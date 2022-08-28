namespace Microsoft.AspNetCore.Builder;

public static class ErpApplicationBuilderExtensionsExtensions
{
    /// <summary>
    /// 记录请求响应日志
    /// </summary>
    /// <returns></returns>
    public static IApplicationBuilder UseRequestLog(this IApplicationBuilder app)
    {
        return app.UseMiddleware<RequestLogMiddleware>();
    }
}