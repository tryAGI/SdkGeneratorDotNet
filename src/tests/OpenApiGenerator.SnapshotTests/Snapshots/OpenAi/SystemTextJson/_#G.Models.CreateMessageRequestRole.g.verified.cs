﻿//HintName: G.Models.CreateMessageRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the entity that is creating the message. Allowed values include:
    /// - `user`: Indicates the message is sent by an actual user and should be used in most cases to represent user-generated messages.
    /// - `assistant`: Indicates the message is generated by the assistant. Use this value to insert messages from the assistant into the conversation.
    /// </summary>
    public enum CreateMessageRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageRequestRole value)
        {
            return value switch
            {
                CreateMessageRequestRole.User => "user",
                CreateMessageRequestRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => CreateMessageRequestRole.User,
                "assistant" => CreateMessageRequestRole.Assistant,
                _ => null,
            };
        }
    }
}