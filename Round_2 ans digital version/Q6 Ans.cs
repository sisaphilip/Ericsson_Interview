using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfCircle
{
public sealed class Circle
    {
 private double radius;
 private double CircleArea;
 
static  Main(string[] args)
{
        
        Console.WriteLine("Enter radius of a circle");
        radius = Convert.ToDouble(Console.ReadLine());
                
        
       CircleArea (double radius)
        {       
                return (double)(math.PI * radius * radius);  // area of a circle pir^2
        }
        
        Func<double, double> op = new Func<double, double>(CircleArea); 
       
        
        
          public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
        
        
    }
}
