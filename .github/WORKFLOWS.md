# GitHub Actions Workflow System

This document describes the enhanced GitHub Actions workflow system for building and publishing .NET binding libraries.

## 🚀 Overview

The workflow system has been modernized with the following improvements:

- **Reusable Workflows**: Centralized templates for Android and iOS builds
- **Enhanced Security**: Updated actions, dependency scanning, and SBOM generation
- **Performance Optimization**: Build caching and parallel processing
- **Better Error Handling**: Retry mechanisms and comprehensive logging
- **Quality Gates**: Package validation and size checks

## 📁 Workflow Structure

```
.github/workflows/
├── reusable-android-build.yml     # Reusable Android build template
├── reusable-ios-build.yml         # Reusable iOS build template
├── bulk-android-build.yml         # Bulk processing workflow
├── stripe.yml                     # Stripe-specific Android libraries
├── mapbox.yml                     # Mapbox-specific Android libraries
├── accompanist.yml                # Accompanist Android libraries
├── ios-lib.yml                    # iOS library builds
└── publish-helper-lib.yml         # Helper library publishing
```

## 🔧 Reusable Workflows

### Android Build Template (`reusable-android-build.yml`)

**Features:**
- Configurable .NET and Java versions
- Conditional Mapbox and DriveSmart credential setup
- Build caching for NuGet and Gradle dependencies
- Security scanning with dependency checks
- SBOM (Software Bill of Materials) generation
- Retry mechanism for build failures
- Comprehensive logging and error handling

**Inputs:**
- `artifact`: Android library artifact to build (required)
- `dotnet-version`: .NET version (default: '9.0')
- `java-version`: Java version (default: '21')
- `requires-mapbox-token`: Boolean for Mapbox token requirement
- `requires-drivesmart-credentials`: Boolean for DriveSmart credentials
- `runner-os`: OS for the runner (default: 'macos-latest')

**Secrets:**
- `NUGET_PUSH_API_KEY`: Required for NuGet publishing
- `MAPBOX_DOWNLOADS_TOKEN`: Optional, for Mapbox libraries
- `TFSDRIVESMART_USER`: Optional, for DriveSmart libraries
- `TFSDRIVESMART_PASSWORD`: Optional, for DriveSmart libraries

### iOS Build Template (`reusable-ios-build.yml`)

**Features:**
- iOS workload installation
- Build caching optimized for iOS projects
- SBOM generation for iOS packages
- Comprehensive error handling and logging

**Inputs:**
- `artifact`: iOS library artifact to build (required)
- `dotnet-version`: .NET version (default: '8.0')
- `runner-os`: OS for the runner (default: 'macos-latest')

## 📋 Individual Workflows

### Stripe Libraries (`stripe.yml`)
Builds Stripe Android SDK components:
- stripe-core, stripe-ui-core, payments-model
- stripe-3ds2-android, payments-core, payments-ui-core
- link, paymentsheet, stripe-android
- stripeterminal components

### Mapbox Libraries (`mapbox.yml`)
Builds Mapbox mapping libraries:
- com.mapbox.maps:android-ndk27:11.15.2
- Requires Mapbox downloads token

### Accompanist Libraries (`accompanist.yml`)
Builds Google Accompanist theme adapters:
- accompanist-themeadapter-core
- accompanist-themeadapter-appcompat
- accompanist-themeadapter-material
- accompanist-themeadapter-material3

### iOS Libraries (`ios-lib.yml`)
Builds iOS binding libraries:
- Shake
- Stripe

## 🔄 Bulk Processing

### Bulk Android Build (`bulk-android-build.yml`)

Allows building multiple Android libraries in parallel:

**Usage:**
1. Go to Actions → Bulk Android Library Build
2. Enter comma-separated list of artifacts
3. Configure parallel job count (default: 3)
4. Run workflow

**Example Input:**
```
com.google.accompanist:accompanist-themeadapter-core:0.34.0,com.stripe:stripe-core:21.3.1,com.mapbox.maps:android-ndk27:11.15.2
```

Note: All Android workflows now use Java 21 by default for better performance and compatibility.

## 🛠️ Management Tools

### Workflow Manager Script (`scripts/workflow-manager.sh`)

A command-line tool for managing workflows:

```bash
# Create new Android workflow
./scripts/workflow-manager.sh create-android-workflow

# Create new iOS workflow  
./scripts/workflow-manager.sh create-ios-workflow

# Validate all workflows
./scripts/workflow-manager.sh validate-workflows

# List all workflows
./scripts/workflow-manager.sh list-workflows
```

## 🔒 Security Features

### Dependency Scanning
- Automated security scans using Dependency Check
- Fails on high-severity vulnerabilities
- Generates security reports

### SBOM Generation
- Creates Software Bill of Materials for all packages
- Stored as artifacts for compliance
- SPDX JSON format

### Secrets Management
- Secure handling of API keys and tokens
- Environment-specific credential setup
- No secrets in logs or outputs

## 📊 Monitoring & Reporting

### Build Summaries
Each workflow generates detailed summaries including:
- Build status and artifact information
- Package creation details
- Error logs and diagnostics
- Performance metrics

### Artifacts
- Build logs (retained for 7 days)
- SBOM files (retained for 30 days)
- Error diagnostics on failures

## 🚀 Performance Optimizations

### Caching Strategy
- **NuGet packages**: Cached by project files hash
- **Gradle dependencies**: Cached by Gradle files hash
- **Separate caches**: For Android, iOS, and helper builds

### Build Optimization
- Parallel job processing (configurable)
- Retry mechanisms for transient failures
- Timeout management (60 minutes max)
- Efficient artifact validation

## 🐛 Troubleshooting

### Common Issues

**Build Failures:**
1. Check build logs artifact
2. Verify dependency versions
3. Check for CVE issues in security scan
4. Validate artifact names and versions

**Authentication Issues:**
1. Verify secrets are set in repository settings
2. Check token permissions and expiration
3. Ensure environment access permissions

**Performance Issues:**
1. Reduce parallel job count
2. Check runner availability
3. Monitor cache hit rates

### Debug Mode
Enable verbose logging by:
1. Adding `ACTIONS_STEP_DEBUG: true` to environment variables
2. Adding `ACTIONS_RUNNER_DEBUG: true` for runner debugging

## 📈 Metrics & Analytics

### Key Performance Indicators
- Build success rate
- Average build time
- Cache hit percentage
- Security scan pass rate
- Package size trends

### Monitoring Dashboards
Use GitHub's built-in workflow analytics or integrate with external monitoring tools to track:
- Build frequency and patterns
- Failure analysis
- Resource utilization
- Security compliance

## 🔄 Migration Guide

### From Legacy Workflows

1. **Backup existing workflows**
2. **Update action versions** to v4 where applicable
3. **Replace with reusable workflow calls**
4. **Test thoroughly** with non-production artifacts
5. **Monitor** first few runs for issues

### Example Migration

**Before:**
```yaml
jobs:
  build-then-publish:
    runs-on: macos-latest
    steps:
    - uses: actions/checkout@v3
    - name: Setup .NET
      uses: actions/setup-dotnet@v3
    # ... many more steps
```

**After:**
```yaml
jobs:
  build-then-publish:
    uses: ./.github/workflows/reusable-android-build.yml
    with:
      artifact: ${{ inputs.LIB_ARTIFACT }}
    secrets:
      NUGET_PUSH_API_KEY: ${{ secrets.NUGET_PUSH_API_KEY }}
```

## 📚 Best Practices

1. **Use reusable workflows** for new library integrations
2. **Test workflows** in feature branches before merging
3. **Monitor build performance** and optimize as needed
4. **Keep secrets secure** and rotate regularly
5. **Review security scans** and address vulnerabilities promptly
6. **Use bulk workflows** for related library updates
7. **Validate packages** before publishing to production

## 🆘 Support

For issues or questions:
1. Check workflow run logs
2. Review troubleshooting section
3. Create GitHub issues with workflow run links
4. Contact DevOps team for infrastructure issues

---

*Last updated: October 2025*