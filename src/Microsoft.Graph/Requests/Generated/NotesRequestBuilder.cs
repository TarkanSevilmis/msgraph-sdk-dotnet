// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type NotesRequestBuilder.
    /// </summary>
    public partial class NotesRequestBuilder : EntityRequestBuilder, INotesRequestBuilder
    {

        /// <summary>
        /// Constructs a new NotesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public NotesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new INotesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new INotesRequest Request(IEnumerable<Option> options)
        {
            return new NotesRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Notebooks.
        /// </summary>
        /// <returns>The <see cref="INotesNotebooksCollectionRequestBuilder"/>.</returns>
        public INotesNotebooksCollectionRequestBuilder Notebooks
        {
            get
            {
                return new NotesNotebooksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("notebooks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Sections.
        /// </summary>
        /// <returns>The <see cref="INotesSectionsCollectionRequestBuilder"/>.</returns>
        public INotesSectionsCollectionRequestBuilder Sections
        {
            get
            {
                return new NotesSectionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sections"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SectionGroups.
        /// </summary>
        /// <returns>The <see cref="INotesSectionGroupsCollectionRequestBuilder"/>.</returns>
        public INotesSectionGroupsCollectionRequestBuilder SectionGroups
        {
            get
            {
                return new NotesSectionGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sectionGroups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Pages.
        /// </summary>
        /// <returns>The <see cref="INotesPagesCollectionRequestBuilder"/>.</returns>
        public INotesPagesCollectionRequestBuilder Pages
        {
            get
            {
                return new NotesPagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("pages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Resources.
        /// </summary>
        /// <returns>The <see cref="INotesResourcesCollectionRequestBuilder"/>.</returns>
        public INotesResourcesCollectionRequestBuilder Resources
        {
            get
            {
                return new NotesResourcesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("resources"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="INotesOperationsCollectionRequestBuilder"/>.</returns>
        public INotesOperationsCollectionRequestBuilder Operations
        {
            get
            {
                return new NotesOperationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("operations"), this.Client);
            }
        }
    
    }
}