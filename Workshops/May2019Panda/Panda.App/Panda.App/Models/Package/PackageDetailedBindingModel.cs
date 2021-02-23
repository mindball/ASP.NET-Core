namespace Panda.App.Models.Package
{
    public class PackageDetailedBindingModel    {
        
        
        public string Description { get; set; }
        
        public double Weight { get; set; }
        
        public string ShippingAddress { get; set; }
        
        public string Recipient { get; set; }

        public string PackageStatus { get; set; }
        
        public string EstimatedDeliveryDate { get; set; }
    }
}
