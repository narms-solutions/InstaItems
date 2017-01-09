

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
        public static void FlowThrough(string Time)
        {
            MyWorkOrderTasks Tasks = new MyWorkOrderTasks();
            OrderRoom.Click();
            Tasks.InstaOrHygiene.Click();
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollTo(0, 0);");

            Tasks.FirstSoftTextBox.Click();
            Thread.Sleep(1000);
            Tasks.FirstHardTextBox.Click();
            Thread.Sleep(1000);
            //Tasks.DirtSecondHardTextBox.Click();
            //Thread.Sleep(1000);
            Tasks.DustFourthSoftTextBox.Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,300);");
            Tasks.SatinsFirstSoftBox.Click();
            Thread.Sleep(1000);
            //Tasks.SoilingSoftBox.Click();
            //Thread.Sleep(1000);
            Tasks.SoilinghardBox.Click();
            Thread.Sleep(2000);


            Tasks.EditButton.Click();
            Thread.Sleep(1000);
            Tasks.TextArea.SendKeys(Time);
            Thread.Sleep(1000);
            Tasks.OkButton.Click();
           
            Tasks.DoneButton.Click();
            Thread.Sleep(1000);
            Tasks.YesButton.Click();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            


        }


        public static void FirstInspection()
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

              order.ContinueTask.Click();
               //order.SatrtButton.Click();
                order.TopAvistaPlace.Click();
                IList<IWebElement> subelements = order.OrderListContainer.FindElements(By.ClassName("room-item"));
                //int length = subelements.Count;
                for (int option = 3; option < subelements.Count + 3; option++)
                {
                    OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));

                    if (option < 20)
                    {

                        js.ExecuteScript("window.scrollTo(0, 0);");
                        try
                        {
                            Acts.FlowThrough(Config.MemoText.Time);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Done memo text for " + option + "!");
                            Console.WriteLine("Done Room for " + option + "!");


                            //OrderRoom.Click();
                            //order.InstaOrHygiene.Click();

                            //js.ExecuteScript("window.scrollTo(0, 0);");
                            //order.FirstSoftTextBox.Click();
                            //Thread.Sleep(1000);
                            //order.FirstHardTextBox.Click();
                            //Thread.Sleep(1000);
                            //order.DirtSecondHardTextBox.Click();
                            //Thread.Sleep(1000);
                            //order.DustFourthSoftTextBox.Click();
                            //Thread.Sleep(1000);
                            //js.ExecuteScript("window.scrollBy(0,300);");
                            //order.SatinsFirstSoftBox.Click();
                            //Thread.Sleep(1000);
                            //order.SoilingSoftBox.Click();
                            //Thread.Sleep(1000);
                            //order.SoilinghardBox.Click();
                            //Thread.Sleep(2000);
                            //Thread.Sleep(2000);

                            //order.EditButton.Click();
                            //Thread.Sleep(1000);
                            //order.TextArea.SendKeys(Time);
                            //Thread.Sleep(1000);
                            //order.OkButton.Click();
                            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            //Console.WriteLine("Done memo text!");

                            //order.DoneButton.Click();
                            //Thread.Sleep(1000);
                            //order.YesButton.Click();
                            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            //Console.WriteLine("Done Room 1!");


                        }
                        catch (OpenQA.Selenium.StaleElementReferenceException e)
                        {
                            Acts.FlowThrough(Config.MemoText.Time);
                            //OrderRoom.Click();
                            //order.InstaOrHygiene.Click();

                            //js.ExecuteScript("window.scrollTo(0, 0);");
                            //order.FirstSoftTextBox.Click();
                            //Thread.Sleep(1000);
                            //order.FirstHardTextBox.Click();
                            //Thread.Sleep(1000);
                            //order.DirtSecondHardTextBox.Click();
                            //Thread.Sleep(1000);
                            //order.DustFourthSoftTextBox.Click();
                            //Thread.Sleep(1000);
                            //js.ExecuteScript("window.scrollBy(0,300);");
                            //order.SatinsFirstSoftBox.Click();
                            //Thread.Sleep(1000);
                            //order.SoilingSoftBox.Click();
                            //Thread.Sleep(1000);
                            //order.SoilinghardBox.Click();
                            //Thread.Sleep(2000);
                            //Thread.Sleep(2000);

                            //order.EditButton.Click();
                            //Thread.Sleep(1000);
                            //order.TextArea.SendKeys(Time);
                            //Thread.Sleep(1000);
                            //order.OkButton.Click();
                            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            //Console.WriteLine("Done memo text!");

                            //order.DoneButton.Click();
                            //Thread.Sleep(1000);
                            //order.YesButton.Click();
                            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            //Console.WriteLine("Done Room 1!");


                            //throw;
                        }


                    }
                    else if (option < 15)
                    {
                        js.ExecuteScript("window.scrollBy(0,500);");
                        try
                        {
                            Acts.FlowThrough(Config.MemoText.Time);

                        }
                        catch (OpenQA.Selenium.StaleElementReferenceException exe)
                        {
                            Acts.FlowThrough(Config.MemoText.Time);
                            //throw;
                        }


                    }
                    else
                    {
                        js.ExecuteScript("window.scrollBy(0,900);");
                        try
                        {
                            Acts.FlowThrough(Config.MemoText.Time);
                        }
                        catch (OpenQA.Selenium.StaleElementReferenceException ex)
                        {

                            Acts.FlowThrough(Config.MemoText.Time);
                        }

                    }



                }

            }

        }
        public static void HygieneQualityCheck(String Time)
        {
            MyWorkOrderTasks Hygiene = new MyWorkOrderTasks();
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,500);");
            Hygiene.MyWorkOrderTask.Click();
            js.ExecuteScript("window.scrollTo(0, 0);");
          
            Thread.Sleep(1000);
            Hygiene.HygieneWorkOrder.Click();
            Hygiene.SatrtButton.Click();
          
            Hygiene.TopAvistaPlace.Click();
            IList<IWebElement> subelements = Hygiene.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
                if(option==3)
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                   // Hygiene.HBM.Click();
                    //Thread.Sleep(1000);
                    Hygiene.WasteSoftAccesss.Click();
                    Thread.Sleep(1000);
                    Hygiene.DustHardAccess.Click();
                    Thread.Sleep(1000);
                   
                    Hygiene.EditButton.Click();
                    Hygiene.TextArea.SendKeys(Time);
                    Thread.Sleep(1000);
                    Hygiene.OkButton.Click();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for room " + option + "!");

                    Hygiene.DoneButton.Click();
                    Thread.Sleep(1000);
                    Hygiene.YesButton.Click();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done Room " + option + "!");
                    //Hygiene.LogOutButton.Click();
                    //Hygiene.LogOut.Click();
                }
                else
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    Hygiene.TableSoftAccess.Click();
                    Thread.Sleep(1000);
                    Hygiene.TableDustHard.Click();
                    Thread.Sleep(1000);
                    Hygiene.TableDustHard.Click();

                    Hygiene.EditButton.Click();
                    Hygiene.TextArea.SendKeys(Time);
                    Thread.Sleep(1000);
                    Hygiene.OkButton.Click();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for room " + option + "!");

                    Hygiene.DoneButton.Click();
                    Thread.Sleep(1000);
                    Hygiene.YesButton.Click();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done Room " + option + "!");
                }

            
            }

        }
        public static void InstaFlowThrough(string Time)
        {
            MyWorkOrderTasks flow = new MyWorkOrderTasks();
           
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0, 0);");
            flow.FirstSoftTextBox.Click();
            Thread.Sleep(1000);
            //flow.FirstHardTextBox.Click();
            //Thread.Sleep(1000);
            flow.DirtSecondHardTextBox.Click();
            Thread.Sleep(1000);
            flow.DustFourthSoftTextBox.Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,300);");
            flow.SatinsFirstSoftBox.Click();
            Thread.Sleep(1000);
            //flow.SoilingSoftBox.Click();
            //Thread.Sleep(1000);
            //flow.SoilinghardBox.Click();
            //Thread.Sleep(2000);


            flow.EditButton.Click();
            Thread.Sleep(1000);
            flow.TextArea.SendKeys(Time);
            Thread.Sleep(1000);
            flow.OkButton.Click();
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("Done memo text for room "+option+"!");

            flow.DoneButton.Click();
            Thread.Sleep(1000);
           // flow.YesButton.Click();
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("Done Room " + option + "!");
        }


        public static void  MunicipalityInsta()
        {
            MyWorkOrderTasks insta = new MyWorkOrderTasks();
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,500);");
            insta.MyWorkOrderTask.Click();
            insta.InstaWorkOrder.Click();
            //insta.ContinueTask.Click();
           insta.SatrtButton.Click();
            insta.InstaTopavistaPlace.Click();
            IList<IWebElement> subelements = insta.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
                if(option<8)
                {
                    js.ExecuteScript("window.scrollTo(0, 0);");
                    try
                    {
                        OrderRoom.Click();
                        Acts.InstaFlowThrough(Config.MemoText.Time);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Done memo text for room " + option + "!");
                        Console.WriteLine("Done Room " + option + "!");

                    }
                    catch (OpenQA.Selenium.StaleElementReferenceException ex)
                    {
                        OrderRoom.Click();
                        Acts.InstaFlowThrough(Config.MemoText.Time);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Done memo text for room " + option + "!");
                        Console.WriteLine("Done Room " + option + "!");
                    }
               
                }
                //else if (option < 13)
                //{
                //    js.ExecuteScript("window.scrollBy(0,300);");
                //    try
                //    {
                //        Acts.InstaFlowThrough(Config.MemoText.Time);

                //    }
                //    catch (OpenQA.Selenium.StaleElementReferenceException ex)
                //    {
                //        Acts.InstaFlowThrough(Config.MemoText.Time);
                //        //throw;
                //    }


                //}
            
                
                else
                {
                    js.ExecuteScript("window.scrollBy(0,900);");
                    try
                    {
                        OrderRoom.Click();
                        Acts.InstaFlowThrough(Config.MemoText.Time);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Done memo text for room " + option + "!");
                        Console.WriteLine("Done Room " + option + "!");
                    }
                    catch (OpenQA.Selenium.StaleElementReferenceException ex)
                    {
                        OrderRoom.Click();
                        Acts.InstaFlowThrough(Config.MemoText.Time);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Done memo text for room " + option + "!");
                        Console.WriteLine("Done Room " + option + "!");
                    }

                }

            }
        }

    }
}
