using OpenQA.Selenium;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace IntegrationTests.WebApp1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver? _webdriver;
        private const string BaseUrl = "https://localhost:5001/";

        [TestInitialize]
        public void Setup()
        {
            // Setup
            var config = new EdgeConfig();
            var webConfig = new EdgeOptions();

            var emu = new ChromiumMobileEmulationDeviceSettings("Testing");
            emu.Width = 1024;
            emu.Height = 600;
            emu.PixelRatio = 2.0;

            webConfig.EnableMobileEmulation(emu);
            webConfig.AcceptInsecureCertificates = true;

            new DriverManager().SetUpDriver(config);
            _webdriver = new EdgeDriver(webConfig);
        }

        [TestMethod]
        public void EnsureHomePageHasHomeInTheTitle()
        {
            _webdriver?.Navigate().GoToUrl(BaseUrl);
            Assert.IsTrue(_webdriver?.Title.Contains("Home"));
        }

        //[TestMethod]
        //public void TestGoogleSearch()
        //{
            
        //    _webdriver?.Navigate().GoToUrl(BaseUrl);
        //    // Assert.IsTrue(_webdriver.Title.Contains("Google"));

        //    var txtarea = _webdriver?.FindElement(By.Id("APjFqb"));
        //    var btn = _webdriver?.FindElement(By.CssSelector("input.gNO89b"));

        //    txtarea?.SendKeys("Hello");

        //    btn?.Click();

        //    Assert.IsTrue(_webdriver?.Title.Contains("Hello"));
        //}

        [TestCleanup]
        public void Teardown()
        {
            // Tear down
            _webdriver?.Quit();
        }
    }
}