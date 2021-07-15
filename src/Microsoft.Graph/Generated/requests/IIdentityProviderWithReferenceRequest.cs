// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIdentityProviderWithReferenceRequest.
    /// </summary>
    public partial interface IIdentityProviderWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified IdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityProvider.</returns>
        System.Threading.Tasks.Task<IdentityProvider> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IdentityProvider and returns a <see cref="GraphResponse{IdentityProvider}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityProvider>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified IdentityProvider using POST.
        /// </summary>
        /// <param name="identityProviderToCreate">The IdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityProvider.</returns>
        System.Threading.Tasks.Task<IdentityProvider> CreateAsync(IdentityProvider identityProviderToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified IdentityProvider using POST and returns a <see cref="GraphResponse{IdentityProvider}"/> object.
        /// </summary>
        /// <param name="identityProviderToCreate">The IdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityProvider>> CreateResponseAsync(IdentityProvider identityProviderToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified IdentityProvider using PATCH.
        /// </summary>
        /// <param name="identityProviderToUpdate">The IdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityProvider.</returns>
        System.Threading.Tasks.Task<IdentityProvider> UpdateAsync(IdentityProvider identityProviderToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified IdentityProvider using PATCH and returns a <see cref="GraphResponse{IdentityProvider}"/> object.
        /// </summary>
        /// <param name="identityProviderToUpdate">The IdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityProvider>> UpdateResponseAsync(IdentityProvider identityProviderToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified IdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified IdentityProvider and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProviderWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProviderWithReferenceRequest Expand(Expression<Func<IdentityProvider, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProviderWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProviderWithReferenceRequest Select(Expression<Func<IdentityProvider, object>> selectExpression);

    }
}
