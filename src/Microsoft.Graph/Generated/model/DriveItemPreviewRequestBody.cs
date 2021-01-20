// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DriveItemPreviewRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DriveItemPreviewRequestBody
    {
    
        /// <summary>
        /// Gets or sets Page.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "page", Required = Newtonsoft.Json.Required.Default)]
        public string Page { get; set; }
    
        /// <summary>
        /// Gets or sets Zoom.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "zoom", Required = Newtonsoft.Json.Required.Default)]
        public double? Zoom { get; set; }
    
    }
}
