using AutomationExerciseII.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace AutomationExerciseII.Page
{
    public class SignUpPage : CustomControl
    {
        private readonly IWebDriver Driver;
        private WebDriverWait wait;

        public SignUpPage(IWebDriver driver)
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
        IWebElement Consent => Driver.FindElement(By.CssSelector(".fc-button.fc-cta-consent.fc-primary-button"));
        IWebElement SignUpLoginLink => Driver.FindElement(By.LinkText("Signup / Login"));
        IWebElement Home => Driver.FindElement(By.LinkText("Home"));
        IWebElement NewUserSignUpMessage => Driver.FindElement(By.CssSelector("input[data-qa='signup-name']"));
        IWebElement NameField => Driver.FindElement(By.CssSelector("input[data-qa='signup-name']"));
        IWebElement EmailField => Driver.FindElement(By.CssSelector("input[data-qa='signup-email']"));
        IWebElement SignUpButton => Driver.FindElement(By.CssSelector("[data-qa='signup-button']"));

        //Account Info Elements
        IWebElement AccountInformation => Driver.FindElement(By.CssSelector(".title.text-center")); 
        IWebElement TitleCheckBox => Driver.FindElement(By.Id("id_gender1"));
        IWebElement DayField => Driver.FindElement(By.Id("days"));
        IWebElement MonthField => Driver.FindElement(By.Id("months"));
        IWebElement YearField => Driver.FindElement(By.Id("years"));
        IWebElement NewslettersYes => Driver.FindElement(By.Id("newsletter"));
        IWebElement OffersYes => Driver.FindElement(By.CssSelector("input[name='optin']"));
        IWebElement FNField => Driver.FindElement(By.Id("first_name"));
        IWebElement LNField => Driver.FindElement(By.Id("last_name"));
        IWebElement CompanyField => Driver.FindElement(By.Id("company"));
        IWebElement Address1Field => Driver.FindElement(By.Id("address1"));
        IWebElement Address2Field    => Driver.FindElement(By.Id("address2"));
        IWebElement CountryField => Driver.FindElement(By.Id("country"));
        IWebElement StateField => Driver.FindElement(By.Id("state"));
        IWebElement CityField  => Driver.FindElement(By.Id("city")); 
        IWebElement ZipCodeField => Driver.FindElement(By.Id("zipcode"));
        IWebElement MobileField => Driver.FindElement(By.Id("mobile_number"));
        IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        IWebElement CreateAccountBtn => Driver.FindElement(By.CssSelector("button[data-qa='create-account']"));
        IWebElement AccountIsCreatedMessage => Driver.FindElement(By.CssSelector("h2[data-qa='account-created']"));
        IWebElement ContinueBtn => Driver.FindElement(By.CssSelector("a[data-qa='continue-button']"));
        IWebElement LoggedIn => Driver.FindElement(By.CssSelector("a i.fa-user"));
        IWebElement AccountDeletedBtn => Driver.FindElement(By.CssSelector("a[href='/delete_account']"));
        IWebElement AccountDeletedMessage => Driver.FindElement(By.CssSelector("h2[data-qa='account-deleted']"));
        IWebElement AccountExistMessage => Driver.FindElement(By.CssSelector("p[style='color: red;']"));

        #endregion

        #region Actions
        public void AcceptConsent()
        {
            WaitUntilElementIsClickable(Consent).Click();
        }

        public bool HomePageIsVisible()
        {
            try
            {
                WaitUntilElementIsClickable(Home);
                return Home.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }

        public bool NewUserSignupIsVisible()
        {
            try
            {
                WaitUntilElementIsClickable(NewUserSignUpMessage);
                return NewUserSignUpMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }
        public void ClickSignUpButton() 
        {
            SignUpLoginLink.Click();
        }

        public void EnterSignUpDetails(string name, string email)
        {
            WaitUntilElementIsClickable(SignUpButton).Click();
            NameField.SendKeys(name);
            EmailField.SendKeys(email);
        }

        public void ClickSignUpButtonForNewUser()
        {
            SignUpButton.Click();
        }


        public bool IsAccountInformationMessageDisplayed()
        {
            try
            {
                return AccountInformation.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }



        //Enter Account Information - Sign Up
        public void EnterRegistrationDetails(string fn, string ln, string company, string add1, string add2,
            string country, string state, string city, string zip, string phone, string pass, string dob)
        {
            TitleCheckBox.Click();
            PasswordField.SendKeys(pass);
            EnterDOB(dob);
            NewslettersYes.Click();
            OffersYes.Click();
            FNField.SendKeys(fn);
            //EnterText(FNField, fn);
            LNField.SendKeys(ln);
            CompanyField.SendKeys(company);
            Address1Field.SendKeys(add1);
            Address2Field.SendKeys(add2);
            CountryField.SendKeys(country);
            StateField.SendKeys(state);
            CityField.SendKeys(city);
            ZipCodeField.SendKeys(zip);
            MobileField.SendKeys(phone);      
        }

        public void EnterDOB(string dob)
        {
            // Split the DOB string into day, month, and year
            var dobParts = dob.Split(',');

            // Ensure the DOB format is correct (it should result in exactly 3 parts)
            if (dobParts.Length != 3)
            {
                throw new ArgumentException("Invalid DOB format. Ensure the format is DD, MM, YYYY.");
            }

            // Locate and enter the day, month, and year fields
            DayField.SendKeys(dobParts[0].Trim());  // Day
            MonthField.SendKeys(dobParts[1].Trim());  // Month
            YearField.SendKeys(dobParts[2].Trim());  // Year
        }

        public void ClickCreateAccount()
        {
            CreateAccountBtn.Click();
        }

        public bool IsAccountCreatedMessageDisplayed()
        {
            try
            {
                return AccountIsCreatedMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }
        public void ClickContinue()
        {
            ContinueBtn.Click();   
        }
        public bool IsLoggedInUserDisplayed()
        {
            try
            {
                WaitUntilElementIsClickable(LoggedIn);
                return LoggedIn.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }

        public void DeleteAccount()
        {
            AccountDeletedBtn.Click();
        }
        public bool IsAccountDeletedMessageDisplayed()
        {

            try
            {
                WaitUntilElementIsClickable(AccountDeletedMessage);
                return AccountDeletedMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }

        public bool IsEmailAlreadyExistMessageDisplayed()
        {
            try
            {
                WaitUntilElementIsClickable(AccountExistMessage);
                return AccountExistMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }
        #endregion

    }
}
