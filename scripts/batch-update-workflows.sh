#!/bin/bash

# Batch update script for remaining Android workflows

set -e

WORKFLOWS_DIR="c:/ws/tv/dotnet-binding-utils/.github/workflows"
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

# List of workflows to update (excluding already updated ones and reusable templates)
WORKFLOWS_TO_UPDATE=(
    "braintree"
    "coil" 
    "dfu"
    "filament"
    "fresco"
    "intellimec"
    "ktor"
    "mp4parser"
    "paypal"
    "paystack"
    "shakebugs"
    "slf4j"
    "socket-io"
)

update_workflow() {
    local workflow_name="$1"
    local workflow_file="$WORKFLOWS_DIR/${workflow_name}.yml"
    
    if [[ ! -f "$workflow_file" ]]; then
        echo "Warning: $workflow_file not found, skipping..."
        return
    fi
    
    echo "Updating $workflow_name.yml..."
    
    # Extract the display name, artifact options from the original file
    local display_name=$(grep "^name:" "$workflow_file" | sed 's/name: //')
    
    # Read the artifact options from the original file
    local temp_file=$(mktemp)
    local in_options=false
    local artifacts=""
    
    while IFS= read -r line; do
        if [[ "$line" =~ ^[[:space:]]*options:[[:space:]]*$ ]]; then
            in_options=true
            continue
        fi
        
        if [[ "$in_options" == true ]]; then
            if [[ "$line" =~ ^[[:space:]]*-[[:space:]](.+)$ ]]; then
                if [[ -n "$artifacts" ]]; then
                    artifacts+="\n"
                fi
                artifacts+="$line"
            elif [[ "$line" =~ ^[[:space:]]*[a-zA-Z] ]] || [[ "$line" =~ ^[a-zA-Z] ]]; then
                break
            fi
        fi
    done < "$workflow_file"
    
    # Create new workflow content
    cat > "$temp_file" << EOF
$display_name
run-name: ${{ inputs.LIB_ARTIFACT }} 🚀 NuGet

on:
  workflow_dispatch:
    inputs:
      LIB_ARTIFACT:
        description: 'Android library to publish'
        required: true
        type: choice
        options:
$(echo -e "$artifacts")

jobs:
  build-then-publish:
    uses: ./.github/workflows/reusable-android-build.yml
    with:
      artifact: ${{ inputs.LIB_ARTIFACT }}
      dotnet-version: '9.0'
      java-version: '21'
      requires-mapbox-token: false
      requires-drivesmart-credentials: false
    secrets:
      NUGET_PUSH_API_KEY: ${{ secrets.NUGET_PUSH_API_KEY }}
EOF
    
    # Replace the original file
    mv "$temp_file" "$workflow_file"
    echo "✓ Updated $workflow_name.yml"
}

# Update all workflows
for workflow in "${WORKFLOWS_TO_UPDATE[@]}"; do
    update_workflow "$workflow"
done

echo ""
echo "✅ Batch update complete! Updated ${#WORKFLOWS_TO_UPDATE[@]} workflows."
echo "All Android workflows now use:"
echo "  - Reusable template (reusable-android-build.yml)"
echo "  - Java 21"
echo "  - Enhanced security and caching"