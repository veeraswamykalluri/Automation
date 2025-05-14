Feature:About plugin validations
A short summary of the feature


Background:
Given app is launched
 When click "AboutPlugin"
Scenario: Validations for body in Help section in app 
	
	Then It should display "body" in "Help section in app"

Scenario: Validations for body in Hearing aid compatibility 
	
	Then It should display "body" in "Hearing aid compatibility"

Scenario: Validations for body in user guides 

	Then It should display "body" in "User guides"

Scenario: Validations for existance of link in Hearing aid compatibility 
	
	Then It should display "link" in "Hearing aid compatibility"

Scenario: Validations for existance of link in user guides 
	
	Then It should display "link" in "Help section in app"

Scenario: Validations for Header in About plugin 
	
	Then It should display "headers" in "About plugin"

#Scenario: Validation for Back button on the About plugin page
#	
#	Then It should display "Backbutton" in "About plugin"

