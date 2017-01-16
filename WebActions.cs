
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
//using InstaAndHygiene.InstaItems;
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
            Driver.driver.Navigate().GoToUrl(Config.DashBoardURL);
            Thread.Sleep(2000);
            menu.BigN.Click();
            //Driver.driver.Navigate().GoToUrl(Config.SubscriberURL);
            //menu.LanguageChange.Click();
            //Thread.Sleep(2000);
            //IList<IWebElement> subelements = menu.SelLanEng.FindElements(By.XPath("/html/body/div[24]/div/div[2]/div/a[1]"));
            //Thread.Sleep(2000);
            //menu.Eng.Click();
            //Thread.Sleep(2000);
            //menu.DownloadButton.Click();
            //Thread.Sleep(2000);
            //menu.StatusTab.Click();
            //Thread.Sleep(2000);
            //menu.StatusEnded.Click();
            Thread.Sleep(2000);
            // IList<IWebElement> rows_table = menu.Temp1.FindElements(By.LinkText("column"));
            //  menu.Table.Click();

            //IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;

            IWebElement val = Driver.driver.FindElement(By.TagName("table"));
            // IWebElement val2 = val.FindElement(By.XPath(".//tbody/tr/td[2]"));

            // IList<IWebElement> rows_table = menu.Table.FindElements(By.ClassName("webix_cell "));
            for (int i = 1; i < 9; i++)
            {
                IWebElement val2 = val.FindElement(By.XPath(".//tbody/tr/td[" + i + "]"));
                Console.WriteLine(val2.Text.Trim() + "\n");
                //val2.Click();
                var test_elements = Driver.driver.FindElements(By.XPath("//div[@column='" + i + "'] "));

                foreach (var item in test_elements)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(item.Text.Trim() + "\n");
                    item.Click();
                 

                    for (int WebOption = 1; WebOption < 13; WebOption++)
                    {
                        menu.Charts.Click();
                        IList<IWebElement> subelements = menu.ChartContainer.FindElements(By.ClassName("webix_list_item"));
                        Console.WriteLine(subelements.Count);
                        //ChartsList = Driver.driver.FindElement(By.CssSelector(" div > div.webix_win_body > div > div > div:nth-child("+ WebOption +")"));
                        ChartsList = Driver.driver.FindElement(By.CssSelector(" body > div:nth-child(15) > div > div.webix_win_body > div > div > div:nth-child(" + WebOption + ")"));

                        Thread.Sleep(3000);
                        ChartsList.Click();
                        Thread.Sleep(2000);
                        //int num = 100;
                        //var frequently = Driver.driver.FindElements(By.ClassName("highcharts-tooltip"));
                        //foreach (var e in frequently)
                        //{
                        //    var value = Int32.TryParse(e.GetAttribute("value"),out num); // Get barchart value.
                        //    Console.WriteLine(value);
                        //}
                        //string result = frequently[0].GetAttribute("value").Substring(0, 100);
                        //Console.WriteLine(result);

                        //var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
                        //IWebElement waitToolTip = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#highcharts-6 > svg > g.highcharts-tooltip")));

                        //String tooltipText = Driver.driver.FindElement(By.CssSelector("#highcharts-6 > svg > g.highcharts-tooltip")).Text;
                        //Console.WriteLine(tooltipText);

                        Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                        String fp = @"C:\Users\narms\Desktop\Insta\Test\" + "First_" + WebOption + DateTime.Now.ToString("_dd_MMMM_hh_mm_ss_tt") + ".png";
                        ss.SaveAsFile(fp, System.Drawing.Imaging.ImageFormat.Png);
                        Thread.Sleep(2000);
                        menu.CloseChart.Click();

                    }

                }
            }
                    //    }   //DebuggClass.PrintToFile(item.Text.ToString());



                    // var test1_elements = Driver.driver.FindElements(By.XPath("//div[@column='2'] "));
                    // var test2_elements = Driver.driver.FindElements(By.XPath("//div[@column='3'] "));
                    // IWebElement val2 = val.FindElement(By.XPath(".//tbody/tr/td[2]"));
                    // //Console.WriteLine(val2.Text.Trim() + "\n");
                    // //string value = test_elements.ToString();
                    // //Char delimiter = '\r';
                    // //String[] substrings = value.Split(delimiter);

                    //menu.Charts.Click();
                    //IList<IWebElement> subelements = menu.ChartContainer.FindElements(By.ClassName("webix_list_item"));
                    //Console.WriteLine(subelements.Count);
                    //Thread.Sleep(2000);

                    //for (int WebOption = 1; WebOption < 13; WebOption++)
                    //{
                    //    menu.Charts.Click();
                    //    // IList<IWebElement> subelements = menu.ChartContainer.FindElements(By.ClassName("webix_list_item"));
                    //    //Console.WriteLine(subelements.Count);
                    //    ChartsList = Driver.driver.FindElement(By.CssSelector("body > div:nth-child(13) > div > div.webix_win_body > div > div > div:nth-child( " + WebOption + ")"));

                    //    Thread.Sleep(2000);
                    //    ChartsList.Click();
                    //    Thread.Sleep(2000);
                    //    //int num = 100;
                    //    //    var frequently = Driver.driver.FindElements(By.ClassName("highcharts-tooltip"));
                    //    //    foreach (var e in frequently)
                    //    //    {
                    //    //        var value = Int32.TryParse(e.GetAttribute("value"),out num); // Get barchart value.
                    //    //        Console.WriteLine(value);
                    //    //    }
                    //    //    string result = frequently[0].GetAttribute("value").Substring(0,100);
                    //    //    Console.WriteLine(result);

                    //    //    var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
                    //    //    IWebElement waitToolTip = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#highcharts-6 > svg > g.highcharts-tooltip")));

                    //    //String tooltipText = Driver.driver.FindElement(By.CssSelector("#highcharts-6 > svg > g.highcharts-tooltip")).Text;
                    //    //    Console.WriteLine(tooltipText);

                    //    Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                    //    String fp = @"C:\Users\narms\Desktop\Insta\Test\" + "First_" + WebOption + DateTime.Now.ToString("_dd_MMMM_hh_mm_ss_tt") + ".png";
                    //    ss.SaveAsFile(fp, System.Drawing.Imaging.ImageFormat.Png);
                    //    Thread.Sleep(2000);
                    //    menu.CloseChart.Click();
                    //}




                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Finished taking ScreenShots for first Row !");
               
            }
        }
    }

     
   
//}
