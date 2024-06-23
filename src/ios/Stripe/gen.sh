dirs=(artifacts/*/) 
find=".xcframework"
replace=""

for dir in "${dirs[@]}"
do
    dirName="$(basename $dir)"
    frameworkName=${dirName//$find/$replace}
    echo $dir $frameworkName

    # if [[ "$frameworkName" != "TVStripePaymentSheet" ]]; then
    #  continue
    # fi

    sharpie bind \
        --output $frameworkName.iOS \
        --namespace $frameworkName \
        --sdk iphoneos \
        -scope $dir/ios-arm64/$frameworkName.framework/Headers \
            $dir/ios-arm64/$frameworkName.framework/Headers/*.h
done

# Issue referencing another framework 
# https://github.com/xamarin/XamarinComponents/issues/735

# Issue with maccatalyst_app_extension
# https://github.com/xamarin/xamarin-macios/issues/18098