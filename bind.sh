
rm -rf ./src/libs/BindingHost/*.props
dotnet tool restore
dotnet clean ./src/libs/BindingHost/BindingHost.csproj

dotnet cake "$@"

# Install Android workload
echo "Install Android workload"
dotnet workload install android

dotnet restore ./src/libs/BindingHost/BindingHost.csproj
dotnet run --project ./src/libs/BindingHost/BindingHost.csproj -- --base-path=$PWD "$@"