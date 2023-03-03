echo $PWD

dotnet run --project ./frosting/Build.csproj -- "$@"

ls ./nugets
