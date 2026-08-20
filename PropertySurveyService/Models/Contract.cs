using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyRepairs.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Contract Code")]
        public string? ContractCode { get; set; }

        public int? CustomerId { get; set; }

        public Customer? Customer { get; set; }

        // Map to SQL "date" (no time) and render as date-only in editors
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayName("Incident Date")]
        public DateTime IncidentDate { get; set; }
        [DisplayName("Damage Description")]
        public string DamageDescription { get; set; }
        [DisplayName("Cause of Damage")]
        public string CauseOfDamage { get; set; }

        [DisplayName("Insurance Company")]
        public string InsuranceCompanyName { get; set; } = "";

        [DisplayName("Excess")]
        public string Excess { get; set; } = "";

        [DisplayName("Policy Number")]
        public string PolicyNumber { get; set; } = "";
    }
}
