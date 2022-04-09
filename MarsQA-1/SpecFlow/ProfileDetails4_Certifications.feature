Feature: ProfileDetails4_Certifications
*The Purpose of this Feature file is to list down testcases to Create,Edit and Delete Certifications in the Profile.
*Further to the CRUD Tests below, more Test scenarios both (Positives and Negatives) 
  can be added to this feature file in future for Certifications Scetion.

@Profile_Languages_CRUD
Scenario: Test_Certification_1.Create Certifications record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Certifications via Home-Profile tab
	When  Add a New Certifications in Profile.
	Then  Profile Certifications was succesffuly Created 

Scenario: Test_Certification_2.Edit Certifications record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Certifications via Home-Profile tab
	When  Edit the last created Certifications record.
	Then  Profile Certifications was succesfuly Edited. 

	Scenario: Test_Certification_3.Delete Languages record for Profile Deatils
    //Given  Login to the Portal successfully 
    And   Navigate to Certifications via Home-Profile tab
	When  Delete the last Edited Certification record.
	Then  Profile Certification was succesffuly Deleted.

@More_TestCases_Certification
	Scenario: Test_Certificatio_4. User should not be able to Add Certification without entering all Mandatory Details. 
	//Given Login to the Portal successfully 
	And   Navigate to Certification via Home-Profile tab

	When  Add Only "Certification or Award" name and Click Add
	Then  Message Should show: Please enter all the fields
	
	When  Add only "Certified from" and Click Add
    Then  Message Should show: Please enter all the fields

	When  Select only "Year" and Click Add
    Then  Message Should show: Please enter all the fields

Scenario: Test_Certificatio_5.User Should be able to Cancel the page if doesnt want to continue adding Certification
  // Given  Login to the Portal successfully 
    And   Navigate to Certificatio via Home-Profile tab
	When  Click on Add New and then click on Cancel button
	Then  Create certication form should disapper and Home page directing Certification Page Should be visible.