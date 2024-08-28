﻿//HintName: G.Api.ConvertDocumentFileStudioV1ChatFilesConvertPost.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareConvertDocumentFileStudioV1ChatFilesConvertPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost request);
        partial void PrepareConvertDocumentFileStudioV1ChatFilesConvertPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost request);
        partial void ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Convert Document File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ConvertDocumentFileStudioV1ChatFilesConvertPostResponse> ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
            global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareConvertDocumentFileStudioV1ChatFilesConvertPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/studio/v1/chat/files/convert", global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", request.Files.Select(x => x))}]"),
                name: "files");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareConvertDocumentFileStudioV1ChatFilesConvertPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ConvertDocumentFileStudioV1ChatFilesConvertPostResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Convert Document File
        /// </summary>
        /// <param name="files"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ConvertDocumentFileStudioV1ChatFilesConvertPostResponse> ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost
            {
                Files = files,
            };

            return await ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}