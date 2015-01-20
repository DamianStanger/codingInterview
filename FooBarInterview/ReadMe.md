# FooBar the children's number counting game

The new product is envisioned to Increase the number literacy of the players by getting them to learn their times tables in a fun setting.

You are required to code the business logic component that will calculate the correct answer so the children know if they are correct during the game.

##Basic Rules:
1. When counting from 1 to 10 you substitute "Foo" for all the numbers divisible by 3.
2. Substitute "Bar" for all numbers divisible by 5

---

##New game feature 1.
Allow the user to pick the starting and finishing numbers
##Advanced Rules
3. Substitute "FooBar" For all the numbers divisible by 3 and 5



---

##New game feature 2.
We are finding that many children are not entering numbers but instead text garbage causing exceptions. So inside the UI layer we need to protect against bad input and respond with
```
"'<??>' Is not valid. Please enter two numbers between 0 and 100"
```
where <??> Is the original input.
    
---

##New game feature 3.
We are still finding people are having trouble with the app. We would like to log all the input values so that we can analyse them later. The component for logging is being done by a different team you just need to call an object with the interface IInputLogger on all calls to the UI.

---

# Notes to the Interviewer
* This is designed to be given to the candidate in 4 stages. the first is to see how they attack the problem, do they write more tests? do they do part 1. then 2. or both together? Do they treat it as two stories or one?
* Part 2 is again designed to see how they tackle 2 very different requirements. do they finish one fully tested before doing the next? The new game feature will need new unit tests creating as there are none for the console app project.
* The final new feature 3. is to see if they know how to mock classes correctly.