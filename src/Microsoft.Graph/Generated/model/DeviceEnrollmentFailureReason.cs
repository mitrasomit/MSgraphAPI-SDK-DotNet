// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DeviceEnrollmentFailureReason.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceEnrollmentFailureReason
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Authentication
        /// </summary>
        Authentication = 1,
	
        /// <summary>
        /// Authorization
        /// </summary>
        Authorization = 2,
	
        /// <summary>
        /// Account Validation
        /// </summary>
        AccountValidation = 3,
	
        /// <summary>
        /// User Validation
        /// </summary>
        UserValidation = 4,
	
        /// <summary>
        /// Device Not Supported
        /// </summary>
        DeviceNotSupported = 5,
	
        /// <summary>
        /// In Maintenance
        /// </summary>
        InMaintenance = 6,
	
        /// <summary>
        /// Bad Request
        /// </summary>
        BadRequest = 7,
	
        /// <summary>
        /// Feature Not Supported
        /// </summary>
        FeatureNotSupported = 8,
	
        /// <summary>
        /// Enrollment Restrictions Enforced
        /// </summary>
        EnrollmentRestrictionsEnforced = 9,
	
        /// <summary>
        /// Client Disconnected
        /// </summary>
        ClientDisconnected = 10,
	
        /// <summary>
        /// User Abandonment
        /// </summary>
        UserAbandonment = 11,
	
    }
}
