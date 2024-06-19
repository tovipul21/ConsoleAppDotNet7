namespace InterfaceDemoLibrary
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; set; }

        void IProductModel.ShipItem(CustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
