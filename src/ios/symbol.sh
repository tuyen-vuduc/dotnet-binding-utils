framework=$1
cls=$2

echo "$framework $cls"

nm -m "$framework/artifacts/$framework.xcframework/ios-arm64/$framework.framework/$framework" \
 | grep "_OBJC_CLASS_\$_$cls"