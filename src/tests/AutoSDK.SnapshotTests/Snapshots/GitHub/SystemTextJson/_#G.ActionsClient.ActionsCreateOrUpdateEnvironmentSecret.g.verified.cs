﻿//HintName: G.ActionsClient.ActionsCreateOrUpdateEnvironmentSecret.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsCreateOrUpdateEnvironmentSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string environmentName,
            ref string secretName,
            global::G.ActionsCreateOrUpdateEnvironmentSecretRequest request);
        partial void PrepareActionsCreateOrUpdateEnvironmentSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string environmentName,
            string secretName,
            global::G.ActionsCreateOrUpdateEnvironmentSecretRequest request);
        partial void ProcessActionsCreateOrUpdateEnvironmentSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsCreateOrUpdateEnvironmentSecretResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update an environment secret<br/>
        /// Creates or updates an environment secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsCreateOrUpdateEnvironmentSecretAsync(
            string owner,
            string repo,
            string environmentName,
            string secretName,
            global::G.ActionsCreateOrUpdateEnvironmentSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsCreateOrUpdateEnvironmentSecretArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                environmentName: ref environmentName,
                secretName: ref secretName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}/secrets/{secretName}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsCreateOrUpdateEnvironmentSecretRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                secretName: secretName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsCreateOrUpdateEnvironmentSecretResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsCreateOrUpdateEnvironmentSecretResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmptyObject?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update an environment secret<br/>
        /// Creates or updates an environment secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="secretName"></param>
        /// <param name="encryptedValue">
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an environment public key](https://docs.github.com/rest/actions/secrets#get-an-environment-public-key) endpoint.
        /// </param>
        /// <param name="keyId">
        /// ID of the key you used to encrypt the secret.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsCreateOrUpdateEnvironmentSecretAsync(
            string owner,
            string repo,
            string environmentName,
            string secretName,
            string encryptedValue,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsCreateOrUpdateEnvironmentSecretRequest
            {
                EncryptedValue = encryptedValue,
                KeyId = keyId,
            };

            return await ActionsCreateOrUpdateEnvironmentSecretAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                secretName: secretName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}