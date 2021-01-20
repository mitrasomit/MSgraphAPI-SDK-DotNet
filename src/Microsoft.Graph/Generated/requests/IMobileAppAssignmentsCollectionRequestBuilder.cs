// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IMobileAppAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IMobileAppAssignmentsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IMobileAppAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IMobileAppAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMobileAppAssignmentRequestBuilder"/> for the specified MobileAppAssignment.
        /// </summary>
        /// <param name="id">The ID for the MobileAppAssignment.</param>
        /// <returns>The <see cref="IMobileAppAssignmentRequestBuilder"/>.</returns>
        IMobileAppAssignmentRequestBuilder this[string id] { get; }

        
    }
}
