using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationExerciseII.Page
{
    public class LoginPage : CustomControl
    {
        private readonly IWebDriver Driver;
        private readonly WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        #region
        public IWebElement WaitUntilElementIsClickable(IWebElement locator)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
        #endregion

        #region Locators
        IWebElement TxtUserName => Driver.FindElement(By.CssSelector("input[data-qa='login-email']"));
        IWebElement TxtPassword => Driver.FindElement(By.CssSelector("input[data-qa='login-password']"));
        IWebElement AccountLoginMessage => Driver.FindElement(By.CssSelector("div.login-form h2"));
        IWebElement BtnLogin => Driver.FindElement(By.CssSelector("button[data-qa='login-button"));

        #endregion

        #region Actions
        public void EnterUserNameAndPassword(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(password);
        }

        public bool IsLoginToYourAccountMessageDisplayed()
        {
            try
            {
                return AccountLoginMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }

        public void ClickLogin()
        {
            BtnLogin.Click();
        }
        #endregion
    }
}