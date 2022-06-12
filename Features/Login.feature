Feature: Login

@Register @smoke @integration
Scenario: Validate a user can register successfully
	Given User in the registration page
	When User register
	Then User registration should be successful

