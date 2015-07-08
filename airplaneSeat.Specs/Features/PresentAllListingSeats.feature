Feature: PresentAllListingSeats

Scenario: user want to see a list with reserved seats
	Given There are some reservations
	When I search for a list of all reservations
	Then The user can see the following list
		| Seat Number | Passanger |
		| 1           | Ross      |
		| 2           | N/O       |
		| 3           | Belisle   |
		| 4           | Krakov    |
		| 5           | N/O       |
		| 6           | N/O       |
		| 7           | Soo       |
		| 8           | Green     |
		| 9           | Garcia    |
		| 10          | Levin     |
		| 11          | N/O       |
		| 12          | Johnson   |