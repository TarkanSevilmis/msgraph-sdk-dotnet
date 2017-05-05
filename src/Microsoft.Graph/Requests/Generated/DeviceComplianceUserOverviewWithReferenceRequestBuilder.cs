// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceComplianceUserOverviewWithReferenceRequestBuilder.
    /// </summary>
    public partial class DeviceComplianceUserOverviewWithReferenceRequestBuilder : BaseRequestBuilder, IDeviceComplianceUserOverviewWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceComplianceUserOverviewWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceComplianceUserOverviewWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceComplianceUserOverviewWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceComplianceUserOverviewWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new DeviceComplianceUserOverviewWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the deviceComplianceUserOverview.
        /// </summary>
        /// <returns>The <see cref="IDeviceComplianceUserOverviewReferenceRequestBuilder"/>.</returns>
        public IDeviceComplianceUserOverviewReferenceRequestBuilder Reference
        {
            get
            {
                return new DeviceComplianceUserOverviewReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}