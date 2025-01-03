using Xunit;
using Microsoft.AspNetCore.Http;
using Moq;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Text.Json;
using Starcatcher.Api.Infrastructure.Middleware;
using Starcatcher.Api.Common.Exceptions;

public class ExceptionHandlingMiddlewareTest
{
    [Fact]
    public async Task InvokeAsync_ShouldReturnCustomException()
    {
        var context = new DefaultHttpContext();
        var middleware = new ExceptionHandlingMiddleware(async (innerHttpContext) => throw new EmailInUseException());
        context.Response.Body = new MemoryStream();

        await middleware.InvokeAsync(context);

        context.Response.Body.Seek(0, SeekOrigin.Begin);
        var responseBody = new StreamReader(context.Response.Body).ReadToEnd();

        Assert.Contains("Email already in use", responseBody);
    }
}