﻿using Dream.ToolKits.Helper;
using log4net;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dream.HttpApi.Hosting.Filters
{
    public class ExceptionFilter: IExceptionFilter
    {
        private readonly ILog _log;

        public ExceptionFilter()
        {
            _log = LogManager.GetLogger(typeof(ExceptionFilter));
        }

        /// <summary>
        /// 异常处理
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public void OnException(ExceptionContext context)
        {
            // 错误日志记录
            _log.Error($"{context.HttpContext.Request.Path}|{context.Exception.Message}", context.Exception);
        }
        ///// <summary>
        ///// 异常处理
        ///// </summary>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //public void OnException(ExceptionContext context)
        //{
        //    // 日志记录
        //    LoggerHelper.WriteToFile($"{context.HttpContext.Request.Path}|{context.Exception.Message}", context.Exception);
        //}
    }
}
