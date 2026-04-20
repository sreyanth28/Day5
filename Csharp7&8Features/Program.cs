using System;
using System.Linq.Expressions;
//C#Features in 7 and 8 versions
//1) Tuples and Out variables:
//2) Pattern Matching:
//3) Local Functions:
//4) Async Streams:
//5) Nullable Reference Types:
//C#Features in 9 and 10 versions
//1) Records:
//2) Init-only properties:
//3) Top-level statements:
//4) Target-typed new expressions:
//5) Pattern Matching Enhancements:

//C# we have tuples for returning multiple values from a method. In C# 7.0, we can use tuples to return
//multiple values from a method without creating a custom class or struct.
//for example,
(double area, double perimeter) CalculateRectangle(double length, double width)
{
    double area = length * width;
    double perimeter = 2 * (length + width);
    return (area, perimeter);
}
//in contrast to a single return type, we can return both area and perimeter as a tuple.
//This allows us to return multiple values from a method without creating a custom class or struct.
//it simlifies the code and makes it more readable. We can also use out variables to return multiple values from a method.

CalculateRectangle(5, 3);
CalculateRectangle(5, 4);
Console.WriteLine("Output for tuple implementation: "+CalculateRectangle(10,7));


//Pattern Matching: In C# 7.0, we can use pattern matching
//to check the type of an object and extract its value in a single statement. For example,

object obj = "Hello, World!";
if(obj is string str)
{
    Console.WriteLine($"The string is: {str}");
}
else
{
    Console.WriteLine("The object is not a string.");
}

Console.WriteLine("Output of pattern matching: "+obj);

//Scenario for implemeting Pattern matching with Switch statement:
//Step 1: We will take input from the user and check if it is an integer, a double, or a string.
//Step 2: We will use a switch statement to match the input against different patterns and execute
//different code based on the pattern that matches.
//Step 3: We will also use pattern matching with tuples to deconstruct them and extract values.
//Step 4: Showing output of pattern matching with properties to check if an object has certain

Console.WriteLine("Enter a value:");
string input = Console.ReadLine();
switch (input)
{
    case int i:
        Console.WriteLine($"The input is an integer: {i}");
        break;
    case double d:
        Console.WriteLine($"The input is a double: {d}");
        break;
    case string s:
        Console.WriteLine($"The input is a string: {s}");
        break;
    default:
        Console.WriteLine("The input is of an unknown type.");
        break;
}


//We have to create Program covering top 10 C# 7 & 8 features 
//We have to explore Exception and File handling in C#
//We will have demo based on delegates and events in C#
//Refelection and Attributes in C#

//Solid principles and Design patterns in C#