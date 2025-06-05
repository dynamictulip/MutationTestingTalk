---
theme: frost
layout: default
---

# Code coverage is a very basic measure

- It tells you if a line of code is covered by a test
- It does not tell you whether or not you can trust that test

---

# Mutation testing is another way to measure the quality of your unit tests

---

# How mutation testing works

- Injects small bugs 👾 into the code
- Runs the unit tests that touch that code
  - If a test failed then you killed the mutant and get a ✔️
  - If the tests all pass then the mutant survived and you get a ❌
