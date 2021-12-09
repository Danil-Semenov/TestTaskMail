using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TestTaskMail.Utils
{
    public static class Config
    {
        public static string Browser => ConfigurationManager.AppSettings["Browser"];
        public static int DefoltTimeout => Convert.ToInt32(ConfigurationManager.AppSettings["DefoltTimeout"]);
        public static string Localization => ConfigurationManager.AppSettings["Localization"];
        public static string Host => ConfigurationManager.AppSettings["Host"];
    }
}
