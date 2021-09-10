using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter first number:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter another number:");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Sum =" + (num1 + num2));
    Console.WriteLine("Diff =" + (num1 - num2));
    Console.WriteLine("Product = " + (num1 * num2));
    Console.WriteLine("Quotant =" + (num1 / num2));
    Console.WriteLine("Remainder =" + (num1 % num2));
  }
}