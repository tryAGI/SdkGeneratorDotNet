﻿//HintName: G.Models.RepositoryMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MERGE_MESSAGE")]
        MERGEMESSAGE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryMergeCommitTitle value)
        {
            return value switch
            {
                RepositoryMergeCommitTitle.PRTITLE => "PR_TITLE",
                RepositoryMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => RepositoryMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => RepositoryMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}