using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PropertySurveyService.Models
{
    public class SpotChecks
    {
        int Id { get; set; }

        int JobId { get; set; }

        [Display(Name = "Job Date")]
        [DataType(DataType.Date)]

        public DateTime Date { get; set; }

        [Display(Name = "Job Time")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Display(Name = "Damage")]
        public string? DamageDesc { get; set; }
        [Display(Name = "Instructions")]
        public string? Instructions { get; set; }

        string Name { get; set; }

        string Add1 { get; set; }
        string Add2 { get; set; }
        string Add3 { get; set; }
        string Add4 { get; set; }
        string Pcode { get; set; }
        string JobInstructions { get; set; }

        string Comments { get; set; }

        /*
        [DisplayName("Spot Check Fitter")]
        public string? uspot_fitter { get; set; }
        [DisplayName("Spot Check Trainee")]
        public string? uspot_trainee { get; set; }
        [DisplayName("Spot Check Date")]
        public string? uspot_date { get; set; }
        [DisplayName("Spot Check Customer")]
        public string? uspot_customer { get; set; }
        [DisplayName("Spot Check Postcode")]
        public string? uspot_postcode { get; set; }
        [DisplayName("Spot Check Insurance Company")]
        public string? uspot_insuranceco { get; set; }
        [DisplayName("Spot Check Branch")]
        public string? uspot_branch { get; set; }
        [DisplayName("Spot Check Repair")]
        public bool uspot_repair { get; set; }
        [DisplayName("Spot Check Repair Arrived")]
        public bool uspot_repair_arrived { get; set; }
        [DisplayName("Spot Check Repair Setup")]
        public bool uspot_repair_setup { get; set; }
        [DisplayName("Spot Check Repair Ongoing")]
        public bool uspot_repair_ongoing { get; set; }
        [DisplayName("Spot Check Repair Completed")]
        public bool uspot_repair_completed { get; set; }
        [DisplayName("Spot Check Replace")]
        public bool uspot_replace { get; set; }
        [DisplayName("Spot Check Replace Arrived")]
        public bool uspot_replace_arrived { get; set; }
        [DisplayName("Spot Check Replace Setup")]
        public bool uspot_replace_setup { get; set; }
        [DisplayName("Spot Check Replace Unit Moved")]
        public bool uspot_replace_unitmoved { get; set; }
        [DisplayName("Spot Check Replace Completed")]
        public bool uspot_replace_completed { get; set; }
        [DisplayName("Spot Check Review Door")]
        public bool uspot_rev_door { get; set; }
        [DisplayName("Spot Check Review Window")]
        public bool uspot_rev_window { get; set; }
        [DisplayName("Spot Check Review Garage Door")]
        public bool uspot_rev_garagedoor { get; set; }
        [DisplayName("Spot Check Review Glass")]
        public bool uspot_rev_glass { get; set; }
        [DisplayName("Spot Check Review Locks")]
        public bool uspot_rev_locks { get; set; }
        [DisplayName("Spot Check Review Other")]
        public bool uspot_rev_other { get; set; }
        [DisplayName("Spot Check Review UPVC")]
        public bool uspot_revb_upvc { get; set; }
        [DisplayName("Spot Check Review Aluminium")]
        public bool uspot_revb_ali { get; set; }
        [DisplayName("Spot Check Review Timber")]
        public bool uspot_revb_timber { get; set; }
        [DisplayName("Spot Check Review Other (Alt)")]
        public bool uspot_revb_other { get; set; }
        [DisplayName("Spot Check Appearance")]
        public int uspot_appearence { get; set; }
        */

    }
}
