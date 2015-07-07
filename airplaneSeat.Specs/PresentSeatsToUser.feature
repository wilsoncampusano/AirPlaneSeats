Feature: Ordering answers

Scenario: The answer with the highest vote gets to the top
	Given there is a question "What's your favorite colour?" with the answers
		| Answer			| Vote |
		| Red				| 1    |
		| Cucumber Green    | 1    |	
	When you upvote answer Cucumber Green"
	Then the answer "Cucumber Green" should be on top