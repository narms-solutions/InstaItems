
using System;
namespace InstaAndHygiene
{
   public class Config
    {
       public static string BaseURL = "https://a5.avistatime.com/mobile/";
       public static string WebURL = "https://a5.avistatime.com/login.php";

       public static class HospitalCredentials
       {
           public static string MobileNumber = "0705587800";
           public static string UserCare = "casea@h.se";
           public static string PassWord = "12340";
       }
       public static class MemoText
       {
           public static string Time = DateTime.Now.ToString();

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
    }
}
