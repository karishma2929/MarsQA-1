Feature: ProfileDetails5_Description

The purpose of this feature file is to  list down all the Test for the description feature of the Profile

@tag1
Scenario: Test_Description_1.Create Descriptio for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Profile tab
	When  Add Profile description
	Then  Description is sucessfully created.

Scenario: Test_Description_2.Edit Description for Profile Details
    //Given  Login to the Portal successfully 
    And   Navigate to Profile tab
	When  Edit Profile Description
	Then  Description is sucessfully Edited and viewed.