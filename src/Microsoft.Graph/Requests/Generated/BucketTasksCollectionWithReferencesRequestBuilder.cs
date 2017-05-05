// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type BucketTasksCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class BucketTasksCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IBucketTasksCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new BucketTasksCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BucketTasksCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IBucketTasksCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IBucketTasksCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new BucketTasksCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITaskWithReferenceRequestBuilder"/> for the specified BucketTask.
        /// </summary>
        /// <param name="id">The ID for the BucketTask.</param>
        /// <returns>The <see cref="ITaskWithReferenceRequestBuilder"/>.</returns>
        public ITaskWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new TaskWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IBucketTasksCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IBucketTasksCollectionReferencesRequestBuilder"/>.</returns>
        public IBucketTasksCollectionReferencesRequestBuilder References
        {
            get
            {
                return new BucketTasksCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}