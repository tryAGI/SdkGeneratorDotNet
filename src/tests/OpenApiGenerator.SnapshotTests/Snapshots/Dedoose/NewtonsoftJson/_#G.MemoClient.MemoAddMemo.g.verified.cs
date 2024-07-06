﻿//HintName: G.MemoClient.MemoAddMemo.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MemoClient
    {
        /// <summary>
        /// AddMemo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="dataPath"></param>
        /// <param name="folderIds"></param>
        /// <param name="resources"></param>
        /// <param name="excerpts"></param>
        /// <param name="descriptors"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.MemoAndLinks> MemoAddMemoAsync(
            string token,
            string projectId,
            string title,
            string dataPath,
            global::System.Collections.Generic.IList<string> folderIds,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos> tags,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/memo/addmemo?projectId={projectId}&title={title}&dataPath={dataPath}&{string.Join("&", folderIds.Select(static x => $"folderIds={x}"))}&{string.Join("&", resources.Select(static x => $"resources={x}"))}&{string.Join("&", excerpts.Select(static x => $"excerpts={x}"))}&{string.Join("&", descriptors.Select(static x => $"descriptors={x}"))}&{string.Join("&", tags.Select(static x => $"tags={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MemoAndLinks?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}