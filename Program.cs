using System;


namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args) {
            
            Console.WriteLine("Lab 1 - Encapsulation");
            Console.WriteLine("Completed - Tishchenko Alexander");

            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            
            Complex c = new Complex() { Real = 3, Imag = 0.5 };
            Complex d = new Complex() { Real = 2, Imag = 0.8 };
            
            a.Add(b);
            b.Substract(a);
            c.Multiply(d);
            d.Divide(c);
            
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} - {1}i", b.Real, b.Imag);
            Console.WriteLine("c = {0} * {1}i", c.Real, c.Imag);
            Console.WriteLine("d = {0} / {1}i", d.Real, d.Imag);
            
            
        }
    }
}