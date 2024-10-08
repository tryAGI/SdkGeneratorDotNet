﻿//HintName: G.IIssuesClient.IssuesListEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List issue events<br/>
        /// Lists all events for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.IssueEventForIssue>> IssuesListEventsAsync(
            string owner,
            string repo,
            int issueNumber,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}