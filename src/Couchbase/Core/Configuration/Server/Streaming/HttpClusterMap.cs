using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Couchbase.Core.Configuration.Server.Streaming
{
    /// <summary>
    /// For mocking/testing
    /// </summary>
    internal abstract class HttpClusterMapBase
    {
        public abstract Task<BucketConfig> GetClusterMapAsync(string bucketName, HostEndpoint hostEndpoint,
            CancellationToken cancellationToken);
    }

    internal class HttpClusterMap : HttpClusterMapBase
    {
        private readonly HttpClient _httpClient;
        public const string Path = "/pools/default/b/";
        private readonly ClusterContext _context;

        public HttpClusterMap(HttpClient httpClient, ClusterContext context)
        {
            _httpClient = httpClient;
            _context = context;
        }

        public override async Task<BucketConfig> GetClusterMapAsync(string bucketName, HostEndpoint hostEndpoint,
            CancellationToken cancellationToken)
        {
            var uri = new UriBuilder
            {
                Scheme = _context.ClusterOptions.EffectiveEnableTls ? Uri.UriSchemeHttps : Uri.UriSchemeHttp,
                Host = hostEndpoint.Host,
                Port = _context.ClusterOptions.EffectiveEnableTls
                    ? _context.ClusterOptions.BootstrapHttpPortTls
                    : _context.ClusterOptions.BootstrapHttpPort,
                Path = Path + bucketName
            };

            using (var response = await _httpClient.GetAsync(uri.Uri, cancellationToken).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var bucketConfig = JsonConvert.DeserializeObject<BucketConfig>(json);
                bucketConfig.ReplacePlaceholderWithBootstrapHost(uri.Host);
                return bucketConfig;
            }
        }
    }
}
