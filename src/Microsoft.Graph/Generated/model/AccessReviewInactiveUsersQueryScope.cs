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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AccessReviewInactiveUsersQueryScope.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessReviewInactiveUsersQueryScope : AccessReviewQueryScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewInactiveUsersQueryScope"/> class.
        /// </summary>
        public AccessReviewInactiveUsersQueryScope()
        {
            this.ODataType = "microsoft.graph.accessReviewInactiveUsersQueryScope";
        }

        /// <summary>
        /// Gets or sets inactiveDuration.
        /// Defines the length of the duration period of inactivity. Inactivity is based on the last sign in date of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inactiveDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration InactiveDuration { get; set; }
    
    }
}