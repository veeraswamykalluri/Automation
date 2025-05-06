Feature: AcceptTermsandConditions

A short summary of the feature


Scenario: Validation for closebutton on the AcceptTermsAndConditions page
	Given app is launched
	When click "AcceptTermsAndConditionsPlugin"
	And  I click on "close"
	Then App navigates to "mainpage"

Scenario Outline: Validation for Terms and conditions and privacy policy links on the AcceptTermsAndConditions page
	Given app is launched
	When click "AcceptTermsAndConditionsPlugin"
	And  I click on "<link name>"
	Then App navigates to "<message>"
	When I click on "close"
	Then App navigates to "mainpage"
	Examples:
  | link name            | message              |
  | Privacy policy       | privacy policy page   |
  | Terms and conditions | Terms and conditions page   |

Scenario: Validation for body on the AcceptTermsAndConditions page
	Given app is launched
	When click "AcceptTermsAndConditionsPlugin"
	Then App should display body under terms and condition on AcceptTermsAndConditions page 

Scenario: Validation for enable of continue on the AcceptTermsAndConditions page
	Given app is launched
	When click "AcceptTermsAndConditionsPlugin"
	And  Unmark the "checkbox" if marked 
	Then App not enables the "continue" button

Scenario: Validation for Click event on continue in the AcceptTermsAndConditions page
	Given app is launched
	When click "AcceptTermsAndConditionsPlugin"
	And  Mark on the "checkbox"
	And App enables the "continue" button to click
	And I click on "continue"
	Then App navigates to the "Main page"

Scenario: Validation for back button not exist on the AcceptTermsAndConditions page
	Given app is launched
	When click "AcceptTermsAndConditionsPlugin"
	Then App not having the "backbutton"
#Scenario: Validation for back button exist on the AcceptTermsAndConditions page 

Scenario Outline: Verify back button is enables
  Given  app is launched
  When click "AcceptTermsAndConditionsPlugin"
  And I click on "<link name>"
  Then I should see  "<element>"

Examples:
  | link name            | element      |
  | Privacy policy       | back button  |
  | Terms and conditions | back button  |

