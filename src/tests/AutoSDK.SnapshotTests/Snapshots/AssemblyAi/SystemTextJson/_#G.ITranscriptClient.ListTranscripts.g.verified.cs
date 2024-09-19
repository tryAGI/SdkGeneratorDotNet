﻿//HintName: G.ITranscriptClient.ListTranscripts.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// List transcripts<br/>
        /// Retrieve a list of transcripts you created.<br/>
        /// Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </summary>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptList> ListTranscriptsAsync(
            global::G.TranscriptStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}