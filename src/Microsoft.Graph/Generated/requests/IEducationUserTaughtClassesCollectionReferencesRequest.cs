// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IEducationUserTaughtClassesCollectionReferencesRequest.
    /// </summary>
    public partial interface IEducationUserTaughtClassesCollectionReferencesRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified EducationClass to the collection via POST.
        /// </summary>
        /// <param name="educationClass">The EducationClass to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(EducationClass educationClass, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified EducationClass to the collection via POST and returns a <see cref="GraphResponse{EducationClass}"/> object of the request.
        /// </summary>
        /// <param name="educationClass">The EducationClass to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(EducationClass educationClass, CancellationToken cancellationToken = default);

    }
}
