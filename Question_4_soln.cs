using System;
using System.Collections.Generic;

namespace spaceTWO
{
    class TWO {         
        static void Main(string[] args)
        {
/////////////part 1   //////////////////////////////////////////////////////////////////////

Console.WriteLine("Input Temperature:");
double user_temperature = Convert.ToDouble(Console.ReadLine());

/////////////part 2 EXTRACTION OF HEXADECIMAL NUMBERS FROM STRINGS /////////////////////////

//extract x1 hexadecimal
       string string1 = "var1/ext23/gainX1 0X14";
       // Location of the number 0
       int charPos1   = string1.IndexOf("0");
       string hexX1   = string1.Substring(charPos1);
       // to decimal conversion
       int int_X1     = Convert.ToInt32(hexX1, 16);       


//extract y1 hexadecimal 
       string string2 = "var2/ext56/tempY1 0X5F";
       // Location of the number 0  
       int charPos2   = string2.IndexOf("0");      
       string hexY1   = string2.Substring(charPos2);
       // to decimal conversion
       int int_Y1     = Convert.ToInt32(hexY1, 16);       

//extract x2 hexadecimal
       string string3 = "var1/ext23/gainX2 0X3C";
       // Location of the number 0  
       int charPos3   = string3.IndexOf("0");      
       string hexX2   = string3.Substring(charPos3);
       // to decimal conversion
       int int_X2     = Convert.ToInt32(hexX2, 16);       

//extract y2 hexadecimal
       string string4 = "var2/ext56/tempY2 0X2A";
       // Location of the number 0  
       int charPos4   = string4.IndexOf("0");
       string hexY2   = string4.Substring(charPos4);
       // to decimal conversion
       int int_Y2     = Convert.ToInt32(hexY2, 16);


/////////GRADIENT CALCULATION//////////////////////////////////////

       //Gradient = change in Y / change in X/////

int change_Y = int_Y2 - int_Y1;
int change_X = int_X2 - int_X1;

int gradient = change_Y / change_X;

// y intercept is at x = 0///////////////////////////////////
// Using the two points ie (x1,y1) and (x2,y2) on linear equation y = mx + b 
// leads to 2 equations 95 = 20m + b and 42 = 60m + b
// upon solving this system of equations using substitution method
// the value of m = -(53/40) and the value of b = 121.5

//from y = mx + b, y intercept occures at x = 0
// meaning y = 121.5
double Y_intercept = 0.00 + 121.5;

//printing value of gradient
Console.WriteLine("Gradient value is :  {0}", gradient);

// printing value of the intercept
Console.WriteLine("Intercept value is :  {0}", Y_intercept);


//from y = mx +b equation //////////////////////////
// gain x = (y - b)/m 

double gain = (user_temperature - 121.5)/(-1.33);



// in case the temperature is 25 assumming gain to be gain_25

double gain_25 = (25 - 121.5)/(-1.33);
Console.WriteLine("The gain at temperature 25 is :  {0}", gain_25);


	}
    }
}
