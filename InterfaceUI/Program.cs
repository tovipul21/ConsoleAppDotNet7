using InterfaceDemoLibrary;
using System.Runtime.InteropServices;

namespace InterfaceUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "Test1".Substring(0,4);
            //string s2 = "Test1";
            //string s3 = "Test1";
            //string s4 = s1;
            
            //Console.WriteLine(s1);
            //Console.WriteLine($"{s1 == s2} {s1.Equals(s2)}");
            //Console.WriteLine($"{s2 == s3} {s2.Equals(s3)}");
            //Console.WriteLine($"{s1 == s3} {s1.Equals(s3)}");

            List<IProductModel> productList = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (var product in productList)
            {
                product.ShipItem(customer);

                if (product is DigitalProductModel digital)
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left");
            }
        }

        static List<IProductModel> AddSampleData()
        {
            List<IProductModel> productModels =
            [
                new PhysicalProductModel() { Title = "P - .Net Architecture Book" },
                new PhysicalProductModel() { Title = "P - Azure Architecture Book" },
                new PhysicalProductModel() { Title = "P - C# Fundamentals" },
                new PhysicalProductModel() { Title = "P - Azure Fundamentals" },
                new DigitalProductModel() { Title = "D - e Course for C#", HasOrderBeenCompleted = false },
            ];

            return productModels;
        }

        static CustomerModel GetCustomer() 
        {
            CustomerModel customer = new CustomerModel
            {
                FirstName = "Vipul",
                LastName = "Mehta",
                EmailAddress = "someemail@gmail.com",
                PhoneNumber = "1234567890",
                City = "Houston",
                State = "TX"
            };

            return customer;
        }
    }
}
