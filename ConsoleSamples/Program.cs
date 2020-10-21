﻿using System;

using Exceptionless;
using Exceptionless.Logging;

namespace ConsoleSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionlessClient.Default.Configuration.ApiKey = "LsioUkJpN7gHPKelib2rGV0XW4l32QHs8eHFOtjT";
            ExceptionlessClient.Default.Configuration.ServerUrl = "http://192.168.199.129:5000";
            ExceptionlessClient.Default.Startup();

            ExceptionlessClient.Default.SubmitLog("这是一个普通日志记录code:{12345678999}", LogLevel.Info);

            try
            {
                ExceptionlessClient.Default.CreateLog("出错了", LogLevel.Error).Submit();
                throw new Exception($"看这里异常了!时间：{DateTime.Now}");
            }
            catch (System.Exception ex)
            {
                ex.ToExceptionless().Submit();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
