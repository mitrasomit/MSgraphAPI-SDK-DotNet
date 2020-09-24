// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Managed Mobile App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedMobileApp : Entity
    {
    
		///<summary>
		/// The ManagedMobileApp constructor
		///</summary>
        public ManagedMobileApp()
        {
            this.ODataType = "microsoft.graph.managedMobileApp";
        }
	
        /// <summary>
        /// Gets or sets mobile app identifier.
        /// The identifier for an app with it's operating system type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppIdentifier MobileAppIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public string Version { get; set; }
    
    }
}
