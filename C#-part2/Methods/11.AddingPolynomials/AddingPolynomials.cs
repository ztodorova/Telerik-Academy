//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

using System;

    class AddingPolynomials
    {
        static void Main()
        {
            Console.WriteLine("Enter first polynomial's coefficients separated by space: ");
            string[] firstInput = Console.ReadLine().Split(' ');
            int[] firstPolynomial = new int[firstInput.Length];
            for (int i = 0; i < firstInput.Length; i++)
            {
                firstPolynomial[i] = int.Parse(firstInput[i]);
            }

            Console.WriteLine("Enter second polynomial's coefficients separated by space: ");
            
            string[] secondInput = Console.ReadLine().Split(' ');
            int[] secondPolynomial = new int[secondInput.Length];
            for (int i = 0; i < secondInput.Length; i++)
            {
                secondPolynomial[i] = int.Parse(secondInput[i]);
            }
            

            int[] sumOfpolynomials = AddPolynomials(firstPolynomial, secondPolynomial);

            Console.WriteLine("Sum of polynomials' coeficients: \n{0}",string.Join(" ", sumOfpolynomials));


        }

        static int[] AddPolynomials(int[] first, int[] second)
        {
            int length = 0;
            
            if(first.Length>second.Length)
            {
                length = first.Length;    
            }
            else
            {
                length = second.Length;
            }
            int[] longer = new int[length];
            int[] sum = new int[length];
            if(first.Length>second.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (i < second.Length)
                    {
                        longer[i] = second[i];
                    }
                }

                for (int i = 0; i < length; i++)
                {
                    sum[i] = first[i] + longer[i];
                }


            }
            else //(second.Length>first.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (i < first.Length)
                    {
                        longer[i] = first[i];
                    }
                }

                for (int i = 0; i < length; i++)
                {
                    sum[i] = longer[i] + second[i];
                }

            }

            return sum;
        }

        

    }

