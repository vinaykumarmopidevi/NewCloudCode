﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using OpenQA.Selenium;
using Helpers.TestHelpers;
using Helpers.TestHelpers;
using Helpers.TestHelpers.ComponentHelper;

namespace Helpers.TestHelpers.ExtensionClass.WebElementExtClass
{
    public static class JavaScriptExecutor
    {
        private static readonly ILog Logger = LoggerHelper.GetLogger(typeof(JavaScriptExecutor));
        public static void ScrollToElement(this IWebElement element)
        {
            Thread.Sleep(500);
            JavaScriptExecutorHelper.ExecuteScript("window.scrollTo(0," + element.Location.Y + ");");
        }

        public static void ScrollElementAndClick(this IWebElement element)
        {
            Thread.Sleep(500);
            JavaScriptExecutorHelper.ExecuteScript("window.scrollTo(0," + element.Location.Y + ");");
            element.Click();
        }
    }
}
