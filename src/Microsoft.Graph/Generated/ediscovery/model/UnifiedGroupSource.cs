// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Unified Group Source.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<UnifiedGroupSource>))]
    public partial class UnifiedGroupSource : DataSource
    {
    
        ///<summary>
        /// The UnifiedGroupSource constructor
        ///</summary>
        public UnifiedGroupSource()
        {
            this.ODataType = "microsoft.graph.ediscovery.unifiedGroupSource";
        }

        /// <summary>
        /// Gets or sets included sources.
        /// Specifies which sources are included in this group. Possible values are: mailbox, site.
        /// </summary>
        [JsonPropertyName("includedSources")]
        public SourceType? IncludedSources { get; set; }
    
        /// <summary>
        /// Gets or sets group.
        /// The group associated with the unifiedGroupSource.
        /// </summary>
        [JsonPropertyName("group")]
        public Microsoft.Graph.Group Group { get; set; }
    
    }
}
