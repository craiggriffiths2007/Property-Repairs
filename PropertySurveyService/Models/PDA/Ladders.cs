using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PropertySurveyService.Models
{
    public class LaddersTable
    {
        public int Id { get; set; }

        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();


        // --- Metadata & Inspection Details ---

        [DisplayName("Date Completed")]
        public string date_done { get; set; } = "";

        [DisplayName("Branch")]
        public string branch { get; set; } = "";

        [DisplayName("Ladder Number / Asset ID")]
        public string ladder_number { get; set; } = "";

        [DisplayName("Ladder Type")]
        public string ladder_type { get; set; } = "";

        [DisplayName("Vehicle Registration")]
        public string registration { get; set; } = "";

        [DisplayName("Fitter / Surveyor Name")]
        public string fitter_surveyor_name { get; set; } = "";

        [DisplayName("Manager's Name")]
        public string managers_name { get; set; } = "";

        [DisplayName("Check ID")]
        public string CheckID { get; set; } = "";


        // --- Ladder Condition Checklist ---

        [DisplayName("In Reasonable Overall Condition")]
        public int in_reasonable_condition { get; set; }

        [DisplayName("Any Rungs Missing or Loose?")]
        public int rungs_missing_or_loose { get; set; }

        [DisplayName("Any Stiles Damaged or Bent?")]
        public int stiles_damaged_or_bent { get; set; }

        [DisplayName("Any Cracks Found?")]
        public int any_cracks { get; set; }

        [DisplayName("Any Corrosion Found?")]
        public int any_corrosion { get; set; }

        [DisplayName("Rubber/Plastic Feet Intact & Secure?")]
        public int rubber_plastic_feet { get; set; }

        [DisplayName("Any Sharp Edges or Metal Splinters?")]
        public int sharp_or_metal_splinters { get; set; }

        [DisplayName("Any Rungs Dented?")]
        public int rungs_dented { get; set; }

        [DisplayName("Has Ladder Been Painted or Decorated?")]
        public int painted_or_decorated { get; set; }

        [DisplayName("Do Hooks Sit & Secure Properly?")]
        public int hooks_sit_properly { get; set; }

        [DisplayName("Has the Ladder Ever Been Repaired?")]
        public int ladders_been_repaired { get; set; }

        [DisplayName("Any General Damage Detected?")]
        public int any_damage { get; set; }


        // --- Comments, Photos, & Workflow ---

        [DisplayName("Inspector Comments")]
        public string comments { get; set; } = "";

        [DisplayName("Total Photos Taken")]
        public int total_photos { get; set; }

        [DisplayName("Sent to Server")]
        public bool bSent { get; set; }

        [DisplayName("Is Completed")]
        public bool bComplete { get; set; }


        // --- Signatures ---

        [DisplayName("Inspector Signed")]
        public bool bSigned { get; set; }

        [DisplayName("Manager Signed")]
        public bool bSigned2 { get; set; }

        [DisplayName("Inspector Signature Filename")]
        public string signature_filename { get; set; } = "";

        [DisplayName("Manager Signature Filename")]
        public string signature_filename_2 { get; set; } = "";
    }

}
