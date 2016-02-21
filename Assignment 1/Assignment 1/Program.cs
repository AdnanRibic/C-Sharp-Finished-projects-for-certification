using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string birthDate;
            string addressLineOne;
            string addressLineTwo;
            string city;
            string stateProvince;
            int zipPostal;
            string country;

            firstName = "Adnan";
            lastName = "Ribic";
            birthDate = "31/01/1989";
            addressLineOne = "Turbinveien 20";
            addressLineTwo = "Prve Zenicke Brigade 15d";
            city = "Oslo";
            stateProvince = "Oslo area";
            zipPostal = 195;
            country = "Norway";


            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthDate);
            Console.WriteLine(addressLineOne);
            Console.WriteLine(addressLineTwo);
            Console.WriteLine(city);
            Console.WriteLine(stateProvince);
            Console.WriteLine(zipPostal);
            Console.WriteLine(country);


        }
    }
}
