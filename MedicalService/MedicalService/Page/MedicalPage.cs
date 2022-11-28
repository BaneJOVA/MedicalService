using MedicalService.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MedicalService.Page
{
    public class MedicalPages
    {
        private IWebDriver driver = WebDrivers.Instance;
        private object text;
        private object element;

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(driver.FindElement(By.Id("combo_facility")));
            element.SelectByText(text);
        }

        public IWebElement CheckBox => driver.FindElement((By.Id("chk_hospotal_readmission")));
        public IWebElement MedicId => driver.FindElement((By.Id("radio_program_medicaid")));
        public IWebElement Data => driver.FindElement((By.Id("txt_visit_date")));
        public IWebElement Comment => driver.FindElement((By.Id("txt_comment")));
        public IWebElement Buton => driver.FindElement((By.Id("btn-book-appointment")));

        public IWebElement Confirm => driver.FindElement((By.CssSelector("text-selectorh2")));

    }

}
