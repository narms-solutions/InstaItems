
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace InstaAndHygiene
{
   public class Attendance
    {
       public Attendance()
       {
           PageFactory.InitElements(Driver.driver, this);
       }
       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.start-attendance > div > span.text")]
       public IWebElement MobileAttendance { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.main-content > div.left-panel > div.group-list.section.absent.show")]
       public IWebElement AttendanceContainer { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.bottom-panel > div > span > span")]
       public IWebElement BackButton { get; set; }
    }
}
