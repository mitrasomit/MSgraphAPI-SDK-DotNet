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
    /// The interface ISharedPCConfigurationRequest.
    /// </summary>
    public partial interface ISharedPCConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharedPCConfiguration using POST.
        /// </summary>
        /// <param name="sharedPCConfigurationToCreate">The SharedPCConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedPCConfiguration.</returns>
        System.Threading.Tasks.Task<SharedPCConfiguration> CreateAsync(SharedPCConfiguration sharedPCConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SharedPCConfiguration using POST and returns a <see cref="GraphResponse{SharedPCConfiguration}"/> object.
        /// </summary>
        /// <param name="sharedPCConfigurationToCreate">The SharedPCConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedPCConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedPCConfiguration>> CreateResponseAsync(SharedPCConfiguration sharedPCConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SharedPCConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SharedPCConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SharedPCConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedPCConfiguration.</returns>
        System.Threading.Tasks.Task<SharedPCConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SharedPCConfiguration and returns a <see cref="GraphResponse{SharedPCConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedPCConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedPCConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedPCConfiguration using PATCH.
        /// </summary>
        /// <param name="sharedPCConfigurationToUpdate">The SharedPCConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharedPCConfiguration.</returns>
        System.Threading.Tasks.Task<SharedPCConfiguration> UpdateAsync(SharedPCConfiguration sharedPCConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedPCConfiguration using PATCH and returns a <see cref="GraphResponse{SharedPCConfiguration}"/> object.
        /// </summary>
        /// <param name="sharedPCConfigurationToUpdate">The SharedPCConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharedPCConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedPCConfiguration>> UpdateResponseAsync(SharedPCConfiguration sharedPCConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedPCConfiguration using PUT.
        /// </summary>
        /// <param name="sharedPCConfigurationToUpdate">The SharedPCConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SharedPCConfiguration> PutAsync(SharedPCConfiguration sharedPCConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedPCConfiguration using PUT and returns a <see cref="GraphResponse{SharedPCConfiguration}"/> object.
        /// </summary>
        /// <param name="sharedPCConfigurationToUpdate">The SharedPCConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SharedPCConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedPCConfiguration>> PutResponseAsync(SharedPCConfiguration sharedPCConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedPCConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedPCConfigurationRequest Expand(Expression<Func<SharedPCConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedPCConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedPCConfigurationRequest Select(Expression<Func<SharedPCConfiguration, object>> selectExpression);

    }
}
