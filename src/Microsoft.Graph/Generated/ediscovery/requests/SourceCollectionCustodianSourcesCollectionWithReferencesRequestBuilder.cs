// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SourceCollectionCustodianSourcesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class SourceCollectionCustodianSourcesCollectionWithReferencesRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ISourceCollectionCustodianSourcesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new SourceCollectionCustodianSourcesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public SourceCollectionCustodianSourcesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISourceCollectionCustodianSourcesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISourceCollectionCustodianSourcesCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new SourceCollectionCustodianSourcesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDataSourceWithReferenceRequestBuilder"/> for the specified SourceCollectionDataSource.
        /// </summary>
        /// <param name="id">The ID for the SourceCollectionDataSource.</param>
        /// <returns>The <see cref="IDataSourceWithReferenceRequestBuilder"/>.</returns>
        public IDataSourceWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DataSourceWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="ISourceCollectionCustodianSourcesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="ISourceCollectionCustodianSourcesCollectionReferencesRequestBuilder"/>.</returns>
        public ISourceCollectionCustodianSourcesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new SourceCollectionCustodianSourcesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}