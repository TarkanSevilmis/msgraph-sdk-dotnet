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
    /// The type MobileAppRequestBuilder.
    /// </summary>
    public partial class MobileAppRequestBuilder : EntityRequestBuilder, IMobileAppRequestBuilder
    {

        /// <summary>
        /// Constructs a new MobileAppRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MobileAppRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMobileAppRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMobileAppRequest Request(IEnumerable<Option> options)
        {
            return new MobileAppRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Categories.
        /// </summary>
        /// <returns>The <see cref="IMobileAppCategoriesCollectionRequestBuilder"/>.</returns>
        public IMobileAppCategoriesCollectionRequestBuilder Categories
        {
            get
            {
                return new MobileAppCategoriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("categories"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for GroupAssignments.
        /// </summary>
        /// <returns>The <see cref="IMobileAppGroupAssignmentsCollectionRequestBuilder"/>.</returns>
        public IMobileAppGroupAssignmentsCollectionRequestBuilder GroupAssignments
        {
            get
            {
                return new MobileAppGroupAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("groupAssignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for InstallSummary.
        /// </summary>
        /// <returns>The <see cref="IMobileAppInstallSummaryRequestBuilder"/>.</returns>
        public IMobileAppInstallSummaryRequestBuilder InstallSummary
        {
            get
            {
                return new MobileAppInstallSummaryRequestBuilder(this.AppendSegmentToRequestUrl("installSummary"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatuses.
        /// </summary>
        /// <returns>The <see cref="IMobileAppDeviceStatusesCollectionRequestBuilder"/>.</returns>
        public IMobileAppDeviceStatusesCollectionRequestBuilder DeviceStatuses
        {
            get
            {
                return new MobileAppDeviceStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatuses.
        /// </summary>
        /// <returns>The <see cref="IMobileAppUserStatusesCollectionRequestBuilder"/>.</returns>
        public IMobileAppUserStatusesCollectionRequestBuilder UserStatuses
        {
            get
            {
                return new MobileAppUserStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userStatuses"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for MobileAppAssign.
        /// </summary>
        /// <returns>The <see cref="IMobileAppAssignRequestBuilder"/>.</returns>
        public IMobileAppAssignRequestBuilder Assign(
            IEnumerable<MobileAppGroupAssignment> mobileAppGroupAssignments = null)
        {
            return new MobileAppAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                mobileAppGroupAssignments);
        }

        /// <summary>
        /// Gets the request builder for MobileAppGetMobileAppCount.
        /// </summary>
        /// <returns>The <see cref="IMobileAppGetMobileAppCountRequestBuilder"/>.</returns>
        public IMobileAppGetMobileAppCountRequestBuilder GetMobileAppCount(
            ResultantAppState status)
        {
            return new MobileAppGetMobileAppCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getMobileAppCount"),
                this.Client,
                status);
        }

        /// <summary>
        /// Gets the request builder for MobileAppGetTopMobileApps.
        /// </summary>
        /// <returns>The <see cref="IMobileAppGetTopMobileAppsRequestBuilder"/>.</returns>
        public IMobileAppGetTopMobileAppsRequestBuilder GetTopMobileApps(
            ResultantAppState status,
            Int64 count)
        {
            return new MobileAppGetTopMobileAppsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getTopMobileApps"),
                this.Client,
                status,
                count);
        }
    
    }
}