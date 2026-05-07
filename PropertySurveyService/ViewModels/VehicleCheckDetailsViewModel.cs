using PropertySurveyService.Controllers;
using PropertySurveyService.Models;


namespace PropertySurveyService.ViewModels
{
    public class VehicleCheckDetailsViewModel
    {
        public DeliveryHGV? DeliveryHGV { get; set; }
        public DeliveryVan? DeliveryVan { get; set; }
        public FitterVan? FitterVan { get; set; }
        public SalesCar? SalesCar { get; set; }

        public IEnumerable<PhotoImage>? Images { get; set; }

    }
}
