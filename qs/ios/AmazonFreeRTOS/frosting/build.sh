
env > env.txt
xcrun xctrace list devices > devices.txt
#! /bin/sh -e
# This script demonstrates archive and create action on frameworks and libraries
# Based on script by @author Boris Bielik

PROJECT_DIR=$1
PROJECT_NAME=$2
DYNAMIC_FRAMEWORK=$3
STATIC=$4
CONFIGURATION=Release
OBJROOT="${PROJECT_DIR}/build"

echo "> PROJECT_DIR       ${PROJECT_DIR}"
echo "> PROJECT_NAME      ${PROJECT_NAME}"
echo "> DYNAMIC_FRAMEWORK ${DYNAMIC_FRAMEWORK}"

# Release dir path
OUTPUT_DIR_PATH="${PROJECT_DIR}/.output"

function archivePathSimulator {
  local DIR=${OUTPUT_DIR_PATH}/archives/"${1}-SIMULATOR"
  echo "${DIR}"
}

function archivePathDevice {
  local DIR=${OUTPUT_DIR_PATH}/archives/"${1}-DEVICE"
  echo "${DIR}"
}

# Archive takes 3 params
#
# 1st == SCHEME
# 2nd == destination
# 3rd == archivePath
function archive {
    echo "▸ Starts archiving the scheme: ${1} for destination: ${2};\n▸ Archive path: ${3}.xcarchive"
    xcodebuild clean archive \
    -project "$PROJECT_DIR/${PROJECT_NAME}.xcodeproj" \
    -scheme ${1} \
    -configuration ${CONFIGURATION} \
    -destination "${2}" \
    -archivePath "${3}" \
    SKIP_INSTALL=NO \
    OBJROOT="${OBJROOT}" \
    BUILD_LIBRARY_FOR_DISTRIBUTION=YES
}

# Builds archive for iOS simulator & device
function buildArchive {
  SCHEME=${1}

  archive $SCHEME "generic/platform=iOS Simulator" $(archivePathSimulator $SCHEME)
  archive $SCHEME "generic/platform=iOS" $(archivePathDevice $SCHEME)
}

# Creates xc framework
function createXCFramework {
  FRAMEWORK_ARCHIVE_PATH_POSTFIX=".xcarchive/Products/Library/Frameworks"
  FRAMEWORK_SIMULATOR_DIR="$(archivePathSimulator $1)${FRAMEWORK_ARCHIVE_PATH_POSTFIX}"
  FRAMEWORK_DEVICE_DIR="$(archivePathDevice $1)${FRAMEWORK_ARCHIVE_PATH_POSTFIX}"

  xcodebuild -create-xcframework \
            -framework ${FRAMEWORK_SIMULATOR_DIR}/${1}.framework \
            -framework ${FRAMEWORK_DEVICE_DIR}/${1}.framework \
            -output ${OUTPUT_DIR_PATH}/${1}.xcframework
}

### Static Libraries cant be turned into frameworks
function createXCFrameworkForStaticLibrary {

  LIBRARY_ARCHIVE_PATH_POSTFIX=".xcarchive/Products/usr/local/lib"
  LIBRARY_SIMULATOR_DIR="$(archivePathSimulator $1)${LIBRARY_ARCHIVE_PATH_POSTFIX}"
  LIBRARY_DEVICE_DIR="$(archivePathDevice $1)${LIBRARY_ARCHIVE_PATH_POSTFIX}"

  xcodebuild -create-xcframework \
            -library ${LIBRARY_SIMULATOR_DIR}/lib${1}.a \
            -headers ${PROJECT_DIR}/Headers/Public/${1} \
            -library ${LIBRARY_DEVICE_DIR}/lib${1}.a \
            -headers ${PROJECT_DIR}/Headers/Public/${1} \
            -output ${OUTPUT_DIR_PATH}/${1}.xcframework
}

echo "#####################"
echo "▸ Cleaning the dir: ${OUTPUT_DIR_PATH}"
rm -rf $OUTPUT_DIR_PATH

if [ $STATIC = 'STATIC' ]
then
  ### Static Library ####
  LIBRARY="${DYNAMIC_FRAMEWORK}"

  echo "▸ Archive $LIBRARY"
  buildArchive ${LIBRARY}

  echo "▸ Create $FRAMEWORK.xcframework"
  createXCFrameworkForStaticLibrary ${LIBRARY}
else
  #### Dynamic Framework ####

  echo "▸ Archive $DYNAMIC_FRAMEWORK"
  buildArchive ${DYNAMIC_FRAMEWORK}

  echo "▸ Create $DYNAMIC_FRAMEWORK.xcframework"
  createXCFramework ${DYNAMIC_FRAMEWORK}
fi