﻿//HintName: G.IPackagesClient.PackagesListPackagesForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// List packages for a user<br/>
        /// Lists all packages in a user's namespace for which the requesting user has access.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="username"></param>
        /// <param name="packageType"></param>
        /// <param name="visibility"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Package>> PackagesListPackagesForUserAsync(
            string username,
            global::G.PackagesListPackagesForUserPackageType packageType,
            global::G.PackagesListPackagesForUserVisibility? visibility = default,
            int? page = 1,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}