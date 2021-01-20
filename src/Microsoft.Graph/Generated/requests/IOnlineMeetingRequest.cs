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
    /// The interface IOnlineMeetingRequest.
    /// </summary>
    public partial interface IOnlineMeetingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnlineMeeting using POST.
        /// </summary>
        /// <param name="onlineMeetingToCreate">The OnlineMeeting to create.</param>
        /// <returns>The created OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> CreateAsync(OnlineMeeting onlineMeetingToCreate);        /// <summary>
        /// Creates the specified OnlineMeeting using POST.
        /// </summary>
        /// <param name="onlineMeetingToCreate">The OnlineMeeting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> CreateAsync(OnlineMeeting onlineMeetingToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnlineMeeting.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnlineMeeting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnlineMeeting.
        /// </summary>
        /// <returns>The OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> GetAsync();

        /// <summary>
        /// Gets the specified OnlineMeeting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnlineMeeting using PATCH.
        /// </summary>
        /// <param name="onlineMeetingToUpdate">The OnlineMeeting to update.</param>
        /// <returns>The updated OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> UpdateAsync(OnlineMeeting onlineMeetingToUpdate);

        /// <summary>
        /// Updates the specified OnlineMeeting using PATCH.
        /// </summary>
        /// <param name="onlineMeetingToUpdate">The OnlineMeeting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> UpdateAsync(OnlineMeeting onlineMeetingToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Expand(Expression<Func<OnlineMeeting, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Select(Expression<Func<OnlineMeeting, object>> selectExpression);

    }
}
