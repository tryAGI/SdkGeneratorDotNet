﻿//HintName: G.Models.GlobalEmoteFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GlobalEmoteFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Animated,
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlobalEmoteFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalEmoteFormat value)
        {
            return value switch
            {
                GlobalEmoteFormat.Animated => "animated",
                GlobalEmoteFormat.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalEmoteFormat? ToEnum(string value)
        {
            return value switch
            {
                "animated" => GlobalEmoteFormat.Animated,
                "static" => GlobalEmoteFormat.Static,
                _ => null,
            };
        }
    }
}