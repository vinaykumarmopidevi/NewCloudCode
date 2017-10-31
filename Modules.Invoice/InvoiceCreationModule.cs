using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers.BaseClasses;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using Pages.Invoice;
using System.Configuration;
using Helpers.TestHelpers.Settings;

namespace Modules.Invoice
{
   public class InvoiceCreationModule
    {
        public void InvoicPage()
        {
            Invoice_Pages.WelcomePage.NavigateToWelcomePage();
            //Invoice_Pages.WelcomePage.GotoPayable();
            Invoice_Pages.WelcomePage.GotoInvoiceWorkbench();
        }

       // private ILog Log = CommonBase.Log;
        public void loginToApplication()
        {
            Invoice_Pages.HomePage.GoTo();
            string instance = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Instance']");
            Invoice_Pages.HomePage.Login(ConfigurationManager.AppSettings.Get(AppConfigKeys.Username));
            Invoice_Pages.HomePage.Password(ConfigurationManager.AppSettings.Get(AppConfigKeys.Password));

            Invoice_Pages.HomePage.LoginButton();
            //Log.Info("logged in successfully");
        }

        public void logoutFromApplication()
        {
            Invoice_Pages.HomePage.Signoutimageclick();
            Invoice_Pages.HomePage.Signoutlinkclick();
            Invoice_Pages.HomePage.Confirmbuttonclick();
            Browser.Close();
        }

        public void InvoicWorknenchNav()
        {
            Invoice_Pages.invoiceWorkbenchPage.invoiceWorkBench_btn_click();
            Invoice_Pages.invoiceWorkbenchPage.invoiceWorkBench_link_click();

        }

        public void CreateInvoicePage(string invoiceNumber)
        {
            Invoice_Pages.createInvoicePage.Enter_Businessunit();
            Invoice_Pages.createInvoicePage.Click_Supplier();
            Invoice_Pages.createInvoicePage.Invoice_Num(invoiceNumber);
            Invoice_Pages.createInvoicePage.Amount_Num();
            Invoice_Pages.createInvoicePage.Input_Payment();

        }

        public void CreateInvoiceLineSectionAmount()
        {
            Invoice_Pages.createInvoicePage.Input_LineSectionAmount();
            Invoice_Pages.createInvoicePage.Input_DistributionConbination();
            Invoice_Pages.createInvoicePage.LineSectionAmount2LineClick();
            Invoice_Pages.createInvoicePage.Input_LineSectionAmount2();
            Invoice_Pages.createInvoicePage.Input_DistributionConbination2();
            Invoice_Pages.createInvoicePage.click_distributionbutton();
            
            }

        public void CreateDistribution()
        {
            Invoice_Pages.createInvoicePage.choose_InvoiceLineLOV();
            Invoice_Pages.createInvoicePage.ManageDistribution_AddRowClick();
            Invoice_Pages.createInvoicePage.Distribution1value();
            Invoice_Pages.createInvoicePage.Distribution2value();
            Invoice_Pages.createInvoicePage.choose_InvoiceLine2LOV();
            Invoice_Pages.createInvoicePage.ManageDistribution_AddRowClick();
            Invoice_Pages.createInvoicePage.Distribution1value();
            Invoice_Pages.createInvoicePage.Distribution2value();
            Invoice_Pages.createInvoicePage.saveandclosebutton();
        }

        public void InvoiceValidate()
        {
            Invoice_Pages.createInvoicePage.InvoiceActionsLOV();
            Invoice_Pages.createInvoicePage.ValidateClick();
            Invoice_Pages.createInvoicePage.InvoiceActionsLOV();
            Invoice_Pages.createInvoicePage.AccountInDraftLinkClick();
            Invoice_Pages.createInvoicePage.ConfirmationOKButton();
            Invoice_Pages.createInvoicePage.InvoiceActionsLOV();
            Invoice_Pages.createInvoicePage.PostToLedgerLinkClick();
            Invoice_Pages.createInvoicePage.AccountingOKButtonClick();
            Invoice_Pages.createInvoicePage.ValidationStatus();
            Invoice_Pages.createInvoicePage.SaveandcloseInvoicePage();
            
        }

    }
}
