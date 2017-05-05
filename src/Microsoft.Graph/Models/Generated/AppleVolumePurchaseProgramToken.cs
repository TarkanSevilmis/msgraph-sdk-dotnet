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
    /// The type Apple Volume Purchase Program Token.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AppleVolumePurchaseProgramToken : Entity
    {
    
        /// <summary>
        /// Gets or sets organization name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizationName", Required = Newtonsoft.Json.Required.Default)]
        public string OrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets volume purchase program token account type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "volumePurchaseProgramTokenAccountType", Required = Newtonsoft.Json.Required.Default)]
        public VolumePurchaseProgramTokenAccountType? VolumePurchaseProgramTokenAccountType { get; set; }
    
        /// <summary>
        /// Gets or sets apple id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleId", Required = Newtonsoft.Json.Required.Default)]
        public string AppleId { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "token", Required = Newtonsoft.Json.Required.Default)]
        public string Token { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public VolumePurchaseProgramTokenState? State { get; set; }
    
        /// <summary>
        /// Gets or sets last sync status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncStatus", Required = Newtonsoft.Json.Required.Default)]
        public VolumePurchaseProgramTokenSyncStatus? LastSyncStatus { get; set; }
    
    }
}
