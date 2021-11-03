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
    /// The type Add To Review Set Operation.
    /// </summary>
    public partial class AddToReviewSetOperation : CaseOperation
    {
    
        ///<summary>
        /// The AddToReviewSetOperation constructor
        ///</summary>
        public AddToReviewSetOperation()
        {
            this.ODataType = "microsoft.graph.ediscovery.addToReviewSetOperation";
        }

        /// <summary>
        /// Gets or sets review set.
        /// The review set to which items matching the source collection query are added to.
        /// </summary>
        [JsonPropertyName("reviewSet")]
        public ReviewSet ReviewSet { get; set; }
    
        /// <summary>
        /// Gets or sets source collection.
        /// The sourceCollection that items are being added from.
        /// </summary>
        [JsonPropertyName("sourceCollection")]
        public SourceCollection SourceCollection { get; set; }
    
    }
}
