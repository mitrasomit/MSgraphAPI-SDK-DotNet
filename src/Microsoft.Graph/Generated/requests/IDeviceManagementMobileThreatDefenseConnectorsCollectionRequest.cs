// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified MobileThreatDefenseConnector to the collection via POST.
        /// </summary>
        /// <param name="mobileThreatDefenseConnector">The MobileThreatDefenseConnector to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileThreatDefenseConnector.</returns>
        System.Threading.Tasks.Task<MobileThreatDefenseConnector> AddAsync(MobileThreatDefenseConnector mobileThreatDefenseConnector, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified MobileThreatDefenseConnector to the collection via POST and returns a <see cref="GraphResponse{MobileThreatDefenseConnector}"/> object of the request.
        /// </summary>
        /// <param name="mobileThreatDefenseConnector">The MobileThreatDefenseConnector to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileThreatDefenseConnector}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileThreatDefenseConnector>> AddResponseAsync(MobileThreatDefenseConnector mobileThreatDefenseConnector, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementMobileThreatDefenseConnectorsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementMobileThreatDefenseConnectorsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementMobileThreatDefenseConnectorsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementMobileThreatDefenseConnectorsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest Expand(Expression<Func<MobileThreatDefenseConnector, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest Select(Expression<Func<MobileThreatDefenseConnector, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequest OrderBy(string value);
    }
}
