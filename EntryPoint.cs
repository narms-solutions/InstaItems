

using System.Threading;
namespace InstaAndHygiene
{
    public class EntryPoint
    {
        static void Main()
        {
            //Acts.InitializeDriver();
            //Thread.Sleep(1000);
            //Acts.LoginCredentials(Config.HospitalCredentials.MobileNumber, Config.HospitalCredentials.UserCare, Config.HospitalCredentials.PassWord);
            ////Thread.Sleep(3000);
            //Actions.Attendance();
            //Actions.EventReport(Config.MemoText.Time);
            //Actions.StartUnplannedTask();
           // Acts.MyWorkOrderTask(Config.MemoText.Time);
            //Acts.SevenRoomWorkOrder(Config.MemoText.Time);
            //Acts.FirstInspection(Config.MemoText.Time);


            WebActions.InitializeWebDriver();
            Thread.Sleep(1000);
            WebActions.WebloginCredentials(Config.WebLoginCredentials.WebUserCare, Config.WebLoginCredentials.WebPassWord);
            WebActions.MenuSelection();
            
        }
    }
}
