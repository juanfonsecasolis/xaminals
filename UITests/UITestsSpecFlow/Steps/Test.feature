Feature: Navigation
    To find my animals quickly
    As a biologist
    I want to have one tabs per category
    
@smoke-test
Scenario: Navigate through categories
    Given that I am in the home screen
    When I navigate through the categories
    Then at least one animal should be displayed per category
