// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ICloudCommunicationsRequestBuilder.
    /// </summary>
    public partial interface ICloudCommunicationsRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ICloudCommunicationsRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ICloudCommunicationsRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Calls.
        /// </summary>
        /// <returns>The <see cref="ICloudCommunicationsCallsCollectionRequestBuilder"/>.</returns>
        ICloudCommunicationsCallsCollectionRequestBuilder Calls { get; }

        /// <summary>
        /// Gets the request builder for CallRecords.
        /// </summary>
        /// <returns>The <see cref="ICloudCommunicationsCallRecordsCollectionRequestBuilder"/>.</returns>
        ICloudCommunicationsCallRecordsCollectionRequestBuilder CallRecords { get; }

        /// <summary>
        /// Gets the request builder for OnlineMeetings.
        /// </summary>
        /// <returns>The <see cref="ICloudCommunicationsOnlineMeetingsCollectionRequestBuilder"/>.</returns>
        ICloudCommunicationsOnlineMeetingsCollectionRequestBuilder OnlineMeetings { get; }

        /// <summary>
        /// Gets the request builder for Presences.
        /// </summary>
        /// <returns>The <see cref="ICloudCommunicationsPresencesCollectionRequestBuilder"/>.</returns>
        ICloudCommunicationsPresencesCollectionRequestBuilder Presences { get; }
    
        /// <summary>
        /// Gets the request builder for CloudCommunicationsGetPresencesByUserId.
        /// </summary>
        /// <returns>The <see cref="ICloudCommunicationsGetPresencesByUserIdRequestBuilder"/>.</returns>
        ICloudCommunicationsGetPresencesByUserIdRequestBuilder GetPresencesByUserId(
            IEnumerable<string> ids);
    
    }
}
