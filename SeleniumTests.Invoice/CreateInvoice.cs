using NUnit.Framework;
using System;
using System.Collections.Generic;
using FluentAssertions;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using Helpers.TestHelpers.BaseClasses;
using Modules.Invoice;
using Pages.Invoice;


namespace SeleniumTests.Invoice

{

    [TestFixture]
   // [Parallelizable(ParallelScope.Self)]
    public class CreateInvoice : CommonBase
    {
        //Declare an instance for log4net
        
        //Declare an instance for log4net
        static string testName = "CreateInvoice";
     

        

        [Test, TestCaseSource("getData"),
         Category("RegressionTests"),
         Description("Ensure Hire An CreateInvoice successfully")]
        public void CreateInvoice_Test(Dictionary<string, string> data)
        {
            Log.Info("Started scenario  execution");


            if (!DataUtil.isTestRunnable(xls, testName) || data["Runmode"].Equals("N"))
                Assert.Ignore("the scenario is Ignored from the current exdcution ");
            string brwname = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Browser']");
            Browser.GetDriver(brwname);
            // SeleniumTests.OracleTestBase.Singleton.GetInstance().Show();
            //Arrange (data)
            Random rnd = new Random();
            int rnd_num = rnd.Next(1000, 2000);
            string LastName = "TestUser" + rnd_num;


            // Arrange(modules)
            InvoiceCreationModule invoice = new InvoiceCreationModule();

            //Act

            /*
             * login to application
             * 
             */

            Log.Info("login to application");
            invoice.loginToApplication();

            /*
             * Entering Invoice page
             */
            invoice.InvoicPage();

            invoice.InvoicWorknenchNav();

            invoice.CreateInvoicePage("invoiceNumber"+ LastName);

            invoice.CreateInvoiceLineSectionAmount();

            invoice.CreateDistribution();

            invoice.InvoiceValidate();

            //Assert
            Log.Info("Verification Invoice Status");
            //Assert.IsTrue(invoice.verificationEmployeeCreation(LastName), "Employeee created successful, pleas check!!");

            Invoice_Pages.createInvoicePage.ValidationStatus().ShouldBeEquivalentTo("Validated");
            //CoreHR_Pages.SearchPerson.getEmployeeName().Should().StartWith("Validated");
            /*
             * logout from application
             */
            invoice.logoutFromApplication();
        }

        public static object[] getData()
        {
            return DataUtil.getData_old(xls, testName);
        }

        [TearDown]
        public void quit()
        {
        
        }
    }
}
