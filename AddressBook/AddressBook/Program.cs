using System;
using System.Collections;
using System.Dynamic;

namespace AddressBook
{


    class AddressBook
    {

        static void Main(string[] args)
        {
            ArrayList address = new ArrayList { };
            Boolean Menu = true;
            
            do
            {

                Console.WriteLine("Enter Your First Name");
                string name = "FirstName";
                name = Console.ReadLine();
                string valuestring = name;

                Console.WriteLine("Enter Your last Name");
                string name1 = "LastName";
                name1 = Console.ReadLine();
                string valuestring1 = name1;

                Console.WriteLine("Enter YourAddress City");
                string name2 = "Address City";
                name2 = Console.ReadLine();
                string valuestring2 = name2;

                Console.WriteLine("Enter Your Phone Number");
                string name3 = "Phone no";
                name3 = Console.ReadLine();
                string valuestring3 = name3;

                Console.WriteLine("Enter Your postal zip");
                string name4 = "PostalZip";
                name4 = Console.ReadLine();
                string valuestring4 = name4;

                Console.WriteLine("Enter Your Email");
                string name5 = "Email";
                name5 = Console.ReadLine();
                string valuestring5 = name5;


                Console.WriteLine("First Name You Entere:" + valuestring);
                Console.WriteLine("Last Number You Entere:" + valuestring1);
                Console.WriteLine("Address City You Entere:" + valuestring2);
                Console.WriteLine("Phone number You Entere:" + valuestring3);
                Console.WriteLine("Postal code You Entere:" + valuestring4);
                Console.WriteLine("email You Entere:" + valuestring5);




            }

            while (Menu == true);
        }
    }
}
