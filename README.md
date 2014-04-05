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
 * [DamoFizzBuzz](https://github.com/DamianStanger/codingInterview/tree/DamoFizzBuzz) *Warning, i used a totally test driven overkill method to do this*

### Some good follow up questions: ###
* Ask what might go wrong with their solution, for example bad arguments, any exceptions you can see in their logic

* Ask the candidate to ensure the program always accepts one argument. You are looking for a TDD approach here, write the test for zero arguments and ensure it writes out some text to the console instead e.g. "Please pass only one argument". They should write 2 tests:
  * 0 args
  * 2 args

* Then ensure that the argument passed is numeric, again if it is not the program should write "Expected argument should be numeric". 
