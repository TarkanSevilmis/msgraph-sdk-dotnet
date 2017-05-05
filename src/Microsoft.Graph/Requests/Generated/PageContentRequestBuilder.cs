// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\StreamRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;

    /// <summary>
    /// The type PageContentRequestBuilder.
    /// </summary>
    public partial class PageContentRequestBuilder : BaseRequestBuilder, IPageContentRequestBuilder
    {
        /// <summary>
        /// Constructs a new PageContentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PageContentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPageContentRequest Request(IEnumerable<Option> options = null)
        {
            return new PageContentRequest(this.RequestUrl, this.Client, options);
        }
    }
}