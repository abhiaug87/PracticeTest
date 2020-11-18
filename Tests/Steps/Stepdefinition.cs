using NUnit.Framework;
using Tests.PageObjects;
using Tests.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Interactions;
using System;
using Newtonsoft.Json;
using System.IO;
using Utf8Json;
using System.Data;

namespace Tests.Steps
{
    [Binding]
   public class Stepdefinition : BaseClass
    {
        Pageobjects po = new Pageobjects(Driver);
        WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 5));
        JSON read = new JSON();

[Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            //Driver.Navigate().GoToUrl(CommonConstants.ApplicationSettings.Url);
            Driver.Navigate().GoToUrl(read.jsonReader("../Tests/Utilities/Data.json", "url"));
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            po.loginbtn.Click();
            po.usr.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "username"));
            po.pass.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "password"));
            po.next.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("//*[@id='layout']/tbody/tr[1]/td[1]/div")));
        }

        [When(@"I click on Profile")]
        public void WhenIClickOnProfile()
        {
            Driver.SwitchTo().Frame(0);
            Sleep(2);
            po.profile.SendKeys(Keys.Enter + Keys.Enter + Keys.Tab + Keys.Enter);
            wait.Until(Driver => Driver.FindElement(By.Id("anti_sizzle_do_not_remove")));
            Assert.True(po.personal.Displayed, "Element is not displayed");
            Driver.SwitchTo().Frame("ASB.58c9b2b87b9d150d1c7dd287_v1.1.8_58d98a132d7fb9101018fc3a-1");
            wait.Until(Driver => Driver.FindElement(By.CssSelector("div.profile-section-title")));
        }



        [Then(@"I see the changes")]
        public void ThenISeeTheChanges()
        {
            po.prefferedname.Click();
            po.nametxt.SendKeys(Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace+ Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace);
            po.nametxt.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "name"));
            po.nametxt.SendKeys(Keys.Tab + Keys.Enter);
        }



        /// <summary>
        /// //////////
        /// </summary>

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Driver.Navigate().GoToUrl(CommonConstants.ApplicationSettings.BaseUrl);
            Driver.Navigate().GoToUrl(read.jsonReader("../Tests/Utilities/Data.json", "url"));
        }

        [When(@"I enter login credentials to get access to the portal")]
        public void WhenIEnterLoginCredentialsToGetAccessToThePortal()
        {
            Assert.True(po.forgot.Text.Contains(read.jsonReader("../Tests/Utilities/Data.json", "forgot")), "Text not displayed");
            Assert.True(po.otherlogin.Text.Contains("Other login options"), "Text not displayed");
            Assert.True(po.signup.Text.Contains("Sign Up"), "Text not displayed");
            Assert.True(po.noaccount.Text.Contains("Don't have an account?"), "Text not displayed");
            Assert.True(po.username.Displayed, "Text field not displayed");
            Assert.True(po.password.Displayed, "Text field not displayed");
            po.username.SendKeys("qakulkarni@unl.sh");
            po.password.SendKeys("Testmycode123");
            po.login.Click();
        }
        [Then(@"I am redirected to the dashboard page")]
        public void ThenIAmRedirectedToTheDashboardPage()
        {
            Assert.True(po.dashboard.Text.Contains("Dashboard"), "Text not displayed");
            Assert.True(po.dsbpagename.Text.Contains("Dashboard - Quarter To Date"), "Text not displayed");
        }

        [Given(@"I am on the Add Product page")]
        public void GivenIAmOnTheAddProductPage()
        {
            GivenIAmOnTheLoginPage();
            WhenIEnterLoginCredentialsToGetAccessToThePortal();
            ThenIAmRedirectedToTheDashboardPage();           
            po.inventory.Click();
            Sleep(2);
            Assert.True(po.inventory.Text.Contains("Inventory"), "Text not displayed");
            po.products.Click();
            Sleep(2);
            Assert.True(po.products.Text.Contains("Products"), "Text not displayed");
            po.addproduct.Click();
            Sleep(2);
            Assert.True(po.addproduct.Text.Contains("Add Product"), "Text not displayed");
            Assert.True(po.productpage.Text.Contains("Add Product"), "Text not displayed");
        }

        [When(@"I add details of the product")]
        public void WhenIAddDetailsOfTheProduct()
        {
         var measuretxt = Driver.FindElement(By.Id("Product_UnitOfMeasureId"));
         var grptxt = Driver.FindElement(By.Id("Product_ProductGroupId"));
         var selectm = new SelectElement(measuretxt);
         var selectg = new SelectElement(grptxt);
         Assert.True(po.detailstab.Text.Contains("Details"), "Text not displayed");
         Assert.True(po.inventorytab.Text.Contains("Inventory"), "Text not displayed");
         Assert.True(po.purchasetab.Text.Contains("Purchase"), "Text not displayed");
         Assert.True(po.saletab.Text.Contains("Sale"), "Text not displayed");
         Assert.True(po.transtab.Text.Contains("Transactions"), "Text not displayed");
         Assert.True(po.reftab.Text.Contains("References"), "Text not displayed");
         Assert.True(po.costtab.Text.Contains("Costs"), "Text not displayed");
         Assert.True(po.attachmenttab.Text.Contains("Attachments"), "Text not displayed");
         Assert.True(po.code.Text.Contains("*Product Code"), "Text not displayed");
         po.codetxt.SendKeys("123456");
         Sleep(2);
         Assert.True(po.description.Text.Contains("*Product Description"), "Text not displayed");
         po.desctxt.SendKeys("Testing");
         Sleep(2);
         Assert.True(po.barcode.Text.Contains("Barcode"), "Text not displayed");
         po.barcodetxt.SendKeys("ABC123456");
         Sleep(2);
         Assert.True(po.measure.Text.Contains("Unit Of Measure"), "Text not displayed");
         selectm.SelectByText("KG");
         Sleep(2);
         Assert.True(po.group.Text.Contains("Product Group"), "Text not displayed");
         selectg.SelectByText("Consumable");
         Sleep(2);
         Assert.True(po.template.Text.Contains("Default Label Template"), "Text not displayed");
         Assert.True(po.attribute.Text.Contains("Attribute set"), "Text not displayed");
         Assert.True(po.packsize.Text.Contains("Pack Size"), "Text not displayed");
         po.packsizetxt.SendKeys("123");
         Sleep(2);
         Assert.True(po.weight.Text.Contains("Weight (kg)"), "Text not displayed");
         po.weighttxt.SendKeys("50");
         Sleep(2);
         Assert.True(po.width.Text.Contains("Width (metre)"), "Text not displayed");
         po.widthtxt.SendKeys("25");
         Sleep(2);
         Assert.True(po.height.Text.Contains("Height (metre)"), "Text not displayed");
         po.heighttxt.SendKeys("25");
         Sleep(2);
         Assert.True(po.depth.Text.Contains("Depth (metre)"), "Text not displayed");
         po.depthtxt.SendKeys("15");
         Sleep(2);
         Assert.True(po.cubictotal.Text.Contains("Cubic Total (metre)"), "Text not displayed");
         Sleep(2);
         Assert.True(po.notestitle.Text.Contains("Notes"), "Text not displayed");
         po.notestxt.SendKeys("This is a test");
         Sleep(2);
        }

        [When(@"save the product")]
        public void WhenSaveTheProduct()
        {
         Assert.True(po.delete.Text.Contains("Delete"), "Button not displayed");
         Assert.True(po.search.Text.Contains("Search"), "Button not displayed");
         Assert.True(po.save.Text.Contains("Save"), "Button not displayed");
         po.save.Click();
         Sleep(2);
        }

        [Then(@"I see a confirmation message")]
        public void ThenISeeAConfirmationMessage()
        {
         Assert.True(po.savetitle.Text.Contains("Updating a Product"), "Text not displayed");
         Assert.True(po.savemsg.Text.Contains("You have updated the product successfully."), "Text not displayed");
         po.view.Click();
         Sleep(2);
         Assert.True(po.viewcnf.Text.Contains("123456"), "Text not displayed");
         Assert.True(po.viewcnf.Text.Contains("Testing"), "Text not displayed");
        }

        [Given(@"I am on the sales order page")]
        public void GivenIAmOnTheSalesOrderPage()
        {
         GivenIAmOnTheLoginPage();
         WhenIEnterLoginCredentialsToGetAccessToThePortal();
         ThenIAmRedirectedToTheDashboardPage();
         po.sales.Click();
         Sleep(2);
         po.salesorder.Click();
         Sleep(2);
         po.addsalesorder.Click();
         Assert.True(po.salespage.Text.Contains("Add Sales Order"), "Text not displayed");
        }

        [When(@"I add sales order")]
        public void WhenIAddSalesOrder()
        {
         Assert.True(po.customercode.Text.Contains("*Customer Code"), "Text not displayed");
         Assert.True(po.customername.Text.Contains("*Customer Name"), "Text not displayed");
         po.cctxt.SendKeys("gar123");
         po.ccsrc.Click();
         po.csc.SendKeys("gar123");
         po.custsrc.Click();
         po.choosecust.Click();
         Assert.True(po.tab1.Text.Contains("Order Lines"), "Text not displayed");
         Assert.True(po.tab2.Text.Contains("Shipments"), "Text not displayed");
         Assert.True(po.tab3.Text.Contains("Invoices"), "Text not displayed");
         Assert.True(po.lbl1.Text.Contains("Product"), "Text not displayed");
         Assert.True(po.lbl2.Text.Contains("*Quantity"), "Text not displayed");
         Assert.True(po.lbl3.Text.Contains("Price"), "Text not displayed");
         Assert.True(po.lbl5.Text.Contains("Availability"), "Text not displayed");
         Assert.True(po.lbl7.Text.Contains("Sub Total"), "Text not displayed");
         Sleep(2);
         po.prtxt.SendKeys("chair");
         Sleep(2);
         po.prtxt.SendKeys(Keys.Tab);
         Sleep(2);
         po.qty.SendKeys("1");
         Sleep(2);
         po.comment.SendKeys("Test");
         po.add.Click();
        }

        [When(@"view the product ordered")]
        public void WhenViewTheProductOrdered()
        {
         Assert.True(po.viewprod.Text.Contains("CHAIR"), "Text not displayed");
         po.complete.Click();
         Assert.True(po.msgtitle.Text.Contains("Complete Order"), "Text not displayed");
         Assert.True(po.msg1.Text.Contains("Completing this sales order will also complete any open shipments and invoices on this transaction. This cannot be undone."), "Text not displayed");
         Assert.True(po.msg2.Text.Contains("Are you sure you want to complete this order?"), "Text not displayed");
         Assert.True(po.msg3.Text.Contains("Don't show this message again"), "Text not displayed");
         po.complcnf.Click();
         Sleep(2);
        }

        [Then(@"I see the availability details")]
        public void ThenISeeTheAvailabilityDetails()
        {
         po.viewprod.Click();
        }

        [Given(@"I am on the Sub External page")]
        public void GivenIAmOnTheSubEXternalPage()
        {
            Driver.Navigate().GoToUrl(read.jsonReader("../Tests/Utilities/Data.json", "extsub"));
        }

        [Given(@"I am on the Product App page")]
        public void GivenIAmOnTheProductAppPage()
        {
            Driver.Navigate().GoToUrl(read.jsonReader("../Tests/Utilities/Data.json", "prodapp"));
        }

        [Given(@"I create a billing account")]
        public void GivenICreateABillingAccount()
        {
            po.email.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "usr"));
            po.pas.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "pas"));
            po.submit.Click();
            po.subscription.Click();
            po.orgname.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "orgname"));
            po.work.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "work"));
            po.work.SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Enter);
            po.apply.SendKeys(Keys.Tab + Keys.Enter);
            po.apply.SendKeys(Keys.Tab + Keys.Enter);
            po.existing.Click();
            po.apply.SendKeys(Keys.Tab + Keys.Enter);
            po.apply.SendKeys(Keys.Tab + Keys.Enter);
        }

        [When(@"I login to the app")]
        public void GivenILoginToTheApp()
        {
            po.email.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "usr"));
            po.pas.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "pas"));
            po.submit.Click();
            po.ellipsis.Click();
            po.viewplans.Click();
        }

        [Then(@"I am able to see the (.*), (.*), (.*) rows:")]
        public void ThenIAmAbleToSeeTheFollowingRows(string Name, string Purchasable, string Partner, Table table)
        {
            bool dataexists = false;
            System.Collections.Generic.IList<IWebElement> tableRow = po.table.FindElements(By.TagName("td"));
            for (int i = 0; i < tableRow.Count; i++)
            {
                if (tableRow[0].Text.Contains("Apple") && tableRow[1].Text.Contains("Never"))
                {
                    dataexists = true;
                    break;
                }
            }
            Assert.True(dataexists, "data does not exist.");
        }

        [Given(@"I login to SX")]
        public void GivenILoginToSX()
        {
            Driver.Navigate().GoToUrl(read.jsonReader("../Tests/Utilities/Data.json", "sx"));
        }

        [Given(@"I can see the Billing Account of my org")]
        public void GivenICanSeeTheBillingAccountOfMyOrg()
        {
            po.email.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "usr"));
            po.pas.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "pas"));
            po.submit.Click();
            //Sleep(2);
           // po.searchfield.SendKeys(read.jsonReader("../Tests/Utilities/Data.json", "usr"));
            po.logoutlink.Click();
            po.logoutbtn.Click();
        }


    }
}
