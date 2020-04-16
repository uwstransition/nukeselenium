using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SampleSelenium
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(@"https://google.com");
            }
            Assert.Pass();
        }
    }
}