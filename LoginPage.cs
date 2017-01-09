
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace InstaAndHygiene
{
   public class LoginPage
    {
       public LoginPage()
       {
           PageFactory.InitElements(Driver.driver, this);
       }
       /// <summary>
       /// ///////////////////////////////////////////////////////////////
       /// ****************Mobile LogIn Credentials*************************
       /// ////////////////////////////////////////////////////////////////
       /// </summary>
       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.input-field > input")]
       public IWebElement MobileNumber { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.buttons-field > div > span")]
       public IWebElement OKButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.user-name > input")]
       public IWebElement UserName { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.user-pass > input")]
       public IWebElement Password { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div:nth-child(4) > button > span")]
       public IWebElement LoginButton { get; set; }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// **************** WEB LogIn Credentials*************************
        /// ////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

       [FindsBy(How = How.CssSelector, Using = "[type='text']")]
       public IWebElement WebUserName { get; set; }

       [FindsBy(How = How.CssSelector, Using = "[type='password']")]
       public IWebElement WebPassword { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div.webix_view.webix_layout_line > div.webix_view.body.webix_layout_line > div.webix_view.webix_layout_line > div.webix_view.webix_form.webix_layout_form > div > div:nth-child(8) > div.webix_view.webix_control.webix_el_button.custom_next_button > div > button")]
       public IWebElement WebSubmitButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(6) > div > div.webix_win_body > div > div > div.webix_view.webix_control.webix_el_combo > div")]
       public IWebElement DropDownSubscriberList { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(6) > div > div.webix_win_body > div > div > div.webix_view.webix_control.webix_el_combo > div > span")]
       public IWebElement PopUp { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(6) > div > div.webix_win_body > div > div > div:nth-child(2)")]
       public IWebElement SubscriberNarmadaTestkonto { get; set; }

       [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(7) > div > div.webix_win_body > div > div > div.webix_view.webix_layout_line > div.webix_view.webix_control.webix_el_button.custom_next_button > div > button")]
       public IWebElement SubmitAfterSubscriberSel { get; set; }

    }
}
