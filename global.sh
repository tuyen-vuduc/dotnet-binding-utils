if [[ $1 == 8.* ]] ;
then
    echo "DOTNET8"
    cp _xlobal.8.json global.json
else
    echo "DOTNET7 and below"
    cp _xlobal.7.json global.json
fi

echo "Install Android workload"
dotnet workload install android