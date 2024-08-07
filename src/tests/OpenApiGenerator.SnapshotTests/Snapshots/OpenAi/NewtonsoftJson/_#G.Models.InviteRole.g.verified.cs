﻿//HintName: G.Models.InviteRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `reader`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InviteRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reader")]
        Reader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteRole value)
        {
            return value switch
            {
                InviteRole.Owner => "owner",
                InviteRole.Reader => "reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => InviteRole.Owner,
                "reader" => InviteRole.Reader,
                _ => null,
            };
        }
    }
}