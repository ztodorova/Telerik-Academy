//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesAritmetic
{
    static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine("intValue= {0}, doubleValue= {1}", intValue, doubleValue);

        int? intValue2 = intValue + 5;
        double? doubleValue2 = doubleValue + 7.25;
        Console.WriteLine("intValue2= {0}, doubleValue2= {1}", intValue2, doubleValue2);

    }
}

