using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Pages.Invoice
{
   public class CreateInvoicePage
    {

        //SET TEXT BOX VALUE
        //System.Threading.Thread.Sleep(5000);
            //driver.FindElement(By.XPath("")).SendKeys("DELL_BU01");

        //business unit
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic2::content']")]
        private IWebElement input_businessunit;
        //select the  desired value
        public void Enter_Businessunit()
        {
            input_businessunit.SendKeys("DELL_BU01");
            System.Threading.Thread.Sleep(4000);
            input_businessunit.SendKeys(Keys.Tab);
            System.Threading.Thread.Sleep(4000);
        }
        //System.Threading.Thread.Sleep(10000);
        //  driver.FindElement(By.XPath("")).Click();
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic2::_afrautosuggestpopup']/li[2]")]
        private IWebElement choose_businessunit;
        public void Choose_Businessunit()
        {
            choose_businessunit.Click();
            ;
        }
        //select the box value

        //System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("DELL");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic3::content']")]
        private IWebElement click_supplier;
        public void Click_Supplier()
        {
            click_supplier.SendKeys("DELL_Supplier");
            System.Threading.Thread.Sleep(4000);
            click_supplier.SendKeys(Keys.Tab);
            System.Threading.Thread.Sleep(4000);
        }

        //select the  desired value

        // System.Threading.Thread.Sleep(5000);
        //  driver.FindElement(By.XPath("//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic3::_afrautosuggestpopup']/li[1]")).Click();

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic3::_afrautosuggestpopup']/li[1]")]
        private IWebElement choose_loc;
        public void Choose_Loc()
        {
            choose_loc.Click();
        }

        // System.Threading.Thread.Sleep(5000);
        //  driver.FindElement(By.XPath("//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i2::content']")).SendKeys("test23");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i2::content']")]
        private IWebElement input_invoice_num;
        public void Invoice_Num(string invoiceNumber)
        {
            input_invoice_num.SendKeys(invoiceNumber);
            System.Threading.Thread.Sleep(4000);
        }


        // System.Threading.Thread.Sleep(5000);
        //  driver.FindElement(By.XPath("//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i3::content']")).SendKeys("200");

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i3::content']")]
        private IWebElement input_amt_num;
        public void Amount_Num()
        {
            input_amt_num.SendKeys("200.00");
            System.Threading.Thread.Sleep(4000);
        }


        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("Immediate");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:so3::content']")]
        private IWebElement input_payment_terms;
        public void Input_Payment()
        {
            input_payment_terms.SendKeys("Immediate");
            System.Threading.Thread.Sleep(4000);
        }
        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("100");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:0:i26::content']")]
        private IWebElement input_LineSectionAmount;
        public void Input_LineSectionAmount()
        {
            input_LineSectionAmount.SendKeys("100.00");
            System.Threading.Thread.Sleep(4000);
        }
        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("001-02-0001");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:0:kf1CS::content']")]
        private IWebElement input_DistributionCombination;
        public void Input_DistributionConbination()
        {
            input_DistributionCombination.SendKeys("001-02-0001");
            System.Threading.Thread.Sleep(4000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.webDriver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }
        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).Click();
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2::db']/table/tbody/tr[2]/td[4]")]
        private IWebElement lineSectionAmount2LineClick;
        public void LineSectionAmount2LineClick()
        {
            lineSectionAmount2LineClick.Click();
            System.Threading.Thread.Sleep(4000);
        }
        //System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("100");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:1:i26::content']")]
        private IWebElement input_LineSectionAmount2;
        public void Input_LineSectionAmount2()
        {
            input_LineSectionAmount2.SendKeys("100.00");
            System.Threading.Thread.Sleep(4000);
        }

        //  System.Threading.Thread.Sleep(5000);
        //    driver.FindElement(By.XPath("")).SendKeys("001-02-0001");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:1:kf1CS::content']")]
        private IWebElement input_DistributionConbination2;
        public void Input_DistributionConbination2()
        {
            input_DistributionConbination2.SendKeys("001-02-0001");
            System.Threading.Thread.Sleep(4000);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ctb3']")]
        private IWebElement distribution_ButtonClick;
        public void click_distributionbutton()
        {
            ((IJavaScriptExecutor)Browser.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", distribution_ButtonClick);
            System.Threading.Thread.Sleep(1000);
            distribution_ButtonClick.Click();
            System.Threading.Thread.Sleep(20000);
        }


        [FindsBy(How = How.XPath, Using = "//select[@id=\'_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:so1::content\']")]
        private IWebElement invoiceLineLOV;
        public void choose_InvoiceLineLOV()
        {
            SelectElement invoiceLineDropDown = new SelectElement(invoiceLineLOV);
            //BusinessRelationshipDropDown.SelectByValue("0");
            try
            {
                invoiceLineDropDown.SelectByText("1");
            }
            catch (Exception e)
            {
                
            }
            try
            {
                invoiceLineDropDown.SelectByValue("1");
            }
            catch (Exception e)
            {

            }
            System.Threading.Thread.Sleep(4000);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:create::icon']")]
        private IWebElement manageDistribution_AddRow;
        public void ManageDistribution_AddRowClick()
        {
            manageDistribution_AddRow.Click();
            System.Threading.Thread.Sleep(10000);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:ta1::db']/table/tbody/tr[1]/td[5]//input")]

        //*[@id="_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:ta1::db"]/table/tbody/tr[1]/td[5]
        private IWebElement distribution1value;
        public void Distribution1value()
        {
            distribution1value.SendKeys("50.00");
            System.Threading.Thread.Sleep(4000);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:ta1::db']/table/tbody/tr[2]/td[5]//input")]
        private IWebElement distribution2value;
        public void Distribution2value()
        {
            distribution2value.SendKeys("50.00");
            System.Threading.Thread.Sleep(4000);
        }
        public void choose_InvoiceLine2LOV()
        {
            SelectElement invoiceLineDropDown = new SelectElement(invoiceLineLOV);
            //BusinessRelationshipDropDown.SelectByValue("0");
            invoiceLineDropDown.SelectByText("2");
            System.Threading.Thread.Sleep(4000);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:create::icon']")]
        private IWebElement click_the_plus2_image;
        public void click_the_Plus2()
        {
            click_the_plus2_image.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:ta1:5:i1::content']")]
        private IWebElement D1value;
        public void D21()
        {
            D1value.SendKeys("50");
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r8:1:at1:_ATp:ta1:1:i1::content']")]
        private IWebElement D22value;
        public void D22()
        {
            D22value.SendKeys("50");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:cb11']")]
        private IWebElement saveandcloseButtonClick;
        public void saveandclosebutton()
        {
            saveandcloseButtonClick.Click();
            System.Threading.Thread.Sleep(8000);
        }

        //[FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:me1']/div/table/tbody/tr/td[3]/div']")]
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Invoice Actions')]")]
        private IWebElement invoiceActionsLOV;
        public void InvoiceActionsLOV()
        {
            invoiceActionsLOV.Click();
            System.Threading.Thread.Sleep(4000);
        }


        [FindsBy(How = How.XPath, Using = "//div[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:me1::ScrollBox']//td[contains(text(),'Validate')]")]
        private IWebElement validateLinkClick;
        public void ValidateClick()
        {
            validateLinkClick.Click();
            System.Threading.Thread.Sleep(4000);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:me1::ScrollBox']//td[contains(text(),'Account in Draft')]")]
        private IWebElement accountInDraftLinkClick;
        public void AccountInDraftLinkClick()
        {
            accountInDraftLinkClick.Click();
            System.Threading.Thread.Sleep(6000);
        }

        [FindsBy(How = How.XPath, Using = "//button[@accesskey='K']")]
        private IWebElement confirmationOKButton;
        public void ConfirmationOKButton()
        {
            confirmationOKButton.Click();
            System.Threading.Thread.Sleep(6000);
        }


        [FindsBy(How = How.XPath, Using = "//div[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:me1::ScrollBox']//td[contains(text(),'Post to Ledger')]")]
        private IWebElement postToLedgerLinkClick;
        public void PostToLedgerLinkClick()
        {
            System.Threading.Thread.Sleep(8000);
            postToLedgerLinkClick.Click();
            System.Threading.Thread.Sleep(8000);
        }

        [FindsBy(How = How.XPath, Using = "//button[@_afrpdo='cancel' and contains(text(),'OK')]")]
        private IWebElement accountingOKButton;
        public void AccountingOKButtonClick()
        {
            System.Threading.Thread.Sleep(8000);
            accountingOKButton.Click();
            System.Threading.Thread.Sleep(8000);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'ave and Close')]")]
        private IWebElement saveandcloseInvoicePage;
        public void SaveandcloseInvoicePage()
        {
            System.Threading.Thread.Sleep(8000);
            saveandcloseInvoicePage.Click();
            System.Threading.Thread.Sleep(8000);
        }
        
       [FindsBy(How = How.XPath, Using = "//table[@summary='Status']//tr[1]/td[2]")]
        private IWebElement validationStatus;

        public String ValidationStatus()
        {
            System.Threading.Thread.Sleep(8000);
            String validated =  validationStatus.Text;
           return validated;
        }
    }
}
