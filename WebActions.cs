
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
namespace InstaAndHygiene
{
   public class WebActions
    {
        public static void InitializeWebDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.WebURL);
            Driver.driver.Manage().Window.Maximize();
        }
        public static void WebloginCredentials(string WebUserName, string Webpassword)
        {
            LoginPage login = new LoginPage();
            login.WebUserName.Clear();
            login.WebUserName.SendKeys(WebUserName);
            login.WebPassword.Clear();
            login.WebPassword.SendKeys(Webpassword);
            login.WebSubmitButton.Click();
            //login.SubscriberNarmadaTestkonto.Click();
            //login.SubmitAfterSubscriberSel.Click();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Succesfully Login !");
        }
       public static void MenuSelection()
        {
            WebMenu menu = new WebMenu();
            //menu.TopMenu.Click();
          
            Thread.Sleep(3000);
            menu.TopMenu.Click();
            Thread.Sleep(3000);
            //Action action = new Action(Actions.InitialiseDriver);
            //BRP.Blank.Click();
            menu.ShiftScheme.Click();
            Thread.Sleep(3000);
            //IList<IWebElement> subelements =menu.MenuContainer.FindElements(By.ClassName("webix_list_item"));
            //menu.MenuContainer.Click();
            //Console.WriteLine(subelements);

        }
    }
}
