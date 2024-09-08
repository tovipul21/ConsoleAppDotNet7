namespace InterfaceDemoLibrary
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; set; }

        void IProductModel.ShipItem(CustomerModel customer)
        {
            if (!HasOrderBeenCompleted) {
                Console.WriteLine($"Simulating shipping {Title} to {customer.FirstName} {customer.LastName} in {customer.City},{customer.State}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
