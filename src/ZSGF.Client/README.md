# ZSGF.Client

## 安装

导航到你的项目目录后，运行以下命令来安装 ZSGF.Client 包：

```bash
dotnet add package ZSGF.Client
```

## 使用方式

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IAccessTokenApi>();
            AccessTokenDeleteApiResponse apiResponse = await api.AccessTokenDeleteAsync("todo");
            JObjectApiResult model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, options) =>
          {
              // 此处令牌的类型取决于 API 安全规范
              ApiKeyToken token = new("<your token>", ClientUtils.ApiKeyHeader.Authorization);
              options.AddTokens(token);

             // 可选择提供令牌的方法，默认为 RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // 如果有的话，添加任何自定义转换器
              });

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // 添加你喜欢的任何中间件
              );
          });
    }
}
```
## 问题

1. HttpRequest 失败和重试机制是怎样的？

如果启用了 supportsRetry，可以在 ConfigureClients 方法中配置 Polly（一种用于处理瞬态故障的库）。

2. 令牌是如何使用的？

令牌由 TokenProvider 类提供。默认情况下使用的是 RateLimitProvider，它将执行客户端速率限制。也可以使用 UseProvider 方法使用其他提供程序。

3. 当服务器响应状态不是 Ok 时，HttpRequest 会抛出错误吗？

这取决于你发起请求的方式。如果返回类型是 ApiResponse，不会抛出错误，不过 Content 属性将为 null。StatusCode 和 ReasonPhrase 属性将包含有关错误的信息。如果返回类型是 T，则会抛出错误。如果返回类型是 TOrDefault，则会返回 null。

4. 如何验证请求和处理响应？

使用 ZSGF.Client.Rest.DefaultApi 命名空间中 Api 类提供的 On 和 After 方法。或者通过使用泛型 ConfigureApi 方法提供你自己的类。

## 依赖

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later