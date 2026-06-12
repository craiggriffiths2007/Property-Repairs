using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class ContractDetailsViewModel
    {
        public Contract? Contract { get; set; }

        public IEnumerable<ContractNote> ContractNotes { get; set; } = new List<ContractNote>();
    }
}
