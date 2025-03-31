using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics;


namespace AutomationExerciseII.Page
{
    class HomePage
    {
        private IWebDriver Driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        #region Wait
        public IWebElement WaitUntilElementIsClickable(IWebElement locator)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
        #endregion

        #region Locators

        private IWebElement Product => Driver.FindElement(By.LinkText("Add to cart"));
        private IWebElement ProductOverlay => Driver.FindElement(By.CssSelector(".col-sm-4:nth-child(3) .product-overlay .btn"));
        private IWebElement Modal => Driver.FindElement(By.CssSelector(".close-modal"));
        private IWebElement ViewCartButton => Driver.FindElement(By.LinkText("Cart"));
        private IWebElement ProductPrice => Driver.FindElement(By.XPath("//p[text()='Rs. 500']"));
        private IWebElement ProductQuantity => Driver.FindElement(By.CssSelector("td.cart_quantity button.disabled"));
        private IWebElement TotalPrice => Driver.FindElement(By.XPath("//p[@class='cart_total_price'][text()='Rs. 1000']"));

        #endregion

        #region Actions
        public void ClickToViewTheCart()
        {
            WaitUntilElementIsClickable(ViewCartButton);
            ViewCartButton.Click();
        }


        public void AddProductToCart()
        {
            try
            {
                IWebElement elementToScrollTo = ProductOverlay;

                // Scroll the page to the element using JavaScript
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elementToScrollTo);

                // Product Hover
                Actions actions = new(Driver);
                actions.MoveToElement(Product).Build().Perform();

                // Click "Add to cart" button;
                ProductOverlay.Click();

                //Close Modal
                WaitUntilElementIsClickable(Modal).Click();
        
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine($"Product not found!");
            }
        }


        public bool IsProductPricesAsExpected()
        {
            var expectedPrice = "Rs.500";
            var expectedPriceValue = expectedPrice.Replace("Rs.", "").Trim();
            try
            {
                WaitUntilElementIsClickable(ProductPrice);
                var totalText = ProductPrice.Text.Replace("Rs.", "").Trim(); ;
                Console.WriteLine(totalText);
                return totalText == expectedPriceValue;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }

        }

        public bool IsProductQuantityAsExpected()
        {
            var expectedQuantity = "2";
            try
            {
                WaitUntilElementIsClickable(ProductQuantity);
                var productQuantity = ProductQuantity.Text;
                return productQuantity.Trim() == expectedQuantity.Trim(); ;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }

        public bool IsTotalAsExpected()
        {
            var expectedTotalPriceToPay = "Rs.1000";
            var expectedTotalPriceValue = expectedTotalPriceToPay.Replace("Rs.", "").Trim();
            try
            {
                WaitUntilElementIsClickable(TotalPrice);
                var totalText = TotalPrice.Text.Replace("Rs.", "").Trim();
                return totalText == expectedTotalPriceValue;
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