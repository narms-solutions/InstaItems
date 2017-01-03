

using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
//using InstaAndHygiene.InstaItems;
//using OpenQA.Selenium.Interactions.Actions ;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
namespace InstaAndHygiene
{
    public class Acts
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
        }
        public static string option = "";
        public static string Delivery = "";

        static IWebElement WorkOrder;
        static IWebElement OrderRoom;
        public static void LoginCredentials(string MobileNumber, string UserName, string password)
        {
            LoginPage login = new LoginPage();
            login.MobileNumber.Clear();
            login.MobileNumber.SendKeys(MobileNumber);
            login.OKButton.Click();
            login.UserName.Clear();
            login.UserName.SendKeys(UserName);
            login.Password.Clear();
            login.Password.SendKeys(password);
            login.LoginButton.Click();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Succesfully Login !");

        }
        public static void Attendance()
        {
            Attendance attend = new Attendance();
            attend.MobileAttendance.Click();
            IList<IWebElement> subelements = attend.AttendanceContainer.FindElements(By.ClassName("user-item"));
            string ContainerSize = subelements.Count.ToString();
            Assert.AreEqual(ContainerSize, "4");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Number of orders found for Care user:" + ContainerSize);
            Thread.Sleep(3000);
            attend.BackButton.Click();
            //Console.WriteLine("Number of orders found for Care user:" + ContainerSize ); //Count=6
            //IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            //Thread.Sleep(3000);
            //js.ExecuteScript("window.scrollBy(0,900);");
            //js.ExecuteScript("window.scrollTo(0, 0);");
        }
        public static void EventReport(string Time)
        {
            EventReporting Report = new EventReporting();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,500);");
            Report.MobileEventReporting.Click();
            Thread.Sleep(2000);
            Report.Subscriber.Click();
            Thread.Sleep(2000);
            Report.FirstCustomer.Click();
            Thread.Sleep(2000);
            Report.FirstAvistaPlace.Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300);");
            Report.AvistaRoom.Click();
            Thread.Sleep(2000);
            Report.Room1.Click();
            Thread.Sleep(2000);
            Report.LarmActivity.Click();
            Thread.Sleep(2000);
            Report.MemoText.SendKeys(Time);
            Thread.Sleep(2000);
            Report.SaveButton.Click();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Done Event Reporting !");
        }
        public static void StartUnplannedTask()
        {
            StartUnplannedTasks unpalnnedTask = new StartUnplannedTasks();
            unpalnnedTask.StartUnPlannedOrder.Click();
            Thread.Sleep(1000);
            unpalnnedTask.StartandEndButton.Click();
            Thread.Sleep(1000);
            unpalnnedTask.Subscriber.Click();
            Thread.Sleep(1000);
            unpalnnedTask.FirstCustomer.Click();
            Thread.Sleep(2000);
            unpalnnedTask.FirstAvistaPlace.Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,300);");
            unpalnnedTask.AvistaRoom.Click();
            Thread.Sleep(2000);
            unpalnnedTask.Room1.Click();
            Thread.Sleep(2000);
            unpalnnedTask.WallActivity.Click();
            Thread.Sleep(1000);
            unpalnnedTask.SaveButton.Click();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Done UnpalnnedTasks !");

        }


        public static void FirstInspection(string Time)
        {
            MyWorkOrderTasks order = new MyWorkOrderTasks();
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
         
            
            
            for (int Delivery = 1; Delivery < 6; Delivery++)
            {
                js.ExecuteScript("window.scrollBy(0,500);");
                order.MyWorkOrderTask.Click();
                WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(" + Delivery + ") > div.order-text"));
                js.ExecuteScript("window.scrollTo(0, 0);");
                
                    WorkOrder.Click();
                    //order.ContinueTask.Click();
                    order.SatrtButton.Click();
                    order.TopAvistaPlace.Click();
                    IList<IWebElement> subelements = order.OrderListContainer.FindElements(By.ClassName("room-item"));
                    //int length = subelements.Count;
                    for (int option = 9; option < subelements.Count+3; option++)
                    {
                        OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child("+ option +")"));

                        if (option<8)
                        {

                            js.ExecuteScript("window.scrollTo(0, 0);");
                            try
                            {
                                OrderRoom.Click();
                                order.InstaOrHygiene.Click();

                                js.ExecuteScript("window.scrollTo(0, 0);");
                                order.FirstSoftTextBox.Click();
                                Thread.Sleep(1000);
                                order.FirstHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DirtSecondHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DustFourthSoftTextBox.Click();
                                Thread.Sleep(1000);
                                js.ExecuteScript("window.scrollBy(0,300);");
                                order.SatinsFirstSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilingSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilinghardBox.Click();
                                Thread.Sleep(2000);
                                Thread.Sleep(2000);

                                order.EditButton.Click();
                                Thread.Sleep(1000);
                                order.TextArea.SendKeys(Time);
                                Thread.Sleep(1000);
                                order.OkButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done memo text!");

                                order.DoneButton.Click();
                                Thread.Sleep(1000);
                                order.YesButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done Room 1!");


                            }
                            catch (OpenQA.Selenium.StaleElementReferenceException e)
                            {
                                OrderRoom.Click();
                                order.InstaOrHygiene.Click();

                                js.ExecuteScript("window.scrollTo(0, 0);");
                                order.FirstSoftTextBox.Click();
                                Thread.Sleep(1000);
                                order.FirstHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DirtSecondHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DustFourthSoftTextBox.Click();
                                Thread.Sleep(1000);
                                js.ExecuteScript("window.scrollBy(0,300);");
                                order.SatinsFirstSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilingSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilinghardBox.Click();
                                Thread.Sleep(2000);
                                Thread.Sleep(2000);

                                order.EditButton.Click();
                                Thread.Sleep(1000);
                                order.TextArea.SendKeys(Time);
                                Thread.Sleep(1000);
                                order.OkButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done memo text!");

                                order.DoneButton.Click();
                                Thread.Sleep(1000);
                                order.YesButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done Room 1!");

                                
                                //throw;
                            }
                          

                        }
                        else  if(option<15)
                        {
                            js.ExecuteScript("window.scrollBy(0,500);");
                            try
                            {
                               
                                OrderRoom.Click();
                                order.InstaOrHygiene.Click();
                                js.ExecuteScript("window.scrollTo(0, 0);");
                                order.FirstSoftTextBox.Click();
                                Thread.Sleep(1000);
                                order.FirstHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DirtSecondHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DustFourthSoftTextBox.Click();
                                Thread.Sleep(1000);
                                js.ExecuteScript("window.scrollBy(0,300);");
                                order.SatinsFirstSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilingSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilinghardBox.Click();
                                Thread.Sleep(2000);
                                Thread.Sleep(2000);

                                order.EditButton.Click();
                                Thread.Sleep(1000);
                                order.TextArea.SendKeys(Time);
                                Thread.Sleep(1000);
                                order.OkButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done memo text!");

                                order.DoneButton.Click();
                                Thread.Sleep(1000);
                                order.YesButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done Room 1!");

                            }
                            catch (OpenQA.Selenium.StaleElementReferenceException exe)
                            {
                                OrderRoom.Click();
                                order.InstaOrHygiene.Click();
                                js.ExecuteScript("window.scrollTo(0, 0);");
                                order.FirstSoftTextBox.Click();
                                Thread.Sleep(1000);
                                order.FirstHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DirtSecondHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DustFourthSoftTextBox.Click();
                                Thread.Sleep(1000);
                                js.ExecuteScript("window.scrollBy(0,300);");
                                order.SatinsFirstSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilingSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilinghardBox.Click();
                                Thread.Sleep(2000);
                                Thread.Sleep(2000);

                                order.EditButton.Click();
                                Thread.Sleep(1000);
                                order.TextArea.SendKeys(Time);
                                Thread.Sleep(1000);
                                order.OkButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done memo text!");

                                order.DoneButton.Click();
                                Thread.Sleep(1000);
                                order.YesButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done Room 1!");
                                
                                //throw;
                            }
                         

                        }
                        else
                        {
                            js.ExecuteScript("window.scrollBy(0,900);");
                            try
                            {
                                OrderRoom.Click();
                                order.InstaOrHygiene.Click();
                                js.ExecuteScript("window.scrollTo(0, 0);");
                                order.FirstSoftTextBox.Click();
                                Thread.Sleep(1000);
                                order.FirstHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DirtSecondHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DustFourthSoftTextBox.Click();
                                Thread.Sleep(1000);
                                js.ExecuteScript("window.scrollBy(0,300);");
                                order.SatinsFirstSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilingSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilinghardBox.Click();
                                Thread.Sleep(2000);
                                Thread.Sleep(2000);

                                order.EditButton.Click();
                                Thread.Sleep(1000);
                                order.TextArea.SendKeys(Time);
                                Thread.Sleep(1000);
                                order.OkButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done memo text!");

                                order.DoneButton.Click();
                                Thread.Sleep(1000);
                                order.YesButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done Room 1!");

                            }
                            catch (OpenQA.Selenium.StaleElementReferenceException ex)
                            {

                                OrderRoom.Click();
                                order.InstaOrHygiene.Click();
                                js.ExecuteScript("window.scrollTo(0, 0);");
                                order.FirstSoftTextBox.Click();
                                Thread.Sleep(1000);
                                order.FirstHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DirtSecondHardTextBox.Click();
                                Thread.Sleep(1000);
                                order.DustFourthSoftTextBox.Click();
                                Thread.Sleep(1000);
                                js.ExecuteScript("window.scrollBy(0,300);");
                                order.SatinsFirstSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilingSoftBox.Click();
                                Thread.Sleep(1000);
                                order.SoilinghardBox.Click();
                                Thread.Sleep(2000);
                                Thread.Sleep(2000);

                                order.EditButton.Click();
                                Thread.Sleep(1000);
                                order.TextArea.SendKeys(Time);
                                Thread.Sleep(1000);
                                order.OkButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done memo text!");

                                order.DoneButton.Click();
                                Thread.Sleep(1000);
                                order.YesButton.Click();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Done Room 1!");

                                //throw;
                            }
                            
                        }


                
                }

            }

        }
    }
}
