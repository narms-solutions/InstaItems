

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace InstaAndHygiene
{
   public class WebMenu
    {
       public WebMenu()
       {
           PageFactory.InitElements(Driver.driver, this);
       }
       [FindsBy(How = How.CssSelector, Using = "[type='combo']")]
       public IWebElement TopMenu { get; set; }


       //[FindsBy(How = How.CssSelector, Using = "https://a5.avistatime.com/index.php")]
       //public IWebElement TopMenu { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "body > div.webix_view.webix_layout_line > div.webix_view.my_layout_cell.top_layout.webix_layout_line > div.webix_view.webix_menu-x.avista_menu > div > a:nth-child(8)")]
       //public IWebElement Blank { get; set; }

       //[FindsBy(How = How.Id, Using = "body > div.webix_view.webix_layout_line > div.webix_view.my_layout_cell.top_layout.webix_layout_line > div.webix_view.webix_menu-x.avista_menu > div > a:nth-child(7)")]
       //public IWebElement Planning { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "body > div:nth-child(8) > div > div.webix_win_body > div > a:nth-child(1)")]
       //public IWebElement ShiftScheme { get; set; }


       ////Checking Shift Schedule has all the schedules as in the test case

       //[FindsBy(How = How.CssSelector, Using = "#datatable_a1482419952635 > div.webix_ss_body")]
       //public IWebElement FirstRowTwoShift { get; set; }

       [FindsBy(How=How.CssSelector,Using="body > div.webix_view.webix_layout_line > div.webix_view.webix_layout_layout > div.webix_view.webix_toolbar.webix_layout_toolbar > div > div:nth-child(7) > div > button")]
       public IWebElement DownloadButton { get; set; }

       [FindsBy(How=How.CssSelector,Using="body > div.webix_view.webix_layout_line > div.webix_view.my_layout_cell.top_layout.webix_layout_line > div.webix_view.webix_menu-x.avista_menu > div > a:nth-child(2)")]
       public IWebElement LanguageChange { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(25) > div")]
       public IWebElement SelLanEng { get; set; }

       [FindsBy(How = How.XPath, Using = "/html/body/div[24]/div/div[2]/div/a[1]")]
       public IWebElement Eng { get; set; }


       //////////////////////////////////////////Reports/////////////////////////////////////////////////

       [FindsBy(How = How.CssSelector, Using = "[type='text']")]
       public IWebElement StatusTab { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(14) > div > div.webix_win_body > div > div.webix_view.webix_list.webix_multilist > div > div:nth-child(2) > span")]
       public IWebElement StatusEnded { get; set; }

       [FindsBy(How = How.XPath, Using = "//*[@id=\"datatable_a1483967223124\"]/div[2]/div[2]/div/div[5]")]
       public IWebElement RowSelect { get; set; }

       [FindsBy(How=How.XPath,Using="//*[@id=\"datatable_a1483967107104\"]/div[2]/div[2]/div/div[5]/div[1]")]
       public IWebElement Row { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div.webix_view.webix_layout_line > div.webix_view.webix_layout_layout > div.webix_view.webix_toolbar.webix_layout_toolbar > div > div:nth-child(12) > div > span")]
       public IWebElement Charts { get; set; }

       [FindsBy(How=How.CssSelector,Using="body > div:nth-child(13) > div > div.webix_win_body > div > div")]
       public IWebElement ChartContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(27) > div > div.webix_win_head > div > div > div.webix_view.webix_control.webix_el_icon > button > span")]
       public IWebElement CloseChart { get; set; }


       [FindsBy(How = How.ClassName, Using = "webix_ss_body")]
        public IWebElement Temp { get; set; }
       [FindsBy(How = How.ClassName, Using = "webix_ss_center_scroll")]
       public IWebElement Temp1 { get; set; }

       [FindsBy(How=How.ClassName,Using="webix_ss_header")]
       public IWebElement TempHeader { get; set; }

       [FindsBy(How = How.ClassName, Using = "webix_hs_center")]
       public IWebElement TempHeaderContainer { get; set; }

       [FindsBy(How = How.ClassName, Using = "webix_column")]
       public IWebElement Table { get; set; }

       [FindsBy(How = How.CssSelector, Using = "webix_column.s1484226787595.webix_last")]
       public IWebElement Table1 { get; set; }

       [FindsBy(How=How.ClassName,Using="webix_c_scroll_y")]
       public IWebElement footerscroollBar { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div.webix_view.webix_layout_line > div.webix_view.dashboard.webix_layout_space > div.webix_view.webix_layout_space > div.webix_view.webix_dataview.dashboard_report > div > div:nth-child(1) > div:nth-child(4)")]
       public IWebElement TestFolder { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div.webix_view.webix_layout_line > div.webix_view.dashboard.webix_layout_space > div.webix_view.webix_layout_space > div.webix_view.webix_dataview.dashboard_report > div > div:nth-child(1) > div:nth-child(2) > div")]
       public IWebElement NewResult { get; set; }

       [FindsBy(How = How.XPath, Using = "//*[@id=\"datatable_a1484209190619\"]/div[2]/div[2]/div/div[9]")]
       public IWebElement Column { get; set; }

       [FindsBy(How=How.CssSelector,Using="body > div.webix_view.webix_layout_line > div.webix_view.my_layout_cell.bottom_layout.webix_layout_line > div:nth-child(1) > div > button")]
       public IWebElement BottomSelection { get; set; }

       [FindsBy(How=How.CssSelector,Using="body > div:nth-child(5) > div > div.webix_win_body > div > div.webix_view.webix_layout_line > div:nth-child(3) > div > button")]
       public IWebElement NoneButton { get; set; }

       [FindsBy(How = How.ClassName, Using = "webix_column")]
       public IWebElement CapitalN { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#datatable1484562384714 > div.webix_ss_body > div.webix_ss_center > div > div.webix_column.s1484562384724.webix_first > div:nth-child(21)")]
       public IWebElement SmallN { get; set; }
    }
}
