﻿//HintName: G.FileStorageClient.UploadToFileStorage.g.cs

#nullable enable

namespace G
{
    public partial class FileStorageClient
    {
        partial void PrepareUploadToFileStorageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string name,
            ref string projectId,
            ref int uploadType,
            byte[] request);
        partial void PrepareUploadToFileStorageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string name,
            string projectId,
            int uploadType,
            byte[] request);
        partial void ProcessUploadToFileStorageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessUploadToFileStorageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns data path.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="uploadType"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UploadToFileStorageAsync(
            string token,
            string name,
            string projectId,
            int uploadType,
            byte[] request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/uploadtofilestorage?name={name}&projectId={projectId}&uploadType={uploadType}", global::System.UriKind.RelativeOrAbsolute));
            var __base64 = global::System.Convert.ToBase64String(request);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __base64,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/octet-stream");

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}