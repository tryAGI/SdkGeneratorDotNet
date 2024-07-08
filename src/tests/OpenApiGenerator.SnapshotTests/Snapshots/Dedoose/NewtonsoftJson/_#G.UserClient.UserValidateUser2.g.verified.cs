﻿//HintName: G.UserClient.UserValidateUser2.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserValidateUser2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string username,
            ref string rsaEncryptedPass,
            ref string connectionKey);
        partial void PrepareUserValidateUser2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string username,
            string rsaEncryptedPass,
            string connectionKey);
        partial void ProcessUserValidateUser2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessUserValidateUser2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ValidateUser2.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPass"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ValidateUserResult> UserValidateUser2Async(
            string token,
            string username,
            string rsaEncryptedPass,
            string connectionKey,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/user/validateuser2?username={username}&rsaEncryptedPass={rsaEncryptedPass}&connectionKey={connectionKey}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ValidateUserResult?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}