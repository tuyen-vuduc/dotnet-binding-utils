dirs=(artifacts/*/) 
find=".xcframework"
replace=""

for dir in "${dirs[@]}"
do
    dirName="$(basename $dir)"
    frameworkName=${dirName//$find/$replace}
    echo $dir $frameworkName

    sharpie bind \
        --output $frameworkName.iOS \
        --namespace $frameworkName \
        --sdk iphoneos17.4 \
        -scope $dir/ios-arm64/$frameworkName.framework/Headers \
            $dir/ios-arm64/$frameworkName.framework/Headers/*.h
done