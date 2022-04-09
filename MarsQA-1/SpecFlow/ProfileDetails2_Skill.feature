Feature: ProfileDetails2_Skill
*The Purpose of this Feature file is to list down testcases to Create,Edit and Delete Skill in the Profile.
*Further to the CRUD Tests, More Test scenarios both (Positive and Negative) 
  can be added to this feature file in future for Skill Section Tests.

Scenario Outline:Test_Skill_1.Create Skill record for Profile Deatils
	Given Login to the Portal successfully 
	And   Navigate to Skill via Home-Profile tab
	When  Add a New Skill '<New Skills>' and Skill Level in Profile
	Then  Profile Skill was succesffuly Created with '<New Skills>'
	Then  Profile Skill Level was succesffuly applied.
	Examples: 
	|New Skills|
	|Communication 123|
	|Leadership @ Proactive|
	|Technical Sales|

Scenario: Test_Skill_2.Edit Skill record for Profile Deatils
	Given Login to the Portal successfully 
	And   Navigate to Skill via Home-Profile tab
	When  Edit the last created Skill record.
	Then  Profile Skill was succesffuly Edited. 

Scenario: Test_Skill_3.Delete Skill record for Profile Deatils
	Given Login to the Portal successfully 
	And   Navigate to Skill via Home-Profile tab
	When  Delete the last Edited Skill record.
	Then  Profile Skill was succesffuly Deleted. 

Scenario:Test_Skill_4.User Should not be able to add Skill by only entering "Skill Level" details.
 // Given  Login to the Portal successfully
 // And    Navigate to Skill via Home-Profile tab
  When   Choose any "Skill Level" only.
  Then  User Should not be able to enter Skill without mentioning Skill.

Scenario:Test_Skill_5.User Should not be able to add Skill by only entering "Skill "
 // Given  Login to the Portal successfully
 // And    Navigate to Skill via Home-Profile tab
  When   Add only Skill in Skill tab.
  Then   User Should not be able to enter Skill without choosing Skill Levels .

Scenario: Test_Skill_6.User trying to add Skill without adding any data.
  // Given  Login to the Portal successfully 
  // And   Navigate to Skill via Home-Profile tab
   When  Add new Skill without putting any data for "Add Skill"and "Skill Level"
   Then  Pop up Message should ask to enter valid data to create Skill.

Scenario: Test_Skill_7.User Should be able to Cancel the page if doesnt want to continue adding langauge
  // Given Login to the Portal successfully 
   // And   Navigate to Skill via Home-Profile tab
	When  Click on Add New and then click on Cancel button
	Then  Home page directing Skill Page Should be visible.






	