# Challenge_Academy.NET

## FirstCodingChallenge
Task: 
> Insert Node into Linked List
Write a function to insert a node in a singly-linked list at a given point in the linked list. The function
should take in two inputs: the value of the node and the position where the node will be inserted.
The position will be a 1-based index meaning that the position of the head node will be 1. The
position will never be the beginning (the head) or the end (the tail) of the list

Result:
1. Implementation IEnumerable
2. Methods of SinglyLinkedList: Insert, Add, Remove, Clear, Contains
3. UnitTests


## SecondCodingChallenge

Task:
1. Input a number of students
2. Ask the user how many tests were administered to the students
3. For each student, ask the user to input the first name of the student, the last name of the student, and each numerical grade of the tests for the student.
4. For each student, calculate the grade average (sum of all test scores / number of tests) and a letter
grade based on the following table. 
5. Then output each student’s first and last name, grade average, and letter grade to the user.

Result:
```cmd
Hi, input a number of students (number is integer)
3
How many tests were administered to the students? (number is integer)
3

Student № 1
Input the first name
Mark
Input the last name
Hovich

Note, input numerical grade based on the following table.
|Numerical Grade|Letter Grade|
|    90 - 100   |      A     |
|    80 - 89    |      B     |
|    70 - 79    |      C     |
|    60 - 69    |      D     |
|     0 - 59    |      F     |


Input by ";" each numerical 3 grade(s) of the tests for the Mark Hovich (For instance, 80; 90; 50)
30;40;50

Student № 2
Input the first name
Timur
Input the last name
Rodich
Input by ";" each numerical 3 grade(s) of the tests for the Timur Rodich (For instance, 80; 90; 50)
50;60;70

Student № 3
Input the first name
Rodriges
Input the last name
Tuman
Input by ";" each numerical 3 grade(s) of the tests for the Rodriges Tuman (For instance, 80; 90; 50)
80;90;100

 Tables with results
|Mark Hovich||   40||    F|
|Timur Rodich||   60||    D|
|Rodriges Tuman||   90||    A|
```
