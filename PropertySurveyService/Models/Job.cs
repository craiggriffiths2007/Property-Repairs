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


        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Job Time")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Display(Name = "Incident Date")]
        public DateTime IncidentDate { get; set; } = DateTime.Today;

        [Display(Name = "Insurance Company Name")]
        public string InsuranceCompanyName { get; set; } = "";

        [Display(Name = "Cause of damage")]
        public string CauseOfDamage { get; set; } = "";

        [Display(Name = "Damage")]
        public string DamageDesc { get; set; }
        [Display(Name = "Instructions")]
        public string Instructions { get; set; }

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

        public string ContractCode { get; set; } = ""; // for spot checks

        public string Note { get; set; } = "";  // for contract notes
    }

    public class JobContractDTO
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public enum_job_type JobType { get; set; } = enum_job_type.Survey;
        public string ContractCode { get; set; } = "";
        public DateTime DiaryDate { get; set; } = DateTime.Today;
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
        public List<ContractNote> ContractNotes { get; set; } = new List<ContractNote>();

        public JobContractDTO() { }
        public JobContractDTO(Job jobItem,Customer custItem)
        { 
            

            (Id, ContractId, ContractCode, DiaryDate, Time, EndTime, Name, Add1, Add2, Add3, Postcode, Phone1, Phone2, Phone3, DamageDesc, Instructions, CauseOfDamage, IncidentDate, bRequestRepudiation, InsuranceCompanyName, JobType) =

            (jobItem.Id, jobItem.ContractId, jobItem.ContractCode, jobItem.DiaryDate, jobItem.Time.ToShortTimeString(), jobItem.Time.AddHours(1).ToShortTimeString(), custItem.Name,
                custItem.Add1, custItem.Add2, custItem.Add3, custItem.Postcode, custItem.Phone1,
                custItem.Phone2, custItem.Phone3, jobItem.DamageDesc, jobItem.Instructions, jobItem.CauseOfDamage, jobItem.IncidentDate.ToShortDateString(),jobItem.bRequestRepudiation, jobItem.InsuranceCompanyName, jobItem.JobType);

        }

        public JobContractDTO(Contract contractItem, Customer custItem)
        {

            (Id, ContractId, ContractCode, Name, Add1, Add2, Add3, Postcode, Phone1, Phone2, Phone3, DamageDesc,CauseOfDamage, IncidentDate,  InsuranceCompanyName) =

            (contractItem.Id, contractItem.Id, contractItem.ContractCode, custItem.Name,
                custItem.Add1, custItem.Add2, custItem.Add3, custItem.Postcode, custItem.Phone1,
                custItem.Phone2, custItem.Phone3, contractItem.DamageDescription, contractItem.CauseOfDamage, contractItem.IncidentDate.ToShortDateString(), contractItem.InsuranceCompanyName);

        }
    }

}
