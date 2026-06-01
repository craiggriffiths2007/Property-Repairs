using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class ItemDetailsViewModel
    {
        public Material? Material { get; set; }
        public Aluminium? Aluminium { get; set; }
        public Bifolding? Bifolding { get; set; }
        public Composite? Composite { get; set; }
        public Conservatory? Conservatory { get; set; }
        public Garage? Garage { get; set; }
        public Glass? Glass { get; set; }
        public Greenhouse? Greenhouse { get; set; }
        public Lockmech? Lockmech { get; set; }
        public Panel? Panel { get; set; }
        public Timber? Timber { get; set; }
        public UPVC? UPVC { get; set; }

  
        public IEnumerable<PhotoImage>? Images { get; set; }
    }
}
