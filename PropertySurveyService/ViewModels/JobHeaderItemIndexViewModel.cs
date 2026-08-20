using PropertyRepairs.Models;

namespace PropertyRepairs.ViewModels
{
    public class JobHeaderItemIndexViewModel
    {
        public JobHeader? JobHeader { get; set; }
        public IEnumerable<SurveyItem>? SurveyItems { get; set; }

        public IEnumerable<PhotoImage>? Images { get; set; }
    }
}
