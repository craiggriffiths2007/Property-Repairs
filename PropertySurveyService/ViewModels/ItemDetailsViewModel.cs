using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class ItemDetailsViewModel
    {
        public ItemAssembly? Assembly { get; set; }
        public Bifolding? Bifolding { get; set; }
        public Composite? Composite { get; set; }
        public Conservatory? Conservatory { get; set; }
        public Garage? Garage { get; set; }
        public Glass? Glass { get; set; }
        public Greenhouse? Greenhouse { get; set; }
        public Lockmech? Lockmech { get; set; }
        public Panel? Panel { get; set; }

        public IEnumerable<PhotoImage>? Images { get; set; }

    }
}
