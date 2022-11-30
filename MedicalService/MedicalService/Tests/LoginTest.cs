using MedicalService.Driver;
using MedicalService.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Tests
{
    public class LoginTest
    {

        LoginPage loginPage;
        string Massage = "Login failed! Please ensure the username and password are valid.";

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }

        [Test]
        public void TC01_EnterInvalidUsername()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("Bane", "ThisIsNotAPassword");

            Assert.That(Massage, Is.EqualTo(loginPage.UserNotLogin.Text));
        }

        [Test]
        public void TC02_EnterNoData_ShoulNotBeLoginOnPage()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("", "");

            Assert.That(Massage, Is.EqualTo(loginPage.UserNotLogin.Text));
        }
    }
}
