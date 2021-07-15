// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISocialIdentityProviderRequest.
    /// </summary>
    public partial interface ISocialIdentityProviderRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SocialIdentityProvider using POST.
        /// </summary>
        /// <param name="socialIdentityProviderToCreate">The SocialIdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SocialIdentityProvider.</returns>
        System.Threading.Tasks.Task<SocialIdentityProvider> CreateAsync(SocialIdentityProvider socialIdentityProviderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SocialIdentityProvider using POST and returns a <see cref="GraphResponse{SocialIdentityProvider}"/> object.
        /// </summary>
        /// <param name="socialIdentityProviderToCreate">The SocialIdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SocialIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SocialIdentityProvider>> CreateResponseAsync(SocialIdentityProvider socialIdentityProviderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SocialIdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SocialIdentityProvider and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SocialIdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SocialIdentityProvider.</returns>
        System.Threading.Tasks.Task<SocialIdentityProvider> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SocialIdentityProvider and returns a <see cref="GraphResponse{SocialIdentityProvider}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SocialIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SocialIdentityProvider>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SocialIdentityProvider using PATCH.
        /// </summary>
        /// <param name="socialIdentityProviderToUpdate">The SocialIdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SocialIdentityProvider.</returns>
        System.Threading.Tasks.Task<SocialIdentityProvider> UpdateAsync(SocialIdentityProvider socialIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SocialIdentityProvider using PATCH and returns a <see cref="GraphResponse{SocialIdentityProvider}"/> object.
        /// </summary>
        /// <param name="socialIdentityProviderToUpdate">The SocialIdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SocialIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SocialIdentityProvider>> UpdateResponseAsync(SocialIdentityProvider socialIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SocialIdentityProvider using PUT.
        /// </summary>
        /// <param name="socialIdentityProviderToUpdate">The SocialIdentityProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SocialIdentityProvider> PutAsync(SocialIdentityProvider socialIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SocialIdentityProvider using PUT and returns a <see cref="GraphResponse{SocialIdentityProvider}"/> object.
        /// </summary>
        /// <param name="socialIdentityProviderToUpdate">The SocialIdentityProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SocialIdentityProvider}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SocialIdentityProvider>> PutResponseAsync(SocialIdentityProvider socialIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISocialIdentityProviderRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISocialIdentityProviderRequest Expand(Expression<Func<SocialIdentityProvider, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISocialIdentityProviderRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISocialIdentityProviderRequest Select(Expression<Func<SocialIdentityProvider, object>> selectExpression);

    }
}
