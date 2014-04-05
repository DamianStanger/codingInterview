# Coding Interview Frameworks #

Sample C# solutions to form a basis of code interviews

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

* Ask the candidate to ensure the program always accepts one argument. You are looking for a TDD approach here, write the test for zero arguments and ensure it writes out some text to the console instead e.g. "Please pass only one argument". They should write 2 tests:
  * test 0 args
  * test 2 args

* Finally ensure that the first argument passed is positive number above zero, again if it is not the program should write "Expected argument should be numeric". You are looking for a number of tests:
  * "abc"
  * -1
  * 0
  * if they used an int (max int +1) if a long (max long +1)

### Advanced follow up: ###
 * Every time the program is run it is to write the result string to a DB, but we are not going to write the DB code yet (another team is writing that), so they need to write a test that tests a call to the DB is made through an interface with the correct data, they can use a mocking framework if they like, or a test double its upto them.