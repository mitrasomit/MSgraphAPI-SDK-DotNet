// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ISourceCollectionNoncustodialSourcesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface ISourceCollectionNoncustodialSourcesCollectionWithReferencesRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISourceCollectionNoncustodialSourcesCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISourceCollectionNoncustodialSourcesCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="INoncustodialDataSourceWithReferenceRequestBuilder"/> for the specified NoncustodialDataSource.
        /// </summary>
        /// <param name="id">The ID for the NoncustodialDataSource.</param>
        /// <returns>The <see cref="INoncustodialDataSourceWithReferenceRequestBuilder"/>.</returns>
        INoncustodialDataSourceWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="ISourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="ISourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder"/>.</returns>
        ISourceCollectionNoncustodialSourcesCollectionReferencesRequestBuilder References { get; }

    }
}