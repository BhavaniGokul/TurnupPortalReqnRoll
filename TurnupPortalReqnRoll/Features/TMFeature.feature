Feature: TMFeature

As a Turnupportal Admin user, I would like to create, edit and delete Time Material records
so I can manage the employee time and materials successfully

Background: 
Given I logged into turnup portal successfully
And I navigated to the Time and Material page

@regression @bvt @timeandmaterial
Scenario: Create new time and material record with valid data
When I create a new time and material record
Then The record should be created successfully

Scenario Outline: Edit exiting time and material record with valid data
When I update the '<Code>' and '<Description>' on an existing time record
Then The record should have the updated '<Code>' and '<Description>'
Examples: 
| Code             | Description |
| Industry Connect | Laptop      |
| TA Job Ready     | Mouse       |
| Edited Record    | Keyboard    |