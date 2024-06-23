framework=$1
cls=$2

echo "$framework $cls"

nm -m "/Volumes/ws/tv/dotnet-binding-utils/src/ios/Stripe/adapters/StripePaymentsheetObjC/Carthage/Build/StripePayments.xcframework/ios-arm64/StripePayments.framework/StripePayments" \
 | grep "_OBJC_CLASS_\$_TtC14StripePayments35STPIntentActionAlipayHandleRedirect"