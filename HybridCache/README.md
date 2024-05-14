# .NET 9 Hybrid Cache

## Existing Solutions for Caching

### `IMemoryCache` for Locally Caching Requests

- Built-in caching mechanism that allows caching data in-memory on the server.
- Limitations:
  - *Scaling Application Server to Multiple Instances*: Each instance will have its own isolated memory cache.
  - *Stampede Problem*: Occurs when multiple requests try to access the same uncached data simultaneously.

### Redis `IDistributedCache` for Distributed Caching

- The `IDistributedCache` interface provides an abstraction over various distributed caching implementations, including Redis.
- Limitations:
  - *Stampede Problem*: If the cached data expires or is evicted, multiple concurrent requests can trigger requests to fetch the uncached data from the original data source simultaneously, leading to a stampede of requests. Redis provides mechanisms like distributed locks and semaphores to mitigate this problem.

### Hybrid Cache
