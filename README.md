# Coding Interview Frameworks #

.net solutions designed to be a basis for code interviews

## FooBar children's game (Basic C#) ##
Based on Fizz Buzz below but with a new name so that people dont have Fizz Buzz baggage, and it makes it more difficult to google for solutions if given off line. The difference is that its structured more story like and will evolve and hopefully promote more testing. maybe. see my quick solution here: [DamoFooBar](https://github.com/DamianStanger/codingInterview/tree/DamoFooBar/FooBarInterview) Details and stories can be found in the separate readme.md

## Shapes Interview (Basic C#) ##
This solution is designed to test very basic knowledge of C#. It does use unit tests using nunit, but the candidate does not really need to know about unit testing or nunit to do this.

I implemented the tests in the branch [Damo](https://github.com/DamianStanger/codingInterview/tree/Damo)

## Fizz Buzz (Basic C#) ##
There is an integration test that forms the basis of the solution. The interviewer can decide, depending on how the interview progresses, whether the candidate should drive the code through pure TDD or leave it open to see what happens. Either way there is an over arching test that can be used to guide the candidate to a correct solution.

Rules of Fizz Buzz are here: [https://en.wikipedia.org/wiki/Bizz_buzz](https://en.wikipedia.org/wiki/Bizz_buzz)

I implemented FizzBuzz Twice:
 * [damoFizzbuzzquick](https://github.com/DamianStanger/codingInterview/tree/damoFizzbuzzquick) quick and basic method
 * [DamoFizzBuzz](https://github.com/DamianStanger/codingInterview/tree/DamoFizzBuzz) *Warning, test driven development overkill*

### Some good follow up questions: ###
* Ask what might go wrong with their solution, for example bad arguments, any exceptions you can see in their logic

* Add the requirement for 3 and 5 FizzBuzz, do they do try and do TDD or jump straight into coding the logic?

* Ask the candidate to ensure the program always accepts one argument. You are looking for a TDD approach here, write the test for zero arguments and ensure it writes out some text to the console instead e.g. "Please pass only one argument". They should write 2 tests:
  * test 0 args
  * test 2 args

* Finally ensure that the first argument passed is positive number above zero, again if it is not the program should write "Expected argument should be numeric". You are looking for a number of tests:
  * "abc"
  * -1
  * 0
  * if they used an int (max int +1) if a long (max long +1)

### Advanced follow up: ###
 * Scenario: Every time the program is run it is to write the resulting string to a data base. We are not going to write the DB code yet (another team is writing that), we need to write a test that ensures a call to the DB is made through an interface with the correct data, they can use a mocking framework if they like, or a test double, its upto them. But do they know what to do? and can they do real TDD?
