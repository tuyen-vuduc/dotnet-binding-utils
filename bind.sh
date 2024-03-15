
dotnet tool restore
dotnet cake "$@"
dotnet run --project ./src/libs/BindingHost/BindingHost.csproj -- --base-path=$PWD "$@"