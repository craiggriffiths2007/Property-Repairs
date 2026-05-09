using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PropertySurveyService.Models
{
    public class AccidentsVehicleDTO
    {
        public VAccidentTable Accident { get; set; }
        public List<Whitness>? Whitnesses { get; set; }

    }

    public class Whitness
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } 
        public int Accident_sheetId { get; set; }
        public string p_name { get; set; }
        public string p_add1 { get; set; }
        public string p_add2 { get; set; }
        public string p_add3 { get; set; }
        public string p_pcode { get; set; }
        public string p_wittel { get; set; }
        public bool complete { get; set; }
    }



    public class VAccidentTable
    {
        public int Id { get; set; }

        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();


        // ==========================================
        // Header & Metadata
        // ==========================================

        [DisplayName("Report Date/Time Created")]
        public string date_time { get; set; } = "";

        [DisplayName("Sent to Server")]
        public bool bSent { get; set; }

        [DisplayName("Is Completed")]
        public bool bComplete { get; set; }

        [DisplayName("Brief Overview / Title")]
        public string brief { get; set; } = "";

        [DisplayName("Accident Date")]
        public string acc_date { get; set; } = "";

        [DisplayName("Accident Time")]
        public string acc_time { get; set; } = "";


        // ==========================================
        // Progress Checklist Status (c_)
        // ==========================================

        [DisplayName("Checklist: Instructions Read")]
        public bool c_instructions { get; set; }

        [DisplayName("Checklist: Details Complete")]
        public bool c_details { get; set; }

        [DisplayName("Checklist: Your Details Complete")]
        public bool c_you { get; set; }

        [DisplayName("Checklist: Third-Party Details Complete")]
        public bool c_them { get; set; }

        [DisplayName("Checklist: Police Details Complete")]
        public bool c_police { get; set; }

        [DisplayName("Checklist: Witness Details Complete")]
        public bool c_witness { get; set; }

        [DisplayName("Checklist: Photographs Uploaded")]
        public bool c_photographs { get; set; }

        [DisplayName("Checklist: Diagrams/Drawings Complete")]
        public bool c_drawings { get; set; }


        // ==========================================
        // Incident Details & Police (d_)
        // ==========================================

        [DisplayName("Police Attended Incident?")]
        public bool d_bPolice { get; set; }

        [DisplayName("Reporting Officer's Name")]
        public string d_officers_name { get; set; } = "";

        [DisplayName("Reporting Officer's Badge Number")]
        public string d_officers_number { get; set; } = "";

        [DisplayName("Police Station Name")]
        public string d_station { get; set; } = "";

        [DisplayName("Accident Location/Place")]
        public string d_place { get; set; } = "";

        [DisplayName("Estimated Speed (MPH)")]
        public string d_speed { get; set; } = "";

        [DisplayName("Weather & Road Conditions")]
        public string d_weather { get; set; } = "";

        [DisplayName("Accident Description")]
        public string d_description { get; set; } = "";

        [DisplayName("Details Declaration Sign Date")]
        public string d_sign_date { get; set; } = "";


        // ==========================================
        // Your Vehicle & Driver Details (y_)
        // ==========================================

        [DisplayName("Your Vehicle: Make")]
        public string y_make { get; set; } = "";

        [DisplayName("Your Vehicle: Model")]
        public string y_model { get; set; } = "";

        [DisplayName("Your Vehicle: Registration")]
        public string y_reg { get; set; } = "";

        [DisplayName("Your Vehicle: Reason for Use")]
        public string y_used_for { get; set; } = "";

        [DisplayName("Your Driver: Full Name")]
        public string y_driver_full_name { get; set; } = "";

        [DisplayName("Your Driver: Date of Birth")]
        public string y_driver_dob { get; set; } = "";

        [DisplayName("Your Driver: Address Line 1")]
        public string y_address1 { get; set; } = "";

        [DisplayName("Your Driver: Address Line 2")]
        public string y_address2 { get; set; } = "";

        [DisplayName("Your Driver: Address Line 3")]
        public string y_address3 { get; set; } = "";

        [DisplayName("Your Driver: Postcode")]
        public string y_pcode { get; set; } = "";

        [DisplayName("Your Driver: Occupation")]
        public string y_occupation { get; set; } = "";

        [DisplayName("Your Driver: Years Employed")]
        public string y_years_employed { get; set; } = "";

        [DisplayName("Your Driver: Months Employed")]
        public string y_months_employed { get; set; } = "";

        [DisplayName("Your Driver: Prior Accident History")]
        public string y_any_other_accidents { get; set; } = "";

        [DisplayName("Your Driver: Physical Infirmity/Conditions")]
        public string y_infirmity { get; set; } = "";

        [DisplayName("Is Prosecution Pending?")]
        public string y_prosecution { get; set; } = "";

        [DisplayName("Your Vehicle: Damage Description")]
        public string y_vehicle_damage { get; set; } = "";

        [DisplayName("Your Vehicle: Driveable? (0 = No, 1 = Yes)")]
        public int y_driveable { get; set; }

        [DisplayName("Damage to Third-Party Property")]
        public string y_damage_to_property { get; set; } = "";

        [DisplayName("Injuries Sustained (Our Driver/Passengers)")]
        public string y_injuries_sustained { get; set; } = "";

        [DisplayName("Your Driver: Signature Complete")]
        public bool y_signed { get; set; }


        // ==========================================
        // Third-Party Details (t_)
        // ==========================================

        [DisplayName("Third Party: Full Name")]
        public string t_name { get; set; } = "";

        [DisplayName("Third Party: Address Line 1")]
        public string t_add1 { get; set; } = "";

        [DisplayName("Third Party: Address Line 2")]
        public string t_add2 { get; set; } = "";

        [DisplayName("Third Party: Address Line 3")]
        public string t_add3 { get; set; } = "";

        [DisplayName("Third Party: Postcode")]
        public string t_pcode { get; set; } = "";

        [DisplayName("Third Party: Telephone Number")]
        public string t_telnum { get; set; } = "";

        [DisplayName("Third Party: Vehicle Make")]
        public string t_make { get; set; } = "";

        [DisplayName("Third Party: Vehicle Model")]
        public string t_model { get; set; } = "";

        [DisplayName("Third Party: Vehicle Registration")]
        public string t_reg { get; set; } = "";

        [DisplayName("Third Party: Insurer Name")]
        public string t_insurer { get; set; } = "";

        [DisplayName("Third Party: Policy Number")]
        public string t_policy_no { get; set; } = "";

        [DisplayName("Total Number of Third-Party/Other Passengers")]
        public int no_of_other_people { get; set; }


        // ==========================================
        // Witness Details (p_)
        // ==========================================

        [DisplayName("Witness: Full Name")]
        public string p_name { get; set; } = "";

        [DisplayName("Witness: Address Line 1")]
        public string p_add1 { get; set; } = "";

        [DisplayName("Witness: Address Line 2")]
        public string p_add2 { get; set; } = "";

        [DisplayName("Witness: Address Line 3")]
        public string p_add3 { get; set; } = "";

        [DisplayName("Witness: Postcode")]
        public string p_pcode { get; set; } = "";

        [DisplayName("Witness: Telephone Number")]
        public string p_wittel { get; set; } = "";


        // ==========================================
        // System Vehicle Link Metadata (v_)
        // ==========================================

        [DisplayName("System Vehicle Registration Link")]
        public string v_reg { get; set; } = "";

        [DisplayName("System Vehicle Model Link")]
        public string v_model { get; set; } = "";
    }

    public class FAccidentTable
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
