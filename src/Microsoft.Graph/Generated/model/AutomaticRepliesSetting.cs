// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AutomaticRepliesSetting.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AutomaticRepliesSetting>))]
    public partial class AutomaticRepliesSetting
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticRepliesSetting"/> class.
        /// </summary>
        public AutomaticRepliesSetting()
        {
            this.ODataType = "microsoft.graph.automaticRepliesSetting";
        }

        /// <summary>
        /// Gets or sets externalAudience.
        /// The set of audience external to the signed-in user's organization who will receive the ExternalReplyMessage, if Status is AlwaysEnabled or Scheduled. Possible values are: none, contactsOnly, all.
        /// </summary>
        [JsonPropertyName("externalAudience")]
        public ExternalAudienceScope? ExternalAudience { get; set; }
    
        /// <summary>
        /// Gets or sets externalReplyMessage.
        /// The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.
        /// </summary>
        [JsonPropertyName("externalReplyMessage")]
        public string ExternalReplyMessage { get; set; }
    
        /// <summary>
        /// Gets or sets internalReplyMessage.
        /// The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.
        /// </summary>
        [JsonPropertyName("internalReplyMessage")]
        public string InternalReplyMessage { get; set; }
    
        /// <summary>
        /// Gets or sets scheduledEndDateTime.
        /// The date and time that automatic replies are set to end, if Status is set to Scheduled.
        /// </summary>
        [JsonPropertyName("scheduledEndDateTime")]
        public DateTimeTimeZone ScheduledEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets scheduledStartDateTime.
        /// The date and time that automatic replies are set to begin, if Status is set to Scheduled.
        /// </summary>
        [JsonPropertyName("scheduledStartDateTime")]
        public DateTimeTimeZone ScheduledStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Configurations status for automatic replies. Possible values are: disabled, alwaysEnabled, scheduled.
        /// </summary>
        [JsonPropertyName("status")]
        public AutomaticRepliesStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
