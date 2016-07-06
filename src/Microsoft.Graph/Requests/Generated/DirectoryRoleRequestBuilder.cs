// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DirectoryRoleRequestBuilder.
    /// </summary>
    public partial class DirectoryRoleRequestBuilder : DirectoryObjectRequestBuilder, IDirectoryRoleRequestBuilder
    {

        /// <summary>
        /// Constructs a new DirectoryRoleRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DirectoryRoleRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDirectoryRoleRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDirectoryRoleRequest Request(IEnumerable<Option> options)
        {
            return new DirectoryRoleRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IDirectoryRoleMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IDirectoryRoleMembersCollectionWithReferencesRequestBuilder Members
        {
            get
            {
                return new DirectoryRoleMembersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("members"), this.Client);
            }
        }
    
    }
}
