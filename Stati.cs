
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace InstaAndHygiene
{
    public class Stati
    {
        public Stati()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.statistics > div > span.text")]
        public IWebElement StatisticMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.menu-item.stat_activities > div")]
        public IWebElement Activity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.settings-panel > div.settings-menu-button.button-menu > span")]
        public IWebElement ActivityMenu { get; set; }

        [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.settings-panel > div.settings-menu-list.show > div:nth-child(1) > div > select")]
        public IWebElement DayDropDown { get; set; }
    }
}
