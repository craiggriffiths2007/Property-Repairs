using Microsoft.EntityFrameworkCore;
using PropertyRepairs.Models;

namespace PropertyRepairs.ViewModels
{
    public class ContractDetailsViewModel
    {
        public Contract? Contract { get; set; }

        public IEnumerable<ContractNote> ContractNotes { get; set; } = new List<ContractNote>();

        public string Note { get; set; } = "";
    }
}
