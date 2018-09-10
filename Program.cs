using System;

namespace InterestRate
{
    class Program
    {
        static double InterestRate(double principal, double rate, double years, double time)
        {
            double amount; 
            amount = principal * Math.Pow(1 + rate / years, years * time);
            return amount;
        }


              static void Main(string[] args)
        {
            double principal;
            double rate;
            double years;
            double time;
            double result = 0.0;
            double age;
            double credit;
            double total = 0.0;

            Console.WriteLine("Please enter your principal amount");
            principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your annual intrest rate");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the times per year the intrest was compounded");
            years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the total time");
            time = Convert.ToDouble(Console.ReadLine());


             result = InterestRate(principal, rate, years, time);


            // age group
            Console.WriteLine("Please enter your age group. 1 = 18-29, 2 = 30-59, 3 = 60 and up");
            age = Convert.ToDouble(Console.ReadLine());

            switch (age)
            {
                case 1: total = result + 1.0;
                break;

                case 2: total = result + 3.0;
                break;

                case 3: total = result + 5.0;
                break;

            }

            Console.WriteLine("Please enter your credit score? 1 = 0-580, 2 = 581-669, 3 = 670-739, 4 = 740-850");
            credit = Convert.ToDouble(Console.ReadLine());

            switch (credit)
            {
                case 1: total = result + 10.0;
                break;

                case 2: total = result + 6.0;
                break;

                case 3: total = result + 4.0;
                break;

                case 4: total = result + 2.0;
                break;
            }

            Console.WriteLine("Are you a male or female");
            String gender = (Console.ReadLine());

            switch (gender)
            {
                case "male": total = result + 4.0;
                break;

                case "female": total = result + 2.0;
                break;

            }


            
            result = InterestRate(principal, rate, years, time);
            Console.WriteLine("Your interest rate is {0}", total);
        
        }
    }
}
