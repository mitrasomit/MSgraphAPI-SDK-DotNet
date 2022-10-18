// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Risk Detection.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RiskDetection>))]
    public partial class RiskDetection : Entity
    {
    
        /// <summary>
        /// Gets or sets activity.
        /// Indicates the activity type the detected risk is linked to. Possible values are: signin, user, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("activity")]
        public ActivityType? Activity { get; set; }
    
        /// <summary>
        /// Gets or sets activity date time.
        /// Date and time that the risky activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("activityDateTime")]
        public DateTimeOffset? ActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional info.
        /// Additional information associated with the risk detection in JSON format. For example, '[{/'Key/':/'userAgent/',/'Value/':/'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36/'}]'. Possible keys in the additionalInfo JSON string are: userAgent, alertUrl, relatedEventTimeInUtc, relatedUserAgent, deviceInformation, relatedLocation, requestId, correlationId, lastActivityTimeInUtc, malwareName, clientLocation, clientIp, riskReasons. For more information about riskReasons and possible values, see riskReasons values.
        /// </summary>
        [JsonPropertyName("additionalInfo")]
        public string AdditionalInfo { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// Correlation ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
        /// </summary>
        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets detected date time.
        /// Date and time that the risk was detected. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("detectedDateTime")]
        public DateTimeOffset? DetectedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets detection timing type.
        /// Timing of the detected risk (real-time/offline). Possible values are: notDefined, realtime, nearRealtime, offline, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("detectionTimingType")]
        public RiskDetectionTimingType? DetectionTimingType { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// Provides the IP address of the client from where the risk occurred.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// Date and time that the risk detection was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("lastUpdatedDateTime")]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// Location of the sign-in.
        /// </summary>
        [JsonPropertyName("location")]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets request id.
        /// Request ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
        /// </summary>
        [JsonPropertyName("requestId")]
        public string RequestId { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// Details of the detected risk. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue, m365DAdminDismissedDetection. Note that you must use the Prefer: include - unknown -enum-members request header to get the following value(s) in this evolvable enum: m365DAdminDismissedDetection.
        /// </summary>
        [JsonPropertyName("riskDetail")]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets risk event type.
        /// The type of risk event detected. The possible values are unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence, generic,adminConfirmedUserCompromised, passwordSpray, impossibleTravel, newCountry, anomalousToken, tokenIssuerAnomaly,suspiciousBrowser, riskyIPAddress, mcasSuspiciousInboxManipulationRules, suspiciousInboxForwarding, and anomalousUserActivity. If the risk detection is a premium detection, will show generic. For more information about each value, see riskEventType values.
        /// </summary>
        [JsonPropertyName("riskEventType")]
        public string RiskEventType { get; set; }
    
        /// <summary>
        /// Gets or sets risk level.
        /// Level of the detected risk. Possible values are: low, medium, high, hidden, none, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskLevel")]
        public RiskLevel? RiskLevel { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// The state of a detected risky user or sign-in. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskState")]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// Source of the risk detection. For example, activeDirectory.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer type.
        /// Indicates the type of token issuer for the detected sign-in risk. Possible values are: AzureAD, ADFederationServices, UnknownFutureValue.
        /// </summary>
        [JsonPropertyName("tokenIssuerType")]
        public TokenIssuerType? TokenIssuerType { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// The user principal name (UPN) of the user.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Unique ID of the user.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

