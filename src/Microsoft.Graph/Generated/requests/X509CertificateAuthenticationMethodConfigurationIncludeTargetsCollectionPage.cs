// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionPage.
    /// </summary>
    public partial class X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionPage : CollectionPage<AuthenticationMethodTarget>, IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequest"/> instance.
        /// </summary>
        public IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}