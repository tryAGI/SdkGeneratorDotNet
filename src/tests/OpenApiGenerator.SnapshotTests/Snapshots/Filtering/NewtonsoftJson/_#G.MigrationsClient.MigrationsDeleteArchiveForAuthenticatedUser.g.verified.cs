﻿//HintName: G.MigrationsClient.MigrationsDeleteArchiveForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsDeleteArchiveForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int migrationId);
        partial void PrepareMigrationsDeleteArchiveForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int migrationId);
        partial void ProcessMigrationsDeleteArchiveForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessMigrationsDeleteArchiveForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete a user migration archive<br/>
        /// Deletes a previous migration archive. Downloadable migration archives are automatically deleted after seven days. Migration metadata, which is returned in the [List user migrations](https://docs.github.com/rest/migrations/users#list-user-migrations) and [Get a user migration status](https://docs.github.com/rest/migrations/users#get-a-user-migration-status) endpoints, will continue to be available even after an archive is deleted.
        /// </summary>
        /// <param name="migrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> MigrationsDeleteArchiveForAuthenticatedUserAsync(
            int migrationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/migrations/{migrationId}/archive", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}