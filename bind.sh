
dotnet tool restore
dotnet cake "$@"
dotnet clean ./src/libs/BindingHost/BindingHost.csproj
dotnet restore ./src/libs/BindingHost/BindingHost.csproj
dotnet run --project ./src/libs/BindingHost/BindingHost.csproj -- --base-path=$PWD "$@"