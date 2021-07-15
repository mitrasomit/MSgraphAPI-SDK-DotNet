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
    /// The interface IDeviceEnrollmentLimitConfigurationRequest.
    /// </summary>
    public partial interface IDeviceEnrollmentLimitConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceEnrollmentLimitConfiguration using POST.
        /// </summary>
        /// <param name="deviceEnrollmentLimitConfigurationToCreate">The DeviceEnrollmentLimitConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceEnrollmentLimitConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentLimitConfiguration> CreateAsync(DeviceEnrollmentLimitConfiguration deviceEnrollmentLimitConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceEnrollmentLimitConfiguration using POST and returns a <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentLimitConfigurationToCreate">The DeviceEnrollmentLimitConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentLimitConfiguration>> CreateResponseAsync(DeviceEnrollmentLimitConfiguration deviceEnrollmentLimitConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentLimitConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentLimitConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceEnrollmentLimitConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceEnrollmentLimitConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentLimitConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceEnrollmentLimitConfiguration and returns a <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentLimitConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentLimitConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentLimitConfigurationToUpdate">The DeviceEnrollmentLimitConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceEnrollmentLimitConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentLimitConfiguration> UpdateAsync(DeviceEnrollmentLimitConfiguration deviceEnrollmentLimitConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentLimitConfiguration using PATCH and returns a <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentLimitConfigurationToUpdate">The DeviceEnrollmentLimitConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentLimitConfiguration>> UpdateResponseAsync(DeviceEnrollmentLimitConfiguration deviceEnrollmentLimitConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentLimitConfiguration using PUT.
        /// </summary>
        /// <param name="deviceEnrollmentLimitConfigurationToUpdate">The DeviceEnrollmentLimitConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentLimitConfiguration> PutAsync(DeviceEnrollmentLimitConfiguration deviceEnrollmentLimitConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentLimitConfiguration using PUT and returns a <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentLimitConfigurationToUpdate">The DeviceEnrollmentLimitConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceEnrollmentLimitConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentLimitConfiguration>> PutResponseAsync(DeviceEnrollmentLimitConfiguration deviceEnrollmentLimitConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentLimitConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentLimitConfigurationRequest Expand(Expression<Func<DeviceEnrollmentLimitConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentLimitConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentLimitConfigurationRequest Select(Expression<Func<DeviceEnrollmentLimitConfiguration, object>> selectExpression);

    }
}
