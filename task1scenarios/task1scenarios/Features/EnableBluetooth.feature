Feature: EnableBluetooth
Verified Enable Bluetooth page  
    
Scenario: Verify EnableBluetooth flow completed
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I press 'Bluetooth' button on Settings Page and Turn 'ON' bluetooth
    And I relaunch the plugin app 
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    Then verify plugin is completed


#Scenario: Verify about enabling Bluetooth-iOS
#    Given I launch the plugin app
#    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
#    And I press 'Ok' on 'BluetoothPermissionPluginPage'
#    And I 'GRANT' permission request
#    And Go to native settings
#    When I press 'Bluetooth' button on Settings Page
#    And I turn 'OFF' Bluetooth
#    And I relaunch the plugin app
#    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
#    Then verify 'Body1Description' is 'displayed' on 'EnableBluetoothPluginPage'


#Scenario: Verify Option to Open settings-iOS
#    Given I launch the plugin app
#    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
#    And I press 'Ok' on 'BluetoothPermissionPluginPage'
#    And I 'GRANT' permission request
#    And Go to native settings
#    When I press 'Bluetooth' button on Settings Page
#    And I turn 'OFF' Bluetooth
#    And I relaunch the plugin app 
#    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
#    Then verify 'Open Settings' is 'displayed' on 'EnableBluetoothPluginPage'   


Scenario: Verify about enabling Bluetooth-Android
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I turn 'OFF' Bluetooth
    And I relaunch the plugin app
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    Then verify 'Body1Description' is 'displayed' on 'EnableBluetoothPluginPage'    


Scenario: Verify option to enable Bluetooth prompt-Android
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I turn 'OFF' Bluetooth
    And I relaunch the plugin app
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    Then verify 'Turn On Bluetooth' is 'displayed' on 'EnableBluetoothPluginPage'    


Scenario: Verify Bluetooth is enabled in OS dialog-Android
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I turn 'OFF' Bluetooth
    And I relaunch the plugin app
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    And I press 'Turn On Bluetooth' on 'EnableBluetoothPluginPage'
    And I press 'AllowBluetooth' on 'NativeBluetoothPage'
    Then verify plugin is completed


Scenario: Verify Bluetooth is enabled in OS dialogs-Anroid
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I turn 'OFF' Bluetooth
    And I relaunch the plugin app
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    And I press 'Turn On Bluetooth' on 'EnableBluetoothPluginPage'
    And I press 'AllowBluetooth' on 'NativeBluetoothPage'
    Then verify plugin is completed


Scenario: Verify EnableBluetooth flow is not completed when denying permission request-Anroid
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I turn 'OFF' Bluetooth
    And I relaunch the plugin app
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    And I press 'Turn On Bluetooth' on 'EnableBluetoothPluginPage'
    And I press 'DenyBluetooth' on 'NativeBluetoothPage'
    Then verify 'Body1Description' is 'displayed' on 'EnableBluetoothPluginPage'   


Scenario: Verify the app settings are displayed through OS-iOS
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I press 'Bluetooth' button on Settings Page
    And I turn 'OFF' Bluetooth
    And I relaunch the plugin app 
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    And I press 'Open Settings' on 'EnableBluetoothPluginPage'  
    Then Verify if 'Bluetooth' permission is 'GRANT'


Scenario: Verify EnableBluettoth flow is completed on granting bluetooth-iOS
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I press 'Bluetooth' button on Settings Page
    And I turn 'OFF' Bluetooth
    And I relaunch the plugin app
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    And Go to native settings
    And I press 'Bluetooth' button on Settings Page
    And I turn 'ON' Bluetooth
    And I relaunch the plugin app
    Then verify plugin is completed
     

Scenario: Verify EnableBluetooth flow is not proceeded on denying bluetooth-iOS
    Given I launch the plugin app
    And I scroll 'Down' and launch plugin 'BluetoothPermissionPlugin'
    And I press 'Ok' on 'BluetoothPermissionPluginPage'
    And I 'GRANT' permission request
    And Go to native settings
    When I press 'Bluetooth' button on Settings Page
    And I turn 'OFF' Bluetooth
    And I relaunch the plugin app
    And I scroll 'Down' and launch plugin 'EnableBluetoothPlugin'
    Then verify 'Body1Description' is 'displayed' on 'EnableBluetoothPluginPage' 