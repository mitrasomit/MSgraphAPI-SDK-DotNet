// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type OauthApplicationEvidence.
    /// </summary>
    public partial class OauthApplicationEvidence : AlertEvidence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OauthApplicationEvidence"/> class.
        /// </summary>
        public OauthApplicationEvidence()
        {
            this.ODataType = "microsoft.graph.security.oauthApplicationEvidence";
        }

        /// <summary>
        /// Gets or sets appId.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets objectId.
        /// </summary>
        [JsonPropertyName("objectId")]
        public string ObjectId { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
    
    }
}
