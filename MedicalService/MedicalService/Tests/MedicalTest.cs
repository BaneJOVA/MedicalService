using MedicalService.Driver;
using MedicalService.Page;

namespace MedicalService.Tests
{
    public class MedicalPage
    {
        LoginPage loginPage;
        MedicalPages medicalPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            medicalPage = new MedicalPages();
        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }
        [Test]
        public void TC01_MakeAppointment_ShouldAppointmentBeCompleted()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("John Doe", "ThisIsNotAPassword");
            medicalPage.SelectOption("Hongkong CURA Healthcare Center");
            medicalPage.CheckBox.Click();
            medicalPage.MedicId.Click();
            medicalPage.Data.SendKeys("25/12/2022");
            medicalPage.Comment.SendKeys("Zakazano");
            medicalPage.Buton.Submit();

            Assert.That("Appointment Confirmation",Is.EqualTo(medicalPage.Confirm.Text));
            

        }
    }
}