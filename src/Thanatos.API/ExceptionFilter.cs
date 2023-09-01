using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using Thanatos.API.Infrastructure.Exceptions;

namespace Thanatos.API
{
    internal class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            switch (context.Exception)
            {
                case ValidationException: OnValidationException(context); break;
                case NotFoundException: OnNotFoundException(context); break;
            }
        }

        private static void OnValidationException(ExceptionContext context)
        {
            var errors = ((ValidationException)context.Exception).Errors.Select(e => new { e.PropertyName, e.ErrorMessage });

            context.Result = new JsonResult(new { Errors = errors })
            {
                StatusCode = 400 // Bad Request
            };

            context.ExceptionHandled = true;
        }

        private static void OnNotFoundException(ExceptionContext context)
        {
            context.Result = new NotFoundResult();
            context.ExceptionHandled = true;
        }
    }
}