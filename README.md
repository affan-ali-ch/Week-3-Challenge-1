Task 1: ClockType Class
Suppose, that we want to define a class to implement the time of day in a program.
Because a clock gives the time of day, let us call this class clockType.
Furthermore, to represent time in computer memory, we use three int variables: one to
represent the hours, one to represent the minutes, and one to represent the seconds.
Suppose these three variables are: int hr; int min; int sec;
We also want to perform the following operations on the time:
1. Set the time(seconds, minutes, hours). (default Constructor and parameterized
constructors)
2. Print the time.
3. Increment the time by one second.
4. Increment the time by one minute.
5. Increment the time by one hour.
6. Compare the two times for equality.
● With manual timings
● With passed object’s timings

Challenge # 1:
Task: Write a program that performs the following:
Enhance Programming Exercise by adding functions to the class clockType so that a
program that uses this class can perform the following operations:

a. Returns the elapsed time of the day of a clock in seconds.

b. Returns the remaining time of the day to a clock in seconds.

c. Determines and outputs how far apart in time two clocks are. (pass one parameter of
class clockType)

d. Outputs the time in the form hr:min: sec.

Elapsed time = current time - 00:00:00

Remaining time = 24:00:00 - a current time

