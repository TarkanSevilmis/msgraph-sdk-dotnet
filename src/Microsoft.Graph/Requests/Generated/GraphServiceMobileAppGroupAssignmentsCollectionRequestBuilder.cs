// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceMobileAppGroupAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceMobileAppGroupAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceMobileAppGroupAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceMobileAppGroupAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMobileAppGroupAssignmentRequestBuilder"/> for the specified GraphServiceMobileAppGroupAssignment.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceMobileAppGroupAssignment.</param>
        /// <returns>The <see cref="IMobileAppGroupAssignmentRequestBuilder"/>.</returns>
        public IMobileAppGroupAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new MobileAppGroupAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}