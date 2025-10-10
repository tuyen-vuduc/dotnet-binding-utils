set -e
echo "Clearing local NuGet caches..."
dotnet nuget locals -c all

echo "Restoring packages (will use feeds from nuget.config)..."
dotnet restore src/libs/Dependencies.Gradle/Dependencies.Gradle.csproj

echo "Cleaning project before packing..."
dotnet clean src/libs/Dependencies.Gradle/Dependencies.Gradle.csproj

echo "Packing..."
dotnet pack -c Release -o nugets src/libs/Dependencies.Gradle/Dependencies.Gradle.csproj

# dotnet build -c Release dependencies.gradle.qs.sln