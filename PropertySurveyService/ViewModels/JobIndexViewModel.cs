using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class JobIndexViewModel
    {
        public IEnumerable<Job>? Jobs { get; set; }
        public IEnumerable<Header>? Headers { get; set; }
        public HashSet<string> ContractCodesWithHeaders { get; set; } = new();
        public int Year { get; set; }
        public int Month { get; set; }
        public string ViewMode { get; set; } = "month";
        public DateTime WeekStartDate { get; set; }
    }
}
