// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IEducationClassSchoolsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IEducationClassSchoolsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEducationClassSchoolsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEducationClassSchoolsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IEducationSchoolWithReferenceRequestBuilder"/> for the specified EducationSchool.
        /// </summary>
        /// <param name="id">The ID for the EducationSchool.</param>
        /// <returns>The <see cref="IEducationSchoolWithReferenceRequestBuilder"/>.</returns>
        IEducationSchoolWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IEducationClassSchoolsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEducationClassSchoolsCollectionReferencesRequestBuilder"/>.</returns>
        IEducationClassSchoolsCollectionReferencesRequestBuilder References { get; }

    }
}
