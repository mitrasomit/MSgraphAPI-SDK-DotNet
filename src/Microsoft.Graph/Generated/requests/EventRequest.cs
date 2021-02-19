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
    /// The type EventRequest.
    /// </summary>
    public partial class EventRequest : BaseRequest, IEventRequest
    {
        /// <summary>
        /// Constructs a new EventRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EventRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Event using POST.
        /// </summary>
        /// <param name="eventToCreate">The Event to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Event.</returns>
        public async System.Threading.Tasks.Task<Event> CreateAsync(Event eventToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<Event>(eventToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Event using POST and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <param name="eventToCreate">The Event to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Event>> CreateResponseAsync(Event eventToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Event>(eventToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Event.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<Event>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Event and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Event.
        /// </summary>
        /// <returns>The Event.</returns>
        public System.Threading.Tasks.Task<Event> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Event.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Event.</returns>
        public async System.Threading.Tasks.Task<Event> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Event>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Event and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Event>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Event and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Event>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Event>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Event using PATCH.
        /// </summary>
        /// <param name="eventToUpdate">The Event to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Event.</returns>
        public async System.Threading.Tasks.Task<Event> UpdateAsync(Event eventToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Event>(eventToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Event using PATCH and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <param name="eventToUpdate">The Event to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Event>> UpdateResponseAsync(Event eventToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Event>(eventToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEventRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEventRequest Expand(Expression<Func<Event, object>> expandExpression)
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
        public IEventRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEventRequest Select(Expression<Func<Event, object>> selectExpression)
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
        /// <param name="eventToInitialize">The <see cref="Event"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Event eventToInitialize)
        {

            if (eventToInitialize != null && eventToInitialize.AdditionalData != null)
            {

                if (eventToInitialize.Attachments != null && eventToInitialize.Attachments.CurrentPage != null)
                {
                    eventToInitialize.Attachments.AdditionalData = eventToInitialize.AdditionalData;

                    object nextPageLink;
                    eventToInitialize.AdditionalData.TryGetValue("attachments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        eventToInitialize.Attachments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (eventToInitialize.Extensions != null && eventToInitialize.Extensions.CurrentPage != null)
                {
                    eventToInitialize.Extensions.AdditionalData = eventToInitialize.AdditionalData;

                    object nextPageLink;
                    eventToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        eventToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (eventToInitialize.Instances != null && eventToInitialize.Instances.CurrentPage != null)
                {
                    eventToInitialize.Instances.AdditionalData = eventToInitialize.AdditionalData;

                    object nextPageLink;
                    eventToInitialize.AdditionalData.TryGetValue("instances@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        eventToInitialize.Instances.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (eventToInitialize.MultiValueExtendedProperties != null && eventToInitialize.MultiValueExtendedProperties.CurrentPage != null)
                {
                    eventToInitialize.MultiValueExtendedProperties.AdditionalData = eventToInitialize.AdditionalData;

                    object nextPageLink;
                    eventToInitialize.AdditionalData.TryGetValue("multiValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        eventToInitialize.MultiValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (eventToInitialize.SingleValueExtendedProperties != null && eventToInitialize.SingleValueExtendedProperties.CurrentPage != null)
                {
                    eventToInitialize.SingleValueExtendedProperties.AdditionalData = eventToInitialize.AdditionalData;

                    object nextPageLink;
                    eventToInitialize.AdditionalData.TryGetValue("singleValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        eventToInitialize.SingleValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
