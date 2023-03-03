using ObjCRuntime;

namespace AWSIoT
{
	[Native]
	public enum AWSIoTErrorType : long
	{
		Unknown,
		CertificateConflict,
		CertificateState,
		CertificateValidation,
		Conflict,
		ConflictingResourceUpdate,
		DeleteConflict,
		IndexNotReady,
		Internal,
		InternalFailure,
		InternalServer,
		InvalidAggregation,
		InvalidQuery,
		InvalidRequest,
		InvalidResponse,
		InvalidStateTransition,
		LimitExceeded,
		MalformedPolicy,
		NotConfigured,
		RegistrationCodeValidation,
		ResourceAlreadyExists,
		ResourceNotFound,
		ResourceRegistrationFailure,
		ServiceUnavailable,
		SqlParse,
		TaskAlreadyExists,
		Throttling,
		TransferAlreadyCompleted,
		TransferConflict,
		Unauthorized,
		VersionConflict,
		VersionsLimitExceeded
	}

	[Native]
	public enum AWSIoTAbortAction : long
	{
		Unknown,
		Cancel
	}

	[Native]
	public enum AWSIoTActionType : long
	{
		Unknown,
		Publish,
		Subscribe,
		Receive,
		Connect
	}

	[Native]
	public enum AWSIoTAggregationTypeName : long
	{
		Unknown,
		Statistics,
		Percentiles,
		Cardinality
	}

	[Native]
	public enum AWSIoTAlertTargetType : long
	{
		Unknown,
		Sns
	}

	[Native]
	public enum AWSIoTAuditCheckRunStatus : long
	{
		Unknown,
		InProgress,
		WaitingForDataCollection,
		Canceled,
		CompletedCompliant,
		CompletedNonCompliant,
		Failed
	}

	[Native]
	public enum AWSIoTAuditFindingSeverity : long
	{
		Unknown,
		Critical,
		High,
		Medium,
		Low
	}

	[Native]
	public enum AWSIoTAuditFrequency : long
	{
		Unknown,
		Daily,
		Weekly,
		Biweekly,
		Monthly
	}

	[Native]
	public enum AWSIoTAuditMitigationActionsExecutionStatus : long
	{
		Unknown,
		InProgress,
		Completed,
		Failed,
		Canceled,
		Skipped,
		Pending
	}

	[Native]
	public enum AWSIoTAuditMitigationActionsTaskStatus : long
	{
		Unknown,
		InProgress,
		Completed,
		Failed,
		Canceled
	}

	[Native]
	public enum AWSIoTAuditNotificationType : long
	{
		Unknown,
		Sns
	}

	[Native]
	public enum AWSIoTAuditTaskStatus : long
	{
		Unknown,
		InProgress,
		Completed,
		Failed,
		Canceled
	}

	[Native]
	public enum AWSIoTAuditTaskType : long
	{
		Unknown,
		OnDemandAuditTask,
		ScheduledAuditTask
	}

	[Native]
	public enum AWSIoTAuthDecision : long
	{
		Unknown,
		Allowed,
		ExplicitDeny,
		ImplicitDeny
	}

	[Native]
	public enum AWSIoTAuthorizerStatus : long
	{
		Unknown,
		Active,
		Inactive
	}

	[Native]
	public enum AWSIoTAutoRegistrationStatus : long
	{
		Unknown,
		Enable,
		Disable
	}

	[Native]
	public enum AWSIoTAwsJobAbortCriteriaAbortAction : long
	{
		Unknown,
		Cancel
	}

	[Native]
	public enum AWSIoTAwsJobAbortCriteriaFailureType : long
	{
		Unknown,
		Failed,
		Rejected,
		TimedOut,
		All
	}

	[Native]
	public enum AWSIoTBehaviorCriteriaType : long
	{
		Unknown,
		Static,
		Statistical,
		MachineLearning
	}

	[Native]
	public enum AWSIoTCACertificateStatus : long
	{
		Unknown,
		Active,
		Inactive
	}

	[Native]
	public enum AWSIoTCACertificateUpdateAction : long
	{
		Unknown,
		Deactivate
	}

	[Native]
	public enum AWSIoTCannedAccessControlList : long
	{
		Unknown,
		Private,
		PublicRead,
		PublicReadWrite,
		AwsExecRead,
		AuthenticatedRead,
		BucketOwnerRead,
		BucketOwnerFullControl,
		LogDeliveryWrite
	}

	[Native]
	public enum AWSIoTCertificateMode : long
	{
		Unknown,
		Default,
		SniOnly
	}

	[Native]
	public enum AWSIoTCertificateStatus : long
	{
		Unknown,
		Active,
		Inactive,
		Revoked,
		PendingTransfer,
		RegisterInactive,
		PendingActivation
	}

	[Native]
	public enum AWSIoTComparisonOperator : long
	{
		Unknown,
		LessThan,
		LessThanEquals,
		GreaterThan,
		GreaterThanEquals,
		InCidrSet,
		NotInCidrSet,
		InPortSet,
		NotInPortSet,
		InSet,
		NotInSet
	}

	[Native]
	public enum AWSIoTConfidenceLevel : long
	{
		Unknown,
		Low,
		Medium,
		High
	}

	[Native]
	public enum AWSIoTCustomMetricType : long
	{
		Unknown,
		StringList,
		IpAddressList,
		NumberList,
		Number
	}

	[Native]
	public enum AWSIoTDayOfWeek : long
	{
		Unknown,
		Sun,
		Mon,
		Tue,
		Wed,
		Thu,
		Fri,
		Sat
	}

	[Native]
	public enum AWSIoTDetectMitigationActionExecutionStatus : long
	{
		Unknown,
		InProgress,
		Successful,
		Failed,
		Skipped
	}

	[Native]
	public enum AWSIoTDetectMitigationActionsTaskStatus : long
	{
		Unknown,
		InProgress,
		Successful,
		Failed,
		Canceled
	}

	[Native]
	public enum AWSIoTDeviceCertificateUpdateAction : long
	{
		Unknown,
		Deactivate
	}

	[Native]
	public enum AWSIoTDeviceDefenderIndexingMode : long
	{
		Unknown,
		Off,
		Violations
	}

	[Native]
	public enum AWSIoTDimensionType : long
	{
		Unknown,
		TopicFilter
	}

	[Native]
	public enum AWSIoTDimensionValueOperator : long
	{
		Unknown,
		In,
		NotIn
	}

	[Native]
	public enum AWSIoTDomainConfigurationStatus : long
	{
		Unknown,
		Enabled,
		Disabled
	}

	[Native]
	public enum AWSIoTDomainType : long
	{
		Unknown,
		Endpoint,
		AwsManaged,
		CustomerManaged
	}

	[Native]
	public enum AWSIoTDynamicGroupStatus : long
	{
		Unknown,
		Active,
		Building,
		Rebuilding
	}

	[Native]
	public enum AWSIoTDynamoKeyType : long
	{
		Unknown,
		String,
		Number
	}

	[Native]
	public enum AWSIoTEventType : long
	{
		Unknown,
		Thing,
		ThingGroup,
		ThingType,
		ThingGroupMembership,
		ThingGroupHierarchy,
		ThingTypeAssociation,
		Job,
		JobExecution,
		Policy,
		Certificate,
		CaCertificate
	}

	[Native]
	public enum AWSIoTFieldType : long
	{
		Unknown,
		Number,
		String,
		Boolean
	}

	[Native]
	public enum AWSIoTFleetMetricUnit : long
	{
		Unknown,
		Seconds,
		Microseconds,
		Milliseconds,
		Bytes,
		Kilobytes,
		Megabytes,
		Gigabytes,
		Terabytes,
		Bits,
		Kilobits,
		Megabits,
		Gigabits,
		Terabits,
		Percent,
		Count,
		BytesSecond,
		KilobytesSecond,
		MegabytesSecond,
		GigabytesSecond,
		TerabytesSecond,
		BitsSecond,
		KilobitsSecond,
		MegabitsSecond,
		GigabitsSecond,
		TerabitsSecond,
		CountSecond,
		None
	}

	[Native]
	public enum AWSIoTIndexStatus : long
	{
		Unknown,
		Active,
		Building,
		Rebuilding
	}

	[Native]
	public enum AWSIoTJobEndBehavior : long
	{
		Unknown,
		StopRollout,
		Cancel,
		ForceCancel
	}

	[Native]
	public enum AWSIoTJobExecutionFailureType : long
	{
		Unknown,
		Failed,
		Rejected,
		TimedOut,
		All
	}

	[Native]
	public enum AWSIoTJobExecutionStatus : long
	{
		Unknown,
		Queued,
		InProgress,
		Succeeded,
		Failed,
		TimedOut,
		Rejected,
		Removed,
		Canceled
	}

	[Native]
	public enum AWSIoTJobStatus : long
	{
		Unknown,
		InProgress,
		Canceled,
		Completed,
		DeletionInProgress,
		Scheduled
	}

	[Native]
	public enum AWSIoTLogLevel : long
	{
		Unknown,
		Debug,
		Info,
		Error,
		Warn,
		Disabled
	}

	[Native]
	public enum AWSIoTLogTargetType : long
	{
		Unknown,
		Default,
		ThingGroup,
		ClientId,
		SourceIp,
		PrincipalId
	}

	[Native]
	public enum AWSIoTMessageFormat : long
	{
		Unknown,
		Raw,
		Json
	}

	[Native]
	public enum AWSIoTMitigationActionType : long
	{
		Unknown,
		UpdateDeviceCertificate,
		UpdateCaCertificate,
		AddThingsToThingGroup,
		ReplaceDefaultPolicyVersion,
		EnableIotLogging,
		PublishFindingToSns
	}

	[Native]
	public enum AWSIoTModelStatus : long
	{
		Unknown,
		PendingBuild,
		Active,
		Expired
	}

	[Native]
	public enum AWSIoTNamedShadowIndexingMode : long
	{
		Unknown,
		Off,
		On
	}

	[Native]
	public enum AWSIoTOTAUpdateStatus : long
	{
		Unknown,
		CreatePending,
		CreateInProgress,
		CreateComplete,
		CreateFailed
	}

	[Native]
	public enum AWSIoTPolicyTemplateName : long
	{
		Unknown,
		BlankPolicy
	}

	[Native]
	public enum AWSIoTProtocols : long
	{
		Unknown,
		Mqtt,
		Http
	}

	[Native]
	public enum AWSIoTReportType : long
	{
		Unknown,
		Errors,
		Results
	}

	[Native]
	public enum AWSIoTResourceType : long
	{
		Unknown,
		DeviceCertificate,
		CaCertificate,
		IotPolicy,
		CognitoIdentityPool,
		ClientId,
		AccountSettings,
		RoleAlias,
		IamRole,
		IssuerCertificate
	}

	[Native]
	public enum AWSIoTRetryableFailureType : long
	{
		Unknown,
		Failed,
		TimedOut,
		All
	}

	[Native]
	public enum AWSIoTServerCertificateStatus : long
	{
		Unknown,
		Invalid,
		Valid
	}

	[Native]
	public enum AWSIoTServiceType : long
	{
		Unknown,
		Data,
		CredentialProvider,
		Jobs
	}

	[Native]
	public enum AWSIoTStatus : long
	{
		Unknown,
		InProgress,
		Completed,
		Failed,
		Cancelled,
		Cancelling
	}

	[Native]
	public enum AWSIoTTargetSelection : long
	{
		Unknown,
		Continuous,
		Snapshot
	}

	[Native]
	public enum AWSIoTTemplateType : long
	{
		Unknown,
		FleetProvisioning,
		Jitp
	}

	[Native]
	public enum AWSIoTThingConnectivityIndexingMode : long
	{
		Unknown,
		Off,
		Status
	}

	[Native]
	public enum AWSIoTThingGroupIndexingMode : long
	{
		Unknown,
		Off,
		On
	}

	[Native]
	public enum AWSIoTThingIndexingMode : long
	{
		Unknown,
		Off,
		Registry,
		RegistryAndShadow
	}

	[Native]
	public enum AWSIoTTopicRuleDestinationStatus : long
	{
		Unknown,
		Enabled,
		InProgress,
		Disabled,
		Error,
		Deleting
	}

	[Native]
	public enum AWSIoTVerificationState : long
	{
		Unknown,
		FalsePositive,
		BenignPositive,
		TruePositive
	}

	[Native]
	public enum AWSIoTViolationEventType : long
	{
		Unknown,
		InAlarm,
		AlarmCleared,
		AlarmInvalidated
	}

	[Native]
	public enum AWSIoTKeyChainAccessibility : long
	{
		WhenUnlocked = 1,
		AfterFirstUnlock,
		Always,
		WhenPasscodeSetThisDeviceOnly,
		WhenUnlockedThisDeviceOnly,
		AfterFirstUnlockThisDeviceOnly,
		AlwaysThisDeviceOnly
	}

	[Native]
	public enum AWSIoTDataErrorType : long
	{
		Unknown,
		Conflict,
		InternalFailure,
		InvalidRequest,
		MethodNotAllowed,
		RequestEntityTooLarge,
		ResourceNotFound,
		ServiceUnavailable,
		Throttling,
		Unauthorized,
		UnsupportedDocumentEncoding
	}

	[Native]
	public enum AWSIoTDataPayloadFormatIndicator : long
	{
		nknown,
		nspecifiedBytes,
		tf8Data
	}

	[Native]
	public enum AWSIoTMQTTStatus : long
	{
		Unknown,
		Connecting,
		Connected,
		Disconnected,
		ConnectionRefused,
		ConnectionError,
		ProtocolError
	}

	[Native]
	public enum AWSIoTMQTTMessageType : long
	{
		Connect = 1,
		Connack = 2,
		Publish = 3,
		Puback = 4,
		Pubrec = 5,
		Pubrel = 6,
		Pubcomp = 7,
		Subscribe = 8,
		Suback = 9,
		Unsubscribe = 10,
		Unsuback = 11,
		Pingreq = 12,
		Pingresp = 13,
		Disconnect = 14
	}

	[Native]
	public enum AWSIoTMQTTQoS : long
	{
		AtMostOnce = 0,
		AtLeastOnce = 1,
		ExactlyOnce = 2
	}

	[Native]
	public enum AWSIoTShadowOperationType : long
	{
		Update,
		Get,
		Delete,
		Count,
		None
	}

	[Native]
	public enum AWSIoTShadowOperationStatusType : long
	{
		Accepted,
		Rejected,
		Delta,
		Documents,
		Count,
		ForeignUpdate,
		Timeout
	}
}
