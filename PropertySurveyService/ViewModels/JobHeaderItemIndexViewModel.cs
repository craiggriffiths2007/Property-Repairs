using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class JobHeaderItemIndexViewModel
    {
        public JobHeader? JobHeader { get; set; }
        public IEnumerable<SurveyItem>? SurveyItems { get; set; }

        public IEnumerable<PhotoImage>? Images { get; set; }
    }
}
