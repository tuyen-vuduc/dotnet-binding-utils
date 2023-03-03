using System;
using AWSIoT;
using Foundation;
using ObjCRuntime;

namespace AWSIoT
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double AWSIoTVersionNumber __attribute__((deprecated("Use AWSIoTSDKVersion instead.")));
		[Field ("AWSIoTVersionNumber", "__Internal")]
		double AWSIoTVersionNumber { get; }

		// extern const unsigned char[] AWSIoTVersionString __attribute__((deprecated("Use AWSIoTSDKVersion instead.")));
		[Field ("AWSIoTVersionString", "__Internal")]
		byte[] AWSIoTVersionString { get; }

		// extern NSString *const _Nonnull AWSIoTErrorDomain;
		[Field ("AWSIoTErrorDomain", "__Internal")]
		NSString AWSIoTErrorDomain { get; }
	}

	// @interface AWSIoTAbortConfig
	interface AWSIoTAbortConfig
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAbortCriteria *> * _Nullable criteriaList;
		[NullAllowed, Export ("criteriaList", ArgumentSemantic.Strong)]
		AWSIoTAbortCriteria[] CriteriaList { get; set; }
	}

	// @interface AWSIoTAbortCriteria
	interface AWSIoTAbortCriteria
	{
		// @property (assign, nonatomic) AWSIoTAbortAction action;
		[Export ("action", ArgumentSemantic.Assign)]
		AWSIoTAbortAction Action { get; set; }

		// @property (assign, nonatomic) AWSIoTJobExecutionFailureType failureType;
		[Export ("failureType", ArgumentSemantic.Assign)]
		AWSIoTJobExecutionFailureType FailureType { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minNumberOfExecutedThings;
		[NullAllowed, Export ("minNumberOfExecutedThings", ArgumentSemantic.Strong)]
		NSNumber MinNumberOfExecutedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable thresholdPercentage;
		[NullAllowed, Export ("thresholdPercentage", ArgumentSemantic.Strong)]
		NSNumber ThresholdPercentage { get; set; }
	}

	// @interface AWSIoTAcceptCertificateTransferRequest
	interface AWSIoTAcceptCertificateTransferRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable setAsActive;
		[NullAllowed, Export ("setAsActive", ArgumentSemantic.Strong)]
		NSNumber SetAsActive { get; set; }
	}

	// @interface AWSIoTAction
	interface AWSIoTAction
	{
		// @property (nonatomic, strong) AWSIoTCloudwatchAlarmAction * _Nullable cloudwatchAlarm;
		[NullAllowed, Export ("cloudwatchAlarm", ArgumentSemantic.Strong)]
		AWSIoTCloudwatchAlarmAction CloudwatchAlarm { get; set; }

		// @property (nonatomic, strong) AWSIoTCloudwatchLogsAction * _Nullable cloudwatchLogs;
		[NullAllowed, Export ("cloudwatchLogs", ArgumentSemantic.Strong)]
		AWSIoTCloudwatchLogsAction CloudwatchLogs { get; set; }

		// @property (nonatomic, strong) AWSIoTCloudwatchMetricAction * _Nullable cloudwatchMetric;
		[NullAllowed, Export ("cloudwatchMetric", ArgumentSemantic.Strong)]
		AWSIoTCloudwatchMetricAction CloudwatchMetric { get; set; }

		// @property (nonatomic, strong) AWSIoTDynamoDBAction * _Nullable dynamoDB;
		[NullAllowed, Export ("dynamoDB", ArgumentSemantic.Strong)]
		AWSIoTDynamoDBAction DynamoDB { get; set; }

		// @property (nonatomic, strong) AWSIoTDynamoDBv2Action * _Nullable dynamoDBv2;
		[NullAllowed, Export ("dynamoDBv2", ArgumentSemantic.Strong)]
		AWSIoTDynamoDBv2Action DynamoDBv2 { get; set; }

		// @property (nonatomic, strong) AWSIoTElasticsearchAction * _Nullable elasticsearch;
		[NullAllowed, Export ("elasticsearch", ArgumentSemantic.Strong)]
		AWSIoTElasticsearchAction Elasticsearch { get; set; }

		// @property (nonatomic, strong) AWSIoTFirehoseAction * _Nullable firehose;
		[NullAllowed, Export ("firehose", ArgumentSemantic.Strong)]
		AWSIoTFirehoseAction Firehose { get; set; }

		// @property (nonatomic, strong) AWSIoTHttpAction * _Nullable http;
		[NullAllowed, Export ("http", ArgumentSemantic.Strong)]
		AWSIoTHttpAction Http { get; set; }

		// @property (nonatomic, strong) AWSIoTIotAnalyticsAction * _Nullable iotAnalytics;
		[NullAllowed, Export ("iotAnalytics", ArgumentSemantic.Strong)]
		AWSIoTIotAnalyticsAction IotAnalytics { get; set; }

		// @property (nonatomic, strong) AWSIoTIotEventsAction * _Nullable iotEvents;
		[NullAllowed, Export ("iotEvents", ArgumentSemantic.Strong)]
		AWSIoTIotEventsAction IotEvents { get; set; }

		// @property (nonatomic, strong) AWSIoTIotSiteWiseAction * _Nullable iotSiteWise;
		[NullAllowed, Export ("iotSiteWise", ArgumentSemantic.Strong)]
		AWSIoTIotSiteWiseAction IotSiteWise { get; set; }

		// @property (nonatomic, strong) AWSIoTKafkaAction * _Nullable kafka;
		[NullAllowed, Export ("kafka", ArgumentSemantic.Strong)]
		AWSIoTKafkaAction Kafka { get; set; }

		// @property (nonatomic, strong) AWSIoTKinesisAction * _Nullable kinesis;
		[NullAllowed, Export ("kinesis", ArgumentSemantic.Strong)]
		AWSIoTKinesisAction Kinesis { get; set; }

		// @property (nonatomic, strong) AWSIoTLambdaAction * _Nullable lambda;
		[NullAllowed, Export ("lambda", ArgumentSemantic.Strong)]
		AWSIoTLambdaAction Lambda { get; set; }

		// @property (nonatomic, strong) AWSIoTLocationAction * _Nullable location;
		[NullAllowed, Export ("location", ArgumentSemantic.Strong)]
		AWSIoTLocationAction Location { get; set; }

		// @property (nonatomic, strong) AWSIoTOpenSearchAction * _Nullable openSearch;
		[NullAllowed, Export ("openSearch", ArgumentSemantic.Strong)]
		AWSIoTOpenSearchAction OpenSearch { get; set; }

		// @property (nonatomic, strong) AWSIoTRepublishAction * _Nullable republish;
		[NullAllowed, Export ("republish", ArgumentSemantic.Strong)]
		AWSIoTRepublishAction Republish { get; set; }

		// @property (nonatomic, strong) AWSIoTS3Action * _Nullable s3;
		[NullAllowed, Export ("s3", ArgumentSemantic.Strong)]
		AWSIoTS3Action S3 { get; set; }

		// @property (nonatomic, strong) AWSIoTSalesforceAction * _Nullable salesforce;
		[NullAllowed, Export ("salesforce", ArgumentSemantic.Strong)]
		AWSIoTSalesforceAction Salesforce { get; set; }

		// @property (nonatomic, strong) AWSIoTSnsAction * _Nullable sns;
		[NullAllowed, Export ("sns", ArgumentSemantic.Strong)]
		AWSIoTSnsAction Sns { get; set; }

		// @property (nonatomic, strong) AWSIoTSqsAction * _Nullable sqs;
		[NullAllowed, Export ("sqs", ArgumentSemantic.Strong)]
		AWSIoTSqsAction Sqs { get; set; }

		// @property (nonatomic, strong) AWSIoTStepFunctionsAction * _Nullable stepFunctions;
		[NullAllowed, Export ("stepFunctions", ArgumentSemantic.Strong)]
		AWSIoTStepFunctionsAction StepFunctions { get; set; }

		// @property (nonatomic, strong) AWSIoTTimestreamAction * _Nullable timestream;
		[NullAllowed, Export ("timestream", ArgumentSemantic.Strong)]
		AWSIoTTimestreamAction Timestream { get; set; }
	}

	// @interface AWSIoTActiveViolation
	interface AWSIoTActiveViolation
	{
		// @property (nonatomic, strong) AWSIoTBehavior * _Nullable behavior;
		[NullAllowed, Export ("behavior", ArgumentSemantic.Strong)]
		AWSIoTBehavior Behavior { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastViolationTime;
		[NullAllowed, Export ("lastViolationTime", ArgumentSemantic.Strong)]
		NSDate LastViolationTime { get; set; }

		// @property (nonatomic, strong) AWSIoTMetricValue * _Nullable lastViolationValue;
		[NullAllowed, Export ("lastViolationValue", ArgumentSemantic.Strong)]
		AWSIoTMetricValue LastViolationValue { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (assign, nonatomic) AWSIoTVerificationState verificationState;
		[Export ("verificationState", ArgumentSemantic.Assign)]
		AWSIoTVerificationState VerificationState { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable verificationStateDescription;
		[NullAllowed, Export ("verificationStateDescription", ArgumentSemantic.Strong)]
		string VerificationStateDescription { get; set; }

		// @property (nonatomic, strong) AWSIoTViolationEventAdditionalInfo * _Nullable violationEventAdditionalInfo;
		[NullAllowed, Export ("violationEventAdditionalInfo", ArgumentSemantic.Strong)]
		AWSIoTViolationEventAdditionalInfo ViolationEventAdditionalInfo { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable violationId;
		[NullAllowed, Export ("violationId", ArgumentSemantic.Strong)]
		string ViolationId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable violationStartTime;
		[NullAllowed, Export ("violationStartTime", ArgumentSemantic.Strong)]
		NSDate ViolationStartTime { get; set; }
	}

	// @interface AWSIoTAddThingToBillingGroupRequest
	interface AWSIoTAddThingToBillingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupArn;
		[NullAllowed, Export ("billingGroupArn", ArgumentSemantic.Strong)]
		string BillingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTAddThingToBillingGroupResponse
	interface AWSIoTAddThingToBillingGroupResponse
	{
	}

	// @interface AWSIoTAddThingToThingGroupRequest
	interface AWSIoTAddThingToThingGroupRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable overrideDynamicGroups;
		[NullAllowed, Export ("overrideDynamicGroups", ArgumentSemantic.Strong)]
		NSNumber OverrideDynamicGroups { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupArn;
		[NullAllowed, Export ("thingGroupArn", ArgumentSemantic.Strong)]
		string ThingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTAddThingToThingGroupResponse
	interface AWSIoTAddThingToThingGroupResponse
	{
	}

	// @interface AWSIoTAddThingsToThingGroupParams
	interface AWSIoTAddThingsToThingGroupParams
	{
		// @property (nonatomic, strong) NSNumber * _Nullable overrideDynamicGroups;
		[NullAllowed, Export ("overrideDynamicGroups", ArgumentSemantic.Strong)]
		NSNumber OverrideDynamicGroups { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable thingGroupNames;
		[NullAllowed, Export ("thingGroupNames", ArgumentSemantic.Strong)]
		string[] ThingGroupNames { get; set; }
	}

	// @interface AWSIoTAggregationType
	interface AWSIoTAggregationType
	{
		// @property (assign, nonatomic) AWSIoTAggregationTypeName name;
		[Export ("name", ArgumentSemantic.Assign)]
		AWSIoTAggregationTypeName Name { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable values;
		[NullAllowed, Export ("values", ArgumentSemantic.Strong)]
		string[] Values { get; set; }
	}

	// @interface AWSIoTAlertTarget
	interface AWSIoTAlertTarget
	{
		// @property (nonatomic, strong) NSString * _Nullable alertTargetArn;
		[NullAllowed, Export ("alertTargetArn", ArgumentSemantic.Strong)]
		string AlertTargetArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTAllowed
	interface AWSIoTAllowed
	{
		// @property (nonatomic, strong) NSArray<AWSIoTPolicy *> * _Nullable policies;
		[NullAllowed, Export ("policies", ArgumentSemantic.Strong)]
		AWSIoTPolicy[] Policies { get; set; }
	}

	// @interface AWSIoTAssetPropertyTimestamp
	interface AWSIoTAssetPropertyTimestamp
	{
		// @property (nonatomic, strong) NSString * _Nullable offsetInNanos;
		[NullAllowed, Export ("offsetInNanos", ArgumentSemantic.Strong)]
		string OffsetInNanos { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable timeInSeconds;
		[NullAllowed, Export ("timeInSeconds", ArgumentSemantic.Strong)]
		string TimeInSeconds { get; set; }
	}

	// @interface AWSIoTAssetPropertyValue
	interface AWSIoTAssetPropertyValue
	{
		// @property (nonatomic, strong) NSString * _Nullable quality;
		[NullAllowed, Export ("quality", ArgumentSemantic.Strong)]
		string Quality { get; set; }

		// @property (nonatomic, strong) AWSIoTAssetPropertyTimestamp * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Strong)]
		AWSIoTAssetPropertyTimestamp Timestamp { get; set; }

		// @property (nonatomic, strong) AWSIoTAssetPropertyVariant * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		AWSIoTAssetPropertyVariant Value { get; set; }
	}

	// @interface AWSIoTAssetPropertyVariant
	interface AWSIoTAssetPropertyVariant
	{
		// @property (nonatomic, strong) NSString * _Nullable booleanValueProperty;
		[NullAllowed, Export ("booleanValueProperty", ArgumentSemantic.Strong)]
		string BooleanValueProperty { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable doubleValueProperty;
		[NullAllowed, Export ("doubleValueProperty", ArgumentSemantic.Strong)]
		string DoubleValueProperty { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable integerValueProperty;
		[NullAllowed, Export ("integerValueProperty", ArgumentSemantic.Strong)]
		string IntegerValueProperty { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable stringValueProperty;
		[NullAllowed, Export ("stringValueProperty", ArgumentSemantic.Strong)]
		string StringValueProperty { get; set; }
	}

	// @interface AWSIoTAssociateTargetsWithJobRequest
	interface AWSIoTAssociateTargetsWithJobRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable comment;
		[NullAllowed, Export ("comment", ArgumentSemantic.Strong)]
		string Comment { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targets;
		[NullAllowed, Export ("targets", ArgumentSemantic.Strong)]
		string[] Targets { get; set; }
	}

	// @interface AWSIoTAssociateTargetsWithJobResponse
	interface AWSIoTAssociateTargetsWithJobResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobArn;
		[NullAllowed, Export ("jobArn", ArgumentSemantic.Strong)]
		string JobArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }
	}

	// @interface AWSIoTAttachPolicyRequest
	interface AWSIoTAttachPolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		string Target { get; set; }
	}

	// @interface AWSIoTAttachPrincipalPolicyRequest
	interface AWSIoTAttachPrincipalPolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }
	}

	// @interface AWSIoTAttachSecurityProfileRequest
	interface AWSIoTAttachSecurityProfileRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileTargetArn;
		[NullAllowed, Export ("securityProfileTargetArn", ArgumentSemantic.Strong)]
		string SecurityProfileTargetArn { get; set; }
	}

	// @interface AWSIoTAttachSecurityProfileResponse
	interface AWSIoTAttachSecurityProfileResponse
	{
	}

	// @interface AWSIoTAttachThingPrincipalRequest
	interface AWSIoTAttachThingPrincipalRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTAttachThingPrincipalResponse
	interface AWSIoTAttachThingPrincipalResponse
	{
	}

	// @interface AWSIoTAttributePayload
	interface AWSIoTAttributePayload
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable attributes;
		[NullAllowed, Export ("attributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Attributes { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable merge;
		[NullAllowed, Export ("merge", ArgumentSemantic.Strong)]
		NSNumber Merge { get; set; }
	}

	// @interface AWSIoTAuditCheckConfiguration
	interface AWSIoTAuditCheckConfiguration
	{
		// @property (nonatomic, strong) NSNumber * _Nullable enabled;
		[NullAllowed, Export ("enabled", ArgumentSemantic.Strong)]
		NSNumber Enabled { get; set; }
	}

	// @interface AWSIoTAuditCheckDetails
	interface AWSIoTAuditCheckDetails
	{
		// @property (nonatomic, strong) NSNumber * _Nullable checkCompliant;
		[NullAllowed, Export ("checkCompliant", ArgumentSemantic.Strong)]
		NSNumber CheckCompliant { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditCheckRunStatus checkRunStatus;
		[Export ("checkRunStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditCheckRunStatus CheckRunStatus { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable errorCode;
		[NullAllowed, Export ("errorCode", ArgumentSemantic.Strong)]
		string ErrorCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable nonCompliantResourcesCount;
		[NullAllowed, Export ("nonCompliantResourcesCount", ArgumentSemantic.Strong)]
		NSNumber NonCompliantResourcesCount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable suppressedNonCompliantResourcesCount;
		[NullAllowed, Export ("suppressedNonCompliantResourcesCount", ArgumentSemantic.Strong)]
		NSNumber SuppressedNonCompliantResourcesCount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable totalResourcesCount;
		[NullAllowed, Export ("totalResourcesCount", ArgumentSemantic.Strong)]
		NSNumber TotalResourcesCount { get; set; }
	}

	// @interface AWSIoTAuditFinding
	interface AWSIoTAuditFinding
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable findingId;
		[NullAllowed, Export ("findingId", ArgumentSemantic.Strong)]
		string FindingId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable findingTime;
		[NullAllowed, Export ("findingTime", ArgumentSemantic.Strong)]
		NSDate FindingTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isSuppressed;
		[NullAllowed, Export ("isSuppressed", ArgumentSemantic.Strong)]
		NSNumber IsSuppressed { get; set; }

		// @property (nonatomic, strong) AWSIoTNonCompliantResource * _Nullable nonCompliantResource;
		[NullAllowed, Export ("nonCompliantResource", ArgumentSemantic.Strong)]
		AWSIoTNonCompliantResource NonCompliantResource { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable reasonForNonCompliance;
		[NullAllowed, Export ("reasonForNonCompliance", ArgumentSemantic.Strong)]
		string ReasonForNonCompliance { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable reasonForNonComplianceCode;
		[NullAllowed, Export ("reasonForNonComplianceCode", ArgumentSemantic.Strong)]
		string ReasonForNonComplianceCode { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTRelatedResource *> * _Nullable relatedResources;
		[NullAllowed, Export ("relatedResources", ArgumentSemantic.Strong)]
		AWSIoTRelatedResource[] RelatedResources { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditFindingSeverity severity;
		[Export ("severity", ArgumentSemantic.Assign)]
		AWSIoTAuditFindingSeverity Severity { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable taskStartTime;
		[NullAllowed, Export ("taskStartTime", ArgumentSemantic.Strong)]
		NSDate TaskStartTime { get; set; }
	}

	// @interface AWSIoTAuditMitigationActionExecutionMetadata
	interface AWSIoTAuditMitigationActionExecutionMetadata
	{
		// @property (nonatomic, strong) NSString * _Nullable actionId;
		[NullAllowed, Export ("actionId", ArgumentSemantic.Strong)]
		string ActionId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable errorCode;
		[NullAllowed, Export ("errorCode", ArgumentSemantic.Strong)]
		string ErrorCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable findingId;
		[NullAllowed, Export ("findingId", ArgumentSemantic.Strong)]
		string FindingId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditMitigationActionsExecutionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTAuditMitigationActionsExecutionStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTAuditMitigationActionsTaskMetadata
	interface AWSIoTAuditMitigationActionsTaskMetadata
	{
		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditMitigationActionsTaskStatus taskStatus;
		[Export ("taskStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditMitigationActionsTaskStatus TaskStatus { get; set; }
	}

	// @interface AWSIoTAuditMitigationActionsTaskTarget
	interface AWSIoTAuditMitigationActionsTaskTarget
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSArray<NSString *> *> * _Nullable auditCheckToReasonCodeFilter;
		[NullAllowed, Export ("auditCheckToReasonCodeFilter", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSArray<NSString>> AuditCheckToReasonCodeFilter { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable auditTaskId;
		[NullAllowed, Export ("auditTaskId", ArgumentSemantic.Strong)]
		string AuditTaskId { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable findingIds;
		[NullAllowed, Export ("findingIds", ArgumentSemantic.Strong)]
		string[] FindingIds { get; set; }
	}

	// @interface AWSIoTAuditNotificationTarget
	interface AWSIoTAuditNotificationTarget
	{
		// @property (nonatomic, strong) NSNumber * _Nullable enabled;
		[NullAllowed, Export ("enabled", ArgumentSemantic.Strong)]
		NSNumber Enabled { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable targetArn;
		[NullAllowed, Export ("targetArn", ArgumentSemantic.Strong)]
		string TargetArn { get; set; }
	}

	// @interface AWSIoTAuditSuppression
	interface AWSIoTAuditSuppression
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expirationDate;
		[NullAllowed, Export ("expirationDate", ArgumentSemantic.Strong)]
		NSDate ExpirationDate { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable suppressIndefinitely;
		[NullAllowed, Export ("suppressIndefinitely", ArgumentSemantic.Strong)]
		NSNumber SuppressIndefinitely { get; set; }
	}

	// @interface AWSIoTAuditTaskMetadata
	interface AWSIoTAuditTaskMetadata
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditTaskStatus taskStatus;
		[Export ("taskStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditTaskStatus TaskStatus { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditTaskType taskType;
		[Export ("taskType", ArgumentSemantic.Assign)]
		AWSIoTAuditTaskType TaskType { get; set; }
	}

	// @interface AWSIoTAuthInfo
	interface AWSIoTAuthInfo
	{
		// @property (assign, nonatomic) AWSIoTActionType actionType;
		[Export ("actionType", ArgumentSemantic.Assign)]
		AWSIoTActionType ActionType { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable resources;
		[NullAllowed, Export ("resources", ArgumentSemantic.Strong)]
		string[] Resources { get; set; }
	}

	// @interface AWSIoTAuthResult
	interface AWSIoTAuthResult
	{
		// @property (nonatomic, strong) AWSIoTAllowed * _Nullable allowed;
		[NullAllowed, Export ("allowed", ArgumentSemantic.Strong)]
		AWSIoTAllowed Allowed { get; set; }

		// @property (assign, nonatomic) AWSIoTAuthDecision authDecision;
		[Export ("authDecision", ArgumentSemantic.Assign)]
		AWSIoTAuthDecision AuthDecision { get; set; }

		// @property (nonatomic, strong) AWSIoTAuthInfo * _Nullable authInfo;
		[NullAllowed, Export ("authInfo", ArgumentSemantic.Strong)]
		AWSIoTAuthInfo AuthInfo { get; set; }

		// @property (nonatomic, strong) AWSIoTDenied * _Nullable denied;
		[NullAllowed, Export ("denied", ArgumentSemantic.Strong)]
		AWSIoTDenied Denied { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable missingContextValues;
		[NullAllowed, Export ("missingContextValues", ArgumentSemantic.Strong)]
		string[] MissingContextValues { get; set; }
	}

	// @interface AWSIoTAuthorizerConfig
	interface AWSIoTAuthorizerConfig
	{
		// @property (nonatomic, strong) NSNumber * _Nullable allowAuthorizerOverride;
		[NullAllowed, Export ("allowAuthorizerOverride", ArgumentSemantic.Strong)]
		NSNumber AllowAuthorizerOverride { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable defaultAuthorizerName;
		[NullAllowed, Export ("defaultAuthorizerName", ArgumentSemantic.Strong)]
		string DefaultAuthorizerName { get; set; }
	}

	// @interface AWSIoTAuthorizerDescription
	interface AWSIoTAuthorizerDescription
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerArn;
		[NullAllowed, Export ("authorizerArn", ArgumentSemantic.Strong)]
		string AuthorizerArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerFunctionArn;
		[NullAllowed, Export ("authorizerFunctionArn", ArgumentSemantic.Strong)]
		string AuthorizerFunctionArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable enableCachingForHttp;
		[NullAllowed, Export ("enableCachingForHttp", ArgumentSemantic.Strong)]
		NSNumber EnableCachingForHttp { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable signingDisabled;
		[NullAllowed, Export ("signingDisabled", ArgumentSemantic.Strong)]
		NSNumber SigningDisabled { get; set; }

		// @property (assign, nonatomic) AWSIoTAuthorizerStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTAuthorizerStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tokenKeyName;
		[NullAllowed, Export ("tokenKeyName", ArgumentSemantic.Strong)]
		string TokenKeyName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable tokenSigningPublicKeys;
		[NullAllowed, Export ("tokenSigningPublicKeys", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> TokenSigningPublicKeys { get; set; }
	}

	// @interface AWSIoTAuthorizerSummary
	interface AWSIoTAuthorizerSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerArn;
		[NullAllowed, Export ("authorizerArn", ArgumentSemantic.Strong)]
		string AuthorizerArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }
	}

	// @interface AWSIoTAwsJobAbortConfig
	interface AWSIoTAwsJobAbortConfig
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAwsJobAbortCriteria *> * _Nullable abortCriteriaList;
		[NullAllowed, Export ("abortCriteriaList", ArgumentSemantic.Strong)]
		AWSIoTAwsJobAbortCriteria[] AbortCriteriaList { get; set; }
	}

	// @interface AWSIoTAwsJobAbortCriteria
	interface AWSIoTAwsJobAbortCriteria
	{
		// @property (assign, nonatomic) AWSIoTAwsJobAbortCriteriaAbortAction action;
		[Export ("action", ArgumentSemantic.Assign)]
		AWSIoTAwsJobAbortCriteriaAbortAction Action { get; set; }

		// @property (assign, nonatomic) AWSIoTAwsJobAbortCriteriaFailureType failureType;
		[Export ("failureType", ArgumentSemantic.Assign)]
		AWSIoTAwsJobAbortCriteriaFailureType FailureType { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minNumberOfExecutedThings;
		[NullAllowed, Export ("minNumberOfExecutedThings", ArgumentSemantic.Strong)]
		NSNumber MinNumberOfExecutedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable thresholdPercentage;
		[NullAllowed, Export ("thresholdPercentage", ArgumentSemantic.Strong)]
		NSNumber ThresholdPercentage { get; set; }
	}

	// @interface AWSIoTAwsJobExecutionsRolloutConfig
	interface AWSIoTAwsJobExecutionsRolloutConfig
	{
		// @property (nonatomic, strong) AWSIoTAwsJobExponentialRolloutRate * _Nullable exponentialRate;
		[NullAllowed, Export ("exponentialRate", ArgumentSemantic.Strong)]
		AWSIoTAwsJobExponentialRolloutRate ExponentialRate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maximumPerMinute;
		[NullAllowed, Export ("maximumPerMinute", ArgumentSemantic.Strong)]
		NSNumber MaximumPerMinute { get; set; }
	}

	// @interface AWSIoTAwsJobExponentialRolloutRate
	interface AWSIoTAwsJobExponentialRolloutRate
	{
		// @property (nonatomic, strong) NSNumber * _Nullable baseRatePerMinute;
		[NullAllowed, Export ("baseRatePerMinute", ArgumentSemantic.Strong)]
		NSNumber BaseRatePerMinute { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable incrementFactor;
		[NullAllowed, Export ("incrementFactor", ArgumentSemantic.Strong)]
		NSNumber IncrementFactor { get; set; }

		// @property (nonatomic, strong) AWSIoTAwsJobRateIncreaseCriteria * _Nullable rateIncreaseCriteria;
		[NullAllowed, Export ("rateIncreaseCriteria", ArgumentSemantic.Strong)]
		AWSIoTAwsJobRateIncreaseCriteria RateIncreaseCriteria { get; set; }
	}

	// @interface AWSIoTAwsJobPresignedUrlConfig
	interface AWSIoTAwsJobPresignedUrlConfig
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expiresInSec;
		[NullAllowed, Export ("expiresInSec", ArgumentSemantic.Strong)]
		NSNumber ExpiresInSec { get; set; }
	}

	// @interface AWSIoTAwsJobRateIncreaseCriteria
	interface AWSIoTAwsJobRateIncreaseCriteria
	{
		// @property (nonatomic, strong) NSNumber * _Nullable numberOfNotifiedThings;
		[NullAllowed, Export ("numberOfNotifiedThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfNotifiedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfSucceededThings;
		[NullAllowed, Export ("numberOfSucceededThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfSucceededThings { get; set; }
	}

	// @interface AWSIoTAwsJobTimeoutConfig
	interface AWSIoTAwsJobTimeoutConfig
	{
		// @property (nonatomic, strong) NSNumber * _Nullable inProgressTimeoutInMinutes;
		[NullAllowed, Export ("inProgressTimeoutInMinutes", ArgumentSemantic.Strong)]
		NSNumber InProgressTimeoutInMinutes { get; set; }
	}

	// @interface AWSIoTBehavior
	interface AWSIoTBehavior
	{
		// @property (nonatomic, strong) AWSIoTBehaviorCriteria * _Nullable criteria;
		[NullAllowed, Export ("criteria", ArgumentSemantic.Strong)]
		AWSIoTBehaviorCriteria Criteria { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metric;
		[NullAllowed, Export ("metric", ArgumentSemantic.Strong)]
		string Metric { get; set; }

		// @property (nonatomic, strong) AWSIoTMetricDimension * _Nullable metricDimension;
		[NullAllowed, Export ("metricDimension", ArgumentSemantic.Strong)]
		AWSIoTMetricDimension MetricDimension { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable suppressAlerts;
		[NullAllowed, Export ("suppressAlerts", ArgumentSemantic.Strong)]
		NSNumber SuppressAlerts { get; set; }
	}

	// @interface AWSIoTBehaviorCriteria
	interface AWSIoTBehaviorCriteria
	{
		// @property (assign, nonatomic) AWSIoTComparisonOperator comparisonOperator;
		[Export ("comparisonOperator", ArgumentSemantic.Assign)]
		AWSIoTComparisonOperator ComparisonOperator { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable consecutiveDatapointsToAlarm;
		[NullAllowed, Export ("consecutiveDatapointsToAlarm", ArgumentSemantic.Strong)]
		NSNumber ConsecutiveDatapointsToAlarm { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable consecutiveDatapointsToClear;
		[NullAllowed, Export ("consecutiveDatapointsToClear", ArgumentSemantic.Strong)]
		NSNumber ConsecutiveDatapointsToClear { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable durationSeconds;
		[NullAllowed, Export ("durationSeconds", ArgumentSemantic.Strong)]
		NSNumber DurationSeconds { get; set; }

		// @property (nonatomic, strong) AWSIoTMachineLearningDetectionConfig * _Nullable mlDetectionConfig;
		[NullAllowed, Export ("mlDetectionConfig", ArgumentSemantic.Strong)]
		AWSIoTMachineLearningDetectionConfig MlDetectionConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTStatisticalThreshold * _Nullable statisticalThreshold;
		[NullAllowed, Export ("statisticalThreshold", ArgumentSemantic.Strong)]
		AWSIoTStatisticalThreshold StatisticalThreshold { get; set; }

		// @property (nonatomic, strong) AWSIoTMetricValue * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		AWSIoTMetricValue Value { get; set; }
	}

	// @interface AWSIoTBehaviorModelTrainingSummary
	interface AWSIoTBehaviorModelTrainingSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable behaviorName;
		[NullAllowed, Export ("behaviorName", ArgumentSemantic.Strong)]
		string BehaviorName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable datapointsCollectionPercentage;
		[NullAllowed, Export ("datapointsCollectionPercentage", ArgumentSemantic.Strong)]
		NSNumber DatapointsCollectionPercentage { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModelRefreshDate;
		[NullAllowed, Export ("lastModelRefreshDate", ArgumentSemantic.Strong)]
		NSDate LastModelRefreshDate { get; set; }

		// @property (assign, nonatomic) AWSIoTModelStatus modelStatus;
		[Export ("modelStatus", ArgumentSemantic.Assign)]
		AWSIoTModelStatus ModelStatus { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable trainingDataCollectionStartDate;
		[NullAllowed, Export ("trainingDataCollectionStartDate", ArgumentSemantic.Strong)]
		NSDate TrainingDataCollectionStartDate { get; set; }
	}

	// @interface AWSIoTBillingGroupMetadata
	interface AWSIoTBillingGroupMetadata
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }
	}

	// @interface AWSIoTBillingGroupProperties
	interface AWSIoTBillingGroupProperties
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupDescription;
		[NullAllowed, Export ("billingGroupDescription", ArgumentSemantic.Strong)]
		string BillingGroupDescription { get; set; }
	}

	// @interface AWSIoTBucket
	interface AWSIoTBucket
	{
		// @property (nonatomic, strong) NSNumber * _Nullable count;
		[NullAllowed, Export ("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable keyValue;
		[NullAllowed, Export ("keyValue", ArgumentSemantic.Strong)]
		string KeyValue { get; set; }
	}

	// @interface AWSIoTBucketsAggregationType
	interface AWSIoTBucketsAggregationType
	{
		// @property (nonatomic, strong) AWSIoTTermsAggregation * _Nullable termsAggregation;
		[NullAllowed, Export ("termsAggregation", ArgumentSemantic.Strong)]
		AWSIoTTermsAggregation TermsAggregation { get; set; }
	}

	// @interface AWSIoTCACertificate
	interface AWSIoTCACertificate
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (assign, nonatomic) AWSIoTCACertificateStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTCACertificateStatus Status { get; set; }
	}

	// @interface AWSIoTCACertificateDescription
	interface AWSIoTCACertificateDescription
	{
		// @property (assign, nonatomic) AWSIoTAutoRegistrationStatus autoRegistrationStatus;
		[Export ("autoRegistrationStatus", ArgumentSemantic.Assign)]
		AWSIoTAutoRegistrationStatus AutoRegistrationStatus { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateMode certificateMode;
		[Export ("certificateMode", ArgumentSemantic.Assign)]
		AWSIoTCertificateMode CertificateMode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable customerVersion;
		[NullAllowed, Export ("customerVersion", ArgumentSemantic.Strong)]
		NSNumber CustomerVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable generationId;
		[NullAllowed, Export ("generationId", ArgumentSemantic.Strong)]
		string GenerationId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ownedBy;
		[NullAllowed, Export ("ownedBy", ArgumentSemantic.Strong)]
		string OwnedBy { get; set; }

		// @property (assign, nonatomic) AWSIoTCACertificateStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTCACertificateStatus Status { get; set; }

		// @property (nonatomic, strong) AWSIoTCertificateValidity * _Nullable validity;
		[NullAllowed, Export ("validity", ArgumentSemantic.Strong)]
		AWSIoTCertificateValidity Validity { get; set; }
	}

	// @interface AWSIoTCancelAuditMitigationActionsTaskRequest
	interface AWSIoTCancelAuditMitigationActionsTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTCancelAuditMitigationActionsTaskResponse
	interface AWSIoTCancelAuditMitigationActionsTaskResponse
	{
	}

	// @interface AWSIoTCancelAuditTaskRequest
	interface AWSIoTCancelAuditTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTCancelAuditTaskResponse
	interface AWSIoTCancelAuditTaskResponse
	{
	}

	// @interface AWSIoTCancelCertificateTransferRequest
	interface AWSIoTCancelCertificateTransferRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }
	}

	// @interface AWSIoTCancelDetectMitigationActionsTaskRequest
	interface AWSIoTCancelDetectMitigationActionsTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTCancelDetectMitigationActionsTaskResponse
	interface AWSIoTCancelDetectMitigationActionsTaskResponse
	{
	}

	// @interface AWSIoTCancelJobExecutionRequest
	interface AWSIoTCancelJobExecutionRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable force;
		[NullAllowed, Export ("force", ArgumentSemantic.Strong)]
		NSNumber Force { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable statusDetails;
		[NullAllowed, Export ("statusDetails", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> StatusDetails { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTCancelJobRequest
	interface AWSIoTCancelJobRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable comment;
		[NullAllowed, Export ("comment", ArgumentSemantic.Strong)]
		string Comment { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable force;
		[NullAllowed, Export ("force", ArgumentSemantic.Strong)]
		NSNumber Force { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable reasonCode;
		[NullAllowed, Export ("reasonCode", ArgumentSemantic.Strong)]
		string ReasonCode { get; set; }
	}

	// @interface AWSIoTCancelJobResponse
	interface AWSIoTCancelJobResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobArn;
		[NullAllowed, Export ("jobArn", ArgumentSemantic.Strong)]
		string JobArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }
	}

	// @interface AWSIoTCertificate
	interface AWSIoTCertificate
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateMode certificateMode;
		[Export ("certificateMode", ArgumentSemantic.Assign)]
		AWSIoTCertificateMode CertificateMode { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTCertificateStatus Status { get; set; }
	}

	// @interface AWSIoTCertificateDescription
	interface AWSIoTCertificateDescription
	{
		// @property (nonatomic, strong) NSString * _Nullable caCertificateId;
		[NullAllowed, Export ("caCertificateId", ArgumentSemantic.Strong)]
		string CaCertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateMode certificateMode;
		[Export ("certificateMode", ArgumentSemantic.Assign)]
		AWSIoTCertificateMode CertificateMode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable customerVersion;
		[NullAllowed, Export ("customerVersion", ArgumentSemantic.Strong)]
		NSNumber CustomerVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable generationId;
		[NullAllowed, Export ("generationId", ArgumentSemantic.Strong)]
		string GenerationId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ownedBy;
		[NullAllowed, Export ("ownedBy", ArgumentSemantic.Strong)]
		string OwnedBy { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable previousOwnedBy;
		[NullAllowed, Export ("previousOwnedBy", ArgumentSemantic.Strong)]
		string PreviousOwnedBy { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTCertificateStatus Status { get; set; }

		// @property (nonatomic, strong) AWSIoTTransferData * _Nullable transferData;
		[NullAllowed, Export ("transferData", ArgumentSemantic.Strong)]
		AWSIoTTransferData TransferData { get; set; }

		// @property (nonatomic, strong) AWSIoTCertificateValidity * _Nullable validity;
		[NullAllowed, Export ("validity", ArgumentSemantic.Strong)]
		AWSIoTCertificateValidity Validity { get; set; }
	}

	// @interface AWSIoTCertificateValidity
	interface AWSIoTCertificateValidity
	{
		// @property (nonatomic, strong) NSDate * _Nullable notAfter;
		[NullAllowed, Export ("notAfter", ArgumentSemantic.Strong)]
		NSDate NotAfter { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable notBefore;
		[NullAllowed, Export ("notBefore", ArgumentSemantic.Strong)]
		NSDate NotBefore { get; set; }
	}

	// @interface AWSIoTClearDefaultAuthorizerRequest
	interface AWSIoTClearDefaultAuthorizerRequest
	{
	}

	// @interface AWSIoTClearDefaultAuthorizerResponse
	interface AWSIoTClearDefaultAuthorizerResponse
	{
	}

	// @interface AWSIoTCloudwatchAlarmAction
	interface AWSIoTCloudwatchAlarmAction
	{
		// @property (nonatomic, strong) NSString * _Nullable alarmName;
		[NullAllowed, Export ("alarmName", ArgumentSemantic.Strong)]
		string AlarmName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable stateReason;
		[NullAllowed, Export ("stateReason", ArgumentSemantic.Strong)]
		string StateReason { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable stateValue;
		[NullAllowed, Export ("stateValue", ArgumentSemantic.Strong)]
		string StateValue { get; set; }
	}

	// @interface AWSIoTCloudwatchLogsAction
	interface AWSIoTCloudwatchLogsAction
	{
		// @property (nonatomic, strong) NSNumber * _Nullable batchMode;
		[NullAllowed, Export ("batchMode", ArgumentSemantic.Strong)]
		NSNumber BatchMode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable logGroupName;
		[NullAllowed, Export ("logGroupName", ArgumentSemantic.Strong)]
		string LogGroupName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTCloudwatchMetricAction
	interface AWSIoTCloudwatchMetricAction
	{
		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricNamespace;
		[NullAllowed, Export ("metricNamespace", ArgumentSemantic.Strong)]
		string MetricNamespace { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricTimestamp;
		[NullAllowed, Export ("metricTimestamp", ArgumentSemantic.Strong)]
		string MetricTimestamp { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricUnit;
		[NullAllowed, Export ("metricUnit", ArgumentSemantic.Strong)]
		string MetricUnit { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricValue;
		[NullAllowed, Export ("metricValue", ArgumentSemantic.Strong)]
		string MetricValue { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTCodeSigning
	interface AWSIoTCodeSigning
	{
		// @property (nonatomic, strong) NSString * _Nullable awsSignerJobId;
		[NullAllowed, Export ("awsSignerJobId", ArgumentSemantic.Strong)]
		string AwsSignerJobId { get; set; }

		// @property (nonatomic, strong) AWSIoTCustomCodeSigning * _Nullable customCodeSigning;
		[NullAllowed, Export ("customCodeSigning", ArgumentSemantic.Strong)]
		AWSIoTCustomCodeSigning CustomCodeSigning { get; set; }

		// @property (nonatomic, strong) AWSIoTStartSigningJobParameter * _Nullable startSigningJobParameter;
		[NullAllowed, Export ("startSigningJobParameter", ArgumentSemantic.Strong)]
		AWSIoTStartSigningJobParameter StartSigningJobParameter { get; set; }
	}

	// @interface AWSIoTCodeSigningCertificateChain
	interface AWSIoTCodeSigningCertificateChain
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateName;
		[NullAllowed, Export ("certificateName", ArgumentSemantic.Strong)]
		string CertificateName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable inlineDocument;
		[NullAllowed, Export ("inlineDocument", ArgumentSemantic.Strong)]
		string InlineDocument { get; set; }
	}

	// @interface AWSIoTCodeSigningSignature
	interface AWSIoTCodeSigningSignature
	{
		// @property (nonatomic, strong) NSData * _Nullable inlineDocument;
		[NullAllowed, Export ("inlineDocument", ArgumentSemantic.Strong)]
		NSData InlineDocument { get; set; }
	}

	// @interface AWSIoTConfiguration
	interface AWSIoTConfiguration
	{
		// @property (nonatomic, strong) NSNumber * _Nullable enabled;
		[NullAllowed, Export ("enabled", ArgumentSemantic.Strong)]
		NSNumber Enabled { get; set; }
	}

	// @interface AWSIoTConfirmTopicRuleDestinationRequest
	interface AWSIoTConfirmTopicRuleDestinationRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable confirmationToken;
		[NullAllowed, Export ("confirmationToken", ArgumentSemantic.Strong)]
		string ConfirmationToken { get; set; }
	}

	// @interface AWSIoTConfirmTopicRuleDestinationResponse
	interface AWSIoTConfirmTopicRuleDestinationResponse
	{
	}

	// @interface AWSIoTCreateAuditSuppressionRequest
	interface AWSIoTCreateAuditSuppressionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable clientRequestToken;
		[NullAllowed, Export ("clientRequestToken", ArgumentSemantic.Strong)]
		string ClientRequestToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expirationDate;
		[NullAllowed, Export ("expirationDate", ArgumentSemantic.Strong)]
		NSDate ExpirationDate { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable suppressIndefinitely;
		[NullAllowed, Export ("suppressIndefinitely", ArgumentSemantic.Strong)]
		NSNumber SuppressIndefinitely { get; set; }
	}

	// @interface AWSIoTCreateAuditSuppressionResponse
	interface AWSIoTCreateAuditSuppressionResponse
	{
	}

	// @interface AWSIoTCreateAuthorizerRequest
	interface AWSIoTCreateAuthorizerRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerFunctionArn;
		[NullAllowed, Export ("authorizerFunctionArn", ArgumentSemantic.Strong)]
		string AuthorizerFunctionArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable enableCachingForHttp;
		[NullAllowed, Export ("enableCachingForHttp", ArgumentSemantic.Strong)]
		NSNumber EnableCachingForHttp { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable signingDisabled;
		[NullAllowed, Export ("signingDisabled", ArgumentSemantic.Strong)]
		NSNumber SigningDisabled { get; set; }

		// @property (assign, nonatomic) AWSIoTAuthorizerStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTAuthorizerStatus Status { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tokenKeyName;
		[NullAllowed, Export ("tokenKeyName", ArgumentSemantic.Strong)]
		string TokenKeyName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable tokenSigningPublicKeys;
		[NullAllowed, Export ("tokenSigningPublicKeys", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> TokenSigningPublicKeys { get; set; }
	}

	// @interface AWSIoTCreateAuthorizerResponse
	interface AWSIoTCreateAuthorizerResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerArn;
		[NullAllowed, Export ("authorizerArn", ArgumentSemantic.Strong)]
		string AuthorizerArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }
	}

	// @interface AWSIoTCreateBillingGroupRequest
	interface AWSIoTCreateBillingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTBillingGroupProperties * _Nullable billingGroupProperties;
		[NullAllowed, Export ("billingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTBillingGroupProperties BillingGroupProperties { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTCreateBillingGroupResponse
	interface AWSIoTCreateBillingGroupResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupArn;
		[NullAllowed, Export ("billingGroupArn", ArgumentSemantic.Strong)]
		string BillingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupId;
		[NullAllowed, Export ("billingGroupId", ArgumentSemantic.Strong)]
		string BillingGroupId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }
	}

	// @interface AWSIoTCreateCertificateFromCsrRequest
	interface AWSIoTCreateCertificateFromCsrRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateSigningRequest;
		[NullAllowed, Export ("certificateSigningRequest", ArgumentSemantic.Strong)]
		string CertificateSigningRequest { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable setAsActive;
		[NullAllowed, Export ("setAsActive", ArgumentSemantic.Strong)]
		NSNumber SetAsActive { get; set; }
	}

	// @interface AWSIoTCreateCertificateFromCsrResponse
	interface AWSIoTCreateCertificateFromCsrResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }
	}

	// @interface AWSIoTCreateCustomMetricRequest
	interface AWSIoTCreateCustomMetricRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable clientRequestToken;
		[NullAllowed, Export ("clientRequestToken", ArgumentSemantic.Strong)]
		string ClientRequestToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName", ArgumentSemantic.Strong)]
		string DisplayName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (assign, nonatomic) AWSIoTCustomMetricType metricType;
		[Export ("metricType", ArgumentSemantic.Assign)]
		AWSIoTCustomMetricType MetricType { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTCreateCustomMetricResponse
	interface AWSIoTCreateCustomMetricResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable metricArn;
		[NullAllowed, Export ("metricArn", ArgumentSemantic.Strong)]
		string MetricArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTCreateDimensionRequest
	interface AWSIoTCreateDimensionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable clientRequestToken;
		[NullAllowed, Export ("clientRequestToken", ArgumentSemantic.Strong)]
		string ClientRequestToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable stringValues;
		[NullAllowed, Export ("stringValues", ArgumentSemantic.Strong)]
		string[] StringValues { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (assign, nonatomic) AWSIoTDimensionType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSIoTDimensionType Types { get; set; }
	}

	// @interface AWSIoTCreateDimensionResponse
	interface AWSIoTCreateDimensionResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }
	}

	// @interface AWSIoTCreateDomainConfigurationRequest
	interface AWSIoTCreateDomainConfigurationRequest
	{
		// @property (nonatomic, strong) AWSIoTAuthorizerConfig * _Nullable authorizerConfig;
		[NullAllowed, Export ("authorizerConfig", ArgumentSemantic.Strong)]
		AWSIoTAuthorizerConfig AuthorizerConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainName;
		[NullAllowed, Export ("domainName", ArgumentSemantic.Strong)]
		string DomainName { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable serverCertificateArns;
		[NullAllowed, Export ("serverCertificateArns", ArgumentSemantic.Strong)]
		string[] ServerCertificateArns { get; set; }

		// @property (assign, nonatomic) AWSIoTServiceType serviceType;
		[Export ("serviceType", ArgumentSemantic.Assign)]
		AWSIoTServiceType ServiceType { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable validationCertificateArn;
		[NullAllowed, Export ("validationCertificateArn", ArgumentSemantic.Strong)]
		string ValidationCertificateArn { get; set; }
	}

	// @interface AWSIoTCreateDomainConfigurationResponse
	interface AWSIoTCreateDomainConfigurationResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationArn;
		[NullAllowed, Export ("domainConfigurationArn", ArgumentSemantic.Strong)]
		string DomainConfigurationArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }
	}

	// @interface AWSIoTCreateDynamicThingGroupRequest
	interface AWSIoTCreateDynamicThingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingGroupProperties * _Nullable thingGroupProperties;
		[NullAllowed, Export ("thingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTThingGroupProperties ThingGroupProperties { get; set; }
	}

	// @interface AWSIoTCreateDynamicThingGroupResponse
	interface AWSIoTCreateDynamicThingGroupResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupArn;
		[NullAllowed, Export ("thingGroupArn", ArgumentSemantic.Strong)]
		string ThingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupId;
		[NullAllowed, Export ("thingGroupId", ArgumentSemantic.Strong)]
		string ThingGroupId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTCreateFleetMetricRequest
	interface AWSIoTCreateFleetMetricRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable aggregationField;
		[NullAllowed, Export ("aggregationField", ArgumentSemantic.Strong)]
		string AggregationField { get; set; }

		// @property (nonatomic, strong) AWSIoTAggregationType * _Nullable aggregationType;
		[NullAllowed, Export ("aggregationType", ArgumentSemantic.Strong)]
		AWSIoTAggregationType AggregationType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable period;
		[NullAllowed, Export ("period", ArgumentSemantic.Strong)]
		NSNumber Period { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (assign, nonatomic) AWSIoTFleetMetricUnit unit;
		[Export ("unit", ArgumentSemantic.Assign)]
		AWSIoTFleetMetricUnit Unit { get; set; }
	}

	// @interface AWSIoTCreateFleetMetricResponse
	interface AWSIoTCreateFleetMetricResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable metricArn;
		[NullAllowed, Export ("metricArn", ArgumentSemantic.Strong)]
		string MetricArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTCreateJobRequest
	interface AWSIoTCreateJobRequest
	{
		// @property (nonatomic, strong) AWSIoTAbortConfig * _Nullable abortConfig;
		[NullAllowed, Export ("abortConfig", ArgumentSemantic.Strong)]
		AWSIoTAbortConfig AbortConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable document;
		[NullAllowed, Export ("document", ArgumentSemantic.Strong)]
		string Document { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable documentParameters;
		[NullAllowed, Export ("documentParameters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> DocumentParameters { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable documentSource;
		[NullAllowed, Export ("documentSource", ArgumentSemantic.Strong)]
		string DocumentSource { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRetryConfig * _Nullable jobExecutionsRetryConfig;
		[NullAllowed, Export ("jobExecutionsRetryConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRolloutConfig * _Nullable jobExecutionsRolloutConfig;
		[NullAllowed, Export ("jobExecutionsRolloutConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateArn;
		[NullAllowed, Export ("jobTemplateArn", ArgumentSemantic.Strong)]
		string JobTemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }

		// @property (nonatomic, strong) AWSIoTPresignedUrlConfig * _Nullable presignedUrlConfig;
		[NullAllowed, Export ("presignedUrlConfig", ArgumentSemantic.Strong)]
		AWSIoTPresignedUrlConfig PresignedUrlConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTSchedulingConfig * _Nullable schedulingConfig;
		[NullAllowed, Export ("schedulingConfig", ArgumentSemantic.Strong)]
		AWSIoTSchedulingConfig SchedulingConfig { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (assign, nonatomic) AWSIoTTargetSelection targetSelection;
		[Export ("targetSelection", ArgumentSemantic.Assign)]
		AWSIoTTargetSelection TargetSelection { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targets;
		[NullAllowed, Export ("targets", ArgumentSemantic.Strong)]
		string[] Targets { get; set; }

		// @property (nonatomic, strong) AWSIoTTimeoutConfig * _Nullable timeoutConfig;
		[NullAllowed, Export ("timeoutConfig", ArgumentSemantic.Strong)]
		AWSIoTTimeoutConfig TimeoutConfig { get; set; }
	}

	// @interface AWSIoTCreateJobResponse
	interface AWSIoTCreateJobResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobArn;
		[NullAllowed, Export ("jobArn", ArgumentSemantic.Strong)]
		string JobArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }
	}

	// @interface AWSIoTCreateJobTemplateRequest
	interface AWSIoTCreateJobTemplateRequest
	{
		// @property (nonatomic, strong) AWSIoTAbortConfig * _Nullable abortConfig;
		[NullAllowed, Export ("abortConfig", ArgumentSemantic.Strong)]
		AWSIoTAbortConfig AbortConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable document;
		[NullAllowed, Export ("document", ArgumentSemantic.Strong)]
		string Document { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable documentSource;
		[NullAllowed, Export ("documentSource", ArgumentSemantic.Strong)]
		string DocumentSource { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobArn;
		[NullAllowed, Export ("jobArn", ArgumentSemantic.Strong)]
		string JobArn { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRetryConfig * _Nullable jobExecutionsRetryConfig;
		[NullAllowed, Export ("jobExecutionsRetryConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRolloutConfig * _Nullable jobExecutionsRolloutConfig;
		[NullAllowed, Export ("jobExecutionsRolloutConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateId;
		[NullAllowed, Export ("jobTemplateId", ArgumentSemantic.Strong)]
		string JobTemplateId { get; set; }

		// @property (nonatomic, strong) AWSIoTPresignedUrlConfig * _Nullable presignedUrlConfig;
		[NullAllowed, Export ("presignedUrlConfig", ArgumentSemantic.Strong)]
		AWSIoTPresignedUrlConfig PresignedUrlConfig { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) AWSIoTTimeoutConfig * _Nullable timeoutConfig;
		[NullAllowed, Export ("timeoutConfig", ArgumentSemantic.Strong)]
		AWSIoTTimeoutConfig TimeoutConfig { get; set; }
	}

	// @interface AWSIoTCreateJobTemplateResponse
	interface AWSIoTCreateJobTemplateResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable jobTemplateArn;
		[NullAllowed, Export ("jobTemplateArn", ArgumentSemantic.Strong)]
		string JobTemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateId;
		[NullAllowed, Export ("jobTemplateId", ArgumentSemantic.Strong)]
		string JobTemplateId { get; set; }
	}

	// @interface AWSIoTCreateKeysAndCertificateRequest
	interface AWSIoTCreateKeysAndCertificateRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable setAsActive;
		[NullAllowed, Export ("setAsActive", ArgumentSemantic.Strong)]
		NSNumber SetAsActive { get; set; }
	}

	// @interface AWSIoTCreateKeysAndCertificateResponse
	interface AWSIoTCreateKeysAndCertificateResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }

		// @property (nonatomic, strong) AWSIoTKeyPair * _Nullable keyPair;
		[NullAllowed, Export ("keyPair", ArgumentSemantic.Strong)]
		AWSIoTKeyPair KeyPair { get; set; }
	}

	// @interface AWSIoTCreateMitigationActionRequest
	interface AWSIoTCreateMitigationActionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }

		// @property (nonatomic, strong) AWSIoTMitigationActionParams * _Nullable actionParams;
		[NullAllowed, Export ("actionParams", ArgumentSemantic.Strong)]
		AWSIoTMitigationActionParams ActionParams { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTCreateMitigationActionResponse
	interface AWSIoTCreateMitigationActionResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable actionArn;
		[NullAllowed, Export ("actionArn", ArgumentSemantic.Strong)]
		string ActionArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable actionId;
		[NullAllowed, Export ("actionId", ArgumentSemantic.Strong)]
		string ActionId { get; set; }
	}

	// @interface AWSIoTCreateOTAUpdateRequest
	interface AWSIoTCreateOTAUpdateRequest
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable additionalParameters;
		[NullAllowed, Export ("additionalParameters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> AdditionalParameters { get; set; }

		// @property (nonatomic, strong) AWSIoTAwsJobAbortConfig * _Nullable awsJobAbortConfig;
		[NullAllowed, Export ("awsJobAbortConfig", ArgumentSemantic.Strong)]
		AWSIoTAwsJobAbortConfig AwsJobAbortConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTAwsJobExecutionsRolloutConfig * _Nullable awsJobExecutionsRolloutConfig;
		[NullAllowed, Export ("awsJobExecutionsRolloutConfig", ArgumentSemantic.Strong)]
		AWSIoTAwsJobExecutionsRolloutConfig AwsJobExecutionsRolloutConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTAwsJobPresignedUrlConfig * _Nullable awsJobPresignedUrlConfig;
		[NullAllowed, Export ("awsJobPresignedUrlConfig", ArgumentSemantic.Strong)]
		AWSIoTAwsJobPresignedUrlConfig AwsJobPresignedUrlConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTAwsJobTimeoutConfig * _Nullable awsJobTimeoutConfig;
		[NullAllowed, Export ("awsJobTimeoutConfig", ArgumentSemantic.Strong)]
		AWSIoTAwsJobTimeoutConfig AwsJobTimeoutConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTOTAUpdateFile *> * _Nullable files;
		[NullAllowed, Export ("files", ArgumentSemantic.Strong)]
		AWSIoTOTAUpdateFile[] Files { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateId;
		[NullAllowed, Export ("otaUpdateId", ArgumentSemantic.Strong)]
		string OtaUpdateId { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable protocols;
		[NullAllowed, Export ("protocols", ArgumentSemantic.Strong)]
		string[] Protocols { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (assign, nonatomic) AWSIoTTargetSelection targetSelection;
		[Export ("targetSelection", ArgumentSemantic.Assign)]
		AWSIoTTargetSelection TargetSelection { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targets;
		[NullAllowed, Export ("targets", ArgumentSemantic.Strong)]
		string[] Targets { get; set; }
	}

	// @interface AWSIoTCreateOTAUpdateResponse
	interface AWSIoTCreateOTAUpdateResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable awsIotJobArn;
		[NullAllowed, Export ("awsIotJobArn", ArgumentSemantic.Strong)]
		string AwsIotJobArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable awsIotJobId;
		[NullAllowed, Export ("awsIotJobId", ArgumentSemantic.Strong)]
		string AwsIotJobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateArn;
		[NullAllowed, Export ("otaUpdateArn", ArgumentSemantic.Strong)]
		string OtaUpdateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateId;
		[NullAllowed, Export ("otaUpdateId", ArgumentSemantic.Strong)]
		string OtaUpdateId { get; set; }

		// @property (assign, nonatomic) AWSIoTOTAUpdateStatus otaUpdateStatus;
		[Export ("otaUpdateStatus", ArgumentSemantic.Assign)]
		AWSIoTOTAUpdateStatus OtaUpdateStatus { get; set; }
	}

	// @interface AWSIoTCreatePolicyRequest
	interface AWSIoTCreatePolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyDocument;
		[NullAllowed, Export ("policyDocument", ArgumentSemantic.Strong)]
		string PolicyDocument { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTCreatePolicyResponse
	interface AWSIoTCreatePolicyResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable policyArn;
		[NullAllowed, Export ("policyArn", ArgumentSemantic.Strong)]
		string PolicyArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyDocument;
		[NullAllowed, Export ("policyDocument", ArgumentSemantic.Strong)]
		string PolicyDocument { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyVersionId;
		[NullAllowed, Export ("policyVersionId", ArgumentSemantic.Strong)]
		string PolicyVersionId { get; set; }
	}

	// @interface AWSIoTCreatePolicyVersionRequest
	interface AWSIoTCreatePolicyVersionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyDocument;
		[NullAllowed, Export ("policyDocument", ArgumentSemantic.Strong)]
		string PolicyDocument { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable setAsDefault;
		[NullAllowed, Export ("setAsDefault", ArgumentSemantic.Strong)]
		NSNumber SetAsDefault { get; set; }
	}

	// @interface AWSIoTCreatePolicyVersionResponse
	interface AWSIoTCreatePolicyVersionResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable isDefaultVersion;
		[NullAllowed, Export ("isDefaultVersion", ArgumentSemantic.Strong)]
		NSNumber IsDefaultVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyArn;
		[NullAllowed, Export ("policyArn", ArgumentSemantic.Strong)]
		string PolicyArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyDocument;
		[NullAllowed, Export ("policyDocument", ArgumentSemantic.Strong)]
		string PolicyDocument { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyVersionId;
		[NullAllowed, Export ("policyVersionId", ArgumentSemantic.Strong)]
		string PolicyVersionId { get; set; }
	}

	// @interface AWSIoTCreateProvisioningClaimRequest
	interface AWSIoTCreateProvisioningClaimRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTCreateProvisioningClaimResponse
	interface AWSIoTCreateProvisioningClaimResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expiration;
		[NullAllowed, Export ("expiration", ArgumentSemantic.Strong)]
		NSDate Expiration { get; set; }

		// @property (nonatomic, strong) AWSIoTKeyPair * _Nullable keyPair;
		[NullAllowed, Export ("keyPair", ArgumentSemantic.Strong)]
		AWSIoTKeyPair KeyPair { get; set; }
	}

	// @interface AWSIoTCreateProvisioningTemplateRequest
	interface AWSIoTCreateProvisioningTemplateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable enabled;
		[NullAllowed, Export ("enabled", ArgumentSemantic.Strong)]
		NSNumber Enabled { get; set; }

		// @property (nonatomic, strong) AWSIoTProvisioningHook * _Nullable preProvisioningHook;
		[NullAllowed, Export ("preProvisioningHook", ArgumentSemantic.Strong)]
		AWSIoTProvisioningHook PreProvisioningHook { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable provisioningRoleArn;
		[NullAllowed, Export ("provisioningRoleArn", ArgumentSemantic.Strong)]
		string ProvisioningRoleArn { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (assign, nonatomic) AWSIoTTemplateType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSIoTTemplateType Types { get; set; }
	}

	// @interface AWSIoTCreateProvisioningTemplateResponse
	interface AWSIoTCreateProvisioningTemplateResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable defaultVersionId;
		[NullAllowed, Export ("defaultVersionId", ArgumentSemantic.Strong)]
		NSNumber DefaultVersionId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateArn;
		[NullAllowed, Export ("templateArn", ArgumentSemantic.Strong)]
		string TemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTCreateProvisioningTemplateVersionRequest
	interface AWSIoTCreateProvisioningTemplateVersionRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable setAsDefault;
		[NullAllowed, Export ("setAsDefault", ArgumentSemantic.Strong)]
		NSNumber SetAsDefault { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTCreateProvisioningTemplateVersionResponse
	interface AWSIoTCreateProvisioningTemplateVersionResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable isDefaultVersion;
		[NullAllowed, Export ("isDefaultVersion", ArgumentSemantic.Strong)]
		NSNumber IsDefaultVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateArn;
		[NullAllowed, Export ("templateArn", ArgumentSemantic.Strong)]
		string TemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable versionId;
		[NullAllowed, Export ("versionId", ArgumentSemantic.Strong)]
		NSNumber VersionId { get; set; }
	}

	// @interface AWSIoTCreateRoleAliasRequest
	interface AWSIoTCreateRoleAliasRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable credentialDurationSeconds;
		[NullAllowed, Export ("credentialDurationSeconds", ArgumentSemantic.Strong)]
		NSNumber CredentialDurationSeconds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleAlias;
		[NullAllowed, Export ("roleAlias", ArgumentSemantic.Strong)]
		string RoleAlias { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTCreateRoleAliasResponse
	interface AWSIoTCreateRoleAliasResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable roleAlias;
		[NullAllowed, Export ("roleAlias", ArgumentSemantic.Strong)]
		string RoleAlias { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleAliasArn;
		[NullAllowed, Export ("roleAliasArn", ArgumentSemantic.Strong)]
		string RoleAliasArn { get; set; }
	}

	// @interface AWSIoTCreateScheduledAuditRequest
	interface AWSIoTCreateScheduledAuditRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable dayOfMonth;
		[NullAllowed, Export ("dayOfMonth", ArgumentSemantic.Strong)]
		string DayOfMonth { get; set; }

		// @property (assign, nonatomic) AWSIoTDayOfWeek dayOfWeek;
		[Export ("dayOfWeek", ArgumentSemantic.Assign)]
		AWSIoTDayOfWeek DayOfWeek { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditFrequency frequency;
		[Export ("frequency", ArgumentSemantic.Assign)]
		AWSIoTAuditFrequency Frequency { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditName;
		[NullAllowed, Export ("scheduledAuditName", ArgumentSemantic.Strong)]
		string ScheduledAuditName { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targetCheckNames;
		[NullAllowed, Export ("targetCheckNames", ArgumentSemantic.Strong)]
		string[] TargetCheckNames { get; set; }
	}

	// @interface AWSIoTCreateScheduledAuditResponse
	interface AWSIoTCreateScheduledAuditResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditArn;
		[NullAllowed, Export ("scheduledAuditArn", ArgumentSemantic.Strong)]
		string ScheduledAuditArn { get; set; }
	}

	// @interface AWSIoTCreateSecurityProfileRequest
	interface AWSIoTCreateSecurityProfileRequest
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable additionalMetricsToRetain;
		[NullAllowed, Export ("additionalMetricsToRetain", ArgumentSemantic.Strong)]
		string[] AdditionalMetricsToRetain { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTMetricToRetain *> * _Nullable additionalMetricsToRetainV2;
		[NullAllowed, Export ("additionalMetricsToRetainV2", ArgumentSemantic.Strong)]
		AWSIoTMetricToRetain[] AdditionalMetricsToRetainV2 { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAlertTarget *> * _Nullable alertTargets;
		[NullAllowed, Export ("alertTargets", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAlertTarget> AlertTargets { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTBehavior *> * _Nullable behaviors;
		[NullAllowed, Export ("behaviors", ArgumentSemantic.Strong)]
		AWSIoTBehavior[] Behaviors { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileDescription;
		[NullAllowed, Export ("securityProfileDescription", ArgumentSemantic.Strong)]
		string SecurityProfileDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTCreateSecurityProfileResponse
	interface AWSIoTCreateSecurityProfileResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable securityProfileArn;
		[NullAllowed, Export ("securityProfileArn", ArgumentSemantic.Strong)]
		string SecurityProfileArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }
	}

	// @interface AWSIoTCreateStreamRequest
	interface AWSIoTCreateStreamRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTStreamFile *> * _Nullable files;
		[NullAllowed, Export ("files", ArgumentSemantic.Strong)]
		AWSIoTStreamFile[] Files { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTCreateStreamResponse
	interface AWSIoTCreateStreamResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamArn;
		[NullAllowed, Export ("streamArn", ArgumentSemantic.Strong)]
		string StreamArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable streamVersion;
		[NullAllowed, Export ("streamVersion", ArgumentSemantic.Strong)]
		NSNumber StreamVersion { get; set; }
	}

	// @interface AWSIoTCreateThingGroupRequest
	interface AWSIoTCreateThingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable parentGroupName;
		[NullAllowed, Export ("parentGroupName", ArgumentSemantic.Strong)]
		string ParentGroupName { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingGroupProperties * _Nullable thingGroupProperties;
		[NullAllowed, Export ("thingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTThingGroupProperties ThingGroupProperties { get; set; }
	}

	// @interface AWSIoTCreateThingGroupResponse
	interface AWSIoTCreateThingGroupResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable thingGroupArn;
		[NullAllowed, Export ("thingGroupArn", ArgumentSemantic.Strong)]
		string ThingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupId;
		[NullAllowed, Export ("thingGroupId", ArgumentSemantic.Strong)]
		string ThingGroupId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTCreateThingRequest
	interface AWSIoTCreateThingRequest
	{
		// @property (nonatomic, strong) AWSIoTAttributePayload * _Nullable attributePayload;
		[NullAllowed, Export ("attributePayload", ArgumentSemantic.Strong)]
		AWSIoTAttributePayload AttributePayload { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }
	}

	// @interface AWSIoTCreateThingResponse
	interface AWSIoTCreateThingResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingId;
		[NullAllowed, Export ("thingId", ArgumentSemantic.Strong)]
		string ThingId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTCreateThingTypeRequest
	interface AWSIoTCreateThingTypeRequest
	{
		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingTypeProperties * _Nullable thingTypeProperties;
		[NullAllowed, Export ("thingTypeProperties", ArgumentSemantic.Strong)]
		AWSIoTThingTypeProperties ThingTypeProperties { get; set; }
	}

	// @interface AWSIoTCreateThingTypeResponse
	interface AWSIoTCreateThingTypeResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable thingTypeArn;
		[NullAllowed, Export ("thingTypeArn", ArgumentSemantic.Strong)]
		string ThingTypeArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeId;
		[NullAllowed, Export ("thingTypeId", ArgumentSemantic.Strong)]
		string ThingTypeId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }
	}

	// @interface AWSIoTCreateTopicRuleDestinationRequest
	interface AWSIoTCreateTopicRuleDestinationRequest
	{
		// @property (nonatomic, strong) AWSIoTTopicRuleDestinationConfiguration * _Nullable destinationConfiguration;
		[NullAllowed, Export ("destinationConfiguration", ArgumentSemantic.Strong)]
		AWSIoTTopicRuleDestinationConfiguration DestinationConfiguration { get; set; }
	}

	// @interface AWSIoTCreateTopicRuleDestinationResponse
	interface AWSIoTCreateTopicRuleDestinationResponse
	{
		// @property (nonatomic, strong) AWSIoTTopicRuleDestination * _Nullable topicRuleDestination;
		[NullAllowed, Export ("topicRuleDestination", ArgumentSemantic.Strong)]
		AWSIoTTopicRuleDestination TopicRuleDestination { get; set; }
	}

	// @interface AWSIoTCreateTopicRuleRequest
	interface AWSIoTCreateTopicRuleRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		string Tags { get; set; }

		// @property (nonatomic, strong) AWSIoTTopicRulePayload * _Nullable topicRulePayload;
		[NullAllowed, Export ("topicRulePayload", ArgumentSemantic.Strong)]
		AWSIoTTopicRulePayload TopicRulePayload { get; set; }
	}

	// @interface AWSIoTCustomCodeSigning
	interface AWSIoTCustomCodeSigning
	{
		// @property (nonatomic, strong) AWSIoTCodeSigningCertificateChain * _Nullable certificateChain;
		[NullAllowed, Export ("certificateChain", ArgumentSemantic.Strong)]
		AWSIoTCodeSigningCertificateChain CertificateChain { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable hashAlgorithm;
		[NullAllowed, Export ("hashAlgorithm", ArgumentSemantic.Strong)]
		string HashAlgorithm { get; set; }

		// @property (nonatomic, strong) AWSIoTCodeSigningSignature * _Nullable signature;
		[NullAllowed, Export ("signature", ArgumentSemantic.Strong)]
		AWSIoTCodeSigningSignature Signature { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable signatureAlgorithm;
		[NullAllowed, Export ("signatureAlgorithm", ArgumentSemantic.Strong)]
		string SignatureAlgorithm { get; set; }
	}

	// @interface AWSIoTDeleteAccountAuditConfigurationRequest
	interface AWSIoTDeleteAccountAuditConfigurationRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable deleteScheduledAudits;
		[NullAllowed, Export ("deleteScheduledAudits", ArgumentSemantic.Strong)]
		NSNumber DeleteScheduledAudits { get; set; }
	}

	// @interface AWSIoTDeleteAccountAuditConfigurationResponse
	interface AWSIoTDeleteAccountAuditConfigurationResponse
	{
	}

	// @interface AWSIoTDeleteAuditSuppressionRequest
	interface AWSIoTDeleteAuditSuppressionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }
	}

	// @interface AWSIoTDeleteAuditSuppressionResponse
	interface AWSIoTDeleteAuditSuppressionResponse
	{
	}

	// @interface AWSIoTDeleteAuthorizerRequest
	interface AWSIoTDeleteAuthorizerRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }
	}

	// @interface AWSIoTDeleteAuthorizerResponse
	interface AWSIoTDeleteAuthorizerResponse
	{
	}

	// @interface AWSIoTDeleteBillingGroupRequest
	interface AWSIoTDeleteBillingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }
	}

	// @interface AWSIoTDeleteBillingGroupResponse
	interface AWSIoTDeleteBillingGroupResponse
	{
	}

	// @interface AWSIoTDeleteCACertificateRequest
	interface AWSIoTDeleteCACertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }
	}

	// @interface AWSIoTDeleteCACertificateResponse
	interface AWSIoTDeleteCACertificateResponse
	{
	}

	// @interface AWSIoTDeleteCertificateRequest
	interface AWSIoTDeleteCertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable forceDelete;
		[NullAllowed, Export ("forceDelete", ArgumentSemantic.Strong)]
		NSNumber ForceDelete { get; set; }
	}

	// @interface AWSIoTDeleteCustomMetricRequest
	interface AWSIoTDeleteCustomMetricRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTDeleteCustomMetricResponse
	interface AWSIoTDeleteCustomMetricResponse
	{
	}

	// @interface AWSIoTDeleteDimensionRequest
	interface AWSIoTDeleteDimensionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }
	}

	// @interface AWSIoTDeleteDimensionResponse
	interface AWSIoTDeleteDimensionResponse
	{
	}

	// @interface AWSIoTDeleteDomainConfigurationRequest
	interface AWSIoTDeleteDomainConfigurationRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }
	}

	// @interface AWSIoTDeleteDomainConfigurationResponse
	interface AWSIoTDeleteDomainConfigurationResponse
	{
	}

	// @interface AWSIoTDeleteDynamicThingGroupRequest
	interface AWSIoTDeleteDynamicThingGroupRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTDeleteDynamicThingGroupResponse
	interface AWSIoTDeleteDynamicThingGroupResponse
	{
	}

	// @interface AWSIoTDeleteFleetMetricRequest
	interface AWSIoTDeleteFleetMetricRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTDeleteJobExecutionRequest
	interface AWSIoTDeleteJobExecutionRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable executionNumber;
		[NullAllowed, Export ("executionNumber", ArgumentSemantic.Strong)]
		NSNumber ExecutionNumber { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable force;
		[NullAllowed, Export ("force", ArgumentSemantic.Strong)]
		NSNumber Force { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDeleteJobRequest
	interface AWSIoTDeleteJobRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable force;
		[NullAllowed, Export ("force", ArgumentSemantic.Strong)]
		NSNumber Force { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }
	}

	// @interface AWSIoTDeleteJobTemplateRequest
	interface AWSIoTDeleteJobTemplateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable jobTemplateId;
		[NullAllowed, Export ("jobTemplateId", ArgumentSemantic.Strong)]
		string JobTemplateId { get; set; }
	}

	// @interface AWSIoTDeleteMitigationActionRequest
	interface AWSIoTDeleteMitigationActionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }
	}

	// @interface AWSIoTDeleteMitigationActionResponse
	interface AWSIoTDeleteMitigationActionResponse
	{
	}

	// @interface AWSIoTDeleteOTAUpdateRequest
	interface AWSIoTDeleteOTAUpdateRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable deleteStream;
		[NullAllowed, Export ("deleteStream", ArgumentSemantic.Strong)]
		NSNumber DeleteStream { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable forceDeleteAWSJob;
		[NullAllowed, Export ("forceDeleteAWSJob", ArgumentSemantic.Strong)]
		NSNumber ForceDeleteAWSJob { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateId;
		[NullAllowed, Export ("otaUpdateId", ArgumentSemantic.Strong)]
		string OtaUpdateId { get; set; }
	}

	// @interface AWSIoTDeleteOTAUpdateResponse
	interface AWSIoTDeleteOTAUpdateResponse
	{
	}

	// @interface AWSIoTDeletePolicyRequest
	interface AWSIoTDeletePolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTDeletePolicyVersionRequest
	interface AWSIoTDeletePolicyVersionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyVersionId;
		[NullAllowed, Export ("policyVersionId", ArgumentSemantic.Strong)]
		string PolicyVersionId { get; set; }
	}

	// @interface AWSIoTDeleteProvisioningTemplateRequest
	interface AWSIoTDeleteProvisioningTemplateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTDeleteProvisioningTemplateResponse
	interface AWSIoTDeleteProvisioningTemplateResponse
	{
	}

	// @interface AWSIoTDeleteProvisioningTemplateVersionRequest
	interface AWSIoTDeleteProvisioningTemplateVersionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable versionId;
		[NullAllowed, Export ("versionId", ArgumentSemantic.Strong)]
		NSNumber VersionId { get; set; }
	}

	// @interface AWSIoTDeleteProvisioningTemplateVersionResponse
	interface AWSIoTDeleteProvisioningTemplateVersionResponse
	{
	}

	// @interface AWSIoTDeleteRegistrationCodeRequest
	interface AWSIoTDeleteRegistrationCodeRequest
	{
	}

	// @interface AWSIoTDeleteRegistrationCodeResponse
	interface AWSIoTDeleteRegistrationCodeResponse
	{
	}

	// @interface AWSIoTDeleteRoleAliasRequest
	interface AWSIoTDeleteRoleAliasRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable roleAlias;
		[NullAllowed, Export ("roleAlias", ArgumentSemantic.Strong)]
		string RoleAlias { get; set; }
	}

	// @interface AWSIoTDeleteRoleAliasResponse
	interface AWSIoTDeleteRoleAliasResponse
	{
	}

	// @interface AWSIoTDeleteScheduledAuditRequest
	interface AWSIoTDeleteScheduledAuditRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditName;
		[NullAllowed, Export ("scheduledAuditName", ArgumentSemantic.Strong)]
		string ScheduledAuditName { get; set; }
	}

	// @interface AWSIoTDeleteScheduledAuditResponse
	interface AWSIoTDeleteScheduledAuditResponse
	{
	}

	// @interface AWSIoTDeleteSecurityProfileRequest
	interface AWSIoTDeleteSecurityProfileRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }
	}

	// @interface AWSIoTDeleteSecurityProfileResponse
	interface AWSIoTDeleteSecurityProfileResponse
	{
	}

	// @interface AWSIoTDeleteStreamRequest
	interface AWSIoTDeleteStreamRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }
	}

	// @interface AWSIoTDeleteStreamResponse
	interface AWSIoTDeleteStreamResponse
	{
	}

	// @interface AWSIoTDeleteThingGroupRequest
	interface AWSIoTDeleteThingGroupRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTDeleteThingGroupResponse
	interface AWSIoTDeleteThingGroupResponse
	{
	}

	// @interface AWSIoTDeleteThingRequest
	interface AWSIoTDeleteThingRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDeleteThingResponse
	interface AWSIoTDeleteThingResponse
	{
	}

	// @interface AWSIoTDeleteThingTypeRequest
	interface AWSIoTDeleteThingTypeRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }
	}

	// @interface AWSIoTDeleteThingTypeResponse
	interface AWSIoTDeleteThingTypeResponse
	{
	}

	// @interface AWSIoTDeleteTopicRuleDestinationRequest
	interface AWSIoTDeleteTopicRuleDestinationRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }
	}

	// @interface AWSIoTDeleteTopicRuleDestinationResponse
	interface AWSIoTDeleteTopicRuleDestinationResponse
	{
	}

	// @interface AWSIoTDeleteTopicRuleRequest
	interface AWSIoTDeleteTopicRuleRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }
	}

	// @interface AWSIoTDeleteV2LoggingLevelRequest
	interface AWSIoTDeleteV2LoggingLevelRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable targetName;
		[NullAllowed, Export ("targetName", ArgumentSemantic.Strong)]
		string TargetName { get; set; }

		// @property (assign, nonatomic) AWSIoTLogTargetType targetType;
		[Export ("targetType", ArgumentSemantic.Assign)]
		AWSIoTLogTargetType TargetType { get; set; }
	}

	// @interface AWSIoTDenied
	interface AWSIoTDenied
	{
		// @property (nonatomic, strong) AWSIoTExplicitDeny * _Nullable explicitDeny;
		[NullAllowed, Export ("explicitDeny", ArgumentSemantic.Strong)]
		AWSIoTExplicitDeny ExplicitDeny { get; set; }

		// @property (nonatomic, strong) AWSIoTImplicitDeny * _Nullable implicitDeny;
		[NullAllowed, Export ("implicitDeny", ArgumentSemantic.Strong)]
		AWSIoTImplicitDeny ImplicitDeny { get; set; }
	}

	// @interface AWSIoTDeprecateThingTypeRequest
	interface AWSIoTDeprecateThingTypeRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable undoDeprecate;
		[NullAllowed, Export ("undoDeprecate", ArgumentSemantic.Strong)]
		NSNumber UndoDeprecate { get; set; }
	}

	// @interface AWSIoTDeprecateThingTypeResponse
	interface AWSIoTDeprecateThingTypeResponse
	{
	}

	// @interface AWSIoTDescribeAccountAuditConfigurationRequest
	interface AWSIoTDescribeAccountAuditConfigurationRequest
	{
	}

	// @interface AWSIoTDescribeAccountAuditConfigurationResponse
	interface AWSIoTDescribeAccountAuditConfigurationResponse
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAuditCheckConfiguration *> * _Nullable auditCheckConfigurations;
		[NullAllowed, Export ("auditCheckConfigurations", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAuditCheckConfiguration> AuditCheckConfigurations { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAuditNotificationTarget *> * _Nullable auditNotificationTargetConfigurations;
		[NullAllowed, Export ("auditNotificationTargetConfigurations", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAuditNotificationTarget> AuditNotificationTargetConfigurations { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTDescribeAuditFindingRequest
	interface AWSIoTDescribeAuditFindingRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable findingId;
		[NullAllowed, Export ("findingId", ArgumentSemantic.Strong)]
		string FindingId { get; set; }
	}

	// @interface AWSIoTDescribeAuditFindingResponse
	interface AWSIoTDescribeAuditFindingResponse
	{
		// @property (nonatomic, strong) AWSIoTAuditFinding * _Nullable finding;
		[NullAllowed, Export ("finding", ArgumentSemantic.Strong)]
		AWSIoTAuditFinding Finding { get; set; }
	}

	// @interface AWSIoTDescribeAuditMitigationActionsTaskRequest
	interface AWSIoTDescribeAuditMitigationActionsTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTDescribeAuditMitigationActionsTaskResponse
	interface AWSIoTDescribeAuditMitigationActionsTaskResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTMitigationAction *> * _Nullable actionsDefinition;
		[NullAllowed, Export ("actionsDefinition", ArgumentSemantic.Strong)]
		AWSIoTMitigationAction[] ActionsDefinition { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSArray<NSString *> *> * _Nullable auditCheckToActionsMapping;
		[NullAllowed, Export ("auditCheckToActionsMapping", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSArray<NSString>> AuditCheckToActionsMapping { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (nonatomic, strong) AWSIoTAuditMitigationActionsTaskTarget * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		AWSIoTAuditMitigationActionsTaskTarget Target { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTTaskStatisticsForAuditCheck *> * _Nullable taskStatistics;
		[NullAllowed, Export ("taskStatistics", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTTaskStatisticsForAuditCheck> TaskStatistics { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditMitigationActionsTaskStatus taskStatus;
		[Export ("taskStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditMitigationActionsTaskStatus TaskStatus { get; set; }
	}

	// @interface AWSIoTDescribeAuditSuppressionRequest
	interface AWSIoTDescribeAuditSuppressionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }
	}

	// @interface AWSIoTDescribeAuditSuppressionResponse
	interface AWSIoTDescribeAuditSuppressionResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expirationDate;
		[NullAllowed, Export ("expirationDate", ArgumentSemantic.Strong)]
		NSDate ExpirationDate { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable suppressIndefinitely;
		[NullAllowed, Export ("suppressIndefinitely", ArgumentSemantic.Strong)]
		NSNumber SuppressIndefinitely { get; set; }
	}

	// @interface AWSIoTDescribeAuditTaskRequest
	interface AWSIoTDescribeAuditTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTDescribeAuditTaskResponse
	interface AWSIoTDescribeAuditTaskResponse
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAuditCheckDetails *> * _Nullable auditDetails;
		[NullAllowed, Export ("auditDetails", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAuditCheckDetails> AuditDetails { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditName;
		[NullAllowed, Export ("scheduledAuditName", ArgumentSemantic.Strong)]
		string ScheduledAuditName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable taskStartTime;
		[NullAllowed, Export ("taskStartTime", ArgumentSemantic.Strong)]
		NSDate TaskStartTime { get; set; }

		// @property (nonatomic, strong) AWSIoTTaskStatistics * _Nullable taskStatistics;
		[NullAllowed, Export ("taskStatistics", ArgumentSemantic.Strong)]
		AWSIoTTaskStatistics TaskStatistics { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditTaskStatus taskStatus;
		[Export ("taskStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditTaskStatus TaskStatus { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditTaskType taskType;
		[Export ("taskType", ArgumentSemantic.Assign)]
		AWSIoTAuditTaskType TaskType { get; set; }
	}

	// @interface AWSIoTDescribeAuthorizerRequest
	interface AWSIoTDescribeAuthorizerRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }
	}

	// @interface AWSIoTDescribeAuthorizerResponse
	interface AWSIoTDescribeAuthorizerResponse
	{
		// @property (nonatomic, strong) AWSIoTAuthorizerDescription * _Nullable authorizerDescription;
		[NullAllowed, Export ("authorizerDescription", ArgumentSemantic.Strong)]
		AWSIoTAuthorizerDescription AuthorizerDescription { get; set; }
	}

	// @interface AWSIoTDescribeBillingGroupRequest
	interface AWSIoTDescribeBillingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }
	}

	// @interface AWSIoTDescribeBillingGroupResponse
	interface AWSIoTDescribeBillingGroupResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupArn;
		[NullAllowed, Export ("billingGroupArn", ArgumentSemantic.Strong)]
		string BillingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupId;
		[NullAllowed, Export ("billingGroupId", ArgumentSemantic.Strong)]
		string BillingGroupId { get; set; }

		// @property (nonatomic, strong) AWSIoTBillingGroupMetadata * _Nullable billingGroupMetadata;
		[NullAllowed, Export ("billingGroupMetadata", ArgumentSemantic.Strong)]
		AWSIoTBillingGroupMetadata BillingGroupMetadata { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTBillingGroupProperties * _Nullable billingGroupProperties;
		[NullAllowed, Export ("billingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTBillingGroupProperties BillingGroupProperties { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTDescribeCACertificateRequest
	interface AWSIoTDescribeCACertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }
	}

	// @interface AWSIoTDescribeCACertificateResponse
	interface AWSIoTDescribeCACertificateResponse
	{
		// @property (nonatomic, strong) AWSIoTCACertificateDescription * _Nullable certificateDescription;
		[NullAllowed, Export ("certificateDescription", ArgumentSemantic.Strong)]
		AWSIoTCACertificateDescription CertificateDescription { get; set; }

		// @property (nonatomic, strong) AWSIoTRegistrationConfig * _Nullable registrationConfig;
		[NullAllowed, Export ("registrationConfig", ArgumentSemantic.Strong)]
		AWSIoTRegistrationConfig RegistrationConfig { get; set; }
	}

	// @interface AWSIoTDescribeCertificateRequest
	interface AWSIoTDescribeCertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }
	}

	// @interface AWSIoTDescribeCertificateResponse
	interface AWSIoTDescribeCertificateResponse
	{
		// @property (nonatomic, strong) AWSIoTCertificateDescription * _Nullable certificateDescription;
		[NullAllowed, Export ("certificateDescription", ArgumentSemantic.Strong)]
		AWSIoTCertificateDescription CertificateDescription { get; set; }
	}

	// @interface AWSIoTDescribeCustomMetricRequest
	interface AWSIoTDescribeCustomMetricRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTDescribeCustomMetricResponse
	interface AWSIoTDescribeCustomMetricResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName", ArgumentSemantic.Strong)]
		string DisplayName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricArn;
		[NullAllowed, Export ("metricArn", ArgumentSemantic.Strong)]
		string MetricArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (assign, nonatomic) AWSIoTCustomMetricType metricType;
		[Export ("metricType", ArgumentSemantic.Assign)]
		AWSIoTCustomMetricType MetricType { get; set; }
	}

	// @interface AWSIoTDescribeDefaultAuthorizerRequest
	interface AWSIoTDescribeDefaultAuthorizerRequest
	{
	}

	// @interface AWSIoTDescribeDefaultAuthorizerResponse
	interface AWSIoTDescribeDefaultAuthorizerResponse
	{
		// @property (nonatomic, strong) AWSIoTAuthorizerDescription * _Nullable authorizerDescription;
		[NullAllowed, Export ("authorizerDescription", ArgumentSemantic.Strong)]
		AWSIoTAuthorizerDescription AuthorizerDescription { get; set; }
	}

	// @interface AWSIoTDescribeDetectMitigationActionsTaskRequest
	interface AWSIoTDescribeDetectMitigationActionsTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTDescribeDetectMitigationActionsTaskResponse
	interface AWSIoTDescribeDetectMitigationActionsTaskResponse
	{
		// @property (nonatomic, strong) AWSIoTDetectMitigationActionsTaskSummary * _Nullable taskSummary;
		[NullAllowed, Export ("taskSummary", ArgumentSemantic.Strong)]
		AWSIoTDetectMitigationActionsTaskSummary TaskSummary { get; set; }
	}

	// @interface AWSIoTDescribeDimensionRequest
	interface AWSIoTDescribeDimensionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }
	}

	// @interface AWSIoTDescribeDimensionResponse
	interface AWSIoTDescribeDimensionResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable stringValues;
		[NullAllowed, Export ("stringValues", ArgumentSemantic.Strong)]
		string[] StringValues { get; set; }

		// @property (assign, nonatomic) AWSIoTDimensionType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSIoTDimensionType Types { get; set; }
	}

	// @interface AWSIoTDescribeDomainConfigurationRequest
	interface AWSIoTDescribeDomainConfigurationRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }
	}

	// @interface AWSIoTDescribeDomainConfigurationResponse
	interface AWSIoTDescribeDomainConfigurationResponse
	{
		// @property (nonatomic, strong) AWSIoTAuthorizerConfig * _Nullable authorizerConfig;
		[NullAllowed, Export ("authorizerConfig", ArgumentSemantic.Strong)]
		AWSIoTAuthorizerConfig AuthorizerConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationArn;
		[NullAllowed, Export ("domainConfigurationArn", ArgumentSemantic.Strong)]
		string DomainConfigurationArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }

		// @property (assign, nonatomic) AWSIoTDomainConfigurationStatus domainConfigurationStatus;
		[Export ("domainConfigurationStatus", ArgumentSemantic.Assign)]
		AWSIoTDomainConfigurationStatus DomainConfigurationStatus { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainName;
		[NullAllowed, Export ("domainName", ArgumentSemantic.Strong)]
		string DomainName { get; set; }

		// @property (assign, nonatomic) AWSIoTDomainType domainType;
		[Export ("domainType", ArgumentSemantic.Assign)]
		AWSIoTDomainType DomainType { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastStatusChangeDate;
		[NullAllowed, Export ("lastStatusChangeDate", ArgumentSemantic.Strong)]
		NSDate LastStatusChangeDate { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTServerCertificateSummary *> * _Nullable serverCertificates;
		[NullAllowed, Export ("serverCertificates", ArgumentSemantic.Strong)]
		AWSIoTServerCertificateSummary[] ServerCertificates { get; set; }

		// @property (assign, nonatomic) AWSIoTServiceType serviceType;
		[Export ("serviceType", ArgumentSemantic.Assign)]
		AWSIoTServiceType ServiceType { get; set; }
	}

	// @interface AWSIoTDescribeEndpointRequest
	interface AWSIoTDescribeEndpointRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable endpointType;
		[NullAllowed, Export ("endpointType", ArgumentSemantic.Strong)]
		string EndpointType { get; set; }
	}

	// @interface AWSIoTDescribeEndpointResponse
	interface AWSIoTDescribeEndpointResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable endpointAddress;
		[NullAllowed, Export ("endpointAddress", ArgumentSemantic.Strong)]
		string EndpointAddress { get; set; }
	}

	// @interface AWSIoTDescribeEventConfigurationsRequest
	interface AWSIoTDescribeEventConfigurationsRequest
	{
	}

	// @interface AWSIoTDescribeEventConfigurationsResponse
	interface AWSIoTDescribeEventConfigurationsResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTConfiguration *> * _Nullable eventConfigurations;
		[NullAllowed, Export ("eventConfigurations", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTConfiguration> EventConfigurations { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }
	}

	// @interface AWSIoTDescribeFleetMetricRequest
	interface AWSIoTDescribeFleetMetricRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTDescribeFleetMetricResponse
	interface AWSIoTDescribeFleetMetricResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable aggregationField;
		[NullAllowed, Export ("aggregationField", ArgumentSemantic.Strong)]
		string AggregationField { get; set; }

		// @property (nonatomic, strong) AWSIoTAggregationType * _Nullable aggregationType;
		[NullAllowed, Export ("aggregationType", ArgumentSemantic.Strong)]
		AWSIoTAggregationType AggregationType { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricArn;
		[NullAllowed, Export ("metricArn", ArgumentSemantic.Strong)]
		string MetricArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable period;
		[NullAllowed, Export ("period", ArgumentSemantic.Strong)]
		NSNumber Period { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }

		// @property (assign, nonatomic) AWSIoTFleetMetricUnit unit;
		[Export ("unit", ArgumentSemantic.Assign)]
		AWSIoTFleetMetricUnit Unit { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTDescribeIndexRequest
	interface AWSIoTDescribeIndexRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }
	}

	// @interface AWSIoTDescribeIndexResponse
	interface AWSIoTDescribeIndexResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (assign, nonatomic) AWSIoTIndexStatus indexStatus;
		[Export ("indexStatus", ArgumentSemantic.Assign)]
		AWSIoTIndexStatus IndexStatus { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable schema;
		[NullAllowed, Export ("schema", ArgumentSemantic.Strong)]
		string Schema { get; set; }
	}

	// @interface AWSIoTDescribeJobExecutionRequest
	interface AWSIoTDescribeJobExecutionRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable executionNumber;
		[NullAllowed, Export ("executionNumber", ArgumentSemantic.Strong)]
		NSNumber ExecutionNumber { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDescribeJobExecutionResponse
	interface AWSIoTDescribeJobExecutionResponse
	{
		// @property (nonatomic, strong) AWSIoTJobExecution * _Nullable execution;
		[NullAllowed, Export ("execution", ArgumentSemantic.Strong)]
		AWSIoTJobExecution Execution { get; set; }
	}

	// @interface AWSIoTDescribeJobRequest
	interface AWSIoTDescribeJobRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }
	}

	// @interface AWSIoTDescribeJobResponse
	interface AWSIoTDescribeJobResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable documentSource;
		[NullAllowed, Export ("documentSource", ArgumentSemantic.Strong)]
		string DocumentSource { get; set; }

		// @property (nonatomic, strong) AWSIoTJob * _Nullable job;
		[NullAllowed, Export ("job", ArgumentSemantic.Strong)]
		AWSIoTJob Job { get; set; }
	}

	// @interface AWSIoTDescribeJobTemplateRequest
	interface AWSIoTDescribeJobTemplateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable jobTemplateId;
		[NullAllowed, Export ("jobTemplateId", ArgumentSemantic.Strong)]
		string JobTemplateId { get; set; }
	}

	// @interface AWSIoTDescribeJobTemplateResponse
	interface AWSIoTDescribeJobTemplateResponse
	{
		// @property (nonatomic, strong) AWSIoTAbortConfig * _Nullable abortConfig;
		[NullAllowed, Export ("abortConfig", ArgumentSemantic.Strong)]
		AWSIoTAbortConfig AbortConfig { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable document;
		[NullAllowed, Export ("document", ArgumentSemantic.Strong)]
		string Document { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable documentSource;
		[NullAllowed, Export ("documentSource", ArgumentSemantic.Strong)]
		string DocumentSource { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRetryConfig * _Nullable jobExecutionsRetryConfig;
		[NullAllowed, Export ("jobExecutionsRetryConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRolloutConfig * _Nullable jobExecutionsRolloutConfig;
		[NullAllowed, Export ("jobExecutionsRolloutConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateArn;
		[NullAllowed, Export ("jobTemplateArn", ArgumentSemantic.Strong)]
		string JobTemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateId;
		[NullAllowed, Export ("jobTemplateId", ArgumentSemantic.Strong)]
		string JobTemplateId { get; set; }

		// @property (nonatomic, strong) AWSIoTPresignedUrlConfig * _Nullable presignedUrlConfig;
		[NullAllowed, Export ("presignedUrlConfig", ArgumentSemantic.Strong)]
		AWSIoTPresignedUrlConfig PresignedUrlConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTTimeoutConfig * _Nullable timeoutConfig;
		[NullAllowed, Export ("timeoutConfig", ArgumentSemantic.Strong)]
		AWSIoTTimeoutConfig TimeoutConfig { get; set; }
	}

	// @interface AWSIoTDescribeManagedJobTemplateRequest
	interface AWSIoTDescribeManagedJobTemplateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateVersion;
		[NullAllowed, Export ("templateVersion", ArgumentSemantic.Strong)]
		string TemplateVersion { get; set; }
	}

	// @interface AWSIoTDescribeManagedJobTemplateResponse
	interface AWSIoTDescribeManagedJobTemplateResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable document;
		[NullAllowed, Export ("document", ArgumentSemantic.Strong)]
		string Document { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTDocumentParameter *> * _Nullable documentParameters;
		[NullAllowed, Export ("documentParameters", ArgumentSemantic.Strong)]
		AWSIoTDocumentParameter[] DocumentParameters { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable environments;
		[NullAllowed, Export ("environments", ArgumentSemantic.Strong)]
		string[] Environments { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateArn;
		[NullAllowed, Export ("templateArn", ArgumentSemantic.Strong)]
		string TemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateVersion;
		[NullAllowed, Export ("templateVersion", ArgumentSemantic.Strong)]
		string TemplateVersion { get; set; }
	}

	// @interface AWSIoTDescribeMitigationActionRequest
	interface AWSIoTDescribeMitigationActionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }
	}

	// @interface AWSIoTDescribeMitigationActionResponse
	interface AWSIoTDescribeMitigationActionResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable actionArn;
		[NullAllowed, Export ("actionArn", ArgumentSemantic.Strong)]
		string ActionArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable actionId;
		[NullAllowed, Export ("actionId", ArgumentSemantic.Strong)]
		string ActionId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }

		// @property (nonatomic, strong) AWSIoTMitigationActionParams * _Nullable actionParams;
		[NullAllowed, Export ("actionParams", ArgumentSemantic.Strong)]
		AWSIoTMitigationActionParams ActionParams { get; set; }

		// @property (assign, nonatomic) AWSIoTMitigationActionType actionType;
		[Export ("actionType", ArgumentSemantic.Assign)]
		AWSIoTMitigationActionType ActionType { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTDescribeProvisioningTemplateRequest
	interface AWSIoTDescribeProvisioningTemplateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTDescribeProvisioningTemplateResponse
	interface AWSIoTDescribeProvisioningTemplateResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable defaultVersionId;
		[NullAllowed, Export ("defaultVersionId", ArgumentSemantic.Strong)]
		NSNumber DefaultVersionId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable enabled;
		[NullAllowed, Export ("enabled", ArgumentSemantic.Strong)]
		NSNumber Enabled { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) AWSIoTProvisioningHook * _Nullable preProvisioningHook;
		[NullAllowed, Export ("preProvisioningHook", ArgumentSemantic.Strong)]
		AWSIoTProvisioningHook PreProvisioningHook { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable provisioningRoleArn;
		[NullAllowed, Export ("provisioningRoleArn", ArgumentSemantic.Strong)]
		string ProvisioningRoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateArn;
		[NullAllowed, Export ("templateArn", ArgumentSemantic.Strong)]
		string TemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (assign, nonatomic) AWSIoTTemplateType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSIoTTemplateType Types { get; set; }
	}

	// @interface AWSIoTDescribeProvisioningTemplateVersionRequest
	interface AWSIoTDescribeProvisioningTemplateVersionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable versionId;
		[NullAllowed, Export ("versionId", ArgumentSemantic.Strong)]
		NSNumber VersionId { get; set; }
	}

	// @interface AWSIoTDescribeProvisioningTemplateVersionResponse
	interface AWSIoTDescribeProvisioningTemplateVersionResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isDefaultVersion;
		[NullAllowed, Export ("isDefaultVersion", ArgumentSemantic.Strong)]
		NSNumber IsDefaultVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable versionId;
		[NullAllowed, Export ("versionId", ArgumentSemantic.Strong)]
		NSNumber VersionId { get; set; }
	}

	// @interface AWSIoTDescribeRoleAliasRequest
	interface AWSIoTDescribeRoleAliasRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable roleAlias;
		[NullAllowed, Export ("roleAlias", ArgumentSemantic.Strong)]
		string RoleAlias { get; set; }
	}

	// @interface AWSIoTDescribeRoleAliasResponse
	interface AWSIoTDescribeRoleAliasResponse
	{
		// @property (nonatomic, strong) AWSIoTRoleAliasDescription * _Nullable roleAliasDescription;
		[NullAllowed, Export ("roleAliasDescription", ArgumentSemantic.Strong)]
		AWSIoTRoleAliasDescription RoleAliasDescription { get; set; }
	}

	// @interface AWSIoTDescribeScheduledAuditRequest
	interface AWSIoTDescribeScheduledAuditRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditName;
		[NullAllowed, Export ("scheduledAuditName", ArgumentSemantic.Strong)]
		string ScheduledAuditName { get; set; }
	}

	// @interface AWSIoTDescribeScheduledAuditResponse
	interface AWSIoTDescribeScheduledAuditResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable dayOfMonth;
		[NullAllowed, Export ("dayOfMonth", ArgumentSemantic.Strong)]
		string DayOfMonth { get; set; }

		// @property (assign, nonatomic) AWSIoTDayOfWeek dayOfWeek;
		[Export ("dayOfWeek", ArgumentSemantic.Assign)]
		AWSIoTDayOfWeek DayOfWeek { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditFrequency frequency;
		[Export ("frequency", ArgumentSemantic.Assign)]
		AWSIoTAuditFrequency Frequency { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditArn;
		[NullAllowed, Export ("scheduledAuditArn", ArgumentSemantic.Strong)]
		string ScheduledAuditArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditName;
		[NullAllowed, Export ("scheduledAuditName", ArgumentSemantic.Strong)]
		string ScheduledAuditName { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targetCheckNames;
		[NullAllowed, Export ("targetCheckNames", ArgumentSemantic.Strong)]
		string[] TargetCheckNames { get; set; }
	}

	// @interface AWSIoTDescribeSecurityProfileRequest
	interface AWSIoTDescribeSecurityProfileRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }
	}

	// @interface AWSIoTDescribeSecurityProfileResponse
	interface AWSIoTDescribeSecurityProfileResponse
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable additionalMetricsToRetain;
		[NullAllowed, Export ("additionalMetricsToRetain", ArgumentSemantic.Strong)]
		string[] AdditionalMetricsToRetain { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTMetricToRetain *> * _Nullable additionalMetricsToRetainV2;
		[NullAllowed, Export ("additionalMetricsToRetainV2", ArgumentSemantic.Strong)]
		AWSIoTMetricToRetain[] AdditionalMetricsToRetainV2 { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAlertTarget *> * _Nullable alertTargets;
		[NullAllowed, Export ("alertTargets", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAlertTarget> AlertTargets { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTBehavior *> * _Nullable behaviors;
		[NullAllowed, Export ("behaviors", ArgumentSemantic.Strong)]
		AWSIoTBehavior[] Behaviors { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileArn;
		[NullAllowed, Export ("securityProfileArn", ArgumentSemantic.Strong)]
		string SecurityProfileArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileDescription;
		[NullAllowed, Export ("securityProfileDescription", ArgumentSemantic.Strong)]
		string SecurityProfileDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTDescribeStreamRequest
	interface AWSIoTDescribeStreamRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }
	}

	// @interface AWSIoTDescribeStreamResponse
	interface AWSIoTDescribeStreamResponse
	{
		// @property (nonatomic, strong) AWSIoTStreamInfo * _Nullable streamInfo;
		[NullAllowed, Export ("streamInfo", ArgumentSemantic.Strong)]
		AWSIoTStreamInfo StreamInfo { get; set; }
	}

	// @interface AWSIoTDescribeThingGroupRequest
	interface AWSIoTDescribeThingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTDescribeThingGroupResponse
	interface AWSIoTDescribeThingGroupResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }

		// @property (assign, nonatomic) AWSIoTDynamicGroupStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTDynamicGroupStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupArn;
		[NullAllowed, Export ("thingGroupArn", ArgumentSemantic.Strong)]
		string ThingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupId;
		[NullAllowed, Export ("thingGroupId", ArgumentSemantic.Strong)]
		string ThingGroupId { get; set; }

		// @property (nonatomic, strong) AWSIoTThingGroupMetadata * _Nullable thingGroupMetadata;
		[NullAllowed, Export ("thingGroupMetadata", ArgumentSemantic.Strong)]
		AWSIoTThingGroupMetadata ThingGroupMetadata { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingGroupProperties * _Nullable thingGroupProperties;
		[NullAllowed, Export ("thingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTThingGroupProperties ThingGroupProperties { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTDescribeThingRegistrationTaskRequest
	interface AWSIoTDescribeThingRegistrationTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTDescribeThingRegistrationTaskResponse
	interface AWSIoTDescribeThingRegistrationTaskResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable failureCount;
		[NullAllowed, Export ("failureCount", ArgumentSemantic.Strong)]
		NSNumber FailureCount { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable inputFileBucket;
		[NullAllowed, Export ("inputFileBucket", ArgumentSemantic.Strong)]
		string InputFileBucket { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable inputFileKey;
		[NullAllowed, Export ("inputFileKey", ArgumentSemantic.Strong)]
		string InputFileKey { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable percentageProgress;
		[NullAllowed, Export ("percentageProgress", ArgumentSemantic.Strong)]
		NSNumber PercentageProgress { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (assign, nonatomic) AWSIoTStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTStatus Status { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable successCount;
		[NullAllowed, Export ("successCount", ArgumentSemantic.Strong)]
		NSNumber SuccessCount { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }
	}

	// @interface AWSIoTDescribeThingRequest
	interface AWSIoTDescribeThingRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDescribeThingResponse
	interface AWSIoTDescribeThingResponse
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable attributes;
		[NullAllowed, Export ("attributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Attributes { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable defaultClientId;
		[NullAllowed, Export ("defaultClientId", ArgumentSemantic.Strong)]
		string DefaultClientId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingId;
		[NullAllowed, Export ("thingId", ArgumentSemantic.Strong)]
		string ThingId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTDescribeThingTypeRequest
	interface AWSIoTDescribeThingTypeRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }
	}

	// @interface AWSIoTDescribeThingTypeResponse
	interface AWSIoTDescribeThingTypeResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable thingTypeArn;
		[NullAllowed, Export ("thingTypeArn", ArgumentSemantic.Strong)]
		string ThingTypeArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeId;
		[NullAllowed, Export ("thingTypeId", ArgumentSemantic.Strong)]
		string ThingTypeId { get; set; }

		// @property (nonatomic, strong) AWSIoTThingTypeMetadata * _Nullable thingTypeMetadata;
		[NullAllowed, Export ("thingTypeMetadata", ArgumentSemantic.Strong)]
		AWSIoTThingTypeMetadata ThingTypeMetadata { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingTypeProperties * _Nullable thingTypeProperties;
		[NullAllowed, Export ("thingTypeProperties", ArgumentSemantic.Strong)]
		AWSIoTThingTypeProperties ThingTypeProperties { get; set; }
	}

	// @interface AWSIoTDestination
	interface AWSIoTDestination
	{
		// @property (nonatomic, strong) AWSIoTS3Destination * _Nullable s3Destination;
		[NullAllowed, Export ("s3Destination", ArgumentSemantic.Strong)]
		AWSIoTS3Destination S3Destination { get; set; }
	}

	// @interface AWSIoTDetachPolicyRequest
	interface AWSIoTDetachPolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		string Target { get; set; }
	}

	// @interface AWSIoTDetachPrincipalPolicyRequest
	interface AWSIoTDetachPrincipalPolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }
	}

	// @interface AWSIoTDetachSecurityProfileRequest
	interface AWSIoTDetachSecurityProfileRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileTargetArn;
		[NullAllowed, Export ("securityProfileTargetArn", ArgumentSemantic.Strong)]
		string SecurityProfileTargetArn { get; set; }
	}

	// @interface AWSIoTDetachSecurityProfileResponse
	interface AWSIoTDetachSecurityProfileResponse
	{
	}

	// @interface AWSIoTDetachThingPrincipalRequest
	interface AWSIoTDetachThingPrincipalRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDetachThingPrincipalResponse
	interface AWSIoTDetachThingPrincipalResponse
	{
	}

	// @interface AWSIoTDetectMitigationActionExecution
	interface AWSIoTDetectMitigationActionExecution
	{
		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable errorCode;
		[NullAllowed, Export ("errorCode", ArgumentSemantic.Strong)]
		string ErrorCode { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable executionEndDate;
		[NullAllowed, Export ("executionEndDate", ArgumentSemantic.Strong)]
		NSDate ExecutionEndDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable executionStartDate;
		[NullAllowed, Export ("executionStartDate", ArgumentSemantic.Strong)]
		NSDate ExecutionStartDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (assign, nonatomic) AWSIoTDetectMitigationActionExecutionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTDetectMitigationActionExecutionStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable violationId;
		[NullAllowed, Export ("violationId", ArgumentSemantic.Strong)]
		string ViolationId { get; set; }
	}

	// @interface AWSIoTDetectMitigationActionsTaskStatistics
	interface AWSIoTDetectMitigationActionsTaskStatistics
	{
		// @property (nonatomic, strong) NSNumber * _Nullable actionsExecuted;
		[NullAllowed, Export ("actionsExecuted", ArgumentSemantic.Strong)]
		NSNumber ActionsExecuted { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable actionsFailed;
		[NullAllowed, Export ("actionsFailed", ArgumentSemantic.Strong)]
		NSNumber ActionsFailed { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable actionsSkipped;
		[NullAllowed, Export ("actionsSkipped", ArgumentSemantic.Strong)]
		NSNumber ActionsSkipped { get; set; }
	}

	// @interface AWSIoTDetectMitigationActionsTaskSummary
	interface AWSIoTDetectMitigationActionsTaskSummary
	{
		// @property (nonatomic, strong) NSArray<AWSIoTMitigationAction *> * _Nullable actionsDefinition;
		[NullAllowed, Export ("actionsDefinition", ArgumentSemantic.Strong)]
		AWSIoTMitigationAction[] ActionsDefinition { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable onlyActiveViolationsIncluded;
		[NullAllowed, Export ("onlyActiveViolationsIncluded", ArgumentSemantic.Strong)]
		NSNumber OnlyActiveViolationsIncluded { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable suppressedAlertsIncluded;
		[NullAllowed, Export ("suppressedAlertsIncluded", ArgumentSemantic.Strong)]
		NSNumber SuppressedAlertsIncluded { get; set; }

		// @property (nonatomic, strong) AWSIoTDetectMitigationActionsTaskTarget * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		AWSIoTDetectMitigationActionsTaskTarget Target { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable taskEndTime;
		[NullAllowed, Export ("taskEndTime", ArgumentSemantic.Strong)]
		NSDate TaskEndTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable taskStartTime;
		[NullAllowed, Export ("taskStartTime", ArgumentSemantic.Strong)]
		NSDate TaskStartTime { get; set; }

		// @property (nonatomic, strong) AWSIoTDetectMitigationActionsTaskStatistics * _Nullable taskStatistics;
		[NullAllowed, Export ("taskStatistics", ArgumentSemantic.Strong)]
		AWSIoTDetectMitigationActionsTaskStatistics TaskStatistics { get; set; }

		// @property (assign, nonatomic) AWSIoTDetectMitigationActionsTaskStatus taskStatus;
		[Export ("taskStatus", ArgumentSemantic.Assign)]
		AWSIoTDetectMitigationActionsTaskStatus TaskStatus { get; set; }

		// @property (nonatomic, strong) AWSIoTViolationEventOccurrenceRange * _Nullable violationEventOccurrenceRange;
		[NullAllowed, Export ("violationEventOccurrenceRange", ArgumentSemantic.Strong)]
		AWSIoTViolationEventOccurrenceRange ViolationEventOccurrenceRange { get; set; }
	}

	// @interface AWSIoTDetectMitigationActionsTaskTarget
	interface AWSIoTDetectMitigationActionsTaskTarget
	{
		// @property (nonatomic, strong) NSString * _Nullable behaviorName;
		[NullAllowed, Export ("behaviorName", ArgumentSemantic.Strong)]
		string BehaviorName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable violationIds;
		[NullAllowed, Export ("violationIds", ArgumentSemantic.Strong)]
		string[] ViolationIds { get; set; }
	}

	// @interface AWSIoTDisableTopicRuleRequest
	interface AWSIoTDisableTopicRuleRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }
	}

	// @interface AWSIoTDocumentParameter
	interface AWSIoTDocumentParameter
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable example;
		[NullAllowed, Export ("example", ArgumentSemantic.Strong)]
		string Example { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable optionalValue;
		[NullAllowed, Export ("optionalValue", ArgumentSemantic.Strong)]
		NSNumber OptionalValue { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable regex;
		[NullAllowed, Export ("regex", ArgumentSemantic.Strong)]
		string Regex { get; set; }
	}

	// @interface AWSIoTDomainConfigurationSummary
	interface AWSIoTDomainConfigurationSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationArn;
		[NullAllowed, Export ("domainConfigurationArn", ArgumentSemantic.Strong)]
		string DomainConfigurationArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }

		// @property (assign, nonatomic) AWSIoTServiceType serviceType;
		[Export ("serviceType", ArgumentSemantic.Assign)]
		AWSIoTServiceType ServiceType { get; set; }
	}

	// @interface AWSIoTDynamoDBAction
	interface AWSIoTDynamoDBAction
	{
		// @property (nonatomic, strong) NSString * _Nullable hashKeyField;
		[NullAllowed, Export ("hashKeyField", ArgumentSemantic.Strong)]
		string HashKeyField { get; set; }

		// @property (assign, nonatomic) AWSIoTDynamoKeyType hashKeyType;
		[Export ("hashKeyType", ArgumentSemantic.Assign)]
		AWSIoTDynamoKeyType HashKeyType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable hashKeyValue;
		[NullAllowed, Export ("hashKeyValue", ArgumentSemantic.Strong)]
		string HashKeyValue { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable operation;
		[NullAllowed, Export ("operation", ArgumentSemantic.Strong)]
		string Operation { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable payloadField;
		[NullAllowed, Export ("payloadField", ArgumentSemantic.Strong)]
		string PayloadField { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable rangeKeyField;
		[NullAllowed, Export ("rangeKeyField", ArgumentSemantic.Strong)]
		string RangeKeyField { get; set; }

		// @property (assign, nonatomic) AWSIoTDynamoKeyType rangeKeyType;
		[Export ("rangeKeyType", ArgumentSemantic.Assign)]
		AWSIoTDynamoKeyType RangeKeyType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable rangeKeyValue;
		[NullAllowed, Export ("rangeKeyValue", ArgumentSemantic.Strong)]
		string RangeKeyValue { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tableName;
		[NullAllowed, Export ("tableName", ArgumentSemantic.Strong)]
		string TableName { get; set; }
	}

	// @interface AWSIoTDynamoDBv2Action
	interface AWSIoTDynamoDBv2Action
	{
		// @property (nonatomic, strong) AWSIoTPutItemInput * _Nullable putItem;
		[NullAllowed, Export ("putItem", ArgumentSemantic.Strong)]
		AWSIoTPutItemInput PutItem { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTEffectivePolicy
	interface AWSIoTEffectivePolicy
	{
		// @property (nonatomic, strong) NSString * _Nullable policyArn;
		[NullAllowed, Export ("policyArn", ArgumentSemantic.Strong)]
		string PolicyArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyDocument;
		[NullAllowed, Export ("policyDocument", ArgumentSemantic.Strong)]
		string PolicyDocument { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTElasticsearchAction
	interface AWSIoTElasticsearchAction
	{
		// @property (nonatomic, strong) NSString * _Nullable endpoint;
		[NullAllowed, Export ("endpoint", ArgumentSemantic.Strong)]
		string Endpoint { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable index;
		[NullAllowed, Export ("index", ArgumentSemantic.Strong)]
		string Index { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable types;
		[NullAllowed, Export ("types", ArgumentSemantic.Strong)]
		string Types { get; set; }
	}

	// @interface AWSIoTEnableIoTLoggingParams
	interface AWSIoTEnableIoTLoggingParams
	{
		// @property (assign, nonatomic) AWSIoTLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		AWSIoTLogLevel LogLevel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArnForLogging;
		[NullAllowed, Export ("roleArnForLogging", ArgumentSemantic.Strong)]
		string RoleArnForLogging { get; set; }
	}

	// @interface AWSIoTEnableTopicRuleRequest
	interface AWSIoTEnableTopicRuleRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }
	}

	// @interface AWSIoTErrorInfo
	interface AWSIoTErrorInfo
	{
		// @property (nonatomic, strong) NSString * _Nullable code;
		[NullAllowed, Export ("code", ArgumentSemantic.Strong)]
		string Code { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }
	}

	// @interface AWSIoTExplicitDeny
	interface AWSIoTExplicitDeny
	{
		// @property (nonatomic, strong) NSArray<AWSIoTPolicy *> * _Nullable policies;
		[NullAllowed, Export ("policies", ArgumentSemantic.Strong)]
		AWSIoTPolicy[] Policies { get; set; }
	}

	// @interface AWSIoTExponentialRolloutRate
	interface AWSIoTExponentialRolloutRate
	{
		// @property (nonatomic, strong) NSNumber * _Nullable baseRatePerMinute;
		[NullAllowed, Export ("baseRatePerMinute", ArgumentSemantic.Strong)]
		NSNumber BaseRatePerMinute { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable incrementFactor;
		[NullAllowed, Export ("incrementFactor", ArgumentSemantic.Strong)]
		NSNumber IncrementFactor { get; set; }

		// @property (nonatomic, strong) AWSIoTRateIncreaseCriteria * _Nullable rateIncreaseCriteria;
		[NullAllowed, Export ("rateIncreaseCriteria", ArgumentSemantic.Strong)]
		AWSIoTRateIncreaseCriteria RateIncreaseCriteria { get; set; }
	}

	// @interface AWSIoTField
	interface AWSIoTField
	{
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (assign, nonatomic) AWSIoTFieldType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSIoTFieldType Types { get; set; }
	}

	// @interface AWSIoTFileLocation
	interface AWSIoTFileLocation
	{
		// @property (nonatomic, strong) AWSIoTS3Location * _Nullable s3Location;
		[NullAllowed, Export ("s3Location", ArgumentSemantic.Strong)]
		AWSIoTS3Location S3Location { get; set; }

		// @property (nonatomic, strong) AWSIoTStream * _Nullable stream;
		[NullAllowed, Export ("stream", ArgumentSemantic.Strong)]
		AWSIoTStream Stream { get; set; }
	}

	// @interface AWSIoTFirehoseAction
	interface AWSIoTFirehoseAction
	{
		// @property (nonatomic, strong) NSNumber * _Nullable batchMode;
		[NullAllowed, Export ("batchMode", ArgumentSemantic.Strong)]
		NSNumber BatchMode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deliveryStreamName;
		[NullAllowed, Export ("deliveryStreamName", ArgumentSemantic.Strong)]
		string DeliveryStreamName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable separator;
		[NullAllowed, Export ("separator", ArgumentSemantic.Strong)]
		string Separator { get; set; }
	}

	// @interface AWSIoTFleetMetricNameAndArn
	interface AWSIoTFleetMetricNameAndArn
	{
		// @property (nonatomic, strong) NSString * _Nullable metricArn;
		[NullAllowed, Export ("metricArn", ArgumentSemantic.Strong)]
		string MetricArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTGetBehaviorModelTrainingSummariesRequest
	interface AWSIoTGetBehaviorModelTrainingSummariesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }
	}

	// @interface AWSIoTGetBehaviorModelTrainingSummariesResponse
	interface AWSIoTGetBehaviorModelTrainingSummariesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTBehaviorModelTrainingSummary *> * _Nullable summaries;
		[NullAllowed, Export ("summaries", ArgumentSemantic.Strong)]
		AWSIoTBehaviorModelTrainingSummary[] Summaries { get; set; }
	}

	// @interface AWSIoTGetBucketsAggregationRequest
	interface AWSIoTGetBucketsAggregationRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable aggregationField;
		[NullAllowed, Export ("aggregationField", ArgumentSemantic.Strong)]
		string AggregationField { get; set; }

		// @property (nonatomic, strong) AWSIoTBucketsAggregationType * _Nullable bucketsAggregationType;
		[NullAllowed, Export ("bucketsAggregationType", ArgumentSemantic.Strong)]
		AWSIoTBucketsAggregationType BucketsAggregationType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }
	}

	// @interface AWSIoTGetBucketsAggregationResponse
	interface AWSIoTGetBucketsAggregationResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTBucket *> * _Nullable buckets;
		[NullAllowed, Export ("buckets", ArgumentSemantic.Strong)]
		AWSIoTBucket[] Buckets { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable totalCount;
		[NullAllowed, Export ("totalCount", ArgumentSemantic.Strong)]
		NSNumber TotalCount { get; set; }
	}

	// @interface AWSIoTGetCardinalityRequest
	interface AWSIoTGetCardinalityRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable aggregationField;
		[NullAllowed, Export ("aggregationField", ArgumentSemantic.Strong)]
		string AggregationField { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }
	}

	// @interface AWSIoTGetCardinalityResponse
	interface AWSIoTGetCardinalityResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable cardinality;
		[NullAllowed, Export ("cardinality", ArgumentSemantic.Strong)]
		NSNumber Cardinality { get; set; }
	}

	// @interface AWSIoTGetEffectivePoliciesRequest
	interface AWSIoTGetEffectivePoliciesRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable cognitoIdentityPoolId;
		[NullAllowed, Export ("cognitoIdentityPoolId", ArgumentSemantic.Strong)]
		string CognitoIdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTGetEffectivePoliciesResponse
	interface AWSIoTGetEffectivePoliciesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTEffectivePolicy *> * _Nullable effectivePolicies;
		[NullAllowed, Export ("effectivePolicies", ArgumentSemantic.Strong)]
		AWSIoTEffectivePolicy[] EffectivePolicies { get; set; }
	}

	// @interface AWSIoTGetIndexingConfigurationRequest
	interface AWSIoTGetIndexingConfigurationRequest
	{
	}

	// @interface AWSIoTGetIndexingConfigurationResponse
	interface AWSIoTGetIndexingConfigurationResponse
	{
		// @property (nonatomic, strong) AWSIoTThingGroupIndexingConfiguration * _Nullable thingGroupIndexingConfiguration;
		[NullAllowed, Export ("thingGroupIndexingConfiguration", ArgumentSemantic.Strong)]
		AWSIoTThingGroupIndexingConfiguration ThingGroupIndexingConfiguration { get; set; }

		// @property (nonatomic, strong) AWSIoTThingIndexingConfiguration * _Nullable thingIndexingConfiguration;
		[NullAllowed, Export ("thingIndexingConfiguration", ArgumentSemantic.Strong)]
		AWSIoTThingIndexingConfiguration ThingIndexingConfiguration { get; set; }
	}

	// @interface AWSIoTGetJobDocumentRequest
	interface AWSIoTGetJobDocumentRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }
	}

	// @interface AWSIoTGetJobDocumentResponse
	interface AWSIoTGetJobDocumentResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable document;
		[NullAllowed, Export ("document", ArgumentSemantic.Strong)]
		string Document { get; set; }
	}

	// @interface AWSIoTGetLoggingOptionsRequest
	interface AWSIoTGetLoggingOptionsRequest
	{
	}

	// @interface AWSIoTGetLoggingOptionsResponse
	interface AWSIoTGetLoggingOptionsResponse
	{
		// @property (assign, nonatomic) AWSIoTLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		AWSIoTLogLevel LogLevel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTGetOTAUpdateRequest
	interface AWSIoTGetOTAUpdateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable otaUpdateId;
		[NullAllowed, Export ("otaUpdateId", ArgumentSemantic.Strong)]
		string OtaUpdateId { get; set; }
	}

	// @interface AWSIoTGetOTAUpdateResponse
	interface AWSIoTGetOTAUpdateResponse
	{
		// @property (nonatomic, strong) AWSIoTOTAUpdateInfo * _Nullable otaUpdateInfo;
		[NullAllowed, Export ("otaUpdateInfo", ArgumentSemantic.Strong)]
		AWSIoTOTAUpdateInfo OtaUpdateInfo { get; set; }
	}

	// @interface AWSIoTGetPercentilesRequest
	interface AWSIoTGetPercentilesRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable aggregationField;
		[NullAllowed, Export ("aggregationField", ArgumentSemantic.Strong)]
		string AggregationField { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * _Nullable percents;
		[NullAllowed, Export ("percents", ArgumentSemantic.Strong)]
		NSNumber[] Percents { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }
	}

	// @interface AWSIoTGetPercentilesResponse
	interface AWSIoTGetPercentilesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTPercentPair *> * _Nullable percentiles;
		[NullAllowed, Export ("percentiles", ArgumentSemantic.Strong)]
		AWSIoTPercentPair[] Percentiles { get; set; }
	}

	// @interface AWSIoTGetPolicyRequest
	interface AWSIoTGetPolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTGetPolicyResponse
	interface AWSIoTGetPolicyResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable defaultVersionId;
		[NullAllowed, Export ("defaultVersionId", ArgumentSemantic.Strong)]
		string DefaultVersionId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable generationId;
		[NullAllowed, Export ("generationId", ArgumentSemantic.Strong)]
		string GenerationId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyArn;
		[NullAllowed, Export ("policyArn", ArgumentSemantic.Strong)]
		string PolicyArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyDocument;
		[NullAllowed, Export ("policyDocument", ArgumentSemantic.Strong)]
		string PolicyDocument { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTGetPolicyVersionRequest
	interface AWSIoTGetPolicyVersionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyVersionId;
		[NullAllowed, Export ("policyVersionId", ArgumentSemantic.Strong)]
		string PolicyVersionId { get; set; }
	}

	// @interface AWSIoTGetPolicyVersionResponse
	interface AWSIoTGetPolicyVersionResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable generationId;
		[NullAllowed, Export ("generationId", ArgumentSemantic.Strong)]
		string GenerationId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isDefaultVersion;
		[NullAllowed, Export ("isDefaultVersion", ArgumentSemantic.Strong)]
		NSNumber IsDefaultVersion { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyArn;
		[NullAllowed, Export ("policyArn", ArgumentSemantic.Strong)]
		string PolicyArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyDocument;
		[NullAllowed, Export ("policyDocument", ArgumentSemantic.Strong)]
		string PolicyDocument { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyVersionId;
		[NullAllowed, Export ("policyVersionId", ArgumentSemantic.Strong)]
		string PolicyVersionId { get; set; }
	}

	// @interface AWSIoTGetRegistrationCodeRequest
	interface AWSIoTGetRegistrationCodeRequest
	{
	}

	// @interface AWSIoTGetRegistrationCodeResponse
	interface AWSIoTGetRegistrationCodeResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable registrationCode;
		[NullAllowed, Export ("registrationCode", ArgumentSemantic.Strong)]
		string RegistrationCode { get; set; }
	}

	// @interface AWSIoTGetStatisticsRequest
	interface AWSIoTGetStatisticsRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable aggregationField;
		[NullAllowed, Export ("aggregationField", ArgumentSemantic.Strong)]
		string AggregationField { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }
	}

	// @interface AWSIoTGetStatisticsResponse
	interface AWSIoTGetStatisticsResponse
	{
		// @property (nonatomic, strong) AWSIoTStatistics * _Nullable statistics;
		[NullAllowed, Export ("statistics", ArgumentSemantic.Strong)]
		AWSIoTStatistics Statistics { get; set; }
	}

	// @interface AWSIoTGetTopicRuleDestinationRequest
	interface AWSIoTGetTopicRuleDestinationRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }
	}

	// @interface AWSIoTGetTopicRuleDestinationResponse
	interface AWSIoTGetTopicRuleDestinationResponse
	{
		// @property (nonatomic, strong) AWSIoTTopicRuleDestination * _Nullable topicRuleDestination;
		[NullAllowed, Export ("topicRuleDestination", ArgumentSemantic.Strong)]
		AWSIoTTopicRuleDestination TopicRuleDestination { get; set; }
	}

	// @interface AWSIoTGetTopicRuleRequest
	interface AWSIoTGetTopicRuleRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }
	}

	// @interface AWSIoTGetTopicRuleResponse
	interface AWSIoTGetTopicRuleResponse
	{
		// @property (nonatomic, strong) AWSIoTTopicRule * _Nullable rule;
		[NullAllowed, Export ("rule", ArgumentSemantic.Strong)]
		AWSIoTTopicRule Rule { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ruleArn;
		[NullAllowed, Export ("ruleArn", ArgumentSemantic.Strong)]
		string RuleArn { get; set; }
	}

	// @interface AWSIoTGetV2LoggingOptionsRequest
	interface AWSIoTGetV2LoggingOptionsRequest
	{
	}

	// @interface AWSIoTGetV2LoggingOptionsResponse
	interface AWSIoTGetV2LoggingOptionsResponse
	{
		// @property (assign, nonatomic) AWSIoTLogLevel defaultLogLevel;
		[Export ("defaultLogLevel", ArgumentSemantic.Assign)]
		AWSIoTLogLevel DefaultLogLevel { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable disableAllLogs;
		[NullAllowed, Export ("disableAllLogs", ArgumentSemantic.Strong)]
		NSNumber DisableAllLogs { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTGroupNameAndArn
	interface AWSIoTGroupNameAndArn
	{
		// @property (nonatomic, strong) NSString * _Nullable groupArn;
		[NullAllowed, Export ("groupArn", ArgumentSemantic.Strong)]
		string GroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable groupName;
		[NullAllowed, Export ("groupName", ArgumentSemantic.Strong)]
		string GroupName { get; set; }
	}

	// @interface AWSIoTHttpAction
	interface AWSIoTHttpAction
	{
		// @property (nonatomic, strong) AWSIoTHttpAuthorization * _Nullable auth;
		[NullAllowed, Export ("auth", ArgumentSemantic.Strong)]
		AWSIoTHttpAuthorization Auth { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable confirmationUrl;
		[NullAllowed, Export ("confirmationUrl", ArgumentSemantic.Strong)]
		string ConfirmationUrl { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTHttpActionHeader *> * _Nullable headers;
		[NullAllowed, Export ("headers", ArgumentSemantic.Strong)]
		AWSIoTHttpActionHeader[] Headers { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		string Url { get; set; }
	}

	// @interface AWSIoTHttpActionHeader
	interface AWSIoTHttpActionHeader
	{
		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSIoTHttpAuthorization
	interface AWSIoTHttpAuthorization
	{
		// @property (nonatomic, strong) AWSIoTSigV4Authorization * _Nullable sigv4;
		[NullAllowed, Export ("sigv4", ArgumentSemantic.Strong)]
		AWSIoTSigV4Authorization Sigv4 { get; set; }
	}

	// @interface AWSIoTHttpContext
	interface AWSIoTHttpContext
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable headers;
		[NullAllowed, Export ("headers", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Headers { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }
	}

	// @interface AWSIoTHttpUrlDestinationConfiguration
	interface AWSIoTHttpUrlDestinationConfiguration
	{
		// @property (nonatomic, strong) NSString * _Nullable confirmationUrl;
		[NullAllowed, Export ("confirmationUrl", ArgumentSemantic.Strong)]
		string ConfirmationUrl { get; set; }
	}

	// @interface AWSIoTHttpUrlDestinationProperties
	interface AWSIoTHttpUrlDestinationProperties
	{
		// @property (nonatomic, strong) NSString * _Nullable confirmationUrl;
		[NullAllowed, Export ("confirmationUrl", ArgumentSemantic.Strong)]
		string ConfirmationUrl { get; set; }
	}

	// @interface AWSIoTHttpUrlDestinationSummary
	interface AWSIoTHttpUrlDestinationSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable confirmationUrl;
		[NullAllowed, Export ("confirmationUrl", ArgumentSemantic.Strong)]
		string ConfirmationUrl { get; set; }
	}

	// @interface AWSIoTImplicitDeny
	interface AWSIoTImplicitDeny
	{
		// @property (nonatomic, strong) NSArray<AWSIoTPolicy *> * _Nullable policies;
		[NullAllowed, Export ("policies", ArgumentSemantic.Strong)]
		AWSIoTPolicy[] Policies { get; set; }
	}

	// @interface AWSIoTIndexingFilter
	interface AWSIoTIndexingFilter
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable namedShadowNames;
		[NullAllowed, Export ("namedShadowNames", ArgumentSemantic.Strong)]
		string[] NamedShadowNames { get; set; }
	}

	// @interface AWSIoTIotAnalyticsAction
	interface AWSIoTIotAnalyticsAction
	{
		// @property (nonatomic, strong) NSNumber * _Nullable batchMode;
		[NullAllowed, Export ("batchMode", ArgumentSemantic.Strong)]
		NSNumber BatchMode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable channelArn;
		[NullAllowed, Export ("channelArn", ArgumentSemantic.Strong)]
		string ChannelArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable channelName;
		[NullAllowed, Export ("channelName", ArgumentSemantic.Strong)]
		string ChannelName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTIotEventsAction
	interface AWSIoTIotEventsAction
	{
		// @property (nonatomic, strong) NSNumber * _Nullable batchMode;
		[NullAllowed, Export ("batchMode", ArgumentSemantic.Strong)]
		NSNumber BatchMode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable inputName;
		[NullAllowed, Export ("inputName", ArgumentSemantic.Strong)]
		string InputName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable messageId;
		[NullAllowed, Export ("messageId", ArgumentSemantic.Strong)]
		string MessageId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTIotSiteWiseAction
	interface AWSIoTIotSiteWiseAction
	{
		// @property (nonatomic, strong) NSArray<AWSIoTPutAssetPropertyValueEntry *> * _Nullable putAssetPropertyValueEntries;
		[NullAllowed, Export ("putAssetPropertyValueEntries", ArgumentSemantic.Strong)]
		AWSIoTPutAssetPropertyValueEntry[] PutAssetPropertyValueEntries { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTIssuerCertificateIdentifier
	interface AWSIoTIssuerCertificateIdentifier
	{
		// @property (nonatomic, strong) NSString * _Nullable issuerCertificateSerialNumber;
		[NullAllowed, Export ("issuerCertificateSerialNumber", ArgumentSemantic.Strong)]
		string IssuerCertificateSerialNumber { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable issuerCertificateSubject;
		[NullAllowed, Export ("issuerCertificateSubject", ArgumentSemantic.Strong)]
		string IssuerCertificateSubject { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable issuerId;
		[NullAllowed, Export ("issuerId", ArgumentSemantic.Strong)]
		string IssuerId { get; set; }
	}

	// @interface AWSIoTJob
	interface AWSIoTJob
	{
		// @property (nonatomic, strong) AWSIoTAbortConfig * _Nullable abortConfig;
		[NullAllowed, Export ("abortConfig", ArgumentSemantic.Strong)]
		AWSIoTAbortConfig AbortConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable comment;
		[NullAllowed, Export ("comment", ArgumentSemantic.Strong)]
		string Comment { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable completedAt;
		[NullAllowed, Export ("completedAt", ArgumentSemantic.Strong)]
		NSDate CompletedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable documentParameters;
		[NullAllowed, Export ("documentParameters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> DocumentParameters { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable forceCanceled;
		[NullAllowed, Export ("forceCanceled", ArgumentSemantic.Strong)]
		NSNumber ForceCanceled { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isConcurrent;
		[NullAllowed, Export ("isConcurrent", ArgumentSemantic.Strong)]
		NSNumber IsConcurrent { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobArn;
		[NullAllowed, Export ("jobArn", ArgumentSemantic.Strong)]
		string JobArn { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRetryConfig * _Nullable jobExecutionsRetryConfig;
		[NullAllowed, Export ("jobExecutionsRetryConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRolloutConfig * _Nullable jobExecutionsRolloutConfig;
		[NullAllowed, Export ("jobExecutionsRolloutConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) AWSIoTJobProcessDetails * _Nullable jobProcessDetails;
		[NullAllowed, Export ("jobProcessDetails", ArgumentSemantic.Strong)]
		AWSIoTJobProcessDetails JobProcessDetails { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateArn;
		[NullAllowed, Export ("jobTemplateArn", ArgumentSemantic.Strong)]
		string JobTemplateArn { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastUpdatedAt;
		[NullAllowed, Export ("lastUpdatedAt", ArgumentSemantic.Strong)]
		NSDate LastUpdatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }

		// @property (nonatomic, strong) AWSIoTPresignedUrlConfig * _Nullable presignedUrlConfig;
		[NullAllowed, Export ("presignedUrlConfig", ArgumentSemantic.Strong)]
		AWSIoTPresignedUrlConfig PresignedUrlConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable reasonCode;
		[NullAllowed, Export ("reasonCode", ArgumentSemantic.Strong)]
		string ReasonCode { get; set; }

		// @property (nonatomic, strong) AWSIoTSchedulingConfig * _Nullable schedulingConfig;
		[NullAllowed, Export ("schedulingConfig", ArgumentSemantic.Strong)]
		AWSIoTSchedulingConfig SchedulingConfig { get; set; }

		// @property (assign, nonatomic) AWSIoTJobStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTJobStatus Status { get; set; }

		// @property (assign, nonatomic) AWSIoTTargetSelection targetSelection;
		[Export ("targetSelection", ArgumentSemantic.Assign)]
		AWSIoTTargetSelection TargetSelection { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targets;
		[NullAllowed, Export ("targets", ArgumentSemantic.Strong)]
		string[] Targets { get; set; }

		// @property (nonatomic, strong) AWSIoTTimeoutConfig * _Nullable timeoutConfig;
		[NullAllowed, Export ("timeoutConfig", ArgumentSemantic.Strong)]
		AWSIoTTimeoutConfig TimeoutConfig { get; set; }
	}

	// @interface AWSIoTJobExecution
	interface AWSIoTJobExecution
	{
		// @property (nonatomic, strong) NSNumber * _Nullable approximateSecondsBeforeTimedOut;
		[NullAllowed, Export ("approximateSecondsBeforeTimedOut", ArgumentSemantic.Strong)]
		NSNumber ApproximateSecondsBeforeTimedOut { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable executionNumber;
		[NullAllowed, Export ("executionNumber", ArgumentSemantic.Strong)]
		NSNumber ExecutionNumber { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable forceCanceled;
		[NullAllowed, Export ("forceCanceled", ArgumentSemantic.Strong)]
		NSNumber ForceCanceled { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastUpdatedAt;
		[NullAllowed, Export ("lastUpdatedAt", ArgumentSemantic.Strong)]
		NSDate LastUpdatedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable queuedAt;
		[NullAllowed, Export ("queuedAt", ArgumentSemantic.Strong)]
		NSDate QueuedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startedAt;
		[NullAllowed, Export ("startedAt", ArgumentSemantic.Strong)]
		NSDate StartedAt { get; set; }

		// @property (assign, nonatomic) AWSIoTJobExecutionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTJobExecutionStatus Status { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionStatusDetails * _Nullable statusDetails;
		[NullAllowed, Export ("statusDetails", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionStatusDetails StatusDetails { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable versionNumber;
		[NullAllowed, Export ("versionNumber", ArgumentSemantic.Strong)]
		NSNumber VersionNumber { get; set; }
	}

	// @interface AWSIoTJobExecutionStatusDetails
	interface AWSIoTJobExecutionStatusDetails
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable detailsMap;
		[NullAllowed, Export ("detailsMap", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> DetailsMap { get; set; }
	}

	// @interface AWSIoTJobExecutionSummary
	interface AWSIoTJobExecutionSummary
	{
		// @property (nonatomic, strong) NSNumber * _Nullable executionNumber;
		[NullAllowed, Export ("executionNumber", ArgumentSemantic.Strong)]
		NSNumber ExecutionNumber { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastUpdatedAt;
		[NullAllowed, Export ("lastUpdatedAt", ArgumentSemantic.Strong)]
		NSDate LastUpdatedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable queuedAt;
		[NullAllowed, Export ("queuedAt", ArgumentSemantic.Strong)]
		NSDate QueuedAt { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable retryAttempt;
		[NullAllowed, Export ("retryAttempt", ArgumentSemantic.Strong)]
		NSNumber RetryAttempt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startedAt;
		[NullAllowed, Export ("startedAt", ArgumentSemantic.Strong)]
		NSDate StartedAt { get; set; }

		// @property (assign, nonatomic) AWSIoTJobExecutionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTJobExecutionStatus Status { get; set; }
	}

	// @interface AWSIoTJobExecutionSummaryForJob
	interface AWSIoTJobExecutionSummaryForJob
	{
		// @property (nonatomic, strong) AWSIoTJobExecutionSummary * _Nullable jobExecutionSummary;
		[NullAllowed, Export ("jobExecutionSummary", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionSummary JobExecutionSummary { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }
	}

	// @interface AWSIoTJobExecutionSummaryForThing
	interface AWSIoTJobExecutionSummaryForThing
	{
		// @property (nonatomic, strong) AWSIoTJobExecutionSummary * _Nullable jobExecutionSummary;
		[NullAllowed, Export ("jobExecutionSummary", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionSummary JobExecutionSummary { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }
	}

	// @interface AWSIoTJobExecutionsRetryConfig
	interface AWSIoTJobExecutionsRetryConfig
	{
		// @property (nonatomic, strong) NSArray<AWSIoTRetryCriteria *> * _Nullable criteriaList;
		[NullAllowed, Export ("criteriaList", ArgumentSemantic.Strong)]
		AWSIoTRetryCriteria[] CriteriaList { get; set; }
	}

	// @interface AWSIoTJobExecutionsRolloutConfig
	interface AWSIoTJobExecutionsRolloutConfig
	{
		// @property (nonatomic, strong) AWSIoTExponentialRolloutRate * _Nullable exponentialRate;
		[NullAllowed, Export ("exponentialRate", ArgumentSemantic.Strong)]
		AWSIoTExponentialRolloutRate ExponentialRate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maximumPerMinute;
		[NullAllowed, Export ("maximumPerMinute", ArgumentSemantic.Strong)]
		NSNumber MaximumPerMinute { get; set; }
	}

	// @interface AWSIoTJobProcessDetails
	interface AWSIoTJobProcessDetails
	{
		// @property (nonatomic, strong) NSNumber * _Nullable numberOfCanceledThings;
		[NullAllowed, Export ("numberOfCanceledThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfCanceledThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfFailedThings;
		[NullAllowed, Export ("numberOfFailedThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfFailedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfInProgressThings;
		[NullAllowed, Export ("numberOfInProgressThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfInProgressThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfQueuedThings;
		[NullAllowed, Export ("numberOfQueuedThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfQueuedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfRejectedThings;
		[NullAllowed, Export ("numberOfRejectedThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfRejectedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfRemovedThings;
		[NullAllowed, Export ("numberOfRemovedThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfRemovedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfSucceededThings;
		[NullAllowed, Export ("numberOfSucceededThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfSucceededThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfTimedOutThings;
		[NullAllowed, Export ("numberOfTimedOutThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfTimedOutThings { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable processingTargets;
		[NullAllowed, Export ("processingTargets", ArgumentSemantic.Strong)]
		string[] ProcessingTargets { get; set; }
	}

	// @interface AWSIoTJobSummary
	interface AWSIoTJobSummary
	{
		// @property (nonatomic, strong) NSDate * _Nullable completedAt;
		[NullAllowed, Export ("completedAt", ArgumentSemantic.Strong)]
		NSDate CompletedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isConcurrent;
		[NullAllowed, Export ("isConcurrent", ArgumentSemantic.Strong)]
		NSNumber IsConcurrent { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobArn;
		[NullAllowed, Export ("jobArn", ArgumentSemantic.Strong)]
		string JobArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastUpdatedAt;
		[NullAllowed, Export ("lastUpdatedAt", ArgumentSemantic.Strong)]
		NSDate LastUpdatedAt { get; set; }

		// @property (assign, nonatomic) AWSIoTJobStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTJobStatus Status { get; set; }

		// @property (assign, nonatomic) AWSIoTTargetSelection targetSelection;
		[Export ("targetSelection", ArgumentSemantic.Assign)]
		AWSIoTTargetSelection TargetSelection { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupId;
		[NullAllowed, Export ("thingGroupId", ArgumentSemantic.Strong)]
		string ThingGroupId { get; set; }
	}

	// @interface AWSIoTJobTemplateSummary
	interface AWSIoTJobTemplateSummary
	{
		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateArn;
		[NullAllowed, Export ("jobTemplateArn", ArgumentSemantic.Strong)]
		string JobTemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobTemplateId;
		[NullAllowed, Export ("jobTemplateId", ArgumentSemantic.Strong)]
		string JobTemplateId { get; set; }
	}

	// @interface AWSIoTKafkaAction
	interface AWSIoTKafkaAction
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable clientProperties;
		[NullAllowed, Export ("clientProperties", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> ClientProperties { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable destinationArn;
		[NullAllowed, Export ("destinationArn", ArgumentSemantic.Strong)]
		string DestinationArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable partition;
		[NullAllowed, Export ("partition", ArgumentSemantic.Strong)]
		string Partition { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable topic;
		[NullAllowed, Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }
	}

	// @interface AWSIoTKeyPair
	interface AWSIoTKeyPair
	{
		// @property (nonatomic, strong) NSString * _Nullable privateKey;
		[NullAllowed, Export ("privateKey", ArgumentSemantic.Strong)]
		string PrivateKey { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable publicKey;
		[NullAllowed, Export ("publicKey", ArgumentSemantic.Strong)]
		string PublicKey { get; set; }
	}

	// @interface AWSIoTKinesisAction
	interface AWSIoTKinesisAction
	{
		// @property (nonatomic, strong) NSString * _Nullable partitionKey;
		[NullAllowed, Export ("partitionKey", ArgumentSemantic.Strong)]
		string PartitionKey { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamName;
		[NullAllowed, Export ("streamName", ArgumentSemantic.Strong)]
		string StreamName { get; set; }
	}

	// @interface AWSIoTLambdaAction
	interface AWSIoTLambdaAction
	{
		// @property (nonatomic, strong) NSString * _Nullable functionArn;
		[NullAllowed, Export ("functionArn", ArgumentSemantic.Strong)]
		string FunctionArn { get; set; }
	}

	// @interface AWSIoTListActiveViolationsRequest
	interface AWSIoTListActiveViolationsRequest
	{
		// @property (assign, nonatomic) AWSIoTBehaviorCriteriaType behaviorCriteriaType;
		[Export ("behaviorCriteriaType", ArgumentSemantic.Assign)]
		AWSIoTBehaviorCriteriaType BehaviorCriteriaType { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable listSuppressedAlerts;
		[NullAllowed, Export ("listSuppressedAlerts", ArgumentSemantic.Strong)]
		NSNumber ListSuppressedAlerts { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (assign, nonatomic) AWSIoTVerificationState verificationState;
		[Export ("verificationState", ArgumentSemantic.Assign)]
		AWSIoTVerificationState VerificationState { get; set; }
	}

	// @interface AWSIoTListActiveViolationsResponse
	interface AWSIoTListActiveViolationsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTActiveViolation *> * _Nullable activeViolations;
		[NullAllowed, Export ("activeViolations", ArgumentSemantic.Strong)]
		AWSIoTActiveViolation[] ActiveViolations { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListAttachedPoliciesRequest
	interface AWSIoTListAttachedPoliciesRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable recursive;
		[NullAllowed, Export ("recursive", ArgumentSemantic.Strong)]
		NSNumber Recursive { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		string Target { get; set; }
	}

	// @interface AWSIoTListAttachedPoliciesResponse
	interface AWSIoTListAttachedPoliciesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTPolicy *> * _Nullable policies;
		[NullAllowed, Export ("policies", ArgumentSemantic.Strong)]
		AWSIoTPolicy[] Policies { get; set; }
	}

	// @interface AWSIoTListAuditFindingsRequest
	interface AWSIoTListAuditFindingsRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable listSuppressedFindings;
		[NullAllowed, Export ("listSuppressedFindings", ArgumentSemantic.Strong)]
		NSNumber ListSuppressedFindings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTListAuditFindingsResponse
	interface AWSIoTListAuditFindingsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAuditFinding *> * _Nullable findings;
		[NullAllowed, Export ("findings", ArgumentSemantic.Strong)]
		AWSIoTAuditFinding[] Findings { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListAuditMitigationActionsExecutionsRequest
	interface AWSIoTListAuditMitigationActionsExecutionsRequest
	{
		// @property (assign, nonatomic) AWSIoTAuditMitigationActionsExecutionStatus actionStatus;
		[Export ("actionStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditMitigationActionsExecutionStatus ActionStatus { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable findingId;
		[NullAllowed, Export ("findingId", ArgumentSemantic.Strong)]
		string FindingId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTListAuditMitigationActionsExecutionsResponse
	interface AWSIoTListAuditMitigationActionsExecutionsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAuditMitigationActionExecutionMetadata *> * _Nullable actionsExecutions;
		[NullAllowed, Export ("actionsExecutions", ArgumentSemantic.Strong)]
		AWSIoTAuditMitigationActionExecutionMetadata[] ActionsExecutions { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListAuditMitigationActionsTasksRequest
	interface AWSIoTListAuditMitigationActionsTasksRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable auditTaskId;
		[NullAllowed, Export ("auditTaskId", ArgumentSemantic.Strong)]
		string AuditTaskId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable findingId;
		[NullAllowed, Export ("findingId", ArgumentSemantic.Strong)]
		string FindingId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditMitigationActionsTaskStatus taskStatus;
		[Export ("taskStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditMitigationActionsTaskStatus TaskStatus { get; set; }
	}

	// @interface AWSIoTListAuditMitigationActionsTasksResponse
	interface AWSIoTListAuditMitigationActionsTasksResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTAuditMitigationActionsTaskMetadata *> * _Nullable tasks;
		[NullAllowed, Export ("tasks", ArgumentSemantic.Strong)]
		AWSIoTAuditMitigationActionsTaskMetadata[] Tasks { get; set; }
	}

	// @interface AWSIoTListAuditSuppressionsRequest
	interface AWSIoTListAuditSuppressionsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }
	}

	// @interface AWSIoTListAuditSuppressionsResponse
	interface AWSIoTListAuditSuppressionsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTAuditSuppression *> * _Nullable suppressions;
		[NullAllowed, Export ("suppressions", ArgumentSemantic.Strong)]
		AWSIoTAuditSuppression[] Suppressions { get; set; }
	}

	// @interface AWSIoTListAuditTasksRequest
	interface AWSIoTListAuditTasksRequest
	{
		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditTaskStatus taskStatus;
		[Export ("taskStatus", ArgumentSemantic.Assign)]
		AWSIoTAuditTaskStatus TaskStatus { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditTaskType taskType;
		[Export ("taskType", ArgumentSemantic.Assign)]
		AWSIoTAuditTaskType TaskType { get; set; }
	}

	// @interface AWSIoTListAuditTasksResponse
	interface AWSIoTListAuditTasksResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTAuditTaskMetadata *> * _Nullable tasks;
		[NullAllowed, Export ("tasks", ArgumentSemantic.Strong)]
		AWSIoTAuditTaskMetadata[] Tasks { get; set; }
	}

	// @interface AWSIoTListAuthorizersRequest
	interface AWSIoTListAuthorizersRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (assign, nonatomic) AWSIoTAuthorizerStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTAuthorizerStatus Status { get; set; }
	}

	// @interface AWSIoTListAuthorizersResponse
	interface AWSIoTListAuthorizersResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAuthorizerSummary *> * _Nullable authorizers;
		[NullAllowed, Export ("authorizers", ArgumentSemantic.Strong)]
		AWSIoTAuthorizerSummary[] Authorizers { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }
	}

	// @interface AWSIoTListBillingGroupsRequest
	interface AWSIoTListBillingGroupsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namePrefixFilter;
		[NullAllowed, Export ("namePrefixFilter", ArgumentSemantic.Strong)]
		string NamePrefixFilter { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListBillingGroupsResponse
	interface AWSIoTListBillingGroupsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTGroupNameAndArn *> * _Nullable billingGroups;
		[NullAllowed, Export ("billingGroups", ArgumentSemantic.Strong)]
		AWSIoTGroupNameAndArn[] BillingGroups { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListCACertificatesRequest
	interface AWSIoTListCACertificatesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTListCACertificatesResponse
	interface AWSIoTListCACertificatesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTCACertificate *> * _Nullable certificates;
		[NullAllowed, Export ("certificates", ArgumentSemantic.Strong)]
		AWSIoTCACertificate[] Certificates { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }
	}

	// @interface AWSIoTListCertificatesByCARequest
	interface AWSIoTListCertificatesByCARequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable caCertificateId;
		[NullAllowed, Export ("caCertificateId", ArgumentSemantic.Strong)]
		string CaCertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }
	}

	// @interface AWSIoTListCertificatesByCAResponse
	interface AWSIoTListCertificatesByCAResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTCertificate *> * _Nullable certificates;
		[NullAllowed, Export ("certificates", ArgumentSemantic.Strong)]
		AWSIoTCertificate[] Certificates { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }
	}

	// @interface AWSIoTListCertificatesRequest
	interface AWSIoTListCertificatesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }
	}

	// @interface AWSIoTListCertificatesResponse
	interface AWSIoTListCertificatesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTCertificate *> * _Nullable certificates;
		[NullAllowed, Export ("certificates", ArgumentSemantic.Strong)]
		AWSIoTCertificate[] Certificates { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }
	}

	// @interface AWSIoTListCustomMetricsRequest
	interface AWSIoTListCustomMetricsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListCustomMetricsResponse
	interface AWSIoTListCustomMetricsResponse
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable metricNames;
		[NullAllowed, Export ("metricNames", ArgumentSemantic.Strong)]
		string[] MetricNames { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListDetectMitigationActionsExecutionsRequest
	interface AWSIoTListDetectMitigationActionsExecutionsRequest
	{
		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable violationId;
		[NullAllowed, Export ("violationId", ArgumentSemantic.Strong)]
		string ViolationId { get; set; }
	}

	// @interface AWSIoTListDetectMitigationActionsExecutionsResponse
	interface AWSIoTListDetectMitigationActionsExecutionsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTDetectMitigationActionExecution *> * _Nullable actionsExecutions;
		[NullAllowed, Export ("actionsExecutions", ArgumentSemantic.Strong)]
		AWSIoTDetectMitigationActionExecution[] ActionsExecutions { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListDetectMitigationActionsTasksRequest
	interface AWSIoTListDetectMitigationActionsTasksRequest
	{
		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }
	}

	// @interface AWSIoTListDetectMitigationActionsTasksResponse
	interface AWSIoTListDetectMitigationActionsTasksResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTDetectMitigationActionsTaskSummary *> * _Nullable tasks;
		[NullAllowed, Export ("tasks", ArgumentSemantic.Strong)]
		AWSIoTDetectMitigationActionsTaskSummary[] Tasks { get; set; }
	}

	// @interface AWSIoTListDimensionsRequest
	interface AWSIoTListDimensionsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListDimensionsResponse
	interface AWSIoTListDimensionsResponse
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable dimensionNames;
		[NullAllowed, Export ("dimensionNames", ArgumentSemantic.Strong)]
		string[] DimensionNames { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListDomainConfigurationsRequest
	interface AWSIoTListDomainConfigurationsRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (assign, nonatomic) AWSIoTServiceType serviceType;
		[Export ("serviceType", ArgumentSemantic.Assign)]
		AWSIoTServiceType ServiceType { get; set; }
	}

	// @interface AWSIoTListDomainConfigurationsResponse
	interface AWSIoTListDomainConfigurationsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTDomainConfigurationSummary *> * _Nullable domainConfigurations;
		[NullAllowed, Export ("domainConfigurations", ArgumentSemantic.Strong)]
		AWSIoTDomainConfigurationSummary[] DomainConfigurations { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }
	}

	// @interface AWSIoTListFleetMetricsRequest
	interface AWSIoTListFleetMetricsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListFleetMetricsResponse
	interface AWSIoTListFleetMetricsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTFleetMetricNameAndArn *> * _Nullable fleetMetrics;
		[NullAllowed, Export ("fleetMetrics", ArgumentSemantic.Strong)]
		AWSIoTFleetMetricNameAndArn[] FleetMetrics { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListIndicesRequest
	interface AWSIoTListIndicesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListIndicesResponse
	interface AWSIoTListIndicesResponse
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable indexNames;
		[NullAllowed, Export ("indexNames", ArgumentSemantic.Strong)]
		string[] IndexNames { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListJobExecutionsForJobRequest
	interface AWSIoTListJobExecutionsForJobRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTJobExecutionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTJobExecutionStatus Status { get; set; }
	}

	// @interface AWSIoTListJobExecutionsForJobResponse
	interface AWSIoTListJobExecutionsForJobResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTJobExecutionSummaryForJob *> * _Nullable executionSummaries;
		[NullAllowed, Export ("executionSummaries", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionSummaryForJob[] ExecutionSummaries { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListJobExecutionsForThingRequest
	interface AWSIoTListJobExecutionsForThingRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTJobExecutionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTJobExecutionStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTListJobExecutionsForThingResponse
	interface AWSIoTListJobExecutionsForThingResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTJobExecutionSummaryForThing *> * _Nullable executionSummaries;
		[NullAllowed, Export ("executionSummaries", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionSummaryForThing[] ExecutionSummaries { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListJobTemplatesRequest
	interface AWSIoTListJobTemplatesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListJobTemplatesResponse
	interface AWSIoTListJobTemplatesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTJobTemplateSummary *> * _Nullable jobTemplates;
		[NullAllowed, Export ("jobTemplates", ArgumentSemantic.Strong)]
		AWSIoTJobTemplateSummary[] JobTemplates { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListJobsRequest
	interface AWSIoTListJobsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTJobStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTJobStatus Status { get; set; }

		// @property (assign, nonatomic) AWSIoTTargetSelection targetSelection;
		[Export ("targetSelection", ArgumentSemantic.Assign)]
		AWSIoTTargetSelection TargetSelection { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupId;
		[NullAllowed, Export ("thingGroupId", ArgumentSemantic.Strong)]
		string ThingGroupId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTListJobsResponse
	interface AWSIoTListJobsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTJobSummary *> * _Nullable jobs;
		[NullAllowed, Export ("jobs", ArgumentSemantic.Strong)]
		AWSIoTJobSummary[] Jobs { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListManagedJobTemplatesRequest
	interface AWSIoTListManagedJobTemplatesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTListManagedJobTemplatesResponse
	interface AWSIoTListManagedJobTemplatesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTManagedJobTemplateSummary *> * _Nullable managedJobTemplates;
		[NullAllowed, Export ("managedJobTemplates", ArgumentSemantic.Strong)]
		AWSIoTManagedJobTemplateSummary[] ManagedJobTemplates { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListMetricValuesRequest
	interface AWSIoTListMetricValuesRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable dimensionName;
		[NullAllowed, Export ("dimensionName", ArgumentSemantic.Strong)]
		string DimensionName { get; set; }

		// @property (assign, nonatomic) AWSIoTDimensionValueOperator dimensionValueOperator;
		[Export ("dimensionValueOperator", ArgumentSemantic.Assign)]
		AWSIoTDimensionValueOperator DimensionValueOperator { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTListMetricValuesResponse
	interface AWSIoTListMetricValuesResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTMetricDatum *> * _Nullable metricDatumList;
		[NullAllowed, Export ("metricDatumList", ArgumentSemantic.Strong)]
		AWSIoTMetricDatum[] MetricDatumList { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListMitigationActionsRequest
	interface AWSIoTListMitigationActionsRequest
	{
		// @property (assign, nonatomic) AWSIoTMitigationActionType actionType;
		[Export ("actionType", ArgumentSemantic.Assign)]
		AWSIoTMitigationActionType ActionType { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListMitigationActionsResponse
	interface AWSIoTListMitigationActionsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTMitigationActionIdentifier *> * _Nullable actionIdentifiers;
		[NullAllowed, Export ("actionIdentifiers", ArgumentSemantic.Strong)]
		AWSIoTMitigationActionIdentifier[] ActionIdentifiers { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListOTAUpdatesRequest
	interface AWSIoTListOTAUpdatesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTOTAUpdateStatus otaUpdateStatus;
		[Export ("otaUpdateStatus", ArgumentSemantic.Assign)]
		AWSIoTOTAUpdateStatus OtaUpdateStatus { get; set; }
	}

	// @interface AWSIoTListOTAUpdatesResponse
	interface AWSIoTListOTAUpdatesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTOTAUpdateSummary *> * _Nullable otaUpdates;
		[NullAllowed, Export ("otaUpdates", ArgumentSemantic.Strong)]
		AWSIoTOTAUpdateSummary[] OtaUpdates { get; set; }
	}

	// @interface AWSIoTListOutgoingCertificatesRequest
	interface AWSIoTListOutgoingCertificatesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }
	}

	// @interface AWSIoTListOutgoingCertificatesResponse
	interface AWSIoTListOutgoingCertificatesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTOutgoingCertificate *> * _Nullable outgoingCertificates;
		[NullAllowed, Export ("outgoingCertificates", ArgumentSemantic.Strong)]
		AWSIoTOutgoingCertificate[] OutgoingCertificates { get; set; }
	}

	// @interface AWSIoTListPoliciesRequest
	interface AWSIoTListPoliciesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }
	}

	// @interface AWSIoTListPoliciesResponse
	interface AWSIoTListPoliciesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTPolicy *> * _Nullable policies;
		[NullAllowed, Export ("policies", ArgumentSemantic.Strong)]
		AWSIoTPolicy[] Policies { get; set; }
	}

	// @interface AWSIoTListPolicyPrincipalsRequest
	interface AWSIoTListPolicyPrincipalsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTListPolicyPrincipalsResponse
	interface AWSIoTListPolicyPrincipalsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable principals;
		[NullAllowed, Export ("principals", ArgumentSemantic.Strong)]
		string[] Principals { get; set; }
	}

	// @interface AWSIoTListPolicyVersionsRequest
	interface AWSIoTListPolicyVersionsRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTListPolicyVersionsResponse
	interface AWSIoTListPolicyVersionsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTPolicyVersion *> * _Nullable policyVersions;
		[NullAllowed, Export ("policyVersions", ArgumentSemantic.Strong)]
		AWSIoTPolicyVersion[] PolicyVersions { get; set; }
	}

	// @interface AWSIoTListPrincipalPoliciesRequest
	interface AWSIoTListPrincipalPoliciesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }
	}

	// @interface AWSIoTListPrincipalPoliciesResponse
	interface AWSIoTListPrincipalPoliciesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTPolicy *> * _Nullable policies;
		[NullAllowed, Export ("policies", ArgumentSemantic.Strong)]
		AWSIoTPolicy[] Policies { get; set; }
	}

	// @interface AWSIoTListPrincipalThingsRequest
	interface AWSIoTListPrincipalThingsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }
	}

	// @interface AWSIoTListPrincipalThingsResponse
	interface AWSIoTListPrincipalThingsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable things;
		[NullAllowed, Export ("things", ArgumentSemantic.Strong)]
		string[] Things { get; set; }
	}

	// @interface AWSIoTListProvisioningTemplateVersionsRequest
	interface AWSIoTListProvisioningTemplateVersionsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTListProvisioningTemplateVersionsResponse
	interface AWSIoTListProvisioningTemplateVersionsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTProvisioningTemplateVersionSummary *> * _Nullable versions;
		[NullAllowed, Export ("versions", ArgumentSemantic.Strong)]
		AWSIoTProvisioningTemplateVersionSummary[] Versions { get; set; }
	}

	// @interface AWSIoTListProvisioningTemplatesRequest
	interface AWSIoTListProvisioningTemplatesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListProvisioningTemplatesResponse
	interface AWSIoTListProvisioningTemplatesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTProvisioningTemplateSummary *> * _Nullable templates;
		[NullAllowed, Export ("templates", ArgumentSemantic.Strong)]
		AWSIoTProvisioningTemplateSummary[] Templates { get; set; }
	}

	// @interface AWSIoTListRelatedResourcesForAuditFindingRequest
	interface AWSIoTListRelatedResourcesForAuditFindingRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable findingId;
		[NullAllowed, Export ("findingId", ArgumentSemantic.Strong)]
		string FindingId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListRelatedResourcesForAuditFindingResponse
	interface AWSIoTListRelatedResourcesForAuditFindingResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTRelatedResource *> * _Nullable relatedResources;
		[NullAllowed, Export ("relatedResources", ArgumentSemantic.Strong)]
		AWSIoTRelatedResource[] RelatedResources { get; set; }
	}

	// @interface AWSIoTListRoleAliasesRequest
	interface AWSIoTListRoleAliasesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }
	}

	// @interface AWSIoTListRoleAliasesResponse
	interface AWSIoTListRoleAliasesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable roleAliases;
		[NullAllowed, Export ("roleAliases", ArgumentSemantic.Strong)]
		string[] RoleAliases { get; set; }
	}

	// @interface AWSIoTListScheduledAuditsRequest
	interface AWSIoTListScheduledAuditsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListScheduledAuditsResponse
	interface AWSIoTListScheduledAuditsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTScheduledAuditMetadata *> * _Nullable scheduledAudits;
		[NullAllowed, Export ("scheduledAudits", ArgumentSemantic.Strong)]
		AWSIoTScheduledAuditMetadata[] ScheduledAudits { get; set; }
	}

	// @interface AWSIoTListSecurityProfilesForTargetRequest
	interface AWSIoTListSecurityProfilesForTargetRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable recursive;
		[NullAllowed, Export ("recursive", ArgumentSemantic.Strong)]
		NSNumber Recursive { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileTargetArn;
		[NullAllowed, Export ("securityProfileTargetArn", ArgumentSemantic.Strong)]
		string SecurityProfileTargetArn { get; set; }
	}

	// @interface AWSIoTListSecurityProfilesForTargetResponse
	interface AWSIoTListSecurityProfilesForTargetResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTSecurityProfileTargetMapping *> * _Nullable securityProfileTargetMappings;
		[NullAllowed, Export ("securityProfileTargetMappings", ArgumentSemantic.Strong)]
		AWSIoTSecurityProfileTargetMapping[] SecurityProfileTargetMappings { get; set; }
	}

	// @interface AWSIoTListSecurityProfilesRequest
	interface AWSIoTListSecurityProfilesRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable dimensionName;
		[NullAllowed, Export ("dimensionName", ArgumentSemantic.Strong)]
		string DimensionName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListSecurityProfilesResponse
	interface AWSIoTListSecurityProfilesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTSecurityProfileIdentifier *> * _Nullable securityProfileIdentifiers;
		[NullAllowed, Export ("securityProfileIdentifiers", ArgumentSemantic.Strong)]
		AWSIoTSecurityProfileIdentifier[] SecurityProfileIdentifiers { get; set; }
	}

	// @interface AWSIoTListStreamsRequest
	interface AWSIoTListStreamsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable ascendingOrder;
		[NullAllowed, Export ("ascendingOrder", ArgumentSemantic.Strong)]
		NSNumber AscendingOrder { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListStreamsResponse
	interface AWSIoTListStreamsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTStreamSummary *> * _Nullable streams;
		[NullAllowed, Export ("streams", ArgumentSemantic.Strong)]
		AWSIoTStreamSummary[] Streams { get; set; }
	}

	// @interface AWSIoTListTagsForResourceRequest
	interface AWSIoTListTagsForResourceRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable resourceArn;
		[NullAllowed, Export ("resourceArn", ArgumentSemantic.Strong)]
		string ResourceArn { get; set; }
	}

	// @interface AWSIoTListTagsForResourceResponse
	interface AWSIoTListTagsForResourceResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTListTargetsForPolicyRequest
	interface AWSIoTListTargetsForPolicyRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable marker;
		[NullAllowed, Export ("marker", ArgumentSemantic.Strong)]
		string Marker { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTListTargetsForPolicyResponse
	interface AWSIoTListTargetsForPolicyResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextMarker;
		[NullAllowed, Export ("nextMarker", ArgumentSemantic.Strong)]
		string NextMarker { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targets;
		[NullAllowed, Export ("targets", ArgumentSemantic.Strong)]
		string[] Targets { get; set; }
	}

	// @interface AWSIoTListTargetsForSecurityProfileRequest
	interface AWSIoTListTargetsForSecurityProfileRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }
	}

	// @interface AWSIoTListTargetsForSecurityProfileResponse
	interface AWSIoTListTargetsForSecurityProfileResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTSecurityProfileTarget *> * _Nullable securityProfileTargets;
		[NullAllowed, Export ("securityProfileTargets", ArgumentSemantic.Strong)]
		AWSIoTSecurityProfileTarget[] SecurityProfileTargets { get; set; }
	}

	// @interface AWSIoTListThingGroupsForThingRequest
	interface AWSIoTListThingGroupsForThingRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTListThingGroupsForThingResponse
	interface AWSIoTListThingGroupsForThingResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTGroupNameAndArn *> * _Nullable thingGroups;
		[NullAllowed, Export ("thingGroups", ArgumentSemantic.Strong)]
		AWSIoTGroupNameAndArn[] ThingGroups { get; set; }
	}

	// @interface AWSIoTListThingGroupsRequest
	interface AWSIoTListThingGroupsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namePrefixFilter;
		[NullAllowed, Export ("namePrefixFilter", ArgumentSemantic.Strong)]
		string NamePrefixFilter { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable parentGroup;
		[NullAllowed, Export ("parentGroup", ArgumentSemantic.Strong)]
		string ParentGroup { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable recursive;
		[NullAllowed, Export ("recursive", ArgumentSemantic.Strong)]
		NSNumber Recursive { get; set; }
	}

	// @interface AWSIoTListThingGroupsResponse
	interface AWSIoTListThingGroupsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTGroupNameAndArn *> * _Nullable thingGroups;
		[NullAllowed, Export ("thingGroups", ArgumentSemantic.Strong)]
		AWSIoTGroupNameAndArn[] ThingGroups { get; set; }
	}

	// @interface AWSIoTListThingPrincipalsRequest
	interface AWSIoTListThingPrincipalsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTListThingPrincipalsResponse
	interface AWSIoTListThingPrincipalsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable principals;
		[NullAllowed, Export ("principals", ArgumentSemantic.Strong)]
		string[] Principals { get; set; }
	}

	// @interface AWSIoTListThingRegistrationTaskReportsRequest
	interface AWSIoTListThingRegistrationTaskReportsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTReportType reportType;
		[Export ("reportType", ArgumentSemantic.Assign)]
		AWSIoTReportType ReportType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTListThingRegistrationTaskReportsResponse
	interface AWSIoTListThingRegistrationTaskReportsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTReportType reportType;
		[Export ("reportType", ArgumentSemantic.Assign)]
		AWSIoTReportType ReportType { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable resourceLinks;
		[NullAllowed, Export ("resourceLinks", ArgumentSemantic.Strong)]
		string[] ResourceLinks { get; set; }
	}

	// @interface AWSIoTListThingRegistrationTasksRequest
	interface AWSIoTListThingRegistrationTasksRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTStatus Status { get; set; }
	}

	// @interface AWSIoTListThingRegistrationTasksResponse
	interface AWSIoTListThingRegistrationTasksResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable taskIds;
		[NullAllowed, Export ("taskIds", ArgumentSemantic.Strong)]
		string[] TaskIds { get; set; }
	}

	// @interface AWSIoTListThingTypesRequest
	interface AWSIoTListThingTypesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }
	}

	// @interface AWSIoTListThingTypesResponse
	interface AWSIoTListThingTypesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTThingTypeDefinition *> * _Nullable thingTypes;
		[NullAllowed, Export ("thingTypes", ArgumentSemantic.Strong)]
		AWSIoTThingTypeDefinition[] ThingTypes { get; set; }
	}

	// @interface AWSIoTListThingsInBillingGroupRequest
	interface AWSIoTListThingsInBillingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListThingsInBillingGroupResponse
	interface AWSIoTListThingsInBillingGroupResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable things;
		[NullAllowed, Export ("things", ArgumentSemantic.Strong)]
		string[] Things { get; set; }
	}

	// @interface AWSIoTListThingsInThingGroupRequest
	interface AWSIoTListThingsInThingGroupRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable recursive;
		[NullAllowed, Export ("recursive", ArgumentSemantic.Strong)]
		NSNumber Recursive { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTListThingsInThingGroupResponse
	interface AWSIoTListThingsInThingGroupResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable things;
		[NullAllowed, Export ("things", ArgumentSemantic.Strong)]
		string[] Things { get; set; }
	}

	// @interface AWSIoTListThingsRequest
	interface AWSIoTListThingsRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable attributeName;
		[NullAllowed, Export ("attributeName", ArgumentSemantic.Strong)]
		string AttributeName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable attributeValue;
		[NullAllowed, Export ("attributeValue", ArgumentSemantic.Strong)]
		string AttributeValue { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable usePrefixAttributeValue;
		[NullAllowed, Export ("usePrefixAttributeValue", ArgumentSemantic.Strong)]
		NSNumber UsePrefixAttributeValue { get; set; }
	}

	// @interface AWSIoTListThingsResponse
	interface AWSIoTListThingsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTThingAttribute *> * _Nullable things;
		[NullAllowed, Export ("things", ArgumentSemantic.Strong)]
		AWSIoTThingAttribute[] Things { get; set; }
	}

	// @interface AWSIoTListTopicRuleDestinationsRequest
	interface AWSIoTListTopicRuleDestinationsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListTopicRuleDestinationsResponse
	interface AWSIoTListTopicRuleDestinationsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTTopicRuleDestinationSummary *> * _Nullable destinationSummaries;
		[NullAllowed, Export ("destinationSummaries", ArgumentSemantic.Strong)]
		AWSIoTTopicRuleDestinationSummary[] DestinationSummaries { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListTopicRulesRequest
	interface AWSIoTListTopicRulesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable ruleDisabled;
		[NullAllowed, Export ("ruleDisabled", ArgumentSemantic.Strong)]
		NSNumber RuleDisabled { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable topic;
		[NullAllowed, Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }
	}

	// @interface AWSIoTListTopicRulesResponse
	interface AWSIoTListTopicRulesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTopicRuleListItem *> * _Nullable rules;
		[NullAllowed, Export ("rules", ArgumentSemantic.Strong)]
		AWSIoTTopicRuleListItem[] Rules { get; set; }
	}

	// @interface AWSIoTListV2LoggingLevelsRequest
	interface AWSIoTListV2LoggingLevelsRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (assign, nonatomic) AWSIoTLogTargetType targetType;
		[Export ("targetType", ArgumentSemantic.Assign)]
		AWSIoTLogTargetType TargetType { get; set; }
	}

	// @interface AWSIoTListV2LoggingLevelsResponse
	interface AWSIoTListV2LoggingLevelsResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTLogTargetConfiguration *> * _Nullable logTargetConfigurations;
		[NullAllowed, Export ("logTargetConfigurations", ArgumentSemantic.Strong)]
		AWSIoTLogTargetConfiguration[] LogTargetConfigurations { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTListViolationEventsRequest
	interface AWSIoTListViolationEventsRequest
	{
		// @property (assign, nonatomic) AWSIoTBehaviorCriteriaType behaviorCriteriaType;
		[Export ("behaviorCriteriaType", ArgumentSemantic.Assign)]
		AWSIoTBehaviorCriteriaType BehaviorCriteriaType { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable listSuppressedAlerts;
		[NullAllowed, Export ("listSuppressedAlerts", ArgumentSemantic.Strong)]
		NSNumber ListSuppressedAlerts { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (assign, nonatomic) AWSIoTVerificationState verificationState;
		[Export ("verificationState", ArgumentSemantic.Assign)]
		AWSIoTVerificationState VerificationState { get; set; }
	}

	// @interface AWSIoTListViolationEventsResponse
	interface AWSIoTListViolationEventsResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTViolationEvent *> * _Nullable violationEvents;
		[NullAllowed, Export ("violationEvents", ArgumentSemantic.Strong)]
		AWSIoTViolationEvent[] ViolationEvents { get; set; }
	}

	// @interface AWSIoTLocationAction
	interface AWSIoTLocationAction
	{
		// @property (nonatomic, strong) NSString * _Nullable deviceId;
		[NullAllowed, Export ("deviceId", ArgumentSemantic.Strong)]
		string DeviceId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable latitude;
		[NullAllowed, Export ("latitude", ArgumentSemantic.Strong)]
		string Latitude { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable longitude;
		[NullAllowed, Export ("longitude", ArgumentSemantic.Strong)]
		string Longitude { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) AWSIoTLocationTimestamp * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Strong)]
		AWSIoTLocationTimestamp Timestamp { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable trackerName;
		[NullAllowed, Export ("trackerName", ArgumentSemantic.Strong)]
		string TrackerName { get; set; }
	}

	// @interface AWSIoTLocationTimestamp
	interface AWSIoTLocationTimestamp
	{
		// @property (nonatomic, strong) NSString * _Nullable unit;
		[NullAllowed, Export ("unit", ArgumentSemantic.Strong)]
		string Unit { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSIoTLogTarget
	interface AWSIoTLogTarget
	{
		// @property (nonatomic, strong) NSString * _Nullable targetName;
		[NullAllowed, Export ("targetName", ArgumentSemantic.Strong)]
		string TargetName { get; set; }

		// @property (assign, nonatomic) AWSIoTLogTargetType targetType;
		[Export ("targetType", ArgumentSemantic.Assign)]
		AWSIoTLogTargetType TargetType { get; set; }
	}

	// @interface AWSIoTLogTargetConfiguration
	interface AWSIoTLogTargetConfiguration
	{
		// @property (assign, nonatomic) AWSIoTLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		AWSIoTLogLevel LogLevel { get; set; }

		// @property (nonatomic, strong) AWSIoTLogTarget * _Nullable logTarget;
		[NullAllowed, Export ("logTarget", ArgumentSemantic.Strong)]
		AWSIoTLogTarget LogTarget { get; set; }
	}

	// @interface AWSIoTLoggingOptionsPayload
	interface AWSIoTLoggingOptionsPayload
	{
		// @property (assign, nonatomic) AWSIoTLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		AWSIoTLogLevel LogLevel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTMachineLearningDetectionConfig
	interface AWSIoTMachineLearningDetectionConfig
	{
		// @property (assign, nonatomic) AWSIoTConfidenceLevel confidenceLevel;
		[Export ("confidenceLevel", ArgumentSemantic.Assign)]
		AWSIoTConfidenceLevel ConfidenceLevel { get; set; }
	}

	// @interface AWSIoTManagedJobTemplateSummary
	interface AWSIoTManagedJobTemplateSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable environments;
		[NullAllowed, Export ("environments", ArgumentSemantic.Strong)]
		string[] Environments { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateArn;
		[NullAllowed, Export ("templateArn", ArgumentSemantic.Strong)]
		string TemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateVersion;
		[NullAllowed, Export ("templateVersion", ArgumentSemantic.Strong)]
		string TemplateVersion { get; set; }
	}

	// @interface AWSIoTMetricDatum
	interface AWSIoTMetricDatum
	{
		// @property (nonatomic, strong) NSDate * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Strong)]
		NSDate Timestamp { get; set; }

		// @property (nonatomic, strong) AWSIoTMetricValue * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		AWSIoTMetricValue Value { get; set; }
	}

	// @interface AWSIoTMetricDimension
	interface AWSIoTMetricDimension
	{
		// @property (nonatomic, strong) NSString * _Nullable dimensionName;
		[NullAllowed, Export ("dimensionName", ArgumentSemantic.Strong)]
		string DimensionName { get; set; }

		// @property (assign, nonatomic) AWSIoTDimensionValueOperator operatorValue;
		[Export ("operatorValue", ArgumentSemantic.Assign)]
		AWSIoTDimensionValueOperator OperatorValue { get; set; }
	}

	// @interface AWSIoTMetricToRetain
	interface AWSIoTMetricToRetain
	{
		// @property (nonatomic, strong) NSString * _Nullable metric;
		[NullAllowed, Export ("metric", ArgumentSemantic.Strong)]
		string Metric { get; set; }

		// @property (nonatomic, strong) AWSIoTMetricDimension * _Nullable metricDimension;
		[NullAllowed, Export ("metricDimension", ArgumentSemantic.Strong)]
		AWSIoTMetricDimension MetricDimension { get; set; }
	}

	// @interface AWSIoTMetricValue
	interface AWSIoTMetricValue
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable cidrs;
		[NullAllowed, Export ("cidrs", ArgumentSemantic.Strong)]
		string[] Cidrs { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable count;
		[NullAllowed, Export ("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable number;
		[NullAllowed, Export ("number", ArgumentSemantic.Strong)]
		NSNumber Number { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * _Nullable numbers;
		[NullAllowed, Export ("numbers", ArgumentSemantic.Strong)]
		NSNumber[] Numbers { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * _Nullable ports;
		[NullAllowed, Export ("ports", ArgumentSemantic.Strong)]
		NSNumber[] Ports { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable strings;
		[NullAllowed, Export ("strings", ArgumentSemantic.Strong)]
		string[] Strings { get; set; }
	}

	// @interface AWSIoTMitigationAction
	interface AWSIoTMitigationAction
	{
		// @property (nonatomic, strong) AWSIoTMitigationActionParams * _Nullable actionParams;
		[NullAllowed, Export ("actionParams", ArgumentSemantic.Strong)]
		AWSIoTMitigationActionParams ActionParams { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTMitigationActionIdentifier
	interface AWSIoTMitigationActionIdentifier
	{
		// @property (nonatomic, strong) NSString * _Nullable actionArn;
		[NullAllowed, Export ("actionArn", ArgumentSemantic.Strong)]
		string ActionArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }
	}

	// @interface AWSIoTMitigationActionParams
	interface AWSIoTMitigationActionParams
	{
		// @property (nonatomic, strong) AWSIoTAddThingsToThingGroupParams * _Nullable addThingsToThingGroupParams;
		[NullAllowed, Export ("addThingsToThingGroupParams", ArgumentSemantic.Strong)]
		AWSIoTAddThingsToThingGroupParams AddThingsToThingGroupParams { get; set; }

		// @property (nonatomic, strong) AWSIoTEnableIoTLoggingParams * _Nullable enableIoTLoggingParams;
		[NullAllowed, Export ("enableIoTLoggingParams", ArgumentSemantic.Strong)]
		AWSIoTEnableIoTLoggingParams EnableIoTLoggingParams { get; set; }

		// @property (nonatomic, strong) AWSIoTPublishFindingToSnsParams * _Nullable publishFindingToSnsParams;
		[NullAllowed, Export ("publishFindingToSnsParams", ArgumentSemantic.Strong)]
		AWSIoTPublishFindingToSnsParams PublishFindingToSnsParams { get; set; }

		// @property (nonatomic, strong) AWSIoTReplaceDefaultPolicyVersionParams * _Nullable replaceDefaultPolicyVersionParams;
		[NullAllowed, Export ("replaceDefaultPolicyVersionParams", ArgumentSemantic.Strong)]
		AWSIoTReplaceDefaultPolicyVersionParams ReplaceDefaultPolicyVersionParams { get; set; }

		// @property (nonatomic, strong) AWSIoTUpdateCACertificateParams * _Nullable updateCACertificateParams;
		[NullAllowed, Export ("updateCACertificateParams", ArgumentSemantic.Strong)]
		AWSIoTUpdateCACertificateParams UpdateCACertificateParams { get; set; }

		// @property (nonatomic, strong) AWSIoTUpdateDeviceCertificateParams * _Nullable updateDeviceCertificateParams;
		[NullAllowed, Export ("updateDeviceCertificateParams", ArgumentSemantic.Strong)]
		AWSIoTUpdateDeviceCertificateParams UpdateDeviceCertificateParams { get; set; }
	}

	// @interface AWSIoTMqttContext
	interface AWSIoTMqttContext
	{
		// @property (nonatomic, strong) NSString * _Nullable clientId;
		[NullAllowed, Export ("clientId", ArgumentSemantic.Strong)]
		string ClientId { get; set; }

		// @property (nonatomic, strong) NSData * _Nullable password;
		[NullAllowed, Export ("password", ArgumentSemantic.Strong)]
		NSData Password { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable username;
		[NullAllowed, Export ("username", ArgumentSemantic.Strong)]
		string Username { get; set; }
	}

	// @interface AWSIoTMqttHeaders
	interface AWSIoTMqttHeaders
	{
		// @property (nonatomic, strong) NSString * _Nullable contentType;
		[NullAllowed, Export ("contentType", ArgumentSemantic.Strong)]
		string ContentType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable correlationData;
		[NullAllowed, Export ("correlationData", ArgumentSemantic.Strong)]
		string CorrelationData { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable messageExpiry;
		[NullAllowed, Export ("messageExpiry", ArgumentSemantic.Strong)]
		string MessageExpiry { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable payloadFormatIndicator;
		[NullAllowed, Export ("payloadFormatIndicator", ArgumentSemantic.Strong)]
		string PayloadFormatIndicator { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable responseTopic;
		[NullAllowed, Export ("responseTopic", ArgumentSemantic.Strong)]
		string ResponseTopic { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTUserProperty *> * _Nullable userProperties;
		[NullAllowed, Export ("userProperties", ArgumentSemantic.Strong)]
		AWSIoTUserProperty[] UserProperties { get; set; }
	}

	// @interface AWSIoTNonCompliantResource
	interface AWSIoTNonCompliantResource
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable additionalInfo;
		[NullAllowed, Export ("additionalInfo", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> AdditionalInfo { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }

		// @property (assign, nonatomic) AWSIoTResourceType resourceType;
		[Export ("resourceType", ArgumentSemantic.Assign)]
		AWSIoTResourceType ResourceType { get; set; }
	}

	// @interface AWSIoTOTAUpdateFile
	interface AWSIoTOTAUpdateFile
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable attributes;
		[NullAllowed, Export ("attributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Attributes { get; set; }

		// @property (nonatomic, strong) AWSIoTCodeSigning * _Nullable codeSigning;
		[NullAllowed, Export ("codeSigning", ArgumentSemantic.Strong)]
		AWSIoTCodeSigning CodeSigning { get; set; }

		// @property (nonatomic, strong) AWSIoTFileLocation * _Nullable fileLocation;
		[NullAllowed, Export ("fileLocation", ArgumentSemantic.Strong)]
		AWSIoTFileLocation FileLocation { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable fileName;
		[NullAllowed, Export ("fileName", ArgumentSemantic.Strong)]
		string FileName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable fileType;
		[NullAllowed, Export ("fileType", ArgumentSemantic.Strong)]
		NSNumber FileType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable fileVersion;
		[NullAllowed, Export ("fileVersion", ArgumentSemantic.Strong)]
		string FileVersion { get; set; }
	}

	// @interface AWSIoTOTAUpdateInfo
	interface AWSIoTOTAUpdateInfo
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable additionalParameters;
		[NullAllowed, Export ("additionalParameters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> AdditionalParameters { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable awsIotJobArn;
		[NullAllowed, Export ("awsIotJobArn", ArgumentSemantic.Strong)]
		string AwsIotJobArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable awsIotJobId;
		[NullAllowed, Export ("awsIotJobId", ArgumentSemantic.Strong)]
		string AwsIotJobId { get; set; }

		// @property (nonatomic, strong) AWSIoTAwsJobExecutionsRolloutConfig * _Nullable awsJobExecutionsRolloutConfig;
		[NullAllowed, Export ("awsJobExecutionsRolloutConfig", ArgumentSemantic.Strong)]
		AWSIoTAwsJobExecutionsRolloutConfig AwsJobExecutionsRolloutConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTAwsJobPresignedUrlConfig * _Nullable awsJobPresignedUrlConfig;
		[NullAllowed, Export ("awsJobPresignedUrlConfig", ArgumentSemantic.Strong)]
		AWSIoTAwsJobPresignedUrlConfig AwsJobPresignedUrlConfig { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) AWSIoTErrorInfo * _Nullable errorInfo;
		[NullAllowed, Export ("errorInfo", ArgumentSemantic.Strong)]
		AWSIoTErrorInfo ErrorInfo { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateArn;
		[NullAllowed, Export ("otaUpdateArn", ArgumentSemantic.Strong)]
		string OtaUpdateArn { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTOTAUpdateFile *> * _Nullable otaUpdateFiles;
		[NullAllowed, Export ("otaUpdateFiles", ArgumentSemantic.Strong)]
		AWSIoTOTAUpdateFile[] OtaUpdateFiles { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateId;
		[NullAllowed, Export ("otaUpdateId", ArgumentSemantic.Strong)]
		string OtaUpdateId { get; set; }

		// @property (assign, nonatomic) AWSIoTOTAUpdateStatus otaUpdateStatus;
		[Export ("otaUpdateStatus", ArgumentSemantic.Assign)]
		AWSIoTOTAUpdateStatus OtaUpdateStatus { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable protocols;
		[NullAllowed, Export ("protocols", ArgumentSemantic.Strong)]
		string[] Protocols { get; set; }

		// @property (assign, nonatomic) AWSIoTTargetSelection targetSelection;
		[Export ("targetSelection", ArgumentSemantic.Assign)]
		AWSIoTTargetSelection TargetSelection { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targets;
		[NullAllowed, Export ("targets", ArgumentSemantic.Strong)]
		string[] Targets { get; set; }
	}

	// @interface AWSIoTOTAUpdateSummary
	interface AWSIoTOTAUpdateSummary
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateArn;
		[NullAllowed, Export ("otaUpdateArn", ArgumentSemantic.Strong)]
		string OtaUpdateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable otaUpdateId;
		[NullAllowed, Export ("otaUpdateId", ArgumentSemantic.Strong)]
		string OtaUpdateId { get; set; }
	}

	// @interface AWSIoTOpenSearchAction
	interface AWSIoTOpenSearchAction
	{
		// @property (nonatomic, strong) NSString * _Nullable endpoint;
		[NullAllowed, Export ("endpoint", ArgumentSemantic.Strong)]
		string Endpoint { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable index;
		[NullAllowed, Export ("index", ArgumentSemantic.Strong)]
		string Index { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable types;
		[NullAllowed, Export ("types", ArgumentSemantic.Strong)]
		string Types { get; set; }
	}

	// @interface AWSIoTOutgoingCertificate
	interface AWSIoTOutgoingCertificate
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable transferDate;
		[NullAllowed, Export ("transferDate", ArgumentSemantic.Strong)]
		NSDate TransferDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable transferMessage;
		[NullAllowed, Export ("transferMessage", ArgumentSemantic.Strong)]
		string TransferMessage { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable transferredTo;
		[NullAllowed, Export ("transferredTo", ArgumentSemantic.Strong)]
		string TransferredTo { get; set; }
	}

	// @interface AWSIoTPercentPair
	interface AWSIoTPercentPair
	{
		// @property (nonatomic, strong) NSNumber * _Nullable percent;
		[NullAllowed, Export ("percent", ArgumentSemantic.Strong)]
		NSNumber Percent { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		NSNumber Value { get; set; }
	}

	// @interface AWSIoTPolicy
	interface AWSIoTPolicy
	{
		// @property (nonatomic, strong) NSString * _Nullable policyArn;
		[NullAllowed, Export ("policyArn", ArgumentSemantic.Strong)]
		string PolicyArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }
	}

	// @interface AWSIoTPolicyVersion
	interface AWSIoTPolicyVersion
	{
		// @property (nonatomic, strong) NSDate * _Nullable createDate;
		[NullAllowed, Export ("createDate", ArgumentSemantic.Strong)]
		NSDate CreateDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isDefaultVersion;
		[NullAllowed, Export ("isDefaultVersion", ArgumentSemantic.Strong)]
		NSNumber IsDefaultVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable versionId;
		[NullAllowed, Export ("versionId", ArgumentSemantic.Strong)]
		string VersionId { get; set; }
	}

	// @interface AWSIoTPolicyVersionIdentifier
	interface AWSIoTPolicyVersionIdentifier
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyVersionId;
		[NullAllowed, Export ("policyVersionId", ArgumentSemantic.Strong)]
		string PolicyVersionId { get; set; }
	}

	// @interface AWSIoTPresignedUrlConfig
	interface AWSIoTPresignedUrlConfig
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expiresInSec;
		[NullAllowed, Export ("expiresInSec", ArgumentSemantic.Strong)]
		NSNumber ExpiresInSec { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTProvisioningHook
	interface AWSIoTProvisioningHook
	{
		// @property (nonatomic, strong) NSString * _Nullable payloadVersion;
		[NullAllowed, Export ("payloadVersion", ArgumentSemantic.Strong)]
		string PayloadVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable targetArn;
		[NullAllowed, Export ("targetArn", ArgumentSemantic.Strong)]
		string TargetArn { get; set; }
	}

	// @interface AWSIoTProvisioningTemplateSummary
	interface AWSIoTProvisioningTemplateSummary
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable enabled;
		[NullAllowed, Export ("enabled", ArgumentSemantic.Strong)]
		NSNumber Enabled { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateArn;
		[NullAllowed, Export ("templateArn", ArgumentSemantic.Strong)]
		string TemplateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }

		// @property (assign, nonatomic) AWSIoTTemplateType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSIoTTemplateType Types { get; set; }
	}

	// @interface AWSIoTProvisioningTemplateVersionSummary
	interface AWSIoTProvisioningTemplateVersionSummary
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isDefaultVersion;
		[NullAllowed, Export ("isDefaultVersion", ArgumentSemantic.Strong)]
		NSNumber IsDefaultVersion { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable versionId;
		[NullAllowed, Export ("versionId", ArgumentSemantic.Strong)]
		NSNumber VersionId { get; set; }
	}

	// @interface AWSIoTPublishFindingToSnsParams
	interface AWSIoTPublishFindingToSnsParams
	{
		// @property (nonatomic, strong) NSString * _Nullable topicArn;
		[NullAllowed, Export ("topicArn", ArgumentSemantic.Strong)]
		string TopicArn { get; set; }
	}

	// @interface AWSIoTPutAssetPropertyValueEntry
	interface AWSIoTPutAssetPropertyValueEntry
	{
		// @property (nonatomic, strong) NSString * _Nullable assetId;
		[NullAllowed, Export ("assetId", ArgumentSemantic.Strong)]
		string AssetId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable entryId;
		[NullAllowed, Export ("entryId", ArgumentSemantic.Strong)]
		string EntryId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable propertyAlias;
		[NullAllowed, Export ("propertyAlias", ArgumentSemantic.Strong)]
		string PropertyAlias { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable propertyId;
		[NullAllowed, Export ("propertyId", ArgumentSemantic.Strong)]
		string PropertyId { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTAssetPropertyValue *> * _Nullable propertyValues;
		[NullAllowed, Export ("propertyValues", ArgumentSemantic.Strong)]
		AWSIoTAssetPropertyValue[] PropertyValues { get; set; }
	}

	// @interface AWSIoTPutItemInput
	interface AWSIoTPutItemInput
	{
		// @property (nonatomic, strong) NSString * _Nullable tableName;
		[NullAllowed, Export ("tableName", ArgumentSemantic.Strong)]
		string TableName { get; set; }
	}

	// @interface AWSIoTPutVerificationStateOnViolationRequest
	interface AWSIoTPutVerificationStateOnViolationRequest
	{
		// @property (assign, nonatomic) AWSIoTVerificationState verificationState;
		[Export ("verificationState", ArgumentSemantic.Assign)]
		AWSIoTVerificationState VerificationState { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable verificationStateDescription;
		[NullAllowed, Export ("verificationStateDescription", ArgumentSemantic.Strong)]
		string VerificationStateDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable violationId;
		[NullAllowed, Export ("violationId", ArgumentSemantic.Strong)]
		string ViolationId { get; set; }
	}

	// @interface AWSIoTPutVerificationStateOnViolationResponse
	interface AWSIoTPutVerificationStateOnViolationResponse
	{
	}

	// @interface AWSIoTRateIncreaseCriteria
	interface AWSIoTRateIncreaseCriteria
	{
		// @property (nonatomic, strong) NSNumber * _Nullable numberOfNotifiedThings;
		[NullAllowed, Export ("numberOfNotifiedThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfNotifiedThings { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfSucceededThings;
		[NullAllowed, Export ("numberOfSucceededThings", ArgumentSemantic.Strong)]
		NSNumber NumberOfSucceededThings { get; set; }
	}

	// @interface AWSIoTRegisterCACertificateRequest
	interface AWSIoTRegisterCACertificateRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable allowAutoRegistration;
		[NullAllowed, Export ("allowAutoRegistration", ArgumentSemantic.Strong)]
		NSNumber AllowAutoRegistration { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable caCertificate;
		[NullAllowed, Export ("caCertificate", ArgumentSemantic.Strong)]
		string CaCertificate { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateMode certificateMode;
		[Export ("certificateMode", ArgumentSemantic.Assign)]
		AWSIoTCertificateMode CertificateMode { get; set; }

		// @property (nonatomic, strong) AWSIoTRegistrationConfig * _Nullable registrationConfig;
		[NullAllowed, Export ("registrationConfig", ArgumentSemantic.Strong)]
		AWSIoTRegistrationConfig RegistrationConfig { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable setAsActive;
		[NullAllowed, Export ("setAsActive", ArgumentSemantic.Strong)]
		NSNumber SetAsActive { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable verificationCertificate;
		[NullAllowed, Export ("verificationCertificate", ArgumentSemantic.Strong)]
		string VerificationCertificate { get; set; }
	}

	// @interface AWSIoTRegisterCACertificateResponse
	interface AWSIoTRegisterCACertificateResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }
	}

	// @interface AWSIoTRegisterCertificateRequest
	interface AWSIoTRegisterCertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable caCertificatePem;
		[NullAllowed, Export ("caCertificatePem", ArgumentSemantic.Strong)]
		string CaCertificatePem { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable setAsActive;
		[NullAllowed, Export ("setAsActive", ArgumentSemantic.Strong)]
		NSNumber SetAsActive { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTCertificateStatus Status { get; set; }
	}

	// @interface AWSIoTRegisterCertificateResponse
	interface AWSIoTRegisterCertificateResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }
	}

	// @interface AWSIoTRegisterCertificateWithoutCARequest
	interface AWSIoTRegisterCertificateWithoutCARequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTCertificateStatus Status { get; set; }
	}

	// @interface AWSIoTRegisterCertificateWithoutCAResponse
	interface AWSIoTRegisterCertificateWithoutCAResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }
	}

	// @interface AWSIoTRegisterThingRequest
	interface AWSIoTRegisterThingRequest
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable parameters;
		[NullAllowed, Export ("parameters", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Parameters { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }
	}

	// @interface AWSIoTRegisterThingResponse
	interface AWSIoTRegisterThingResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable certificatePem;
		[NullAllowed, Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable resourceArns;
		[NullAllowed, Export ("resourceArns", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> ResourceArns { get; set; }
	}

	// @interface AWSIoTRegistrationConfig
	interface AWSIoTRegistrationConfig
	{
		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTRejectCertificateTransferRequest
	interface AWSIoTRejectCertificateTransferRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable rejectReason;
		[NullAllowed, Export ("rejectReason", ArgumentSemantic.Strong)]
		string RejectReason { get; set; }
	}

	// @interface AWSIoTRelatedResource
	interface AWSIoTRelatedResource
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable additionalInfo;
		[NullAllowed, Export ("additionalInfo", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> AdditionalInfo { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }

		// @property (assign, nonatomic) AWSIoTResourceType resourceType;
		[Export ("resourceType", ArgumentSemantic.Assign)]
		AWSIoTResourceType ResourceType { get; set; }
	}

	// @interface AWSIoTRemoveThingFromBillingGroupRequest
	interface AWSIoTRemoveThingFromBillingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupArn;
		[NullAllowed, Export ("billingGroupArn", ArgumentSemantic.Strong)]
		string BillingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTRemoveThingFromBillingGroupResponse
	interface AWSIoTRemoveThingFromBillingGroupResponse
	{
	}

	// @interface AWSIoTRemoveThingFromThingGroupRequest
	interface AWSIoTRemoveThingFromThingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupArn;
		[NullAllowed, Export ("thingGroupArn", ArgumentSemantic.Strong)]
		string ThingGroupArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTRemoveThingFromThingGroupResponse
	interface AWSIoTRemoveThingFromThingGroupResponse
	{
	}

	// @interface AWSIoTReplaceDefaultPolicyVersionParams
	interface AWSIoTReplaceDefaultPolicyVersionParams
	{
		// @property (assign, nonatomic) AWSIoTPolicyTemplateName templateName;
		[Export ("templateName", ArgumentSemantic.Assign)]
		AWSIoTPolicyTemplateName TemplateName { get; set; }
	}

	// @interface AWSIoTReplaceTopicRuleRequest
	interface AWSIoTReplaceTopicRuleRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }

		// @property (nonatomic, strong) AWSIoTTopicRulePayload * _Nullable topicRulePayload;
		[NullAllowed, Export ("topicRulePayload", ArgumentSemantic.Strong)]
		AWSIoTTopicRulePayload TopicRulePayload { get; set; }
	}

	// @interface AWSIoTRepublishAction
	interface AWSIoTRepublishAction
	{
		// @property (nonatomic, strong) AWSIoTMqttHeaders * _Nullable headers;
		[NullAllowed, Export ("headers", ArgumentSemantic.Strong)]
		AWSIoTMqttHeaders Headers { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable qos;
		[NullAllowed, Export ("qos", ArgumentSemantic.Strong)]
		NSNumber Qos { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable topic;
		[NullAllowed, Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }
	}

	// @interface AWSIoTResourceIdentifier
	interface AWSIoTResourceIdentifier
	{
		// @property (nonatomic, strong) NSString * _Nullable account;
		[NullAllowed, Export ("account", ArgumentSemantic.Strong)]
		string Account { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable caCertificateId;
		[NullAllowed, Export ("caCertificateId", ArgumentSemantic.Strong)]
		string CaCertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable clientId;
		[NullAllowed, Export ("clientId", ArgumentSemantic.Strong)]
		string ClientId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable cognitoIdentityPoolId;
		[NullAllowed, Export ("cognitoIdentityPoolId", ArgumentSemantic.Strong)]
		string CognitoIdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceCertificateArn;
		[NullAllowed, Export ("deviceCertificateArn", ArgumentSemantic.Strong)]
		string DeviceCertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceCertificateId;
		[NullAllowed, Export ("deviceCertificateId", ArgumentSemantic.Strong)]
		string DeviceCertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iamRoleArn;
		[NullAllowed, Export ("iamRoleArn", ArgumentSemantic.Strong)]
		string IamRoleArn { get; set; }

		// @property (nonatomic, strong) AWSIoTIssuerCertificateIdentifier * _Nullable issuerCertificateIdentifier;
		[NullAllowed, Export ("issuerCertificateIdentifier", ArgumentSemantic.Strong)]
		AWSIoTIssuerCertificateIdentifier IssuerCertificateIdentifier { get; set; }

		// @property (nonatomic, strong) AWSIoTPolicyVersionIdentifier * _Nullable policyVersionIdentifier;
		[NullAllowed, Export ("policyVersionIdentifier", ArgumentSemantic.Strong)]
		AWSIoTPolicyVersionIdentifier PolicyVersionIdentifier { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleAliasArn;
		[NullAllowed, Export ("roleAliasArn", ArgumentSemantic.Strong)]
		string RoleAliasArn { get; set; }
	}

	// @interface AWSIoTRetryCriteria
	interface AWSIoTRetryCriteria
	{
		// @property (assign, nonatomic) AWSIoTRetryableFailureType failureType;
		[Export ("failureType", ArgumentSemantic.Assign)]
		AWSIoTRetryableFailureType FailureType { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable numberOfRetries;
		[NullAllowed, Export ("numberOfRetries", ArgumentSemantic.Strong)]
		NSNumber NumberOfRetries { get; set; }
	}

	// @interface AWSIoTRoleAliasDescription
	interface AWSIoTRoleAliasDescription
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable credentialDurationSeconds;
		[NullAllowed, Export ("credentialDurationSeconds", ArgumentSemantic.Strong)]
		NSNumber CredentialDurationSeconds { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable owner;
		[NullAllowed, Export ("owner", ArgumentSemantic.Strong)]
		string Owner { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleAlias;
		[NullAllowed, Export ("roleAlias", ArgumentSemantic.Strong)]
		string RoleAlias { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleAliasArn;
		[NullAllowed, Export ("roleAliasArn", ArgumentSemantic.Strong)]
		string RoleAliasArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTS3Action
	interface AWSIoTS3Action
	{
		// @property (nonatomic, strong) NSString * _Nullable bucketName;
		[NullAllowed, Export ("bucketName", ArgumentSemantic.Strong)]
		string BucketName { get; set; }

		// @property (assign, nonatomic) AWSIoTCannedAccessControlList cannedAcl;
		[Export ("cannedAcl", ArgumentSemantic.Assign)]
		AWSIoTCannedAccessControlList CannedAcl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTS3Destination
	interface AWSIoTS3Destination
	{
		// @property (nonatomic, strong) NSString * _Nullable bucket;
		[NullAllowed, Export ("bucket", ArgumentSemantic.Strong)]
		string Bucket { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable prefix;
		[NullAllowed, Export ("prefix", ArgumentSemantic.Strong)]
		string Prefix { get; set; }
	}

	// @interface AWSIoTS3Location
	interface AWSIoTS3Location
	{
		// @property (nonatomic, strong) NSString * _Nullable bucket;
		[NullAllowed, Export ("bucket", ArgumentSemantic.Strong)]
		string Bucket { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		string Version { get; set; }
	}

	// @interface AWSIoTSalesforceAction
	interface AWSIoTSalesforceAction
	{
		// @property (nonatomic, strong) NSString * _Nullable token;
		[NullAllowed, Export ("token", ArgumentSemantic.Strong)]
		string Token { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		string Url { get; set; }
	}

	// @interface AWSIoTScheduledAuditMetadata
	interface AWSIoTScheduledAuditMetadata
	{
		// @property (nonatomic, strong) NSString * _Nullable dayOfMonth;
		[NullAllowed, Export ("dayOfMonth", ArgumentSemantic.Strong)]
		string DayOfMonth { get; set; }

		// @property (assign, nonatomic) AWSIoTDayOfWeek dayOfWeek;
		[Export ("dayOfWeek", ArgumentSemantic.Assign)]
		AWSIoTDayOfWeek DayOfWeek { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditFrequency frequency;
		[Export ("frequency", ArgumentSemantic.Assign)]
		AWSIoTAuditFrequency Frequency { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditArn;
		[NullAllowed, Export ("scheduledAuditArn", ArgumentSemantic.Strong)]
		string ScheduledAuditArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditName;
		[NullAllowed, Export ("scheduledAuditName", ArgumentSemantic.Strong)]
		string ScheduledAuditName { get; set; }
	}

	// @interface AWSIoTSchedulingConfig
	interface AWSIoTSchedulingConfig
	{
		// @property (assign, nonatomic) AWSIoTJobEndBehavior endBehavior;
		[Export ("endBehavior", ArgumentSemantic.Assign)]
		AWSIoTJobEndBehavior EndBehavior { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		string EndTime { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		string StartTime { get; set; }
	}

	// @interface AWSIoTSearchIndexRequest
	interface AWSIoTSearchIndexRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }
	}

	// @interface AWSIoTSearchIndexResponse
	interface AWSIoTSearchIndexResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTThingGroupDocument *> * _Nullable thingGroups;
		[NullAllowed, Export ("thingGroups", ArgumentSemantic.Strong)]
		AWSIoTThingGroupDocument[] ThingGroups { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTThingDocument *> * _Nullable things;
		[NullAllowed, Export ("things", ArgumentSemantic.Strong)]
		AWSIoTThingDocument[] Things { get; set; }
	}

	// @interface AWSIoTSecurityProfileIdentifier
	interface AWSIoTSecurityProfileIdentifier
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }
	}

	// @interface AWSIoTSecurityProfileTarget
	interface AWSIoTSecurityProfileTarget
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }
	}

	// @interface AWSIoTSecurityProfileTargetMapping
	interface AWSIoTSecurityProfileTargetMapping
	{
		// @property (nonatomic, strong) AWSIoTSecurityProfileIdentifier * _Nullable securityProfileIdentifier;
		[NullAllowed, Export ("securityProfileIdentifier", ArgumentSemantic.Strong)]
		AWSIoTSecurityProfileIdentifier SecurityProfileIdentifier { get; set; }

		// @property (nonatomic, strong) AWSIoTSecurityProfileTarget * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		AWSIoTSecurityProfileTarget Target { get; set; }
	}

	// @interface AWSIoTServerCertificateSummary
	interface AWSIoTServerCertificateSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable serverCertificateArn;
		[NullAllowed, Export ("serverCertificateArn", ArgumentSemantic.Strong)]
		string ServerCertificateArn { get; set; }

		// @property (assign, nonatomic) AWSIoTServerCertificateStatus serverCertificateStatus;
		[Export ("serverCertificateStatus", ArgumentSemantic.Assign)]
		AWSIoTServerCertificateStatus ServerCertificateStatus { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable serverCertificateStatusDetail;
		[NullAllowed, Export ("serverCertificateStatusDetail", ArgumentSemantic.Strong)]
		string ServerCertificateStatusDetail { get; set; }
	}

	// @interface AWSIoTSetDefaultAuthorizerRequest
	interface AWSIoTSetDefaultAuthorizerRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }
	}

	// @interface AWSIoTSetDefaultAuthorizerResponse
	interface AWSIoTSetDefaultAuthorizerResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerArn;
		[NullAllowed, Export ("authorizerArn", ArgumentSemantic.Strong)]
		string AuthorizerArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }
	}

	// @interface AWSIoTSetDefaultPolicyVersionRequest
	interface AWSIoTSetDefaultPolicyVersionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable policyName;
		[NullAllowed, Export ("policyName", ArgumentSemantic.Strong)]
		string PolicyName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable policyVersionId;
		[NullAllowed, Export ("policyVersionId", ArgumentSemantic.Strong)]
		string PolicyVersionId { get; set; }
	}

	// @interface AWSIoTSetLoggingOptionsRequest
	interface AWSIoTSetLoggingOptionsRequest
	{
		// @property (nonatomic, strong) AWSIoTLoggingOptionsPayload * _Nullable loggingOptionsPayload;
		[NullAllowed, Export ("loggingOptionsPayload", ArgumentSemantic.Strong)]
		AWSIoTLoggingOptionsPayload LoggingOptionsPayload { get; set; }
	}

	// @interface AWSIoTSetV2LoggingLevelRequest
	interface AWSIoTSetV2LoggingLevelRequest
	{
		// @property (assign, nonatomic) AWSIoTLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		AWSIoTLogLevel LogLevel { get; set; }

		// @property (nonatomic, strong) AWSIoTLogTarget * _Nullable logTarget;
		[NullAllowed, Export ("logTarget", ArgumentSemantic.Strong)]
		AWSIoTLogTarget LogTarget { get; set; }
	}

	// @interface AWSIoTSetV2LoggingOptionsRequest
	interface AWSIoTSetV2LoggingOptionsRequest
	{
		// @property (assign, nonatomic) AWSIoTLogLevel defaultLogLevel;
		[Export ("defaultLogLevel", ArgumentSemantic.Assign)]
		AWSIoTLogLevel DefaultLogLevel { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable disableAllLogs;
		[NullAllowed, Export ("disableAllLogs", ArgumentSemantic.Strong)]
		NSNumber DisableAllLogs { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTSigV4Authorization
	interface AWSIoTSigV4Authorization
	{
		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable serviceName;
		[NullAllowed, Export ("serviceName", ArgumentSemantic.Strong)]
		string ServiceName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable signingRegion;
		[NullAllowed, Export ("signingRegion", ArgumentSemantic.Strong)]
		string SigningRegion { get; set; }
	}

	// @interface AWSIoTSigningProfileParameter
	interface AWSIoTSigningProfileParameter
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateArn;
		[NullAllowed, Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable certificatePathOnDevice;
		[NullAllowed, Export ("certificatePathOnDevice", ArgumentSemantic.Strong)]
		string CertificatePathOnDevice { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable platform;
		[NullAllowed, Export ("platform", ArgumentSemantic.Strong)]
		string Platform { get; set; }
	}

	// @interface AWSIoTSnsAction
	interface AWSIoTSnsAction
	{
		// @property (assign, nonatomic) AWSIoTMessageFormat messageFormat;
		[Export ("messageFormat", ArgumentSemantic.Assign)]
		AWSIoTMessageFormat MessageFormat { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable targetArn;
		[NullAllowed, Export ("targetArn", ArgumentSemantic.Strong)]
		string TargetArn { get; set; }
	}

	// @interface AWSIoTSqsAction
	interface AWSIoTSqsAction
	{
		// @property (nonatomic, strong) NSString * _Nullable queueUrl;
		[NullAllowed, Export ("queueUrl", ArgumentSemantic.Strong)]
		string QueueUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable useBase64;
		[NullAllowed, Export ("useBase64", ArgumentSemantic.Strong)]
		NSNumber UseBase64 { get; set; }
	}

	// @interface AWSIoTStartAuditMitigationActionsTaskRequest
	interface AWSIoTStartAuditMitigationActionsTaskRequest
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSArray<NSString *> *> * _Nullable auditCheckToActionsMapping;
		[NullAllowed, Export ("auditCheckToActionsMapping", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSArray<NSString>> AuditCheckToActionsMapping { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable clientRequestToken;
		[NullAllowed, Export ("clientRequestToken", ArgumentSemantic.Strong)]
		string ClientRequestToken { get; set; }

		// @property (nonatomic, strong) AWSIoTAuditMitigationActionsTaskTarget * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		AWSIoTAuditMitigationActionsTaskTarget Target { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTStartAuditMitigationActionsTaskResponse
	interface AWSIoTStartAuditMitigationActionsTaskResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTStartDetectMitigationActionsTaskRequest
	interface AWSIoTStartDetectMitigationActionsTaskRequest
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable actions;
		[NullAllowed, Export ("actions", ArgumentSemantic.Strong)]
		string[] Actions { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable clientRequestToken;
		[NullAllowed, Export ("clientRequestToken", ArgumentSemantic.Strong)]
		string ClientRequestToken { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable includeOnlyActiveViolations;
		[NullAllowed, Export ("includeOnlyActiveViolations", ArgumentSemantic.Strong)]
		NSNumber IncludeOnlyActiveViolations { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable includeSuppressedAlerts;
		[NullAllowed, Export ("includeSuppressedAlerts", ArgumentSemantic.Strong)]
		NSNumber IncludeSuppressedAlerts { get; set; }

		// @property (nonatomic, strong) AWSIoTDetectMitigationActionsTaskTarget * _Nullable target;
		[NullAllowed, Export ("target", ArgumentSemantic.Strong)]
		AWSIoTDetectMitigationActionsTaskTarget Target { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }

		// @property (nonatomic, strong) AWSIoTViolationEventOccurrenceRange * _Nullable violationEventOccurrenceRange;
		[NullAllowed, Export ("violationEventOccurrenceRange", ArgumentSemantic.Strong)]
		AWSIoTViolationEventOccurrenceRange ViolationEventOccurrenceRange { get; set; }
	}

	// @interface AWSIoTStartDetectMitigationActionsTaskResponse
	interface AWSIoTStartDetectMitigationActionsTaskResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTStartOnDemandAuditTaskRequest
	interface AWSIoTStartOnDemandAuditTaskRequest
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targetCheckNames;
		[NullAllowed, Export ("targetCheckNames", ArgumentSemantic.Strong)]
		string[] TargetCheckNames { get; set; }
	}

	// @interface AWSIoTStartOnDemandAuditTaskResponse
	interface AWSIoTStartOnDemandAuditTaskResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTStartSigningJobParameter
	interface AWSIoTStartSigningJobParameter
	{
		// @property (nonatomic, strong) AWSIoTDestination * _Nullable destination;
		[NullAllowed, Export ("destination", ArgumentSemantic.Strong)]
		AWSIoTDestination Destination { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable signingProfileName;
		[NullAllowed, Export ("signingProfileName", ArgumentSemantic.Strong)]
		string SigningProfileName { get; set; }

		// @property (nonatomic, strong) AWSIoTSigningProfileParameter * _Nullable signingProfileParameter;
		[NullAllowed, Export ("signingProfileParameter", ArgumentSemantic.Strong)]
		AWSIoTSigningProfileParameter SigningProfileParameter { get; set; }
	}

	// @interface AWSIoTStartThingRegistrationTaskRequest
	interface AWSIoTStartThingRegistrationTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable inputFileBucket;
		[NullAllowed, Export ("inputFileBucket", ArgumentSemantic.Strong)]
		string InputFileBucket { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable inputFileKey;
		[NullAllowed, Export ("inputFileKey", ArgumentSemantic.Strong)]
		string InputFileKey { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateBody;
		[NullAllowed, Export ("templateBody", ArgumentSemantic.Strong)]
		string TemplateBody { get; set; }
	}

	// @interface AWSIoTStartThingRegistrationTaskResponse
	interface AWSIoTStartThingRegistrationTaskResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTStatisticalThreshold
	interface AWSIoTStatisticalThreshold
	{
		// @property (nonatomic, strong) NSString * _Nullable statistic;
		[NullAllowed, Export ("statistic", ArgumentSemantic.Strong)]
		string Statistic { get; set; }
	}

	// @interface AWSIoTStatistics
	interface AWSIoTStatistics
	{
		// @property (nonatomic, strong) NSNumber * _Nullable average;
		[NullAllowed, Export ("average", ArgumentSemantic.Strong)]
		NSNumber Average { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable count;
		[NullAllowed, Export ("count", ArgumentSemantic.Strong)]
		NSNumber Count { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maximum;
		[NullAllowed, Export ("maximum", ArgumentSemantic.Strong)]
		NSNumber Maximum { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minimum;
		[NullAllowed, Export ("minimum", ArgumentSemantic.Strong)]
		NSNumber Minimum { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable stdDeviation;
		[NullAllowed, Export ("stdDeviation", ArgumentSemantic.Strong)]
		NSNumber StdDeviation { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable sum;
		[NullAllowed, Export ("sum", ArgumentSemantic.Strong)]
		NSNumber Sum { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable sumOfSquares;
		[NullAllowed, Export ("sumOfSquares", ArgumentSemantic.Strong)]
		NSNumber SumOfSquares { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable variance;
		[NullAllowed, Export ("variance", ArgumentSemantic.Strong)]
		NSNumber Variance { get; set; }
	}

	// @interface AWSIoTStepFunctionsAction
	interface AWSIoTStepFunctionsAction
	{
		// @property (nonatomic, strong) NSString * _Nullable executionNamePrefix;
		[NullAllowed, Export ("executionNamePrefix", ArgumentSemantic.Strong)]
		string ExecutionNamePrefix { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable stateMachineName;
		[NullAllowed, Export ("stateMachineName", ArgumentSemantic.Strong)]
		string StateMachineName { get; set; }
	}

	// @interface AWSIoTStopThingRegistrationTaskRequest
	interface AWSIoTStopThingRegistrationTaskRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable taskId;
		[NullAllowed, Export ("taskId", ArgumentSemantic.Strong)]
		string TaskId { get; set; }
	}

	// @interface AWSIoTStopThingRegistrationTaskResponse
	interface AWSIoTStopThingRegistrationTaskResponse
	{
	}

	// @interface AWSIoTStream
	interface AWSIoTStream
	{
		// @property (nonatomic, strong) NSNumber * _Nullable fileId;
		[NullAllowed, Export ("fileId", ArgumentSemantic.Strong)]
		NSNumber FileId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }
	}

	// @interface AWSIoTStreamFile
	interface AWSIoTStreamFile
	{
		// @property (nonatomic, strong) NSNumber * _Nullable fileId;
		[NullAllowed, Export ("fileId", ArgumentSemantic.Strong)]
		NSNumber FileId { get; set; }

		// @property (nonatomic, strong) AWSIoTS3Location * _Nullable s3Location;
		[NullAllowed, Export ("s3Location", ArgumentSemantic.Strong)]
		AWSIoTS3Location S3Location { get; set; }
	}

	// @interface AWSIoTStreamInfo
	interface AWSIoTStreamInfo
	{
		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTStreamFile *> * _Nullable files;
		[NullAllowed, Export ("files", ArgumentSemantic.Strong)]
		AWSIoTStreamFile[] Files { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastUpdatedAt;
		[NullAllowed, Export ("lastUpdatedAt", ArgumentSemantic.Strong)]
		NSDate LastUpdatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamArn;
		[NullAllowed, Export ("streamArn", ArgumentSemantic.Strong)]
		string StreamArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable streamVersion;
		[NullAllowed, Export ("streamVersion", ArgumentSemantic.Strong)]
		NSNumber StreamVersion { get; set; }
	}

	// @interface AWSIoTStreamSummary
	interface AWSIoTStreamSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamArn;
		[NullAllowed, Export ("streamArn", ArgumentSemantic.Strong)]
		string StreamArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable streamVersion;
		[NullAllowed, Export ("streamVersion", ArgumentSemantic.Strong)]
		NSNumber StreamVersion { get; set; }
	}

	// @interface AWSIoTTag
	interface AWSIoTTag
	{
		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSIoTTagResourceRequest
	interface AWSIoTTagResourceRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable resourceArn;
		[NullAllowed, Export ("resourceArn", ArgumentSemantic.Strong)]
		string ResourceArn { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTag *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		AWSIoTTag[] Tags { get; set; }
	}

	// @interface AWSIoTTagResourceResponse
	interface AWSIoTTagResourceResponse
	{
	}

	// @interface AWSIoTTaskStatistics
	interface AWSIoTTaskStatistics
	{
		// @property (nonatomic, strong) NSNumber * _Nullable canceledChecks;
		[NullAllowed, Export ("canceledChecks", ArgumentSemantic.Strong)]
		NSNumber CanceledChecks { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable compliantChecks;
		[NullAllowed, Export ("compliantChecks", ArgumentSemantic.Strong)]
		NSNumber CompliantChecks { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable failedChecks;
		[NullAllowed, Export ("failedChecks", ArgumentSemantic.Strong)]
		NSNumber FailedChecks { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable inProgressChecks;
		[NullAllowed, Export ("inProgressChecks", ArgumentSemantic.Strong)]
		NSNumber InProgressChecks { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable nonCompliantChecks;
		[NullAllowed, Export ("nonCompliantChecks", ArgumentSemantic.Strong)]
		NSNumber NonCompliantChecks { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable totalChecks;
		[NullAllowed, Export ("totalChecks", ArgumentSemantic.Strong)]
		NSNumber TotalChecks { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable waitingForDataCollectionChecks;
		[NullAllowed, Export ("waitingForDataCollectionChecks", ArgumentSemantic.Strong)]
		NSNumber WaitingForDataCollectionChecks { get; set; }
	}

	// @interface AWSIoTTaskStatisticsForAuditCheck
	interface AWSIoTTaskStatisticsForAuditCheck
	{
		// @property (nonatomic, strong) NSNumber * _Nullable canceledFindingsCount;
		[NullAllowed, Export ("canceledFindingsCount", ArgumentSemantic.Strong)]
		NSNumber CanceledFindingsCount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable failedFindingsCount;
		[NullAllowed, Export ("failedFindingsCount", ArgumentSemantic.Strong)]
		NSNumber FailedFindingsCount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable skippedFindingsCount;
		[NullAllowed, Export ("skippedFindingsCount", ArgumentSemantic.Strong)]
		NSNumber SkippedFindingsCount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable succeededFindingsCount;
		[NullAllowed, Export ("succeededFindingsCount", ArgumentSemantic.Strong)]
		NSNumber SucceededFindingsCount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable totalFindingsCount;
		[NullAllowed, Export ("totalFindingsCount", ArgumentSemantic.Strong)]
		NSNumber TotalFindingsCount { get; set; }
	}

	// @interface AWSIoTTermsAggregation
	interface AWSIoTTermsAggregation
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxBuckets;
		[NullAllowed, Export ("maxBuckets", ArgumentSemantic.Strong)]
		NSNumber MaxBuckets { get; set; }
	}

	// @interface AWSIoTTestAuthorizationRequest
	interface AWSIoTTestAuthorizationRequest
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAuthInfo *> * _Nullable authInfos;
		[NullAllowed, Export ("authInfos", ArgumentSemantic.Strong)]
		AWSIoTAuthInfo[] AuthInfos { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable clientId;
		[NullAllowed, Export ("clientId", ArgumentSemantic.Strong)]
		string ClientId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable cognitoIdentityPoolId;
		[NullAllowed, Export ("cognitoIdentityPoolId", ArgumentSemantic.Strong)]
		string CognitoIdentityPoolId { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable policyNamesToAdd;
		[NullAllowed, Export ("policyNamesToAdd", ArgumentSemantic.Strong)]
		string[] PolicyNamesToAdd { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable policyNamesToSkip;
		[NullAllowed, Export ("policyNamesToSkip", ArgumentSemantic.Strong)]
		string[] PolicyNamesToSkip { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principal;
		[NullAllowed, Export ("principal", ArgumentSemantic.Strong)]
		string Principal { get; set; }
	}

	// @interface AWSIoTTestAuthorizationResponse
	interface AWSIoTTestAuthorizationResponse
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAuthResult *> * _Nullable authResults;
		[NullAllowed, Export ("authResults", ArgumentSemantic.Strong)]
		AWSIoTAuthResult[] AuthResults { get; set; }
	}

	// @interface AWSIoTTestInvokeAuthorizerRequest
	interface AWSIoTTestInvokeAuthorizerRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }

		// @property (nonatomic, strong) AWSIoTHttpContext * _Nullable httpContext;
		[NullAllowed, Export ("httpContext", ArgumentSemantic.Strong)]
		AWSIoTHttpContext HttpContext { get; set; }

		// @property (nonatomic, strong) AWSIoTMqttContext * _Nullable mqttContext;
		[NullAllowed, Export ("mqttContext", ArgumentSemantic.Strong)]
		AWSIoTMqttContext MqttContext { get; set; }

		// @property (nonatomic, strong) AWSIoTTlsContext * _Nullable tlsContext;
		[NullAllowed, Export ("tlsContext", ArgumentSemantic.Strong)]
		AWSIoTTlsContext TlsContext { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable token;
		[NullAllowed, Export ("token", ArgumentSemantic.Strong)]
		string Token { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tokenSignature;
		[NullAllowed, Export ("tokenSignature", ArgumentSemantic.Strong)]
		string TokenSignature { get; set; }
	}

	// @interface AWSIoTTestInvokeAuthorizerResponse
	interface AWSIoTTestInvokeAuthorizerResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable disconnectAfterInSeconds;
		[NullAllowed, Export ("disconnectAfterInSeconds", ArgumentSemantic.Strong)]
		NSNumber DisconnectAfterInSeconds { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable isAuthenticated;
		[NullAllowed, Export ("isAuthenticated", ArgumentSemantic.Strong)]
		NSNumber IsAuthenticated { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable policyDocuments;
		[NullAllowed, Export ("policyDocuments", ArgumentSemantic.Strong)]
		string[] PolicyDocuments { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable principalId;
		[NullAllowed, Export ("principalId", ArgumentSemantic.Strong)]
		string PrincipalId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable refreshAfterInSeconds;
		[NullAllowed, Export ("refreshAfterInSeconds", ArgumentSemantic.Strong)]
		NSNumber RefreshAfterInSeconds { get; set; }
	}

	// @interface AWSIoTThingAttribute
	interface AWSIoTThingAttribute
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable attributes;
		[NullAllowed, Export ("attributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Attributes { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingArn;
		[NullAllowed, Export ("thingArn", ArgumentSemantic.Strong)]
		string ThingArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTThingConnectivity
	interface AWSIoTThingConnectivity
	{
		// @property (nonatomic, strong) NSNumber * _Nullable connected;
		[NullAllowed, Export ("connected", ArgumentSemantic.Strong)]
		NSNumber Connected { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable disconnectReason;
		[NullAllowed, Export ("disconnectReason", ArgumentSemantic.Strong)]
		string DisconnectReason { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Strong)]
		NSNumber Timestamp { get; set; }
	}

	// @interface AWSIoTThingDocument
	interface AWSIoTThingDocument
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable attributes;
		[NullAllowed, Export ("attributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Attributes { get; set; }

		// @property (nonatomic, strong) AWSIoTThingConnectivity * _Nullable connectivity;
		[NullAllowed, Export ("connectivity", ArgumentSemantic.Strong)]
		AWSIoTThingConnectivity Connectivity { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceDefender;
		[NullAllowed, Export ("deviceDefender", ArgumentSemantic.Strong)]
		string DeviceDefender { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable shadow;
		[NullAllowed, Export ("shadow", ArgumentSemantic.Strong)]
		string Shadow { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable thingGroupNames;
		[NullAllowed, Export ("thingGroupNames", ArgumentSemantic.Strong)]
		string[] ThingGroupNames { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingId;
		[NullAllowed, Export ("thingId", ArgumentSemantic.Strong)]
		string ThingId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }
	}

	// @interface AWSIoTThingGroupDocument
	interface AWSIoTThingGroupDocument
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable attributes;
		[NullAllowed, Export ("attributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> Attributes { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable parentGroupNames;
		[NullAllowed, Export ("parentGroupNames", ArgumentSemantic.Strong)]
		string[] ParentGroupNames { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupDescription;
		[NullAllowed, Export ("thingGroupDescription", ArgumentSemantic.Strong)]
		string ThingGroupDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupId;
		[NullAllowed, Export ("thingGroupId", ArgumentSemantic.Strong)]
		string ThingGroupId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }
	}

	// @interface AWSIoTThingGroupIndexingConfiguration
	interface AWSIoTThingGroupIndexingConfiguration
	{
		// @property (nonatomic, strong) NSArray<AWSIoTField *> * _Nullable customFields;
		[NullAllowed, Export ("customFields", ArgumentSemantic.Strong)]
		AWSIoTField[] CustomFields { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTField *> * _Nullable managedFields;
		[NullAllowed, Export ("managedFields", ArgumentSemantic.Strong)]
		AWSIoTField[] ManagedFields { get; set; }

		// @property (assign, nonatomic) AWSIoTThingGroupIndexingMode thingGroupIndexingMode;
		[Export ("thingGroupIndexingMode", ArgumentSemantic.Assign)]
		AWSIoTThingGroupIndexingMode ThingGroupIndexingMode { get; set; }
	}

	// @interface AWSIoTThingGroupMetadata
	interface AWSIoTThingGroupMetadata
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable parentGroupName;
		[NullAllowed, Export ("parentGroupName", ArgumentSemantic.Strong)]
		string ParentGroupName { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTGroupNameAndArn *> * _Nullable rootToParentThingGroups;
		[NullAllowed, Export ("rootToParentThingGroups", ArgumentSemantic.Strong)]
		AWSIoTGroupNameAndArn[] RootToParentThingGroups { get; set; }
	}

	// @interface AWSIoTThingGroupProperties
	interface AWSIoTThingGroupProperties
	{
		// @property (nonatomic, strong) AWSIoTAttributePayload * _Nullable attributePayload;
		[NullAllowed, Export ("attributePayload", ArgumentSemantic.Strong)]
		AWSIoTAttributePayload AttributePayload { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupDescription;
		[NullAllowed, Export ("thingGroupDescription", ArgumentSemantic.Strong)]
		string ThingGroupDescription { get; set; }
	}

	// @interface AWSIoTThingIndexingConfiguration
	interface AWSIoTThingIndexingConfiguration
	{
		// @property (nonatomic, strong) NSArray<AWSIoTField *> * _Nullable customFields;
		[NullAllowed, Export ("customFields", ArgumentSemantic.Strong)]
		AWSIoTField[] CustomFields { get; set; }

		// @property (assign, nonatomic) AWSIoTDeviceDefenderIndexingMode deviceDefenderIndexingMode;
		[Export ("deviceDefenderIndexingMode", ArgumentSemantic.Assign)]
		AWSIoTDeviceDefenderIndexingMode DeviceDefenderIndexingMode { get; set; }

		// @property (nonatomic, strong) AWSIoTIndexingFilter * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		AWSIoTIndexingFilter Filter { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTField *> * _Nullable managedFields;
		[NullAllowed, Export ("managedFields", ArgumentSemantic.Strong)]
		AWSIoTField[] ManagedFields { get; set; }

		// @property (assign, nonatomic) AWSIoTNamedShadowIndexingMode namedShadowIndexingMode;
		[Export ("namedShadowIndexingMode", ArgumentSemantic.Assign)]
		AWSIoTNamedShadowIndexingMode NamedShadowIndexingMode { get; set; }

		// @property (assign, nonatomic) AWSIoTThingConnectivityIndexingMode thingConnectivityIndexingMode;
		[Export ("thingConnectivityIndexingMode", ArgumentSemantic.Assign)]
		AWSIoTThingConnectivityIndexingMode ThingConnectivityIndexingMode { get; set; }

		// @property (assign, nonatomic) AWSIoTThingIndexingMode thingIndexingMode;
		[Export ("thingIndexingMode", ArgumentSemantic.Assign)]
		AWSIoTThingIndexingMode ThingIndexingMode { get; set; }
	}

	// @interface AWSIoTThingTypeDefinition
	interface AWSIoTThingTypeDefinition
	{
		// @property (nonatomic, strong) NSString * _Nullable thingTypeArn;
		[NullAllowed, Export ("thingTypeArn", ArgumentSemantic.Strong)]
		string ThingTypeArn { get; set; }

		// @property (nonatomic, strong) AWSIoTThingTypeMetadata * _Nullable thingTypeMetadata;
		[NullAllowed, Export ("thingTypeMetadata", ArgumentSemantic.Strong)]
		AWSIoTThingTypeMetadata ThingTypeMetadata { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingTypeProperties * _Nullable thingTypeProperties;
		[NullAllowed, Export ("thingTypeProperties", ArgumentSemantic.Strong)]
		AWSIoTThingTypeProperties ThingTypeProperties { get; set; }
	}

	// @interface AWSIoTThingTypeMetadata
	interface AWSIoTThingTypeMetadata
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable deprecated;
		[NullAllowed, Export ("deprecated", ArgumentSemantic.Strong)]
		NSNumber Deprecated { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable deprecationDate;
		[NullAllowed, Export ("deprecationDate", ArgumentSemantic.Strong)]
		NSDate DeprecationDate { get; set; }
	}

	// @interface AWSIoTThingTypeProperties
	interface AWSIoTThingTypeProperties
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable searchableAttributes;
		[NullAllowed, Export ("searchableAttributes", ArgumentSemantic.Strong)]
		string[] SearchableAttributes { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeDescription;
		[NullAllowed, Export ("thingTypeDescription", ArgumentSemantic.Strong)]
		string ThingTypeDescription { get; set; }
	}

	// @interface AWSIoTTimeoutConfig
	interface AWSIoTTimeoutConfig
	{
		// @property (nonatomic, strong) NSNumber * _Nullable inProgressTimeoutInMinutes;
		[NullAllowed, Export ("inProgressTimeoutInMinutes", ArgumentSemantic.Strong)]
		NSNumber InProgressTimeoutInMinutes { get; set; }
	}

	// @interface AWSIoTTimestreamAction
	interface AWSIoTTimestreamAction
	{
		// @property (nonatomic, strong) NSString * _Nullable databaseName;
		[NullAllowed, Export ("databaseName", ArgumentSemantic.Strong)]
		string DatabaseName { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTTimestreamDimension *> * _Nullable dimensions;
		[NullAllowed, Export ("dimensions", ArgumentSemantic.Strong)]
		AWSIoTTimestreamDimension[] Dimensions { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tableName;
		[NullAllowed, Export ("tableName", ArgumentSemantic.Strong)]
		string TableName { get; set; }

		// @property (nonatomic, strong) AWSIoTTimestreamTimestamp * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Strong)]
		AWSIoTTimestreamTimestamp Timestamp { get; set; }
	}

	// @interface AWSIoTTimestreamDimension
	interface AWSIoTTimestreamDimension
	{
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSIoTTimestreamTimestamp
	interface AWSIoTTimestreamTimestamp
	{
		// @property (nonatomic, strong) NSString * _Nullable unit;
		[NullAllowed, Export ("unit", ArgumentSemantic.Strong)]
		string Unit { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSIoTTlsContext
	interface AWSIoTTlsContext
	{
		// @property (nonatomic, strong) NSString * _Nullable serverName;
		[NullAllowed, Export ("serverName", ArgumentSemantic.Strong)]
		string ServerName { get; set; }
	}

	// @interface AWSIoTTopicRule
	interface AWSIoTTopicRule
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAction *> * _Nullable actions;
		[NullAllowed, Export ("actions", ArgumentSemantic.Strong)]
		AWSIoTAction[] Actions { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable awsIotSqlVersion;
		[NullAllowed, Export ("awsIotSqlVersion", ArgumentSemantic.Strong)]
		string AwsIotSqlVersion { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) AWSIoTAction * _Nullable errorAction;
		[NullAllowed, Export ("errorAction", ArgumentSemantic.Strong)]
		AWSIoTAction ErrorAction { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable ruleDisabled;
		[NullAllowed, Export ("ruleDisabled", ArgumentSemantic.Strong)]
		NSNumber RuleDisabled { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sql;
		[NullAllowed, Export ("sql", ArgumentSemantic.Strong)]
		string Sql { get; set; }
	}

	// @interface AWSIoTTopicRuleDestination
	interface AWSIoTTopicRuleDestination
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) AWSIoTHttpUrlDestinationProperties * _Nullable httpUrlProperties;
		[NullAllowed, Export ("httpUrlProperties", ArgumentSemantic.Strong)]
		AWSIoTHttpUrlDestinationProperties HttpUrlProperties { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastUpdatedAt;
		[NullAllowed, Export ("lastUpdatedAt", ArgumentSemantic.Strong)]
		NSDate LastUpdatedAt { get; set; }

		// @property (assign, nonatomic) AWSIoTTopicRuleDestinationStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTTopicRuleDestinationStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable statusReason;
		[NullAllowed, Export ("statusReason", ArgumentSemantic.Strong)]
		string StatusReason { get; set; }

		// @property (nonatomic, strong) AWSIoTVpcDestinationProperties * _Nullable vpcProperties;
		[NullAllowed, Export ("vpcProperties", ArgumentSemantic.Strong)]
		AWSIoTVpcDestinationProperties VpcProperties { get; set; }
	}

	// @interface AWSIoTTopicRuleDestinationConfiguration
	interface AWSIoTTopicRuleDestinationConfiguration
	{
		// @property (nonatomic, strong) AWSIoTHttpUrlDestinationConfiguration * _Nullable httpUrlConfiguration;
		[NullAllowed, Export ("httpUrlConfiguration", ArgumentSemantic.Strong)]
		AWSIoTHttpUrlDestinationConfiguration HttpUrlConfiguration { get; set; }

		// @property (nonatomic, strong) AWSIoTVpcDestinationConfiguration * _Nullable vpcConfiguration;
		[NullAllowed, Export ("vpcConfiguration", ArgumentSemantic.Strong)]
		AWSIoTVpcDestinationConfiguration VpcConfiguration { get; set; }
	}

	// @interface AWSIoTTopicRuleDestinationSummary
	interface AWSIoTTopicRuleDestinationSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) AWSIoTHttpUrlDestinationSummary * _Nullable httpUrlSummary;
		[NullAllowed, Export ("httpUrlSummary", ArgumentSemantic.Strong)]
		AWSIoTHttpUrlDestinationSummary HttpUrlSummary { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastUpdatedAt;
		[NullAllowed, Export ("lastUpdatedAt", ArgumentSemantic.Strong)]
		NSDate LastUpdatedAt { get; set; }

		// @property (assign, nonatomic) AWSIoTTopicRuleDestinationStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTTopicRuleDestinationStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable statusReason;
		[NullAllowed, Export ("statusReason", ArgumentSemantic.Strong)]
		string StatusReason { get; set; }

		// @property (nonatomic, strong) AWSIoTVpcDestinationSummary * _Nullable vpcDestinationSummary;
		[NullAllowed, Export ("vpcDestinationSummary", ArgumentSemantic.Strong)]
		AWSIoTVpcDestinationSummary VpcDestinationSummary { get; set; }
	}

	// @interface AWSIoTTopicRuleListItem
	interface AWSIoTTopicRuleListItem
	{
		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ruleArn;
		[NullAllowed, Export ("ruleArn", ArgumentSemantic.Strong)]
		string RuleArn { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable ruleDisabled;
		[NullAllowed, Export ("ruleDisabled", ArgumentSemantic.Strong)]
		NSNumber RuleDisabled { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ruleName;
		[NullAllowed, Export ("ruleName", ArgumentSemantic.Strong)]
		string RuleName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable topicPattern;
		[NullAllowed, Export ("topicPattern", ArgumentSemantic.Strong)]
		string TopicPattern { get; set; }
	}

	// @interface AWSIoTTopicRulePayload
	interface AWSIoTTopicRulePayload
	{
		// @property (nonatomic, strong) NSArray<AWSIoTAction *> * _Nullable actions;
		[NullAllowed, Export ("actions", ArgumentSemantic.Strong)]
		AWSIoTAction[] Actions { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable awsIotSqlVersion;
		[NullAllowed, Export ("awsIotSqlVersion", ArgumentSemantic.Strong)]
		string AwsIotSqlVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) AWSIoTAction * _Nullable errorAction;
		[NullAllowed, Export ("errorAction", ArgumentSemantic.Strong)]
		AWSIoTAction ErrorAction { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable ruleDisabled;
		[NullAllowed, Export ("ruleDisabled", ArgumentSemantic.Strong)]
		NSNumber RuleDisabled { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sql;
		[NullAllowed, Export ("sql", ArgumentSemantic.Strong)]
		string Sql { get; set; }
	}

	// @interface AWSIoTTransferCertificateRequest
	interface AWSIoTTransferCertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable targetAwsAccount;
		[NullAllowed, Export ("targetAwsAccount", ArgumentSemantic.Strong)]
		string TargetAwsAccount { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable transferMessage;
		[NullAllowed, Export ("transferMessage", ArgumentSemantic.Strong)]
		string TransferMessage { get; set; }
	}

	// @interface AWSIoTTransferCertificateResponse
	interface AWSIoTTransferCertificateResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable transferredCertificateArn;
		[NullAllowed, Export ("transferredCertificateArn", ArgumentSemantic.Strong)]
		string TransferredCertificateArn { get; set; }
	}

	// @interface AWSIoTTransferData
	interface AWSIoTTransferData
	{
		// @property (nonatomic, strong) NSDate * _Nullable acceptDate;
		[NullAllowed, Export ("acceptDate", ArgumentSemantic.Strong)]
		NSDate AcceptDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable rejectDate;
		[NullAllowed, Export ("rejectDate", ArgumentSemantic.Strong)]
		NSDate RejectDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable rejectReason;
		[NullAllowed, Export ("rejectReason", ArgumentSemantic.Strong)]
		string RejectReason { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable transferDate;
		[NullAllowed, Export ("transferDate", ArgumentSemantic.Strong)]
		NSDate TransferDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable transferMessage;
		[NullAllowed, Export ("transferMessage", ArgumentSemantic.Strong)]
		string TransferMessage { get; set; }
	}

	// @interface AWSIoTUntagResourceRequest
	interface AWSIoTUntagResourceRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable resourceArn;
		[NullAllowed, Export ("resourceArn", ArgumentSemantic.Strong)]
		string ResourceArn { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable tagKeys;
		[NullAllowed, Export ("tagKeys", ArgumentSemantic.Strong)]
		string[] TagKeys { get; set; }
	}

	// @interface AWSIoTUntagResourceResponse
	interface AWSIoTUntagResourceResponse
	{
	}

	// @interface AWSIoTUpdateAccountAuditConfigurationRequest
	interface AWSIoTUpdateAccountAuditConfigurationRequest
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAuditCheckConfiguration *> * _Nullable auditCheckConfigurations;
		[NullAllowed, Export ("auditCheckConfigurations", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAuditCheckConfiguration> AuditCheckConfigurations { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAuditNotificationTarget *> * _Nullable auditNotificationTargetConfigurations;
		[NullAllowed, Export ("auditNotificationTargetConfigurations", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAuditNotificationTarget> AuditNotificationTargetConfigurations { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTUpdateAccountAuditConfigurationResponse
	interface AWSIoTUpdateAccountAuditConfigurationResponse
	{
	}

	// @interface AWSIoTUpdateAuditSuppressionRequest
	interface AWSIoTUpdateAuditSuppressionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable checkName;
		[NullAllowed, Export ("checkName", ArgumentSemantic.Strong)]
		string CheckName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expirationDate;
		[NullAllowed, Export ("expirationDate", ArgumentSemantic.Strong)]
		NSDate ExpirationDate { get; set; }

		// @property (nonatomic, strong) AWSIoTResourceIdentifier * _Nullable resourceIdentifier;
		[NullAllowed, Export ("resourceIdentifier", ArgumentSemantic.Strong)]
		AWSIoTResourceIdentifier ResourceIdentifier { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable suppressIndefinitely;
		[NullAllowed, Export ("suppressIndefinitely", ArgumentSemantic.Strong)]
		NSNumber SuppressIndefinitely { get; set; }
	}

	// @interface AWSIoTUpdateAuditSuppressionResponse
	interface AWSIoTUpdateAuditSuppressionResponse
	{
	}

	// @interface AWSIoTUpdateAuthorizerRequest
	interface AWSIoTUpdateAuthorizerRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerFunctionArn;
		[NullAllowed, Export ("authorizerFunctionArn", ArgumentSemantic.Strong)]
		string AuthorizerFunctionArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable enableCachingForHttp;
		[NullAllowed, Export ("enableCachingForHttp", ArgumentSemantic.Strong)]
		NSNumber EnableCachingForHttp { get; set; }

		// @property (assign, nonatomic) AWSIoTAuthorizerStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTAuthorizerStatus Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tokenKeyName;
		[NullAllowed, Export ("tokenKeyName", ArgumentSemantic.Strong)]
		string TokenKeyName { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,NSString *> * _Nullable tokenSigningPublicKeys;
		[NullAllowed, Export ("tokenSigningPublicKeys", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> TokenSigningPublicKeys { get; set; }
	}

	// @interface AWSIoTUpdateAuthorizerResponse
	interface AWSIoTUpdateAuthorizerResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable authorizerArn;
		[NullAllowed, Export ("authorizerArn", ArgumentSemantic.Strong)]
		string AuthorizerArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable authorizerName;
		[NullAllowed, Export ("authorizerName", ArgumentSemantic.Strong)]
		string AuthorizerName { get; set; }
	}

	// @interface AWSIoTUpdateBillingGroupRequest
	interface AWSIoTUpdateBillingGroupRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable billingGroupName;
		[NullAllowed, Export ("billingGroupName", ArgumentSemantic.Strong)]
		string BillingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTBillingGroupProperties * _Nullable billingGroupProperties;
		[NullAllowed, Export ("billingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTBillingGroupProperties BillingGroupProperties { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }
	}

	// @interface AWSIoTUpdateBillingGroupResponse
	interface AWSIoTUpdateBillingGroupResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTUpdateCACertificateParams
	interface AWSIoTUpdateCACertificateParams
	{
		// @property (assign, nonatomic) AWSIoTCACertificateUpdateAction action;
		[Export ("action", ArgumentSemantic.Assign)]
		AWSIoTCACertificateUpdateAction Action { get; set; }
	}

	// @interface AWSIoTUpdateCACertificateRequest
	interface AWSIoTUpdateCACertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (assign, nonatomic) AWSIoTAutoRegistrationStatus latestAutoRegistrationStatus;
		[Export ("latestAutoRegistrationStatus", ArgumentSemantic.Assign)]
		AWSIoTAutoRegistrationStatus LatestAutoRegistrationStatus { get; set; }

		// @property (assign, nonatomic) AWSIoTCACertificateStatus latestStatus;
		[Export ("latestStatus", ArgumentSemantic.Assign)]
		AWSIoTCACertificateStatus LatestStatus { get; set; }

		// @property (nonatomic, strong) AWSIoTRegistrationConfig * _Nullable registrationConfig;
		[NullAllowed, Export ("registrationConfig", ArgumentSemantic.Strong)]
		AWSIoTRegistrationConfig RegistrationConfig { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable removeAutoRegistration;
		[NullAllowed, Export ("removeAutoRegistration", ArgumentSemantic.Strong)]
		NSNumber RemoveAutoRegistration { get; set; }
	}

	// @interface AWSIoTUpdateCertificateRequest
	interface AWSIoTUpdateCertificateRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable certificateId;
		[NullAllowed, Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (assign, nonatomic) AWSIoTCertificateStatus latestStatus;
		[Export ("latestStatus", ArgumentSemantic.Assign)]
		AWSIoTCertificateStatus LatestStatus { get; set; }
	}

	// @interface AWSIoTUpdateCustomMetricRequest
	interface AWSIoTUpdateCustomMetricRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName", ArgumentSemantic.Strong)]
		string DisplayName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }
	}

	// @interface AWSIoTUpdateCustomMetricResponse
	interface AWSIoTUpdateCustomMetricResponse
	{
		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName", ArgumentSemantic.Strong)]
		string DisplayName { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricArn;
		[NullAllowed, Export ("metricArn", ArgumentSemantic.Strong)]
		string MetricArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (assign, nonatomic) AWSIoTCustomMetricType metricType;
		[Export ("metricType", ArgumentSemantic.Assign)]
		AWSIoTCustomMetricType MetricType { get; set; }
	}

	// @interface AWSIoTUpdateDeviceCertificateParams
	interface AWSIoTUpdateDeviceCertificateParams
	{
		// @property (assign, nonatomic) AWSIoTDeviceCertificateUpdateAction action;
		[Export ("action", ArgumentSemantic.Assign)]
		AWSIoTDeviceCertificateUpdateAction Action { get; set; }
	}

	// @interface AWSIoTUpdateDimensionRequest
	interface AWSIoTUpdateDimensionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable stringValues;
		[NullAllowed, Export ("stringValues", ArgumentSemantic.Strong)]
		string[] StringValues { get; set; }
	}

	// @interface AWSIoTUpdateDimensionResponse
	interface AWSIoTUpdateDimensionResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable stringValues;
		[NullAllowed, Export ("stringValues", ArgumentSemantic.Strong)]
		string[] StringValues { get; set; }

		// @property (assign, nonatomic) AWSIoTDimensionType types;
		[Export ("types", ArgumentSemantic.Assign)]
		AWSIoTDimensionType Types { get; set; }
	}

	// @interface AWSIoTUpdateDomainConfigurationRequest
	interface AWSIoTUpdateDomainConfigurationRequest
	{
		// @property (nonatomic, strong) AWSIoTAuthorizerConfig * _Nullable authorizerConfig;
		[NullAllowed, Export ("authorizerConfig", ArgumentSemantic.Strong)]
		AWSIoTAuthorizerConfig AuthorizerConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }

		// @property (assign, nonatomic) AWSIoTDomainConfigurationStatus domainConfigurationStatus;
		[Export ("domainConfigurationStatus", ArgumentSemantic.Assign)]
		AWSIoTDomainConfigurationStatus DomainConfigurationStatus { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable removeAuthorizerConfig;
		[NullAllowed, Export ("removeAuthorizerConfig", ArgumentSemantic.Strong)]
		NSNumber RemoveAuthorizerConfig { get; set; }
	}

	// @interface AWSIoTUpdateDomainConfigurationResponse
	interface AWSIoTUpdateDomainConfigurationResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationArn;
		[NullAllowed, Export ("domainConfigurationArn", ArgumentSemantic.Strong)]
		string DomainConfigurationArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domainConfigurationName;
		[NullAllowed, Export ("domainConfigurationName", ArgumentSemantic.Strong)]
		string DomainConfigurationName { get; set; }
	}

	// @interface AWSIoTUpdateDynamicThingGroupRequest
	interface AWSIoTUpdateDynamicThingGroupRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingGroupProperties * _Nullable thingGroupProperties;
		[NullAllowed, Export ("thingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTThingGroupProperties ThingGroupProperties { get; set; }
	}

	// @interface AWSIoTUpdateDynamicThingGroupResponse
	interface AWSIoTUpdateDynamicThingGroupResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTUpdateEventConfigurationsRequest
	interface AWSIoTUpdateEventConfigurationsRequest
	{
		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTConfiguration *> * _Nullable eventConfigurations;
		[NullAllowed, Export ("eventConfigurations", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTConfiguration> EventConfigurations { get; set; }
	}

	// @interface AWSIoTUpdateEventConfigurationsResponse
	interface AWSIoTUpdateEventConfigurationsResponse
	{
	}

	// @interface AWSIoTUpdateFleetMetricRequest
	interface AWSIoTUpdateFleetMetricRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable aggregationField;
		[NullAllowed, Export ("aggregationField", ArgumentSemantic.Strong)]
		string AggregationField { get; set; }

		// @property (nonatomic, strong) AWSIoTAggregationType * _Nullable aggregationType;
		[NullAllowed, Export ("aggregationType", ArgumentSemantic.Strong)]
		AWSIoTAggregationType AggregationType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable indexName;
		[NullAllowed, Export ("indexName", ArgumentSemantic.Strong)]
		string IndexName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable metricName;
		[NullAllowed, Export ("metricName", ArgumentSemantic.Strong)]
		string MetricName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable period;
		[NullAllowed, Export ("period", ArgumentSemantic.Strong)]
		NSNumber Period { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryString;
		[NullAllowed, Export ("queryString", ArgumentSemantic.Strong)]
		string QueryString { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable queryVersion;
		[NullAllowed, Export ("queryVersion", ArgumentSemantic.Strong)]
		string QueryVersion { get; set; }

		// @property (assign, nonatomic) AWSIoTFleetMetricUnit unit;
		[Export ("unit", ArgumentSemantic.Assign)]
		AWSIoTFleetMetricUnit Unit { get; set; }
	}

	// @interface AWSIoTUpdateIndexingConfigurationRequest
	interface AWSIoTUpdateIndexingConfigurationRequest
	{
		// @property (nonatomic, strong) AWSIoTThingGroupIndexingConfiguration * _Nullable thingGroupIndexingConfiguration;
		[NullAllowed, Export ("thingGroupIndexingConfiguration", ArgumentSemantic.Strong)]
		AWSIoTThingGroupIndexingConfiguration ThingGroupIndexingConfiguration { get; set; }

		// @property (nonatomic, strong) AWSIoTThingIndexingConfiguration * _Nullable thingIndexingConfiguration;
		[NullAllowed, Export ("thingIndexingConfiguration", ArgumentSemantic.Strong)]
		AWSIoTThingIndexingConfiguration ThingIndexingConfiguration { get; set; }
	}

	// @interface AWSIoTUpdateIndexingConfigurationResponse
	interface AWSIoTUpdateIndexingConfigurationResponse
	{
	}

	// @interface AWSIoTUpdateJobRequest
	interface AWSIoTUpdateJobRequest
	{
		// @property (nonatomic, strong) AWSIoTAbortConfig * _Nullable abortConfig;
		[NullAllowed, Export ("abortConfig", ArgumentSemantic.Strong)]
		AWSIoTAbortConfig AbortConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRetryConfig * _Nullable jobExecutionsRetryConfig;
		[NullAllowed, Export ("jobExecutionsRetryConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTJobExecutionsRolloutConfig * _Nullable jobExecutionsRolloutConfig;
		[NullAllowed, Export ("jobExecutionsRolloutConfig", ArgumentSemantic.Strong)]
		AWSIoTJobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable jobId;
		[NullAllowed, Export ("jobId", ArgumentSemantic.Strong)]
		string JobId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable namespaceId;
		[NullAllowed, Export ("namespaceId", ArgumentSemantic.Strong)]
		string NamespaceId { get; set; }

		// @property (nonatomic, strong) AWSIoTPresignedUrlConfig * _Nullable presignedUrlConfig;
		[NullAllowed, Export ("presignedUrlConfig", ArgumentSemantic.Strong)]
		AWSIoTPresignedUrlConfig PresignedUrlConfig { get; set; }

		// @property (nonatomic, strong) AWSIoTTimeoutConfig * _Nullable timeoutConfig;
		[NullAllowed, Export ("timeoutConfig", ArgumentSemantic.Strong)]
		AWSIoTTimeoutConfig TimeoutConfig { get; set; }
	}

	// @interface AWSIoTUpdateMitigationActionRequest
	interface AWSIoTUpdateMitigationActionRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable actionName;
		[NullAllowed, Export ("actionName", ArgumentSemantic.Strong)]
		string ActionName { get; set; }

		// @property (nonatomic, strong) AWSIoTMitigationActionParams * _Nullable actionParams;
		[NullAllowed, Export ("actionParams", ArgumentSemantic.Strong)]
		AWSIoTMitigationActionParams ActionParams { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTUpdateMitigationActionResponse
	interface AWSIoTUpdateMitigationActionResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable actionArn;
		[NullAllowed, Export ("actionArn", ArgumentSemantic.Strong)]
		string ActionArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable actionId;
		[NullAllowed, Export ("actionId", ArgumentSemantic.Strong)]
		string ActionId { get; set; }
	}

	// @interface AWSIoTUpdateProvisioningTemplateRequest
	interface AWSIoTUpdateProvisioningTemplateRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable defaultVersionId;
		[NullAllowed, Export ("defaultVersionId", ArgumentSemantic.Strong)]
		NSNumber DefaultVersionId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable enabled;
		[NullAllowed, Export ("enabled", ArgumentSemantic.Strong)]
		NSNumber Enabled { get; set; }

		// @property (nonatomic, strong) AWSIoTProvisioningHook * _Nullable preProvisioningHook;
		[NullAllowed, Export ("preProvisioningHook", ArgumentSemantic.Strong)]
		AWSIoTProvisioningHook PreProvisioningHook { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable provisioningRoleArn;
		[NullAllowed, Export ("provisioningRoleArn", ArgumentSemantic.Strong)]
		string ProvisioningRoleArn { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable removePreProvisioningHook;
		[NullAllowed, Export ("removePreProvisioningHook", ArgumentSemantic.Strong)]
		NSNumber RemovePreProvisioningHook { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateName;
		[NullAllowed, Export ("templateName", ArgumentSemantic.Strong)]
		string TemplateName { get; set; }
	}

	// @interface AWSIoTUpdateProvisioningTemplateResponse
	interface AWSIoTUpdateProvisioningTemplateResponse
	{
	}

	// @interface AWSIoTUpdateRoleAliasRequest
	interface AWSIoTUpdateRoleAliasRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable credentialDurationSeconds;
		[NullAllowed, Export ("credentialDurationSeconds", ArgumentSemantic.Strong)]
		NSNumber CredentialDurationSeconds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleAlias;
		[NullAllowed, Export ("roleAlias", ArgumentSemantic.Strong)]
		string RoleAlias { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }
	}

	// @interface AWSIoTUpdateRoleAliasResponse
	interface AWSIoTUpdateRoleAliasResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable roleAlias;
		[NullAllowed, Export ("roleAlias", ArgumentSemantic.Strong)]
		string RoleAlias { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleAliasArn;
		[NullAllowed, Export ("roleAliasArn", ArgumentSemantic.Strong)]
		string RoleAliasArn { get; set; }
	}

	// @interface AWSIoTUpdateScheduledAuditRequest
	interface AWSIoTUpdateScheduledAuditRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable dayOfMonth;
		[NullAllowed, Export ("dayOfMonth", ArgumentSemantic.Strong)]
		string DayOfMonth { get; set; }

		// @property (assign, nonatomic) AWSIoTDayOfWeek dayOfWeek;
		[Export ("dayOfWeek", ArgumentSemantic.Assign)]
		AWSIoTDayOfWeek DayOfWeek { get; set; }

		// @property (assign, nonatomic) AWSIoTAuditFrequency frequency;
		[Export ("frequency", ArgumentSemantic.Assign)]
		AWSIoTAuditFrequency Frequency { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditName;
		[NullAllowed, Export ("scheduledAuditName", ArgumentSemantic.Strong)]
		string ScheduledAuditName { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable targetCheckNames;
		[NullAllowed, Export ("targetCheckNames", ArgumentSemantic.Strong)]
		string[] TargetCheckNames { get; set; }
	}

	// @interface AWSIoTUpdateScheduledAuditResponse
	interface AWSIoTUpdateScheduledAuditResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable scheduledAuditArn;
		[NullAllowed, Export ("scheduledAuditArn", ArgumentSemantic.Strong)]
		string ScheduledAuditArn { get; set; }
	}

	// @interface AWSIoTUpdateSecurityProfileRequest
	interface AWSIoTUpdateSecurityProfileRequest
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable additionalMetricsToRetain;
		[NullAllowed, Export ("additionalMetricsToRetain", ArgumentSemantic.Strong)]
		string[] AdditionalMetricsToRetain { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTMetricToRetain *> * _Nullable additionalMetricsToRetainV2;
		[NullAllowed, Export ("additionalMetricsToRetainV2", ArgumentSemantic.Strong)]
		AWSIoTMetricToRetain[] AdditionalMetricsToRetainV2 { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAlertTarget *> * _Nullable alertTargets;
		[NullAllowed, Export ("alertTargets", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAlertTarget> AlertTargets { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTBehavior *> * _Nullable behaviors;
		[NullAllowed, Export ("behaviors", ArgumentSemantic.Strong)]
		AWSIoTBehavior[] Behaviors { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable deleteAdditionalMetricsToRetain;
		[NullAllowed, Export ("deleteAdditionalMetricsToRetain", ArgumentSemantic.Strong)]
		NSNumber DeleteAdditionalMetricsToRetain { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable deleteAlertTargets;
		[NullAllowed, Export ("deleteAlertTargets", ArgumentSemantic.Strong)]
		NSNumber DeleteAlertTargets { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable deleteBehaviors;
		[NullAllowed, Export ("deleteBehaviors", ArgumentSemantic.Strong)]
		NSNumber DeleteBehaviors { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileDescription;
		[NullAllowed, Export ("securityProfileDescription", ArgumentSemantic.Strong)]
		string SecurityProfileDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }
	}

	// @interface AWSIoTUpdateSecurityProfileResponse
	interface AWSIoTUpdateSecurityProfileResponse
	{
		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable additionalMetricsToRetain;
		[NullAllowed, Export ("additionalMetricsToRetain", ArgumentSemantic.Strong)]
		string[] AdditionalMetricsToRetain { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTMetricToRetain *> * _Nullable additionalMetricsToRetainV2;
		[NullAllowed, Export ("additionalMetricsToRetainV2", ArgumentSemantic.Strong)]
		AWSIoTMetricToRetain[] AdditionalMetricsToRetainV2 { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,AWSIoTAlertTarget *> * _Nullable alertTargets;
		[NullAllowed, Export ("alertTargets", ArgumentSemantic.Strong)]
		NSDictionary<NSString, AWSIoTAlertTarget> AlertTargets { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTBehavior *> * _Nullable behaviors;
		[NullAllowed, Export ("behaviors", ArgumentSemantic.Strong)]
		AWSIoTBehavior[] Behaviors { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable creationDate;
		[NullAllowed, Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable lastModifiedDate;
		[NullAllowed, Export ("lastModifiedDate", ArgumentSemantic.Strong)]
		NSDate LastModifiedDate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileArn;
		[NullAllowed, Export ("securityProfileArn", ArgumentSemantic.Strong)]
		string SecurityProfileArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileDescription;
		[NullAllowed, Export ("securityProfileDescription", ArgumentSemantic.Strong)]
		string SecurityProfileDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTUpdateStreamRequest
	interface AWSIoTUpdateStreamRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTStreamFile *> * _Nullable files;
		[NullAllowed, Export ("files", ArgumentSemantic.Strong)]
		AWSIoTStreamFile[] Files { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }
	}

	// @interface AWSIoTUpdateStreamResponse
	interface AWSIoTUpdateStreamResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable detail;
		[NullAllowed, Export ("detail", ArgumentSemantic.Strong)]
		string Detail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamArn;
		[NullAllowed, Export ("streamArn", ArgumentSemantic.Strong)]
		string StreamArn { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable streamId;
		[NullAllowed, Export ("streamId", ArgumentSemantic.Strong)]
		string StreamId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable streamVersion;
		[NullAllowed, Export ("streamVersion", ArgumentSemantic.Strong)]
		NSNumber StreamVersion { get; set; }
	}

	// @interface AWSIoTUpdateThingGroupRequest
	interface AWSIoTUpdateThingGroupRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingGroupName;
		[NullAllowed, Export ("thingGroupName", ArgumentSemantic.Strong)]
		string ThingGroupName { get; set; }

		// @property (nonatomic, strong) AWSIoTThingGroupProperties * _Nullable thingGroupProperties;
		[NullAllowed, Export ("thingGroupProperties", ArgumentSemantic.Strong)]
		AWSIoTThingGroupProperties ThingGroupProperties { get; set; }
	}

	// @interface AWSIoTUpdateThingGroupResponse
	interface AWSIoTUpdateThingGroupResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable version;
		[NullAllowed, Export ("version", ArgumentSemantic.Strong)]
		NSNumber Version { get; set; }
	}

	// @interface AWSIoTUpdateThingGroupsForThingRequest
	interface AWSIoTUpdateThingGroupsForThingRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable overrideDynamicGroups;
		[NullAllowed, Export ("overrideDynamicGroups", ArgumentSemantic.Strong)]
		NSNumber OverrideDynamicGroups { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable thingGroupsToAdd;
		[NullAllowed, Export ("thingGroupsToAdd", ArgumentSemantic.Strong)]
		string[] ThingGroupsToAdd { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable thingGroupsToRemove;
		[NullAllowed, Export ("thingGroupsToRemove", ArgumentSemantic.Strong)]
		string[] ThingGroupsToRemove { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTUpdateThingGroupsForThingResponse
	interface AWSIoTUpdateThingGroupsForThingResponse
	{
	}

	// @interface AWSIoTUpdateThingRequest
	interface AWSIoTUpdateThingRequest
	{
		// @property (nonatomic, strong) AWSIoTAttributePayload * _Nullable attributePayload;
		[NullAllowed, Export ("attributePayload", ArgumentSemantic.Strong)]
		AWSIoTAttributePayload AttributePayload { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable expectedVersion;
		[NullAllowed, Export ("expectedVersion", ArgumentSemantic.Strong)]
		NSNumber ExpectedVersion { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable removeThingType;
		[NullAllowed, Export ("removeThingType", ArgumentSemantic.Strong)]
		NSNumber RemoveThingType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingTypeName;
		[NullAllowed, Export ("thingTypeName", ArgumentSemantic.Strong)]
		string ThingTypeName { get; set; }
	}

	// @interface AWSIoTUpdateThingResponse
	interface AWSIoTUpdateThingResponse
	{
	}

	// @interface AWSIoTUpdateTopicRuleDestinationRequest
	interface AWSIoTUpdateTopicRuleDestinationRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable arn;
		[NullAllowed, Export ("arn", ArgumentSemantic.Strong)]
		string Arn { get; set; }

		// @property (assign, nonatomic) AWSIoTTopicRuleDestinationStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		AWSIoTTopicRuleDestinationStatus Status { get; set; }
	}

	// @interface AWSIoTUpdateTopicRuleDestinationResponse
	interface AWSIoTUpdateTopicRuleDestinationResponse
	{
	}

	// @interface AWSIoTUserProperty
	interface AWSIoTUserProperty
	{
		// @property (nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		string Value { get; set; }
	}

	// @interface AWSIoTValidateSecurityProfileBehaviorsRequest
	interface AWSIoTValidateSecurityProfileBehaviorsRequest
	{
		// @property (nonatomic, strong) NSArray<AWSIoTBehavior *> * _Nullable behaviors;
		[NullAllowed, Export ("behaviors", ArgumentSemantic.Strong)]
		AWSIoTBehavior[] Behaviors { get; set; }
	}

	// @interface AWSIoTValidateSecurityProfileBehaviorsResponse
	interface AWSIoTValidateSecurityProfileBehaviorsResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable valid;
		[NullAllowed, Export ("valid", ArgumentSemantic.Strong)]
		NSNumber Valid { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTValidationError *> * _Nullable validationErrors;
		[NullAllowed, Export ("validationErrors", ArgumentSemantic.Strong)]
		AWSIoTValidationError[] ValidationErrors { get; set; }
	}

	// @interface AWSIoTValidationError
	interface AWSIoTValidationError
	{
		// @property (nonatomic, strong) NSString * _Nullable errorMessage;
		[NullAllowed, Export ("errorMessage", ArgumentSemantic.Strong)]
		string ErrorMessage { get; set; }
	}

	// @interface AWSIoTViolationEvent
	interface AWSIoTViolationEvent
	{
		// @property (nonatomic, strong) AWSIoTBehavior * _Nullable behavior;
		[NullAllowed, Export ("behavior", ArgumentSemantic.Strong)]
		AWSIoTBehavior Behavior { get; set; }

		// @property (nonatomic, strong) AWSIoTMetricValue * _Nullable metricValue;
		[NullAllowed, Export ("metricValue", ArgumentSemantic.Strong)]
		AWSIoTMetricValue MetricValue { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable securityProfileName;
		[NullAllowed, Export ("securityProfileName", ArgumentSemantic.Strong)]
		string SecurityProfileName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }

		// @property (assign, nonatomic) AWSIoTVerificationState verificationState;
		[Export ("verificationState", ArgumentSemantic.Assign)]
		AWSIoTVerificationState VerificationState { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable verificationStateDescription;
		[NullAllowed, Export ("verificationStateDescription", ArgumentSemantic.Strong)]
		string VerificationStateDescription { get; set; }

		// @property (nonatomic, strong) AWSIoTViolationEventAdditionalInfo * _Nullable violationEventAdditionalInfo;
		[NullAllowed, Export ("violationEventAdditionalInfo", ArgumentSemantic.Strong)]
		AWSIoTViolationEventAdditionalInfo ViolationEventAdditionalInfo { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable violationEventTime;
		[NullAllowed, Export ("violationEventTime", ArgumentSemantic.Strong)]
		NSDate ViolationEventTime { get; set; }

		// @property (assign, nonatomic) AWSIoTViolationEventType violationEventType;
		[Export ("violationEventType", ArgumentSemantic.Assign)]
		AWSIoTViolationEventType ViolationEventType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable violationId;
		[NullAllowed, Export ("violationId", ArgumentSemantic.Strong)]
		string ViolationId { get; set; }
	}

	// @interface AWSIoTViolationEventAdditionalInfo
	interface AWSIoTViolationEventAdditionalInfo
	{
		// @property (assign, nonatomic) AWSIoTConfidenceLevel confidenceLevel;
		[Export ("confidenceLevel", ArgumentSemantic.Assign)]
		AWSIoTConfidenceLevel ConfidenceLevel { get; set; }
	}

	// @interface AWSIoTViolationEventOccurrenceRange
	interface AWSIoTViolationEventOccurrenceRange
	{
		// @property (nonatomic, strong) NSDate * _Nullable endTime;
		[NullAllowed, Export ("endTime", ArgumentSemantic.Strong)]
		NSDate EndTime { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startTime;
		[NullAllowed, Export ("startTime", ArgumentSemantic.Strong)]
		NSDate StartTime { get; set; }
	}

	// @interface AWSIoTVpcDestinationConfiguration
	interface AWSIoTVpcDestinationConfiguration
	{
		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable securityGroups;
		[NullAllowed, Export ("securityGroups", ArgumentSemantic.Strong)]
		string[] SecurityGroups { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable subnetIds;
		[NullAllowed, Export ("subnetIds", ArgumentSemantic.Strong)]
		string[] SubnetIds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable vpcId;
		[NullAllowed, Export ("vpcId", ArgumentSemantic.Strong)]
		string VpcId { get; set; }
	}

	// @interface AWSIoTVpcDestinationProperties
	interface AWSIoTVpcDestinationProperties
	{
		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable securityGroups;
		[NullAllowed, Export ("securityGroups", ArgumentSemantic.Strong)]
		string[] SecurityGroups { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable subnetIds;
		[NullAllowed, Export ("subnetIds", ArgumentSemantic.Strong)]
		string[] SubnetIds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable vpcId;
		[NullAllowed, Export ("vpcId", ArgumentSemantic.Strong)]
		string VpcId { get; set; }
	}

	// @interface AWSIoTVpcDestinationSummary
	interface AWSIoTVpcDestinationSummary
	{
		// @property (nonatomic, strong) NSString * _Nullable roleArn;
		[NullAllowed, Export ("roleArn", ArgumentSemantic.Strong)]
		string RoleArn { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable securityGroups;
		[NullAllowed, Export ("securityGroups", ArgumentSemantic.Strong)]
		string[] SecurityGroups { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable subnetIds;
		[NullAllowed, Export ("subnetIds", ArgumentSemantic.Strong)]
		string[] SubnetIds { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable vpcId;
		[NullAllowed, Export ("vpcId", ArgumentSemantic.Strong)]
		string VpcId { get; set; }
	}

	// @interface AWSIoTResources : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSIoTResources
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		AWSIoTResources SharedInstance ();

		// -(NSDictionary *)JSONObject;
		[Export ("JSONObject")]
		[Verify (MethodToProperty)]
		NSDictionary JSONObject { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSIoTSDKVersion;
		[Field ("AWSIoTSDKVersion", "__Internal")]
		NSString AWSIoTSDKVersion { get; }
	}

	// @interface AWSIoT
	interface AWSIoT
	{
		// @property (readonly, nonatomic, strong) int * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		unsafe int* Configuration { get; }

		// +(instancetype _Nonnull)defaultIoT;
		[Static]
		[Export ("defaultIoT")]
		AWSIoT DefaultIoT ();

		// +(void)registerIoTWithConfiguration:(id)configuration forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("registerIoTWithConfiguration:forKey:")]
		void RegisterIoTWithConfiguration (NSObject configuration, string key);

		// +(instancetype _Nonnull)IoTForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("IoTForKey:")]
		AWSIoT IoTForKey (string key);

		// +(void)removeIoTForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("removeIoTForKey:")]
		void RemoveIoTForKey (string key);

		// -(id)acceptCertificateTransfer:(AWSIoTAcceptCertificateTransferRequest * _Nonnull)request;
		[Export ("acceptCertificateTransfer:")]
		NSObject AcceptCertificateTransfer (AWSIoTAcceptCertificateTransferRequest request);

		// -(void)acceptCertificateTransfer:(AWSIoTAcceptCertificateTransferRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("acceptCertificateTransfer:completionHandler:")]
		void AcceptCertificateTransfer (AWSIoTAcceptCertificateTransferRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)addThingToBillingGroup:(AWSIoTAddThingToBillingGroupRequest * _Nonnull)request;
		[Export ("addThingToBillingGroup:")]
		NSObject AddThingToBillingGroup (AWSIoTAddThingToBillingGroupRequest request);

		// -(void)addThingToBillingGroup:(AWSIoTAddThingToBillingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTAddThingToBillingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("addThingToBillingGroup:completionHandler:")]
		void AddThingToBillingGroup (AWSIoTAddThingToBillingGroupRequest request, [NullAllowed] Action<AWSIoTAddThingToBillingGroupResponse, NSError> completionHandler);

		// -(id)addThingToThingGroup:(AWSIoTAddThingToThingGroupRequest * _Nonnull)request;
		[Export ("addThingToThingGroup:")]
		NSObject AddThingToThingGroup (AWSIoTAddThingToThingGroupRequest request);

		// -(void)addThingToThingGroup:(AWSIoTAddThingToThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTAddThingToThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("addThingToThingGroup:completionHandler:")]
		void AddThingToThingGroup (AWSIoTAddThingToThingGroupRequest request, [NullAllowed] Action<AWSIoTAddThingToThingGroupResponse, NSError> completionHandler);

		// -(id)associateTargetsWithJob:(AWSIoTAssociateTargetsWithJobRequest * _Nonnull)request;
		[Export ("associateTargetsWithJob:")]
		NSObject AssociateTargetsWithJob (AWSIoTAssociateTargetsWithJobRequest request);

		// -(void)associateTargetsWithJob:(AWSIoTAssociateTargetsWithJobRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTAssociateTargetsWithJobResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("associateTargetsWithJob:completionHandler:")]
		void AssociateTargetsWithJob (AWSIoTAssociateTargetsWithJobRequest request, [NullAllowed] Action<AWSIoTAssociateTargetsWithJobResponse, NSError> completionHandler);

		// -(id)attachPolicy:(AWSIoTAttachPolicyRequest * _Nonnull)request;
		[Export ("attachPolicy:")]
		NSObject AttachPolicy (AWSIoTAttachPolicyRequest request);

		// -(void)attachPolicy:(AWSIoTAttachPolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("attachPolicy:completionHandler:")]
		void AttachPolicy (AWSIoTAttachPolicyRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)attachPrincipalPolicy:(AWSIoTAttachPrincipalPolicyRequest * _Nonnull)request;
		[Export ("attachPrincipalPolicy:")]
		NSObject AttachPrincipalPolicy (AWSIoTAttachPrincipalPolicyRequest request);

		// -(void)attachPrincipalPolicy:(AWSIoTAttachPrincipalPolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("attachPrincipalPolicy:completionHandler:")]
		void AttachPrincipalPolicy (AWSIoTAttachPrincipalPolicyRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)attachSecurityProfile:(AWSIoTAttachSecurityProfileRequest * _Nonnull)request;
		[Export ("attachSecurityProfile:")]
		NSObject AttachSecurityProfile (AWSIoTAttachSecurityProfileRequest request);

		// -(void)attachSecurityProfile:(AWSIoTAttachSecurityProfileRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTAttachSecurityProfileResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("attachSecurityProfile:completionHandler:")]
		void AttachSecurityProfile (AWSIoTAttachSecurityProfileRequest request, [NullAllowed] Action<AWSIoTAttachSecurityProfileResponse, NSError> completionHandler);

		// -(id)attachThingPrincipal:(AWSIoTAttachThingPrincipalRequest * _Nonnull)request;
		[Export ("attachThingPrincipal:")]
		NSObject AttachThingPrincipal (AWSIoTAttachThingPrincipalRequest request);

		// -(void)attachThingPrincipal:(AWSIoTAttachThingPrincipalRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTAttachThingPrincipalResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("attachThingPrincipal:completionHandler:")]
		void AttachThingPrincipal (AWSIoTAttachThingPrincipalRequest request, [NullAllowed] Action<AWSIoTAttachThingPrincipalResponse, NSError> completionHandler);

		// -(id)cancelAuditMitigationActionsTask:(AWSIoTCancelAuditMitigationActionsTaskRequest * _Nonnull)request;
		[Export ("cancelAuditMitigationActionsTask:")]
		NSObject CancelAuditMitigationActionsTask (AWSIoTCancelAuditMitigationActionsTaskRequest request);

		// -(void)cancelAuditMitigationActionsTask:(AWSIoTCancelAuditMitigationActionsTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCancelAuditMitigationActionsTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("cancelAuditMitigationActionsTask:completionHandler:")]
		void CancelAuditMitigationActionsTask (AWSIoTCancelAuditMitigationActionsTaskRequest request, [NullAllowed] Action<AWSIoTCancelAuditMitigationActionsTaskResponse, NSError> completionHandler);

		// -(id)cancelAuditTask:(AWSIoTCancelAuditTaskRequest * _Nonnull)request;
		[Export ("cancelAuditTask:")]
		NSObject CancelAuditTask (AWSIoTCancelAuditTaskRequest request);

		// -(void)cancelAuditTask:(AWSIoTCancelAuditTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCancelAuditTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("cancelAuditTask:completionHandler:")]
		void CancelAuditTask (AWSIoTCancelAuditTaskRequest request, [NullAllowed] Action<AWSIoTCancelAuditTaskResponse, NSError> completionHandler);

		// -(id)cancelCertificateTransfer:(AWSIoTCancelCertificateTransferRequest * _Nonnull)request;
		[Export ("cancelCertificateTransfer:")]
		NSObject CancelCertificateTransfer (AWSIoTCancelCertificateTransferRequest request);

		// -(void)cancelCertificateTransfer:(AWSIoTCancelCertificateTransferRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("cancelCertificateTransfer:completionHandler:")]
		void CancelCertificateTransfer (AWSIoTCancelCertificateTransferRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)cancelDetectMitigationActionsTask:(AWSIoTCancelDetectMitigationActionsTaskRequest * _Nonnull)request;
		[Export ("cancelDetectMitigationActionsTask:")]
		NSObject CancelDetectMitigationActionsTask (AWSIoTCancelDetectMitigationActionsTaskRequest request);

		// -(void)cancelDetectMitigationActionsTask:(AWSIoTCancelDetectMitigationActionsTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCancelDetectMitigationActionsTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("cancelDetectMitigationActionsTask:completionHandler:")]
		void CancelDetectMitigationActionsTask (AWSIoTCancelDetectMitigationActionsTaskRequest request, [NullAllowed] Action<AWSIoTCancelDetectMitigationActionsTaskResponse, NSError> completionHandler);

		// -(id)cancelJob:(AWSIoTCancelJobRequest * _Nonnull)request;
		[Export ("cancelJob:")]
		NSObject CancelJob (AWSIoTCancelJobRequest request);

		// -(void)cancelJob:(AWSIoTCancelJobRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCancelJobResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("cancelJob:completionHandler:")]
		void CancelJob (AWSIoTCancelJobRequest request, [NullAllowed] Action<AWSIoTCancelJobResponse, NSError> completionHandler);

		// -(id)cancelJobExecution:(AWSIoTCancelJobExecutionRequest * _Nonnull)request;
		[Export ("cancelJobExecution:")]
		NSObject CancelJobExecution (AWSIoTCancelJobExecutionRequest request);

		// -(void)cancelJobExecution:(AWSIoTCancelJobExecutionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("cancelJobExecution:completionHandler:")]
		void CancelJobExecution (AWSIoTCancelJobExecutionRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)clearDefaultAuthorizer:(AWSIoTClearDefaultAuthorizerRequest * _Nonnull)request;
		[Export ("clearDefaultAuthorizer:")]
		NSObject ClearDefaultAuthorizer (AWSIoTClearDefaultAuthorizerRequest request);

		// -(void)clearDefaultAuthorizer:(AWSIoTClearDefaultAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTClearDefaultAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("clearDefaultAuthorizer:completionHandler:")]
		void ClearDefaultAuthorizer (AWSIoTClearDefaultAuthorizerRequest request, [NullAllowed] Action<AWSIoTClearDefaultAuthorizerResponse, NSError> completionHandler);

		// -(id)confirmTopicRuleDestination:(AWSIoTConfirmTopicRuleDestinationRequest * _Nonnull)request;
		[Export ("confirmTopicRuleDestination:")]
		NSObject ConfirmTopicRuleDestination (AWSIoTConfirmTopicRuleDestinationRequest request);

		// -(void)confirmTopicRuleDestination:(AWSIoTConfirmTopicRuleDestinationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTConfirmTopicRuleDestinationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("confirmTopicRuleDestination:completionHandler:")]
		void ConfirmTopicRuleDestination (AWSIoTConfirmTopicRuleDestinationRequest request, [NullAllowed] Action<AWSIoTConfirmTopicRuleDestinationResponse, NSError> completionHandler);

		// -(id)createAuditSuppression:(AWSIoTCreateAuditSuppressionRequest * _Nonnull)request;
		[Export ("createAuditSuppression:")]
		NSObject CreateAuditSuppression (AWSIoTCreateAuditSuppressionRequest request);

		// -(void)createAuditSuppression:(AWSIoTCreateAuditSuppressionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateAuditSuppressionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createAuditSuppression:completionHandler:")]
		void CreateAuditSuppression (AWSIoTCreateAuditSuppressionRequest request, [NullAllowed] Action<AWSIoTCreateAuditSuppressionResponse, NSError> completionHandler);

		// -(id)createAuthorizer:(AWSIoTCreateAuthorizerRequest * _Nonnull)request;
		[Export ("createAuthorizer:")]
		NSObject CreateAuthorizer (AWSIoTCreateAuthorizerRequest request);

		// -(void)createAuthorizer:(AWSIoTCreateAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createAuthorizer:completionHandler:")]
		void CreateAuthorizer (AWSIoTCreateAuthorizerRequest request, [NullAllowed] Action<AWSIoTCreateAuthorizerResponse, NSError> completionHandler);

		// -(id)createBillingGroup:(AWSIoTCreateBillingGroupRequest * _Nonnull)request;
		[Export ("createBillingGroup:")]
		NSObject CreateBillingGroup (AWSIoTCreateBillingGroupRequest request);

		// -(void)createBillingGroup:(AWSIoTCreateBillingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateBillingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createBillingGroup:completionHandler:")]
		void CreateBillingGroup (AWSIoTCreateBillingGroupRequest request, [NullAllowed] Action<AWSIoTCreateBillingGroupResponse, NSError> completionHandler);

		// -(id)createCertificateFromCsr:(AWSIoTCreateCertificateFromCsrRequest * _Nonnull)request;
		[Export ("createCertificateFromCsr:")]
		NSObject CreateCertificateFromCsr (AWSIoTCreateCertificateFromCsrRequest request);

		// -(void)createCertificateFromCsr:(AWSIoTCreateCertificateFromCsrRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateCertificateFromCsrResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createCertificateFromCsr:completionHandler:")]
		void CreateCertificateFromCsr (AWSIoTCreateCertificateFromCsrRequest request, [NullAllowed] Action<AWSIoTCreateCertificateFromCsrResponse, NSError> completionHandler);

		// -(id)createCustomMetric:(AWSIoTCreateCustomMetricRequest * _Nonnull)request;
		[Export ("createCustomMetric:")]
		NSObject CreateCustomMetric (AWSIoTCreateCustomMetricRequest request);

		// -(void)createCustomMetric:(AWSIoTCreateCustomMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateCustomMetricResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createCustomMetric:completionHandler:")]
		void CreateCustomMetric (AWSIoTCreateCustomMetricRequest request, [NullAllowed] Action<AWSIoTCreateCustomMetricResponse, NSError> completionHandler);

		// -(id)createDimension:(AWSIoTCreateDimensionRequest * _Nonnull)request;
		[Export ("createDimension:")]
		NSObject CreateDimension (AWSIoTCreateDimensionRequest request);

		// -(void)createDimension:(AWSIoTCreateDimensionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateDimensionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createDimension:completionHandler:")]
		void CreateDimension (AWSIoTCreateDimensionRequest request, [NullAllowed] Action<AWSIoTCreateDimensionResponse, NSError> completionHandler);

		// -(id)createDomainConfiguration:(AWSIoTCreateDomainConfigurationRequest * _Nonnull)request;
		[Export ("createDomainConfiguration:")]
		NSObject CreateDomainConfiguration (AWSIoTCreateDomainConfigurationRequest request);

		// -(void)createDomainConfiguration:(AWSIoTCreateDomainConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateDomainConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createDomainConfiguration:completionHandler:")]
		void CreateDomainConfiguration (AWSIoTCreateDomainConfigurationRequest request, [NullAllowed] Action<AWSIoTCreateDomainConfigurationResponse, NSError> completionHandler);

		// -(id)createDynamicThingGroup:(AWSIoTCreateDynamicThingGroupRequest * _Nonnull)request;
		[Export ("createDynamicThingGroup:")]
		NSObject CreateDynamicThingGroup (AWSIoTCreateDynamicThingGroupRequest request);

		// -(void)createDynamicThingGroup:(AWSIoTCreateDynamicThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateDynamicThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createDynamicThingGroup:completionHandler:")]
		void CreateDynamicThingGroup (AWSIoTCreateDynamicThingGroupRequest request, [NullAllowed] Action<AWSIoTCreateDynamicThingGroupResponse, NSError> completionHandler);

		// -(id)createFleetMetric:(AWSIoTCreateFleetMetricRequest * _Nonnull)request;
		[Export ("createFleetMetric:")]
		NSObject CreateFleetMetric (AWSIoTCreateFleetMetricRequest request);

		// -(void)createFleetMetric:(AWSIoTCreateFleetMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateFleetMetricResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createFleetMetric:completionHandler:")]
		void CreateFleetMetric (AWSIoTCreateFleetMetricRequest request, [NullAllowed] Action<AWSIoTCreateFleetMetricResponse, NSError> completionHandler);

		// -(id)createJob:(AWSIoTCreateJobRequest * _Nonnull)request;
		[Export ("createJob:")]
		NSObject CreateJob (AWSIoTCreateJobRequest request);

		// -(void)createJob:(AWSIoTCreateJobRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateJobResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createJob:completionHandler:")]
		void CreateJob (AWSIoTCreateJobRequest request, [NullAllowed] Action<AWSIoTCreateJobResponse, NSError> completionHandler);

		// -(id)createJobTemplate:(AWSIoTCreateJobTemplateRequest * _Nonnull)request;
		[Export ("createJobTemplate:")]
		NSObject CreateJobTemplate (AWSIoTCreateJobTemplateRequest request);

		// -(void)createJobTemplate:(AWSIoTCreateJobTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateJobTemplateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createJobTemplate:completionHandler:")]
		void CreateJobTemplate (AWSIoTCreateJobTemplateRequest request, [NullAllowed] Action<AWSIoTCreateJobTemplateResponse, NSError> completionHandler);

		// -(id)createKeysAndCertificate:(AWSIoTCreateKeysAndCertificateRequest * _Nonnull)request;
		[Export ("createKeysAndCertificate:")]
		NSObject CreateKeysAndCertificate (AWSIoTCreateKeysAndCertificateRequest request);

		// -(void)createKeysAndCertificate:(AWSIoTCreateKeysAndCertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateKeysAndCertificateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createKeysAndCertificate:completionHandler:")]
		void CreateKeysAndCertificate (AWSIoTCreateKeysAndCertificateRequest request, [NullAllowed] Action<AWSIoTCreateKeysAndCertificateResponse, NSError> completionHandler);

		// -(id)createMitigationAction:(AWSIoTCreateMitigationActionRequest * _Nonnull)request;
		[Export ("createMitigationAction:")]
		NSObject CreateMitigationAction (AWSIoTCreateMitigationActionRequest request);

		// -(void)createMitigationAction:(AWSIoTCreateMitigationActionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateMitigationActionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createMitigationAction:completionHandler:")]
		void CreateMitigationAction (AWSIoTCreateMitigationActionRequest request, [NullAllowed] Action<AWSIoTCreateMitigationActionResponse, NSError> completionHandler);

		// -(id)createOTAUpdate:(AWSIoTCreateOTAUpdateRequest * _Nonnull)request;
		[Export ("createOTAUpdate:")]
		NSObject CreateOTAUpdate (AWSIoTCreateOTAUpdateRequest request);

		// -(void)createOTAUpdate:(AWSIoTCreateOTAUpdateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateOTAUpdateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createOTAUpdate:completionHandler:")]
		void CreateOTAUpdate (AWSIoTCreateOTAUpdateRequest request, [NullAllowed] Action<AWSIoTCreateOTAUpdateResponse, NSError> completionHandler);

		// -(id)createPolicy:(AWSIoTCreatePolicyRequest * _Nonnull)request;
		[Export ("createPolicy:")]
		NSObject CreatePolicy (AWSIoTCreatePolicyRequest request);

		// -(void)createPolicy:(AWSIoTCreatePolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreatePolicyResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createPolicy:completionHandler:")]
		void CreatePolicy (AWSIoTCreatePolicyRequest request, [NullAllowed] Action<AWSIoTCreatePolicyResponse, NSError> completionHandler);

		// -(id)createPolicyVersion:(AWSIoTCreatePolicyVersionRequest * _Nonnull)request;
		[Export ("createPolicyVersion:")]
		NSObject CreatePolicyVersion (AWSIoTCreatePolicyVersionRequest request);

		// -(void)createPolicyVersion:(AWSIoTCreatePolicyVersionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreatePolicyVersionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createPolicyVersion:completionHandler:")]
		void CreatePolicyVersion (AWSIoTCreatePolicyVersionRequest request, [NullAllowed] Action<AWSIoTCreatePolicyVersionResponse, NSError> completionHandler);

		// -(id)createProvisioningClaim:(AWSIoTCreateProvisioningClaimRequest * _Nonnull)request;
		[Export ("createProvisioningClaim:")]
		NSObject CreateProvisioningClaim (AWSIoTCreateProvisioningClaimRequest request);

		// -(void)createProvisioningClaim:(AWSIoTCreateProvisioningClaimRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateProvisioningClaimResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createProvisioningClaim:completionHandler:")]
		void CreateProvisioningClaim (AWSIoTCreateProvisioningClaimRequest request, [NullAllowed] Action<AWSIoTCreateProvisioningClaimResponse, NSError> completionHandler);

		// -(id)createProvisioningTemplate:(AWSIoTCreateProvisioningTemplateRequest * _Nonnull)request;
		[Export ("createProvisioningTemplate:")]
		NSObject CreateProvisioningTemplate (AWSIoTCreateProvisioningTemplateRequest request);

		// -(void)createProvisioningTemplate:(AWSIoTCreateProvisioningTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateProvisioningTemplateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createProvisioningTemplate:completionHandler:")]
		void CreateProvisioningTemplate (AWSIoTCreateProvisioningTemplateRequest request, [NullAllowed] Action<AWSIoTCreateProvisioningTemplateResponse, NSError> completionHandler);

		// -(id)createProvisioningTemplateVersion:(AWSIoTCreateProvisioningTemplateVersionRequest * _Nonnull)request;
		[Export ("createProvisioningTemplateVersion:")]
		NSObject CreateProvisioningTemplateVersion (AWSIoTCreateProvisioningTemplateVersionRequest request);

		// -(void)createProvisioningTemplateVersion:(AWSIoTCreateProvisioningTemplateVersionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateProvisioningTemplateVersionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createProvisioningTemplateVersion:completionHandler:")]
		void CreateProvisioningTemplateVersion (AWSIoTCreateProvisioningTemplateVersionRequest request, [NullAllowed] Action<AWSIoTCreateProvisioningTemplateVersionResponse, NSError> completionHandler);

		// -(id)createRoleAlias:(AWSIoTCreateRoleAliasRequest * _Nonnull)request;
		[Export ("createRoleAlias:")]
		NSObject CreateRoleAlias (AWSIoTCreateRoleAliasRequest request);

		// -(void)createRoleAlias:(AWSIoTCreateRoleAliasRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateRoleAliasResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createRoleAlias:completionHandler:")]
		void CreateRoleAlias (AWSIoTCreateRoleAliasRequest request, [NullAllowed] Action<AWSIoTCreateRoleAliasResponse, NSError> completionHandler);

		// -(id)createScheduledAudit:(AWSIoTCreateScheduledAuditRequest * _Nonnull)request;
		[Export ("createScheduledAudit:")]
		NSObject CreateScheduledAudit (AWSIoTCreateScheduledAuditRequest request);

		// -(void)createScheduledAudit:(AWSIoTCreateScheduledAuditRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateScheduledAuditResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createScheduledAudit:completionHandler:")]
		void CreateScheduledAudit (AWSIoTCreateScheduledAuditRequest request, [NullAllowed] Action<AWSIoTCreateScheduledAuditResponse, NSError> completionHandler);

		// -(id)createSecurityProfile:(AWSIoTCreateSecurityProfileRequest * _Nonnull)request;
		[Export ("createSecurityProfile:")]
		NSObject CreateSecurityProfile (AWSIoTCreateSecurityProfileRequest request);

		// -(void)createSecurityProfile:(AWSIoTCreateSecurityProfileRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateSecurityProfileResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createSecurityProfile:completionHandler:")]
		void CreateSecurityProfile (AWSIoTCreateSecurityProfileRequest request, [NullAllowed] Action<AWSIoTCreateSecurityProfileResponse, NSError> completionHandler);

		// -(id)createStream:(AWSIoTCreateStreamRequest * _Nonnull)request;
		[Export ("createStream:")]
		NSObject CreateStream (AWSIoTCreateStreamRequest request);

		// -(void)createStream:(AWSIoTCreateStreamRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateStreamResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createStream:completionHandler:")]
		void CreateStream (AWSIoTCreateStreamRequest request, [NullAllowed] Action<AWSIoTCreateStreamResponse, NSError> completionHandler);

		// -(id)createThing:(AWSIoTCreateThingRequest * _Nonnull)request;
		[Export ("createThing:")]
		NSObject CreateThing (AWSIoTCreateThingRequest request);

		// -(void)createThing:(AWSIoTCreateThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createThing:completionHandler:")]
		void CreateThing (AWSIoTCreateThingRequest request, [NullAllowed] Action<AWSIoTCreateThingResponse, NSError> completionHandler);

		// -(id)createThingGroup:(AWSIoTCreateThingGroupRequest * _Nonnull)request;
		[Export ("createThingGroup:")]
		NSObject CreateThingGroup (AWSIoTCreateThingGroupRequest request);

		// -(void)createThingGroup:(AWSIoTCreateThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createThingGroup:completionHandler:")]
		void CreateThingGroup (AWSIoTCreateThingGroupRequest request, [NullAllowed] Action<AWSIoTCreateThingGroupResponse, NSError> completionHandler);

		// -(id)createThingType:(AWSIoTCreateThingTypeRequest * _Nonnull)request;
		[Export ("createThingType:")]
		NSObject CreateThingType (AWSIoTCreateThingTypeRequest request);

		// -(void)createThingType:(AWSIoTCreateThingTypeRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateThingTypeResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createThingType:completionHandler:")]
		void CreateThingType (AWSIoTCreateThingTypeRequest request, [NullAllowed] Action<AWSIoTCreateThingTypeResponse, NSError> completionHandler);

		// -(id)createTopicRule:(AWSIoTCreateTopicRuleRequest * _Nonnull)request;
		[Export ("createTopicRule:")]
		NSObject CreateTopicRule (AWSIoTCreateTopicRuleRequest request);

		// -(void)createTopicRule:(AWSIoTCreateTopicRuleRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("createTopicRule:completionHandler:")]
		void CreateTopicRule (AWSIoTCreateTopicRuleRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)createTopicRuleDestination:(AWSIoTCreateTopicRuleDestinationRequest * _Nonnull)request;
		[Export ("createTopicRuleDestination:")]
		NSObject CreateTopicRuleDestination (AWSIoTCreateTopicRuleDestinationRequest request);

		// -(void)createTopicRuleDestination:(AWSIoTCreateTopicRuleDestinationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTCreateTopicRuleDestinationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("createTopicRuleDestination:completionHandler:")]
		void CreateTopicRuleDestination (AWSIoTCreateTopicRuleDestinationRequest request, [NullAllowed] Action<AWSIoTCreateTopicRuleDestinationResponse, NSError> completionHandler);

		// -(id)deleteAccountAuditConfiguration:(AWSIoTDeleteAccountAuditConfigurationRequest * _Nonnull)request;
		[Export ("deleteAccountAuditConfiguration:")]
		NSObject DeleteAccountAuditConfiguration (AWSIoTDeleteAccountAuditConfigurationRequest request);

		// -(void)deleteAccountAuditConfiguration:(AWSIoTDeleteAccountAuditConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteAccountAuditConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteAccountAuditConfiguration:completionHandler:")]
		void DeleteAccountAuditConfiguration (AWSIoTDeleteAccountAuditConfigurationRequest request, [NullAllowed] Action<AWSIoTDeleteAccountAuditConfigurationResponse, NSError> completionHandler);

		// -(id)deleteAuditSuppression:(AWSIoTDeleteAuditSuppressionRequest * _Nonnull)request;
		[Export ("deleteAuditSuppression:")]
		NSObject DeleteAuditSuppression (AWSIoTDeleteAuditSuppressionRequest request);

		// -(void)deleteAuditSuppression:(AWSIoTDeleteAuditSuppressionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteAuditSuppressionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteAuditSuppression:completionHandler:")]
		void DeleteAuditSuppression (AWSIoTDeleteAuditSuppressionRequest request, [NullAllowed] Action<AWSIoTDeleteAuditSuppressionResponse, NSError> completionHandler);

		// -(id)deleteAuthorizer:(AWSIoTDeleteAuthorizerRequest * _Nonnull)request;
		[Export ("deleteAuthorizer:")]
		NSObject DeleteAuthorizer (AWSIoTDeleteAuthorizerRequest request);

		// -(void)deleteAuthorizer:(AWSIoTDeleteAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteAuthorizer:completionHandler:")]
		void DeleteAuthorizer (AWSIoTDeleteAuthorizerRequest request, [NullAllowed] Action<AWSIoTDeleteAuthorizerResponse, NSError> completionHandler);

		// -(id)deleteBillingGroup:(AWSIoTDeleteBillingGroupRequest * _Nonnull)request;
		[Export ("deleteBillingGroup:")]
		NSObject DeleteBillingGroup (AWSIoTDeleteBillingGroupRequest request);

		// -(void)deleteBillingGroup:(AWSIoTDeleteBillingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteBillingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteBillingGroup:completionHandler:")]
		void DeleteBillingGroup (AWSIoTDeleteBillingGroupRequest request, [NullAllowed] Action<AWSIoTDeleteBillingGroupResponse, NSError> completionHandler);

		// -(id)deleteCACertificate:(AWSIoTDeleteCACertificateRequest * _Nonnull)request;
		[Export ("deleteCACertificate:")]
		NSObject DeleteCACertificate (AWSIoTDeleteCACertificateRequest request);

		// -(void)deleteCACertificate:(AWSIoTDeleteCACertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteCACertificateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteCACertificate:completionHandler:")]
		void DeleteCACertificate (AWSIoTDeleteCACertificateRequest request, [NullAllowed] Action<AWSIoTDeleteCACertificateResponse, NSError> completionHandler);

		// -(id)deleteCertificate:(AWSIoTDeleteCertificateRequest * _Nonnull)request;
		[Export ("deleteCertificate:")]
		NSObject DeleteCertificate (AWSIoTDeleteCertificateRequest request);

		// -(void)deleteCertificate:(AWSIoTDeleteCertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteCertificate:completionHandler:")]
		void DeleteCertificate (AWSIoTDeleteCertificateRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deleteCustomMetric:(AWSIoTDeleteCustomMetricRequest * _Nonnull)request;
		[Export ("deleteCustomMetric:")]
		NSObject DeleteCustomMetric (AWSIoTDeleteCustomMetricRequest request);

		// -(void)deleteCustomMetric:(AWSIoTDeleteCustomMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteCustomMetricResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteCustomMetric:completionHandler:")]
		void DeleteCustomMetric (AWSIoTDeleteCustomMetricRequest request, [NullAllowed] Action<AWSIoTDeleteCustomMetricResponse, NSError> completionHandler);

		// -(id)deleteDimension:(AWSIoTDeleteDimensionRequest * _Nonnull)request;
		[Export ("deleteDimension:")]
		NSObject DeleteDimension (AWSIoTDeleteDimensionRequest request);

		// -(void)deleteDimension:(AWSIoTDeleteDimensionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteDimensionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteDimension:completionHandler:")]
		void DeleteDimension (AWSIoTDeleteDimensionRequest request, [NullAllowed] Action<AWSIoTDeleteDimensionResponse, NSError> completionHandler);

		// -(id)deleteDomainConfiguration:(AWSIoTDeleteDomainConfigurationRequest * _Nonnull)request;
		[Export ("deleteDomainConfiguration:")]
		NSObject DeleteDomainConfiguration (AWSIoTDeleteDomainConfigurationRequest request);

		// -(void)deleteDomainConfiguration:(AWSIoTDeleteDomainConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteDomainConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteDomainConfiguration:completionHandler:")]
		void DeleteDomainConfiguration (AWSIoTDeleteDomainConfigurationRequest request, [NullAllowed] Action<AWSIoTDeleteDomainConfigurationResponse, NSError> completionHandler);

		// -(id)deleteDynamicThingGroup:(AWSIoTDeleteDynamicThingGroupRequest * _Nonnull)request;
		[Export ("deleteDynamicThingGroup:")]
		NSObject DeleteDynamicThingGroup (AWSIoTDeleteDynamicThingGroupRequest request);

		// -(void)deleteDynamicThingGroup:(AWSIoTDeleteDynamicThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteDynamicThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteDynamicThingGroup:completionHandler:")]
		void DeleteDynamicThingGroup (AWSIoTDeleteDynamicThingGroupRequest request, [NullAllowed] Action<AWSIoTDeleteDynamicThingGroupResponse, NSError> completionHandler);

		// -(id)deleteFleetMetric:(AWSIoTDeleteFleetMetricRequest * _Nonnull)request;
		[Export ("deleteFleetMetric:")]
		NSObject DeleteFleetMetric (AWSIoTDeleteFleetMetricRequest request);

		// -(void)deleteFleetMetric:(AWSIoTDeleteFleetMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteFleetMetric:completionHandler:")]
		void DeleteFleetMetric (AWSIoTDeleteFleetMetricRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deleteJob:(AWSIoTDeleteJobRequest * _Nonnull)request;
		[Export ("deleteJob:")]
		NSObject DeleteJob (AWSIoTDeleteJobRequest request);

		// -(void)deleteJob:(AWSIoTDeleteJobRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteJob:completionHandler:")]
		void DeleteJob (AWSIoTDeleteJobRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deleteJobExecution:(AWSIoTDeleteJobExecutionRequest * _Nonnull)request;
		[Export ("deleteJobExecution:")]
		NSObject DeleteJobExecution (AWSIoTDeleteJobExecutionRequest request);

		// -(void)deleteJobExecution:(AWSIoTDeleteJobExecutionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteJobExecution:completionHandler:")]
		void DeleteJobExecution (AWSIoTDeleteJobExecutionRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deleteJobTemplate:(AWSIoTDeleteJobTemplateRequest * _Nonnull)request;
		[Export ("deleteJobTemplate:")]
		NSObject DeleteJobTemplate (AWSIoTDeleteJobTemplateRequest request);

		// -(void)deleteJobTemplate:(AWSIoTDeleteJobTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteJobTemplate:completionHandler:")]
		void DeleteJobTemplate (AWSIoTDeleteJobTemplateRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deleteMitigationAction:(AWSIoTDeleteMitigationActionRequest * _Nonnull)request;
		[Export ("deleteMitigationAction:")]
		NSObject DeleteMitigationAction (AWSIoTDeleteMitigationActionRequest request);

		// -(void)deleteMitigationAction:(AWSIoTDeleteMitigationActionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteMitigationActionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteMitigationAction:completionHandler:")]
		void DeleteMitigationAction (AWSIoTDeleteMitigationActionRequest request, [NullAllowed] Action<AWSIoTDeleteMitigationActionResponse, NSError> completionHandler);

		// -(id)deleteOTAUpdate:(AWSIoTDeleteOTAUpdateRequest * _Nonnull)request;
		[Export ("deleteOTAUpdate:")]
		NSObject DeleteOTAUpdate (AWSIoTDeleteOTAUpdateRequest request);

		// -(void)deleteOTAUpdate:(AWSIoTDeleteOTAUpdateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteOTAUpdateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteOTAUpdate:completionHandler:")]
		void DeleteOTAUpdate (AWSIoTDeleteOTAUpdateRequest request, [NullAllowed] Action<AWSIoTDeleteOTAUpdateResponse, NSError> completionHandler);

		// -(id)deletePolicy:(AWSIoTDeletePolicyRequest * _Nonnull)request;
		[Export ("deletePolicy:")]
		NSObject DeletePolicy (AWSIoTDeletePolicyRequest request);

		// -(void)deletePolicy:(AWSIoTDeletePolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deletePolicy:completionHandler:")]
		void DeletePolicy (AWSIoTDeletePolicyRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deletePolicyVersion:(AWSIoTDeletePolicyVersionRequest * _Nonnull)request;
		[Export ("deletePolicyVersion:")]
		NSObject DeletePolicyVersion (AWSIoTDeletePolicyVersionRequest request);

		// -(void)deletePolicyVersion:(AWSIoTDeletePolicyVersionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deletePolicyVersion:completionHandler:")]
		void DeletePolicyVersion (AWSIoTDeletePolicyVersionRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deleteProvisioningTemplate:(AWSIoTDeleteProvisioningTemplateRequest * _Nonnull)request;
		[Export ("deleteProvisioningTemplate:")]
		NSObject DeleteProvisioningTemplate (AWSIoTDeleteProvisioningTemplateRequest request);

		// -(void)deleteProvisioningTemplate:(AWSIoTDeleteProvisioningTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteProvisioningTemplateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteProvisioningTemplate:completionHandler:")]
		void DeleteProvisioningTemplate (AWSIoTDeleteProvisioningTemplateRequest request, [NullAllowed] Action<AWSIoTDeleteProvisioningTemplateResponse, NSError> completionHandler);

		// -(id)deleteProvisioningTemplateVersion:(AWSIoTDeleteProvisioningTemplateVersionRequest * _Nonnull)request;
		[Export ("deleteProvisioningTemplateVersion:")]
		NSObject DeleteProvisioningTemplateVersion (AWSIoTDeleteProvisioningTemplateVersionRequest request);

		// -(void)deleteProvisioningTemplateVersion:(AWSIoTDeleteProvisioningTemplateVersionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteProvisioningTemplateVersionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteProvisioningTemplateVersion:completionHandler:")]
		void DeleteProvisioningTemplateVersion (AWSIoTDeleteProvisioningTemplateVersionRequest request, [NullAllowed] Action<AWSIoTDeleteProvisioningTemplateVersionResponse, NSError> completionHandler);

		// -(id)deleteRegistrationCode:(AWSIoTDeleteRegistrationCodeRequest * _Nonnull)request;
		[Export ("deleteRegistrationCode:")]
		NSObject DeleteRegistrationCode (AWSIoTDeleteRegistrationCodeRequest request);

		// -(void)deleteRegistrationCode:(AWSIoTDeleteRegistrationCodeRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteRegistrationCodeResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteRegistrationCode:completionHandler:")]
		void DeleteRegistrationCode (AWSIoTDeleteRegistrationCodeRequest request, [NullAllowed] Action<AWSIoTDeleteRegistrationCodeResponse, NSError> completionHandler);

		// -(id)deleteRoleAlias:(AWSIoTDeleteRoleAliasRequest * _Nonnull)request;
		[Export ("deleteRoleAlias:")]
		NSObject DeleteRoleAlias (AWSIoTDeleteRoleAliasRequest request);

		// -(void)deleteRoleAlias:(AWSIoTDeleteRoleAliasRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteRoleAliasResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteRoleAlias:completionHandler:")]
		void DeleteRoleAlias (AWSIoTDeleteRoleAliasRequest request, [NullAllowed] Action<AWSIoTDeleteRoleAliasResponse, NSError> completionHandler);

		// -(id)deleteScheduledAudit:(AWSIoTDeleteScheduledAuditRequest * _Nonnull)request;
		[Export ("deleteScheduledAudit:")]
		NSObject DeleteScheduledAudit (AWSIoTDeleteScheduledAuditRequest request);

		// -(void)deleteScheduledAudit:(AWSIoTDeleteScheduledAuditRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteScheduledAuditResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteScheduledAudit:completionHandler:")]
		void DeleteScheduledAudit (AWSIoTDeleteScheduledAuditRequest request, [NullAllowed] Action<AWSIoTDeleteScheduledAuditResponse, NSError> completionHandler);

		// -(id)deleteSecurityProfile:(AWSIoTDeleteSecurityProfileRequest * _Nonnull)request;
		[Export ("deleteSecurityProfile:")]
		NSObject DeleteSecurityProfile (AWSIoTDeleteSecurityProfileRequest request);

		// -(void)deleteSecurityProfile:(AWSIoTDeleteSecurityProfileRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteSecurityProfileResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteSecurityProfile:completionHandler:")]
		void DeleteSecurityProfile (AWSIoTDeleteSecurityProfileRequest request, [NullAllowed] Action<AWSIoTDeleteSecurityProfileResponse, NSError> completionHandler);

		// -(id)deleteStream:(AWSIoTDeleteStreamRequest * _Nonnull)request;
		[Export ("deleteStream:")]
		NSObject DeleteStream (AWSIoTDeleteStreamRequest request);

		// -(void)deleteStream:(AWSIoTDeleteStreamRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteStreamResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteStream:completionHandler:")]
		void DeleteStream (AWSIoTDeleteStreamRequest request, [NullAllowed] Action<AWSIoTDeleteStreamResponse, NSError> completionHandler);

		// -(id)deleteThing:(AWSIoTDeleteThingRequest * _Nonnull)request;
		[Export ("deleteThing:")]
		NSObject DeleteThing (AWSIoTDeleteThingRequest request);

		// -(void)deleteThing:(AWSIoTDeleteThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteThing:completionHandler:")]
		void DeleteThing (AWSIoTDeleteThingRequest request, [NullAllowed] Action<AWSIoTDeleteThingResponse, NSError> completionHandler);

		// -(id)deleteThingGroup:(AWSIoTDeleteThingGroupRequest * _Nonnull)request;
		[Export ("deleteThingGroup:")]
		NSObject DeleteThingGroup (AWSIoTDeleteThingGroupRequest request);

		// -(void)deleteThingGroup:(AWSIoTDeleteThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteThingGroup:completionHandler:")]
		void DeleteThingGroup (AWSIoTDeleteThingGroupRequest request, [NullAllowed] Action<AWSIoTDeleteThingGroupResponse, NSError> completionHandler);

		// -(id)deleteThingType:(AWSIoTDeleteThingTypeRequest * _Nonnull)request;
		[Export ("deleteThingType:")]
		NSObject DeleteThingType (AWSIoTDeleteThingTypeRequest request);

		// -(void)deleteThingType:(AWSIoTDeleteThingTypeRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteThingTypeResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteThingType:completionHandler:")]
		void DeleteThingType (AWSIoTDeleteThingTypeRequest request, [NullAllowed] Action<AWSIoTDeleteThingTypeResponse, NSError> completionHandler);

		// -(id)deleteTopicRule:(AWSIoTDeleteTopicRuleRequest * _Nonnull)request;
		[Export ("deleteTopicRule:")]
		NSObject DeleteTopicRule (AWSIoTDeleteTopicRuleRequest request);

		// -(void)deleteTopicRule:(AWSIoTDeleteTopicRuleRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteTopicRule:completionHandler:")]
		void DeleteTopicRule (AWSIoTDeleteTopicRuleRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deleteTopicRuleDestination:(AWSIoTDeleteTopicRuleDestinationRequest * _Nonnull)request;
		[Export ("deleteTopicRuleDestination:")]
		NSObject DeleteTopicRuleDestination (AWSIoTDeleteTopicRuleDestinationRequest request);

		// -(void)deleteTopicRuleDestination:(AWSIoTDeleteTopicRuleDestinationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeleteTopicRuleDestinationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteTopicRuleDestination:completionHandler:")]
		void DeleteTopicRuleDestination (AWSIoTDeleteTopicRuleDestinationRequest request, [NullAllowed] Action<AWSIoTDeleteTopicRuleDestinationResponse, NSError> completionHandler);

		// -(id)deleteV2LoggingLevel:(AWSIoTDeleteV2LoggingLevelRequest * _Nonnull)request;
		[Export ("deleteV2LoggingLevel:")]
		NSObject DeleteV2LoggingLevel (AWSIoTDeleteV2LoggingLevelRequest request);

		// -(void)deleteV2LoggingLevel:(AWSIoTDeleteV2LoggingLevelRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("deleteV2LoggingLevel:completionHandler:")]
		void DeleteV2LoggingLevel (AWSIoTDeleteV2LoggingLevelRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)deprecateThingType:(AWSIoTDeprecateThingTypeRequest * _Nonnull)request;
		[Export ("deprecateThingType:")]
		NSObject DeprecateThingType (AWSIoTDeprecateThingTypeRequest request);

		// -(void)deprecateThingType:(AWSIoTDeprecateThingTypeRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDeprecateThingTypeResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deprecateThingType:completionHandler:")]
		void DeprecateThingType (AWSIoTDeprecateThingTypeRequest request, [NullAllowed] Action<AWSIoTDeprecateThingTypeResponse, NSError> completionHandler);

		// -(id)describeAccountAuditConfiguration:(AWSIoTDescribeAccountAuditConfigurationRequest * _Nonnull)request;
		[Export ("describeAccountAuditConfiguration:")]
		NSObject DescribeAccountAuditConfiguration (AWSIoTDescribeAccountAuditConfigurationRequest request);

		// -(void)describeAccountAuditConfiguration:(AWSIoTDescribeAccountAuditConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeAccountAuditConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeAccountAuditConfiguration:completionHandler:")]
		void DescribeAccountAuditConfiguration (AWSIoTDescribeAccountAuditConfigurationRequest request, [NullAllowed] Action<AWSIoTDescribeAccountAuditConfigurationResponse, NSError> completionHandler);

		// -(id)describeAuditFinding:(AWSIoTDescribeAuditFindingRequest * _Nonnull)request;
		[Export ("describeAuditFinding:")]
		NSObject DescribeAuditFinding (AWSIoTDescribeAuditFindingRequest request);

		// -(void)describeAuditFinding:(AWSIoTDescribeAuditFindingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeAuditFindingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeAuditFinding:completionHandler:")]
		void DescribeAuditFinding (AWSIoTDescribeAuditFindingRequest request, [NullAllowed] Action<AWSIoTDescribeAuditFindingResponse, NSError> completionHandler);

		// -(id)describeAuditMitigationActionsTask:(AWSIoTDescribeAuditMitigationActionsTaskRequest * _Nonnull)request;
		[Export ("describeAuditMitigationActionsTask:")]
		NSObject DescribeAuditMitigationActionsTask (AWSIoTDescribeAuditMitigationActionsTaskRequest request);

		// -(void)describeAuditMitigationActionsTask:(AWSIoTDescribeAuditMitigationActionsTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeAuditMitigationActionsTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeAuditMitigationActionsTask:completionHandler:")]
		void DescribeAuditMitigationActionsTask (AWSIoTDescribeAuditMitigationActionsTaskRequest request, [NullAllowed] Action<AWSIoTDescribeAuditMitigationActionsTaskResponse, NSError> completionHandler);

		// -(id)describeAuditSuppression:(AWSIoTDescribeAuditSuppressionRequest * _Nonnull)request;
		[Export ("describeAuditSuppression:")]
		NSObject DescribeAuditSuppression (AWSIoTDescribeAuditSuppressionRequest request);

		// -(void)describeAuditSuppression:(AWSIoTDescribeAuditSuppressionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeAuditSuppressionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeAuditSuppression:completionHandler:")]
		void DescribeAuditSuppression (AWSIoTDescribeAuditSuppressionRequest request, [NullAllowed] Action<AWSIoTDescribeAuditSuppressionResponse, NSError> completionHandler);

		// -(id)describeAuditTask:(AWSIoTDescribeAuditTaskRequest * _Nonnull)request;
		[Export ("describeAuditTask:")]
		NSObject DescribeAuditTask (AWSIoTDescribeAuditTaskRequest request);

		// -(void)describeAuditTask:(AWSIoTDescribeAuditTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeAuditTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeAuditTask:completionHandler:")]
		void DescribeAuditTask (AWSIoTDescribeAuditTaskRequest request, [NullAllowed] Action<AWSIoTDescribeAuditTaskResponse, NSError> completionHandler);

		// -(id)describeAuthorizer:(AWSIoTDescribeAuthorizerRequest * _Nonnull)request;
		[Export ("describeAuthorizer:")]
		NSObject DescribeAuthorizer (AWSIoTDescribeAuthorizerRequest request);

		// -(void)describeAuthorizer:(AWSIoTDescribeAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeAuthorizer:completionHandler:")]
		void DescribeAuthorizer (AWSIoTDescribeAuthorizerRequest request, [NullAllowed] Action<AWSIoTDescribeAuthorizerResponse, NSError> completionHandler);

		// -(id)describeBillingGroup:(AWSIoTDescribeBillingGroupRequest * _Nonnull)request;
		[Export ("describeBillingGroup:")]
		NSObject DescribeBillingGroup (AWSIoTDescribeBillingGroupRequest request);

		// -(void)describeBillingGroup:(AWSIoTDescribeBillingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeBillingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeBillingGroup:completionHandler:")]
		void DescribeBillingGroup (AWSIoTDescribeBillingGroupRequest request, [NullAllowed] Action<AWSIoTDescribeBillingGroupResponse, NSError> completionHandler);

		// -(id)describeCACertificate:(AWSIoTDescribeCACertificateRequest * _Nonnull)request;
		[Export ("describeCACertificate:")]
		NSObject DescribeCACertificate (AWSIoTDescribeCACertificateRequest request);

		// -(void)describeCACertificate:(AWSIoTDescribeCACertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeCACertificateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeCACertificate:completionHandler:")]
		void DescribeCACertificate (AWSIoTDescribeCACertificateRequest request, [NullAllowed] Action<AWSIoTDescribeCACertificateResponse, NSError> completionHandler);

		// -(id)describeCertificate:(AWSIoTDescribeCertificateRequest * _Nonnull)request;
		[Export ("describeCertificate:")]
		NSObject DescribeCertificate (AWSIoTDescribeCertificateRequest request);

		// -(void)describeCertificate:(AWSIoTDescribeCertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeCertificateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeCertificate:completionHandler:")]
		void DescribeCertificate (AWSIoTDescribeCertificateRequest request, [NullAllowed] Action<AWSIoTDescribeCertificateResponse, NSError> completionHandler);

		// -(id)describeCustomMetric:(AWSIoTDescribeCustomMetricRequest * _Nonnull)request;
		[Export ("describeCustomMetric:")]
		NSObject DescribeCustomMetric (AWSIoTDescribeCustomMetricRequest request);

		// -(void)describeCustomMetric:(AWSIoTDescribeCustomMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeCustomMetricResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeCustomMetric:completionHandler:")]
		void DescribeCustomMetric (AWSIoTDescribeCustomMetricRequest request, [NullAllowed] Action<AWSIoTDescribeCustomMetricResponse, NSError> completionHandler);

		// -(id)describeDefaultAuthorizer:(AWSIoTDescribeDefaultAuthorizerRequest * _Nonnull)request;
		[Export ("describeDefaultAuthorizer:")]
		NSObject DescribeDefaultAuthorizer (AWSIoTDescribeDefaultAuthorizerRequest request);

		// -(void)describeDefaultAuthorizer:(AWSIoTDescribeDefaultAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeDefaultAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeDefaultAuthorizer:completionHandler:")]
		void DescribeDefaultAuthorizer (AWSIoTDescribeDefaultAuthorizerRequest request, [NullAllowed] Action<AWSIoTDescribeDefaultAuthorizerResponse, NSError> completionHandler);

		// -(id)describeDetectMitigationActionsTask:(AWSIoTDescribeDetectMitigationActionsTaskRequest * _Nonnull)request;
		[Export ("describeDetectMitigationActionsTask:")]
		NSObject DescribeDetectMitigationActionsTask (AWSIoTDescribeDetectMitigationActionsTaskRequest request);

		// -(void)describeDetectMitigationActionsTask:(AWSIoTDescribeDetectMitigationActionsTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeDetectMitigationActionsTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeDetectMitigationActionsTask:completionHandler:")]
		void DescribeDetectMitigationActionsTask (AWSIoTDescribeDetectMitigationActionsTaskRequest request, [NullAllowed] Action<AWSIoTDescribeDetectMitigationActionsTaskResponse, NSError> completionHandler);

		// -(id)describeDimension:(AWSIoTDescribeDimensionRequest * _Nonnull)request;
		[Export ("describeDimension:")]
		NSObject DescribeDimension (AWSIoTDescribeDimensionRequest request);

		// -(void)describeDimension:(AWSIoTDescribeDimensionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeDimensionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeDimension:completionHandler:")]
		void DescribeDimension (AWSIoTDescribeDimensionRequest request, [NullAllowed] Action<AWSIoTDescribeDimensionResponse, NSError> completionHandler);

		// -(id)describeDomainConfiguration:(AWSIoTDescribeDomainConfigurationRequest * _Nonnull)request;
		[Export ("describeDomainConfiguration:")]
		NSObject DescribeDomainConfiguration (AWSIoTDescribeDomainConfigurationRequest request);

		// -(void)describeDomainConfiguration:(AWSIoTDescribeDomainConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeDomainConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeDomainConfiguration:completionHandler:")]
		void DescribeDomainConfiguration (AWSIoTDescribeDomainConfigurationRequest request, [NullAllowed] Action<AWSIoTDescribeDomainConfigurationResponse, NSError> completionHandler);

		// -(id)describeEndpoint:(AWSIoTDescribeEndpointRequest * _Nonnull)request;
		[Export ("describeEndpoint:")]
		NSObject DescribeEndpoint (AWSIoTDescribeEndpointRequest request);

		// -(void)describeEndpoint:(AWSIoTDescribeEndpointRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeEndpointResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeEndpoint:completionHandler:")]
		void DescribeEndpoint (AWSIoTDescribeEndpointRequest request, [NullAllowed] Action<AWSIoTDescribeEndpointResponse, NSError> completionHandler);

		// -(id)describeEventConfigurations:(AWSIoTDescribeEventConfigurationsRequest * _Nonnull)request;
		[Export ("describeEventConfigurations:")]
		NSObject DescribeEventConfigurations (AWSIoTDescribeEventConfigurationsRequest request);

		// -(void)describeEventConfigurations:(AWSIoTDescribeEventConfigurationsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeEventConfigurationsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeEventConfigurations:completionHandler:")]
		void DescribeEventConfigurations (AWSIoTDescribeEventConfigurationsRequest request, [NullAllowed] Action<AWSIoTDescribeEventConfigurationsResponse, NSError> completionHandler);

		// -(id)describeFleetMetric:(AWSIoTDescribeFleetMetricRequest * _Nonnull)request;
		[Export ("describeFleetMetric:")]
		NSObject DescribeFleetMetric (AWSIoTDescribeFleetMetricRequest request);

		// -(void)describeFleetMetric:(AWSIoTDescribeFleetMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeFleetMetricResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeFleetMetric:completionHandler:")]
		void DescribeFleetMetric (AWSIoTDescribeFleetMetricRequest request, [NullAllowed] Action<AWSIoTDescribeFleetMetricResponse, NSError> completionHandler);

		// -(id)describeIndex:(AWSIoTDescribeIndexRequest * _Nonnull)request;
		[Export ("describeIndex:")]
		NSObject DescribeIndex (AWSIoTDescribeIndexRequest request);

		// -(void)describeIndex:(AWSIoTDescribeIndexRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeIndexResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeIndex:completionHandler:")]
		void DescribeIndex (AWSIoTDescribeIndexRequest request, [NullAllowed] Action<AWSIoTDescribeIndexResponse, NSError> completionHandler);

		// -(id)describeJob:(AWSIoTDescribeJobRequest * _Nonnull)request;
		[Export ("describeJob:")]
		NSObject DescribeJob (AWSIoTDescribeJobRequest request);

		// -(void)describeJob:(AWSIoTDescribeJobRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeJobResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeJob:completionHandler:")]
		void DescribeJob (AWSIoTDescribeJobRequest request, [NullAllowed] Action<AWSIoTDescribeJobResponse, NSError> completionHandler);

		// -(id)describeJobExecution:(AWSIoTDescribeJobExecutionRequest * _Nonnull)request;
		[Export ("describeJobExecution:")]
		NSObject DescribeJobExecution (AWSIoTDescribeJobExecutionRequest request);

		// -(void)describeJobExecution:(AWSIoTDescribeJobExecutionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeJobExecutionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeJobExecution:completionHandler:")]
		void DescribeJobExecution (AWSIoTDescribeJobExecutionRequest request, [NullAllowed] Action<AWSIoTDescribeJobExecutionResponse, NSError> completionHandler);

		// -(id)describeJobTemplate:(AWSIoTDescribeJobTemplateRequest * _Nonnull)request;
		[Export ("describeJobTemplate:")]
		NSObject DescribeJobTemplate (AWSIoTDescribeJobTemplateRequest request);

		// -(void)describeJobTemplate:(AWSIoTDescribeJobTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeJobTemplateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeJobTemplate:completionHandler:")]
		void DescribeJobTemplate (AWSIoTDescribeJobTemplateRequest request, [NullAllowed] Action<AWSIoTDescribeJobTemplateResponse, NSError> completionHandler);

		// -(id)describeManagedJobTemplate:(AWSIoTDescribeManagedJobTemplateRequest * _Nonnull)request;
		[Export ("describeManagedJobTemplate:")]
		NSObject DescribeManagedJobTemplate (AWSIoTDescribeManagedJobTemplateRequest request);

		// -(void)describeManagedJobTemplate:(AWSIoTDescribeManagedJobTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeManagedJobTemplateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeManagedJobTemplate:completionHandler:")]
		void DescribeManagedJobTemplate (AWSIoTDescribeManagedJobTemplateRequest request, [NullAllowed] Action<AWSIoTDescribeManagedJobTemplateResponse, NSError> completionHandler);

		// -(id)describeMitigationAction:(AWSIoTDescribeMitigationActionRequest * _Nonnull)request;
		[Export ("describeMitigationAction:")]
		NSObject DescribeMitigationAction (AWSIoTDescribeMitigationActionRequest request);

		// -(void)describeMitigationAction:(AWSIoTDescribeMitigationActionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeMitigationActionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeMitigationAction:completionHandler:")]
		void DescribeMitigationAction (AWSIoTDescribeMitigationActionRequest request, [NullAllowed] Action<AWSIoTDescribeMitigationActionResponse, NSError> completionHandler);

		// -(id)describeProvisioningTemplate:(AWSIoTDescribeProvisioningTemplateRequest * _Nonnull)request;
		[Export ("describeProvisioningTemplate:")]
		NSObject DescribeProvisioningTemplate (AWSIoTDescribeProvisioningTemplateRequest request);

		// -(void)describeProvisioningTemplate:(AWSIoTDescribeProvisioningTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeProvisioningTemplateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeProvisioningTemplate:completionHandler:")]
		void DescribeProvisioningTemplate (AWSIoTDescribeProvisioningTemplateRequest request, [NullAllowed] Action<AWSIoTDescribeProvisioningTemplateResponse, NSError> completionHandler);

		// -(id)describeProvisioningTemplateVersion:(AWSIoTDescribeProvisioningTemplateVersionRequest * _Nonnull)request;
		[Export ("describeProvisioningTemplateVersion:")]
		NSObject DescribeProvisioningTemplateVersion (AWSIoTDescribeProvisioningTemplateVersionRequest request);

		// -(void)describeProvisioningTemplateVersion:(AWSIoTDescribeProvisioningTemplateVersionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeProvisioningTemplateVersionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeProvisioningTemplateVersion:completionHandler:")]
		void DescribeProvisioningTemplateVersion (AWSIoTDescribeProvisioningTemplateVersionRequest request, [NullAllowed] Action<AWSIoTDescribeProvisioningTemplateVersionResponse, NSError> completionHandler);

		// -(id)describeRoleAlias:(AWSIoTDescribeRoleAliasRequest * _Nonnull)request;
		[Export ("describeRoleAlias:")]
		NSObject DescribeRoleAlias (AWSIoTDescribeRoleAliasRequest request);

		// -(void)describeRoleAlias:(AWSIoTDescribeRoleAliasRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeRoleAliasResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeRoleAlias:completionHandler:")]
		void DescribeRoleAlias (AWSIoTDescribeRoleAliasRequest request, [NullAllowed] Action<AWSIoTDescribeRoleAliasResponse, NSError> completionHandler);

		// -(id)describeScheduledAudit:(AWSIoTDescribeScheduledAuditRequest * _Nonnull)request;
		[Export ("describeScheduledAudit:")]
		NSObject DescribeScheduledAudit (AWSIoTDescribeScheduledAuditRequest request);

		// -(void)describeScheduledAudit:(AWSIoTDescribeScheduledAuditRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeScheduledAuditResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeScheduledAudit:completionHandler:")]
		void DescribeScheduledAudit (AWSIoTDescribeScheduledAuditRequest request, [NullAllowed] Action<AWSIoTDescribeScheduledAuditResponse, NSError> completionHandler);

		// -(id)describeSecurityProfile:(AWSIoTDescribeSecurityProfileRequest * _Nonnull)request;
		[Export ("describeSecurityProfile:")]
		NSObject DescribeSecurityProfile (AWSIoTDescribeSecurityProfileRequest request);

		// -(void)describeSecurityProfile:(AWSIoTDescribeSecurityProfileRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeSecurityProfileResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeSecurityProfile:completionHandler:")]
		void DescribeSecurityProfile (AWSIoTDescribeSecurityProfileRequest request, [NullAllowed] Action<AWSIoTDescribeSecurityProfileResponse, NSError> completionHandler);

		// -(id)describeStream:(AWSIoTDescribeStreamRequest * _Nonnull)request;
		[Export ("describeStream:")]
		NSObject DescribeStream (AWSIoTDescribeStreamRequest request);

		// -(void)describeStream:(AWSIoTDescribeStreamRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeStreamResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeStream:completionHandler:")]
		void DescribeStream (AWSIoTDescribeStreamRequest request, [NullAllowed] Action<AWSIoTDescribeStreamResponse, NSError> completionHandler);

		// -(id)describeThing:(AWSIoTDescribeThingRequest * _Nonnull)request;
		[Export ("describeThing:")]
		NSObject DescribeThing (AWSIoTDescribeThingRequest request);

		// -(void)describeThing:(AWSIoTDescribeThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeThing:completionHandler:")]
		void DescribeThing (AWSIoTDescribeThingRequest request, [NullAllowed] Action<AWSIoTDescribeThingResponse, NSError> completionHandler);

		// -(id)describeThingGroup:(AWSIoTDescribeThingGroupRequest * _Nonnull)request;
		[Export ("describeThingGroup:")]
		NSObject DescribeThingGroup (AWSIoTDescribeThingGroupRequest request);

		// -(void)describeThingGroup:(AWSIoTDescribeThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeThingGroup:completionHandler:")]
		void DescribeThingGroup (AWSIoTDescribeThingGroupRequest request, [NullAllowed] Action<AWSIoTDescribeThingGroupResponse, NSError> completionHandler);

		// -(id)describeThingRegistrationTask:(AWSIoTDescribeThingRegistrationTaskRequest * _Nonnull)request;
		[Export ("describeThingRegistrationTask:")]
		NSObject DescribeThingRegistrationTask (AWSIoTDescribeThingRegistrationTaskRequest request);

		// -(void)describeThingRegistrationTask:(AWSIoTDescribeThingRegistrationTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeThingRegistrationTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeThingRegistrationTask:completionHandler:")]
		void DescribeThingRegistrationTask (AWSIoTDescribeThingRegistrationTaskRequest request, [NullAllowed] Action<AWSIoTDescribeThingRegistrationTaskResponse, NSError> completionHandler);

		// -(id)describeThingType:(AWSIoTDescribeThingTypeRequest * _Nonnull)request;
		[Export ("describeThingType:")]
		NSObject DescribeThingType (AWSIoTDescribeThingTypeRequest request);

		// -(void)describeThingType:(AWSIoTDescribeThingTypeRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDescribeThingTypeResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("describeThingType:completionHandler:")]
		void DescribeThingType (AWSIoTDescribeThingTypeRequest request, [NullAllowed] Action<AWSIoTDescribeThingTypeResponse, NSError> completionHandler);

		// -(id)detachPolicy:(AWSIoTDetachPolicyRequest * _Nonnull)request;
		[Export ("detachPolicy:")]
		NSObject DetachPolicy (AWSIoTDetachPolicyRequest request);

		// -(void)detachPolicy:(AWSIoTDetachPolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("detachPolicy:completionHandler:")]
		void DetachPolicy (AWSIoTDetachPolicyRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)detachPrincipalPolicy:(AWSIoTDetachPrincipalPolicyRequest * _Nonnull)request;
		[Export ("detachPrincipalPolicy:")]
		NSObject DetachPrincipalPolicy (AWSIoTDetachPrincipalPolicyRequest request);

		// -(void)detachPrincipalPolicy:(AWSIoTDetachPrincipalPolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("detachPrincipalPolicy:completionHandler:")]
		void DetachPrincipalPolicy (AWSIoTDetachPrincipalPolicyRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)detachSecurityProfile:(AWSIoTDetachSecurityProfileRequest * _Nonnull)request;
		[Export ("detachSecurityProfile:")]
		NSObject DetachSecurityProfile (AWSIoTDetachSecurityProfileRequest request);

		// -(void)detachSecurityProfile:(AWSIoTDetachSecurityProfileRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDetachSecurityProfileResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("detachSecurityProfile:completionHandler:")]
		void DetachSecurityProfile (AWSIoTDetachSecurityProfileRequest request, [NullAllowed] Action<AWSIoTDetachSecurityProfileResponse, NSError> completionHandler);

		// -(id)detachThingPrincipal:(AWSIoTDetachThingPrincipalRequest * _Nonnull)request;
		[Export ("detachThingPrincipal:")]
		NSObject DetachThingPrincipal (AWSIoTDetachThingPrincipalRequest request);

		// -(void)detachThingPrincipal:(AWSIoTDetachThingPrincipalRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDetachThingPrincipalResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("detachThingPrincipal:completionHandler:")]
		void DetachThingPrincipal (AWSIoTDetachThingPrincipalRequest request, [NullAllowed] Action<AWSIoTDetachThingPrincipalResponse, NSError> completionHandler);

		// -(id)disableTopicRule:(AWSIoTDisableTopicRuleRequest * _Nonnull)request;
		[Export ("disableTopicRule:")]
		NSObject DisableTopicRule (AWSIoTDisableTopicRuleRequest request);

		// -(void)disableTopicRule:(AWSIoTDisableTopicRuleRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("disableTopicRule:completionHandler:")]
		void DisableTopicRule (AWSIoTDisableTopicRuleRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)enableTopicRule:(AWSIoTEnableTopicRuleRequest * _Nonnull)request;
		[Export ("enableTopicRule:")]
		NSObject EnableTopicRule (AWSIoTEnableTopicRuleRequest request);

		// -(void)enableTopicRule:(AWSIoTEnableTopicRuleRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("enableTopicRule:completionHandler:")]
		void EnableTopicRule (AWSIoTEnableTopicRuleRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)getBehaviorModelTrainingSummaries:(AWSIoTGetBehaviorModelTrainingSummariesRequest * _Nonnull)request;
		[Export ("getBehaviorModelTrainingSummaries:")]
		NSObject GetBehaviorModelTrainingSummaries (AWSIoTGetBehaviorModelTrainingSummariesRequest request);

		// -(void)getBehaviorModelTrainingSummaries:(AWSIoTGetBehaviorModelTrainingSummariesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetBehaviorModelTrainingSummariesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getBehaviorModelTrainingSummaries:completionHandler:")]
		void GetBehaviorModelTrainingSummaries (AWSIoTGetBehaviorModelTrainingSummariesRequest request, [NullAllowed] Action<AWSIoTGetBehaviorModelTrainingSummariesResponse, NSError> completionHandler);

		// -(id)getBucketsAggregation:(AWSIoTGetBucketsAggregationRequest * _Nonnull)request;
		[Export ("getBucketsAggregation:")]
		NSObject GetBucketsAggregation (AWSIoTGetBucketsAggregationRequest request);

		// -(void)getBucketsAggregation:(AWSIoTGetBucketsAggregationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetBucketsAggregationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getBucketsAggregation:completionHandler:")]
		void GetBucketsAggregation (AWSIoTGetBucketsAggregationRequest request, [NullAllowed] Action<AWSIoTGetBucketsAggregationResponse, NSError> completionHandler);

		// -(id)getCardinality:(AWSIoTGetCardinalityRequest * _Nonnull)request;
		[Export ("getCardinality:")]
		NSObject GetCardinality (AWSIoTGetCardinalityRequest request);

		// -(void)getCardinality:(AWSIoTGetCardinalityRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetCardinalityResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getCardinality:completionHandler:")]
		void GetCardinality (AWSIoTGetCardinalityRequest request, [NullAllowed] Action<AWSIoTGetCardinalityResponse, NSError> completionHandler);

		// -(id)getEffectivePolicies:(AWSIoTGetEffectivePoliciesRequest * _Nonnull)request;
		[Export ("getEffectivePolicies:")]
		NSObject GetEffectivePolicies (AWSIoTGetEffectivePoliciesRequest request);

		// -(void)getEffectivePolicies:(AWSIoTGetEffectivePoliciesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetEffectivePoliciesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getEffectivePolicies:completionHandler:")]
		void GetEffectivePolicies (AWSIoTGetEffectivePoliciesRequest request, [NullAllowed] Action<AWSIoTGetEffectivePoliciesResponse, NSError> completionHandler);

		// -(id)getIndexingConfiguration:(AWSIoTGetIndexingConfigurationRequest * _Nonnull)request;
		[Export ("getIndexingConfiguration:")]
		NSObject GetIndexingConfiguration (AWSIoTGetIndexingConfigurationRequest request);

		// -(void)getIndexingConfiguration:(AWSIoTGetIndexingConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetIndexingConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getIndexingConfiguration:completionHandler:")]
		void GetIndexingConfiguration (AWSIoTGetIndexingConfigurationRequest request, [NullAllowed] Action<AWSIoTGetIndexingConfigurationResponse, NSError> completionHandler);

		// -(id)getJobDocument:(AWSIoTGetJobDocumentRequest * _Nonnull)request;
		[Export ("getJobDocument:")]
		NSObject GetJobDocument (AWSIoTGetJobDocumentRequest request);

		// -(void)getJobDocument:(AWSIoTGetJobDocumentRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetJobDocumentResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getJobDocument:completionHandler:")]
		void GetJobDocument (AWSIoTGetJobDocumentRequest request, [NullAllowed] Action<AWSIoTGetJobDocumentResponse, NSError> completionHandler);

		// -(id)getLoggingOptions:(AWSIoTGetLoggingOptionsRequest * _Nonnull)request;
		[Export ("getLoggingOptions:")]
		NSObject GetLoggingOptions (AWSIoTGetLoggingOptionsRequest request);

		// -(void)getLoggingOptions:(AWSIoTGetLoggingOptionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetLoggingOptionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getLoggingOptions:completionHandler:")]
		void GetLoggingOptions (AWSIoTGetLoggingOptionsRequest request, [NullAllowed] Action<AWSIoTGetLoggingOptionsResponse, NSError> completionHandler);

		// -(id)getOTAUpdate:(AWSIoTGetOTAUpdateRequest * _Nonnull)request;
		[Export ("getOTAUpdate:")]
		NSObject GetOTAUpdate (AWSIoTGetOTAUpdateRequest request);

		// -(void)getOTAUpdate:(AWSIoTGetOTAUpdateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetOTAUpdateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getOTAUpdate:completionHandler:")]
		void GetOTAUpdate (AWSIoTGetOTAUpdateRequest request, [NullAllowed] Action<AWSIoTGetOTAUpdateResponse, NSError> completionHandler);

		// -(id)getPercentiles:(AWSIoTGetPercentilesRequest * _Nonnull)request;
		[Export ("getPercentiles:")]
		NSObject GetPercentiles (AWSIoTGetPercentilesRequest request);

		// -(void)getPercentiles:(AWSIoTGetPercentilesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetPercentilesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getPercentiles:completionHandler:")]
		void GetPercentiles (AWSIoTGetPercentilesRequest request, [NullAllowed] Action<AWSIoTGetPercentilesResponse, NSError> completionHandler);

		// -(id)getPolicy:(AWSIoTGetPolicyRequest * _Nonnull)request;
		[Export ("getPolicy:")]
		NSObject GetPolicy (AWSIoTGetPolicyRequest request);

		// -(void)getPolicy:(AWSIoTGetPolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetPolicyResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getPolicy:completionHandler:")]
		void GetPolicy (AWSIoTGetPolicyRequest request, [NullAllowed] Action<AWSIoTGetPolicyResponse, NSError> completionHandler);

		// -(id)getPolicyVersion:(AWSIoTGetPolicyVersionRequest * _Nonnull)request;
		[Export ("getPolicyVersion:")]
		NSObject GetPolicyVersion (AWSIoTGetPolicyVersionRequest request);

		// -(void)getPolicyVersion:(AWSIoTGetPolicyVersionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetPolicyVersionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getPolicyVersion:completionHandler:")]
		void GetPolicyVersion (AWSIoTGetPolicyVersionRequest request, [NullAllowed] Action<AWSIoTGetPolicyVersionResponse, NSError> completionHandler);

		// -(id)getRegistrationCode:(AWSIoTGetRegistrationCodeRequest * _Nonnull)request;
		[Export ("getRegistrationCode:")]
		NSObject GetRegistrationCode (AWSIoTGetRegistrationCodeRequest request);

		// -(void)getRegistrationCode:(AWSIoTGetRegistrationCodeRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetRegistrationCodeResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getRegistrationCode:completionHandler:")]
		void GetRegistrationCode (AWSIoTGetRegistrationCodeRequest request, [NullAllowed] Action<AWSIoTGetRegistrationCodeResponse, NSError> completionHandler);

		// -(id)getStatistics:(AWSIoTGetStatisticsRequest * _Nonnull)request;
		[Export ("getStatistics:")]
		NSObject GetStatistics (AWSIoTGetStatisticsRequest request);

		// -(void)getStatistics:(AWSIoTGetStatisticsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetStatisticsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getStatistics:completionHandler:")]
		void GetStatistics (AWSIoTGetStatisticsRequest request, [NullAllowed] Action<AWSIoTGetStatisticsResponse, NSError> completionHandler);

		// -(id)getTopicRule:(AWSIoTGetTopicRuleRequest * _Nonnull)request;
		[Export ("getTopicRule:")]
		NSObject GetTopicRule (AWSIoTGetTopicRuleRequest request);

		// -(void)getTopicRule:(AWSIoTGetTopicRuleRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetTopicRuleResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getTopicRule:completionHandler:")]
		void GetTopicRule (AWSIoTGetTopicRuleRequest request, [NullAllowed] Action<AWSIoTGetTopicRuleResponse, NSError> completionHandler);

		// -(id)getTopicRuleDestination:(AWSIoTGetTopicRuleDestinationRequest * _Nonnull)request;
		[Export ("getTopicRuleDestination:")]
		NSObject GetTopicRuleDestination (AWSIoTGetTopicRuleDestinationRequest request);

		// -(void)getTopicRuleDestination:(AWSIoTGetTopicRuleDestinationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetTopicRuleDestinationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getTopicRuleDestination:completionHandler:")]
		void GetTopicRuleDestination (AWSIoTGetTopicRuleDestinationRequest request, [NullAllowed] Action<AWSIoTGetTopicRuleDestinationResponse, NSError> completionHandler);

		// -(id)getV2LoggingOptions:(AWSIoTGetV2LoggingOptionsRequest * _Nonnull)request;
		[Export ("getV2LoggingOptions:")]
		NSObject GetV2LoggingOptions (AWSIoTGetV2LoggingOptionsRequest request);

		// -(void)getV2LoggingOptions:(AWSIoTGetV2LoggingOptionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTGetV2LoggingOptionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getV2LoggingOptions:completionHandler:")]
		void GetV2LoggingOptions (AWSIoTGetV2LoggingOptionsRequest request, [NullAllowed] Action<AWSIoTGetV2LoggingOptionsResponse, NSError> completionHandler);

		// -(id)listActiveViolations:(AWSIoTListActiveViolationsRequest * _Nonnull)request;
		[Export ("listActiveViolations:")]
		NSObject ListActiveViolations (AWSIoTListActiveViolationsRequest request);

		// -(void)listActiveViolations:(AWSIoTListActiveViolationsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListActiveViolationsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listActiveViolations:completionHandler:")]
		void ListActiveViolations (AWSIoTListActiveViolationsRequest request, [NullAllowed] Action<AWSIoTListActiveViolationsResponse, NSError> completionHandler);

		// -(id)listAttachedPolicies:(AWSIoTListAttachedPoliciesRequest * _Nonnull)request;
		[Export ("listAttachedPolicies:")]
		NSObject ListAttachedPolicies (AWSIoTListAttachedPoliciesRequest request);

		// -(void)listAttachedPolicies:(AWSIoTListAttachedPoliciesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListAttachedPoliciesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listAttachedPolicies:completionHandler:")]
		void ListAttachedPolicies (AWSIoTListAttachedPoliciesRequest request, [NullAllowed] Action<AWSIoTListAttachedPoliciesResponse, NSError> completionHandler);

		// -(id)listAuditFindings:(AWSIoTListAuditFindingsRequest * _Nonnull)request;
		[Export ("listAuditFindings:")]
		NSObject ListAuditFindings (AWSIoTListAuditFindingsRequest request);

		// -(void)listAuditFindings:(AWSIoTListAuditFindingsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListAuditFindingsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listAuditFindings:completionHandler:")]
		void ListAuditFindings (AWSIoTListAuditFindingsRequest request, [NullAllowed] Action<AWSIoTListAuditFindingsResponse, NSError> completionHandler);

		// -(id)listAuditMitigationActionsExecutions:(AWSIoTListAuditMitigationActionsExecutionsRequest * _Nonnull)request;
		[Export ("listAuditMitigationActionsExecutions:")]
		NSObject ListAuditMitigationActionsExecutions (AWSIoTListAuditMitigationActionsExecutionsRequest request);

		// -(void)listAuditMitigationActionsExecutions:(AWSIoTListAuditMitigationActionsExecutionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListAuditMitigationActionsExecutionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listAuditMitigationActionsExecutions:completionHandler:")]
		void ListAuditMitigationActionsExecutions (AWSIoTListAuditMitigationActionsExecutionsRequest request, [NullAllowed] Action<AWSIoTListAuditMitigationActionsExecutionsResponse, NSError> completionHandler);

		// -(id)listAuditMitigationActionsTasks:(AWSIoTListAuditMitigationActionsTasksRequest * _Nonnull)request;
		[Export ("listAuditMitigationActionsTasks:")]
		NSObject ListAuditMitigationActionsTasks (AWSIoTListAuditMitigationActionsTasksRequest request);

		// -(void)listAuditMitigationActionsTasks:(AWSIoTListAuditMitigationActionsTasksRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListAuditMitigationActionsTasksResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listAuditMitigationActionsTasks:completionHandler:")]
		void ListAuditMitigationActionsTasks (AWSIoTListAuditMitigationActionsTasksRequest request, [NullAllowed] Action<AWSIoTListAuditMitigationActionsTasksResponse, NSError> completionHandler);

		// -(id)listAuditSuppressions:(AWSIoTListAuditSuppressionsRequest * _Nonnull)request;
		[Export ("listAuditSuppressions:")]
		NSObject ListAuditSuppressions (AWSIoTListAuditSuppressionsRequest request);

		// -(void)listAuditSuppressions:(AWSIoTListAuditSuppressionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListAuditSuppressionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listAuditSuppressions:completionHandler:")]
		void ListAuditSuppressions (AWSIoTListAuditSuppressionsRequest request, [NullAllowed] Action<AWSIoTListAuditSuppressionsResponse, NSError> completionHandler);

		// -(id)listAuditTasks:(AWSIoTListAuditTasksRequest * _Nonnull)request;
		[Export ("listAuditTasks:")]
		NSObject ListAuditTasks (AWSIoTListAuditTasksRequest request);

		// -(void)listAuditTasks:(AWSIoTListAuditTasksRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListAuditTasksResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listAuditTasks:completionHandler:")]
		void ListAuditTasks (AWSIoTListAuditTasksRequest request, [NullAllowed] Action<AWSIoTListAuditTasksResponse, NSError> completionHandler);

		// -(id)listAuthorizers:(AWSIoTListAuthorizersRequest * _Nonnull)request;
		[Export ("listAuthorizers:")]
		NSObject ListAuthorizers (AWSIoTListAuthorizersRequest request);

		// -(void)listAuthorizers:(AWSIoTListAuthorizersRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListAuthorizersResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listAuthorizers:completionHandler:")]
		void ListAuthorizers (AWSIoTListAuthorizersRequest request, [NullAllowed] Action<AWSIoTListAuthorizersResponse, NSError> completionHandler);

		// -(id)listBillingGroups:(AWSIoTListBillingGroupsRequest * _Nonnull)request;
		[Export ("listBillingGroups:")]
		NSObject ListBillingGroups (AWSIoTListBillingGroupsRequest request);

		// -(void)listBillingGroups:(AWSIoTListBillingGroupsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListBillingGroupsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listBillingGroups:completionHandler:")]
		void ListBillingGroups (AWSIoTListBillingGroupsRequest request, [NullAllowed] Action<AWSIoTListBillingGroupsResponse, NSError> completionHandler);

		// -(id)listCACertificates:(AWSIoTListCACertificatesRequest * _Nonnull)request;
		[Export ("listCACertificates:")]
		NSObject ListCACertificates (AWSIoTListCACertificatesRequest request);

		// -(void)listCACertificates:(AWSIoTListCACertificatesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListCACertificatesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listCACertificates:completionHandler:")]
		void ListCACertificates (AWSIoTListCACertificatesRequest request, [NullAllowed] Action<AWSIoTListCACertificatesResponse, NSError> completionHandler);

		// -(id)listCertificates:(AWSIoTListCertificatesRequest * _Nonnull)request;
		[Export ("listCertificates:")]
		NSObject ListCertificates (AWSIoTListCertificatesRequest request);

		// -(void)listCertificates:(AWSIoTListCertificatesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListCertificatesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listCertificates:completionHandler:")]
		void ListCertificates (AWSIoTListCertificatesRequest request, [NullAllowed] Action<AWSIoTListCertificatesResponse, NSError> completionHandler);

		// -(id)listCertificatesByCA:(AWSIoTListCertificatesByCARequest * _Nonnull)request;
		[Export ("listCertificatesByCA:")]
		NSObject ListCertificatesByCA (AWSIoTListCertificatesByCARequest request);

		// -(void)listCertificatesByCA:(AWSIoTListCertificatesByCARequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListCertificatesByCAResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listCertificatesByCA:completionHandler:")]
		void ListCertificatesByCA (AWSIoTListCertificatesByCARequest request, [NullAllowed] Action<AWSIoTListCertificatesByCAResponse, NSError> completionHandler);

		// -(id)listCustomMetrics:(AWSIoTListCustomMetricsRequest * _Nonnull)request;
		[Export ("listCustomMetrics:")]
		NSObject ListCustomMetrics (AWSIoTListCustomMetricsRequest request);

		// -(void)listCustomMetrics:(AWSIoTListCustomMetricsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListCustomMetricsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listCustomMetrics:completionHandler:")]
		void ListCustomMetrics (AWSIoTListCustomMetricsRequest request, [NullAllowed] Action<AWSIoTListCustomMetricsResponse, NSError> completionHandler);

		// -(id)listDetectMitigationActionsExecutions:(AWSIoTListDetectMitigationActionsExecutionsRequest * _Nonnull)request;
		[Export ("listDetectMitigationActionsExecutions:")]
		NSObject ListDetectMitigationActionsExecutions (AWSIoTListDetectMitigationActionsExecutionsRequest request);

		// -(void)listDetectMitigationActionsExecutions:(AWSIoTListDetectMitigationActionsExecutionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListDetectMitigationActionsExecutionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listDetectMitigationActionsExecutions:completionHandler:")]
		void ListDetectMitigationActionsExecutions (AWSIoTListDetectMitigationActionsExecutionsRequest request, [NullAllowed] Action<AWSIoTListDetectMitigationActionsExecutionsResponse, NSError> completionHandler);

		// -(id)listDetectMitigationActionsTasks:(AWSIoTListDetectMitigationActionsTasksRequest * _Nonnull)request;
		[Export ("listDetectMitigationActionsTasks:")]
		NSObject ListDetectMitigationActionsTasks (AWSIoTListDetectMitigationActionsTasksRequest request);

		// -(void)listDetectMitigationActionsTasks:(AWSIoTListDetectMitigationActionsTasksRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListDetectMitigationActionsTasksResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listDetectMitigationActionsTasks:completionHandler:")]
		void ListDetectMitigationActionsTasks (AWSIoTListDetectMitigationActionsTasksRequest request, [NullAllowed] Action<AWSIoTListDetectMitigationActionsTasksResponse, NSError> completionHandler);

		// -(id)listDimensions:(AWSIoTListDimensionsRequest * _Nonnull)request;
		[Export ("listDimensions:")]
		NSObject ListDimensions (AWSIoTListDimensionsRequest request);

		// -(void)listDimensions:(AWSIoTListDimensionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListDimensionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listDimensions:completionHandler:")]
		void ListDimensions (AWSIoTListDimensionsRequest request, [NullAllowed] Action<AWSIoTListDimensionsResponse, NSError> completionHandler);

		// -(id)listDomainConfigurations:(AWSIoTListDomainConfigurationsRequest * _Nonnull)request;
		[Export ("listDomainConfigurations:")]
		NSObject ListDomainConfigurations (AWSIoTListDomainConfigurationsRequest request);

		// -(void)listDomainConfigurations:(AWSIoTListDomainConfigurationsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListDomainConfigurationsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listDomainConfigurations:completionHandler:")]
		void ListDomainConfigurations (AWSIoTListDomainConfigurationsRequest request, [NullAllowed] Action<AWSIoTListDomainConfigurationsResponse, NSError> completionHandler);

		// -(id)listFleetMetrics:(AWSIoTListFleetMetricsRequest * _Nonnull)request;
		[Export ("listFleetMetrics:")]
		NSObject ListFleetMetrics (AWSIoTListFleetMetricsRequest request);

		// -(void)listFleetMetrics:(AWSIoTListFleetMetricsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListFleetMetricsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listFleetMetrics:completionHandler:")]
		void ListFleetMetrics (AWSIoTListFleetMetricsRequest request, [NullAllowed] Action<AWSIoTListFleetMetricsResponse, NSError> completionHandler);

		// -(id)listIndices:(AWSIoTListIndicesRequest * _Nonnull)request;
		[Export ("listIndices:")]
		NSObject ListIndices (AWSIoTListIndicesRequest request);

		// -(void)listIndices:(AWSIoTListIndicesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListIndicesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listIndices:completionHandler:")]
		void ListIndices (AWSIoTListIndicesRequest request, [NullAllowed] Action<AWSIoTListIndicesResponse, NSError> completionHandler);

		// -(id)listJobExecutionsForJob:(AWSIoTListJobExecutionsForJobRequest * _Nonnull)request;
		[Export ("listJobExecutionsForJob:")]
		NSObject ListJobExecutionsForJob (AWSIoTListJobExecutionsForJobRequest request);

		// -(void)listJobExecutionsForJob:(AWSIoTListJobExecutionsForJobRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListJobExecutionsForJobResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listJobExecutionsForJob:completionHandler:")]
		void ListJobExecutionsForJob (AWSIoTListJobExecutionsForJobRequest request, [NullAllowed] Action<AWSIoTListJobExecutionsForJobResponse, NSError> completionHandler);

		// -(id)listJobExecutionsForThing:(AWSIoTListJobExecutionsForThingRequest * _Nonnull)request;
		[Export ("listJobExecutionsForThing:")]
		NSObject ListJobExecutionsForThing (AWSIoTListJobExecutionsForThingRequest request);

		// -(void)listJobExecutionsForThing:(AWSIoTListJobExecutionsForThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListJobExecutionsForThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listJobExecutionsForThing:completionHandler:")]
		void ListJobExecutionsForThing (AWSIoTListJobExecutionsForThingRequest request, [NullAllowed] Action<AWSIoTListJobExecutionsForThingResponse, NSError> completionHandler);

		// -(id)listJobTemplates:(AWSIoTListJobTemplatesRequest * _Nonnull)request;
		[Export ("listJobTemplates:")]
		NSObject ListJobTemplates (AWSIoTListJobTemplatesRequest request);

		// -(void)listJobTemplates:(AWSIoTListJobTemplatesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListJobTemplatesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listJobTemplates:completionHandler:")]
		void ListJobTemplates (AWSIoTListJobTemplatesRequest request, [NullAllowed] Action<AWSIoTListJobTemplatesResponse, NSError> completionHandler);

		// -(id)listJobs:(AWSIoTListJobsRequest * _Nonnull)request;
		[Export ("listJobs:")]
		NSObject ListJobs (AWSIoTListJobsRequest request);

		// -(void)listJobs:(AWSIoTListJobsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListJobsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listJobs:completionHandler:")]
		void ListJobs (AWSIoTListJobsRequest request, [NullAllowed] Action<AWSIoTListJobsResponse, NSError> completionHandler);

		// -(id)listManagedJobTemplates:(AWSIoTListManagedJobTemplatesRequest * _Nonnull)request;
		[Export ("listManagedJobTemplates:")]
		NSObject ListManagedJobTemplates (AWSIoTListManagedJobTemplatesRequest request);

		// -(void)listManagedJobTemplates:(AWSIoTListManagedJobTemplatesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListManagedJobTemplatesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listManagedJobTemplates:completionHandler:")]
		void ListManagedJobTemplates (AWSIoTListManagedJobTemplatesRequest request, [NullAllowed] Action<AWSIoTListManagedJobTemplatesResponse, NSError> completionHandler);

		// -(id)listMetricValues:(AWSIoTListMetricValuesRequest * _Nonnull)request;
		[Export ("listMetricValues:")]
		NSObject ListMetricValues (AWSIoTListMetricValuesRequest request);

		// -(void)listMetricValues:(AWSIoTListMetricValuesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListMetricValuesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listMetricValues:completionHandler:")]
		void ListMetricValues (AWSIoTListMetricValuesRequest request, [NullAllowed] Action<AWSIoTListMetricValuesResponse, NSError> completionHandler);

		// -(id)listMitigationActions:(AWSIoTListMitigationActionsRequest * _Nonnull)request;
		[Export ("listMitigationActions:")]
		NSObject ListMitigationActions (AWSIoTListMitigationActionsRequest request);

		// -(void)listMitigationActions:(AWSIoTListMitigationActionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListMitigationActionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listMitigationActions:completionHandler:")]
		void ListMitigationActions (AWSIoTListMitigationActionsRequest request, [NullAllowed] Action<AWSIoTListMitigationActionsResponse, NSError> completionHandler);

		// -(id)listOTAUpdates:(AWSIoTListOTAUpdatesRequest * _Nonnull)request;
		[Export ("listOTAUpdates:")]
		NSObject ListOTAUpdates (AWSIoTListOTAUpdatesRequest request);

		// -(void)listOTAUpdates:(AWSIoTListOTAUpdatesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListOTAUpdatesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listOTAUpdates:completionHandler:")]
		void ListOTAUpdates (AWSIoTListOTAUpdatesRequest request, [NullAllowed] Action<AWSIoTListOTAUpdatesResponse, NSError> completionHandler);

		// -(id)listOutgoingCertificates:(AWSIoTListOutgoingCertificatesRequest * _Nonnull)request;
		[Export ("listOutgoingCertificates:")]
		NSObject ListOutgoingCertificates (AWSIoTListOutgoingCertificatesRequest request);

		// -(void)listOutgoingCertificates:(AWSIoTListOutgoingCertificatesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListOutgoingCertificatesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listOutgoingCertificates:completionHandler:")]
		void ListOutgoingCertificates (AWSIoTListOutgoingCertificatesRequest request, [NullAllowed] Action<AWSIoTListOutgoingCertificatesResponse, NSError> completionHandler);

		// -(id)listPolicies:(AWSIoTListPoliciesRequest * _Nonnull)request;
		[Export ("listPolicies:")]
		NSObject ListPolicies (AWSIoTListPoliciesRequest request);

		// -(void)listPolicies:(AWSIoTListPoliciesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListPoliciesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listPolicies:completionHandler:")]
		void ListPolicies (AWSIoTListPoliciesRequest request, [NullAllowed] Action<AWSIoTListPoliciesResponse, NSError> completionHandler);

		// -(id)listPolicyPrincipals:(AWSIoTListPolicyPrincipalsRequest * _Nonnull)request;
		[Export ("listPolicyPrincipals:")]
		NSObject ListPolicyPrincipals (AWSIoTListPolicyPrincipalsRequest request);

		// -(void)listPolicyPrincipals:(AWSIoTListPolicyPrincipalsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListPolicyPrincipalsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listPolicyPrincipals:completionHandler:")]
		void ListPolicyPrincipals (AWSIoTListPolicyPrincipalsRequest request, [NullAllowed] Action<AWSIoTListPolicyPrincipalsResponse, NSError> completionHandler);

		// -(id)listPolicyVersions:(AWSIoTListPolicyVersionsRequest * _Nonnull)request;
		[Export ("listPolicyVersions:")]
		NSObject ListPolicyVersions (AWSIoTListPolicyVersionsRequest request);

		// -(void)listPolicyVersions:(AWSIoTListPolicyVersionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListPolicyVersionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listPolicyVersions:completionHandler:")]
		void ListPolicyVersions (AWSIoTListPolicyVersionsRequest request, [NullAllowed] Action<AWSIoTListPolicyVersionsResponse, NSError> completionHandler);

		// -(id)listPrincipalPolicies:(AWSIoTListPrincipalPoliciesRequest * _Nonnull)request;
		[Export ("listPrincipalPolicies:")]
		NSObject ListPrincipalPolicies (AWSIoTListPrincipalPoliciesRequest request);

		// -(void)listPrincipalPolicies:(AWSIoTListPrincipalPoliciesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListPrincipalPoliciesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listPrincipalPolicies:completionHandler:")]
		void ListPrincipalPolicies (AWSIoTListPrincipalPoliciesRequest request, [NullAllowed] Action<AWSIoTListPrincipalPoliciesResponse, NSError> completionHandler);

		// -(id)listPrincipalThings:(AWSIoTListPrincipalThingsRequest * _Nonnull)request;
		[Export ("listPrincipalThings:")]
		NSObject ListPrincipalThings (AWSIoTListPrincipalThingsRequest request);

		// -(void)listPrincipalThings:(AWSIoTListPrincipalThingsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListPrincipalThingsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listPrincipalThings:completionHandler:")]
		void ListPrincipalThings (AWSIoTListPrincipalThingsRequest request, [NullAllowed] Action<AWSIoTListPrincipalThingsResponse, NSError> completionHandler);

		// -(id)listProvisioningTemplateVersions:(AWSIoTListProvisioningTemplateVersionsRequest * _Nonnull)request;
		[Export ("listProvisioningTemplateVersions:")]
		NSObject ListProvisioningTemplateVersions (AWSIoTListProvisioningTemplateVersionsRequest request);

		// -(void)listProvisioningTemplateVersions:(AWSIoTListProvisioningTemplateVersionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListProvisioningTemplateVersionsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listProvisioningTemplateVersions:completionHandler:")]
		void ListProvisioningTemplateVersions (AWSIoTListProvisioningTemplateVersionsRequest request, [NullAllowed] Action<AWSIoTListProvisioningTemplateVersionsResponse, NSError> completionHandler);

		// -(id)listProvisioningTemplates:(AWSIoTListProvisioningTemplatesRequest * _Nonnull)request;
		[Export ("listProvisioningTemplates:")]
		NSObject ListProvisioningTemplates (AWSIoTListProvisioningTemplatesRequest request);

		// -(void)listProvisioningTemplates:(AWSIoTListProvisioningTemplatesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListProvisioningTemplatesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listProvisioningTemplates:completionHandler:")]
		void ListProvisioningTemplates (AWSIoTListProvisioningTemplatesRequest request, [NullAllowed] Action<AWSIoTListProvisioningTemplatesResponse, NSError> completionHandler);

		// -(id)listRelatedResourcesForAuditFinding:(AWSIoTListRelatedResourcesForAuditFindingRequest * _Nonnull)request;
		[Export ("listRelatedResourcesForAuditFinding:")]
		NSObject ListRelatedResourcesForAuditFinding (AWSIoTListRelatedResourcesForAuditFindingRequest request);

		// -(void)listRelatedResourcesForAuditFinding:(AWSIoTListRelatedResourcesForAuditFindingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListRelatedResourcesForAuditFindingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listRelatedResourcesForAuditFinding:completionHandler:")]
		void ListRelatedResourcesForAuditFinding (AWSIoTListRelatedResourcesForAuditFindingRequest request, [NullAllowed] Action<AWSIoTListRelatedResourcesForAuditFindingResponse, NSError> completionHandler);

		// -(id)listRoleAliases:(AWSIoTListRoleAliasesRequest * _Nonnull)request;
		[Export ("listRoleAliases:")]
		NSObject ListRoleAliases (AWSIoTListRoleAliasesRequest request);

		// -(void)listRoleAliases:(AWSIoTListRoleAliasesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListRoleAliasesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listRoleAliases:completionHandler:")]
		void ListRoleAliases (AWSIoTListRoleAliasesRequest request, [NullAllowed] Action<AWSIoTListRoleAliasesResponse, NSError> completionHandler);

		// -(id)listScheduledAudits:(AWSIoTListScheduledAuditsRequest * _Nonnull)request;
		[Export ("listScheduledAudits:")]
		NSObject ListScheduledAudits (AWSIoTListScheduledAuditsRequest request);

		// -(void)listScheduledAudits:(AWSIoTListScheduledAuditsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListScheduledAuditsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listScheduledAudits:completionHandler:")]
		void ListScheduledAudits (AWSIoTListScheduledAuditsRequest request, [NullAllowed] Action<AWSIoTListScheduledAuditsResponse, NSError> completionHandler);

		// -(id)listSecurityProfiles:(AWSIoTListSecurityProfilesRequest * _Nonnull)request;
		[Export ("listSecurityProfiles:")]
		NSObject ListSecurityProfiles (AWSIoTListSecurityProfilesRequest request);

		// -(void)listSecurityProfiles:(AWSIoTListSecurityProfilesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListSecurityProfilesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listSecurityProfiles:completionHandler:")]
		void ListSecurityProfiles (AWSIoTListSecurityProfilesRequest request, [NullAllowed] Action<AWSIoTListSecurityProfilesResponse, NSError> completionHandler);

		// -(id)listSecurityProfilesForTarget:(AWSIoTListSecurityProfilesForTargetRequest * _Nonnull)request;
		[Export ("listSecurityProfilesForTarget:")]
		NSObject ListSecurityProfilesForTarget (AWSIoTListSecurityProfilesForTargetRequest request);

		// -(void)listSecurityProfilesForTarget:(AWSIoTListSecurityProfilesForTargetRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListSecurityProfilesForTargetResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listSecurityProfilesForTarget:completionHandler:")]
		void ListSecurityProfilesForTarget (AWSIoTListSecurityProfilesForTargetRequest request, [NullAllowed] Action<AWSIoTListSecurityProfilesForTargetResponse, NSError> completionHandler);

		// -(id)listStreams:(AWSIoTListStreamsRequest * _Nonnull)request;
		[Export ("listStreams:")]
		NSObject ListStreams (AWSIoTListStreamsRequest request);

		// -(void)listStreams:(AWSIoTListStreamsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListStreamsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listStreams:completionHandler:")]
		void ListStreams (AWSIoTListStreamsRequest request, [NullAllowed] Action<AWSIoTListStreamsResponse, NSError> completionHandler);

		// -(id)listTagsForResource:(AWSIoTListTagsForResourceRequest * _Nonnull)request;
		[Export ("listTagsForResource:")]
		NSObject ListTagsForResource (AWSIoTListTagsForResourceRequest request);

		// -(void)listTagsForResource:(AWSIoTListTagsForResourceRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListTagsForResourceResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listTagsForResource:completionHandler:")]
		void ListTagsForResource (AWSIoTListTagsForResourceRequest request, [NullAllowed] Action<AWSIoTListTagsForResourceResponse, NSError> completionHandler);

		// -(id)listTargetsForPolicy:(AWSIoTListTargetsForPolicyRequest * _Nonnull)request;
		[Export ("listTargetsForPolicy:")]
		NSObject ListTargetsForPolicy (AWSIoTListTargetsForPolicyRequest request);

		// -(void)listTargetsForPolicy:(AWSIoTListTargetsForPolicyRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListTargetsForPolicyResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listTargetsForPolicy:completionHandler:")]
		void ListTargetsForPolicy (AWSIoTListTargetsForPolicyRequest request, [NullAllowed] Action<AWSIoTListTargetsForPolicyResponse, NSError> completionHandler);

		// -(id)listTargetsForSecurityProfile:(AWSIoTListTargetsForSecurityProfileRequest * _Nonnull)request;
		[Export ("listTargetsForSecurityProfile:")]
		NSObject ListTargetsForSecurityProfile (AWSIoTListTargetsForSecurityProfileRequest request);

		// -(void)listTargetsForSecurityProfile:(AWSIoTListTargetsForSecurityProfileRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListTargetsForSecurityProfileResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listTargetsForSecurityProfile:completionHandler:")]
		void ListTargetsForSecurityProfile (AWSIoTListTargetsForSecurityProfileRequest request, [NullAllowed] Action<AWSIoTListTargetsForSecurityProfileResponse, NSError> completionHandler);

		// -(id)listThingGroups:(AWSIoTListThingGroupsRequest * _Nonnull)request;
		[Export ("listThingGroups:")]
		NSObject ListThingGroups (AWSIoTListThingGroupsRequest request);

		// -(void)listThingGroups:(AWSIoTListThingGroupsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingGroupsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingGroups:completionHandler:")]
		void ListThingGroups (AWSIoTListThingGroupsRequest request, [NullAllowed] Action<AWSIoTListThingGroupsResponse, NSError> completionHandler);

		// -(id)listThingGroupsForThing:(AWSIoTListThingGroupsForThingRequest * _Nonnull)request;
		[Export ("listThingGroupsForThing:")]
		NSObject ListThingGroupsForThing (AWSIoTListThingGroupsForThingRequest request);

		// -(void)listThingGroupsForThing:(AWSIoTListThingGroupsForThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingGroupsForThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingGroupsForThing:completionHandler:")]
		void ListThingGroupsForThing (AWSIoTListThingGroupsForThingRequest request, [NullAllowed] Action<AWSIoTListThingGroupsForThingResponse, NSError> completionHandler);

		// -(id)listThingPrincipals:(AWSIoTListThingPrincipalsRequest * _Nonnull)request;
		[Export ("listThingPrincipals:")]
		NSObject ListThingPrincipals (AWSIoTListThingPrincipalsRequest request);

		// -(void)listThingPrincipals:(AWSIoTListThingPrincipalsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingPrincipalsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingPrincipals:completionHandler:")]
		void ListThingPrincipals (AWSIoTListThingPrincipalsRequest request, [NullAllowed] Action<AWSIoTListThingPrincipalsResponse, NSError> completionHandler);

		// -(id)listThingRegistrationTaskReports:(AWSIoTListThingRegistrationTaskReportsRequest * _Nonnull)request;
		[Export ("listThingRegistrationTaskReports:")]
		NSObject ListThingRegistrationTaskReports (AWSIoTListThingRegistrationTaskReportsRequest request);

		// -(void)listThingRegistrationTaskReports:(AWSIoTListThingRegistrationTaskReportsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingRegistrationTaskReportsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingRegistrationTaskReports:completionHandler:")]
		void ListThingRegistrationTaskReports (AWSIoTListThingRegistrationTaskReportsRequest request, [NullAllowed] Action<AWSIoTListThingRegistrationTaskReportsResponse, NSError> completionHandler);

		// -(id)listThingRegistrationTasks:(AWSIoTListThingRegistrationTasksRequest * _Nonnull)request;
		[Export ("listThingRegistrationTasks:")]
		NSObject ListThingRegistrationTasks (AWSIoTListThingRegistrationTasksRequest request);

		// -(void)listThingRegistrationTasks:(AWSIoTListThingRegistrationTasksRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingRegistrationTasksResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingRegistrationTasks:completionHandler:")]
		void ListThingRegistrationTasks (AWSIoTListThingRegistrationTasksRequest request, [NullAllowed] Action<AWSIoTListThingRegistrationTasksResponse, NSError> completionHandler);

		// -(id)listThingTypes:(AWSIoTListThingTypesRequest * _Nonnull)request;
		[Export ("listThingTypes:")]
		NSObject ListThingTypes (AWSIoTListThingTypesRequest request);

		// -(void)listThingTypes:(AWSIoTListThingTypesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingTypesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingTypes:completionHandler:")]
		void ListThingTypes (AWSIoTListThingTypesRequest request, [NullAllowed] Action<AWSIoTListThingTypesResponse, NSError> completionHandler);

		// -(id)listThings:(AWSIoTListThingsRequest * _Nonnull)request;
		[Export ("listThings:")]
		NSObject ListThings (AWSIoTListThingsRequest request);

		// -(void)listThings:(AWSIoTListThingsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThings:completionHandler:")]
		void ListThings (AWSIoTListThingsRequest request, [NullAllowed] Action<AWSIoTListThingsResponse, NSError> completionHandler);

		// -(id)listThingsInBillingGroup:(AWSIoTListThingsInBillingGroupRequest * _Nonnull)request;
		[Export ("listThingsInBillingGroup:")]
		NSObject ListThingsInBillingGroup (AWSIoTListThingsInBillingGroupRequest request);

		// -(void)listThingsInBillingGroup:(AWSIoTListThingsInBillingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingsInBillingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingsInBillingGroup:completionHandler:")]
		void ListThingsInBillingGroup (AWSIoTListThingsInBillingGroupRequest request, [NullAllowed] Action<AWSIoTListThingsInBillingGroupResponse, NSError> completionHandler);

		// -(id)listThingsInThingGroup:(AWSIoTListThingsInThingGroupRequest * _Nonnull)request;
		[Export ("listThingsInThingGroup:")]
		NSObject ListThingsInThingGroup (AWSIoTListThingsInThingGroupRequest request);

		// -(void)listThingsInThingGroup:(AWSIoTListThingsInThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListThingsInThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listThingsInThingGroup:completionHandler:")]
		void ListThingsInThingGroup (AWSIoTListThingsInThingGroupRequest request, [NullAllowed] Action<AWSIoTListThingsInThingGroupResponse, NSError> completionHandler);

		// -(id)listTopicRuleDestinations:(AWSIoTListTopicRuleDestinationsRequest * _Nonnull)request;
		[Export ("listTopicRuleDestinations:")]
		NSObject ListTopicRuleDestinations (AWSIoTListTopicRuleDestinationsRequest request);

		// -(void)listTopicRuleDestinations:(AWSIoTListTopicRuleDestinationsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListTopicRuleDestinationsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listTopicRuleDestinations:completionHandler:")]
		void ListTopicRuleDestinations (AWSIoTListTopicRuleDestinationsRequest request, [NullAllowed] Action<AWSIoTListTopicRuleDestinationsResponse, NSError> completionHandler);

		// -(id)listTopicRules:(AWSIoTListTopicRulesRequest * _Nonnull)request;
		[Export ("listTopicRules:")]
		NSObject ListTopicRules (AWSIoTListTopicRulesRequest request);

		// -(void)listTopicRules:(AWSIoTListTopicRulesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListTopicRulesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listTopicRules:completionHandler:")]
		void ListTopicRules (AWSIoTListTopicRulesRequest request, [NullAllowed] Action<AWSIoTListTopicRulesResponse, NSError> completionHandler);

		// -(id)listV2LoggingLevels:(AWSIoTListV2LoggingLevelsRequest * _Nonnull)request;
		[Export ("listV2LoggingLevels:")]
		NSObject ListV2LoggingLevels (AWSIoTListV2LoggingLevelsRequest request);

		// -(void)listV2LoggingLevels:(AWSIoTListV2LoggingLevelsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListV2LoggingLevelsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listV2LoggingLevels:completionHandler:")]
		void ListV2LoggingLevels (AWSIoTListV2LoggingLevelsRequest request, [NullAllowed] Action<AWSIoTListV2LoggingLevelsResponse, NSError> completionHandler);

		// -(id)listViolationEvents:(AWSIoTListViolationEventsRequest * _Nonnull)request;
		[Export ("listViolationEvents:")]
		NSObject ListViolationEvents (AWSIoTListViolationEventsRequest request);

		// -(void)listViolationEvents:(AWSIoTListViolationEventsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTListViolationEventsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listViolationEvents:completionHandler:")]
		void ListViolationEvents (AWSIoTListViolationEventsRequest request, [NullAllowed] Action<AWSIoTListViolationEventsResponse, NSError> completionHandler);

		// -(id)putVerificationStateOnViolation:(AWSIoTPutVerificationStateOnViolationRequest * _Nonnull)request;
		[Export ("putVerificationStateOnViolation:")]
		NSObject PutVerificationStateOnViolation (AWSIoTPutVerificationStateOnViolationRequest request);

		// -(void)putVerificationStateOnViolation:(AWSIoTPutVerificationStateOnViolationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTPutVerificationStateOnViolationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("putVerificationStateOnViolation:completionHandler:")]
		void PutVerificationStateOnViolation (AWSIoTPutVerificationStateOnViolationRequest request, [NullAllowed] Action<AWSIoTPutVerificationStateOnViolationResponse, NSError> completionHandler);

		// -(id)registerCACertificate:(AWSIoTRegisterCACertificateRequest * _Nonnull)request;
		[Export ("registerCACertificate:")]
		NSObject RegisterCACertificate (AWSIoTRegisterCACertificateRequest request);

		// -(void)registerCACertificate:(AWSIoTRegisterCACertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTRegisterCACertificateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("registerCACertificate:completionHandler:")]
		void RegisterCACertificate (AWSIoTRegisterCACertificateRequest request, [NullAllowed] Action<AWSIoTRegisterCACertificateResponse, NSError> completionHandler);

		// -(id)registerCertificate:(AWSIoTRegisterCertificateRequest * _Nonnull)request;
		[Export ("registerCertificate:")]
		NSObject RegisterCertificate (AWSIoTRegisterCertificateRequest request);

		// -(void)registerCertificate:(AWSIoTRegisterCertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTRegisterCertificateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("registerCertificate:completionHandler:")]
		void RegisterCertificate (AWSIoTRegisterCertificateRequest request, [NullAllowed] Action<AWSIoTRegisterCertificateResponse, NSError> completionHandler);

		// -(id)registerCertificateWithoutCA:(AWSIoTRegisterCertificateWithoutCARequest * _Nonnull)request;
		[Export ("registerCertificateWithoutCA:")]
		NSObject RegisterCertificateWithoutCA (AWSIoTRegisterCertificateWithoutCARequest request);

		// -(void)registerCertificateWithoutCA:(AWSIoTRegisterCertificateWithoutCARequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTRegisterCertificateWithoutCAResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("registerCertificateWithoutCA:completionHandler:")]
		void RegisterCertificateWithoutCA (AWSIoTRegisterCertificateWithoutCARequest request, [NullAllowed] Action<AWSIoTRegisterCertificateWithoutCAResponse, NSError> completionHandler);

		// -(id)registerThing:(AWSIoTRegisterThingRequest * _Nonnull)request;
		[Export ("registerThing:")]
		NSObject RegisterThing (AWSIoTRegisterThingRequest request);

		// -(void)registerThing:(AWSIoTRegisterThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTRegisterThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("registerThing:completionHandler:")]
		void RegisterThing (AWSIoTRegisterThingRequest request, [NullAllowed] Action<AWSIoTRegisterThingResponse, NSError> completionHandler);

		// -(id)rejectCertificateTransfer:(AWSIoTRejectCertificateTransferRequest * _Nonnull)request;
		[Export ("rejectCertificateTransfer:")]
		NSObject RejectCertificateTransfer (AWSIoTRejectCertificateTransferRequest request);

		// -(void)rejectCertificateTransfer:(AWSIoTRejectCertificateTransferRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("rejectCertificateTransfer:completionHandler:")]
		void RejectCertificateTransfer (AWSIoTRejectCertificateTransferRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)removeThingFromBillingGroup:(AWSIoTRemoveThingFromBillingGroupRequest * _Nonnull)request;
		[Export ("removeThingFromBillingGroup:")]
		NSObject RemoveThingFromBillingGroup (AWSIoTRemoveThingFromBillingGroupRequest request);

		// -(void)removeThingFromBillingGroup:(AWSIoTRemoveThingFromBillingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTRemoveThingFromBillingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("removeThingFromBillingGroup:completionHandler:")]
		void RemoveThingFromBillingGroup (AWSIoTRemoveThingFromBillingGroupRequest request, [NullAllowed] Action<AWSIoTRemoveThingFromBillingGroupResponse, NSError> completionHandler);

		// -(id)removeThingFromThingGroup:(AWSIoTRemoveThingFromThingGroupRequest * _Nonnull)request;
		[Export ("removeThingFromThingGroup:")]
		NSObject RemoveThingFromThingGroup (AWSIoTRemoveThingFromThingGroupRequest request);

		// -(void)removeThingFromThingGroup:(AWSIoTRemoveThingFromThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTRemoveThingFromThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("removeThingFromThingGroup:completionHandler:")]
		void RemoveThingFromThingGroup (AWSIoTRemoveThingFromThingGroupRequest request, [NullAllowed] Action<AWSIoTRemoveThingFromThingGroupResponse, NSError> completionHandler);

		// -(id)replaceTopicRule:(AWSIoTReplaceTopicRuleRequest * _Nonnull)request;
		[Export ("replaceTopicRule:")]
		NSObject ReplaceTopicRule (AWSIoTReplaceTopicRuleRequest request);

		// -(void)replaceTopicRule:(AWSIoTReplaceTopicRuleRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("replaceTopicRule:completionHandler:")]
		void ReplaceTopicRule (AWSIoTReplaceTopicRuleRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)searchIndex:(AWSIoTSearchIndexRequest * _Nonnull)request;
		[Export ("searchIndex:")]
		NSObject SearchIndex (AWSIoTSearchIndexRequest request);

		// -(void)searchIndex:(AWSIoTSearchIndexRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTSearchIndexResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("searchIndex:completionHandler:")]
		void SearchIndex (AWSIoTSearchIndexRequest request, [NullAllowed] Action<AWSIoTSearchIndexResponse, NSError> completionHandler);

		// -(id)setDefaultAuthorizer:(AWSIoTSetDefaultAuthorizerRequest * _Nonnull)request;
		[Export ("setDefaultAuthorizer:")]
		NSObject SetDefaultAuthorizer (AWSIoTSetDefaultAuthorizerRequest request);

		// -(void)setDefaultAuthorizer:(AWSIoTSetDefaultAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTSetDefaultAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("setDefaultAuthorizer:completionHandler:")]
		void SetDefaultAuthorizer (AWSIoTSetDefaultAuthorizerRequest request, [NullAllowed] Action<AWSIoTSetDefaultAuthorizerResponse, NSError> completionHandler);

		// -(id)setDefaultPolicyVersion:(AWSIoTSetDefaultPolicyVersionRequest * _Nonnull)request;
		[Export ("setDefaultPolicyVersion:")]
		NSObject SetDefaultPolicyVersion (AWSIoTSetDefaultPolicyVersionRequest request);

		// -(void)setDefaultPolicyVersion:(AWSIoTSetDefaultPolicyVersionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("setDefaultPolicyVersion:completionHandler:")]
		void SetDefaultPolicyVersion (AWSIoTSetDefaultPolicyVersionRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)setLoggingOptions:(AWSIoTSetLoggingOptionsRequest * _Nonnull)request;
		[Export ("setLoggingOptions:")]
		NSObject SetLoggingOptions (AWSIoTSetLoggingOptionsRequest request);

		// -(void)setLoggingOptions:(AWSIoTSetLoggingOptionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("setLoggingOptions:completionHandler:")]
		void SetLoggingOptions (AWSIoTSetLoggingOptionsRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)setV2LoggingLevel:(AWSIoTSetV2LoggingLevelRequest * _Nonnull)request;
		[Export ("setV2LoggingLevel:")]
		NSObject SetV2LoggingLevel (AWSIoTSetV2LoggingLevelRequest request);

		// -(void)setV2LoggingLevel:(AWSIoTSetV2LoggingLevelRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("setV2LoggingLevel:completionHandler:")]
		void SetV2LoggingLevel (AWSIoTSetV2LoggingLevelRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)setV2LoggingOptions:(AWSIoTSetV2LoggingOptionsRequest * _Nonnull)request;
		[Export ("setV2LoggingOptions:")]
		NSObject SetV2LoggingOptions (AWSIoTSetV2LoggingOptionsRequest request);

		// -(void)setV2LoggingOptions:(AWSIoTSetV2LoggingOptionsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("setV2LoggingOptions:completionHandler:")]
		void SetV2LoggingOptions (AWSIoTSetV2LoggingOptionsRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)startAuditMitigationActionsTask:(AWSIoTStartAuditMitigationActionsTaskRequest * _Nonnull)request;
		[Export ("startAuditMitigationActionsTask:")]
		NSObject StartAuditMitigationActionsTask (AWSIoTStartAuditMitigationActionsTaskRequest request);

		// -(void)startAuditMitigationActionsTask:(AWSIoTStartAuditMitigationActionsTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTStartAuditMitigationActionsTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("startAuditMitigationActionsTask:completionHandler:")]
		void StartAuditMitigationActionsTask (AWSIoTStartAuditMitigationActionsTaskRequest request, [NullAllowed] Action<AWSIoTStartAuditMitigationActionsTaskResponse, NSError> completionHandler);

		// -(id)startDetectMitigationActionsTask:(AWSIoTStartDetectMitigationActionsTaskRequest * _Nonnull)request;
		[Export ("startDetectMitigationActionsTask:")]
		NSObject StartDetectMitigationActionsTask (AWSIoTStartDetectMitigationActionsTaskRequest request);

		// -(void)startDetectMitigationActionsTask:(AWSIoTStartDetectMitigationActionsTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTStartDetectMitigationActionsTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("startDetectMitigationActionsTask:completionHandler:")]
		void StartDetectMitigationActionsTask (AWSIoTStartDetectMitigationActionsTaskRequest request, [NullAllowed] Action<AWSIoTStartDetectMitigationActionsTaskResponse, NSError> completionHandler);

		// -(id)startOnDemandAuditTask:(AWSIoTStartOnDemandAuditTaskRequest * _Nonnull)request;
		[Export ("startOnDemandAuditTask:")]
		NSObject StartOnDemandAuditTask (AWSIoTStartOnDemandAuditTaskRequest request);

		// -(void)startOnDemandAuditTask:(AWSIoTStartOnDemandAuditTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTStartOnDemandAuditTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("startOnDemandAuditTask:completionHandler:")]
		void StartOnDemandAuditTask (AWSIoTStartOnDemandAuditTaskRequest request, [NullAllowed] Action<AWSIoTStartOnDemandAuditTaskResponse, NSError> completionHandler);

		// -(id)startThingRegistrationTask:(AWSIoTStartThingRegistrationTaskRequest * _Nonnull)request;
		[Export ("startThingRegistrationTask:")]
		NSObject StartThingRegistrationTask (AWSIoTStartThingRegistrationTaskRequest request);

		// -(void)startThingRegistrationTask:(AWSIoTStartThingRegistrationTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTStartThingRegistrationTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("startThingRegistrationTask:completionHandler:")]
		void StartThingRegistrationTask (AWSIoTStartThingRegistrationTaskRequest request, [NullAllowed] Action<AWSIoTStartThingRegistrationTaskResponse, NSError> completionHandler);

		// -(id)stopThingRegistrationTask:(AWSIoTStopThingRegistrationTaskRequest * _Nonnull)request;
		[Export ("stopThingRegistrationTask:")]
		NSObject StopThingRegistrationTask (AWSIoTStopThingRegistrationTaskRequest request);

		// -(void)stopThingRegistrationTask:(AWSIoTStopThingRegistrationTaskRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTStopThingRegistrationTaskResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("stopThingRegistrationTask:completionHandler:")]
		void StopThingRegistrationTask (AWSIoTStopThingRegistrationTaskRequest request, [NullAllowed] Action<AWSIoTStopThingRegistrationTaskResponse, NSError> completionHandler);

		// -(id)tagResource:(AWSIoTTagResourceRequest * _Nonnull)request;
		[Export ("tagResource:")]
		NSObject TagResource (AWSIoTTagResourceRequest request);

		// -(void)tagResource:(AWSIoTTagResourceRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTTagResourceResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("tagResource:completionHandler:")]
		void TagResource (AWSIoTTagResourceRequest request, [NullAllowed] Action<AWSIoTTagResourceResponse, NSError> completionHandler);

		// -(id)testAuthorization:(AWSIoTTestAuthorizationRequest * _Nonnull)request;
		[Export ("testAuthorization:")]
		NSObject TestAuthorization (AWSIoTTestAuthorizationRequest request);

		// -(void)testAuthorization:(AWSIoTTestAuthorizationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTTestAuthorizationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("testAuthorization:completionHandler:")]
		void TestAuthorization (AWSIoTTestAuthorizationRequest request, [NullAllowed] Action<AWSIoTTestAuthorizationResponse, NSError> completionHandler);

		// -(id)testInvokeAuthorizer:(AWSIoTTestInvokeAuthorizerRequest * _Nonnull)request;
		[Export ("testInvokeAuthorizer:")]
		NSObject TestInvokeAuthorizer (AWSIoTTestInvokeAuthorizerRequest request);

		// -(void)testInvokeAuthorizer:(AWSIoTTestInvokeAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTTestInvokeAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("testInvokeAuthorizer:completionHandler:")]
		void TestInvokeAuthorizer (AWSIoTTestInvokeAuthorizerRequest request, [NullAllowed] Action<AWSIoTTestInvokeAuthorizerResponse, NSError> completionHandler);

		// -(id)transferCertificate:(AWSIoTTransferCertificateRequest * _Nonnull)request;
		[Export ("transferCertificate:")]
		NSObject TransferCertificate (AWSIoTTransferCertificateRequest request);

		// -(void)transferCertificate:(AWSIoTTransferCertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTTransferCertificateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("transferCertificate:completionHandler:")]
		void TransferCertificate (AWSIoTTransferCertificateRequest request, [NullAllowed] Action<AWSIoTTransferCertificateResponse, NSError> completionHandler);

		// -(id)untagResource:(AWSIoTUntagResourceRequest * _Nonnull)request;
		[Export ("untagResource:")]
		NSObject UntagResource (AWSIoTUntagResourceRequest request);

		// -(void)untagResource:(AWSIoTUntagResourceRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUntagResourceResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("untagResource:completionHandler:")]
		void UntagResource (AWSIoTUntagResourceRequest request, [NullAllowed] Action<AWSIoTUntagResourceResponse, NSError> completionHandler);

		// -(id)updateAccountAuditConfiguration:(AWSIoTUpdateAccountAuditConfigurationRequest * _Nonnull)request;
		[Export ("updateAccountAuditConfiguration:")]
		NSObject UpdateAccountAuditConfiguration (AWSIoTUpdateAccountAuditConfigurationRequest request);

		// -(void)updateAccountAuditConfiguration:(AWSIoTUpdateAccountAuditConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateAccountAuditConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateAccountAuditConfiguration:completionHandler:")]
		void UpdateAccountAuditConfiguration (AWSIoTUpdateAccountAuditConfigurationRequest request, [NullAllowed] Action<AWSIoTUpdateAccountAuditConfigurationResponse, NSError> completionHandler);

		// -(id)updateAuditSuppression:(AWSIoTUpdateAuditSuppressionRequest * _Nonnull)request;
		[Export ("updateAuditSuppression:")]
		NSObject UpdateAuditSuppression (AWSIoTUpdateAuditSuppressionRequest request);

		// -(void)updateAuditSuppression:(AWSIoTUpdateAuditSuppressionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateAuditSuppressionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateAuditSuppression:completionHandler:")]
		void UpdateAuditSuppression (AWSIoTUpdateAuditSuppressionRequest request, [NullAllowed] Action<AWSIoTUpdateAuditSuppressionResponse, NSError> completionHandler);

		// -(id)updateAuthorizer:(AWSIoTUpdateAuthorizerRequest * _Nonnull)request;
		[Export ("updateAuthorizer:")]
		NSObject UpdateAuthorizer (AWSIoTUpdateAuthorizerRequest request);

		// -(void)updateAuthorizer:(AWSIoTUpdateAuthorizerRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateAuthorizerResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateAuthorizer:completionHandler:")]
		void UpdateAuthorizer (AWSIoTUpdateAuthorizerRequest request, [NullAllowed] Action<AWSIoTUpdateAuthorizerResponse, NSError> completionHandler);

		// -(id)updateBillingGroup:(AWSIoTUpdateBillingGroupRequest * _Nonnull)request;
		[Export ("updateBillingGroup:")]
		NSObject UpdateBillingGroup (AWSIoTUpdateBillingGroupRequest request);

		// -(void)updateBillingGroup:(AWSIoTUpdateBillingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateBillingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateBillingGroup:completionHandler:")]
		void UpdateBillingGroup (AWSIoTUpdateBillingGroupRequest request, [NullAllowed] Action<AWSIoTUpdateBillingGroupResponse, NSError> completionHandler);

		// -(id)updateCACertificate:(AWSIoTUpdateCACertificateRequest * _Nonnull)request;
		[Export ("updateCACertificate:")]
		NSObject UpdateCACertificate (AWSIoTUpdateCACertificateRequest request);

		// -(void)updateCACertificate:(AWSIoTUpdateCACertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("updateCACertificate:completionHandler:")]
		void UpdateCACertificate (AWSIoTUpdateCACertificateRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)updateCertificate:(AWSIoTUpdateCertificateRequest * _Nonnull)request;
		[Export ("updateCertificate:")]
		NSObject UpdateCertificate (AWSIoTUpdateCertificateRequest request);

		// -(void)updateCertificate:(AWSIoTUpdateCertificateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("updateCertificate:completionHandler:")]
		void UpdateCertificate (AWSIoTUpdateCertificateRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)updateCustomMetric:(AWSIoTUpdateCustomMetricRequest * _Nonnull)request;
		[Export ("updateCustomMetric:")]
		NSObject UpdateCustomMetric (AWSIoTUpdateCustomMetricRequest request);

		// -(void)updateCustomMetric:(AWSIoTUpdateCustomMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateCustomMetricResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateCustomMetric:completionHandler:")]
		void UpdateCustomMetric (AWSIoTUpdateCustomMetricRequest request, [NullAllowed] Action<AWSIoTUpdateCustomMetricResponse, NSError> completionHandler);

		// -(id)updateDimension:(AWSIoTUpdateDimensionRequest * _Nonnull)request;
		[Export ("updateDimension:")]
		NSObject UpdateDimension (AWSIoTUpdateDimensionRequest request);

		// -(void)updateDimension:(AWSIoTUpdateDimensionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateDimensionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateDimension:completionHandler:")]
		void UpdateDimension (AWSIoTUpdateDimensionRequest request, [NullAllowed] Action<AWSIoTUpdateDimensionResponse, NSError> completionHandler);

		// -(id)updateDomainConfiguration:(AWSIoTUpdateDomainConfigurationRequest * _Nonnull)request;
		[Export ("updateDomainConfiguration:")]
		NSObject UpdateDomainConfiguration (AWSIoTUpdateDomainConfigurationRequest request);

		// -(void)updateDomainConfiguration:(AWSIoTUpdateDomainConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateDomainConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateDomainConfiguration:completionHandler:")]
		void UpdateDomainConfiguration (AWSIoTUpdateDomainConfigurationRequest request, [NullAllowed] Action<AWSIoTUpdateDomainConfigurationResponse, NSError> completionHandler);

		// -(id)updateDynamicThingGroup:(AWSIoTUpdateDynamicThingGroupRequest * _Nonnull)request;
		[Export ("updateDynamicThingGroup:")]
		NSObject UpdateDynamicThingGroup (AWSIoTUpdateDynamicThingGroupRequest request);

		// -(void)updateDynamicThingGroup:(AWSIoTUpdateDynamicThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateDynamicThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateDynamicThingGroup:completionHandler:")]
		void UpdateDynamicThingGroup (AWSIoTUpdateDynamicThingGroupRequest request, [NullAllowed] Action<AWSIoTUpdateDynamicThingGroupResponse, NSError> completionHandler);

		// -(id)updateEventConfigurations:(AWSIoTUpdateEventConfigurationsRequest * _Nonnull)request;
		[Export ("updateEventConfigurations:")]
		NSObject UpdateEventConfigurations (AWSIoTUpdateEventConfigurationsRequest request);

		// -(void)updateEventConfigurations:(AWSIoTUpdateEventConfigurationsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateEventConfigurationsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateEventConfigurations:completionHandler:")]
		void UpdateEventConfigurations (AWSIoTUpdateEventConfigurationsRequest request, [NullAllowed] Action<AWSIoTUpdateEventConfigurationsResponse, NSError> completionHandler);

		// -(id)updateFleetMetric:(AWSIoTUpdateFleetMetricRequest * _Nonnull)request;
		[Export ("updateFleetMetric:")]
		NSObject UpdateFleetMetric (AWSIoTUpdateFleetMetricRequest request);

		// -(void)updateFleetMetric:(AWSIoTUpdateFleetMetricRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("updateFleetMetric:completionHandler:")]
		void UpdateFleetMetric (AWSIoTUpdateFleetMetricRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)updateIndexingConfiguration:(AWSIoTUpdateIndexingConfigurationRequest * _Nonnull)request;
		[Export ("updateIndexingConfiguration:")]
		NSObject UpdateIndexingConfiguration (AWSIoTUpdateIndexingConfigurationRequest request);

		// -(void)updateIndexingConfiguration:(AWSIoTUpdateIndexingConfigurationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateIndexingConfigurationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateIndexingConfiguration:completionHandler:")]
		void UpdateIndexingConfiguration (AWSIoTUpdateIndexingConfigurationRequest request, [NullAllowed] Action<AWSIoTUpdateIndexingConfigurationResponse, NSError> completionHandler);

		// -(id)updateJob:(AWSIoTUpdateJobRequest * _Nonnull)request;
		[Export ("updateJob:")]
		NSObject UpdateJob (AWSIoTUpdateJobRequest request);

		// -(void)updateJob:(AWSIoTUpdateJobRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("updateJob:completionHandler:")]
		void UpdateJob (AWSIoTUpdateJobRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)updateMitigationAction:(AWSIoTUpdateMitigationActionRequest * _Nonnull)request;
		[Export ("updateMitigationAction:")]
		NSObject UpdateMitigationAction (AWSIoTUpdateMitigationActionRequest request);

		// -(void)updateMitigationAction:(AWSIoTUpdateMitigationActionRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateMitigationActionResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateMitigationAction:completionHandler:")]
		void UpdateMitigationAction (AWSIoTUpdateMitigationActionRequest request, [NullAllowed] Action<AWSIoTUpdateMitigationActionResponse, NSError> completionHandler);

		// -(id)updateProvisioningTemplate:(AWSIoTUpdateProvisioningTemplateRequest * _Nonnull)request;
		[Export ("updateProvisioningTemplate:")]
		NSObject UpdateProvisioningTemplate (AWSIoTUpdateProvisioningTemplateRequest request);

		// -(void)updateProvisioningTemplate:(AWSIoTUpdateProvisioningTemplateRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateProvisioningTemplateResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateProvisioningTemplate:completionHandler:")]
		void UpdateProvisioningTemplate (AWSIoTUpdateProvisioningTemplateRequest request, [NullAllowed] Action<AWSIoTUpdateProvisioningTemplateResponse, NSError> completionHandler);

		// -(id)updateRoleAlias:(AWSIoTUpdateRoleAliasRequest * _Nonnull)request;
		[Export ("updateRoleAlias:")]
		NSObject UpdateRoleAlias (AWSIoTUpdateRoleAliasRequest request);

		// -(void)updateRoleAlias:(AWSIoTUpdateRoleAliasRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateRoleAliasResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateRoleAlias:completionHandler:")]
		void UpdateRoleAlias (AWSIoTUpdateRoleAliasRequest request, [NullAllowed] Action<AWSIoTUpdateRoleAliasResponse, NSError> completionHandler);

		// -(id)updateScheduledAudit:(AWSIoTUpdateScheduledAuditRequest * _Nonnull)request;
		[Export ("updateScheduledAudit:")]
		NSObject UpdateScheduledAudit (AWSIoTUpdateScheduledAuditRequest request);

		// -(void)updateScheduledAudit:(AWSIoTUpdateScheduledAuditRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateScheduledAuditResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateScheduledAudit:completionHandler:")]
		void UpdateScheduledAudit (AWSIoTUpdateScheduledAuditRequest request, [NullAllowed] Action<AWSIoTUpdateScheduledAuditResponse, NSError> completionHandler);

		// -(id)updateSecurityProfile:(AWSIoTUpdateSecurityProfileRequest * _Nonnull)request;
		[Export ("updateSecurityProfile:")]
		NSObject UpdateSecurityProfile (AWSIoTUpdateSecurityProfileRequest request);

		// -(void)updateSecurityProfile:(AWSIoTUpdateSecurityProfileRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateSecurityProfileResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateSecurityProfile:completionHandler:")]
		void UpdateSecurityProfile (AWSIoTUpdateSecurityProfileRequest request, [NullAllowed] Action<AWSIoTUpdateSecurityProfileResponse, NSError> completionHandler);

		// -(id)updateStream:(AWSIoTUpdateStreamRequest * _Nonnull)request;
		[Export ("updateStream:")]
		NSObject UpdateStream (AWSIoTUpdateStreamRequest request);

		// -(void)updateStream:(AWSIoTUpdateStreamRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateStreamResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateStream:completionHandler:")]
		void UpdateStream (AWSIoTUpdateStreamRequest request, [NullAllowed] Action<AWSIoTUpdateStreamResponse, NSError> completionHandler);

		// -(id)updateThing:(AWSIoTUpdateThingRequest * _Nonnull)request;
		[Export ("updateThing:")]
		NSObject UpdateThing (AWSIoTUpdateThingRequest request);

		// -(void)updateThing:(AWSIoTUpdateThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateThing:completionHandler:")]
		void UpdateThing (AWSIoTUpdateThingRequest request, [NullAllowed] Action<AWSIoTUpdateThingResponse, NSError> completionHandler);

		// -(id)updateThingGroup:(AWSIoTUpdateThingGroupRequest * _Nonnull)request;
		[Export ("updateThingGroup:")]
		NSObject UpdateThingGroup (AWSIoTUpdateThingGroupRequest request);

		// -(void)updateThingGroup:(AWSIoTUpdateThingGroupRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateThingGroupResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateThingGroup:completionHandler:")]
		void UpdateThingGroup (AWSIoTUpdateThingGroupRequest request, [NullAllowed] Action<AWSIoTUpdateThingGroupResponse, NSError> completionHandler);

		// -(id)updateThingGroupsForThing:(AWSIoTUpdateThingGroupsForThingRequest * _Nonnull)request;
		[Export ("updateThingGroupsForThing:")]
		NSObject UpdateThingGroupsForThing (AWSIoTUpdateThingGroupsForThingRequest request);

		// -(void)updateThingGroupsForThing:(AWSIoTUpdateThingGroupsForThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateThingGroupsForThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateThingGroupsForThing:completionHandler:")]
		void UpdateThingGroupsForThing (AWSIoTUpdateThingGroupsForThingRequest request, [NullAllowed] Action<AWSIoTUpdateThingGroupsForThingResponse, NSError> completionHandler);

		// -(id)updateTopicRuleDestination:(AWSIoTUpdateTopicRuleDestinationRequest * _Nonnull)request;
		[Export ("updateTopicRuleDestination:")]
		NSObject UpdateTopicRuleDestination (AWSIoTUpdateTopicRuleDestinationRequest request);

		// -(void)updateTopicRuleDestination:(AWSIoTUpdateTopicRuleDestinationRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTUpdateTopicRuleDestinationResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateTopicRuleDestination:completionHandler:")]
		void UpdateTopicRuleDestination (AWSIoTUpdateTopicRuleDestinationRequest request, [NullAllowed] Action<AWSIoTUpdateTopicRuleDestinationResponse, NSError> completionHandler);

		// -(id)validateSecurityProfileBehaviors:(AWSIoTValidateSecurityProfileBehaviorsRequest * _Nonnull)request;
		[Export ("validateSecurityProfileBehaviors:")]
		NSObject ValidateSecurityProfileBehaviors (AWSIoTValidateSecurityProfileBehaviorsRequest request);

		// -(void)validateSecurityProfileBehaviors:(AWSIoTValidateSecurityProfileBehaviorsRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTValidateSecurityProfileBehaviorsResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("validateSecurityProfileBehaviors:completionHandler:")]
		void ValidateSecurityProfileBehaviors (AWSIoTValidateSecurityProfileBehaviorsRequest request, [NullAllowed] Action<AWSIoTValidateSecurityProfileBehaviorsResponse, NSError> completionHandler);
	}

	// @interface AWSIoTCreateCertificateResponse
	interface AWSIoTCreateCertificateResponse
	{
		// @property (nonatomic, strong) NSString * certificateArn;
		[Export ("certificateArn", ArgumentSemantic.Strong)]
		string CertificateArn { get; set; }

		// @property (nonatomic, strong) NSString * certificateId;
		[Export ("certificateId", ArgumentSemantic.Strong)]
		string CertificateId { get; set; }

		// @property (nonatomic, strong) NSString * certificatePem;
		[Export ("certificatePem", ArgumentSemantic.Strong)]
		string CertificatePem { get; set; }
	}

	// @interface AWSIoTManager
	interface AWSIoTManager
	{
		// @property (readonly, nonatomic, strong) int * configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		unsafe int* Configuration { get; }

		// @property (assign, nonatomic, class) BOOL tagCertificateEnabled;
		[Static]
		[Export ("tagCertificateEnabled")]
		bool TagCertificateEnabled { get; set; }

		// +(instancetype)defaultIoTManager;
		[Static]
		[Export ("defaultIoTManager")]
		AWSIoTManager DefaultIoTManager ();

		// +(void)registerIoTManagerWithConfiguration:(id)configuration forKey:(NSString *)key;
		[Static]
		[Export ("registerIoTManagerWithConfiguration:forKey:")]
		void RegisterIoTManagerWithConfiguration (NSObject configuration, string key);

		// +(instancetype)IoTManagerForKey:(NSString *)key;
		[Static]
		[Export ("IoTManagerForKey:")]
		AWSIoTManager IoTManagerForKey (string key);

		// +(void)removeIoTManagerForKey:(NSString *)key;
		[Static]
		[Export ("removeIoTManagerForKey:")]
		void RemoveIoTManagerForKey (string key);

		// -(void)createKeysAndCertificateFromCsr:(NSDictionary<NSString *,NSString *> *)csrDictionary callback:(void (^)(AWSIoTCreateCertificateResponse *))callback;
		[Export ("createKeysAndCertificateFromCsr:callback:")]
		void CreateKeysAndCertificateFromCsr (NSDictionary<NSString, NSString> csrDictionary, Action<AWSIoTCreateCertificateResponse> callback);

		// +(BOOL)importIdentityFromPKCS12Data:(NSData *)pkcs12Data passPhrase:(NSString *)passPhrase certificateId:(NSString *)certificateId;
		[Static]
		[Export ("importIdentityFromPKCS12Data:passPhrase:certificateId:")]
		bool ImportIdentityFromPKCS12Data (NSData pkcs12Data, string passPhrase, string certificateId);

		// +(BOOL)isValidCertificate:(NSString *)certificateId;
		[Static]
		[Export ("isValidCertificate:")]
		bool IsValidCertificate (string certificateId);

		// +(BOOL)deleteCertificate;
		[Static]
		[Export ("deleteCertificate")]
		[Verify (MethodToProperty)]
		bool DeleteCertificate { get; }

		// +(BOOL)deleteCertificateWithCertificateId:(NSString *)certificateId __attribute__((swift_name("deleteCertificate(certificateId:)")));
		[Static]
		[Export ("deleteCertificateWithCertificateId:")]
		bool DeleteCertificateWithCertificateId (string certificateId);

		// +(void)setKeyChainAccessibility:(AWSIoTKeyChainAccessibility)accessibility;
		[Static]
		[Export ("setKeyChainAccessibility:")]
		void SetKeyChainAccessibility (AWSIoTKeyChainAccessibility accessibility);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double AWSIoTDataVersionNumber __attribute__((deprecated("Use AWSIoTDataSDKVersion instead.")));
		[Field ("AWSIoTDataVersionNumber", "__Internal")]
		double AWSIoTDataVersionNumber { get; }

		// extern const unsigned char[] AWSIoTDataVersionString __attribute__((deprecated("Use AWSIoTDataSDKVersion instead.")));
		[Field ("AWSIoTDataVersionString", "__Internal")]
		byte[] AWSIoTDataVersionString { get; }

		// extern NSString *const _Nonnull AWSIoTDataErrorDomain;
		[Field ("AWSIoTDataErrorDomain", "__Internal")]
		NSString AWSIoTDataErrorDomain { get; }
	}

	// @interface AWSIoTDataDeleteThingShadowRequest
	interface AWSIoTDataDeleteThingShadowRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable shadowName;
		[NullAllowed, Export ("shadowName", ArgumentSemantic.Strong)]
		string ShadowName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDataDeleteThingShadowResponse
	interface AWSIoTDataDeleteThingShadowResponse
	{
		// @property (nonatomic, strong) id _Nullable payload;
		[NullAllowed, Export ("payload", ArgumentSemantic.Strong)]
		NSObject Payload { get; set; }
	}

	// @interface AWSIoTDataGetRetainedMessageRequest
	interface AWSIoTDataGetRetainedMessageRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable topic;
		[NullAllowed, Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }
	}

	// @interface AWSIoTDataGetRetainedMessageResponse
	interface AWSIoTDataGetRetainedMessageResponse
	{
		// @property (nonatomic, strong) NSNumber * _Nullable lastModifiedTime;
		[NullAllowed, Export ("lastModifiedTime", ArgumentSemantic.Strong)]
		NSNumber LastModifiedTime { get; set; }

		// @property (nonatomic, strong) id _Nullable payload;
		[NullAllowed, Export ("payload", ArgumentSemantic.Strong)]
		NSObject Payload { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable qos;
		[NullAllowed, Export ("qos", ArgumentSemantic.Strong)]
		NSNumber Qos { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable topic;
		[NullAllowed, Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }
	}

	// @interface AWSIoTDataGetThingShadowRequest
	interface AWSIoTDataGetThingShadowRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable shadowName;
		[NullAllowed, Export ("shadowName", ArgumentSemantic.Strong)]
		string ShadowName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDataGetThingShadowResponse
	interface AWSIoTDataGetThingShadowResponse
	{
		// @property (nonatomic, strong) id _Nullable payload;
		[NullAllowed, Export ("payload", ArgumentSemantic.Strong)]
		NSObject Payload { get; set; }
	}

	// @interface AWSIoTDataListNamedShadowsForThingRequest
	interface AWSIoTDataListNamedShadowsForThingRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pageSize;
		[NullAllowed, Export ("pageSize", ArgumentSemantic.Strong)]
		NSNumber PageSize { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDataListNamedShadowsForThingResponse
	interface AWSIoTDataListNamedShadowsForThingResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable results;
		[NullAllowed, Export ("results", ArgumentSemantic.Strong)]
		string[] Results { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Strong)]
		NSNumber Timestamp { get; set; }
	}

	// @interface AWSIoTDataListRetainedMessagesRequest
	interface AWSIoTDataListRetainedMessagesRequest
	{
		// @property (nonatomic, strong) NSNumber * _Nullable maxResults;
		[NullAllowed, Export ("maxResults", ArgumentSemantic.Strong)]
		NSNumber MaxResults { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }
	}

	// @interface AWSIoTDataListRetainedMessagesResponse
	interface AWSIoTDataListRetainedMessagesResponse
	{
		// @property (nonatomic, strong) NSString * _Nullable nextToken;
		[NullAllowed, Export ("nextToken", ArgumentSemantic.Strong)]
		string NextToken { get; set; }

		// @property (nonatomic, strong) NSArray<AWSIoTDataRetainedMessageSummary *> * _Nullable retainedTopics;
		[NullAllowed, Export ("retainedTopics", ArgumentSemantic.Strong)]
		AWSIoTDataRetainedMessageSummary[] RetainedTopics { get; set; }
	}

	// @interface AWSIoTDataPublishRequest
	interface AWSIoTDataPublishRequest
	{
		// @property (nonatomic, strong) NSString * _Nullable contentType;
		[NullAllowed, Export ("contentType", ArgumentSemantic.Strong)]
		string ContentType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable correlationData;
		[NullAllowed, Export ("correlationData", ArgumentSemantic.Strong)]
		string CorrelationData { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable messageExpiry;
		[NullAllowed, Export ("messageExpiry", ArgumentSemantic.Strong)]
		NSNumber MessageExpiry { get; set; }

		// @property (nonatomic, strong) id _Nullable payload;
		[NullAllowed, Export ("payload", ArgumentSemantic.Strong)]
		NSObject Payload { get; set; }

		// @property (assign, nonatomic) AWSIoTDataPayloadFormatIndicator payloadFormatIndicator;
		[Export ("payloadFormatIndicator", ArgumentSemantic.Assign)]
		AWSIoTDataPayloadFormatIndicator PayloadFormatIndicator { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable qos;
		[NullAllowed, Export ("qos", ArgumentSemantic.Strong)]
		NSNumber Qos { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable responseTopic;
		[NullAllowed, Export ("responseTopic", ArgumentSemantic.Strong)]
		string ResponseTopic { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable retainValue;
		[NullAllowed, Export ("retainValue", ArgumentSemantic.Strong)]
		NSNumber RetainValue { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable topic;
		[NullAllowed, Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable userProperties;
		[NullAllowed, Export ("userProperties", ArgumentSemantic.Strong)]
		string UserProperties { get; set; }
	}

	// @interface AWSIoTDataRetainedMessageSummary
	interface AWSIoTDataRetainedMessageSummary
	{
		// @property (nonatomic, strong) NSNumber * _Nullable lastModifiedTime;
		[NullAllowed, Export ("lastModifiedTime", ArgumentSemantic.Strong)]
		NSNumber LastModifiedTime { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable payloadSize;
		[NullAllowed, Export ("payloadSize", ArgumentSemantic.Strong)]
		NSNumber PayloadSize { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable qos;
		[NullAllowed, Export ("qos", ArgumentSemantic.Strong)]
		NSNumber Qos { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable topic;
		[NullAllowed, Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }
	}

	// @interface AWSIoTDataUpdateThingShadowRequest
	interface AWSIoTDataUpdateThingShadowRequest
	{
		// @property (nonatomic, strong) id _Nullable payload;
		[NullAllowed, Export ("payload", ArgumentSemantic.Strong)]
		NSObject Payload { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable shadowName;
		[NullAllowed, Export ("shadowName", ArgumentSemantic.Strong)]
		string ShadowName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable thingName;
		[NullAllowed, Export ("thingName", ArgumentSemantic.Strong)]
		string ThingName { get; set; }
	}

	// @interface AWSIoTDataUpdateThingShadowResponse
	interface AWSIoTDataUpdateThingShadowResponse
	{
		// @property (nonatomic, strong) id _Nullable payload;
		[NullAllowed, Export ("payload", ArgumentSemantic.Strong)]
		NSObject Payload { get; set; }
	}

	// @interface AWSIoTDataResources : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSIoTDataResources
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		AWSIoTDataResources SharedInstance ();

		// -(NSDictionary *)JSONObject;
		[Export ("JSONObject")]
		[Verify (MethodToProperty)]
		NSDictionary JSONObject { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AWSIoTDataSDKVersion;
		[Field ("AWSIoTDataSDKVersion", "__Internal")]
		NSString AWSIoTDataSDKVersion { get; }
	}

	// @interface AWSIoTData
	interface AWSIoTData
	{
		// @property (readonly, nonatomic, strong) int * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		unsafe int* Configuration { get; }

		// +(instancetype _Nonnull)defaultIoTData;
		[Static]
		[Export ("defaultIoTData")]
		AWSIoTData DefaultIoTData ();

		// +(void)registerIoTDataWithConfiguration:(id)configuration forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("registerIoTDataWithConfiguration:forKey:")]
		void RegisterIoTDataWithConfiguration (NSObject configuration, string key);

		// +(instancetype _Nonnull)IoTDataForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("IoTDataForKey:")]
		AWSIoTData IoTDataForKey (string key);

		// +(void)removeIoTDataForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("removeIoTDataForKey:")]
		void RemoveIoTDataForKey (string key);

		// -(id)deleteThingShadow:(AWSIoTDataDeleteThingShadowRequest * _Nonnull)request;
		[Export ("deleteThingShadow:")]
		NSObject DeleteThingShadow (AWSIoTDataDeleteThingShadowRequest request);

		// -(void)deleteThingShadow:(AWSIoTDataDeleteThingShadowRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDataDeleteThingShadowResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("deleteThingShadow:completionHandler:")]
		void DeleteThingShadow (AWSIoTDataDeleteThingShadowRequest request, [NullAllowed] Action<AWSIoTDataDeleteThingShadowResponse, NSError> completionHandler);

		// -(id)getRetainedMessage:(AWSIoTDataGetRetainedMessageRequest * _Nonnull)request;
		[Export ("getRetainedMessage:")]
		NSObject GetRetainedMessage (AWSIoTDataGetRetainedMessageRequest request);

		// -(void)getRetainedMessage:(AWSIoTDataGetRetainedMessageRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDataGetRetainedMessageResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getRetainedMessage:completionHandler:")]
		void GetRetainedMessage (AWSIoTDataGetRetainedMessageRequest request, [NullAllowed] Action<AWSIoTDataGetRetainedMessageResponse, NSError> completionHandler);

		// -(id)getThingShadow:(AWSIoTDataGetThingShadowRequest * _Nonnull)request;
		[Export ("getThingShadow:")]
		NSObject GetThingShadow (AWSIoTDataGetThingShadowRequest request);

		// -(void)getThingShadow:(AWSIoTDataGetThingShadowRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDataGetThingShadowResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("getThingShadow:completionHandler:")]
		void GetThingShadow (AWSIoTDataGetThingShadowRequest request, [NullAllowed] Action<AWSIoTDataGetThingShadowResponse, NSError> completionHandler);

		// -(id)listNamedShadowsForThing:(AWSIoTDataListNamedShadowsForThingRequest * _Nonnull)request;
		[Export ("listNamedShadowsForThing:")]
		NSObject ListNamedShadowsForThing (AWSIoTDataListNamedShadowsForThingRequest request);

		// -(void)listNamedShadowsForThing:(AWSIoTDataListNamedShadowsForThingRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDataListNamedShadowsForThingResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listNamedShadowsForThing:completionHandler:")]
		void ListNamedShadowsForThing (AWSIoTDataListNamedShadowsForThingRequest request, [NullAllowed] Action<AWSIoTDataListNamedShadowsForThingResponse, NSError> completionHandler);

		// -(id)listRetainedMessages:(AWSIoTDataListRetainedMessagesRequest * _Nonnull)request;
		[Export ("listRetainedMessages:")]
		NSObject ListRetainedMessages (AWSIoTDataListRetainedMessagesRequest request);

		// -(void)listRetainedMessages:(AWSIoTDataListRetainedMessagesRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDataListRetainedMessagesResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("listRetainedMessages:completionHandler:")]
		void ListRetainedMessages (AWSIoTDataListRetainedMessagesRequest request, [NullAllowed] Action<AWSIoTDataListRetainedMessagesResponse, NSError> completionHandler);

		// -(id)publish:(AWSIoTDataPublishRequest * _Nonnull)request;
		[Export ("publish:")]
		NSObject Publish (AWSIoTDataPublishRequest request);

		// -(void)publish:(AWSIoTDataPublishRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("publish:completionHandler:")]
		void Publish (AWSIoTDataPublishRequest request, [NullAllowed] Action<NSError> completionHandler);

		// -(id)updateThingShadow:(AWSIoTDataUpdateThingShadowRequest * _Nonnull)request;
		[Export ("updateThingShadow:")]
		NSObject UpdateThingShadow (AWSIoTDataUpdateThingShadowRequest request);

		// -(void)updateThingShadow:(AWSIoTDataUpdateThingShadowRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSIoTDataUpdateThingShadowResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("updateThingShadow:completionHandler:")]
		void UpdateThingShadow (AWSIoTDataUpdateThingShadowRequest request, [NullAllowed] Action<AWSIoTDataUpdateThingShadowResponse, NSError> completionHandler);
	}

	// typedef void (^AWSIoTMQTTNewMessageBlock)(NSData * _Nonnull);
	delegate void AWSIoTMQTTNewMessageBlock (NSData arg0);

	// typedef void (^AWSIoTMQTTExtendedNewMessageBlock)(NSObject * _Nonnull, NSString * _Nonnull, NSData * _Nonnull);
	delegate void AWSIoTMQTTExtendedNewMessageBlock (NSObject arg0, string arg1, NSData arg2);

	// typedef void (^AWSIoTMQTTFullMessageBlock)(NSString * _Nonnull, AWSIoTMessage * _Nonnull);
	delegate void AWSIoTMQTTFullMessageBlock (string arg0, AWSIoTMessage arg1);

	// typedef void (^AWSIoTMQTTAckBlock)();
	delegate void AWSIoTMQTTAckBlock ();

	// @interface AWSIoTMQTTLastWillAndTestament : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSIoTMQTTLastWillAndTestament
	{
		// @property (nonatomic, strong) NSString * _Nonnull topic;
		[Export ("topic", ArgumentSemantic.Strong)]
		string Topic { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull message;
		[Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (assign, nonatomic) AWSIoTMQTTQoS qos;
		[Export ("qos", ArgumentSemantic.Assign)]
		AWSIoTMQTTQoS Qos { get; set; }

		// @property (assign, nonatomic) BOOL willRetain;
		[Export ("willRetain")]
		bool WillRetain { get; set; }
	}

	// @interface AWSIoTMQTTConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSIoTMQTTConfiguration
	{
		// @property (readonly, assign, nonatomic) NSTimeInterval baseReconnectTimeInterval;
		[Export ("baseReconnectTimeInterval")]
		double BaseReconnectTimeInterval { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval minimumConnectionTimeInterval;
		[Export ("minimumConnectionTimeInterval")]
		double MinimumConnectionTimeInterval { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval maximumReconnectTimeInterval;
		[Export ("maximumReconnectTimeInterval")]
		double MaximumReconnectTimeInterval { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval keepAliveTimeInterval;
		[Export ("keepAliveTimeInterval")]
		double KeepAliveTimeInterval { get; }

		// @property (readonly, atomic, strong) AWSIoTMQTTLastWillAndTestament * _Nonnull lastWillAndTestament;
		[Export ("lastWillAndTestament", ArgumentSemantic.Strong)]
		AWSIoTMQTTLastWillAndTestament LastWillAndTestament { get; }

		// @property (readonly, atomic, strong) NSRunLoop * _Nonnull runLoop;
		[Export ("runLoop", ArgumentSemantic.Strong)]
		NSRunLoop RunLoop { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull runLoopMode;
		[Export ("runLoopMode", ArgumentSemantic.Strong)]
		string RunLoopMode { get; }

		// @property (readonly, assign, nonatomic) BOOL autoResubscribe;
		[Export ("autoResubscribe")]
		bool AutoResubscribe { get; }

		// @property (readonly, assign, nonatomic) NSUInteger publishRetryThrottle;
		[Export ("publishRetryThrottle")]
		nuint PublishRetryThrottle { get; }

		// @property (copy, nonatomic) NSString * _Nonnull username;
		[Export ("username")]
		string Username { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull password;
		[Export ("password")]
		string Password { get; set; }

		// -(instancetype _Nonnull)initWithKeepAliveTimeInterval:(NSTimeInterval)kat baseReconnectTimeInterval:(NSTimeInterval)brt minimumConnectionTimeInterval:(NSTimeInterval)mct maximumReconnectTimeInterval:(NSTimeInterval)mrt runLoop:(NSRunLoop * _Nonnull)rlp runLoopMode:(NSString * _Nonnull)rlm autoResubscribe:(BOOL)ars lastWillAndTestament:(AWSIoTMQTTLastWillAndTestament * _Nonnull)lwt;
		[Export ("initWithKeepAliveTimeInterval:baseReconnectTimeInterval:minimumConnectionTimeInterval:maximumReconnectTimeInterval:runLoop:runLoopMode:autoResubscribe:lastWillAndTestament:")]
		NativeHandle Constructor (double kat, double brt, double mct, double mrt, NSRunLoop rlp, string rlm, bool ars, AWSIoTMQTTLastWillAndTestament lwt);

		// -(instancetype _Nonnull)initWithKeepAliveTimeInterval:(NSTimeInterval)kat baseReconnectTimeInterval:(NSTimeInterval)brt minimumConnectionTimeInterval:(NSTimeInterval)mct maximumReconnectTimeInterval:(NSTimeInterval)mrt runLoop:(NSRunLoop * _Nonnull)rlp runLoopMode:(NSString * _Nonnull)rlm autoResubscribe:(BOOL)ars lastWillAndTestament:(AWSIoTMQTTLastWillAndTestament * _Nonnull)lwt publishRetryThrottle:(NSUInteger)prt;
		[Export ("initWithKeepAliveTimeInterval:baseReconnectTimeInterval:minimumConnectionTimeInterval:maximumReconnectTimeInterval:runLoop:runLoopMode:autoResubscribe:lastWillAndTestament:publishRetryThrottle:")]
		NativeHandle Constructor (double kat, double brt, double mct, double mrt, NSRunLoop rlp, string rlm, bool ars, AWSIoTMQTTLastWillAndTestament lwt, nuint prt);
	}

	// @interface AWSIoTDataManager
	interface AWSIoTDataManager
	{
		// @property (readonly, nonatomic, strong) int * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		unsafe int* Configuration { get; }

		// @property (readonly, nonatomic, strong) AWSIoTMQTTConfiguration * _Nonnull mqttConfiguration;
		[Export ("mqttConfiguration", ArgumentSemantic.Strong)]
		AWSIoTMQTTConfiguration MqttConfiguration { get; }

		// +(instancetype _Nonnull)defaultIoTDataManager __attribute__((deprecated("Use `registerIoTDataManagerWithConfiguration:forKey:` with the custom endpoint to initialize AWSIoTDataManager")));
		[Static]
		[Export ("defaultIoTDataManager")]
		AWSIoTDataManager DefaultIoTDataManager ();

		// +(void)registerIoTDataManagerWithConfiguration:(id)configuration forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("registerIoTDataManagerWithConfiguration:forKey:")]
		void RegisterIoTDataManagerWithConfiguration (NSObject configuration, string key);

		// +(void)registerIoTDataManagerWithConfiguration:(id)configuration withMQTTConfiguration:(AWSIoTMQTTConfiguration * _Nonnull)mqttConfig forKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("registerIoTDataManagerWithConfiguration:withMQTTConfiguration:forKey:")]
		void RegisterIoTDataManagerWithConfiguration (NSObject configuration, AWSIoTMQTTConfiguration mqttConfig, string key);

		// +(instancetype _Nonnull)IoTDataManagerForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("IoTDataManagerForKey:")]
		AWSIoTDataManager IoTDataManagerForKey (string key);

		// +(void)removeIoTDataManagerForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("removeIoTDataManagerForKey:")]
		void RemoveIoTDataManagerForKey (string key);

		// -(void)enableMetricsCollection:(BOOL)enabled;
		[Export ("enableMetricsCollection:")]
		void EnableMetricsCollection (bool enabled);

		// -(void)addUserMetaData:(NSDictionary<NSString *,NSString *> * _Nonnull)userMetaData __attribute__((deprecated("Use `updateUserMetaData` for updating the user meta data")));
		[Export ("addUserMetaData:")]
		void AddUserMetaData (NSDictionary<NSString, NSString> userMetaData);

		// -(void)updateUserMetaData:(NSDictionary<NSString *,NSString *> * _Nonnull)userMetaData;
		[Export ("updateUserMetaData:")]
		void UpdateUserMetaData (NSDictionary<NSString, NSString> userMetaData);

		// -(BOOL)connectWithClientId:(NSString * _Nonnull)clientId cleanSession:(BOOL)cleanSession certificateId:(NSString * _Nonnull)certificateId statusCallback:(void (^ _Nonnull)(AWSIoTMQTTStatus))callback;
		[Export ("connectWithClientId:cleanSession:certificateId:statusCallback:")]
		bool ConnectWithClientId (string clientId, bool cleanSession, string certificateId, Action<AWSIoTMQTTStatus> callback);

		// -(BOOL)connectUsingALPNWithClientId:(NSString * _Nonnull)clientId cleanSession:(BOOL)cleanSession certificateId:(NSString * _Nonnull)certificateId statusCallback:(void (^ _Nonnull)(AWSIoTMQTTStatus))callback __attribute__((availability(ios, introduced=11))) __attribute__((availability(macos, introduced=10.13)));
		[Mac (10,13), iOS (11,0)]
		[Export ("connectUsingALPNWithClientId:cleanSession:certificateId:statusCallback:")]
		bool ConnectUsingALPNWithClientId (string clientId, bool cleanSession, string certificateId, Action<AWSIoTMQTTStatus> callback);

		// -(BOOL)connectUsingWebSocketWithClientId:(NSString * _Nonnull)clientId cleanSession:(BOOL)cleanSession statusCallback:(void (^ _Nonnull)(AWSIoTMQTTStatus))callback;
		[Export ("connectUsingWebSocketWithClientId:cleanSession:statusCallback:")]
		bool ConnectUsingWebSocketWithClientId (string clientId, bool cleanSession, Action<AWSIoTMQTTStatus> callback);

		// -(BOOL)connectUsingWebSocketWithClientId:(NSString * _Nonnull)clientId cleanSession:(BOOL)cleanSession customAuthorizerName:(NSString * _Nonnull)customAuthorizerName tokenKeyName:(NSString * _Nonnull)tokenKeyName tokenValue:(NSString * _Nonnull)tokenValue tokenSignature:(NSString * _Nonnull)tokenSignature statusCallback:(void (^ _Nonnull)(AWSIoTMQTTStatus))callback;
		[Export ("connectUsingWebSocketWithClientId:cleanSession:customAuthorizerName:tokenKeyName:tokenValue:tokenSignature:statusCallback:")]
		bool ConnectUsingWebSocketWithClientId (string clientId, bool cleanSession, string customAuthorizerName, string tokenKeyName, string tokenValue, string tokenSignature, Action<AWSIoTMQTTStatus> callback);

		// -(void)disconnect;
		[Export ("disconnect")]
		void Disconnect ();

		// -(AWSIoTMQTTStatus)getConnectionStatus;
		[Export ("getConnectionStatus")]
		[Verify (MethodToProperty)]
		AWSIoTMQTTStatus ConnectionStatus { get; }

		// -(BOOL)publishString:(NSString * _Nonnull)string onTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos;
		[Export ("publishString:onTopic:QoS:")]
		bool PublishString (string @string, string topic, AWSIoTMQTTQoS qos);

		// -(BOOL)publishString:(NSString * _Nonnull)string onTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos ackCallback:(AWSIoTMQTTAckBlock _Nullable)ackCallback;
		[Export ("publishString:onTopic:QoS:ackCallback:")]
		bool PublishString (string @string, string topic, AWSIoTMQTTQoS qos, [NullAllowed] AWSIoTMQTTAckBlock ackCallback);

		// -(BOOL)publishData:(NSData * _Nonnull)data onTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos;
		[Export ("publishData:onTopic:QoS:")]
		bool PublishData (NSData data, string topic, AWSIoTMQTTQoS qos);

		// -(BOOL)publishData:(NSData * _Nonnull)data onTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos ackCallback:(AWSIoTMQTTAckBlock _Nullable)ackCallback;
		[Export ("publishData:onTopic:QoS:ackCallback:")]
		bool PublishData (NSData data, string topic, AWSIoTMQTTQoS qos, [NullAllowed] AWSIoTMQTTAckBlock ackCallback);

		// -(BOOL)publishData:(NSData * _Nonnull)data onTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos retain:(BOOL)retain ackCallback:(AWSIoTMQTTAckBlock _Nullable)ackCallback;
		[Export ("publishData:onTopic:QoS:retain:ackCallback:")]
		bool PublishData (NSData data, string topic, AWSIoTMQTTQoS qos, bool retain, [NullAllowed] AWSIoTMQTTAckBlock ackCallback);

		// -(BOOL)subscribeToTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos messageCallback:(AWSIoTMQTTNewMessageBlock _Nonnull)callback;
		[Export ("subscribeToTopic:QoS:messageCallback:")]
		bool SubscribeToTopic (string topic, AWSIoTMQTTQoS qos, AWSIoTMQTTNewMessageBlock callback);

		// -(BOOL)subscribeToTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos messageCallback:(AWSIoTMQTTNewMessageBlock _Nonnull)callback ackCallback:(AWSIoTMQTTAckBlock _Nullable)ackCallback;
		[Export ("subscribeToTopic:QoS:messageCallback:ackCallback:")]
		bool SubscribeToTopic (string topic, AWSIoTMQTTQoS qos, AWSIoTMQTTNewMessageBlock callback, [NullAllowed] AWSIoTMQTTAckBlock ackCallback);

		// -(BOOL)subscribeToTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos extendedCallback:(AWSIoTMQTTExtendedNewMessageBlock _Nonnull)callback;
		[Export ("subscribeToTopic:QoS:extendedCallback:")]
		bool SubscribeToTopic (string topic, AWSIoTMQTTQoS qos, AWSIoTMQTTExtendedNewMessageBlock callback);

		// -(BOOL)subscribeToTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos extendedCallback:(AWSIoTMQTTExtendedNewMessageBlock _Nonnull)callback ackCallback:(AWSIoTMQTTAckBlock _Nullable)ackCallback;
		[Export ("subscribeToTopic:QoS:extendedCallback:ackCallback:")]
		bool SubscribeToTopic (string topic, AWSIoTMQTTQoS qos, AWSIoTMQTTExtendedNewMessageBlock callback, [NullAllowed] AWSIoTMQTTAckBlock ackCallback);

		// -(BOOL)subscribeToTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos fullCallback:(AWSIoTMQTTFullMessageBlock _Nonnull)callback;
		[Export ("subscribeToTopic:QoS:fullCallback:")]
		bool SubscribeToTopic (string topic, AWSIoTMQTTQoS qos, AWSIoTMQTTFullMessageBlock callback);

		// -(BOOL)subscribeToTopic:(NSString * _Nonnull)topic QoS:(AWSIoTMQTTQoS)qos fullCallback:(AWSIoTMQTTFullMessageBlock _Nonnull)callback ackCallback:(AWSIoTMQTTAckBlock _Nullable)ackCallback;
		[Export ("subscribeToTopic:QoS:fullCallback:ackCallback:")]
		bool SubscribeToTopic (string topic, AWSIoTMQTTQoS qos, AWSIoTMQTTFullMessageBlock callback, [NullAllowed] AWSIoTMQTTAckBlock ackCallback);

		// -(void)unsubscribeTopic:(NSString * _Nonnull)topic;
		[Export ("unsubscribeTopic:")]
		void UnsubscribeTopic (string topic);

		// -(BOOL)registerWithShadow:(NSString * _Nonnull)name options:(NSDictionary<NSString *,NSNumber *> * _Nullable)options eventCallback:(void (^ _Nonnull)(NSString * _Nonnull, AWSIoTShadowOperationType, AWSIoTShadowOperationStatusType, NSString * _Nonnull, NSData * _Nonnull))callback;
		[Export ("registerWithShadow:options:eventCallback:")]
		bool RegisterWithShadow (string name, [NullAllowed] NSDictionary<NSString, NSNumber> options, Action<NSString, AWSIoTShadowOperationType, AWSIoTShadowOperationStatusType, NSString, NSData> callback);

		// -(BOOL)unregisterFromShadow:(NSString * _Nonnull)name;
		[Export ("unregisterFromShadow:")]
		bool UnregisterFromShadow (string name);

		// -(BOOL)updateShadow:(NSString * _Nonnull)name jsonString:(NSString * _Nonnull)jsonString;
		[Export ("updateShadow:jsonString:")]
		bool UpdateShadow (string name, string jsonString);

		// -(BOOL)updateShadow:(NSString * _Nonnull)name jsonString:(NSString * _Nonnull)jsonString clientToken:(NSString * _Nullable)clientToken;
		[Export ("updateShadow:jsonString:clientToken:")]
		bool UpdateShadow (string name, string jsonString, [NullAllowed] string clientToken);

		// -(BOOL)getShadow:(NSString * _Nonnull)name;
		[Export ("getShadow:")]
		bool GetShadow (string name);

		// -(BOOL)getShadow:(NSString * _Nonnull)name clientToken:(NSString * _Nullable)clientToken;
		[Export ("getShadow:clientToken:")]
		bool GetShadow (string name, [NullAllowed] string clientToken);

		// -(BOOL)deleteShadow:(NSString * _Nonnull)name;
		[Export ("deleteShadow:")]
		bool DeleteShadow (string name);

		// -(BOOL)deleteShadow:(NSString * _Nonnull)name clientToken:(NSString * _Nullable)clientToken;
		[Export ("deleteShadow:clientToken:")]
		bool DeleteShadow (string name, [NullAllowed] string clientToken);
	}

	// @interface AWSIoTMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface AWSIoTMessage
	{
		// @property (assign) AWSIoTMQTTMessageType type;
		[Export ("type", ArgumentSemantic.Assign)]
		AWSIoTMQTTMessageType Type { get; set; }

		// @property (assign) AWSIoTMQTTQoS qos;
		[Export ("qos", ArgumentSemantic.Assign)]
		AWSIoTMQTTQoS Qos { get; set; }

		// @property (assign) BOOL retainFlag;
		[Export ("retainFlag")]
		bool RetainFlag { get; set; }

		// @property (assign) BOOL isDuplicate;
		[Export ("isDuplicate")]
		bool IsDuplicate { get; set; }

		// @property (copy, nonatomic) NSData * _Nonnull rawData;
		[Export ("rawData", ArgumentSemantic.Copy)]
		NSData RawData { get; set; }

		// @property (copy, nonatomic) NSData * _Nonnull messageData;
		[Export ("messageData", ArgumentSemantic.Copy)]
		NSData MessageData { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull topic;
		[Export ("topic")]
		string Topic { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; set; }
	}
}
