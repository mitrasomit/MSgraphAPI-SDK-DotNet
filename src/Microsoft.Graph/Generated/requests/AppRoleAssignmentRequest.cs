// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AppRoleAssignmentRequest.
    /// </summary>
    public partial class AppRoleAssignmentRequest : BaseRequest, IAppRoleAssignmentRequest
    {
        /// <summary>
        /// Constructs a new AppRoleAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AppRoleAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AppRoleAssignment using POST.
        /// </summary>
        /// <param name="appRoleAssignmentToCreate">The AppRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<AppRoleAssignment> CreateAsync(AppRoleAssignment appRoleAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AppRoleAssignment>(appRoleAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AppRoleAssignment using POST and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="appRoleAssignmentToCreate">The AppRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> CreateResponseAsync(AppRoleAssignment appRoleAssignmentToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AppRoleAssignment>(appRoleAssignmentToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AppRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AppRoleAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AppRoleAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AppRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<AppRoleAssignment> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AppRoleAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AppRoleAssignment and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AppRoleAssignment>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AppRoleAssignment using PATCH.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<AppRoleAssignment> UpdateAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AppRoleAssignment>(appRoleAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AppRoleAssignment using PATCH and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> UpdateResponseAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AppRoleAssignment>(appRoleAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AppRoleAssignment using PUT.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AppRoleAssignment> PutAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AppRoleAssignment>(appRoleAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AppRoleAssignment using PUT and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object.
        /// </summary>
        /// <param name="appRoleAssignmentToUpdate">The AppRoleAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AppRoleAssignment}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> PutResponseAsync(AppRoleAssignment appRoleAssignmentToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AppRoleAssignment>(appRoleAssignmentToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAppRoleAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAppRoleAssignmentRequest Expand(Expression<Func<AppRoleAssignment, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAppRoleAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAppRoleAssignmentRequest Select(Expression<Func<AppRoleAssignment, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="appRoleAssignmentToInitialize">The <see cref="AppRoleAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AppRoleAssignment appRoleAssignmentToInitialize)
        {

        }
    }
}
