﻿using System;
using LandonApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LandonApi.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        private readonly IHostingEnvironment _env;
        public JsonExceptionFilter(IHostingEnvironment env)
        {
            _env = env;
        }
        public void OnException(ExceptionContext context)
        {
            var error = new ApiError();

            if(_env.IsDevelopment())
            {
                error.Message = context.Exception.Message;
                error.Detail = context.Exception.StackTrace;
            }
            else
            {
                error.Message = "A server error occured.";
                error.Detail = context.Exception.Message;
            }
            

            context.Result = new ObjectResult(error)
            {
                StatusCode = 500
            };
        }
    }
}
