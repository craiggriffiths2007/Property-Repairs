using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class JobDetailsViewModel
    {
        public List<JobHeaderIndex>? JobHeaderIndex { get; set; }

        public Job? Job { get; set; }
    }
}
