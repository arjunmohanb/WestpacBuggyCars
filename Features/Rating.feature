Feature: Rating


@rating @smoke
Scenario: Validate an user can give rating to the cars on make page
	Given the user is in MAKE page
	And the user is logged in
	When the user add a comment and press vote
	Then the comment should be displayed 
	And the vote count should be updated