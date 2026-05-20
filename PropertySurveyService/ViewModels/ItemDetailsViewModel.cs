using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class ItemDetailsViewModel
    {
        public Frame? Frame { get; set; }
        public Aluminium? Alum { get; set; }
        public Bifolding? Bifold { get; set; }
        public Composite? Comp { get; set; }
        public Conservatory? Cons { get; set; }
        public Garage? Garage { get; set; }
        public Glass? Glass { get; set; }
        public Greenhouse? Green { get; set; }
        public Lockmech? Lockin { get; set; }
        public Panel? Panel { get; set; }
        public Timber? Timber { get; set; }
        public UPVC? UPVC { get; set; }

  
        public IEnumerable<PhotoImage>? Images { get; set; }
    }
}
