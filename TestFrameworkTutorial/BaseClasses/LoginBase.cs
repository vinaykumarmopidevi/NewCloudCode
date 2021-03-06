﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers.TestHelpers;

using Helpers.TestHelpers;
using Helpers.TestHelpers.ComponentHelper;
using Helpers.TestHelpers.Settings;

namespace Helpers.TestHelpers.BaseClasses
{
    public class LoginBase
    {
        protected ILog Logger;
        protected LoginPage Lpage;
        protected HomePage HPage;
      
        public LoginBase()
        {
            Logger = LoggerHelper.GetLogger(GetType());
            Lpage = new LoginPage(ObjectRepository.Driver);
            HPage = Lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            Logger.Info("Test Execution Started");
        }
    }
}
