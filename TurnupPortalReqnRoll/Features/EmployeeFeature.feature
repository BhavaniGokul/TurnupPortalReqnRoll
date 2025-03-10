Feature: Employee Feature

As a Turnupportal Admin user,
I would like to create, edit and delete Employee records
so I can manage the employees successfully

Background: 
Given I logged into turnup portal successfully
And I navigated to Employee page

Scenario: Create new employee record successfully
When I create a new employee record
Then The employee record should be created successfully