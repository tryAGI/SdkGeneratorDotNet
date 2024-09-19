﻿//HintName: G.TeamsClient.TeamsListDiscussionsInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsListDiscussionsInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref global::G.TeamsListDiscussionsInOrgDirection? direction,
            ref int? perPage,
            ref int? page,
            ref string? pinned);
        partial void PrepareTeamsListDiscussionsInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            global::G.TeamsListDiscussionsInOrgDirection? direction,
            int? perPage,
            int? page,
            string? pinned);
        partial void ProcessTeamsListDiscussionsInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTeamsListDiscussionsInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List discussions<br/>
        /// List all discussions on a team's page.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pinned"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TeamDiscussion>> TeamsListDiscussionsInOrgAsync(
            string org,
            string teamSlug,
            global::G.TeamsListDiscussionsInOrgDirection? direction = global::G.TeamsListDiscussionsInOrgDirection.Desc,
            int? perPage = 30,
            int? page = 1,
            string? pinned = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTeamsListDiscussionsInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page,
                pinned: ref pinned);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/teams/{teamSlug}/discussions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("pinned", pinned) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTeamsListDiscussionsInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                teamSlug: teamSlug,
                direction: direction,
                perPage: perPage,
                page: page,
                pinned: pinned);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTeamsListDiscussionsInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTeamsListDiscussionsInOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.TeamDiscussion>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}