using MarsQA_1.Pages;
using MarsQA_1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class ProfileDetails_Skill : CommonDriver
    {
        // All Page Objects :
        LoginPage LoginPageObj = new LoginPage();
        HomePage HomepageObj = new HomePage();
        PrSkill_Page PrSkill_PageObj = new PrSkill_Page();

        [Given(@"Login to the Portal successfully")]
        public void GivenLoginToThePortalSuccessfully()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            LoginPageObj.LoginSteps(driver);
        }
        [Given(@"Navigate to Skill via Home-Profile tab")]  
        public void GivenNavigateToSkillViaHome_ProfileTab()
        {
            HomepageObj.GoToProfileTab_Skill(driver);
        }
     //Adding Skills
        [When(@"Add a New Skill '([^']*)' and Skill Level in Profile")]  //__1
        public void WhenAddANewSkillAndSkillLevelInProfile(string p0)
        {
            PrSkill_PageObj.CreateProfileSkill(driver,p0);
        }

        [Then(@"Profile Skill was succesffuly Created with '([^']*)'")]
        public void ThenProfileSkillWasSuccesffulyCreatedWith(string p0)
        {
            string newSkill = PrSkill_PageObj.GetSkillCreated(driver);
            Assert.That(newSkill == p0, message: "New Skill created is not matching");
        }

        [Then(@"Profile Skill Level was succesffuly applied\.")]
        public void ThenProfileSkillLevelWasSuccesffulyApplied_()
        {
           string newSkillLevel = PrSkill_PageObj.GetSkillLevelCreated(driver);
           Assert.That(newSkillLevel == "Beginner", message: "Skill Level is not correct");
        }
     // Updating Last Skill added:
        [When(@"Edit the last created Skill record\.")]
        public void WhenEditTheLastCreatedSkillRecord_()
        {
            PrSkill_PageObj.EditProfileSkill(driver);
        }

        [Then(@"Profile Skill was succesffuly Edited\.")]
        public void ThenProfileSkillWasSuccesffulyEdited_()
        {
            string newEditedSkill = PrSkill_PageObj.GetEditedSkill(driver);
            string newEditedSkillLevel = PrSkill_PageObj.GetEditedSkillLevel(driver);

            Assert.That(newEditedSkill == "Customer Support", message: "Skill Not Edited");
            Assert.That(newEditedSkillLevel == "Intermediate", message: "Dropdown Not Edited");
        }
     // Deleting last skill Edited:
        [When(@"Delete the last Edited Skill record\.")]
        public void WhenDeleteTheLastEditedSkillRecord_()
        { 
            PrSkill_PageObj.DeleteProfileSkill(driver);
        }

        [Then(@"Profile Skill was succesffuly Deleted\.")]
        public void ThenProfileSkillWasSuccesffulyDeleted_()
        {
            string newDeletedSkill = PrSkill_PageObj.DeletedSkill(driver);
            
            Assert.That(newDeletedSkill != "Customer Support", message:"Record is Deleted");
        }
        
    }
}

