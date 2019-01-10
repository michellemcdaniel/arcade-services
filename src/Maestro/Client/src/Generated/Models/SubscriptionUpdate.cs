// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Maestro.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubscriptionUpdate
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionUpdate class.
        /// </summary>
        public SubscriptionUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionUpdate class.
        /// </summary>
        public SubscriptionUpdate(string channelName = default(string), string sourceRepository = default(string), SubscriptionPolicy policy = default(SubscriptionPolicy), bool? enabled = default(bool?))
        {
            ChannelName = channelName;
            SourceRepository = sourceRepository;
            Policy = policy;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channelName")]
        public string ChannelName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceRepository")]
        public string SourceRepository { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public SubscriptionPolicy Policy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Policy != null)
            {
                Policy.Validate();
            }
        }
    }
}
