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
    /// The type SharedWithChannelTeamInfoRequest.
    /// </summary>
    public partial class SharedWithChannelTeamInfoRequest : BaseRequest, ISharedWithChannelTeamInfoRequest
    {
        /// <summary>
        /// Constructs a new SharedWithChannelTeamInfoRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SharedWithChannelTeamInfoRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SharedWithChannelTeamInfo using POST.
        /// </summary>
        /// <param name="sharedWithChannelTeamInfoToCreate">The SharedWithChannelTeamInfo to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedWithChannelTeamInfo.</returns>
        public async System.Threading.Tasks.Task<SharedWithChannelTeamInfo> CreateAsync(SharedWithChannelTeamInfo sharedWithChannelTeamInfoToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SharedWithChannelTeamInfo>(sharedWithChannelTeamInfoToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SharedWithChannelTeamInfo using POST and returns a <see cref="GraphResponse{SharedWithChannelTeamInfo}"/> object.
        /// </summary>
        /// <param name="sharedWithChannelTeamInfoToCreate">The SharedWithChannelTeamInfo to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedWithChannelTeamInfo}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedWithChannelTeamInfo>> CreateResponseAsync(SharedWithChannelTeamInfo sharedWithChannelTeamInfoToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SharedWithChannelTeamInfo>(sharedWithChannelTeamInfoToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SharedWithChannelTeamInfo.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SharedWithChannelTeamInfo>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SharedWithChannelTeamInfo and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SharedWithChannelTeamInfo.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedWithChannelTeamInfo.</returns>
        public async System.Threading.Tasks.Task<SharedWithChannelTeamInfo> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SharedWithChannelTeamInfo>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SharedWithChannelTeamInfo and returns a <see cref="GraphResponse{SharedWithChannelTeamInfo}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedWithChannelTeamInfo}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedWithChannelTeamInfo>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SharedWithChannelTeamInfo>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SharedWithChannelTeamInfo using PATCH.
        /// </summary>
        /// <param name="sharedWithChannelTeamInfoToUpdate">The SharedWithChannelTeamInfo to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharedWithChannelTeamInfo.</returns>
        public async System.Threading.Tasks.Task<SharedWithChannelTeamInfo> UpdateAsync(SharedWithChannelTeamInfo sharedWithChannelTeamInfoToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SharedWithChannelTeamInfo>(sharedWithChannelTeamInfoToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SharedWithChannelTeamInfo using PATCH and returns a <see cref="GraphResponse{SharedWithChannelTeamInfo}"/> object.
        /// </summary>
        /// <param name="sharedWithChannelTeamInfoToUpdate">The SharedWithChannelTeamInfo to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharedWithChannelTeamInfo}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedWithChannelTeamInfo>> UpdateResponseAsync(SharedWithChannelTeamInfo sharedWithChannelTeamInfoToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SharedWithChannelTeamInfo>(sharedWithChannelTeamInfoToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SharedWithChannelTeamInfo using PUT.
        /// </summary>
        /// <param name="sharedWithChannelTeamInfoToUpdate">The SharedWithChannelTeamInfo object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<SharedWithChannelTeamInfo> PutAsync(SharedWithChannelTeamInfo sharedWithChannelTeamInfoToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<SharedWithChannelTeamInfo>(sharedWithChannelTeamInfoToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SharedWithChannelTeamInfo using PUT and returns a <see cref="GraphResponse{SharedWithChannelTeamInfo}"/> object.
        /// </summary>
        /// <param name="sharedWithChannelTeamInfoToUpdate">The SharedWithChannelTeamInfo object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{SharedWithChannelTeamInfo}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SharedWithChannelTeamInfo>> PutResponseAsync(SharedWithChannelTeamInfo sharedWithChannelTeamInfoToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<SharedWithChannelTeamInfo>(sharedWithChannelTeamInfoToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedWithChannelTeamInfoRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedWithChannelTeamInfoRequest Expand(Expression<Func<SharedWithChannelTeamInfo, object>> expandExpression)
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
        public ISharedWithChannelTeamInfoRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISharedWithChannelTeamInfoRequest Select(Expression<Func<SharedWithChannelTeamInfo, object>> selectExpression)
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
        /// <param name="sharedWithChannelTeamInfoToInitialize">The <see cref="SharedWithChannelTeamInfo"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SharedWithChannelTeamInfo sharedWithChannelTeamInfoToInitialize)
        {

            if (sharedWithChannelTeamInfoToInitialize != null)
            {
                if (sharedWithChannelTeamInfoToInitialize.AllowedMembers != null && sharedWithChannelTeamInfoToInitialize.AllowedMembers.CurrentPage != null)
                {
                    sharedWithChannelTeamInfoToInitialize.AllowedMembers.InitializeNextPageRequest(this.Client, sharedWithChannelTeamInfoToInitialize.AllowedMembersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    sharedWithChannelTeamInfoToInitialize.AllowedMembers.AdditionalData = sharedWithChannelTeamInfoToInitialize.AdditionalData;
                }

            }


        }
    }
}