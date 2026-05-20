using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class HeaderIndexViewModel
    {
        public JobHeader? Header { get; set; }
        public IEnumerable<SurveyItem>? SurveyItems { get; set; }

        public IEnumerable<PhotoImage>? Images { get; set; }
    }
}
