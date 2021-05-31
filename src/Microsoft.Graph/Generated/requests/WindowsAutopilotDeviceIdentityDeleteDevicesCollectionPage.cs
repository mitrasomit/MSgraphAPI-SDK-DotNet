// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type WindowsAutopilotDeviceIdentityDeleteDevicesCollectionPage.
    /// </summary>
    public partial class WindowsAutopilotDeviceIdentityDeleteDevicesCollectionPage : CollectionPage<DeletedWindowsAutopilotDeviceState>, IWindowsAutopilotDeviceIdentityDeleteDevicesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IWindowsAutopilotDeviceIdentityDeleteDevicesRequest"/> instance.
        /// </summary>
        public IWindowsAutopilotDeviceIdentityDeleteDevicesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new WindowsAutopilotDeviceIdentityDeleteDevicesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}