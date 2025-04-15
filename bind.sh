
rm -rf ./src/libs/BindingHost/*.props
rm -rf ./src/libs/BindingHost/bin
rm -rf ./src/libs/BindingHost/obj
# dotnet nuget locals -c all
dotnet tool restore
dotnet clean ./src/libs/BindingHost/BindingHost.csproj

dotnet cake "$@"

# Install Android workload
echo "Install Android workload"
dotnet workload install android wasi-experimental

dotnet restore ./src/libs/BindingHost/BindingHost.csproj
dotnet run --project ./src/libs/BindingHost/BindingHost.csproj \
    --verbosity detailed \
    -- --base-path=$PWD "$@"