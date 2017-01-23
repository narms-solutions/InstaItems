

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
        public static void LoginCredentialsWithOutMobileNumber( string UserName, string password)
        {
            LoginPage login1 = new LoginPage();
            login1.UserName.Clear();
            login1.UserName.SendKeys(UserName);
            login1.Password.Clear();
            login1.Password.SendKeys(password);
            login1.LoginButton.Click();
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
            Thread.Sleep(1000);
            Acts.StsrtUnpalnnedCommonCase();
            Thread.Sleep(1000);
            unpalnnedTask.WallActivity.Click();
            Thread.Sleep(1000);
            unpalnnedTask.SaveButton.Click();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Done UnpalnnedTasks !");

        }
        public static void StsrtUnpalnnedCommonCase()
        {
            StartUnplannedTasks unpalnnedTask = new StartUnplannedTasks();
            Thread.Sleep(1000);
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
        }

       
        public static void HptlOwnQualityMethod(string Comment)
        {
            StartUnplannedTasks unpalnnedTask = new StartUnplannedTasks();
            Thread.Sleep(1000);
            Acts.StsrtUnpalnnedCommonCase();
            Thread.Sleep(1000);

            unpalnnedTask.HPTLOwnqualityMethod.Click();
            Thread.Sleep(1000);
            unpalnnedTask.PatientPlatsValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.PatientPlatsValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.PatientComment.Click();
            Thread.Sleep(1000);
            unpalnnedTask.ChooseFourthComment.Click();
            Thread.Sleep(1000);

            unpalnnedTask.TvattComment.Click();
            Thread.Sleep(1000);
            unpalnnedTask.ChooseThirdComment.Click();
            Thread.Sleep(1000);

            unpalnnedTask.AvskarmingsValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.AvskarmingComment.Click();
            Thread.Sleep(1000);
            unpalnnedTask.ChooseSecondComment.Click();

            unpalnnedTask.SanitarInredningValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.SanitarInredningValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.SanitarInredningValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.SanitarComment.Click();
            Thread.Sleep(1000);
            unpalnnedTask.SanitarChooseFourthComment.Click();
            Thread.Sleep(1000);

            unpalnnedTask.GreppValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.GreppValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.GreppValue.Click();
            Thread.Sleep(1000);
            unpalnnedTask.GreppCommnet.Click();


            //unpalnnedTask.BordSendComment.SendKeys(Comment);
            //Thread.Sleep(1000);

            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300);");
            Thread.Sleep(1000);
            unpalnnedTask.TenicheInstallationSendComment.SendKeys(Comment);
            Thread.Sleep(1000);
            unpalnnedTask.OtherTeknicalValue.Click();
            Thread.Sleep(1000);

            Acts.CommonUseCase(Config.MemoText.Time);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Done memo text for " + option + "!");
            Console.WriteLine("Done UnpalnnedTasks !");

        }

        public static void MunicipalityOwnQualityMethod(string Comment)
        {
            StartUnplannedTasks MuniciQuality = new StartUnplannedTasks();
            Thread.Sleep(1000);
            MuniciQuality.StartUnPlannedOrder.Click();
            Thread.Sleep(1000);
            MuniciQuality.StartandEndButton.Click();
            Thread.Sleep(1000);
            MuniciQuality.Subscriber.Click();
            Thread.Sleep(1000);
            MuniciQuality.SelectSecondCustomer.Click();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300);");
            MuniciQuality.MTopAvistaplace.Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,300);");
            Thread.Sleep(1000);
            MuniciQuality.MFirstChild.Click();
            Thread.Sleep(1000);
            MuniciQuality.MFirstFirstChild.Click();
            Thread.Sleep(1000);
            MuniciQuality.MunipalityQualityMethod.Click();
            Thread.Sleep(1000);
            for (int RoomType = 1; RoomType < 5; RoomType++)
            {
                IWebElement Roomtype = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div.content > div:nth-child("+ RoomType +")"));
                if(RoomType==1)
                {
                    Roomtype.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.FirstCeiling.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.FirstCeiling.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.BesokCelingComment.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ChooseFirstComment.Click();
                    MuniciQuality.FirstWall.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.FirstWall.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.FirstWall.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.BesokWallComment.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.BesokChooseThirdComment.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.FirstDoors.SendKeys(Comment);
                    js.ExecuteScript("window.scrollBy(0,400);");
                    Thread.Sleep(1000);
                    MuniciQuality.FirstMats.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.FirstMats.Click();
                    Thread.Sleep(1000);
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done UnpalnnedTasks !");


                }
                else if(RoomType==2)
                {
                    Roomtype.Click();
                    Thread.Sleep(1000);
                    js.ExecuteScript("window.scrollBy(0,600);");
                    Thread.Sleep(1000);
                    MuniciQuality.SecondCeilling.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ArkivCeilingComment.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.Arkivchoosefirstcommnet.Click();
                    Thread.Sleep(1000);

                    MuniciQuality.SecondFloor.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ArkivFloorComment.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ArkivChooseThirdComment.Click();
                    MuniciQuality.SecondWall.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.SecondWall.Click();
                    Thread.Sleep(1000);
                    js.ExecuteScript("window.scrollBy(0,400);");
                    Thread.Sleep(1000);
                    MuniciQuality.SecondWindows.Click();
                    Thread.Sleep(1000);
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done UnpalnnedTasks !");

                }
                else if(RoomType==3)
                {
                    Roomtype.Click();
                    js.ExecuteScript("window.scrollBy(0,900);");
                    Thread.Sleep(1000);
                    MuniciQuality.ThirdFloor.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ThirdFurniture.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ThirdFurniture.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ThirdFurniture.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ThirdFurnitureSendComment.SendKeys(Comment);
                    MuniciQuality.ThirdMats.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.ThirdMats.Click();
                    Thread.Sleep(1000);
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done UnpalnnedTasks !");

                }
                else
                {
                     Roomtype.Click();
                    Thread.Sleep(1000);
                    MuniciQuality.FirstCeiling.Click();
                    Thread.Sleep(1000);
                     MuniciQuality.FirstWall.Click();
                    Thread.Sleep(1000);
                     js.ExecuteScript("window.scrollBy(0,500);");
                    Thread.Sleep(1000);
                     MuniciQuality.SecondFloor.Click();
                    Thread.Sleep(1000);
                     js.ExecuteScript("window.scrollBy(0,900);");
                    Thread.Sleep(1000);
                    MuniciQuality.ThirdFurniture.Click();
                    Thread.Sleep(1000);
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done UnpalnnedTasks !");

                }
               
            }
            MuniciQuality.OwnQualitysaveButton.Click();
        }
        public static void FlowThrough(string Time)
        {
            MyWorkOrderTasks Tasks = new MyWorkOrderTasks();
           
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

            Acts.CommonUseCase(Config.MemoText.Time);
         
        }


        public static void FirstInspection()
        {
            MyWorkOrderTasks order = new MyWorkOrderTasks();
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);


            for (int Delivery = 1; Delivery < 6; Delivery++)
            {
                js.ExecuteScript("window.scrollBy(0,500);");
                Thread.Sleep(1000);
                order.MyWorkOrderTask.Click();

                WorkOrder = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(" + Delivery + ") > div.order-text"));
                js.ExecuteScript("window.scrollTo(0, 0);");
                Thread.Sleep(1000);
                WorkOrder.Click();
                Thread.Sleep(1000);
               //order.ContinueTask.Click();
               order.SatrtButton.Click();
               Thread.Sleep(1000);
                order.TopAvistaPlace.Click();
                IList<IWebElement> subelements = order.OrderListContainer.FindElements(By.ClassName("room-item"));
                //int length = subelements.Count;
                for (int option = 3; option < subelements.Count + 3; option++)
                {
                    OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));

                    if (option < 9)
                    {

                        js.ExecuteScript("window.scrollTo(0, 0);");
                        try
                        {
                            OrderRoom.Click();
                            Acts.FlowThrough(Config.MemoText.Time);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Done memo text for " + option + "!");
                            Console.WriteLine("Done Room for " + option + "!");
                           
                        }
                        catch (OpenQA.Selenium.StaleElementReferenceException e)
                        {
                            OrderRoom.Click();
                            Acts.FlowThrough(Config.MemoText.Time);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Done memo text for " + option + "!");
                            Console.WriteLine("Done Room for " + option + "!");

                            
                        }

                    }
                    else if (option < 13)
                    {
                        js.ExecuteScript("window.scrollBy(0,400);");
                        try
                        {
                            OrderRoom.Click();
                            Acts.FlowThrough(Config.MemoText.Time);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Done memo text for " + option + "!");
                            Console.WriteLine("Done Room for " + option + "!");

                        }
                        catch (OpenQA.Selenium.StaleElementReferenceException exe)
                        {
                            OrderRoom.Click();
                            Acts.FlowThrough(Config.MemoText.Time);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Done memo text for " + option + "!");
                            Console.WriteLine("Done Room for " + option + "!");

                            //throw;
                        }
                    }
                    else
                    {
                       
                        js.ExecuteScript("window.scrollBy(0,900);");
                        try
                        {
                            OrderRoom.Click();
                            Acts.FlowThrough(Config.MemoText.Time);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Done memo text for " + option + "!");
                            Console.WriteLine("Done Room for " + option + "!");

                        }
                        catch (OpenQA.Selenium.StaleElementReferenceException ex)
                        {
                            OrderRoom.Click();
                            Acts.FlowThrough(Config.MemoText.Time);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Done memo text for " + option + "!");
                            Console.WriteLine("Done Room for " + option + "!");

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
                if (option < 5)
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    //Hygiene.TableSoft.Click();

                    // Hygiene.HBM.Click();
                    //Thread.Sleep(1000);
                    //Hygiene.WasteSoftAccesss.Click();
                    //Thread.Sleep(1000);
                    //Hygiene.DustHardAccess.Click();
                    //Thread.Sleep(1000);

                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done Room for " + option + "!");

                   // Hygiene.LogOutButton.Click();
                    //Hygiene.LogOut.Click();
                }
                else
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    Hygiene.TableSoft.Click();
                    //Hygiene.TableSoftAccess.Click();

                    //Thread.Sleep(1000);
                    //Hygiene.TableDustHard.Click();
                    //Thread.Sleep(1000);
                    //Hygiene.TableDustHard.Click();

                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done Room for " + option + "!");

                }

            
            }

        }
        public static void HygineApproved(string Time)
        {
            MyWorkOrderTasks App = new MyWorkOrderTasks();
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,500);");
            App.MyWorkOrderTask.Click();
            js.ExecuteScript("window.scrollTo(0, 0);");
            Thread.Sleep(1000);
            App.HygieneWorkOrder.Click();
            App.SatrtButton.Click();
            Thread.Sleep(1000);
            App.TopAvistaPlace.Click();
            IList<IWebElement> subelements = App.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
                if (option == 3)
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    js.ExecuteScript("window.scrollTo(0, 0);");
                    App.KoridorTechSoft.Click();
                   
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done Room for " + option + "!");

                }
                else if(option == 4 )
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    App.OmKladerSinkHardWaste.Click();
                    Thread.Sleep(1000);
                    App.OmKladerDustHard.Click();
                    Thread.Sleep(1000);
                    App.OmKladerDustHard.Click();
                    Thread.Sleep(1000);
                    js.ExecuteScript("window.scrollBy(0,500);");
                    App.OmKladerTechHard.Click();
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done Room for " + option + "!");

                 
                }
                else
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    App.OmKladerDustHard.Click();
                    Thread.Sleep(1000);
                    App.OmKladerDustHard.Click();
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done memo text for " + option + "!");
                    Console.WriteLine("Done Room for " + option + "!");



                }
            }
        }
        public static void InstaFlowThrough(string Time)
        {
            MyWorkOrderTasks flow = new MyWorkOrderTasks();
           
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            //OrderRoom.Click();
            js.ExecuteScript("window.scrollTo(0, 0);");
            Thread.Sleep(1000);

            flow.FirstSoftTextBox.Click();
            Thread.Sleep(1000);

            flow.FirstHardTextBox.Click();
            Thread.Sleep(1000);

            flow.DirtSecondHardTextBox.Click();
            Thread.Sleep(1000);
            flow.DustFourthSoftTextBox.Click();
            Thread.Sleep(1000);
            flow.DustFourthSoftTextBox.Click();
            Thread.Sleep(1000);
            flow.DustFourthSoftTextBox.Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,300);");

            flow.SatinsFirstSoftBox.Click();
            Thread.Sleep(1000);
            flow.SatinsFirstSoftBox.Click();
            Thread.Sleep(1000);
            flow.SatinsFirstSoftBox.Click();
            Thread.Sleep(1000);

            flow.SoilingSoftBox.Click();
            Thread.Sleep(1000);
            flow.SoilinghardBox.Click();
            Thread.Sleep(2000);
           
           
            
        }


        public static void  MunicipalityInsta(string Time)
        {
            MyWorkOrderTasks insta = new MyWorkOrderTasks();
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,500);");
            Thread.Sleep(1000);
            insta.MyWorkOrderTask.Click();
            insta.InstaWorkOrder.Click();
           // insta.ContinueTask.Click();
           insta.SatrtButton.Click();
           Thread.Sleep(1000);
            insta.InstaTopavistaPlace.Click();
            IList<IWebElement> subelements = insta.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
                if(option<9)
                {
                    js.ExecuteScript("window.scrollTo(0, 0);");
                    try
                    {

                        OrderRoom.Click();
                        js.ExecuteScript("window.scrollTo(0, 0);");
                        Thread.Sleep(1000);
                        insta.FirstSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.FirstHardTextBox.Click();
                        Thread.Sleep(1000);
                        insta.DustFourthSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.EditButton.Click();
                        insta.TextArea.SendKeys(Time);
                        Thread.Sleep(1000);
                        insta.OkButton.Click();

                        insta.DoneButton.Click();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Done memo text for " + option + "!");
                        Console.WriteLine("Done Room for " + option + "!");

                     

                    }
                    catch (OpenQA.Selenium.StaleElementReferenceException ex)
                    {
                        OrderRoom.Click();
                        js.ExecuteScript("window.scrollTo(0, 0);");
                        Thread.Sleep(1000);
                        insta.FirstSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.FirstHardTextBox.Click();
                        Thread.Sleep(1000);
                        insta.DustFourthSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.EditButton.Click();
                        insta.TextArea.SendKeys(Time);
                        Thread.Sleep(1000);
                        insta.OkButton.Click();

                        insta.DoneButton.Click();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Done memo text for room " + option + "!");
                        Console.WriteLine("Done Room " + option + "!");
                    }
               
                }
                else if (option < 13)
                {
                    js.ExecuteScript("window.scrollBy(0,400);");
                    try
                    {
                        OrderRoom.Click();
                        js.ExecuteScript("window.scrollTo(0, 0);");
                        Thread.Sleep(1000);
                        insta.FirstSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.FirstHardTextBox.Click();
                        Thread.Sleep(1000);
                        insta.DustFourthSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.EditButton.Click();
                        insta.TextArea.SendKeys(Time);
                        Thread.Sleep(1000);
                        insta.OkButton.Click();

                        insta.DoneButton.Click();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Done memo text for " + option + "!");
                        Console.WriteLine("Done Room for " + option + "!");


                    }
                    catch (OpenQA.Selenium.StaleElementReferenceException ex)
                    {
                        OrderRoom.Click();
                        js.ExecuteScript("window.scrollTo(0, 0);");
                        Thread.Sleep(1000);
                        insta.FirstSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.FirstHardTextBox.Click();
                        Thread.Sleep(1000);
                        insta.DustFourthSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.EditButton.Click();
                        insta.TextArea.SendKeys(Time);
                        Thread.Sleep(1000);
                        insta.OkButton.Click();

                        insta.DoneButton.Click();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Done memo text for " + option + "!");
                        Console.WriteLine("Done Room for " + option + "!");

                        //throw;
                    }


                }
            
                
                else
                {
                    js.ExecuteScript("window.scrollBy(0,1000);");
                    try
                    {
                        OrderRoom.Click();
                        js.ExecuteScript("window.scrollTo(0, 0);");
                        Thread.Sleep(1000);
                        insta.FirstSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.FirstHardTextBox.Click();
                        Thread.Sleep(1000);
                        insta.DustFourthSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.EditButton.Click();
                        insta.TextArea.SendKeys(Time);
                        Thread.Sleep(1000);
                        insta.OkButton.Click();

                        insta.DoneButton.Click();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Done memo text for room " + option + "!");
                        Console.WriteLine("Done Room " + option + "!");
                    }
                    catch (OpenQA.Selenium.StaleElementReferenceException ex)
                    {

                        OrderRoom.Click();
                        js.ExecuteScript("window.scrollTo(0, 0);");
                        Thread.Sleep(1000);
                        insta.FirstSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.FirstHardTextBox.Click();
                        Thread.Sleep(1000);
                        insta.DustFourthSoftTextBox.Click();
                        Thread.Sleep(1000);
                        insta.EditButton.Click();
                        insta.TextArea.SendKeys(Time);
                        Thread.Sleep(1000);
                        insta.OkButton.Click();

                        insta.DoneButton.Click();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Done memo text for room " + option + "!");
                        Console.WriteLine("Done Room " + option + "!");
                    }

                }

            }
        }
        
        public static void CommonUseCase(String Time)
        {
            MyWorkOrderTasks common = new MyWorkOrderTasks();
            common.EditButton.Click();
            common.TextArea.SendKeys(Time);
            Thread.Sleep(1000);
            common.OkButton.Click();
            
            common.DoneButton.Click();
            Thread.Sleep(1000);
            //common.YesButton.Click();
           
        }


        public static void  BothAppTestCase()
        {
            MyWorkOrderTasks Diff = new MyWorkOrderTasks();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,600);");
            Diff.MyWorkOrderTask.Click();
            Diff.InstaWorkOrder.Click();
            //Diff.BothRej.Click();
            //Diff.ContinueTask.Click();
            Diff.SatrtButton.Click();
            Thread.Sleep(1000);
            Diff.TopAvistaPlace.Click();
           
                IList<IWebElement> subelements = Diff.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
               /////////////////Both approved//////////////////
                OrderRoom.Click();
                Acts.FlowThrough(Config.MemoText.Time);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Done memo text for room " + option + "!");
                Console.WriteLine("Done Room " + option + "!");
                

            }
            Diff.LogOutButton.Click();
            Thread.Sleep(1000);
            Diff.LogOut.Click();
        }


        public static void  InstaAppHygieneRejTestCase()
        {
            MyWorkOrderTasks Diff = new MyWorkOrderTasks();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,600);");
            Diff.MyWorkOrderTask.Click();
            Diff.InstaWorkOrder.Click();
            //Diff.BothRej.Click();
            //Diff.ContinueTask.Click();
            Diff.SatrtButton.Click();
            Thread.Sleep(1000);
            Diff.TopAvistaPlace.Click();
           
            IList<IWebElement> subelements = Diff.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
              
                /////////////////////InstaAppHygieneRej//////////////
                if(option<5)
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    Diff.SinkSoftFourDiff.Click();
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Done memo text for room " + option + "!");
                    Console.WriteLine("Done Room " + option + "!");
                  
                }
                else
                {
                    OrderRoom.Click();
                    Acts.FlowThrough(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Done memo text for room " + option + "!");
                    Console.WriteLine("Done Room " + option + "!");
                }
                
            }
            Diff.LogOutButton.Click();
            Thread.Sleep(1000);
            Diff.LogOut.Click();
        }

           public static void  InstarejHygieneAppTestCase()
         {
            MyWorkOrderTasks Diff = new MyWorkOrderTasks();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,600);");
            Diff.MyWorkOrderTask.Click();
            Diff.InstaWorkOrder.Click();
            //Diff.BothRej.Click();
            //Diff.ContinueTask.Click();
            Diff.SatrtButton.Click();
            Thread.Sleep(1000);
            Diff.TopAvistaPlace.Click();
           
            IList<IWebElement> subelements = Diff.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
              
                
            
               ///////////////////////////InstaRejHygieneApp/////////////////
                if(option <9)
              {
                  js.ExecuteScript("window.scrollTo(0, 0);");
                  OrderRoom.Click();
                  // Diff.OmKladerSinkHardWaste.Click();
                  // Thread.Sleep(1000);
                  //// Diff.OmKladerDustHard.Click();
                  //// Thread.Sleep(1000);
                  //// Diff.OmKladerDustHard.Click();
                  // //Thread.Sleep(1000);
                  // //Diff.OmKladerTechHard.Click();
                  // Thread.Sleep(1000);
                  Diff.InstaOrHygiene.Click();
                  Thread.Sleep(1000);
                  Acts.InstaFlowThrough(Config.MemoText.Time);
                  Acts.CommonUseCase(Config.MemoText.Time);
                  Console.ForegroundColor = ConsoleColor.DarkCyan;
                  Console.WriteLine("Done memo text for room " + option + "!");
                  Console.WriteLine("Done Room " + option + "!");
                
              }
              else if(option < 14)
              {
                  js.ExecuteScript("window.scrollBy(0,400);");
                  OrderRoom.Click();
                  // Diff.OmKladerSinkHardWaste.Click();
                  // Thread.Sleep(1000);
                  //// Diff.OmKladerDustHard.Click();
                  //// Thread.Sleep(1000);
                  //// Diff.OmKladerDustHard.Click();
                  // //Thread.Sleep(1000);
                  // //Diff.OmKladerTechHard.Click();
                  // Thread.Sleep(1000);
                  Diff.InstaOrHygiene.Click();
                  Thread.Sleep(1000);
                  Acts.InstaFlowThrough(Config.MemoText.Time);
                  Acts.CommonUseCase(Config.MemoText.Time);
                  Console.ForegroundColor = ConsoleColor.DarkCyan;
                  Console.WriteLine("Done memo text for room " + option + "!");
                 Console.WriteLine("Done Room " + option + "!");

              }
              else
              {
                  js.ExecuteScript("window.scrollBy(0,900);");
                  OrderRoom.Click();
                  // Diff.OmKladerSinkHardWaste.Click();
                  // Thread.Sleep(1000);
                  //// Diff.OmKladerDustHard.Click();
                  //// Thread.Sleep(1000);
                  //// Diff.OmKladerDustHard.Click();
                  // //Thread.Sleep(1000);
                  // //Diff.OmKladerTechHard.Click();
                  // Thread.Sleep(1000);
                  Diff.InstaOrHygiene.Click();
                  Thread.Sleep(1000);
                  Acts.InstaFlowThrough(Config.MemoText.Time);
                  Acts.CommonUseCase(Config.MemoText.Time);
                       Console.ForegroundColor = ConsoleColor.DarkCyan;
                       Console.WriteLine("Done memo text for room " + option + "!");
                       Console.WriteLine("Done Room " + option + "!");
              }
               
           }
            Diff.LogOutButton.Click();
            Thread.Sleep(1000);
            Diff.LogOut.Click();
                
        }

                 
             
                //////////////////////////////////BothRejected//////////////////////////
              
       public static void  BothRejTestCase()
        {
            MyWorkOrderTasks Diff = new MyWorkOrderTasks();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,600);");
            Diff.MyWorkOrderTask.Click();
            Diff.InstaWorkOrder.Click();
            //Diff.BothRej.Click();
            //Diff.ContinueTask.Click();
            Diff.SatrtButton.Click();
            Thread.Sleep(1000);
            Diff.TopAvistaPlace.Click();
           
                IList<IWebElement> subelements = Diff.OrderListContainer.FindElements(By.ClassName("room-item"));
            for (int option = 3; option < subelements.Count + 3; option++)
            {
                OrderRoom = Driver.driver.FindElement(By.CssSelector("#avista-global-container > div > div > div:nth-child(" + option + ")"));
             
                //OrderRoom.Click();
                //Acts.FlowThrough(Config.MemoText.Time);
                   
                 if(option<5)
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    Diff.SinkSoftFourDiff.Click();
                    Thread.Sleep(1000);
                    Diff.InstaOrHygiene.Click();
                    Thread.Sleep(1000);
                    Acts.InstaFlowThrough(Config.MemoText.Time);
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Done memo text for room " + option + "!");
                    Console.WriteLine("Done Room " + option + "!");

                }
                else
                {
                    OrderRoom.Click();
                    Thread.Sleep(1000);
                    Diff.InstaOrHygiene.Click();
                    Thread.Sleep(1000);
                    Acts.InstaFlowThrough(Config.MemoText.Time);
                    Acts.CommonUseCase(Config.MemoText.Time);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Done memo text for room " + option + "!");
                    Console.WriteLine("Done Room " + option + "!");
                    
                }
            }
            Diff.LogOutButton.Click();
            Thread.Sleep(1000);
            Diff.LogOut.Click();
        }
         

    }
}
