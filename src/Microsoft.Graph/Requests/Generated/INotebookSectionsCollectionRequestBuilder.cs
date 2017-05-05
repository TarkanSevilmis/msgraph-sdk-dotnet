// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface INotebookSectionsCollectionRequestBuilder.
    /// </summary>
    public partial interface INotebookSectionsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        INotebookSectionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        INotebookSectionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ISectionRequestBuilder"/> for the specified Section.
        /// </summary>
        /// <param name="id">The ID for the Section.</param>
        /// <returns>The <see cref="ISectionRequestBuilder"/>.</returns>
        ISectionRequestBuilder this[string id] { get; }

        
    }
}