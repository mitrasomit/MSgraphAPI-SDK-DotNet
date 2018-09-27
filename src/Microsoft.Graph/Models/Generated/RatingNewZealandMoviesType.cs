// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RatingNewZealandMoviesType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RatingNewZealandMoviesType
    {
    
        /// <summary>
        /// all Allowed
        /// </summary>
        AllAllowed = 0,
	
        /// <summary>
        /// all Blocked
        /// </summary>
        AllBlocked = 1,
	
        /// <summary>
        /// general
        /// </summary>
        General = 2,
	
        /// <summary>
        /// parental Guidance
        /// </summary>
        ParentalGuidance = 3,
	
        /// <summary>
        /// mature
        /// </summary>
        Mature = 4,
	
        /// <summary>
        /// ages Above13
        /// </summary>
        AgesAbove13 = 5,
	
        /// <summary>
        /// ages Above15
        /// </summary>
        AgesAbove15 = 6,
	
        /// <summary>
        /// ages Above16
        /// </summary>
        AgesAbove16 = 7,
	
        /// <summary>
        /// ages Above18
        /// </summary>
        AgesAbove18 = 8,
	
        /// <summary>
        /// restricted
        /// </summary>
        Restricted = 9,
	
        /// <summary>
        /// ages Above16Restricted
        /// </summary>
        AgesAbove16Restricted = 10,
	
    }
}