Feature: ProfileDetails3_Education
*The Purpose of this Feature file is to list down testcases to Create,Edit and Delete Education in the Profile.
*Further to the CRUD Tests, More Test scenarios both (Positives and Negatives) 
  can be added to this feature file in future for Education Scetion.

@Profile_Education_CRUD
Scenario: Test_Education_1.Create Education record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Education via Home-Profile tab
	When  Add a New Education in Profile
	Then  Profile Education was succesffuly Created 

Scenario: Test_Education_2.Edit Education record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Education via Home-Profile tab
	When  Edit the last created Education record.
	Then  Profile Education was succesfuly Edited. 

Scenario: Test_Education_3.Delete Education record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Education via Home-Profile tab
	When  Delete the last Edited Education record.
	Then  Profile Education was successfully Deleted. 

	
Scenario: Test_Education_4. User should not be able to Add Education without entering all Mandatory Details. 
	//Given Login to the Portal successfully 
	And   Navigate to Education via Home-Profile tab

	When  Add Only "College/ University" Name and Click Add
	Then  Message Should show: Please enter all the fields
	
	When  Add only "Degree" and Click Add
    Then  Message Should show: Please enter all the fields

	When  Select only "Country of University" and Click Add
    Then  Message Should show: Please enter all the fields

	When  Select only "Year of Graduation" and Click Add
    Then  Message Should show: Please enter all the fields

	When  Select only "Title" and Click Add
    Then  Message Should show: Please enter all the fields


Scenario: Test_Education_'5.User Should be able to Cancel the page if doesnt want to continue adding Certification
   //Given  Login to the Portal successfully 
    And   Navigate to Education via Home-Profile tab
	When  Click on Add New and then click on Cancel button
	Then  Create education form should disapper and Home page directing Certification Page Should be visible.