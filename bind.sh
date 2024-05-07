
rm -rf ./src/libs/BindingHost/*.props
if [[ $3 == "--dotnet" ]] && [[ $4 == 8.* ]] ;
then
    echo "DOTNET8"
    cp global.8.json global.json
else
    echo "DOTNET7 and below"
    cp global.7.json global.json
fi

echo "Install Android workload"
dotnet workload install android

echo "Main steps"
dotnet tool restore
dotnet cake "$@"
dotnet clean ./src/libs/BindingHost/BindingHost.csproj
dotnet restore ./src/libs/BindingHost/BindingHost.csproj
dotnet run --project ./src/libs/BindingHost/BindingHost.csproj -- --base-path=$PWD "$@"