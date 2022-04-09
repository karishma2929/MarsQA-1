using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //___________________________Login Steps______________________________________________________
            //Lauch the Website Portal
            driver.Navigate().GoToUrl("http://localhost:5000");
            try
            {
                // Click on Sign In Button
                IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                SignInButton.Click();

                // Identify Username text box and enter user nanem
                IWebElement UsernameTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                UsernameTextBox.SendKeys("karishmanaik78@gmail.com");

                //Identify Passwor and enetr passwrod
                IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                PasswordTextBox.SendKeys("123123");

                // Click login button.
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();
                Thread.Sleep(5000);
            }
            catch (Exception)
            {
                Console.WriteLine("Login Failed");
                throw;
            }
            

            


        }
    }
}
