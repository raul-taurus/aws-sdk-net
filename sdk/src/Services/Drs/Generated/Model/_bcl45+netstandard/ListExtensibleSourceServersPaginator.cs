/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Base class for ListExtensibleSourceServers paginators.
    /// </summary>
    internal sealed partial class ListExtensibleSourceServersPaginator : IPaginator<ListExtensibleSourceServersResponse>, IListExtensibleSourceServersPaginator
    {
        private readonly IAmazonDrs _client;
        private readonly ListExtensibleSourceServersRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListExtensibleSourceServersResponse> Responses => new PaginatedResponse<ListExtensibleSourceServersResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Items
        /// </summary>
        public IPaginatedEnumerable<StagingSourceServer> Items => 
            new PaginatedResultKeyResponse<ListExtensibleSourceServersResponse, StagingSourceServer>(this, (i) => i.Items);

        internal ListExtensibleSourceServersPaginator(IAmazonDrs client, ListExtensibleSourceServersRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListExtensibleSourceServersResponse> IPaginator<ListExtensibleSourceServersResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListExtensibleSourceServersResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListExtensibleSourceServers(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListExtensibleSourceServersResponse> IPaginator<ListExtensibleSourceServersResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListExtensibleSourceServersResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListExtensibleSourceServersAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}