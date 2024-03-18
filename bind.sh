
dotnet tool restore
dotnet cake "$@"
dotnet clean --project ./src/libs/BindingHost/BindingHost.csproj
dotnet run --project ./src/libs/BindingHost/BindingHost.csproj -- --base-path=$PWD "$@"