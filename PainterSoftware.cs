using System;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace PainterSoftware
{
    public class Calculation
    {
        double PricePerLitterOfGlossPaint = 10;
        double PricePerLitterOfSemiGlossPaint = 7;
        double TotalExpenses;
        double CostOfPaintUsed = 0;
        int LittersUsed = 0;
        double HoursWorked = 0;
        double ServiceCharge = 10;
        double ChargeForHoursWorked = 0;
        string Typeofpaint;
        string extras = "";
        //string extraCost = "";
        double ExtrasCosts = 0; 

        public void ChargeForPaint() //how much is customer charged for paint based on the type of paint and no. of litters used 
        {
            Console.WriteLine("How much paint was used: ");
            LittersUsed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please specify the paint: ");
            Typeofpaint = Console.ReadLine();

            if(Typeofpaint == "Gloss")
            {
                CostOfPaintUsed = PricePerLitterOfGlossPaint*LittersUsed;
                Console.WriteLine("the paint price is £" + CostOfPaintUsed + " for " + LittersUsed +"L of Gloss paint.");
            }
            else if (Typeofpaint == "Semmi-Gloss")
            {
                CostOfPaintUsed = PricePerLitterOfSemiGlossPaint*LittersUsed;
                Console.WriteLine("the paint price is £" + CostOfPaintUsed + " for " + LittersUsed +"L of semi-Gloss paint.");
            }
            else
            {
                Console.Write("Please specify Gloss or Semi-Gloss paint");
            }
            return;
        }

        public void TotalChargeForHoursWorked() //charge for hours worked 
        {
            Console.WriteLine("How many hours have you worked on the project? : ");
            HoursWorked = Convert.ToDouble(Console.ReadLine());
            ChargeForHoursWorked =  ServiceCharge*HoursWorked;
            Console.WriteLine("The Service charge is £" + ChargeForHoursWorked);
           return;
        }

        public void TotalCost() //total cost of paint and hours & maybe any other expenses
        { 
            Console.WriteLine("Any Extra expenses? : ");
            extras = Console.ReadLine();

            if(extras == "Yes") 
            {
                Console.WriteLine("What is the amount of extra cost : ");
                ExtrasCosts = Convert.ToDouble(Console.ReadLine()); //might not work  
                TotalExpenses = ChargeForHoursWorked + CostOfPaintUsed + ExtrasCosts;
                Console.WriteLine("the total fees is £" + TotalExpenses);
            }
            else
            {
                TotalExpenses = ChargeForHoursWorked + CostOfPaintUsed;
                Console.WriteLine("the total fees is £" + TotalExpenses);
            }
            return;
        } 

    }
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.ChargeForPaint();
            c.TotalChargeForHoursWorked();
            c.TotalCost();
        }

        
    }
}