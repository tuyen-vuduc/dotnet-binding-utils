lipo Carthage/Checkouts/sdk-ios/iZettleSDK/iZettlePayments.xcframework/ios-arm64_armv7/iZettlePayments.framework/iZettlePayments -thin arm64 -output ./iZettlePayments-arm64
lipo Carthage/Checkouts/sdk-ios/iZettleSDK/iZettlePayments.xcframework/ios-arm64_x86_64-simulator/iZettlePayments.framework/iZettlePayments -thin x86_64 -output ./iZettlePayments-x86_64
lipo -create iZettlePayments-arm64 iZettlePayments-x86_64 -output iZettlePayments

rm -rf frameworks/iZettlePayments.framework
mv -f Carthage/Checkouts/sdk-ios/iZettleSDK/iZettlePayments.xcframework/ios-arm64_armv7/iZettlePayments.framework frameworks
mv -f iZettlePayments frameworks/iZettlePayments.framework

rm -f iZettlePayments-arm64
rm -f iZettlePayments-x86_64

lipo Carthage/Checkouts/sdk-ios/iZettleSDK/iZettleSDK.xcframework/ios-arm64_armv7/iZettleSDK.framework/iZettleSDK -thin arm64 -output ./iZettleSDK-arm64
lipo Carthage/Checkouts/sdk-ios/iZettleSDK/iZettleSDK.xcframework/ios-arm64_x86_64-simulator/iZettleSDK.framework/iZettleSDK -thin x86_64 -output ./iZettleSDK-x86_64
lipo -create iZettleSDK-arm64 iZettleSDK-x86_64 -output iZettleSDK

rm -rf frameworks/iZettleSDK.framework
mv -f Carthage/Checkouts/sdk-ios/iZettleSDK/iZettleSDK.xcframework/ios-arm64_armv7/iZettleSDK.framework frameworks
mv -f iZettleSDK frameworks/iZettleSDK.framework

rm -f iZettleSDK-arm64
rm -f iZettleSDK-x86_64