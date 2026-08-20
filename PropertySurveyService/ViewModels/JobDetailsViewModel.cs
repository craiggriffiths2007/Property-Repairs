using PropertyRepairs.Models;

namespace PropertyRepairs.ViewModels
{
    public class JobDetailsViewModel
    {
        public List<JobHeaderIndex>? JobHeaderIndex { get; set; }

        public Job? Job { get; set; }
    }
}
