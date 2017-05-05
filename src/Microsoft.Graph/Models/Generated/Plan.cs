// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Plan.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Plan : Entity
    {
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owner", Required = Newtonsoft.Json.Required.Default)]
        public string Owner { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets is visible in planner web client.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isVisibleInPlannerWebClient", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsVisibleInPlannerWebClient { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tasks", Required = Newtonsoft.Json.Required.Default)]
        public IPlanTasksCollectionWithReferencesPage Tasks { get; set; }
    
        /// <summary>
        /// Gets or sets buckets.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "buckets", Required = Newtonsoft.Json.Required.Default)]
        public IPlanBucketsCollectionWithReferencesPage Buckets { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "details", Required = Newtonsoft.Json.Required.Default)]
        public PlanDetails Details { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to task board.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedToTaskBoard", Required = Newtonsoft.Json.Required.Default)]
        public PlanTaskBoard AssignedToTaskBoard { get; set; }
    
        /// <summary>
        /// Gets or sets progress task board.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "progressTaskBoard", Required = Newtonsoft.Json.Required.Default)]
        public PlanTaskBoard ProgressTaskBoard { get; set; }
    
        /// <summary>
        /// Gets or sets bucket task board.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bucketTaskBoard", Required = Newtonsoft.Json.Required.Default)]
        public PlanTaskBoard BucketTaskBoard { get; set; }
    
    }
}
