using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class VehicleCheckHeaderIndexViewModel
    {
        public VehicleCheckHeader? VehicleCheckHeader { get; set; }
        public IEnumerable<VehicleCheckVehicle>? VehicleCheckVehicles { get; set; }
    }
}
