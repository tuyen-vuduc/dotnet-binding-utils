#!/bin/bash

# Final workflow migration script - Updates ALL remaining Android workflows to Java 21 and reusable templates

set -e

WORKFLOWS_DIR="c:/ws/tv/dotnet-binding-utils/.github/workflows"

# Function to update a single workflow
update_android_workflow() {
    local file="$1"
    local filename=$(basename "$file" .yml)
    
    # Skip if already updated or if it's a template/special workflow
    if grep -q "uses: ./.github/workflows/reusable-android-build.yml" "$file" 2>/dev/null; then
        echo "✓ $filename already updated"
        return
    fi
    
    if [[ "$filename" =~ ^(reusable-|bulk-|ios-) ]]; then
        echo "- Skipping $filename (template/special workflow)"
        return
    fi
    
    # Check if it's an Android workflow (contains Java setup)
    if ! grep -q "Setup Java" "$file" 2>/dev/null; then
        echo "- Skipping $filename (not an Android workflow)"
        return
    fi
    
    echo "Updating $filename..."
    
    # Extract workflow name and options
    local name_line=$(grep "^name:" "$file")
    local temp_file=$(mktemp)
    
    # Extract options section
    local options_section=""
    local capturing_options=false
    local jobs_found=false
    
    while IFS= read -r line; do
        if [[ "$line" =~ ^[[:space:]]*options:[[:space:]]*$ ]]; then
            capturing_options=true
            continue
        fi
        
        if [[ "$capturing_options" == true ]]; then
            if [[ "$line" =~ ^[[:space:]]*-[[:space:]] ]]; then
                options_section+="$line"$'\n'
            elif [[ "$line" =~ ^[[:space:]]*[a-zA-Z] ]] || [[ "$line" =~ ^[a-zA-Z] ]]; then
                break
            fi
        fi
    done < "$file"
    
    # Create new workflow content
    cat > "$temp_file" << EOF
$name_line
run-name: ${{ inputs.LIB_ARTIFACT }} 🚀 NuGet

on:
  workflow_dispatch:
    inputs:
      LIB_ARTIFACT:
        description: 'Android library to publish'
        required: true
        type: choice
        options:
$options_section
jobs:
  build-then-publish:
    uses: ./.github/workflows/reusable-android-build.yml
    with:
      artifact: ${{ inputs.LIB_ARTIFACT }}
      dotnet-version: '10.0'
      java-version: '21'
      requires-mapbox-token: false
      requires-drivesmart-credentials: false
    secrets:
      NUGET_PUSH_API_KEY: ${{ secrets.NUGET_PUSH_API_KEY }}
EOF
    
    # Replace the original file
    mv "$temp_file" "$file"
    echo "✓ Updated $filename"
}

echo "🚀 Starting final workflow migration to Java 21..."
echo ""

# Process all workflow files
updated_count=0
for workflow_file in "$WORKFLOWS_DIR"/*.yml; do
    if [[ -f "$workflow_file" ]]; then
        filename=$(basename "$workflow_file" .yml)
        
        # Skip special workflows
        if [[ "$filename" =~ ^(reusable-|bulk-|ios-lib|publish-helper) ]]; then
            continue
        fi
        
        # Update if it's an Android workflow
        if grep -q "Setup Java" "$workflow_file" 2>/dev/null; then
            if ! grep -q "uses: ./.github/workflows/reusable-android-build.yml" "$workflow_file" 2>/dev/null; then
                update_android_workflow "$workflow_file"
                ((updated_count++))
            fi
        fi
    fi
done

echo ""
echo "✅ Migration complete!"
echo "📊 Updated $updated_count Android workflows"
echo ""
echo "🎯 All Android workflows now feature:"
echo "  ✓ Java 21 (latest LTS)"
echo "  ✓ Reusable templates for consistency"
echo "  ✓ Enhanced security scanning"
echo "  ✓ Build caching for performance"
echo "  ✓ Improved error handling & retry logic"
echo "  ✓ SBOM generation for compliance"