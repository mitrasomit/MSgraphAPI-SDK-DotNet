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
    /// The type AgreementFileLocalizationRequest.
    /// </summary>
    public partial class AgreementFileLocalizationRequest : BaseRequest, IAgreementFileLocalizationRequest
    {
        /// <summary>
        /// Constructs a new AgreementFileLocalizationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AgreementFileLocalizationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AgreementFileLocalization using POST.
        /// </summary>
        /// <param name="agreementFileLocalizationToCreate">The AgreementFileLocalization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AgreementFileLocalization.</returns>
        public async System.Threading.Tasks.Task<AgreementFileLocalization> CreateAsync(AgreementFileLocalization agreementFileLocalizationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AgreementFileLocalization>(agreementFileLocalizationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AgreementFileLocalization using POST and returns a <see cref="GraphResponse{AgreementFileLocalization}"/> object.
        /// </summary>
        /// <param name="agreementFileLocalizationToCreate">The AgreementFileLocalization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileLocalization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AgreementFileLocalization>> CreateResponseAsync(AgreementFileLocalization agreementFileLocalizationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AgreementFileLocalization>(agreementFileLocalizationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AgreementFileLocalization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AgreementFileLocalization>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AgreementFileLocalization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AgreementFileLocalization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AgreementFileLocalization.</returns>
        public async System.Threading.Tasks.Task<AgreementFileLocalization> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AgreementFileLocalization>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AgreementFileLocalization and returns a <see cref="GraphResponse{AgreementFileLocalization}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileLocalization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AgreementFileLocalization>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AgreementFileLocalization>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AgreementFileLocalization using PATCH.
        /// </summary>
        /// <param name="agreementFileLocalizationToUpdate">The AgreementFileLocalization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AgreementFileLocalization.</returns>
        public async System.Threading.Tasks.Task<AgreementFileLocalization> UpdateAsync(AgreementFileLocalization agreementFileLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AgreementFileLocalization>(agreementFileLocalizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AgreementFileLocalization using PATCH and returns a <see cref="GraphResponse{AgreementFileLocalization}"/> object.
        /// </summary>
        /// <param name="agreementFileLocalizationToUpdate">The AgreementFileLocalization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AgreementFileLocalization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AgreementFileLocalization>> UpdateResponseAsync(AgreementFileLocalization agreementFileLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AgreementFileLocalization>(agreementFileLocalizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AgreementFileLocalization using PUT.
        /// </summary>
        /// <param name="agreementFileLocalizationToUpdate">The AgreementFileLocalization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AgreementFileLocalization> PutAsync(AgreementFileLocalization agreementFileLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AgreementFileLocalization>(agreementFileLocalizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AgreementFileLocalization using PUT and returns a <see cref="GraphResponse{AgreementFileLocalization}"/> object.
        /// </summary>
        /// <param name="agreementFileLocalizationToUpdate">The AgreementFileLocalization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AgreementFileLocalization}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AgreementFileLocalization>> PutResponseAsync(AgreementFileLocalization agreementFileLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AgreementFileLocalization>(agreementFileLocalizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAgreementFileLocalizationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAgreementFileLocalizationRequest Expand(Expression<Func<AgreementFileLocalization, object>> expandExpression)
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
        public IAgreementFileLocalizationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAgreementFileLocalizationRequest Select(Expression<Func<AgreementFileLocalization, object>> selectExpression)
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
        /// <param name="agreementFileLocalizationToInitialize">The <see cref="AgreementFileLocalization"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AgreementFileLocalization agreementFileLocalizationToInitialize)
        {

            if (agreementFileLocalizationToInitialize != null)
            {
                if (agreementFileLocalizationToInitialize.Versions != null && agreementFileLocalizationToInitialize.Versions.CurrentPage != null)
                {
                    agreementFileLocalizationToInitialize.Versions.InitializeNextPageRequest(this.Client, agreementFileLocalizationToInitialize.VersionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    agreementFileLocalizationToInitialize.Versions.AdditionalData = agreementFileLocalizationToInitialize.AdditionalData;
                }

            }


        }
    }
}
