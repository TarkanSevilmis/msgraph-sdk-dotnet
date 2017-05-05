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
    /// The type Targeted Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TargetedManagedAppProtection : ManagedAppProtection
    {
    
        protected internal TargetedManagedAppProtection()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets targeted security groups count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedSecurityGroupsCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TargetedSecurityGroupsCount { get; set; }
    
        /// <summary>
        /// Gets or sets targeted security group ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedSecurityGroupIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TargetedSecurityGroupIds { get; set; }
    
        /// <summary>
        /// Gets or sets targeted security groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedSecurityGroups", Required = Newtonsoft.Json.Required.Default)]
        public ITargetedManagedAppProtectionTargetedSecurityGroupsCollectionWithReferencesPage TargetedSecurityGroups { get; set; }
    
    }
}
