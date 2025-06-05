# 1 - Slides - Explain concept

## Code coverage is a very basic measure

- Code coverage looks at each line of code and shows whether or not that line was touched by a test
- It tells you if a line of code is covered by a test
- It does not tell you whether or not you can trust that test

## Mutation testing is another way to measure the quality of your unit tests

- It is a tool
- It isn't a different type of testing, same as code coverage isn't a different type of testing
- It does give a better indication of how much you can trust your tests

## How mutation testing works

- Injects small bugs 👾 (known as mutants) into the code
  - this could be something like changing a plus to a minus or deleting a line of code

- Runs the unit tests that touch that code
  - If a test failed then you killed the mutant and get a ✔️
  - If the tests all pass then the mutant survived and you get a ❌

## Let's give it a go

# 2 - Run the tests

Copy `StrykerOutput/2025-06-05.09-59-56/reports/mutation-report.html` part of the output

# 3 - Open the report

- Drill into the layers and show the mutations
- Show killed mutations too
