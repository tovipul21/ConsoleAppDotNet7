namespace InterfaceDemoLibrary
{
    public class DigitalProductModel : IProductModel, IDigitalProductModel
    {
        public string? Title { get; set; }
        public int TotalDownloadsLeft { get; private set; } = 5;
        public bool HasOrderBeenCompleted { get; set; }

        public void ShipItem(CustomerModel customerModel)
        {
            Console.WriteLine("Test");

            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Simulating email {customerModel.EmailAddress}");
            }
        }
    }
}
