using System;
namespace Kalkulator
{
    class Program
    {
        static void Main (string[] args) 
        {
            //membuat menu pilihan kalkulator
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");

            //masukkan pilohan disini
            Console.WriteLine();
            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input : \t");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st input : \t");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is : \t");

            //pengkondisian pilihan menu
            if (pilihan==1) 
            {
                Console.Write(angka1+angka2);
            }
            else if (pilihan==2) 
            {
                Console.Write(angka1-angka2);
            }
            else if (pilihan==3) 
            {
                Console.Write(angka1*angka2);
            }
            else if (pilihan==4) 
            {
                Console.Write(angka1/angka2);
            }
        }
    }
}