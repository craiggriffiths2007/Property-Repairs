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

        public PhotoImage cleft { get; set; }
        public PhotoImage cright { get; set; }
        public PhotoImage cfront { get; set; }
        public PhotoImage cback { get; set; }

        public PhotoImage dleft { get; set; }
        public PhotoImage dright { get; set; }
        public PhotoImage dfront { get; set; }
        public PhotoImage dback { get; set; }
        public PhotoImage drv_signature { get; set; }
        public PhotoImage chk_signature { get; set; }

    }
}
