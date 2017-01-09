
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using InstaAndHygiene.InstaItems;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace InstaAndHygiene
{
   public class WebActions
    {
        public static void InitializeWebDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.WebURL);
            Driver.driver.Manage().Window.Maximize();
        }
        public static string WebOption = "";
        static IWebElement ChartsList;
        public static void WebloginCredentials(string WebUserName, string Webpassword)
        {
            LoginPage login = new LoginPage();
            login.WebUserName.Clear();
            login.WebUserName.SendKeys(WebUserName);
            login.WebPassword.Clear();
            login.WebPassword.SendKeys(Webpassword);
            login.WebSubmitButton.Click();

       
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Succesfully Login !");
        }
       public static void MenuSelection()
        {
            WebMenu menu = new WebMenu();
            Thread.Sleep(2000);
           Driver.driver.Navigate().GoToUrl(Config.SubscriberURL);
           //menu.LanguageChange.Click();
           //Thread.Sleep(2000);
           //IList<IWebElement> subelements = menu.SelLanEng.FindElements(By.XPath("/html/body/div[24]/div/div[2]/div/a[1]"));
           //Thread.Sleep(2000);
           //menu.Eng.Click();
           //Thread.Sleep(2000);
            menu.DownloadButton.Click();
            Thread.Sleep(2000);
            menu.StatusTab.Click();
            Thread.Sleep(2000);
            menu.StatusEnded.Click();
            Thread.Sleep(2000);

            
            Thread.Sleep(2000);
         
           
            for (int WebOption = 1; WebOption < 13; WebOption++)
            {
                    menu.Charts.Click();
                    // IList<IWebElement> subelements = menu.ChartContainer.FindElements(By.ClassName("webix_list_item"));
                    //Console.WriteLine(subelements.Count);
                    ChartsList = Driver.driver.FindElement(By.CssSelector("body > div:nth-child(13) > div > div.webix_win_body > div > div > div:nth-child( " + WebOption + ")"));

                    Thread.Sleep(2000);
                    ChartsList.Click();
                    Thread.Sleep(2000);
                    Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                    String fp = @"C:\Users\narms\Desktop\Insta\" + "FirstRow" + WebOption + DateTime.Now.ToString("_dd_MMMM_hh_mm_ss_tt") + ".png";
                    ss.SaveAsFile(fp, System.Drawing.Imaging.ImageFormat.Png);
                    Thread.Sleep(2000);
                    menu.CloseChart.Click();

                               
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finished taking ScreenShots for first Row !");
          
        }
    }
}
