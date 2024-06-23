# https://stackoverflow.com/questions/64645642/xcframework-with-pods-dependencies
rm -rf ./.build


xcodebuild archive \
    -project "StripePaymentsheetObjC/StripePaymentsheetObjC.xcodeproj" \
    -scheme TVStripePaymentSheet \
    -archivePath ./.build/TVStripePaymentSheet-iphonesimulator.xcarchive \
    -sdk iphonesimulator \
    SKIP_INSTALL=NO \
    BUILD_LIBRARY_FOR_DISTRIBUTION=YES

 xcodebuild archive \
    -project "StripePaymentsheetObjC/StripePaymentsheetObjC.xcodeproj" \
    -scheme TVStripePaymentSheet \
    -archivePath ./.build/TVStripePaymentSheet-iphoneos.xcarchive \
    -sdk iphoneos \
    SKIP_INSTALL=NO \
    BUILD_LIBRARY_FOR_DISTRIBUTION=YES

rm -rf ../artifacts/TVStripePaymentSheet.xcframework
xcodebuild -create-xcframework \
    -framework ./.build/TVStripePaymentSheet-iphonesimulator.xcarchive/Products/Library/Frameworks/TVStripePaymentSheet.framework \
    -framework ./.build/TVStripePaymentSheet-iphoneos.xcarchive/Products/Library/Frameworks/TVStripePaymentSheet.framework \
    -output ../artifacts/TVStripePaymentSheet.xcframework