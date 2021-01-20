// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServicePrincipalTransitiveMemberOfCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServicePrincipalTransitiveMemberOfCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalTransitiveMemberOfCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectWithReferenceRequestBuilder"/> for the specified ServicePrincipalDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipalDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalTransitiveMemberOfCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTransitiveMemberOfCollectionReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalTransitiveMemberOfCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ServicePrincipalTransitiveMemberOfCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
