// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequest.
    /// </summary>
    public partial class ServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequest : BaseRequest, IServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new ServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified HomeRealmDiscoveryPolicy to the collection via POST.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicy">The HomeRealmDiscoveryPolicy to add.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicy)
        {
            return this.AddAsync(homeRealmDiscoveryPolicy, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified HomeRealmDiscoveryPolicy to the collection via POST.
        /// </summary>
        /// <param name="homeRealmDiscoveryPolicy">The HomeRealmDiscoveryPolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(HomeRealmDiscoveryPolicy homeRealmDiscoveryPolicy, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";

            if (string.IsNullOrEmpty(homeRealmDiscoveryPolicy.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/policies/homeRealmDiscoveryPolicies/{1}", this.Client.BaseUrl, homeRealmDiscoveryPolicy.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

    }
}
