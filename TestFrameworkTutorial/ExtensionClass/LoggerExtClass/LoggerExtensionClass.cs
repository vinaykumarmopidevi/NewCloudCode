﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Helpers.TestHelpers;
using Helpers.TestHelpers.ComponentHelper;

namespace Helpers.TestHelpers.ExtensionClass.LoggerExtClass
{
    public static class LoggerExtensionClass
    {
        #region Public

        public static void LogException(this ILog logger, Exception e)
        {
            logger.Error(" Message " + e.Message);
            logger.Error(" StackTrace " + e.StackTrace);
            logger.Error(" InnerException " + e.InnerException);
            GenericHelper.TakeSceenShot();
        }

        #endregion

    }
}
