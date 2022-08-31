// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EdiscoverySearchRequest.
    /// </summary>
    public partial class EdiscoverySearchRequest : Microsoft.Graph.BaseRequest, IEdiscoverySearchRequest
    {
        /// <summary>
        /// Constructs a new EdiscoverySearchRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoverySearchRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EdiscoverySearch using POST.
        /// </summary>
        /// <param name="ediscoverySearchToCreate">The EdiscoverySearch to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoverySearch.</returns>
        public async System.Threading.Tasks.Task<EdiscoverySearch> CreateAsync(EdiscoverySearch ediscoverySearchToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EdiscoverySearch>(ediscoverySearchToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EdiscoverySearch using POST and returns a <see cref="GraphResponse{EdiscoverySearch}"/> object.
        /// </summary>
        /// <param name="ediscoverySearchToCreate">The EdiscoverySearch to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoverySearch}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoverySearch>> CreateResponseAsync(EdiscoverySearch ediscoverySearchToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EdiscoverySearch>(ediscoverySearchToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EdiscoverySearch.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EdiscoverySearch>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EdiscoverySearch and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EdiscoverySearch.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoverySearch.</returns>
        public async System.Threading.Tasks.Task<EdiscoverySearch> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EdiscoverySearch>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EdiscoverySearch and returns a <see cref="GraphResponse{EdiscoverySearch}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoverySearch}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoverySearch>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EdiscoverySearch>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoverySearch using PATCH.
        /// </summary>
        /// <param name="ediscoverySearchToUpdate">The EdiscoverySearch to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoverySearch.</returns>
        public async System.Threading.Tasks.Task<EdiscoverySearch> UpdateAsync(EdiscoverySearch ediscoverySearchToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EdiscoverySearch>(ediscoverySearchToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoverySearch using PATCH and returns a <see cref="GraphResponse{EdiscoverySearch}"/> object.
        /// </summary>
        /// <param name="ediscoverySearchToUpdate">The EdiscoverySearch to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoverySearch}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoverySearch>> UpdateResponseAsync(EdiscoverySearch ediscoverySearchToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EdiscoverySearch>(ediscoverySearchToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoverySearch using PUT.
        /// </summary>
        /// <param name="ediscoverySearchToUpdate">The EdiscoverySearch object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EdiscoverySearch> PutAsync(EdiscoverySearch ediscoverySearchToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EdiscoverySearch>(ediscoverySearchToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoverySearch using PUT and returns a <see cref="GraphResponse{EdiscoverySearch}"/> object.
        /// </summary>
        /// <param name="ediscoverySearchToUpdate">The EdiscoverySearch object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EdiscoverySearch}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoverySearch>> PutResponseAsync(EdiscoverySearch ediscoverySearchToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EdiscoverySearch>(ediscoverySearchToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoverySearchRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoverySearchRequest Expand(Expression<Func<EdiscoverySearch, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoverySearchRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoverySearchRequest Select(Expression<Func<EdiscoverySearch, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="ediscoverySearchToInitialize">The <see cref="EdiscoverySearch"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EdiscoverySearch ediscoverySearchToInitialize)
        {

            if (ediscoverySearchToInitialize != null)
            {
                if (ediscoverySearchToInitialize.AdditionalSources != null && ediscoverySearchToInitialize.AdditionalSources.CurrentPage != null)
                {
                    ediscoverySearchToInitialize.AdditionalSources.InitializeNextPageRequest(this.Client, ediscoverySearchToInitialize.AdditionalSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    ediscoverySearchToInitialize.AdditionalSources.AdditionalData = ediscoverySearchToInitialize.AdditionalData;
                }
                if (ediscoverySearchToInitialize.CustodianSources != null && ediscoverySearchToInitialize.CustodianSources.CurrentPage != null)
                {
                    ediscoverySearchToInitialize.CustodianSources.InitializeNextPageRequest(this.Client, ediscoverySearchToInitialize.CustodianSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    ediscoverySearchToInitialize.CustodianSources.AdditionalData = ediscoverySearchToInitialize.AdditionalData;
                }
                if (ediscoverySearchToInitialize.NoncustodialSources != null && ediscoverySearchToInitialize.NoncustodialSources.CurrentPage != null)
                {
                    ediscoverySearchToInitialize.NoncustodialSources.InitializeNextPageRequest(this.Client, ediscoverySearchToInitialize.NoncustodialSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    ediscoverySearchToInitialize.NoncustodialSources.AdditionalData = ediscoverySearchToInitialize.AdditionalData;
                }

            }


        }
    }
}