// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        double doubleVariable = 34.567839023;
        float floatVariable = 12.345f;
        double secondDoubleVariable = 8923.1234857;
        float thirdFloatVariable = 3456.091f;

        Console.WriteLine(doubleVariable);
        Console.WriteLine(floatVariable);
        Console.WriteLine(secondDoubleVariable);
        Console.WriteLine(thirdFloatVariable);
    }
}

