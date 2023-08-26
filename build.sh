dotnet nuget locals -c all
dotnet pack -c Release -o nugets src/Dependencies.Gradle/Dependencies.Gradle.csproj

# dotnet build -c Release dependencies.gradle.qs.sln