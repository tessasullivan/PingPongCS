# Ping Pong

#### A program that allows a user to enter a number and then counts to that number, replacing some numbers with words

#### By **Tessa Sullivan**

## Description
A user enters a number, and is then provided a list of all the numbers beginning at 1, counting up to their provided number. Except some numbers in this list are replaced with words:
* All numbers in this list that are divisible by 3 are replaced by "ping".
* Numbers divisible by 5 are replaced by pong
* Numbers divisible by both 3 and 5 are replaced by "ping-pong".


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| Non-integer input should give error | User enters 'test' | Program returns error, asking them to enter a number > 0|
| User enters simplest count|User enters 1|Program returns '1' |
| User enters number where no substitution will take place|user enters 2|Program returns '1 2' |
| User enters 1st number divisible by 3|User enters 3 | Program returns '1 2 ping' |
| User enters 1st number divisible by 5 | User enters 5 | Program returns '1 2 ping 4 pong' |
| User enters another number divisible by 3 | User enters 6 | Program returns '1 2 ping 4 pong ping' |
| User enters another number divisible by 5 | User enters 10 | Program returns '1 2 ping 4 pong ping 7 8 ping pong' |
| User enters a number divisible by 3 and 5 | User enters 15 | Program returns '1 2 ping 4 pong ping 7 8 ping pong 11 ping 13 14 ping-pong' |


## Setup/Installation Requirements

1. Clone this repository.
2. Run the Program.exe (one method is to use Mono)

## Known Issues
* No known issues at this time

## Technologies Used

* C#

## Support and contact details

_Contact Tessa Sullivan @ tessa.sullivan@gmail.com_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_Tessa Sullivan_**