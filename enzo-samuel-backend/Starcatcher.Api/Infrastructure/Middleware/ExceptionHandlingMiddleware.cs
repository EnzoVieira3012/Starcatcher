using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Starcatcher.Api.Common.Exceptions;

namespace Starcatcher.Api.Infrastructure.Middleware
{
    public class ExceptionHandlingMiddleware(RequestDelegate next)
    {
        private readonly RequestDelegate _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ConsortiumIsClosedException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.BadRequest, ex.ErrorCode);
            }
            catch (ConsortiumNotFoundException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.NotFound, ex.ErrorCode);
            }
            catch (EmailInUseException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.Conflict, ex.ErrorCode);
            }
            catch (InsufficientBalanceException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.Forbidden, ex.ErrorCode);
            }
            catch (InvalidCredentialsException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.Unauthorized, ex.ErrorCode);
            }
            catch (QuotaNotFoundException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.NotFound, ex.ErrorCode);
            }
            catch (QuotaNumberInUseException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.Conflict, ex.ErrorCode);
            }
            catch (UnauthorizedException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.Unauthorized, ex.ErrorCode);
            }
            catch (UserNotFoundException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.NotFound, ex.ErrorCode);
            }
            catch (WalletNotFoundException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.NotFound, ex.ErrorCode);
            }
            catch (UnavailableQuotaException ex)
            {
                await HandleExceptionAsync(context, ex.Message, (int)HttpStatusCode.BadRequest, ex.ErrorCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                await HandleExceptionAsync(context, "An unexpected error occurred.", (int)HttpStatusCode.InternalServerError, 500);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, string message, int statusCode, int errorCode)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var response = new
            {
                message,
                errorCode 
            };

            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}