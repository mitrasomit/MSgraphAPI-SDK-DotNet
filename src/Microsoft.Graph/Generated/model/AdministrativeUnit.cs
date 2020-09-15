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
    /// The type Administrative Unit.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AdministrativeUnit : DirectoryObject
    {
    
		///<summary>
		/// The AdministrativeUnit constructor
		///</summary>
        public AdministrativeUnit()
        {
            this.ODataType = "microsoft.graph.administrativeUnit";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visibility", Required = Newtonsoft.Json.Required.Default)]
        public string Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IAdministrativeUnitMembersCollectionWithReferencesPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets scoped role members.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scopedRoleMembers", Required = Newtonsoft.Json.Required.Default)]
        public IAdministrativeUnitScopedRoleMembersCollectionPage ScopedRoleMembers { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IAdministrativeUnitExtensionsCollectionPage Extensions { get; set; }
    
    }
}

