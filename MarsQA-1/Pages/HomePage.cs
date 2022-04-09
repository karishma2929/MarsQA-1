using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Pages 
{
    internal class HomePage
    {
        public void GoToProfileTab_Skill(IWebDriver driver)
        {
            
            IWebElement ProfileTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            ProfileTab.Click();

            // Click On Skill Tab:
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();

            Thread.Sleep(1000);
        }
        
    }
}
