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
    /// The type UserAttributeValuesItem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserAttributeValuesItem>))]
    public partial class UserAttributeValuesItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAttributeValuesItem"/> class.
        /// </summary>
        public UserAttributeValuesItem()
        {
            this.ODataType = "microsoft.graph.userAttributeValuesItem";
        }

        /// <summary>
        /// Gets or sets isDefault.
        /// Used to set the value as the default.
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The display name of the property displayed to the end user in the user flow.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The value that is set when this item is selected.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
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
