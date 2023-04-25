using System;
using System.Net;

namespace AddressBookProductReviewManagementProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Address Book Product Review Management Program Problem.");
                Console.WriteLine("Choose Option to Perform\n1.Add contacts and Display Records\n2.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                List<Contacts> contacts = new List<Contacts>();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Contact Details given in Table");
                        Console.WriteLine("------------------------------");
                        contacts.Add(new Contacts { FirstName = "Soma", LastName = "Shekar", Address = "KGF", City = "Kolar", State = "KA", Zip = 563232, PhoneNumber = 9808789778, Email = "Somu@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "Santosh", LastName = "Kumar", Address = "Delhi", City = "Delhi", State = "DH", Zip = 545232, PhoneNumber = 8972789778, Email = "San@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "Anil", LastName = "Kumar", Address = "Banglore", City = "Banglore", State = "KA", Zip = 344432, PhoneNumber = 7808789778, Email = "Ani@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "Jagan", LastName = "Reddy", Address = "Hydrabad", City = "Hydrabad", State = "AP", Zip = 784732, PhoneNumber = 6808789778, Email = "Jagan@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "Ganesh", LastName = "Aryan", Address = "Manglore", City = "Manglore", State = "KA", Zip = 454332, PhoneNumber = 808789778, Email = "Ganesh@gmail.com" });
                        foreach (var data in contacts)
                        {
                            Console.WriteLine("FirstName:-"+ data.FirstName + " " + "LastName:-" + data.LastName + " " + "Address:-" + data.Address + " " + "City:-" + data.City + " " + "State" + data.State + " " + "Zip:-" + data.Zip + " " + "PhoneNumber:-" + data.PhoneNumber + " " + "Email:-" + data.Email);
                        }
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}

