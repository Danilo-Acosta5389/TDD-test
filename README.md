# TDD-test

This project was made for trying out a test-driven-development approach when writing code and methods.
I have created "WordLib" project at first and then added a new project, "WordLibTest", in the same solution file.
Then i write a test method that at first creates a new instance of a class that does not exist, i do however create the class from the suggestion "helper menu" in Visual Studio, then i declare a string variable with a value (any word) and after this i call upon a method that doesn't exist, however i do the same that i did when creating the class and so the method "isPalindrome" is created in the main project. My goal was to create a method that checks if a word is in fact a palindrome, and if so the method returns "true". Fairly easy, however the point is to do this while implementing a TDD approach, writing the test first and adjusting after the reuslts.
