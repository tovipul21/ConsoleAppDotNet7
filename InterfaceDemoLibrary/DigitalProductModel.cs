namespace InterfaceDemoLibrary
{
    public class DigitalProductModel : IProductModel, IDigitalProductModel
    {
        public string? Title { get; set; }
        public int TotalDownloadsLeft { get; private set; } = 5;
        public bool HasOrderBeenCompleted { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Simulating emailing {Title} to { customer.EmailAddress }");

                TotalDownloadsLeft -= 1;

                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
