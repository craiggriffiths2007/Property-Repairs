namespace PropertySurveyService.Models
{
    public enum VehicleType
    {
        DeliveryHGV,    
        DeliveryVan,
        FitterVan,
        SalesCar
    }
    public class Vehicle
    {
        public int Id { get; set; }
        public int BranchId { get; set; } = 0;
        public string? Name { get; set; } = null;
        public string? Registration { get; set; } = null;
        public string? Description { get; set; } = null;
        public VehicleType Type { get; set; }

        public Branch? Branch { get; set; }
    }
}
