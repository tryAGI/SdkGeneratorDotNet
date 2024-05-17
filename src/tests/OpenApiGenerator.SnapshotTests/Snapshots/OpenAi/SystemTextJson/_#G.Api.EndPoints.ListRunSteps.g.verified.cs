﻿//HintName: G.Api.EndPoints.ListRunSteps.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Returns a list of run steps belonging to a run.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ListRunStepsResponse> ListRunStepsAsync(
            string threadId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: $"/threads/{threadId}/runs/{runId}/steps");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ListRunStepsResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}