

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace InstaAndHygiene
{
   public class StartUnplannedTasks
    {
       public StartUnplannedTasks()
       {
           PageFactory.InitElements(Driver.driver, this);
       }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.start-without-order > div > span.text")]
       public IWebElement StartUnPlannedOrder { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-view-confirm-popup.three-button > div.button.start_end")]
       public IWebElement StartandEndButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item > div > span.text")]
       public IWebElement Subscriber { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div:nth-child(1) > div")]
       public IWebElement FirstCustomer { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-parent > div > span.text")]
       public IWebElement FirstAvistaPlace { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div.place-item-parent > div > span.text")]
       public IWebElement AvistaRoom { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div:nth-child(1) > div.place-title")]
       public IWebElement Room1 { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div:nth-child(1) > div > span.indicator")]
       public IWebElement WallActivity { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.bottom-panel > div.button-send > span")]
       public IWebElement SaveButton { get; set; }


    }
}
