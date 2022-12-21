dotnet nuget locals -c all
dotnet pack -c Release -o nugets dotnet-binding-utils.sln

dotnet build -c Release dependencies.gradle.qs.sln