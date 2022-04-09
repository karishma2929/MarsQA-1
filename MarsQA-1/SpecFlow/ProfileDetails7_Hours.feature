Feature: ProfileDetails7_Hours

The purpose of this feature file is to list down all thes test cases for Hours section of the Profile feature 
of the Portal. 

Scenario: Test_Hours_.Edit Hours record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Profile tab
	When  Edit Availabity record by using dropdown options
	Then  Profile should Update with given Hours information

Scenario: Test_Hours_.Test if user can cancel editing Hours option
    //Given  Login to the Portal successfully 
    And   Navigate to Profile tab
	When  Click Edit hours and then click on cancel button
	Then  Hours record should be same as the previous record.