### 3.7.752.0 (2024-02-20 19:14 UTC)
* CloudFront (3.7.301.47)
	* Update `AmazonCloudFrontCookieSigner` to handle paths with leading slashes
* DynamoDBv2 (3.7.301.14)
	* Publishing quick fix for doc only update.
* KinesisFirehose (3.7.304.0)
	* This release updates a few Firehose related APIs.
* Lambda (3.7.304.0)
	* Add .NET 8 (dotnet8) Runtime support to AWS Lambda.

### 3.7.751.0 (2024-02-19 19:20 UTC)
* Amplify (3.7.301.0)
	* This release contains API changes that enable users to configure their Amplify domains with their own custom SSL/TLS certificate.
* Chatbot (3.7.300.0)
	* This release adds support for AWS Chatbot. You can now monitor, operate, and troubleshoot your AWS resources with interactive ChatOps using the AWS SDK.
* ConfigService (3.7.302.23)
	* Documentation updates for the AWS Config CLI
* IVS (3.7.302.8)
	* Changed description for latencyMode in Create/UpdateChannel and Channel/ChannelSummary.
* Keyspaces (3.7.301.16)
	* Documentation updates for Amazon Keyspaces
* MediaTailor (3.7.303.0)
	* MediaTailor: marking #AdBreak.OffsetMillis as required.

### 3.7.750.0 (2024-02-16 19:21 UTC)
* ConnectParticipant (3.7.301.17)
	* Doc only update to GetTranscript API reference guide to inform users about presence of events in the chat transcript.
* ElasticMapReduce (3.7.304.0)
	* adds fine grained control over Unhealthy Node Replacement to Amazon ElasticMapReduce
* KinesisFirehose (3.7.303.0)
	* This release adds support for Data Message Extraction for decompressed CloudWatch logs, and to use a custom file extension or time zone for S3 destinations.
* Lambda (3.7.303.48)
	* Documentation-only updates for Lambda to clarify a number of existing actions and properties.
* RDS (3.7.306.10)
	* Doc only update for a valid option in DB parameter group
* SimpleNotificationService (3.7.301.0)
	* This release marks phone numbers as sensitive inputs.
* Core 3.7.302.12
	* Update `SSOTokenManager` to propagate cancellation token to `GetSsoTokenAsync` flow
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.749.0 (2024-02-15 19:22 UTC)
* Artifact (3.7.300.0)
	* This is the initial SDK release for AWS Artifact. AWS Artifact provides on-demand access to compliance and third-party compliance reports. This release includes access to List and Get reports, along with their metadata. This release also includes access to AWS Artifact notifications settings.
* CodePipeline (3.7.303.0)
	* Add ability to override timeout on action level.
* Detective (3.7.301.43)
	* Doc only updates for content enhancement
* GuardDuty (3.7.303.0)
	* Marked fields IpAddressV4, PrivateIpAddress, Email as Sensitive.
* HealthLake (3.7.301.0)
	* This release adds a new response parameter, JobProgressReport, to the DescribeFHIRImportJob and ListFHIRImportJobs API operation. JobProgressReport provides details on the progress of the import job on the server.
* OpenSearchService (3.7.305.0)
	* Adds additional supported instance types.
* Polly (3.7.302.0)
	* Amazon Polly adds 1 new voice - Burcu (tr-TR)
* SageMaker (3.7.313.0)
	* This release adds a new API UpdateClusterSoftware for SageMaker HyperPod. This API allows users to patch HyperPod clusters with latest platform softwares.
* SecretsManager (3.7.302.26)
	* Doc only update for Secrets Manager
* Core 3.7.302.11
	* Add configuration support to disable IMDSv1 fallback
	* Change Is<property-name>Set properties to not reset the value of the backing field.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.748.0 (2024-02-14 19:15 UTC)
* ControlTower (3.7.304.0)
	* Adds support for new Baseline and EnabledBaseline APIs for automating multi-account governance.
* LookoutEquipment (3.7.301.0)
	* This feature allows customers to see pointwise model diagnostics results for their models.
* QBusiness (3.7.301.0)
	* This release adds the metadata-boosting feature, which allows customers to easily fine-tune the underlying ranking of retrieved RAG passages in order to optimize Q&A answer relevance. It also adds new feedback reasons for the PutFeedback API.
* Core 3.7.302.10
	* Added SSO Logout to SSOTokenManager
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.747.0 (2024-02-13 19:20 UTC)
* Lightsail (3.7.303.0)
	* This release adds support to upgrade the major version of a database.
* MarketplaceCatalog (3.7.303.0)
	* AWS Marketplace Catalog API now supports setting intent on requests
* ResourceExplorer2 (3.7.302.0)
	* Resource Explorer now uses newly supported IPv4 'amazonaws.com' endpoints by default.
* SecurityLake (3.7.300.49)
	* Documentation updates for Security Lake
* Core 3.7.302.9
	* Fixed a regression for SigV2 signing for S3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.746.0 (2024-02-12 19:19 UTC)
* AppSync (3.7.304.0)
	* Adds support for new options on GraphqlAPIs, Resolvers and  Data Sources for emitting Amazon CloudWatch metrics for enhanced monitoring of AppSync APIs.
* CloudWatch (3.7.302.0)
	* This release enables PutMetricData API request payload compression by default.
* NeptuneGraph (3.7.303.0)
	* Adding a new option "parameters" for data plane api ExecuteQuery to support running parameterized query via SDK.
* Route53Domains (3.7.301.0)
	* This release adds bill contact support for RegisterDomain, TransferDomain, UpdateDomainContact and GetDomainDetail API.

### 3.7.745.0 (2024-02-09 19:19 UTC)
* Batch (3.7.301.0)
	* This feature allows Batch to support configuration of repository credentials for jobs running on ECS
* Braket (3.7.302.0)
	* Creating a job will result in DeviceOfflineException when using an offline device, and DeviceRetiredException when using a retired device.
* CostOptimizationHub (3.7.301.0)
	* Adding includeMemberAccounts field to the response of ListEnrollmentStatuses API.
* ECS (3.7.305.10)
	* Documentation only update for Amazon ECS.
* IoT (3.7.306.0)
	* This release allows AWS IoT Core users to enable Online Certificate Status Protocol (OCSP) Stapling for TLS X.509 Server Certificates when creating and updating AWS IoT Domain Configurations with Custom Domain.
* Pricing (3.7.301.0)
	* Add Throttling Exception to all APIs.
* PrometheusService (3.7.302.24)
	* Overall documentation updates.
* Core 3.7.302.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.744.0 (2024-02-08 19:13 UTC)
* CloudFront (3.7.301.41)
	* Remove duplicate `RSA.ImportParameters` call from AmazonCloudFrontUrlSigner (which caused a performance regression issue in OpenSSL 3.0)
* CodePipeline (3.7.302.0)
	* Add ability to execute pipelines with new parallel & queued execution modes and add support for triggers with filtering on branches and file paths.
* QuickSight (3.7.305.0)
	* General Interactions for Visuals; Waterfall Chart Color Configuration; Documentation Update
* WorkSpaces (3.7.302.0)
	* This release introduces User-Decoupling feature. This feature allows Workspaces Core customers to provision workspaces without providing users. CreateWorkspaces and DescribeWorkspaces APIs will now take a new optional parameter "WorkspaceName".

### 3.7.743.0 (2024-02-07 19:16 UTC)
* DataSync (3.7.301.0)
	* AWS DataSync now supports manifests for specifying files or objects to transfer.
* LexModelsV2 (3.7.302.0)
	* This release introduces a new bot replication feature as part of Lex Global Resiliency offering. This feature leverages a new set of APIs that allow customers to create bot replicas and replicate changes to bots across regions.
* Redshift (3.7.304.0)
	* LisRecommendations API to fetch Amazon Redshift Advisor recommendations.
* Core 3.7.302.7
	* Update SigV4A signer not to include headers that are not required for the request signature
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.742.0 (2024-02-06 19:18 UTC)
* AppSync (3.7.303.0)
	* Support for environment variables in AppSync GraphQL APIs
* CloudWatchLogs (3.7.304.0)
	* This release adds a new field, logGroupArn, to the response of the logs:DescribeLogGroups action.
* ECS (3.7.305.8)
	* This release is a documentation only update to address customer issues.
* Elasticsearch (3.7.302.0)
	* This release adds clear visibility to the customers on the changes that they make on the domain.
* OpenSearchService (3.7.304.0)
	* This release adds clear visibility to the customers on the changes that they make on the domain.
* WAFV2 (3.7.301.0)
	* You can now delete an API key that you've created for use with your CAPTCHA JavaScript integration API.

### 3.7.741.0 (2024-02-05 19:15 UTC)
* Glue (3.7.307.0)
	* Introduce Catalog Encryption Role within Glue Data Catalog Settings. Introduce SASL/PLAIN as an authentication method for Glue Kafka connections
* WorkSpaces (3.7.301.39)
	* Added definitions of various WorkSpace states

### 3.7.740.0 (2024-02-02 19:13 UTC)
* DynamoDBv2 (3.7.301.7)
	* Any number of users can execute up to 50 concurrent restores (any type of restore) in a given account.
* SageMaker (3.7.312.0)
	* Amazon SageMaker Canvas adds GenerativeAiSettings support for CanvasAppSettings.
* Core 3.7.302.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.739.0 (2024-02-01 19:18 UTC)
* CognitoIdentityProvider (3.7.302.0)
	* Added CreateIdentityProvider and UpdateIdentityProvider details for new SAML IdP features
* IVS (3.7.302.0)
	* This release introduces a new resource Playback Restriction Policy which can be used to geo-restrict or domain-restrict channel stream playback when associated with a channel.  New APIs to support this resource were introduced in the form of Create/Delete/Get/Update/List.
* ManagedBlockchainQuery (3.7.302.0)
	* This release adds support for transactions that have not reached finality. It also removes support for the status property from the response of the GetTransaction operation. You can use the confirmationStatus and executionStatus properties to determine the status of the transaction.
* MediaConvert (3.7.303.0)
	* This release includes support for broadcast-mixed audio description tracks.
* NeptuneGraph (3.7.302.0)
	* Adding new APIs in SDK for Amazon Neptune Analytics. These APIs include operations to execute, cancel, list queries and get the graph summary.
* Core 3.7.302.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.738.0 (2024-01-31 19:15 UTC)
* CloudFormation (3.7.303.0)
	* CloudFormation IaC generator allows you to scan existing resources in your account and select resources to generate a template for a new or existing CloudFormation stack.
* ElasticLoadBalancingV2 (3.7.302.0)
	* This release enables unhealthy target draining intervals for Network Load Balancers.
* Glue (3.7.306.0)
	* Update page size limits for GetJobRuns and GetTriggers APIs.
* SimpleSystemsManagement (3.7.302.0)
	* This release adds an optional Duration parameter to StateManager Associations. This allows customers to specify how long an apply-only-on-cron association execution should run. Once the specified Duration is out all the ongoing cancellable commands or automations are cancelled.
* Core 3.7.302.4
	* Performance optimization using source generated Regex for .NET 8 target.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.737.0 (2024-01-30 19:13 UTC)
* DataZone (3.7.301.0)
	* Add new skipDeletionCheck to DeleteDomain. Add new skipDeletionCheck to DeleteProject which also automatically deletes dependent objects
* Route53 (3.7.302.10)
	* Update the SDKs for text changes in the APIs.
* Core 3.7.302.3
	* Update request checksum not to add duplicate trailing header key on retries
	* All services packages updated to require new Core

### 3.7.736.0 (2024-01-29 19:24 UTC)
* AutoScaling (3.7.302.0)
	* EC2 Auto Scaling customers who use attribute based instance-type selection can now intuitively define their Spot instances price protection limit as a percentage of the lowest priced On-Demand instance type.
* Comprehend (3.7.300.42)
	* Comprehend PII analysis now supports Spanish input documents.
* EC2 (3.7.314.0)
	* EC2 Fleet customers who use attribute based instance-type selection can now intuitively define their Spot instances price protection limit as a percentage of the lowest priced On-Demand instance type.
* MWAA (3.7.303.0)
	* This release adds MAINTENANCE environment status for Amazon MWAA environments.
* RDS (3.7.306.0)
	* Introduced support for the InsufficientDBInstanceCapacityFault error in the RDS RestoreDBClusterFromSnapshot and RestoreDBClusterToPointInTime API methods. This provides enhanced error handling, ensuring a more robust experience.
* Snowball (3.7.300.42)
	* Modified description of createaddress to include direction to add path when providing a JSON file.
* Core 3.7.302.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.735.0 (2024-01-26 19:18 UTC)
* Connect (3.7.312.0)
	* Update list and string length limits for predefined attributes.
* Inspector2 (3.7.302.0)
	* This release adds ECR container image scanning based on their lastRecordedPullTime.
* SageMaker (3.7.311.0)
	* Amazon SageMaker Automatic Model Tuning now provides an API to programmatically delete tuning jobs.
* Core 3.7.302.1
	* Added support to set SupportsGettingNewToken when retrieving Credentials from SSOAWSCredentials

### 3.7.734.0 (2024-01-25 19:24 UTC)
* ACMPCA (3.7.301.0)
	* AWS Private CA now supports an option to omit the CDP extension from issued certificates, when CRL revocation is enabled.
* Lightsail (3.7.302.0)
	* This release adds support for IPv6-only instance plans.
* S3 (3.7.305.17)
	* Fix bug with S3 ConstantClass enumerations not working with implicit string conversion
* Core 3.7.302.0
	* Introduce a new general HTTP credentials provider, which supports retrieval of AWS credentials from an arbitrary HTTP(S) endpoint specified by the environment. It replaces the existing `ECSTaskCredentials` provider, and it's also used by EKS Pod Identities.
	* All services packages updated to require new Core

### 3.7.733.0 (2024-01-24 22:12 UTC)
* EC2 (3.7.313.0)
	* Introduced a new clientToken request parameter on CreateNetworkAcl and CreateRouteTable APIs. The clientToken parameter allows idempotent operations on the APIs.
* ECS (3.7.305.1)
	* Documentation updates for Amazon ECS.
* Outposts (3.7.301.0)
	* DeviceSerialNumber parameter is now optional in StartConnection API
* RDS (3.7.305.0)
	* This release adds support for Aurora Limitless Database.
* StorageGateway (3.7.301.0)
	* Add DeprecationDate and SoftwareVersion to response of ListGateways.
* Core 3.7.301.10
	* Skip content-type header for requests without a modeled body or payload
	* All services packages updated to require new Core

### 3.7.732.0 (2024-01-23 20:39 UTC)
* Inspector2 (3.7.301.0)
	* This release adds support for CIS scans on EC2 instances.
* S3 (3.7.305.15)
	* Add missing `SSE-C` properties in TransferUtilityDownloadDirectoryRequest

### 3.7.731.0 (2024-01-22 19:25 UTC)
* AppConfigData (3.7.301.0)
	* Fix FIPS Endpoints in aws-us-gov.
* Cloud9 (3.7.301.27)
	* Doc-only update around removing AL1 from list of available AMIs for Cloud9
* CloudFrontKeyValueStore (3.7.301.0)
	* This release improves upon the DescribeKeyValueStore API by returning two additional fields, Status of the KeyValueStore and the FailureReason in case of failures during creation of KeyValueStore.
* ConnectCases (3.7.302.0)
	* This release adds the ability to view audit history on a case and introduces a new parameter, performedBy, for CreateCase and UpdateCase API's.
* EC2 (3.7.312.6)
	* Documentation updates for Amazon EC2.
* ECS (3.7.305.0)
	* This release adds support for Transport Layer Security (TLS) and Configurable Timeout to ECS Service Connect. TLS facilitates privacy and data security for inter-service communications, while Configurable Timeout allows customized per-request timeout and idle timeout for Service Connect services.
* Finspace (3.7.304.0)
	* Allow customer to set zip default through command line arguments.
* Organizations (3.7.300.40)
	* Doc only update for quota increase change
* RDS (3.7.304.0)
	* Introduced support for the InsufficientDBInstanceCapacityFault error in the RDS CreateDBCluster API method. This provides enhanced error handling, ensuring a more robust experience when creating database clusters with insufficient instance capacity.

### 3.7.730.0 (2024-01-19 19:25 UTC)
* Athena (3.7.303.0)
	* Introducing new NotebookS3LocationUri parameter to Athena ImportNotebook API. Payload is no longer required and either Payload or NotebookS3LocationUri needs to be provided (not both) for a successful ImportNotebook API call. If both are provided, an InvalidRequestException will be thrown.
* CodeBuild (3.7.302.0)
	* Release CodeBuild Reserved Capacity feature
* DynamoDBv2 (3.7.301.0)
	* This release adds support for including ApproximateCreationDateTimePrecision configurations in EnableKinesisStreamingDestination API, adds the same as an optional field in the response of DescribeKinesisStreamingDestination, and adds support for a new UpdateKinesisStreamingDestination API.
* QConnect (3.7.303.0)
	* Increased Quick Response name max length to 100
* Core 3.7.301.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.729.0 (2024-01-18 19:19 UTC)
* B2bi (3.7.301.0)
	* Increasing TestMapping inputFileContent file size limit to 5MB and adding file size limit 250KB for TestParsing input file. This release also includes exposing InternalServerException for Tag APIs.
* CloudTrail (3.7.303.0)
	* This release adds a new API ListInsightsMetricData to retrieve metric data from CloudTrail Insights.
* Connect (3.7.311.0)
	* GetMetricDataV2 now supports 3 groupings
* Drs (3.7.302.0)
	* Removed invalid and unnecessary default values.
* KinesisFirehose (3.7.302.0)
	* Allow support for Snowflake as a Kinesis Data Firehose delivery destination.
* SageMakerFeatureStoreRuntime (3.7.301.0)
	* Increase BatchGetRecord limits from 10 items to 100 items
* Core 3.7.301.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.728.0 (2024-01-17 19:16 UTC)
* DynamoDBv2 (3.7.300.38)
	* Updating note for enabling streams for UpdateTable.
* Keyspaces (3.7.301.0)
	* This release adds support for Multi-Region Replication with provisioned tables, and Keyspaces auto scaling APIs

### 3.7.727.0 (2024-01-16 19:23 UTC)
* IoT (3.7.305.0)
	* Revert release of LogTargetTypes
* IoTFleetWise (3.7.303.0)
	* Updated APIs: SignalNodeType query parameter has been added to ListSignalCatalogNodesRequest and ListVehiclesResponse has been extended with attributes field.
* Macie2 (3.7.302.0)
	* This release adds support for analyzing Amazon S3 objects that are encrypted using dual-layer server-side encryption with AWS KMS keys (DSSE-KMS). It also adds support for reporting DSSE-KMS details in statistics and metadata about encryption settings for S3 buckets and objects.
* PaymentCryptography (3.7.302.0)
	* Provide an additional option for key exchange using RSA wrap/unwrap in addition to tr-34/tr-31 in ImportKey and ExportKey operations. Added new key usage (type) TR31_M1_ISO_9797_1_MAC_KEY, for use with Generate/VerifyMac dataplane operations  with ISO9797 Algorithm 1 MAC calculations.
* Personalize (3.7.301.29)
	* Documentation updates for Amazon Personalize.
* PersonalizeRuntime (3.7.301.29)
	* Documentation updates for Amazon Personalize
* Rekognition (3.7.301.0)
	* This release adds ContentType and TaxonomyLevel attributes to DetectModerationLabels and GetMediaAnalysisJob API responses.
* SecurityHub (3.7.303.21)
	* Documentation updates for AWS Security Hub
* Core 3.7.301.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.726.0 (2024-01-14 05:28 UTC)
* SageMaker (3.7.310.0)
	* This release will have ValidationException thrown if certain invalid app types are provided. The release will also throw ValidationException if more than 10 account ids are provided in VpcOnlyTrustedAccounts.
* Core 3.7.301.6
	* Update generators to use correct code tags in `<param>` XML elements
	* All services packages updated to require new Core

### 3.7.725.0 (2024-01-12 19:44 UTC)
* CloudFrontKeyValueStore (3.7.300.28)
	* Fixed CloudFrontKeyValueStore to use Sigv4a instead of Sigv4.
* Connect (3.7.310.0)
	* Supervisor Barge for Chat is now supported through the MonitorContact API.
* ConnectParticipant (3.7.301.0)
	* Introduce new Supervisor participant role
* LocationService (3.7.304.2)
	* Location SDK documentation update. Added missing fonts to the MapConfiguration data type. Updated note for the SubMunicipality property in the place data type.
* MWAA (3.7.302.0)
	* This Amazon MWAA feature release includes new fields in CreateWebLoginToken response model. The new fields IamIdentity and AirflowIdentity will let you match identifications, as the Airflow identity length is currently hashed to 64 characters.
* S3Control (3.7.305.0)
	* S3 On Outposts team adds dualstack endpoints support for S3Control and S3Outposts API calls.
* SupplyChain (3.7.300.0)
	* This release includes APIs CreateBillOfMaterialsImportJob and GetBillOfMaterialsImportJob.
* Transfer (3.7.302.0)
	* AWS Transfer Family now supports static IP addresses for SFTP & AS2 connectors and for async MDNs on AS2 servers.
* Core 3.7.301.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.724.0 (2024-01-11 19:16 UTC)
* EC2 (3.7.312.0)
	* This release adds support for adding an ElasticBlockStorage volume configurations in ECS RunTask/StartTask/CreateService/UpdateService APIs. The configuration allows for attaching EBS volumes to ECS Tasks.
* ECS (3.7.304.0)
	* This release adds support for adding an ElasticBlockStorage volume configurations in ECS RunTask/StartTask/CreateService/UpdateService APIs. The configuration allows for attaching EBS volumes to ECS Tasks.
* EventBridge (3.7.302.0)
	* Adding AppSync as an EventBridge Target
* IoT (3.7.304.0)
	* Add ConflictException to Update APIs of AWS IoT Software Package Catalog
* IoTFleetWise (3.7.302.0)
	* The following dataTypes have been removed: CUSTOMER_DECODED_INTERFACE in NetworkInterfaceType; CUSTOMER_DECODED_SIGNAL_INFO_IS_NULL in SignalDecoderFailureReason; CUSTOMER_DECODED_SIGNAL_NETWORK_INTERFACE_INFO_IS_NULL in NetworkInterfaceFailureReason; CUSTOMER_DECODED_SIGNAL in SignalDecoderType
* SecretsManager (3.7.302.9)
	* Doc only update for Secrets Manager
* WorkSpaces (3.7.301.26)
	* Added AWS Workspaces RebootWorkspaces API - Extended Reboot documentation update
* Core 3.7.301.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.723.0 (2024-01-10 19:21 UTC)
* CloudWatchLogs (3.7.303.0)
	* Add support for account level subscription filter policies to PutAccountPolicy, DescribeAccountPolicies, and DeleteAccountPolicy APIs. Additionally, PutAccountPolicy has been modified with new optional "selectionCriteria" parameter for resource selection.
* ConnectCampaignService (3.7.301.0)
	* Minor pattern updates for Campaign and Dial Request API fields.
* ConnectWisdomService (3.7.302.0)
	* QueryAssistant and GetRecommendations will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.
* LocationService (3.7.304.0)
	* This release adds API support for custom layers for the maps service APIs: CreateMap, UpdateMap, DescribeMap.
* QConnect (3.7.302.0)
	* QueryAssistant and GetRecommendations will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.
* RedshiftServerless (3.7.302.21)
	* Updates to ConfigParameter for RSS workgroup, removal of use_fips_ssl
* Route53 (3.7.302.0)
	* Route53 now supports geoproximity routing in AWS regions
* S3 (3.7.305.8)
	* Fixed a bug where uploading empty unseekable stream with TransferUtility creates 8MB file in S3.
* Core 3.7.301.3
	* Fix encoding issue where resource path components from the configured endpoint were being double encoded. Resource path components from configured endpoints will be single encoded and resource path components from the request will continue to be double encoded (except for S3).
	* Update documentation generators to use correct code tags
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.722.0 (2024-01-08 19:16 UTC)
* CodeBuild (3.7.301.0)
	* Aws CodeBuild now supports new compute type BUILD_GENERAL1_XLARGE
* EC2 (3.7.311.0)
	* Amazon EC2 R7iz bare metal instances are powered by custom 4th generation Intel Xeon Scalable processors.
* Route53Resolver (3.7.302.0)
	* This release adds support for query type configuration on firewall rules that enables customers for granular action (ALLOW, ALERT, BLOCK) by DNS query type.
* Core 3.7.301.2
	* Added SSO registration scopes to SSOAWSCredentialsOptions
	* All services packages updated to require new Core

### 3.7.721.0 (2024-01-05 19:22 UTC)
* Connect (3.7.309.0)
	* Minor trait updates for User APIs
* KeyManagementService (3.7.300.31)
	* Documentation updates for AWS Key Management Service (KMS).
* RedshiftServerless (3.7.302.19)
	* use_fips_ssl and require_ssl parameter support for Workgroup, UpdateWorkgroup, and CreateWorkgroup
* Core 3.7.301.1
	* Update generator to add line breaks in service client documentation
	* All services packages updated to require new Core

### 3.7.720.0 (2024-01-04 19:56 UTC)
* ConfigService (3.7.302.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config in November and December 2023.
* DocDB (3.7.302.0)
	* Adding PerformanceInsightsEnabled and PerformanceInsightsKMSKeyId fields to DescribeDBInstances Response.
* ECS (3.7.303.0)
	* This release adds support for managed instance draining which facilitates graceful termination of Amazon ECS instances.
* Elasticsearch (3.7.301.0)
	* This release adds support for new or existing Amazon OpenSearch domains to enable TLS 1.3 or TLS 1.2 with perfect forward secrecy cipher suites for domain endpoints.
* Lightsail (3.7.301.0)
	* This release adds support to set up an HTTPS endpoint on an instance.
* OpenSearchService (3.7.303.0)
	* This release adds support for new or existing Amazon OpenSearch domains to enable TLS 1.3 or TLS 1.2 with perfect forward secrecy cipher suites for domain endpoints.
* SageMaker (3.7.309.0)
	* Adding support for provisioned throughput mode for SageMaker Feature Groups
* ServiceCatalog (3.7.301.0)
	* Added Idempotency token support to Service Catalog  AssociateServiceActionWithProvisioningArtifact, DisassociateServiceActionFromProvisioningArtifact, DeleteServiceAction API
* Core 3.7.301.0
	* Add support for environment variables `http_proxy` and `https_proxy`; the .NET SDK now matches the behavior of the AWS CLI when using an [HTTP proxy](https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-proxy.html). Note that [HTTPS proxies](https://github.com/dotnet/runtime/issues/31113) are only supported in .NET 8 (and later).
	* All services packages updated to require new Core

### 3.7.719.0 (2024-01-03 19:21 UTC)
* Connect (3.7.308.0)
	* Amazon Connect, Contact Lens Evaluation API increase evaluation notes max length to 3072.
* MediaConvert (3.7.302.0)
	* This release includes video engine updates including HEVC improvements, support for ingesting VP9 encoded video in MP4 containers, and support for user-specified 3D LUTs.
* Core 3.7.300.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

