﻿//HintName: G.Models.RepositoryRuleBranchNamePatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleBranchNamePatternParametersOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starts_with")]
        StartsWith,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ends_with")]
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regex")]
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleBranchNamePatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleBranchNamePatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleBranchNamePatternParametersOperator.StartsWith => "starts_with",
                RepositoryRuleBranchNamePatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleBranchNamePatternParametersOperator.Contains => "contains",
                RepositoryRuleBranchNamePatternParametersOperator.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleBranchNamePatternParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "starts_with" => RepositoryRuleBranchNamePatternParametersOperator.StartsWith,
                "ends_with" => RepositoryRuleBranchNamePatternParametersOperator.EndsWith,
                "contains" => RepositoryRuleBranchNamePatternParametersOperator.Contains,
                "regex" => RepositoryRuleBranchNamePatternParametersOperator.Regex,
                _ => null,
            };
        }
    }
}