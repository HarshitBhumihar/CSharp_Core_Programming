using System;

namespace ConsoleApp1
{
    class EmployeeWageProblem1
    {
        static void Main(string[] args)
        {
            double basicPay, houseRent, da, pf, netSalary;

            Console.Write("Enter Basic Pay: ");
            basicPay = Convert.ToDouble(Console.ReadLine());


            houseRent = basicPay * 0.20;
            da = basicPay * 0.10;


            pf = basicPay * 0.12;


            netSalary = basicPay + houseRent + da - pf;

            Console.WriteLine("houseRent = " + houseRent);
            Console.WriteLine("DA = " + da);
            Console.WriteLine("PF = " + pf);
            Console.WriteLine("Net Salary = " + netSalary);
        }
    }

}