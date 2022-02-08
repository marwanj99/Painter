using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace PainterSoftware
{
    public class Calculation
    {
        double PricePerLiterPaint;
        double TotalExpenses;
        double CostOfPaintUsed;
        double LitersUsed;
        double HoursWorked;
        double ServiceCharge = 10;
        double ChargeForHoursWorked;
        string Typeofpaint;
        string extras = "";
        //string extraCost = "";
        double ExtrasCosts;
        double Length;
        double Height; 
        double TotalArea;
        double Area;


        public void CalculateArea() //area of wall to figure how much paint to use 
        {
            //int i = 1;

            Console.WriteLine("how many areas are you painting?: ");
            int x = Convert.ToInt32(Console.ReadLine());

            double [] CollectionArea = new double[x]; 

            for(int i = 1 ; i<=x; i++ )
            {
                Console.WriteLine("What is the length of wall " + i + " in meters square: ");
                Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the Height of wall " + i + " in meters square: ");
                Height = Convert.ToDouble(Console.ReadLine());
                Area = Length*Height;
                CollectionArea [i] = Area;
                TotalArea += CollectionArea[i];
            }
            LitersUsed = TotalArea*0.1;
            Console.WriteLine("There will be " + LitersUsed + "L needed for this project.");
            return;
        }
        public void ChargeForPaint() //how much is customer charged for paint based on the type of paint and no. of litters used 
        {           

            Console.WriteLine("We have a selection of Gloss, Semmi-Gloss or matte paints \n Please specify the type paint you want: ");
            Typeofpaint = Console.ReadLine();

            switch (Typeofpaint)
            {
                case "Gloss":
                    PricePerLiterPaint = 10;
                    CostOfPaintUsed = PricePerLiterPaint*LitersUsed;
                    Console.WriteLine("the paint price is £" + CostOfPaintUsed + " for " + LitersUsed +"L of Gloss paint.");
                break;

                case "Semmi-Gloss":
                    PricePerLiterPaint = 7;
                    CostOfPaintUsed = PricePerLiterPaint*LitersUsed;
                    Console.WriteLine("the paint price is £" + CostOfPaintUsed + " for " + LitersUsed +"L of semi-Gloss paint.");
                break;

                case "Matte":
                PricePerLiterPaint = 13;
                    CostOfPaintUsed = PricePerLiterPaint*LitersUsed;
                    Console.WriteLine("the paint price is £" + CostOfPaintUsed + " for " + LitersUsed +"L of Matte paint.");
                break;

                default:
                    Console.Write("Please specify Gloss, Semi-Gloss or Matte paint \n");
                break;

            }


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
            else if (extras == "no")
            {
                TotalExpenses = ChargeForHoursWorked + CostOfPaintUsed;
                Console.WriteLine("the total fees is £" + TotalExpenses);
            }
            else
            {
                Console.WriteLine("please specify yes or no for extra expenses \n");
            }
            return;
        } 

    }
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.CalculateArea();
            c.ChargeForPaint();
            c.TotalChargeForHoursWorked();
            c.TotalCost();
        }

        
    }
}