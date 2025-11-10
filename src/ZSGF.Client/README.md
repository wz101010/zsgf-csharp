# ZSGF.Client SDK

![NuGet Version](https://img.shields.io/nuget/v/ZSGF.Client)

一个用于调用 ZSGF 服务 API 的 .NET 客户端 SDK，提供简单易用的接口和强大的功能。

## 🚀 快速开始

### 安装

使用 NuGet 包管理器安装：

```bash
# 使用 .NET CLI
dotnet add package ZSGF.Client

# 或者使用 Package Manager Console
Install-Package ZSGF.Client
```

### 基础配置

在您的项目中添加必要的依赖注入配置：

```cs
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        
        // 获取 API 服务
        var accessTokenApi = host.Services.GetRequiredService<IAccessTokenApi>();
        
        // 调用 API
        try
        {
            var response = await accessTokenApi.AccessTokenDeleteAsync("your-token-id");
            var result = response.Ok();
            Console.WriteLine("API 调用成功！");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"API 调用失败: {ex.Message}");
        }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) => 
        Host.CreateDefaultBuilder(args)
            .ConfigureApi((context, options) =>
            {
                // 配置 API 令牌
                var token = new ApiKeyToken("<您的访问令牌>", ClientUtils.ApiKeyHeader.Authorization);
                options.AddTokens(token);

                // 配置令牌提供者（可选）
                options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

                // 配置 JSON 序列化选项（可选）
                options.ConfigureJsonOptions(jsonOptions =>
                {
                    // 添加自定义 JSON 转换器
                });

                // 配置 HTTP 客户端策略
                options.AddApiHttpClients(builder => builder
                    .AddRetryPolicy(retryCount: 3)                           // 重试 3 次
                    .AddTimeoutPolicy(TimeSpan.FromSeconds(30))              // 30 秒超时
                    .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(60))   // 熔断器
                );
            });
}
```

## 📖 详细使用指南

### 1. 令牌配置

SDK 支持多种令牌类型，根据您的 API 安全规范选择：

```cs
// API Key 令牌
var apiKeyToken = new ApiKeyToken("your-api-key", ClientUtils.ApiKeyHeader.Authorization);

// Bearer 令牌
var bearerToken = new BearerToken("your-bearer-token");

// 添加到配置中
options.AddTokens(apiKeyToken);
```

### 2. 错误处理

SDK 提供了多种错误处理方式：

```cs
// 方式 1：使用 ApiResponse 不抛出异常
AccessTokenDeleteApiResponse response = await api.AccessTokenDeleteAsync("token-id");
if (response.IsSuccessStatusCode)
{
    var result = response.Ok();
    // 处理成功结果
}
else
{
    Console.WriteLine($"请求失败: {response.StatusCode} - {response.ReasonPhrase}");
}

// 方式 2：直接获取结果（失败时抛出异常）
try
{
    var result = await api.AccessTokenDeleteAsync("token-id").ConfigureAwait(false);
    // 处理结果
}
catch (ApiException ex)
{
    Console.WriteLine($"API 异常: {ex.ErrorCode} - {ex.Message}");
}

// 方式 3：获取结果或默认值（失败时返回 null）
var resultOrDefault = await api.AccessTokenDeleteOrDefaultAsync("token-id");
if (resultOrDefault != null)
{
    // 处理结果
}
```

### 3. 自定义配置

#### HTTP 客户端配置

```cs
options.AddApiHttpClients(builder => builder
    .AddRetryPolicy(
        retryCount: 3,
        sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
    )
    .AddTimeoutPolicy(TimeSpan.FromSeconds(30))
    .AddCircuitBreakerPolicy(
        handledEventsAllowedBeforeBreaking: 5,
        durationOfBreak: TimeSpan.FromSeconds(30)
    )
);
```

#### 自定义令牌提供者

```cs
public class CustomTokenProvider : ITokenProvider<ApiKeyToken>
{
    public Task<ApiKeyToken> GetTokenAsync(CancellationToken cancellationToken = default)
    {
        // 自定义令牌获取逻辑
        var token = new ApiKeyToken(GetTokenFromSomewhere(), ClientUtils.ApiKeyHeader.Authorization);
        return Task.FromResult(token);
    }
}

// 在配置中使用
options.UseProvider<CustomTokenProvider, ApiKeyToken>();
```

## ❓ 常见问题

### Q1: HTTP 请求失败时的重试机制如何工作？

**A:** SDK 使用 [Polly](https://github.com/App-vNext/Polly) 库处理瞬态故障。您可以在 `ConfigureApi` 方法中配置重试策略：

- **重试次数**: 可配置重试次数和间隔
- **超时处理**: 设置请求超时时间
- **熔断器**: 防止级联故障

### Q2: 令牌是如何管理的？

**A:** 令牌通过 `TokenProvider` 类管理：

- **默认提供者**: `RateLimitProvider` 实现客户端速率限制
- **自定义提供者**: 可以实现 `ITokenProvider` 接口自定义令牌逻辑
- **令牌刷新**: 支持自动令牌刷新机制

### Q3: 如何处理非 2xx 状态码的响应？

**A:** 根据您选择的方法有不同的行为：

| 返回类型 | 行为 | 适用场景 |
|---------|------|----------|
| `ApiResponse<T>` | 不抛异常，通过 `IsSuccessStatusCode` 检查 | 需要处理各种状态码 |
| `T` | 抛出 `ApiException` | 只关心成功情况 |
| `TOrDefault` | 返回 `null` 或默认值 | 失败时使用默认值 |

### Q4: 如何自定义请求和响应处理？

**A:** 使用 API 类的钩子方法：

```cs
public class CustomApi : AccessTokenApi
{
    protected override async Task OnBeforeRequestAsync(HttpRequestMessage request)
    {
        // 请求前处理
        request.Headers.Add("Custom-Header", "Value");
        await base.OnBeforeRequestAsync(request);
    }

    protected override async Task<T> OnAfterResponseAsync<T>(HttpResponseMessage response, T result)
    {
        // 响应后处理
        Console.WriteLine($"响应状态: {response.StatusCode}");
        return await base.OnAfterResponseAsync(response, result);
    }
}
```

## 🔧 高级配置

### 日志记录

```cs
options.ConfigureLogging(logging =>
{
    logging.AddConsole();
    logging.SetMinimumLevel(LogLevel.Information);
});
```

### 自定义 JSON 序列化

```cs
options.ConfigureJsonOptions(jsonOptions =>
{
    jsonOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    jsonOptions.Converters.Add(new DateTimeConverter());
});
```

## 📦 依赖项

| 包名 | 版本要求 | 用途 |
|------|----------|------|
| [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) | ≥ 5.0.0 | 依赖注入和主机服务 |
| [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) | ≥ 5.0.0 | HTTP 客户端工厂 |
| [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) | ≥ 5.0.1 | 弹性和瞬态故障处理 |
| [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) | ≥ 4.7.0 | 数据注解支持 |

## 📞 支持与贡献

- **问题反馈**: [GitHub Issues](https://github.com/wz101010/zsgf-csharp)
- **文档**: [详细文档](https://doc.zashigaofa.com)

## 📄 许可证

本项目采用 [许可证名称] 许可证 - 查看 [LICENSE](LICENSE) 文件了解详情。