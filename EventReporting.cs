

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace InstaAndHygiene
{
   public class EventReporting
    {
       public EventReporting()
       {
           PageFactory.InitElements(Driver.driver, this);
       }
       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.start-event-reporting > div > span.text")]
       public IWebElement MobileEventReporting { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item > div > span.text")]
       public IWebElement Subscriber { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div:nth-child(1) > div")]
       public IWebElement FirstCustomer { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-parent > div > span.text")]
       public IWebElement FirstAvistaPlace { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div.place-item-parent > div > span.text")]
       public IWebElement AvistaRoom { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div:nth-child(1) > div.place-title")]
       public IWebElement Room1 { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div:nth-child(3) > div > span.indicator")]
       public IWebElement LarmActivity { get; set; }   

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.activity-item-list.expanded > div > div > div:nth-child(2) > div > textarea")]
       public IWebElement MemoText { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.bottom-panel > div.button-send > span")]
       public IWebElement SaveButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.bottom-panel > div.button-back.box > span > span")]
       public IWebElement BackButton { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.setting-button > span > span")]
       public IWebElement MainSetting { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.params > div:nth-child(1) > div:nth-child(2) > input")]
       public IWebElement ClearServerLink { get; set; }        

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-back.box")]
       public IWebElement SettingsBackButton { get; set; }
    }
}
