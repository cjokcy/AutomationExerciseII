using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AutomationExerciseII.Drivers
{


    public class DriverHelper
    {
        public IWebDriver Driver { get; } = new ChromeDriver();

        public void Close() => Driver?.Close();
        public void Quit() => Driver?.Quit();

        }
    }

