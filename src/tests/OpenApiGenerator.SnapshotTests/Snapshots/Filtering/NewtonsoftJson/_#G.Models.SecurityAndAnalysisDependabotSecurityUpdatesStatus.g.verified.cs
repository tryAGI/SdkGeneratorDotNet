﻿//HintName: G.Models.SecurityAndAnalysisDependabotSecurityUpdatesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot security updates for the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAndAnalysisDependabotSecurityUpdatesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
    }

    public static class SecurityAndAnalysisDependabotSecurityUpdatesStatusExtensions
    {
        public static string ToValueString(this SecurityAndAnalysisDependabotSecurityUpdatesStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisDependabotSecurityUpdatesStatus.Enabled => "enabled",
                SecurityAndAnalysisDependabotSecurityUpdatesStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisDependabotSecurityUpdatesStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisDependabotSecurityUpdatesStatus.Enabled,
                "disabled" => SecurityAndAnalysisDependabotSecurityUpdatesStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisDependabotSecurityUpdatesStatus ToEnum(int value)
        {
            return value switch
            {
                0 => SecurityAndAnalysisDependabotSecurityUpdatesStatus.Enabled,
                1 => SecurityAndAnalysisDependabotSecurityUpdatesStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}