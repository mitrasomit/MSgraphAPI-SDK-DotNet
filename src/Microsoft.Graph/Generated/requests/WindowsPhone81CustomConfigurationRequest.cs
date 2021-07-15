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
    /// The type WindowsPhone81CustomConfigurationRequest.
    /// </summary>
    public partial class WindowsPhone81CustomConfigurationRequest : BaseRequest, IWindowsPhone81CustomConfigurationRequest
    {
        /// <summary>
        /// Constructs a new WindowsPhone81CustomConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsPhone81CustomConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsPhone81CustomConfiguration using POST.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToCreate">The WindowsPhone81CustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81CustomConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> CreateAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WindowsPhone81CustomConfiguration>(windowsPhone81CustomConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsPhone81CustomConfiguration using POST and returns a <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToCreate">The WindowsPhone81CustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81CustomConfiguration>> CreateResponseAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WindowsPhone81CustomConfiguration>(windowsPhone81CustomConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WindowsPhone81CustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WindowsPhone81CustomConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsPhone81CustomConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WindowsPhone81CustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81CustomConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WindowsPhone81CustomConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsPhone81CustomConfiguration and returns a <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81CustomConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WindowsPhone81CustomConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsPhone81CustomConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToUpdate">The WindowsPhone81CustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81CustomConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> UpdateAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WindowsPhone81CustomConfiguration>(windowsPhone81CustomConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsPhone81CustomConfiguration using PATCH and returns a <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToUpdate">The WindowsPhone81CustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81CustomConfiguration>> UpdateResponseAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WindowsPhone81CustomConfiguration>(windowsPhone81CustomConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsPhone81CustomConfiguration using PUT.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToUpdate">The WindowsPhone81CustomConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> PutAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<WindowsPhone81CustomConfiguration>(windowsPhone81CustomConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsPhone81CustomConfiguration using PUT and returns a <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToUpdate">The WindowsPhone81CustomConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{WindowsPhone81CustomConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsPhone81CustomConfiguration>> PutResponseAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WindowsPhone81CustomConfiguration>(windowsPhone81CustomConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81CustomConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81CustomConfigurationRequest Expand(Expression<Func<WindowsPhone81CustomConfiguration, object>> expandExpression)
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
        public IWindowsPhone81CustomConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81CustomConfigurationRequest Select(Expression<Func<WindowsPhone81CustomConfiguration, object>> selectExpression)
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
        /// <param name="windowsPhone81CustomConfigurationToInitialize">The <see cref="WindowsPhone81CustomConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToInitialize)
        {

        }
    }
}
