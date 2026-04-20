//Why Exception handling is important?
//So that we can control the flow of the program and avoid crashing of the program.
//It also helps us to log the error and debug the code.

//Step forimplementing Exception handling
//Step 1: Identify the code that may throw an exception. and include it in try block.
//Step 2: Catch the exception using catch block and handle it accordingly.
//Step 3: Finally block is optional and it will always execute regardless of whether an exception is thrown or not.
//It is used to clean up resources or perform any necessary finalization.
//Step 4: In case there are multiple catch blocks,
//the most specific exception should be caught first and then the more general exceptions should be caught later.
//Note: Exception class is the base class for all exceptions in C#.
//It is recommended to catch specific exceptions rather than catching the base Exception class,
//as it allows for better error handling and debugging.

using System;
//types of exceptions
//1. userdefined exceptions
//2. system defined exceptions
//example of system defined exceptions
Console.WriteLine("Enter a number: ");
try
{
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered: {number}");

}
catch (FormatException ex)
{
    Console.WriteLine("Invalid input format. Please enter a valid number.");
}
catch (OverflowException ex)
{
    Console.WriteLine("The number you entered is too large or too small.");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
}


