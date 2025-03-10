Feature: TMFeature

As a Turnupportal Admin user, I would like to create, edit and delete Time Material records
so I can manage the employee time and materials successfully

@regression @bvt @timeandmaterial
Scenario: Create new time and material record with valid data
Given I logged into turnup portal successfully
When I navigated to the Time and Material page
When I create a new time and material record
Then The record should be created successfully

Scenario Outline: Edit exiting time and material record with valid data
Given I logged into turnup portal successfully
When I navigated to the Time and Material page
When I update the '<Code>' on an existing time record
Then The record should have the updated '<Code>'
Examples: 
| Code             |
| Industry Connect |
| TA Job Ready     |
| Edited Record    |