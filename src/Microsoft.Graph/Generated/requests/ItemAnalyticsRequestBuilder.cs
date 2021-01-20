// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ItemAnalyticsRequestBuilder.
    /// </summary>
    public partial class ItemAnalyticsRequestBuilder : EntityRequestBuilder, IItemAnalyticsRequestBuilder
    {

        /// <summary>
        /// Constructs a new ItemAnalyticsRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ItemAnalyticsRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IItemAnalyticsRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IItemAnalyticsRequest Request(IEnumerable<Option> options)
        {
            return new ItemAnalyticsRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AllTime.
        /// </summary>
        /// <returns>The <see cref="IItemActivityStatWithReferenceRequestBuilder"/>.</returns>
        public IItemActivityStatWithReferenceRequestBuilder AllTime
        {
            get
            {
                return new ItemActivityStatWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("allTime"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ItemActivityStats.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsItemActivityStatsCollectionRequestBuilder"/>.</returns>
        public IItemAnalyticsItemActivityStatsCollectionRequestBuilder ItemActivityStats
        {
            get
            {
                return new ItemAnalyticsItemActivityStatsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("itemActivityStats"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for LastSevenDays.
        /// </summary>
        /// <returns>The <see cref="IItemActivityStatWithReferenceRequestBuilder"/>.</returns>
        public IItemActivityStatWithReferenceRequestBuilder LastSevenDays
        {
            get
            {
                return new ItemActivityStatWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("lastSevenDays"), this.Client);
            }
        }
    
    }
}
