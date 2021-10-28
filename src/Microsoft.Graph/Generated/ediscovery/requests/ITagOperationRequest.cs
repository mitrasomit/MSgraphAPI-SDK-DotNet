// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITagOperationRequest.
    /// </summary>
    public partial interface ITagOperationRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified TagOperation using POST.
        /// </summary>
        /// <param name="tagOperationToCreate">The TagOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TagOperation.</returns>
        System.Threading.Tasks.Task<TagOperation> CreateAsync(TagOperation tagOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TagOperation using POST and returns a <see cref="GraphResponse{TagOperation}"/> object.
        /// </summary>
        /// <param name="tagOperationToCreate">The TagOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TagOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TagOperation>> CreateResponseAsync(TagOperation tagOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TagOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TagOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TagOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TagOperation.</returns>
        System.Threading.Tasks.Task<TagOperation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TagOperation and returns a <see cref="GraphResponse{TagOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TagOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TagOperation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TagOperation using PATCH.
        /// </summary>
        /// <param name="tagOperationToUpdate">The TagOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TagOperation.</returns>
        System.Threading.Tasks.Task<TagOperation> UpdateAsync(TagOperation tagOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TagOperation using PATCH and returns a <see cref="GraphResponse{TagOperation}"/> object.
        /// </summary>
        /// <param name="tagOperationToUpdate">The TagOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TagOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TagOperation>> UpdateResponseAsync(TagOperation tagOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TagOperation using PUT.
        /// </summary>
        /// <param name="tagOperationToUpdate">The TagOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TagOperation> PutAsync(TagOperation tagOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TagOperation using PUT and returns a <see cref="GraphResponse{TagOperation}"/> object.
        /// </summary>
        /// <param name="tagOperationToUpdate">The TagOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TagOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TagOperation>> PutResponseAsync(TagOperation tagOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITagOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITagOperationRequest Expand(Expression<Func<TagOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITagOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITagOperationRequest Select(Expression<Func<TagOperation, object>> selectExpression);

    }
}