

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

       /////////////////////////////////////OWN Quality Method for Hospital Customer //////////////////////////////////////
       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div:nth-child(6) > div > span")]
       public IWebElement HPTLOwnqualityMethod { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(2) > div:nth-child(2) > div > div.p-num")]
       public IWebElement PatientPlatsValue { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-num")]
       public IWebElement AvskarmingsValue { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(5) > div:nth-child(2) > div > div.p-num")]
       public IWebElement SanitarInredningValue { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(6) > div:nth-child(2) > div > div.p-num")]
       public IWebElement GreppValue { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(9) > div:nth-child(2) > div > div.p-num")]
       public IWebElement OtherTeknicalValue { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(2) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement PatientComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(2) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(4)")]
       public IWebElement ChooseFourthComment { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement AvskarmingComment { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(2)")]
       public IWebElement ChooseSecondComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(5) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement SanitarComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(5) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(4)")]
       public IWebElement SanitarChooseFourthComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(7) > div:nth-child(2) > div > div.p-text > input")]
       public IWebElement BordSendComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(6) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement GreppCommnet { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(3) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement TvattComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(3) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(3)")]
       public IWebElement ChooseThirdComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(8) > div:nth-child(2) > div > div.p-text > input")]
       public IWebElement TenicheInstallationSendComment { get; set; }

       ////////////////////////////////////////Own QualityMethod For Municipality Customer////////////////////

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div:nth-child(3)")]
       public IWebElement SelectSecondCustomer { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div:nth-child(1) > div > span.text")]
       public IWebElement MTopAvistaplace { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div:nth-child(1)")]
       public IWebElement MFirstChild { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div.place-item-list.expanded > div:nth-child(1) > div.place-title")]
       public IWebElement MFirstFirstChild { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div:nth-child(5) > div > span")]
       public IWebElement MunipalityQualityMethod { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.content")]
       public IWebElement RoomTypeContainer { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(3) > div:nth-child(2) > div > div.p-num")]
       public IWebElement FirstCeiling { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-num")]
       public IWebElement FirstWall { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(5) > div:nth-child(2) > div > div.p-num")]
       public IWebElement FirstFloor { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(8) > div:nth-child(2) > div > div.p-num")]
       public IWebElement FirstMats { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(3) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement BesokCelingComment { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(3) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(2)")]
       public IWebElement ChooseFirstComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(10) > div:nth-child(2) > div > div.p-num")]
       public IWebElement SecondCeilling { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(11) > div:nth-child(2) > div > div.p-num")]
       public IWebElement SecondWall { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(12) > div:nth-child(2) > div > div.p-num")]
       public IWebElement SecondFloor { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(14) > div:nth-child(2) > div > div.p-num")]
       public IWebElement SecondWindows { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement BesokWallComment { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(4)")]
       public IWebElement BesokChooseThirdComment { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(6) > div:nth-child(2) > div > div.p-text > input")]
       public IWebElement FirstDoors { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(16) > div:nth-child(2) > div > div.p-num")]
       public IWebElement ThirdFloor { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(18) > div:nth-child(2) > div > div.p-num")]
       public IWebElement ThirdFurniture { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(19) > div:nth-child(2) > div > div.p-num")]
       public IWebElement ThirdMats { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(10) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement ArkivCeilingComment { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(10) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(3)")]
       public IWebElement Arkivchoosefirstcommnet { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(3) > div:nth-child(2) > div > div.p-messages > select > option:nth-child(4)")]
       public IWebElement ArkivChooseThirdComment { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(12) > div:nth-child(2) > div > div.p-messages > select")]
       public IWebElement ArkivFloorComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(18) > div:nth-child(2) > div > div.p-text > input")]
       public IWebElement ThirdFurnitureSendComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.bottom-panel > div.button-save.box")]
       public IWebElement OwnQualitysaveButton { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div.organization-item-list.ap-tree-root.expanded > div.place-item")]
       public IWebElement NewRoomInspection { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div.container > div > div")]
       public IWebElement TestQualityMethod { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.content > div:nth-child(1)")]
       public IWebElement RoomTypeOne { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(2) > div:nth-child(2) > div > div.p-num")]
       public IWebElement OfficeCelling { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(3) > div:nth-child(2) > div > div.p-num")]
       public IWebElement OfficeWalls { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-num")]
       public IWebElement OfficeFixtures { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(5) > div:nth-child(2) > div > div.p-num")]
       public IWebElement OfficeFloor { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#avista-global-container > div > div > div.inspection-container > div > div:nth-child(2) > div:nth-child(2) > div > div.p-text > input")]
       public IWebElement OfficeCellingComment { get; set; }

       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.inspection-container > div > div:nth-child(4) > div:nth-child(2) > div > div.p-text > input")]
       public IWebElement OfficeFixturesComment { get; set; }
       
       [FindsBy(How=How.CssSelector,Using="#avista-global-container > div > div > div.content > div:nth-child(2)")]
       public IWebElement RoomTypeTwo { get; set; }
    }

}
