Feature: ProfileDetails6_Availability

The purpose of this feature file is to list down all thes test cases for Availibity section of the Profile feature 
of the Portal. 

@tag1
Scenario: Test_Availability_.Edit Availability record for Profile Deatils
	//Given Login to the Portal successfully 
	And   Navigate to Profile tab
	When  Edit Availabity record by using dropdown options
	Then  Profile should Update with given availbilty information

Scenario: Test_Availability_.Test if user can cancel editing Availibity option
    //Given  Login to the Portal successfully 
    And   Navigate to Profile tab
	When  Click Edit availibity and then click on cancel button
	Then  Availibilty record should be same as the previous record.