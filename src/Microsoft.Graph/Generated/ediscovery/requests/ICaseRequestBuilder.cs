// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ICaseRequestBuilder.
    /// </summary>
    public partial interface ICaseRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ICaseRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ICaseRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for Custodians.
        /// </summary>
        /// <returns>The <see cref="ICaseCustodiansCollectionRequestBuilder"/>.</returns>
        ICaseCustodiansCollectionRequestBuilder Custodians { get; }

        /// <summary>
        /// Gets the request builder for LegalHolds.
        /// </summary>
        /// <returns>The <see cref="ICaseLegalHoldsCollectionRequestBuilder"/>.</returns>
        ICaseLegalHoldsCollectionRequestBuilder LegalHolds { get; }

        /// <summary>
        /// Gets the request builder for NoncustodialDataSources.
        /// </summary>
        /// <returns>The <see cref="ICaseNoncustodialDataSourcesCollectionRequestBuilder"/>.</returns>
        ICaseNoncustodialDataSourcesCollectionRequestBuilder NoncustodialDataSources { get; }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="ICaseOperationsCollectionRequestBuilder"/>.</returns>
        ICaseOperationsCollectionRequestBuilder Operations { get; }

        /// <summary>
        /// Gets the request builder for ReviewSets.
        /// </summary>
        /// <returns>The <see cref="ICaseReviewSetsCollectionRequestBuilder"/>.</returns>
        ICaseReviewSetsCollectionRequestBuilder ReviewSets { get; }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="ICaseSettingsRequestBuilder"/>.</returns>
        ICaseSettingsRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for SourceCollections.
        /// </summary>
        /// <returns>The <see cref="ICaseSourceCollectionsCollectionRequestBuilder"/>.</returns>
        ICaseSourceCollectionsCollectionRequestBuilder SourceCollections { get; }

        /// <summary>
        /// Gets the request builder for Tags.
        /// </summary>
        /// <returns>The <see cref="ICaseTagsCollectionRequestBuilder"/>.</returns>
        ICaseTagsCollectionRequestBuilder Tags { get; }
    
        /// <summary>
        /// Gets the request builder for CaseClose.
        /// </summary>
        /// <returns>The <see cref="ICaseCloseRequestBuilder"/>.</returns>
        ICaseCloseRequestBuilder Close();

        /// <summary>
        /// Gets the request builder for CaseReopen.
        /// </summary>
        /// <returns>The <see cref="ICaseReopenRequestBuilder"/>.</returns>
        ICaseReopenRequestBuilder Reopen();
    
    }
}