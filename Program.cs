/* Lab 5
* 
* Diana Guerrero
* Professor Aydin
* BCS 426 
* 3/19/21
* 
* Partner(s): Patrick Adams
* Resource(s): 
* 1. https://drive.google.com/drive/folders/13-xSS9a-eItJRtYWShb3g8pUbvh7mE45
*/

using System;

namespace BCS426Lab5
{
    public class ComplexNumber
    {
        public double RealPart 
        { 
            get; 
            set; 
        }
        public double ImaginaryPart 
        { 
            get; 
            set; 
        }

        public ComplexNumber(double r = -1, double i = -1)
        {
            RealPart = r;
            ImaginaryPart = i;
        }
        public override string ToString() => $"{RealPart} + {ImaginaryPart}i";

        // Override operator + for class ComplexNumber
        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right) =>
                new ComplexNumber(left.RealPart + right.RealPart, left.ImaginaryPart + right.ImaginaryPart);

        // Override operator == for class ComplexNumber
        public static bool operator ==(ComplexNumber left, ComplexNumber right)
        {
            return left.RealPart == right.RealPart && left.ImaginaryPart == right.ImaginaryPart;
        }

        // Override operator != for class ComplexNumber
        public static bool operator !=(ComplexNumber left, ComplexNumber right) =>
                !(left == right);
    }

    class Program
    {
        static void Main()
        {
            var complexNumber1 = new ComplexNumber(10, 20);
            var complexNumber2 = new ComplexNumber(100, 200);
            ComplexNumber result;

            Console.WriteLine("First Complex Number: \n" + complexNumber1);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Second Complex Number: \n" + complexNumber2);
            Console.WriteLine("-------------------------------");

            result = complexNumber1 + complexNumber2;
            Console.WriteLine("Adding Both Complex Numbers: \n" + result);
            Console.WriteLine("-------------------------------");

            if (complexNumber1 == complexNumber2)
            {
                Console.WriteLine("The two numbers are the SAME");
            }
            else
            {
                Console.WriteLine("The two numbers are NOT the SAME");
            }
            Console.WriteLine("-------------------------------");

            // The operators above work because if you were to change the complex numbers you would see if the numbers are the same or not
        }
    }
}