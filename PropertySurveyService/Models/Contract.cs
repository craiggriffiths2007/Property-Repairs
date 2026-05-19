using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }

        public string? ContractCode { get; set; }

        public int? CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public DateTime IncidentAdded { get; set; }

        public string DamageDescription { get; set; }

        public string CauseOfDamage { get; set; }
    }
}
