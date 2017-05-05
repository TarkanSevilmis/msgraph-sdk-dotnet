// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ISectionGroupRequestBuilder.
    /// </summary>
    public partial interface ISectionGroupRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ISectionGroupRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ISectionGroupRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ParentNotebook.
        /// </summary>
        /// <returns>The <see cref="INotebookRequestBuilder"/>.</returns>
        INotebookRequestBuilder ParentNotebook { get; }

        /// <summary>
        /// Gets the request builder for ParentSectionGroup.
        /// </summary>
        /// <returns>The <see cref="ISectionGroupRequestBuilder"/>.</returns>
        ISectionGroupRequestBuilder ParentSectionGroup { get; }

        /// <summary>
        /// Gets the request builder for Sections.
        /// </summary>
        /// <returns>The <see cref="ISectionGroupSectionsCollectionRequestBuilder"/>.</returns>
        ISectionGroupSectionsCollectionRequestBuilder Sections { get; }

        /// <summary>
        /// Gets the request builder for SectionGroups.
        /// </summary>
        /// <returns>The <see cref="ISectionGroupSectionGroupsCollectionRequestBuilder"/>.</returns>
        ISectionGroupSectionGroupsCollectionRequestBuilder SectionGroups { get; }
    
    }
}