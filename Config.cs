
using System;
namespace InstaAndHygiene
{
   public class Config
    {
       //public static string BaseURL = "https://a5.avistatime.com/mobile/";
       //public static string BaseURL = "https://a5test.avistatime.com/mobile/";
       public static string BaseURL = "https://a5stage.avistatime.com/mobile/";
       //public static string WebURL = "https://a5.avistatime.com/login.php";
       public static string WebURL = "https://a5stage.avistatime.com/login.php";
       public static string SubscriberURL = "https://a5.avistatime.com/index.php#reports_insta_hygiene";
       //public static string DashBoardURL = "https://a5.avistatime.com/index.php#dashboard";
       public static string DashBoardURL = "https://a5stage.avistatime.com/index.php#dashboard";

       public static class HospitalCredentials
       {
           public static string MobileNumber = "0705587800";
           public static string UserCare = "casea@h.se";
           public static string PassWord = "12340";
       }
       public static class HygieneCredentials
       {
           public static string MobileNumber = "0705587800";
           public static string UserCare = "casea1@h.se";
           public static string PassWord = "12340";
       }
       public static class MuicipalityCredentials
       {
           public static string MobileNumber = "0705587800";
           public static string UserCare = "municipality@a.se";
           public static string PassWord = "12340";
       }
       public static class FourSingleSampCredentials
       {
           public static string MobileNumber = "0705587800";
           public static string UserCare = "casea2@h.se";
           public static string PassWord = "12340";
       }
       public static class WorkOrderOwnQualityCredentials
       {
           public static string MobileNumber = "0705587800";
           public static string UserCare = "own@quality.se";
           public static string PassWord = "12340";
       }
       public static class MemoText
       {
           public static string Time = DateTime.Now.ToString();
           public static string comment = "Good result!";
       }
      public static class SveenteenRoomUrl
      {
          public static string option = "1";
      }
       public static class WebLoginCredentials
       {
           public static string WebUserCare = "narmada@a.com";
           public static string WebPassWord = "12340";
       }
       public static class serverlink
       {
           public static string ServerLink = "https://a5stage.avistatime.com/";
       }
    }
}
