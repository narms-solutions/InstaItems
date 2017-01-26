
using OpenQA.Selenium;
using System;
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
       public static void OwnQualityMethod(string Comment)
       {
          
           StartUnplannedTasks plan = new StartUnplannedTasks();
           Thread.Sleep(1000);
           plan.StartUnPlannedOrder.Click();
           Thread.Sleep(1000);
           plan.StartandEndButton.Click();
           Thread.Sleep(1000);
           plan.Subscriber.Click();
           Thread.Sleep(1000);
           plan.NewRoomInspection.Click();
           Thread.Sleep(1000);
           plan.TestQualityMethod.Click();
           Thread.Sleep(1000);
           Actss.RoomInspectionCommonUse(Config.MemoText.comment);

           plan.OwnQualitysaveButton.Click();
       }
       public static void RoomInspectionCommonUse(string Comment)
       {
           StartUnplannedTasks plan = new StartUnplannedTasks();
           Thread.Sleep(1000);
           plan.RoomTypeOne.Click();
           Thread.Sleep(1000);
           plan.OfficeCelling.Click();
           Thread.Sleep(1000);
           plan.OfficeCelling.Click();
           Thread.Sleep(1000);
           plan.OfficeCellingComment.SendKeys(Comment);
           Thread.Sleep(1000);
           plan.OfficeWalls.Click();
           Thread.Sleep(1000);
           plan.OfficeFixtures.Click();
           Thread.Sleep(1000);
           plan.OfficeFixturesComment.SendKeys(Comment);
           Thread.Sleep(1000);
           plan.OfficeFloor.Click();
           Thread.Sleep(1000);
           Actss.UseCase(Config.MemoText.Time);

           plan.RoomTypeOne.Click();
           Thread.Sleep(1000);
           //plan.OfficeCelling.Click();
           //Thread.Sleep(1000);
           plan.OfficeCellingComment.SendKeys(Comment);
           Thread.Sleep(1000);
           plan.OfficeWalls.Click();
           Thread.Sleep(1000);
           plan.OfficeFixtures.Click();
           plan.OfficeFixtures.Click();
           Thread.Sleep(1000);
           plan.OfficeFixturesComment.SendKeys(Comment);
           Thread.Sleep(1000);
           plan.OfficeFloor.Click();
           Thread.Sleep(1000);
           Actss.UseCase(Config.MemoText.Time);

           plan.RoomTypeTwo.Click();
           Thread.Sleep(1000);
           //plan.OfficeCelling.Click();
           //Thread.Sleep(1000);
           plan.OfficeCellingComment.SendKeys(Comment);
           Thread.Sleep(1000);
           plan.OfficeWalls.Click();
           Thread.Sleep(1000);
           plan.OfficeFixtures.Click();
           Thread.Sleep(1000);
           plan.OfficeFloor.Click();
           Thread.Sleep(1000);
           Actss.UseCase(Config.MemoText.Time);

           plan.RoomTypeTwo.Click();
           Thread.Sleep(1000);
           plan.OfficeCelling.Click();
           plan.OfficeCelling.Click();
           plan.OfficeCellingComment.SendKeys(Comment);
           Thread.Sleep(1000);
           plan.OfficeWalls.Click();
           Thread.Sleep(1000);
           plan.OfficeFixtures.Click();
           Thread.Sleep(1000);
           plan.OfficeFixturesComment.SendKeys(Comment);
           Thread.Sleep(1000);
           plan.OfficeFloor.Click();
           plan.OfficeFloor.Click();
           Thread.Sleep(1000);
           Actss.UseCase(Config.MemoText.Time);


          
       }
       public static void UseCase(string Time)
       {
           MyWorkOrderTasks common = new MyWorkOrderTasks();
           common.EditButton.Click();
           Thread.Sleep(1000);
           common.TextArea.SendKeys(Time);
           Thread.Sleep(1000);
           common.OkButton.Click();
           Thread.Sleep(1000);
           common.DoneButton.Click();
           Thread.Sleep(1000);
           
       }
       public static void WorkOrderRoomOwnQuality()
       {
           MyWorkOrderTasks own = new MyWorkOrderTasks();
           Thread.Sleep(1000);
           IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
           //Thread.Sleep(1000);
           //js.ExecuteScript("window.scrollBy(0,500);");
           //Thread.Sleep(1000);
           //own.MyWorkOrderTask.Click();
           //Thread.Sleep(1000);
           //js.ExecuteScript("window.scrollTo(0,0);");
           //Thread.Sleep(1000);
           //own.WorkOrderRoomInspection.Click();
           //Thread.Sleep(1000);
           //own.SatrtButton.Click();
           //Thread.Sleep(3000);
           //own.WorkOrderActivity.Click();
           Thread.Sleep(1000);
           js.ExecuteScript("window.scrollBy(0,500);");
           Thread.Sleep(1000);
           own.MyWorkOrderTask.Click();
           Thread.Sleep(1000);
           own.OngoingInspection.Click();
           Thread.Sleep(1000);
           own.EndButton.Click();
           Thread.Sleep(1000);
           own.WorkOrderActivity.Click();
           Thread.Sleep(1000);
           Actss.RoomInspectionCommonUse(Config.MemoText.comment);
           StartUnplannedTasks method1 = new StartUnplannedTasks();
           Thread.Sleep(1000);
           method1.SaveButton.Click();
           //own.LogOutButton.Click();
           //Thread.Sleep(1000);
           //own.LogOut.Click();
       }
       public static  void WorkOrderUnitOwnQuality(string Comment)
       {
           MyWorkOrderTasks unit = new MyWorkOrderTasks();
           StartUnplannedTasks method = new StartUnplannedTasks();
           Thread.Sleep(1000);
           IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
           Thread.Sleep(1000);
           js.ExecuteScript("window.scrollBy(0,500);");
           Thread.Sleep(1000);
           unit.MyWorkOrderTask.Click();
           Thread.Sleep(1000);
           js.ExecuteScript("window.scrollTo(0,0);");
           Thread.Sleep(1000);
           unit.WorkOrderUnitInspection.Click();
           Thread.Sleep(1000);
           unit.SatrtButton.Click();
           Thread.Sleep(3000);
           unit.WorkOrderActivity.Click();
           Thread.Sleep(1000);
           js.ExecuteScript("window.scrollBy(0,500);");
           Thread.Sleep(1000);
           unit.MyWorkOrderTask.Click();
           Thread.Sleep(1000);
           unit.OngoingInspection.Click();
           Thread.Sleep(1000);
           unit.EndButton.Click();
           Thread.Sleep(1000);
           unit.WorkOrderActivity.Click();
           Thread.Sleep(1000);
           Acts.HptlOwnQualityCommonUse(Config.MemoText.comment);
           Thread.Sleep(1000);
           
       }
    }
}
