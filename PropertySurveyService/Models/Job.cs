using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertySurveyService.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        [Display(Name = "Contract Code")]
        public string? ContractCode { get; set; }

        [Display(Name = "Job Type")]
        public enum_job_type JobType { get; set; } // 0 - Survey 1 - Fitting

        [Display(Name = "Diary Date")]
        [DataType(DataType.Date)]

        public DateTime DiaryDate { get; set; } 

        [Display(Name = "Job Time")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Display(Name = "Incident Date")]
        public DateTime IncidentDate { get; set; } = DateTime.Today;

        [Display(Name = "Insurance Company Name")]
        public string? InsuranceCompanyName { get; set; } = "";

        [Display(Name = "Cause of damage")]
        public string? CauseOfDamage { get; set; } = "";

        [Display(Name = "Damage")]
        public string? DamageDesc { get; set; }
        [Display(Name = "Instructions")]
        public string? Instructions { get; set; }

        [Display(Name = "Request Repudiation")]
        public bool bRequestRepudiation { get; set; } = false;
        public int? CustomerId { get; set; }

        public int? AgentId { get; set; }

        public Agent? Agent { get; set; }

        public Customer? Customer { get; set; }

        public Contract? Contract { get; set; }
        /*
        public Job()
        {
            Date = DateTime.Today;
            Time = DateTime.Now;
        }*/
    }

    public class GetDataDTO
    {
        public string? AgentCode { get; set; }

        public string? Password { get; set; }

        public string? Filename { get; set; } // for images

        public string? BranchCode { get; set; } // for vehicle checks

        public string contract_number { get; set; } = ""; // for spot checks
    }

    public class JobDTO
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int iRecordType { get; set; }
        public string ContractCode { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Today;
        public string Time { get; set; } = "";
        public string EndTime { get; set; } = "";
        public string Name { get; set; } = "";
        public string Add1 { get; set; } = "";
        public string Add2 { get; set; } = "";
        public string Add3 { get; set; } = "";
        public string Postcode { get; set; } = "";
        public string Phone1 { get; set; } = "";
        public string Phone2 { get; set; } = "";
        public string Phone3 { get; set; } = "";

        public string IncidentDate { get; set; } = "";
        public string CauseOfDamage { get; set; } = "";
        public string DamageDesc { get; set; } = "";
        public string Instructions { get; set; } = "";
        [DisplayName("Insurance Company")]
        public string InsuranceCompanyName { get; set; } = "";
        public bool bRequestRepudiation { get; set; } = false;
        public JobDTO() { }
        public JobDTO(Job jobItem,Customer custItem)
        { 
            

            (Id, ContractId, ContractCode, Date, Time, EndTime, Name, Add1, Add2, Add3, Postcode, Phone1, Phone2, Phone3, DamageDesc, Instructions, CauseOfDamage, IncidentDate, bRequestRepudiation, InsuranceCompanyName) =

            (jobItem.Id, jobItem.ContractId, jobItem.ContractCode, jobItem.DiaryDate, jobItem.Time.ToShortTimeString(), jobItem.Time.AddHours(1).ToShortTimeString(), custItem.Name,
                custItem.Add1, custItem.Add2, custItem.Add3, custItem.Postcode, custItem.Phone1,
                custItem.Phone2, custItem.Phone3, jobItem.DamageDesc, jobItem.Instructions, jobItem.CauseOfDamage, jobItem.IncidentDate.ToShortDateString(),jobItem.bRequestRepudiation, InsuranceCompanyName);

            ContractCode = ContractCode;

        }
    }

}
