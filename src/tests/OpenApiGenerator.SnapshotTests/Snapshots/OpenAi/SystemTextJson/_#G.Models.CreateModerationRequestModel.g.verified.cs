﻿//HintName: G.Models.CreateModerationRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        TextModerationLatest,
        /// <summary>
        /// 
        /// </summary>
        TextModerationStable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationRequestModel value)
        {
            return value switch
            {
                CreateModerationRequestModel.TextModerationLatest => "text-moderation-latest",
                CreateModerationRequestModel.TextModerationStable => "text-moderation-stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "text-moderation-latest" => CreateModerationRequestModel.TextModerationLatest,
                "text-moderation-stable" => CreateModerationRequestModel.TextModerationStable,
                _ => null,
            };
        }
    }
}