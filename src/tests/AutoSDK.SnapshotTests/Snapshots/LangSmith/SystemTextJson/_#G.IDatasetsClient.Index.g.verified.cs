﻿//HintName: G.IDatasetsClient.Index.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Index<br/>
        /// Index a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexApiV1DatasetsDatasetIdIndexPostResponse> IndexAsync(
            global::System.Guid datasetId,
            global::G.DatasetIndexRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Index<br/>
        /// Index a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="tag">
        /// Default Value: latest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexApiV1DatasetsDatasetIdIndexPostResponse> IndexAsync(
            global::System.Guid datasetId,
            global::G.AnyOf<string, object>? tag = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}