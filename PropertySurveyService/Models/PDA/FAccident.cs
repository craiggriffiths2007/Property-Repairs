using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PropertyRepairs.Models
{

    public class FAccident
    {
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public Guid Guid { get; set; } = Guid.NewGuid();
        [Browsable(false)]
        public string CheckID { get; set; } = ""; // consists of date, pda code, and unique Van Check ID number. Kind of a guid for the van check
        // --- Injured Person Details ---

        [DisplayName("Injured: Full Name")]
        public string full_name { get; set; } = "";

        [DisplayName("Injured: Address Line 1")]
        public string add1 { get; set; } = "";

        [DisplayName("Injured: Address Line 2")]
        public string add2 { get; set; } = "";

        [DisplayName("Injured: Address Line 3")]
        public string add3 { get; set; } = "";

        [DisplayName("Injured: Postcode")]
        public string pcode { get; set; } = "";

        [DisplayName("Injured: Occupation")]
        public string occupation { get; set; } = "";

        [DisplayName("Declared by")]
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

        [DisplayName("Date Happened")]
        public string date_happened { get; set; } = "";

        [DisplayName("Time Happened")]
        public string time_happened { get; set; } = "";

        [DisplayName("Location")]
        public string where_happ_acc { get; set; } = "";

        [DisplayName("Type")]
        public string Type { get; set; } = "";

        [DisplayName("What Happened")]
        public string what_happened { get; set; } = "";

        [DisplayName("How it Happen?")]
        public string how_did_accident_happen { get; set; } = "";

        [DisplayName("Where it Happened?")]
        public string where_it_happened { get; set; } = "";

        [DisplayName("Injuries Sustained")]
        public string injuries_sustained { get; set; } = "";


        // --- Treatment & First Aid ---

        [DisplayName("Materials Used")]
        public string materials_used_in_treatment { get; set; } = "";


        // --- Signatures & Verification ---


        [Browsable(false)]
        public string sig_fname1 { get; set; } = "";

        [Browsable(false)]
        public string sig_fname2 { get; set; } = "";


        // --- Metadata & Photos ---

        [Browsable(false)]
        public int no_of_photos { get; set; }

        [Browsable(false)]
        public DateTime date_time { get; set; }

        [Browsable(false)]
        public bool bSent { get; set; }

        [Browsable(false)]
        public bool bComplete { get; set; }
    }
}