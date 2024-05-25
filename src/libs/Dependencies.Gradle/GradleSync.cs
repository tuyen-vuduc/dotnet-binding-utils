﻿using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Build.Framework;
using Xamarin.Build.Download;
using Xamarin.Components.Ide.Activation;
using Xamarin.MacDev;

namespace Dependencies.Gradle;

public class GradleSync : AsyncTask, Xamarin.Build.Download.ILogger
{
    const int ExclusiveLockTimeout = 60;

    public ITaskItem[] Repositories { get; set; }

    public ITaskItem[] Implementations { get; set; }

    public ITaskItem[] GradleProperties { get; set; }

    public string VsInstallRoot { get; set; }
    public string User7ZipPath { get; set; }
    public string GradleAssetsPath { get; set; }
    public string TempDir { get; set; }
    public bool IsAndroid { get; set; }
    public bool EnableJetifier { get; set; }
    public string AndroidSdkPath { get; set; }
    public string AndroidMinSdkVersion { get; set; }
    public string AndroidTargetSdkVersion { get; set; }

    public override bool Execute()
    {
        var implementations = ParseImplementations(Implementations);

        if (implementations.Length == 0)
        {
            LogMessage("No dependencies!");
            return true;
        }

        Task.Run(async () =>
        {
            var md5 = MD5Hash(string.Join(",", implementations.Select(x => x.Id).OrderBy(x => x)));
            var md5File = Path.Combine(TempDir, ".md5");

            if (File.Exists(md5File))
            {
                var lastMd5 = File.ReadAllText(md5File);
                if (lastMd5 == md5)
                {
                    Complete();
                    return;
                }
            }

            try
            {
                LogMessage("GradleSyncTempDir: " + TempDir);
                try
                {
                    if(Directory.Exists(TempDir))
                    {
                        Directory.Delete(TempDir, true);
                    }

                    Directory.CreateDirectory(TempDir);
                }
                catch (Exception ex)
                {
                    LogCodedError(
                        ErrorCodes.DirectoryCreateFailed,
                        string.Format("Failed to create directory '{0}'.", TempDir)
                    );
                    LogMessage("Directory creation failure reason: " + ex.ToString(), MessageImportance.High);
                    return;
                }

                var unpacked = await MakeSureLibraryIsInPlace(Token);

                if (!unpacked)
                {
                    return;
                }

                OverrideLocalProperties();

                AddRepositories();

                AdjustSdkVersions();

                AdjustGradleProperties();

                AddDependencies(implementations);

                await ExecuteGradleBuild();

                File.WriteAllText(md5File, md5);
            }
            catch (Exception ex)
            {
                LogErrorFromException(ex);
            }
            finally
            {
                Complete();
            }
        });

        var result = base.Execute();

        return result && !Log.HasLoggedErrors;
    }

    async Task<bool> ExecuteGradleBuild()
    {
        var processPath = Platform.IsWindows
            ? Path.Combine(TempDir, "gradlew.bat")
            : Path.Combine(TempDir, "gradlew");
        ProcessArgumentBuilder args = new ProcessArgumentBuilder(processPath);
        args.Add("build");

        ProcessStartInfo psi = new ProcessStartInfo(args.ProcessPath, args.ToString())
            {
                WorkingDirectory = TempDir,
                CreateNoWindow = true,
                UseShellExecute = false
            };

        try
        {
            LogMessage("Exec gradlew build {0} --> {1}", processPath, TempDir);
            var output = new StringWriter();
            int returnCode = await ProcessUtils.StartProcess(psi, output, output, Token);
            if (returnCode == 0)
            {
                return true;
            }

            LogCodedError(
                ErrorCodes.GradleBuildFailed,
                string.Format(
                    "Gradlew build failed {0} --> {1}", processPath, TempDir)
            );

            LogMessage("Unpacking failure reason: " + output.ToString(), MessageImportance.High);
        }
        catch (Exception ex)
        {
            LogErrorFromException(ex);
        }

        return false;
    }

    private void AdjustGradleProperties()
    {
        var gradleSyncPath = Path.Combine(TempDir, "gradle.properties");
        var gradleSyncContent = File.ReadAllText(gradleSyncPath);
        LogMessage(gradleSyncContent, MessageImportance.Normal);

        if (EnableJetifier)
        {
            gradleSyncContent += @"

# Automatically convert third-party libraries to use AndroidX
android.enableJetifier=true
            ";
        }

        File.WriteAllText(gradleSyncPath, gradleSyncContent);
        LogMessage(gradleSyncContent, MessageImportance.Normal);
    }

    private void AdjustSdkVersions()
    {
        var GradleSyncPath = Path.Combine(TempDir, "gradle_util/build.gradle.kts");
        var GradleSyncContent = File.ReadAllText(GradleSyncPath);
        LogMessage(GradleSyncContent, MessageImportance.Normal);

        if (!string.IsNullOrWhiteSpace(AndroidMinSdkVersion))
        {
            GradleSyncContent = GradleSyncContent.Replace(
                "minSdk 26",
                $"minSdk {AndroidMinSdkVersion}"
                );
        }

        if (!string.IsNullOrWhiteSpace(AndroidTargetSdkVersion))
        {
            GradleSyncContent = GradleSyncContent.Replace(
                "targetSdk 34",
                $"targetSdk {AndroidTargetSdkVersion}"
                );
            GradleSyncContent = GradleSyncContent.Replace(
                "compileSdk 34",
                $"compileSdk {AndroidTargetSdkVersion}"
                );
        }

        File.WriteAllText(GradleSyncPath, GradleSyncContent);
        LogMessage(GradleSyncContent, MessageImportance.Normal);
    }

    private void AddDependencies(GradleImplementation[] implementations)
    {
        var repositoriesStringBuilder = new StringBuilder(Environment.NewLine);

        for (int i = 0; i < implementations.Length; i++)
        {
            repositoriesStringBuilder.AppendLine(implementations[i].Implemetation);
        }

        var GradleSyncPath = Path.Combine(TempDir, "gradle_util/build.gradle.kts");
        var defaultGradleSyncContent = File.ReadAllText(GradleSyncPath);
        LogMessage(defaultGradleSyncContent);

        const string DependenciesSectionStart = "dependencies {";
        var indexOfDependenciesSectionStart = defaultGradleSyncContent.LastIndexOf(DependenciesSectionStart);
        var insertionPosition = indexOfDependenciesSectionStart + DependenciesSectionStart.Length;

        var adjustedGradleSyncContent = defaultGradleSyncContent.Insert(
            insertionPosition,
            repositoriesStringBuilder.ToString()
        );
        File.WriteAllText(GradleSyncPath, adjustedGradleSyncContent);
        LogMessage(adjustedGradleSyncContent);
    }

    private void AddRepositories()
    {
        var repositories = ParseRepositories(Repositories);
        var repositoriesStringBuilder = new StringBuilder(Environment.NewLine);

        for (int i = 0; i < repositories.Length; i++)
        {
            repositoriesStringBuilder.AppendLine(repositories[i].Repository);
        }

        var settingsGradlePath = Path.Combine(TempDir, "settings.gradle.kts");
        var defaultSettingsGradleContent = File.ReadAllText(settingsGradlePath);
        LogMessage(defaultSettingsGradleContent);

        const string LastDefaultDependency = "mavenCentral()";
        var indexOfLastDefaultDependency = defaultSettingsGradleContent.LastIndexOf(LastDefaultDependency);
        var insertionPosition = indexOfLastDefaultDependency + LastDefaultDependency.Length;

        var adjustedSettingsGradleContent = defaultSettingsGradleContent.Insert(
            insertionPosition,
            repositoriesStringBuilder.ToString()
        );
        File.WriteAllText(settingsGradlePath, adjustedSettingsGradleContent);
        LogMessage(adjustedSettingsGradleContent);
    }

    private void OverrideLocalProperties()
    {
        var gradleProperties = ParseGradleProperties(GradleProperties);

        var graldePropertiesStringBuilder = new StringBuilder();
        var nomarlizedAndroidSdkPath = Platform.IsWindows
            ? AndroidSdkPath.Replace("\\", "/")
            : AndroidSdkPath;
        graldePropertiesStringBuilder.AppendLine($"sdk.dir={nomarlizedAndroidSdkPath}");

        for (int i = 0; i < gradleProperties.Length; i++)
        {
            var propertyLine = $"{gradleProperties[i].Id}={gradleProperties[i].Value}";

            graldePropertiesStringBuilder.AppendLine(propertyLine);
        }

        var gradleLocalPropertiesPath = Path.Combine(TempDir, "local.properties");
        var localProperties = graldePropertiesStringBuilder.ToString();
        File.WriteAllText(gradleLocalPropertiesPath, localProperties);
        LogMessage(localProperties);
    }

    async Task<bool> MakeSureLibraryIsInPlace(CancellationToken token)
    {
        if (!File.Exists(GradleAssetsPath))
        {
            LogCodedError(
                ErrorCodes.GradleAssetsFileMissing,
                string.Format("Packed gradle assets is missing '{0}'.", GradleAssetsPath)
            );
            return false;
        }

        // Skip extraction if the file is already in place
        var flagFile = TempDir + "/.unpacked";
        if (File.Exists(flagFile))
            return true;

        var lockFile = TempDir + "/.locked";
        using (var lockStream = DownloadUtils.ObtainExclusiveFileLock(lockFile, Token, TimeSpan.FromSeconds(ExclusiveLockTimeout), this))
        {
            if (lockStream == null)
            {
                LogCodedError(ErrorCodes.ExclusiveLockTimeout, "Timed out waiting for exclusive file lock on: {0}", lockFile);
                LogMessage("Timed out waiting for an exclusive file lock on: " + lockFile, MessageImportance.High);
                return false;
            }

            // Check flag again in case someone else downloaded this while we were waiting for the lock
            if (File.Exists(flagFile))
                return true;

            if (await ExtractArchive(flagFile, token))
            {
                File.WriteAllText(flagFile, "This marks that the extraction completed successfully");
                return true;
            }
        }

        // We will attempt to delete the lock file when we're done
        try
        {
            if (File.Exists(lockFile))
                File.Delete(lockFile);
        }
        catch (Exception e)
        {
            LogMessage("Exception on deleting lockFile: {0}\n{0}", lockFile, e.Message);
        }

        return false;
    }

    private GradleProperty[] ParseGradleProperties(ITaskItem[] taskItems)
    {
        if (taskItems == null || taskItems.Length == 0) return new GradleProperty[0];

        var gradleProperties = new List<GradleProperty>();

        for (int i = 0; i < taskItems.Length; i++)
        {
            var taskItem = taskItems[i];
            var kvp = new GradleProperty
            {
                Id = taskItem.ItemSpec,
                Value = taskItem.GetMetadata("Value")
            };
            gradleProperties.Add(kvp);
        }

        return gradleProperties.ToArray();
    }

    private GradleRepository[] ParseRepositories(ITaskItem[] taskItems)
    {
        if (taskItems == null || taskItems.Length == 0) return new GradleRepository[0];

        var repositories = new List<GradleRepository>();

        for (int i = 0; i < taskItems.Length; i++)
        {
            var taskItem = taskItems[i];
            var repository = new GradleRepository
            {
                Id = taskItem.ItemSpec,
                Repository = taskItem.GetMetadata("Repository"),

            };
            repositories.Add(repository);
        }

        return repositories.ToArray();
    }

    private GradleImplementation[] ParseImplementations(ITaskItem[] taskItems)
    {
        if (taskItems == null || taskItems.Length == 0) return new GradleImplementation[0];

        var implementations = new List<GradleImplementation>();

        for (int i = 0; i < taskItems.Length; i++)
        {
            var taskItem = taskItems[i];

            var implementationDeclaration = taskItem.GetMetadata("Implementation");
            if (string.IsNullOrWhiteSpace(implementationDeclaration))
            {
                implementationDeclaration = $"implementation(\"{taskItem.ItemSpec}\")";
            }

            var implementation = new GradleImplementation
            {
                Id = taskItem.ItemSpec,
                Implemetation = implementationDeclaration,
            };

            implementations.Add(implementation);
        }

        return implementations.ToArray();
    }

    async Task<bool> ExtractArchive(string flagFile, CancellationToken token)
    {
        ProcessStartInfo psi = CreateExtractionArgs(GradleAssetsPath, TempDir, VsInstallRoot);

        try
        {
            LogMessage("Extracting {0} to {1}", GradleAssetsPath, TempDir);
            var output = new StringWriter();
            int returnCode = await ProcessUtils.StartProcess(psi, output, output, token);
            if (returnCode == 0)
            {
                return true;
            }

            LogCodedError(
                ErrorCodes.ExtractionFailed,
                string.Format(
                    "Unpacking failed. Please download '{0}' and extract it to the '{1}' directory " +
                    "and create an empty file called '{2}'.", GradleAssetsPath, TempDir, flagFile)
            );

            LogMessage("Unpacking failure reason: " + output.ToString(), MessageImportance.High);
        }
        catch (Exception ex)
        {
            LogErrorFromException(ex);
        }

        //something went wrong, clean up so we try again next time
        try
        {
            Directory.Delete(TempDir, true);
        }
        catch (Exception ex)
        {
            LogCodedError(ErrorCodes.DirectoryDeleteFailed, "Failed to delete directory '{0}'.", TempDir);
            LogErrorFromException(ex);
        }
        return false;
    }

    ProcessStartInfo CreateExtractionArgs(string file, string contentDir, string vsInstallRoot, bool ignoreTarSymLinks = false)
    {
        ProcessArgumentBuilder args = Platform.IsWindows
            ? Build7ZipExtractionArgs(file, contentDir, User7ZipPath, false, vsInstallRoot)
            : BuildZipExtractionArgs(file, contentDir);

        ProcessStartInfo psi = Platform.IsWindows
            ? new ProcessStartInfo(args.ProcessPath, args.ToString())
            {
                WorkingDirectory = null,
                CreateNoWindow = true
            }
            : new ProcessStartInfo(args.ProcessPath, args.ToString())
            {
                WorkingDirectory = contentDir,
                CreateNoWindow = true
            };

        return psi;
    }

    static string Get7ZipPath(string user7ZipPath, string vsInstallRoot)
    {
        if (!string.IsNullOrEmpty(user7ZipPath) && File.Exists(user7ZipPath))
            return user7ZipPath;

        var path7z = VS7ZipLocator.Locate7Zip(vsInstallRoot);

        if (string.IsNullOrEmpty(path7z))
            throw new Exception("Could not find 7zip.exe in Xamarin installation");

        return path7z;
    }

    static ProcessArgumentBuilder Build7ZipExtractionArgs(string file, string contentDir, string user7ZipPath, bool ignoreTarSymLinks, string vsInstallRoot)
    {
        var args = new ProcessArgumentBuilder(Get7ZipPath(user7ZipPath, vsInstallRoot));
        //if it's a tgz, we have a two-step extraction. for the gzipped layer, extract without paths
        if (file.EndsWith(".gz", StringComparison.OrdinalIgnoreCase) || file.EndsWith(".tgz", StringComparison.OrdinalIgnoreCase))
            args.Add("e");
        else
            args.Add("x");

        // Symbolic Links give us problems.  You need to run as admin to extract them.
        // Adding this flag will ignore links
        if (ignoreTarSymLinks)
            args.Add("-snl-");

        args.AddQuoted("-o" + contentDir);
        args.AddQuoted(file);
        return args;
    }

    static ProcessArgumentBuilder BuildZipExtractionArgs(string file, string contentDir)
    {
        var args = new ProcessArgumentBuilder("/usr/bin/unzip");
        args.Add("-o", "-q");
        args.AddQuoted(file);
        return args;
    }

    static string MD5Hash(string input)
    {
        StringBuilder hash = new StringBuilder();
        MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
        byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

        for (int i = 0; i < bytes.Length; i++)
        {
            hash.Append(bytes[i].ToString("x2"));
        }
        return hash.ToString();
    }
}
