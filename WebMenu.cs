

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
       //[FindsBy(How = How.Id, Using = "main_menu")]
       //public IWebElement TopMenu { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "body > div:nth-child(10) > div > div.webix_win_body > div > a:nth-child(11)")]
       //public IWebElement MenuContainer { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div.webix_view.webix_layout_line > div.webix_view.my_layout_cell.top_layout.webix_layout_line > div.webix_view.webix_menu-x.avista_menu")]
       public IWebElement TopMenu { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div.webix_view.webix_layout_line > div.webix_view.dashboard.webix_layout_space > div.webix_view.webix_dataview.dashboard_report")]
       public IWebElement Blank { get; set; }

       [FindsBy(How = How.Id, Using = "body > div.webix_view.webix_layout_line > div.webix_view.my_layout_cell.top_layout.webix_layout_line > div.webix_view.webix_menu-x.avista_menu > div > a:nth-child(7)")]
       public IWebElement Planning { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(8) > div > div.webix_win_body > div > a:nth-child(1)")]
       public IWebElement ShiftScheme { get; set; }

       //Checking Shift Schedule has all the schedules as in the test case

       [FindsBy(How = How.CssSelector, Using = "#datatable_a1482419952635 > div.webix_ss_body")]
       public IWebElement FirstRowTwoShift { get; set; }

    }
}
