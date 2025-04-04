//sisaphilip@gmail.com



using System;
using System.Collections.Generic;

namespace spacethree
{
    class three {         
        static void Main(string[] args)
        {

//command to set freq               
//command ot set output dbm    

//output on                         OUTPut:ALL:STATe 0 

Console.WriteLine("      " );


Console.WriteLine("Welcome R&S SMA100B user" );


Console.WriteLine("Select a number, 1-3 for the corresponding SCPI command " );
Console.WriteLine("      " );
Console.WriteLine("1 for set frequency in GHz" );
Console.WriteLine("2 for Set output level in dBm with two decimals" );
Console.WriteLine("3 for enable output" );

 Console.WriteLine("      " );

//switch statements

int userValue = Convert.ToInt32(Console.ReadLine());

switch (userValue)
{ 
    case 1:
        Console.WriteLine("FREQuency:CW GHZ");
        break;
    case 2:
        Console.WriteLine("POWer:LOG dbm");
        break;
    case 3:
        Console.WriteLine("OUTPut:ALL:STATe 0");
        break;
    

    default:
        Console.WriteLine("Unknown value");
        break;
}

	}
    }
}

