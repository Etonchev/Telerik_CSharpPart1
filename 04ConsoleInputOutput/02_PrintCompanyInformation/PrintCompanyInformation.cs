using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company info");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneCompany = Console.ReadLine();
            Console.Write("Enter fax number :");
            string fax = Console.ReadLine();
            Console.Write("Enter web site: ");
            string url = Console.ReadLine();
            Console.WriteLine("Manager info");
            Console.Write("Enter first name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter phone number: ");
            string phoneManager = Console.ReadLine();

            Console.WriteLine("\nCompany: {0}, {1}, {2}, {3}, {4}", name, address, phoneCompany, fax, url);
            Console.WriteLine("Manager: {0}, {1}, {2}, {3}", fname, lname, age, phoneManager);
        }
    }
}