﻿//HintName: G.AdsClient.StartCommercial.g.cs

#nullable enable

namespace G
{
    public partial class AdsClient
    {
        partial void PrepareStartCommercialArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.StartCommercialBody request);
        partial void PrepareStartCommercialRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.StartCommercialBody request);
        partial void ProcessStartCommercialResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartCommercialResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Starts a commercial on the specified channel.<br/>
        /// Starts a commercial on the specified channel.<br/>
        /// **NOTE**: Only partners and affiliates may run commercials and they must be streaming live at the time.<br/>
        /// **NOTE**: Only the broadcaster may start a commercial; the broadcaster’s editors and moderators may not start commercials on behalf of the broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:edit:commercial** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StartCommercialResponse> StartCommercialAsync(
            global::G.StartCommercialBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStartCommercialArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/channels/commercial", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStartCommercialRequest(
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
            ProcessStartCommercialResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStartCommercialResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.StartCommercialResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Starts a commercial on the specified channel.<br/>
        /// Starts a commercial on the specified channel.<br/>
        /// **NOTE**: Only partners and affiliates may run commercials and they must be streaming live at the time.<br/>
        /// **NOTE**: Only the broadcaster may start a commercial; the broadcaster’s editors and moderators may not start commercials on behalf of the broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:edit:commercial** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="length"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StartCommercialResponse> StartCommercialAsync(
            string broadcasterId,
            int length,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.StartCommercialBody
            {
                BroadcasterId = broadcasterId,
                Length = length,
            };

            return await StartCommercialAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}