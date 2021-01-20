// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.CallRecords
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum NetworkConnectionType.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.EnumConverter))]
    public enum NetworkConnectionType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Wired
        /// </summary>
        Wired = 1,
	
        /// <summary>
        /// Wifi
        /// </summary>
        Wifi = 2,
	
        /// <summary>
        /// Mobile
        /// </summary>
        Mobile = 3,
	
        /// <summary>
        /// Tunnel
        /// </summary>
        Tunnel = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
