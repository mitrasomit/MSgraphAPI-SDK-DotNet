// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IMailFolderMessagesCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<MailFolderMessagesCollectionPage>))]
    public interface IMailFolderMessagesCollectionPage : ICollectionPage<Message>
    {
        /// <summary>
        /// Gets the next page <see cref="IMailFolderMessagesCollectionRequest"/> instance.
        /// </summary>
        IMailFolderMessagesCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
