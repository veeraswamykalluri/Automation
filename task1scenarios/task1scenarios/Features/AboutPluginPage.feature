Feature: AboutPlugin

Scenario: Verify option to hearing aid compatibility
   Given I launch the plugin app
   And I scroll Down and launch plugin 'AboutPlugin'
   Then verify 'Hearing aid compatibility' is 'displayed' on 'AboutPluginPage'

 Scenario: Verify option to user guides
        Given I launch the plugin app
       And I scroll Down and launch plugin 'AboutPlugin'
        Then verify 'User guides' is 'displayed' on 'AboutPluginPage'
Scenario: Verify BodyText in Help section in app
        Given I launch the plugin app
       And I scroll Down and launch plugin 'AboutPlugin'
         Then verify 'Help section in app' is 'displayed' on 'AboutPluginPage'
   Scenario: Verify BodyText in Hearing aid compatibility
        Given I launch the plugin app
       And I scroll Down and launch plugin 'AboutPlugin'
       Then verify 'Hearing aid compatibility' is 'displayed' on 'AboutPluginPage'
     Scenario: Verify BodyText in User guides
        Given I launch the plugin app
       And I scroll Down and launch plugin 'AboutPlugin'
       Then verify 'User guides' is 'displayed' on 'AboutPluginPage'
      
Scenario: Verify the AboutPlugin plugin is closed with Back button
        Given I launch the plugin app
        And I scroll Down and launch plugin 'AboutPlugin'
        Then verify 'Back' is 'displayed' on 'HeaderPage'
        And verify 'close' is 'not Displayed' on 'HeaderPage'
        And verify 'header' is 'displayed' on 'HeaderPage'
        When I press 'Back' on 'HeaderPage'
        Then verify 'MenuPageHeader' is 'displayed' on 'HeaderPage'

