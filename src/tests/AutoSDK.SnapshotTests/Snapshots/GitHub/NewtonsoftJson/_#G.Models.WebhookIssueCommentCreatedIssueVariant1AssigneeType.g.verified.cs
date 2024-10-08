﻿//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant1AssigneeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentCreatedIssueVariant1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1AssigneeType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueVariant1AssigneeType.User => "User",
                WebhookIssueCommentCreatedIssueVariant1AssigneeType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueVariant1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueVariant1AssigneeType.Bot,
                "User" => WebhookIssueCommentCreatedIssueVariant1AssigneeType.User,
                "Organization" => WebhookIssueCommentCreatedIssueVariant1AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueVariant1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}