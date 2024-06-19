using InterfaceDemoLibrary;

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

            foreach (var product in productList)
            {
                Console.WriteLine($"The title of the product is {product.Title}");
            }


        }

        static List<IProductModel> AddSampleData()
        {
            List<IProductModel> productModels = new List<IProductModel>();
            productModels.Add(new PhysicalProductModel() { Title = "P - .Net Architecture Book" });
            productModels.Add(new PhysicalProductModel() { Title = "P - Azure Architecture Book" });
            productModels.Add(new PhysicalProductModel() { Title = "P - C# Fundamentals" });
            productModels.Add(new PhysicalProductModel() { Title = "P - Azure Fundamentals" });
            productModels.Add(new DigitalProductModel() { Title = "D - e Course for C#", HasOrderBeenCompleted = false });

            return productModels;
        }
    }
}
