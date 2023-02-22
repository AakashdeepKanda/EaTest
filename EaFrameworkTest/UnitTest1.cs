using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace EaFrameworkTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          ///  new DriverManager().SetUpDriver(new ChromeConfig());
            var driver = new ChromeDriver();
        ///    var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("htp://localhost:8000/");
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
        }
    }
}