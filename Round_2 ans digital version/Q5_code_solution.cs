
using System;
using System.Collections;
interface Bank0
{

     void bankInfoPrint();
}

class Bank : Bank0
    {
        public void bankInfoPrint()
        {
            Console.WriteLine("bank account reg. request granted");
        }
    }

interface Loan0
{
	void LoanInfoPrint();

}
    class Loan : Loan0
    {
        public void LoanInfoPrint()
        {
            Console.WriteLine("Loan request granted.");
        }
    }
    class CostumerRequest : Bank0, Loan0
    {


    Bank obj1 = new Bank(); 
    Loan obj2 = new Loan(); 
  
    public void bankInfoPrint() 
    { 
        obj1.bankInfoPrint(); 
    } 
  
    public void LoanInfoPrint() 
    { 
        obj2.LoanInfoPrint(); 
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CostumerRequest p = new CostumerRequest();
            int x = 2;
            switch (x)
            {
                case 1:
                    p.bankInfoPrint();
                
                break;

		case 2:
		    p.bankInfoPrint();
                    p.LoanInfoPrint();
                    break;
                default:
                    break;
            }
        }
     }
