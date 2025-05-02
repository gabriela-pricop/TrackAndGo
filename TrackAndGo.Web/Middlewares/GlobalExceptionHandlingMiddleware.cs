using System.ComponentModel.DataAnnotations;
using System.Security;
using System.Text.Json;

namespace TrackAndGo.Web.Middlewares
{
    public class GlobalExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;

        public GlobalExceptionHandlingMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An exception occured");
                context.Response.ContentType = "application/json";

                var (statusCode, message) = ex switch
                {
                    ArgumentException => (StatusCodes.Status400BadRequest, "Invalid argument provided."),
                    FormatException => (StatusCodes.Status400BadRequest, "Input format is incorrect."),
                    JsonException => (StatusCodes.Status400BadRequest, "Malformed JSON in request."),
                    UnauthorizedAccessException => (StatusCodes.Status401Unauthorized, "You are not authorized."),
                    SecurityException => (StatusCodes.Status403Forbidden, "Access is forbidden."),
                    KeyNotFoundException => (StatusCodes.Status404NotFound, "The requested resource was not found."),
                    ValidationException => (StatusCodes.Status400BadRequest, ex.Message), 
                    _ => (StatusCodes.Status500InternalServerError, "An unexpected error occurred.")
                };

                context.Response.StatusCode = statusCode;

                var errorResponse = new
                {
                    Message = message
                };

                var json = JsonSerializer.Serialize(errorResponse);
                await context.Response.WriteAsync(json);
            }
        }

    }
}
