# Classes for Data Objects Challenge
In this challenge, there is no step-by-step guide and no hints. However, if you get really stuck, the full solution is located in the ModelSolutionIfYouNeedIt.Code project.

The challenge gives you a starter project that creates a set of Student objects. You’ll then be set a number of challenges to create LINQ queries that return filtered and grouped collections of students, based on their gender, age, and favourite hobbies.

__Note:__ Upon submission, the output of your code will be automatically tested. Please recognise the tests are looking for precisely sequenced sets of text, so do not alter the student data in any way. Also, if you think your code is producing the correct output, but the associated test fails, then it’s quite likely there’s some kind of minor discrepancy, such as an additional or missing space or piece of punctuation.

# Task
Locate the ClassesForDataObjectsChallenge.Code console project. Look inside the Student.cs file to understand how the Student class has been defined.

1.  Open the ```Program.cs``` files, locate the Main method and within that the TODO 1 comment.

2.  Create a LINQ query that creates a set of students who are female and under 21. 

3.  Create a loop that writes the name and age of each selected student to the console with each set of details appearing on a new line using the following format:

```
"{Student Full Name} is {Age} years old"
```

The correct output should be:

```
Doina Precup is 20 years old
Marissa Mayer is 20 years old
```

4. Locate the TODO 2 comment in the main function of Program.cs

5. Create a LINQ query that creates a collection the surnames and ages of female students who are greater than or equal to 21.

6. Create a loop that writes the name and age of each selected student to the console with each set of details appearing on a new line using the following format:

```
"{Student Surname} is {Age} years old"
```

The correct output should be:

```    
Ehmke is 22 years old
Chang is 21 years old
```

7. Locate the TODO 3 comment in the Main function of Program.cs.

8. Use LINQ and/or lambda to create and print a collection of students that lists the popularity of hobbies in descending sequence within gender. You will probably need to tackle the task using two separate queries and a pair of nested loops, so look out for TODOs 3a to 3d which hint at what needs to be done. Test each section as you develop it.

9. The output should look like the following:

```
     Gender: F, Hobby: Sport, Count: 2
     Gender: F, Hobby: Films, Count: 1
     Gender: F, Hobby: Music, Count: 1
     Gender: M, Hobby: Music, Count: 1
     Gender: M, Hobby: Sport, Count: 1
     Gender: U, Hobby: Music, Count: 1
```

# To Run the Project
-  Select "Start Debugging" or "Run Without Debugging" from Visual Studio Code's "Run" menu or press F5 or Ctrl+F5
-  To interact with the console (and view the program's output) select the "Terminal" option from Visual Studio Code's View Menu (or press Ctrl+')  

# Execute Unit Tests
At any time you can invoke the unit tests that will be used to determine whether you have successfully completed the challenge by selecting the "Terminal" option from Visual Studio Code's View Menu (or pressing Ctrl+')) and running the following command:

```
dotnet test
```
If all the tests pass you will see a message (in green) that states <span style="color:green">"Passed!  - Failed:   0..."</span>. If any of the tests fail tou will see a message in red that states <span style="color:red">"Failed! - Failed:    n..."</span> where n indicates the number of tests that have failed.

__Note:__ You are NOT (yet) expected to understand how to create your own unit tests nor to interpret the results beyond knowing whether the tests have passed or failed. You will be looking at unit testing as the final topic of this digital course.

# Model Solution (__but only if you need it__)
The code for a model solution can be found in the ```ModelSolutionIfYouNeedIt.Code``` project 