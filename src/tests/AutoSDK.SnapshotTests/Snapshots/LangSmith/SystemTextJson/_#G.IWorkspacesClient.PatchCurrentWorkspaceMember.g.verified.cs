﻿//HintName: G.IWorkspacesClient.PatchCurrentWorkspaceMember.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse> PatchCurrentWorkspaceMemberAsync(
            global::System.Guid identityId,
            global::G.IdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse> PatchCurrentWorkspaceMemberAsync(
            global::System.Guid identityId,
            global::System.Guid roleId,
            global::G.AnyOf<bool?, object>? readOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}