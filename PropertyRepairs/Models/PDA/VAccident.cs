using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PropertyRepairs.Models
{
    public class AccidentsVehicleDTO
    {
        public VAccident Accident { get; set; }
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



    public class VAccident
    {
        public int Id { get; set; }
        [Browsable(false)]
        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();
        [Browsable(false)]
        public string CheckID { get; set; } = ""; // consists of date, pda code, and unique Van Check ID number. Kind of a guid for the van check
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
        public bool y_driveable { get; set; }

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

}
