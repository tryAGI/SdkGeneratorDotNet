﻿//HintName: G.Models.ChatToolCallStartEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A streamed event delta which signifies a tool call has started streaming.
    /// </summary>
    public readonly partial struct ChatToolCallStartEvent : global::System.IEquatable<ChatToolCallStartEvent>
    {
        /// <summary>
        /// The streamed event types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatStreamEventType? Value1 { get; init; }
#else
        public global::G.ChatStreamEventType? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallStartEvent(global::G.ChatStreamEventType value) => new ChatToolCallStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatStreamEventType?(ChatToolCallStartEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(global::G.ChatStreamEventType? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolCallStartEventVariant2? Value2 { get; init; }
#else
        public global::G.ChatToolCallStartEventVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolCallStartEvent(global::G.ChatToolCallStartEventVariant2 value) => new ChatToolCallStartEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolCallStartEventVariant2?(ChatToolCallStartEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(global::G.ChatToolCallStartEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolCallStartEvent(
            global::G.ChatStreamEventType? value1,
            global::G.ChatToolCallStartEventVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.ChatStreamEventType),
                Value2,
                typeof(global::G.ChatToolCallStartEventVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatToolCallStartEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatStreamEventType?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolCallStartEventVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolCallStartEvent obj1, ChatToolCallStartEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolCallStartEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolCallStartEvent obj1, ChatToolCallStartEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolCallStartEvent o && Equals(o);
        }
    }
}
