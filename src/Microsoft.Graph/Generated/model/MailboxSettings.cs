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
    /// The type MailboxSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MailboxSettings>))]
    public partial class MailboxSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailboxSettings"/> class.
        /// </summary>
        public MailboxSettings()
        {
            this.ODataType = "microsoft.graph.mailboxSettings";
        }

        /// <summary>
        /// Gets or sets archiveFolder.
        /// Folder ID of an archive folder for the user. Read only.
        /// </summary>
        [JsonPropertyName("archiveFolder")]
        public string ArchiveFolder { get; set; }
    
        /// <summary>
        /// Gets or sets automaticRepliesSetting.
        /// Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.
        /// </summary>
        [JsonPropertyName("automaticRepliesSetting")]
        public AutomaticRepliesSetting AutomaticRepliesSetting { get; set; }
    
        /// <summary>
        /// Gets or sets dateFormat.
        /// The date format for the user's mailbox.
        /// </summary>
        [JsonPropertyName("dateFormat")]
        public string DateFormat { get; set; }
    
        /// <summary>
        /// Gets or sets delegateMeetingMessageDeliveryOptions.
        /// If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: sendToDelegateAndInformationToPrincipal, sendToDelegateAndPrincipal, sendToDelegateOnly. The default is sendToDelegateOnly.
        /// </summary>
        [JsonPropertyName("delegateMeetingMessageDeliveryOptions")]
        public DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// The locale information for the user, including the preferred language and country/region.
        /// </summary>
        [JsonPropertyName("language")]
        public LocaleInfo Language { get; set; }
    
        /// <summary>
        /// Gets or sets timeFormat.
        /// The time format for the user's mailbox.
        /// </summary>
        [JsonPropertyName("timeFormat")]
        public string TimeFormat { get; set; }
    
        /// <summary>
        /// Gets or sets timeZone.
        /// The default time zone for the user's mailbox.
        /// </summary>
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets workingHours.
        /// The days of the week and hours in a specific time zone that the user works.
        /// </summary>
        [JsonPropertyName("workingHours")]
        public WorkingHours WorkingHours { get; set; }
    
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
