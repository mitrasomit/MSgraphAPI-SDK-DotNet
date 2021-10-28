// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class SourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ISourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new SourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public SourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISourceCollectionNoncustodialSourcesCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISourceCollectionNoncustodialSourcesCollectionReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new SourceCollectionNoncustodialSourcesCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}