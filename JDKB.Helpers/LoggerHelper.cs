using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Helpers
{
    public static class LoggerHelper
    {
        public static string GetStringLog(string message) => $"JDKB: {DateTime.Now.ToLongTimeString()} -> {message}";
        public static string GetStringLogError(string message) => $"Erro: {message}";
    }
}
