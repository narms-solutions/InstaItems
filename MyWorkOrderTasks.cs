
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace InstaAndHygiene
{
   public class MyWorkOrderTasks
    {
       public MyWorkOrderTasks()
       {
           PageFactory.InitElements(Driver.driver, this);
       }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div.avista-main-content.main-menu > div > div.menu-item.my-order-deliveries > div > span.text")]
       public IWebElement MyWorkOrderTask { get; set; }

       

       /// <summary>
       /// ///////////////////////////////MyWorkOrders ///////////////////////
       /// </summary>
       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(1) > div.order-text")]
       public IWebElement ThreeRoomEveryDaySingle { get; set; }  //SingleSmapling

       //[FindsBy(How = How.CssSelector, Using = " #avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(2) > div.order-text")]
       //public IWebElement EveryDayStratified { get; set; }   //Stratified

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(1)")]
       public IWebElement EveryDayStratified { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(5) > div.order-text")]
       public IWebElement Double { get; set; }    //Double

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(6) > div.order-text")]
       public IWebElement Customised { get; set; }   //Customised

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(9) > div.order-text")]
       public IWebElement Merge { get; set; }


       /// <summary>
       /// //////////////////////////// Tree -Item-Name  ...parent avista palce (Floor)///////////
       /// 
       /// </summary>
       /// 


       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.locale-tree-item.empty > div.tree-item-name")]
       public IWebElement TopAvistaPlace { get; set; }



       ///////////////////////////////////// OrderList Container /////////////////////////////////////

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div")]
       public IWebElement OrderListContainer { get; set; }

      
       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(3) > div.order-text")]
       //public IWebElement ThreeTestRoomOrder { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(2) > div.order-text")]
       //public IWebElement ThreeTestRoomOrder { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-start")]
       public IWebElement SatrtButton { get; set; }

       //[FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.locale-tree-item.empty")]
       //public IWebElement FirstFloor { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div:nth-child(3)")]
       //public IWebElement FirstRoom { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-switch.box > span")]
       public IWebElement InstaOrHygiene { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(2) > div.val.type-a > span")]
       public IWebElement FirstSoftTextBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(2) > div.val.type-na > span")]
       public IWebElement FirstHardTextBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(1) > div.val.type-na > span")]
       public IWebElement DirtSecondHardTextBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div > div:nth-child(1) > div.val.type-na > span")]
       public IWebElement DustSecondHardTextBox { get; set; }


       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div > div:nth-child(3) > div.val.type-a > span")]
       public IWebElement DustThirdSoftTextBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div > div:nth-child(3) > div.val.type-a > span")]
       public IWebElement DustFourthSoftTextBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div > div:nth-child(3) > div.val.type-na > span")]
       public IWebElement DustFourthHArdTextBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(3) > div.val.type-a > span")]
       public IWebElement SatinsFirstSoftBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(3) > div.val.type-na > span")]
       public IWebElement SatinsFirstHardBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(4) > div.val.type-a > span")]
       public IWebElement StainsSecondSoftBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div > div:nth-child(4) > div.val.type-na > span")]
       public IWebElement StainsSecondHardBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(2) > div:nth-child(2) > div:nth-child(3) > div > div:nth-child(2) > div.val.type-a > span")]
       public IWebElement SoilingSoftBox { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div:nth-child(2) > div:nth-child(2) > div:nth-child(3) > div > div:nth-child(2) > div.val.type-na > span")]
       public IWebElement SoilinghardBox { get; set; }


       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-note.box > span > span")]
       public IWebElement EditButton { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-input-popup > div > div.input-field > textarea")]
       public IWebElement TextArea { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-input-popup > div > div.buttons-field > div.button.ok > span > span")]
       public IWebElement OkButton { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-done > span")]
       public IWebElement DoneButton { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div.avista-view-message > div > div.button-container > div.button.yes")]
       public IWebElement YesButton { get; set; }
       //second room
       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.bottom-panel > div.button-continue > span")]
       public IWebElement ContinueTask { get; set; }
       //ThirdRoom
       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div:nth-child(5) > div.top-line")]
       public IWebElement ThirdRoom { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div:nth-child(4) > div.top-line")]
       public IWebElement SecondRoom { get; set; }

       ////////////////////////SvenRoomWorkOrders////////////////////////////////

       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(1) > div.order-text > span")]
       //public IWebElement FourRoomOrder { get; set; }


       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(1) > div.order-text")]
       //public IWebElement ThreeRoomEveryDay { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(2) > div.order-text")]
       //public IWebElement Double { get; set; }


       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.order-list-container > div.order-group-list1 > div:nth-child(1) > div.order-text")]
       //public IWebElement TestRoom { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.locale-tree-item.empty > div.tree-item-name")]
       //public IWebElement SventeenRoomOrder { get; set; }

       //[FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div:nth-child(3)")]
       //public IWebElement Room1 { get; set; }







    }
}
