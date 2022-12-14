// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IIncidentAlertsCollectionReferencesRequest.
    /// </summary>
    public partial interface IIncidentAlertsCollectionReferencesRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Adds the specified Alert to the collection via POST.
        /// </summary>
        /// <param name="alert">The Alert to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(Alert alert, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified Alert to the collection via POST and returns a <see cref="GraphResponse{Alert}"/> object of the request.
        /// </summary>
        /// <param name="alert">The Alert to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(Alert alert, CancellationToken cancellationToken = default);

    }
}
