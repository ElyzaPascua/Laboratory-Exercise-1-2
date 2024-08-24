
using System;
class DataType {
  static void Main() {
    Console.WriteLine("Enter the pieces of apple: ");
    int pcs = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter total price of " + pcs + " apple(s): ");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("================================================");
    Console.WriteLine("The total price of " + pcs + " apple(s) is " + price );
    Console.WriteLine("The value of original price is " + price);
    Console.WriteLine("The value of converted price is " + Math.Round(price));
    Console.WriteLine("================================================");
    
  }
}