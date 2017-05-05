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
    /// The type SharePointSitesCollectionRequestBuilder.
    /// </summary>
    public partial class SharePointSitesCollectionRequestBuilder : BaseRequestBuilder, ISharePointSitesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SharePointSitesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SharePointSitesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISharePointSitesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISharePointSitesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SharePointSitesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISiteRequestBuilder"/> for the specified SharePointSite.
        /// </summary>
        /// <param name="id">The ID for the SharePointSite.</param>
        /// <returns>The <see cref="ISiteRequestBuilder"/>.</returns>
        public ISiteRequestBuilder this[string id]
        {
            get
            {
                return new SiteRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}