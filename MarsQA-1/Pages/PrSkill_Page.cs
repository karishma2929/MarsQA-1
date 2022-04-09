using MarsQA_1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    internal class PrSkill_Page 
    {
        public void CreateProfileSkill(IWebDriver driver,string AddSkill)
        {

            // Click on Skill Add New Tab
            IWebElement SkillAddNew = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            SkillAddNew.Click();
            // Enter Add Skill
            IWebElement SkillAdd = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            SkillAdd.SendKeys(AddSkill);
            // Choose Skill Level dropdown
            IWebElement SkillLeveldropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillLeveldropdown.Click();
            //Select BeginnerOption
            IWebElement BeginnerOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            BeginnerOption.Click();
            // Select FinalAddSkill
            IWebElement FinalAddSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            FinalAddSkill.Click();

            Thread.Sleep(2000);
        }
        public string GetSkillCreated(IWebDriver driver)
        {
         IWebElement SkillLastRow = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return SkillLastRow.Text;
        }
        public string GetSkillLevelCreated (IWebDriver driver)
        {
         IWebElement SkillLevelLastRow = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return SkillLevelLastRow.Text;

        }
 //_____________________________________________________________________________________________________________________________________________________________________________________________________________________________           
        
        public void EditProfileSkill(IWebDriver driver)
        {
           

         // Checking Again last Skill Record so that it delets my created record only.
            IWebElement LastSkillRecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            if (LastSkillRecord.Text == "Technical Sales")
            {
                //Click on Edit Icon 
                IWebElement EditIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
                EditIcon.Click();
            }
            else
            {
                Console.WriteLine("Cannot Edit the record");
            }
          //Edit Sill Tab
          IWebElement EditSkillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
          EditSkillTab.Clear();
          EditSkillTab.SendKeys("Customer Support");
          // Edit level Drop down
          IWebElement EditLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]"));
          EditLevelDropdown.Click();
          //Click on Update button:
          IWebElement SkillUpdateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
          SkillUpdateButton.Click();

          Thread.Sleep(2000);
            
            
         // Assertion to Check if last record has been changed           
        }
        public string GetEditedSkill(IWebDriver driver)
        {
          IWebElement EditedRecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return EditedRecord.Text;
        }
        public string GetEditedSkillLevel(IWebDriver driver)
        {
            IWebElement EditedLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return EditedLevelDropdown.Text;
        }
//____________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        public void DeleteProfileSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            // Find your Last created record.
            IWebElement DeleteLastSkillRecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            if(DeleteLastSkillRecord.Text == "Customer Support")
            {
                // Click on Delete Function 
                IWebElement DeleteSkillIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
                DeleteSkillIcon.Click();
            }
            else 
            {
                Console.WriteLine("Cant Delete the record as record is not same as Customer Support");
            }

            Thread.Sleep(1000); 
        }
        // Assertion to checkif the Skill record is delete 
        public string DeletedSkill(IWebDriver driver)
        {
          IWebElement CheckDeletedSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return CheckDeletedSkill.Text;
        }
    }
}