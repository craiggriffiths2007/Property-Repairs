using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class JobIndexViewModel
    {
        public IEnumerable<Job>? Jobs { get; set; }
        public List<JobHeader> Headers { get; set; } = new();
        public HashSet<string> ContractCodesWithHeaders { get; set; } = new();
        public int Year { get; set; }
        public int Month { get; set; }
        public string ViewMode { get; set; } = "month";
        public DateTime WeekStartDate { get; set; }
        public string? SearchQuery { get; set; }
        // For the All view: a date range to display
        public DateTime AllStartDate { get; set; }
        public DateTime AllEndDate { get; set; }
    }
}
