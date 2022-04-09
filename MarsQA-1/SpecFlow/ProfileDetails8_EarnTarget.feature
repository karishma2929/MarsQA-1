Feature: ProfileDetails8_EarnTarget

The purpose of this feature file is to list down all thes test cases for EarnTarget section of the Profile feature 
of the Portal.

Scenario: Test_EarnTarget_1.Edit EarnTarget record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Profile tab
	When  Edit Availabity record by using dropdown options
	Then  Profile should Update with given EarnTarget information

Scenario: Test_EarnTarget_2.Test if user can cancel editing Hours option
    //Given  Login to the Portal successfully 
    And   Navigate to Profile tab
	When  Click Edit EarnTarget and then click on cancel button
	Then  EarnTarget record should be same as the previous record.