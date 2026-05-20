using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PropertySurveyService.Models
{

    public class FAccident
    {
        public int Id { get; set; }

        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();


        // --- Injured Person Details ---

        [DisplayName("Injured Person: Full Name")]
        public string full_name { get; set; } = "";

        [DisplayName("Injured Person: Address Line 1")]
        public string add1 { get; set; } = "";

        [DisplayName("Injured Person: Address Line 2")]
        public string add2 { get; set; } = "";

        [DisplayName("Injured Person: Address Line 3")]
        public string add3 { get; set; } = "";

        [DisplayName("Injured Person: Postcode")]
        public string pcode { get; set; } = "";

        [DisplayName("Injured Person: Occupation")]
        public string occupation { get; set; } = "";

        [DisplayName("Declaration Type (Anonymous or Named)")]
        public string anon_or_name { get; set; } = "";


        // --- Filer / Person Reporting Details ---

        [DisplayName("Reporter: Full Name")]
        public string filer_full_name { get; set; } = "";

        [DisplayName("Reporter: Address Line 1")]
        public string filer_add1 { get; set; } = "";

        [DisplayName("Reporter: Address Line 2")]
        public string filer_add2 { get; set; } = "";

        [DisplayName("Reporter: Address Line 3")]
        public string filer_add3 { get; set; } = "";

        [DisplayName("Reporter: Postcode")]
        public string filer_pcode { get; set; } = "";

        [DisplayName("Reporter: Occupation")]
        public string filer_occupation { get; set; } = "";


        // --- Incident Details ---

        [DisplayName("Date Incident Happened")]
        public string date_happened { get; set; } = "";

        [DisplayName("Time Incident Happened")]
        public string time_happened { get; set; } = "";

        [DisplayName("Location of Accident")]
        public string where_happ_acc { get; set; } = "";

        [DisplayName("Specific Location / Whereabouts")]
        public string where_abouts { get; set; } = "";

        [DisplayName("Accident Type / Classification")]
        public string Type { get; set; } = "";

        [DisplayName("Nature of Injuries")]
        public string injuries { get; set; } = "";

        [DisplayName("What Happened (Brief Description)")]
        public string what_happened { get; set; } = "";

        [DisplayName("How Did the Accident Happen? (Full Details)")]
        public string how_did_accident_happen { get; set; } = "";


        // --- Treatment & First Aid ---

        [DisplayName("First Aid Materials Used in Treatment")]
        public string materials_used_in_treatment { get; set; } = "";


        // --- Signatures & Verification ---

        [DisplayName("Injured Person Signed")]
        public int person_signed { get; set; }

        [DisplayName("Supervisor Signed")]
        public int supervisor_signed { get; set; }

        [DisplayName("Injured Person Signature Date")]
        public string sign_date { get; set; } = "";

        [DisplayName("Reporter Signature Date")]
        public string filer_sign_date { get; set; } = "";

        [DisplayName("Injured Person Signature Filename")]
        public string sig_fname1 { get; set; } = "";

        [DisplayName("Supervisor/Reporter Signature Filename")]
        public string sig_fname2 { get; set; } = "";


        // --- Metadata & Photos ---

        [DisplayName("Number of Photographs")]
        public int num_of_photographs { get; set; }

        [DisplayName("Date/Time Record Created")]
        public string date_time { get; set; } = "";

        [DisplayName("Sent to Server")]
        public bool bSent { get; set; }

        [DisplayName("Is Completed")]
        public bool bComplete { get; set; }
    }
}