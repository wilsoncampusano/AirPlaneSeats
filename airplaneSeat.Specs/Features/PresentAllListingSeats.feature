Feature: PresentAllListingSeats

Scenario: a list with reserved seats
	Given the following listing of seats in db
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
	When I search for a list of all passanger
	Then the result shoulb be
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