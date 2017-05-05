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
    /// The type BucketRequestBuilder.
    /// </summary>
    public partial class BucketRequestBuilder : EntityRequestBuilder, IBucketRequestBuilder
    {

        /// <summary>
        /// Constructs a new BucketRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BucketRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IBucketRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IBucketRequest Request(IEnumerable<Option> options)
        {
            return new BucketRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IBucketTasksCollectionWithReferencesRequestBuilder"/>.</returns>
        public IBucketTasksCollectionWithReferencesRequestBuilder Tasks
        {
            get
            {
                return new BucketTasksCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }
    
    }
}