Feature: ProfileDetails1_Languagescs
*The Purpose of this Feature file is to list down testcases to Create,Edit and Delete Languages in the Profile.
*Further to the CRUD Tests, More Test scenarios both(Positives and Negatives) 
  can be added to this feature file in future for Languages Scetion.

@Profile_Languages_CRUD
Scenario: Test_Languages_1.Create Languages record for Profile Deatils
   // Given Login to the Portal successfully 
	And   Navigate to Languages via Home-Profile tab
	When  Add a New Languages in Profile
	Then  Profile Language was succesffuly Created 

Scenario: Test_Languages_2.Edit Languages record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Languages via Home-Profile tab
	When  Edit the last created Language record.
	Then  Profile Language was succesffuly Edited. 

Scenario: Test_Languages_3.Delete Languages record for Profile Deatils
    //Given  Login to the Portal successfully 
    And   Navigate to Languages via Home-Profile tab
	When  Delete the last Edited Language record.
	Then  Profile Language was succesffuly Deleted. 

@More_TestCases_Langauge
Scenario Outline: Test_Languages_4.User Should not be able to add more then 4 Langauges
	//Given Login to the Portal successfully 
    And   Navigate to Languages via Home-Profile tab
	When  Add 4 Langauges '<Lagauges>' to the Profile
	Then  Add New button of the Lanaguge should not be visible.
	Examples: 
	| Langauges  |
	| English    |
	| French     |
	| Portuguese |
	| Hindi      |

Scenario Outline: Test_Languages_5.Add New Button should reflect back when 1 langauge is deleted out of 4
  //Given Login to the Portal successfully 
    And   Navigate to Languages via Home-Profile tab
	When  Add 4 Langauges '<Lagauges>' to the Profile.
	When  Delete 1 Langauge.
	Then  Add New button should be visible. 
    Examples:   
	| Langauges  |
	| English    |
	| French     |
	| Portuguese |
	| Hindi      |

Scenario: Test_Languages_6.Trying to add Lanaguge without adding any data.
  //  Given Login to the Portal successfully 
    And   Navigate to Languages via Home-Profile tab
	When  Add new Lanaguge without putting any data for "Add Lanaguge"and "Langauge Level"
	Then  Pop up Message should ask to enter valid data.

Scenario: Test_Languages_7.User Should be able to cancel the page if doesnt want to continue adding langauge
  //  Given Login to the Portal successfully 
    And   Navigate to Languages via Home-Profile tab
	When  Click on Add New and then click on Cancel button
	Then  Home page directing to Lanaguge page Should be visible.
