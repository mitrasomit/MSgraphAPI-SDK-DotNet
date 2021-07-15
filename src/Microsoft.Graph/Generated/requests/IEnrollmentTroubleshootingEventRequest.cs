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
    /// The interface IEnrollmentTroubleshootingEventRequest.
    /// </summary>
    public partial interface IEnrollmentTroubleshootingEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EnrollmentTroubleshootingEvent using POST.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToCreate">The EnrollmentTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> CreateAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EnrollmentTroubleshootingEvent using POST and returns a <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToCreate">The EnrollmentTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnrollmentTroubleshootingEvent>> CreateResponseAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EnrollmentTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EnrollmentTroubleshootingEvent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EnrollmentTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EnrollmentTroubleshootingEvent and returns a <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnrollmentTroubleshootingEvent>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnrollmentTroubleshootingEvent using PATCH.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToUpdate">The EnrollmentTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> UpdateAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnrollmentTroubleshootingEvent using PATCH and returns a <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToUpdate">The EnrollmentTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnrollmentTroubleshootingEvent>> UpdateResponseAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnrollmentTroubleshootingEvent using PUT.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToUpdate">The EnrollmentTroubleshootingEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> PutAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EnrollmentTroubleshootingEvent using PUT and returns a <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> object.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToUpdate">The EnrollmentTroubleshootingEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EnrollmentTroubleshootingEvent}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EnrollmentTroubleshootingEvent>> PutResponseAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Expand(Expression<Func<EnrollmentTroubleshootingEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Select(Expression<Func<EnrollmentTroubleshootingEvent, object>> selectExpression);

    }
}
