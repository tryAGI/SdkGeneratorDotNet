﻿//HintName: G.ExportClient.ExportStartExportHierarchicalChartJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExportClient
    {
        /// <summary>
        /// StartExportHierarchicalChartJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="parentItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ExportStartExportHierarchicalChartJobAsync(
            string token,
            string projectId,
            string title,
            global::System.Collections.Generic.IList<ChartHierarchicalItemInfo> parentItems,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/export/startexporthierarchicalchartjob?projectId={projectId}&Title={title}&{string.Join("&", parentItems.Select(static x => $"parentItems={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}