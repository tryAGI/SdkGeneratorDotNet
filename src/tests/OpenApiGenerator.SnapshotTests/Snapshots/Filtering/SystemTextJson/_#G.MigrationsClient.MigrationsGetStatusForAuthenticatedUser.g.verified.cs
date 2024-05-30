﻿//HintName: G.MigrationsClient.MigrationsGetStatusForAuthenticatedUser.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// Get a user migration status
        /// </summary>
        /// <param name="migrationId"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Migration> MigrationsGetStatusForAuthenticatedUserAsync(
            int migrationId,
            global::System.Collections.Generic.IList<string> exclude,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/migrations/{migrationId}?{string.Join("&", exclude.Select(static x => $"exclude={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Migration?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }
    }
}