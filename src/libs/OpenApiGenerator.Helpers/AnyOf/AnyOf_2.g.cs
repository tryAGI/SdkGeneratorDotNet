// This file includes code from the StefH/AnyOf project,
// which is licensed under the MIT license.
// Original code: https://github.com/StefH/AnyOf
// MIT License: https://github.com/StefH/AnyOf/blob/main/LICENSE

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/AnyOf.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Collections.Generic;

#nullable enable

namespace AnyOfTypes
{
    [DebuggerDisplay("{_thisType}, AnyOfType = {_currentType}; Type = {_currentValueType?.Name}; Value = '{ToString()}'")]
    public readonly struct AnyOf<TFirst, TSecond> : IEquatable<AnyOf<TFirst, TSecond>>
    {
        private readonly string _thisType => $"AnyOf<{typeof(TFirst).Name}, {typeof(TSecond).Name}>";

        public bool IsFirst => First != null;
        public bool IsSecond => Second != null;

        public bool Validate()
        {
            return IsAnyOf;
        }
        
        public bool IsAnyOf =>
            IsFirst || IsSecond;
        
        public bool IsOneOf =>
            IsFirst && !IsSecond ||
            !IsFirst && IsSecond;
        
        public bool IsAllOf =>
            IsFirst && IsSecond;

        public static implicit operator AnyOf<TFirst, TSecond>(TFirst value) => new AnyOf<TFirst, TSecond>(value);

        public static implicit operator TFirst?(AnyOf<TFirst, TSecond> @this) => @this.First;

        public AnyOf(TFirst value)
        {
            First = value;
        }

        public TFirst? First { get; init; }

        public static implicit operator AnyOf<TFirst, TSecond>(TSecond value) => new AnyOf<TFirst, TSecond>(value);

        public static implicit operator TSecond?(AnyOf<TFirst, TSecond> @this) => @this.Second;

        public AnyOf(TSecond value)
        {
            Second = value;
        }

        public TSecond? Second { get; init; }

        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                First,
                Second,
                typeof(TFirst),
                typeof(TSecond),
            };
            return HashCodeCalculator.GetHashCode(fields);
        }

        public bool Equals(AnyOf<TFirst, TSecond> other)
        {
            return EqualityComparer<TFirst?>.Default.Equals(First, other.First) &&
                   EqualityComparer<TSecond?>.Default.Equals(Second, other.Second);
        }

        public static bool operator ==(AnyOf<TFirst, TSecond> obj1, AnyOf<TFirst, TSecond> obj2)
        {
            return EqualityComparer<AnyOf<TFirst, TSecond>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(AnyOf<TFirst, TSecond> obj1, AnyOf<TFirst, TSecond> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is AnyOf<TFirst, TSecond> o && Equals(o);
        }

        public override string ToString()
        {
            return $"{First}{Second}";
        }
    }
}
