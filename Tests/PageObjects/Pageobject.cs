using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tests.PageObjects
{
    public class Pageobjects
    {
        public Pageobjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "div.logoPage-logo")]
        public IWebElement logo;

        [FindsBy(How = How.XPath, Using = "//*[@id='inputform']/div/div[1]/a")]
        public IWebElement helptxt;

        [FindsBy(How = How.CssSelector, Using = "a.forgot-password")]
        public IWebElement forgot;

        [FindsBy(How = How.CssSelector, Using = "#login-option-expander")]
        public IWebElement otherlogin;

        [FindsBy(How = How.Id, Using = "btnLogOn")]
        public IWebElement login;

        [FindsBy(How = How.CssSelector, Using = "a.fm-button.secondary")]
        public IWebElement signup;

        [FindsBy(How = How.XPath, Using = "//*[@id='inputform']/div/div[3]/div[4]/h3")]
        public IWebElement noaccount;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[1]/a/span")]
        public IWebElement dashboard;

        [FindsBy(How = How.CssSelector, Using = "div.pageName")]
        public IWebElement dsbpagename;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[4]/a/span[1]")]
        public IWebElement inventory;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[4]/ul/li[2]/a/span[1]")]
        public IWebElement products;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[4]/ul/li[2]/ul/li[1]/a/span")]
        public IWebElement addproduct;

        [FindsBy(How = How.Id, Using = "StickyBar")]
        public IWebElement productpage;

        [FindsBy(How = How.Id, Using = "tabsDetailsLink")]
        public IWebElement detailstab;

        [FindsBy(How = How.Id, Using = "tabsInventoryLink")]
        public IWebElement inventorytab;

        [FindsBy(How = How.Id, Using = "tabsSupplierLink")]
        public IWebElement purchasetab;

        [FindsBy(How = How.Id, Using = "tabsPriceLink")]
        public IWebElement saletab;

        [FindsBy(How = How.Id, Using = "tabsTransactionsLink")]
        public IWebElement transtab;

        [FindsBy(How = How.Id, Using = "tabsReferencesLink")]
        public IWebElement reftab;

        [FindsBy(How = How.Id, Using = "tabsCostLink")]
        public IWebElement costtab;

        [FindsBy(How = How.Id, Using = "tabsFilesLink")]
        public IWebElement attachmenttab;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[1]/tbody/tr[1]/td[1]/label")]
        public IWebElement code;

        [FindsBy(How = How.Id, Using = "Product_ProductCode")]
        public IWebElement codetxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[1]/tbody/tr[2]/td[1]/label")]
        public IWebElement description;

        [FindsBy(How = How.Id, Using = "Product_ProductDescription")]
        public IWebElement desctxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[1]/tbody/tr[3]/td[1]/label")]
        public IWebElement barcode;

        [FindsBy(How = How.Id, Using = "Product_Barcode")]
        public IWebElement barcodetxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[1]/tbody/tr[4]/td[1]")]
        public IWebElement measure;

        [FindsBy(How = How.Id, Using = "Product_UnitOfMeasureId")]
        public IWebElement measuretxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[1]/tbody/tr[5]/td[1]")]
        public IWebElement group;

        [FindsBy(How = How.Id, Using = "Product_ProductGroupId")]
        public IWebElement grptxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[1]/tbody/tr[6]/td[1]")]
        public IWebElement template;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/h2[1]")]
        public IWebElement attributestitle;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/div[2]/span")]
        public IWebElement attribute;

        [FindsBy(How = How.Id, Using = "Product_AttributeSetId")]
        public IWebElement attributestxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[2]/h2[2]")]
        public IWebElement notestitle;

        [FindsBy(How = How.Id, Using = "Product_Notes")]
        public IWebElement notestxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/h2[2]")]
        public IWebElement dimensiontitle;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[2]/tbody/tr[1]/td[1]/label")]
        public IWebElement packsize;

        [FindsBy(How = How.Id, Using = "Product_PackSize")]
        public IWebElement packsizetxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[2]/tbody/tr[2]/td[1]/label")]
        public IWebElement weight;

        [FindsBy(How = How.Id, Using = "Product_Weight")]
        public IWebElement weighttxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[2]/tbody/tr[3]/td[1]/label")]
        public IWebElement width;

        [FindsBy(How = How.Id, Using = "Product_Width")]
        public IWebElement widthtxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[2]/tbody/tr[4]/td[1]/label")]
        public IWebElement height;

        [FindsBy(How = How.Id, Using = "Product_Height")]
        public IWebElement heighttxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[2]/tbody/tr[5]/td[1]/label")]
        public IWebElement depth;

        [FindsBy(How = How.Id, Using = "Product_Depth")]
        public IWebElement depthtxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabsDetails']/div[1]/table[2]/tbody/tr[6]/td[1]/label")]
        public IWebElement cubictotal;

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement save;

        [FindsBy(How = How.Id, Using = "ddbProduct")]
        public IWebElement productbtn;

        [FindsBy(How = How.Id, Using = "DeleteButton")]
        public IWebElement delete;

        [FindsBy(How = How.Id, Using = "ProductSearchButton")]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content-panel']/div[2]/div/h4")]
        public IWebElement savetitle;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content-panel']/div[2]/div/div[3]")]
        public IWebElement savemsg;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[4]/ul/li[2]/ul/li[2]/a/span")]
        public IWebElement view;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content-panel']")]
        public IWebElement viewcnf;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[6]/a/span[1]")]
        public IWebElement sales;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[6]/ul/li[2]/a/span[1]")]
        public IWebElement salesorder;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/div[1]/ul/li[6]/ul/li[2]/ul/li[1]/a/span")]
        public IWebElement addsalesorder;

        [FindsBy(How = How.Id, Using = "StickyBar")]
        public IWebElement salespage;

        [FindsBy(How = How.Id, Using = "CustomerCodeLabel")]
        public IWebElement customercode;

        [FindsBy(How = How.Id, Using = "SelectedCustomerCode")]
        public IWebElement customercodetxt;

        [FindsBy(How = How.Id, Using = "CustomerNameLabel")]
        public IWebElement customername;

        [FindsBy(How = How.Id, Using = "tabsInvoiceLinesList")]
        public IWebElement tab1;

        [FindsBy(How = How.Id, Using = "tabsShipmentsList")]
        public IWebElement tab2;

        [FindsBy(How = How.Id, Using = "tabsInvoiceList")]
        public IWebElement tab3;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[1]/a")]
        public IWebElement lbl1;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[3]")]
        public IWebElement lbl2;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[4]")]
        public IWebElement lbl3;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[5]")]
        public IWebElement lbl4;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[7]")]
        public IWebElement lbl5;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[8]")]
        public IWebElement lbl6;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[9]")]
        public IWebElement lbl7;

        [FindsBy(How = How.XPath, Using = "//*[@id='addLineTable']/tbody/tr[1]/td[10]")]
        public IWebElement lbl8;

        [FindsBy(How = How.CssSelector, Using = "input#QtyAddLine.short.number")]
        public IWebElement qty;

        [FindsBy(How = How.Id, Using = "btnAddOrderLine")]
        public IWebElement add;

        [FindsBy(How = How.Id, Using = "CommentsAddLine")]
        public IWebElement comment;

        [FindsBy(How = How.XPath, Using = "//*[@id='SalesOrderLinesList_tccell0_5']/div/a")]
        public IWebElement viewprod;

        [FindsBy(How = How.Id, Using = "btnComplete")]
        public IWebElement complete;

        [FindsBy(How = How.Id, Using = "OrderStatusDisplay")]
        public IWebElement orderstatus;

        [FindsBy(How = How.XPath, Using = "//*[@id='trStockOnHand']/td[1]/a")]
        public IWebElement stock;

        [FindsBy(How = How.XPath, Using = "//*[@id='trAllocatedQty']/td[1]/a")]
        public IWebElement allocated;

        [FindsBy(How = How.XPath, Using = "//*[@id='trAvailableQty']/td[1]/a")]
        public IWebElement available;

        [FindsBy(How = How.XPath, Using = "//*[@id='trOnOrderQty']/td[1]/a")]
        public IWebElement purchase;

        [FindsBy(How = How.XPath, Using = "//*[@id='trStockValue']/td[1]/a")]
        public IWebElement stockvalue;

        [FindsBy(How = How.Id, Using = "SelectedCustomerCode")]
        public IWebElement cctxt;

        [FindsBy(How = How.Id, Using = "ProductAddLine")]
        public IWebElement prtxt;

        [FindsBy(How = How.CssSelector, Using = "a#CustomerSearchButton")]
        public IWebElement ccsrc;

        [FindsBy(How = How.Id, Using = "RunCustomerSearch")]
        public IWebElement custsrc;

        [FindsBy(How = How.Id, Using = "CustomerSearchCode")]
        public IWebElement csc;

        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerLocalSearch_tccell0_0']/a")]
        public IWebElement choosecust;

        [FindsBy(How = How.XPath, Using = "//*[@id='generic-confirm-modal-message']/p[1]")]
        public IWebElement msg1;

        [FindsBy(How = How.XPath, Using = "//*[@id='generic-confirm-modal-message']/p[2]/strong")]
        public IWebElement msg2;

        [FindsBy(How = How.XPath, Using = "//*[@id='dialog-display-toggle-div']/label")]
        public IWebElement msg3;

        [FindsBy(How = How.Id, Using = "generic-confirm-modal-title")]
        public IWebElement msgtitle;

        [FindsBy(How = How.Id, Using = "generic-confirm-modal-yes")]
        public IWebElement complcnf;

        [FindsBy(How = How.CssSelector, Using = "a.btn.login-button")]
        public IWebElement loginbtn;

        [FindsBy(How = How.Id, Using = "dUsername")]
        public IWebElement usr;

        [FindsBy(How = How.XPath, Using = "//*[@id='layout']/tbody/tr[1]/td[1]/div")]
        public IWebElement pagewait;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement pass;

        [FindsBy(How = How.Id, Using = "loginBtn")]
        public IWebElement next;

        [FindsBy(How = How.CssSelector, Using = "button#me-button.button")]
        public IWebElement profile;

        [FindsBy(How = How.CssSelector, Using = "input#preferredName")]
        public IWebElement prefname;

        [FindsBy(How = How.CssSelector, Using = "button#notifications-button.button")]
        public IWebElement notifications;

        [FindsBy(How = How.CssSelector, Using = "button#main-menu-button.button")]
        public IWebElement menu;

        [FindsBy(How = How.Id, Using = "anti_sizzle_do_not_remove")]
        public IWebElement personal;

        [FindsBy(How = How.CssSelector, Using = "div#has_Preferred_Name.card")]
        public IWebElement namelbl;

        [FindsBy(How = How.Id, Using = "preferredName")]
        public IWebElement nametxt;

        [FindsBy(How = How.CssSelector, Using = "div#has_occupation")]
        public IWebElement occupation;
        
        [FindsBy(How = How.CssSelector, Using = "div.profile-section-title")]
        public IWebElement prefferedname;

        [FindsBy(How = How.Id, Using = "main-menu-button")]
        public IWebElement menubtn;
    }
}
