﻿//HintName: G.Models.CharityCampaignDonation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharityCampaignDonation
    {
        /// <summary>
        /// An ID that identifies the donation. The ID is unique across campaigns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the charity campaign that the donation applies to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("campaign_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CampaignId { get; set; } = default!;

        /// <summary>
        /// An ID that identifies a user that donated money to the campaign.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// An object that contains the amount of money that the user donated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CharityCampaignDonationAmount Amount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}