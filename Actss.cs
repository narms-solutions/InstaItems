
using OpenQA.Selenium;
using System.Threading;
namespace InstaAndHygiene
{
   public class Actss
    {
       public static void InitializeDriver()
       {
           Driver.driver.Navigate().GoToUrl(Config.BaseURL);
           Driver.driver.Manage().Window.Maximize();
       }
       public static void MobileStatistics()
       {
           Stati stic = new Stati();
           Thread.Sleep(1000);
           IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
           js.ExecuteScript("window.scrollBy(0,600);");
           Thread.Sleep(1000);
           stic.StatisticMenu.Click();
           Thread.Sleep(1000);
           stic.Activity.Click();
           Thread.Sleep(1000);
           stic.ActivityMenu.Click();
           Thread.Sleep(1000);
           stic.DayDropDown.Click();
           Thread.Sleep(1000);
       }
    }
}
