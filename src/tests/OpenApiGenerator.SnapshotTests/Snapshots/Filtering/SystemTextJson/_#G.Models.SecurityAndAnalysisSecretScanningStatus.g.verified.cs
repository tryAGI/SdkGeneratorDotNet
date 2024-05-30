﻿//HintName: G.Models.SecurityAndAnalysisSecretScanningStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAndAnalysisSecretScanningStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    public static class SecurityAndAnalysisSecretScanningStatusExtensions
    {
        public static string ToValueString(this SecurityAndAnalysisSecretScanningStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningStatus.Enabled => "enabled",
                SecurityAndAnalysisSecretScanningStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisSecretScanningStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisSecretScanningStatus.Enabled,
                "disabled" => SecurityAndAnalysisSecretScanningStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisSecretScanningStatus ToEnum(int value)
        {
            return value switch
            {
                0 => SecurityAndAnalysisSecretScanningStatus.Enabled,
                1 => SecurityAndAnalysisSecretScanningStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}