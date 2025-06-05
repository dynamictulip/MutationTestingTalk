# Code Coverage

## 1 - Look at code under test

- Here is our super important and incredibly complicated program
  - This is an important program - if there's a bug then bad things might happen like planes falling out of the sky!
- Here are the unit tests for it
  - I've checked each method works

- Lets make sure that they pass
- [_Run tests to see them pass_]
- They all pass! Yay this must be good code!
- "But what about code coverage?" I hear you say?

## 2 - What is code coverage

- It tells you whether or not a line of code is covered by a test
- We tend to use it to measure the quality of unit tests
  - because we expect our unit tests to cover all our edge cases and boundary conditions
  - unit tests are a good way to ensure that we've thought about all the scenarios our code might encounter
- This adds together the number of lines of code covered by tests and divides them by the total number of lines of code

## 3 - Run tests with code coverage

- [_Run with code coverage_]
- Code coverage picked up a missing test! Let's fix that with something that I prepared earlier...

## 4 - Fix missing test

- [_Code should add itself_]
- Explain what the new code does
- [_Re-run tests with code coverage_]
