
using System;
using System.Linq;
class DataTypesAndMathClass {
  static void Main() {
    Console.WriteLine("Enter 5 grades separated by new line: ");
    double[] grades = new double[5];
    for (int i = 0; i < 5; i++)
    {
        grades[i]= Convert.ToDouble(Console.ReadLine());
    }
    
    double average = grades.Average();
    int round = (int)Math.Round(average);
    
    Console.WriteLine("The average is " + average + " and round off to " + round);
    
  }
}