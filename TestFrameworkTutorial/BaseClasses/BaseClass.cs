﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Helpers.TestHelpers;
using Helpers.TestHelpers;
using Helpers.TestHelpers;
using Helpers.TestHelpers.ComponentHelper;
using Helpers.TestHelpers.Settings;
using Helpers.TestHelpers.TestBaseUtility;
using log4net.Appender;

namespace Helpers.TestHelpers.BaseClasses
{
    public class BaseClass
    {
        private static readonly RollingFileAppender Logger = LoggerHelper.GetRollingFileAppender();
        public void Logout()
        {
            if (!GenericHelper.IsElementPresentQuick(By.XPath(LocatorRepository.LogoutXpath)))
                return;

            var logout = GenericHelper.GetElement(By.XPath(LocatorRepository.LogoutXpath));
            logout = GenericHelper.WaitForElementClickAble(logout);
            JavaScriptExecutorHelper.ScrollElementAndClick(logout);
            logout = GenericHelper.WaitForElement(By.XPath(LocatorRepository.LogOffXpath));
            JavaScriptExecutorHelper.ScrollElementAndClick(logout);
            GenericHelper.AcceptAlert();
            GenericHelper.WaitForElement(By.XPath(LocatorRepository.LoginPageLogoXpath));
        }

        public virtual Type GetClassType()
        {
            return GetType();
        }

        protected By GetElementLocator(How locator, string locatorValue)
        {
            switch (locator)
            {
                case How.XPath:
                    return By.XPath(locatorValue);
                case How.ClassName:
                    return By.ClassName(locatorValue);
                case How.CssSelector:
                    return By.CssSelector(locatorValue);
                case How.LinkText:
                    return By.LinkText(locatorValue);
                case How.Name:
                    return By.Name(locatorValue);
                case How.PartialLinkText:
                    return By.PartialLinkText(locatorValue);
                default:
                    return By.Id(locatorValue);
            }
        }

        #region Virtual Methods

        /// <summary>
        /// Perform the file upload, the file name should be present in Resources folder
        /// </summary>
        /// <param name="fileName"></param>
        public virtual void FileUpload(string fileName)
        {
            //TODO Need to modify script for file upload in IE

            var processinfo = new ProcessStartInfo()
            {
                FileName = "FileUpload.exe",
                Arguments = "\"" + Directory.GetCurrentDirectory() + "\\" + fileName + "\""
            };


            try
            {
                using (var process = Process.Start(processinfo))
                {
                    process.WaitForExit();
                    //CommonBase.Log.Info(string.Format(" File Upload {0}",fileName));
                }
            }
            catch (Exception e)
            {
               // CommonBase.Log.LogException(e);
                throw;
            }
           
        }

        #endregion
    }
}
