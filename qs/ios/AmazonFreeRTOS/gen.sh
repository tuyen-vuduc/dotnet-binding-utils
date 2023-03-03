#!/bin/bash

export SDK=iphoneos

function bind {
    echo "$1 artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/"

    if [ $3 == '1' ]
    then
        sharpie bind --sdk=$SDK \
            --output="source/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2.h"
    elif [ $3 == '2' ]
    then
        sharpie bind --sdk=$SDK \
            --output="source/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2.h"
    else
        sharpie bind --sdk=$SDK \
            --output="source/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2-Swift.h"
    fi
}

bind AmazonFreeRTOS AmazonFreeRTOS 3
bind AWSCore AWSCore 1
bind AWSIoT AWSIoT 1
bind CBORCoding CBORCoding 3
bind Half Half 3