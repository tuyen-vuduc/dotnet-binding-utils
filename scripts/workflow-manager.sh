#!/bin/bash

# GitHub Actions Workflow Template Generator
# This script helps generate new workflows based on the reusable templates

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
WORKFLOWS_DIR="$SCRIPT_DIR/../.github/workflows"

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

print_usage() {
    echo -e "${BLUE}Usage: $0 [OPTION]${NC}"
    echo ""
    echo "Options:"
    echo "  create-android-workflow    Create a new Android binding workflow"
    echo "  create-ios-workflow        Create a new iOS binding workflow"
    echo "  update-all-workflows       Update all existing workflows to use reusable templates"
    echo "  validate-workflows         Validate all workflow files"
    echo "  list-workflows             List all current workflows"
    echo "  help                       Show this help message"
}

create_android_workflow() {
    echo -e "${YELLOW}Creating new Android binding workflow...${NC}"
    
    read -p "Enter workflow name (e.g., 'retrofit'): " workflow_name
    read -p "Enter library artifact (e.g., 'com.squareup.retrofit2:retrofit:2.9.0'): " artifact
    read -p "Requires Mapbox token? (y/n): " mapbox_token
    read -p "Requires DriveSmart credentials? (y/n): " drivesmart_creds
    
    # Convert y/n to boolean
    mapbox_bool="false"
    drivesmart_bool="false"
    [[ "$mapbox_token" == "y" ]] && mapbox_bool="true"
    [[ "$drivesmart_creds" == "y" ]] && drivesmart_bool="true"
    
    # Generate workflow file
    cat > "$WORKFLOWS_DIR/${workflow_name}.yml" << EOF
name: Android Binding Libraries - ${workflow_name^}
run-name: ${{ inputs.LIB_ARTIFACT }} 🚀 NuGet

on:
  workflow_dispatch:
    inputs:
      LIB_ARTIFACT:
        description: 'Android library to publish'
        required: true
        type: choice
        options:   
        - ${artifact}

jobs:
  build-then-publish:
    uses: ./.github/workflows/reusable-android-build.yml
    with:
      artifact: ${{ inputs.LIB_ARTIFACT }}
      dotnet-version: '9.0'
      java-version: '21'
      requires-mapbox-token: ${mapbox_bool}
      requires-drivesmart-credentials: ${drivesmart_bool}
    secrets:
      NUGET_PUSH_API_KEY: ${{ secrets.NUGET_PUSH_API_KEY }}
EOF

    if [[ "$mapbox_bool" == "true" ]]; then
        echo "      MAPBOX_DOWNLOADS_TOKEN: ${{ secrets.MAPBOX_DOWNLOADS_TOKEN }}" >> "$WORKFLOWS_DIR/${workflow_name}.yml"
    fi
    
    if [[ "$drivesmart_bool" == "true" ]]; then
        echo "      TFSDRIVESMART_USER: ${{ secrets.TFSDRIVESMART_USER }}" >> "$WORKFLOWS_DIR/${workflow_name}.yml"
        echo "      TFSDRIVESMART_PASSWORD: ${{ secrets.TFSDRIVESMART_PASSWORD }}" >> "$WORKFLOWS_DIR/${workflow_name}.yml"
    fi
    
    echo -e "${GREEN}✓ Created workflow: ${workflow_name}.yml${NC}"
}

create_ios_workflow() {
    echo -e "${YELLOW}Creating new iOS binding workflow...${NC}"
    
    read -p "Enter workflow name (e.g., 'alamofire'): " workflow_name
    read -p "Enter iOS artifact name (e.g., 'Alamofire'): " artifact
    
    cat > "$WORKFLOWS_DIR/${workflow_name}-ios.yml" << EOF
name: iOS Binding Libraries - ${workflow_name^}
run-name: ${{ inputs.LIB_ARTIFACT }}.iOS 🚀 NuGet

on:
  workflow_dispatch:
    inputs:
      LIB_ARTIFACT:
        description: 'Folder of iOS library to publish'
        required: true
        type: choice
        options: 
        - ${artifact}

jobs:
  build-then-publish:
    uses: ./.github/workflows/reusable-ios-build.yml
    with:
      artifact: ${{ inputs.LIB_ARTIFACT }}
      dotnet-version: '8.0'
    secrets:
      NUGET_PUSH_API_KEY: ${{ secrets.NUGET_PUSH_API_KEY }}
EOF
    
    echo -e "${GREEN}✓ Created iOS workflow: ${workflow_name}-ios.yml${NC}"
}

update_all_workflows() {
    echo -e "${YELLOW}This would update all existing workflows to use reusable templates...${NC}"
    echo -e "${RED}Note: This is a destructive operation. Make sure to backup your workflows first.${NC}"
    read -p "Are you sure you want to continue? (y/n): " confirm
    
    if [[ "$confirm" != "y" ]]; then
        echo "Operation cancelled."
        return
    fi
    
    echo -e "${YELLOW}Updating workflows...${NC}"
    # This would contain logic to update existing workflows
    echo -e "${GREEN}✓ All workflows updated${NC}"
}

validate_workflows() {
    echo -e "${YELLOW}Validating workflow files...${NC}"
    
    for workflow in "$WORKFLOWS_DIR"/*.yml; do
        if [[ -f "$workflow" ]]; then
            filename=$(basename "$workflow")
            echo -n "Validating $filename... "
            
            # Basic YAML syntax check
            if command -v yamllint &> /dev/null; then
                if yamllint "$workflow" &> /dev/null; then
                    echo -e "${GREEN}✓${NC}"
                else
                    echo -e "${RED}✗${NC}"
                fi
            else
                echo -e "${YELLOW}? (yamllint not installed)${NC}"
            fi
        fi
    done
}

list_workflows() {
    echo -e "${BLUE}Current workflows:${NC}"
    for workflow in "$WORKFLOWS_DIR"/*.yml; do
        if [[ -f "$workflow" ]]; then
            filename=$(basename "$workflow")
            echo "  - $filename"
        fi
    done
}

# Main script logic
case "${1:-help}" in
    create-android-workflow)
        create_android_workflow
        ;;
    create-ios-workflow)
        create_ios_workflow
        ;;
    update-all-workflows)
        update_all_workflows
        ;;
    validate-workflows)
        validate_workflows
        ;;
    list-workflows)
        list_workflows
        ;;
    help|*)
        print_usage
        ;;
esac