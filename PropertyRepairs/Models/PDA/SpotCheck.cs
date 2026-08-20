using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace PropertyRepairs.Models
{
    public class SpotCheck
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        [DisplayName("GUID")]
        public Guid Guid { get; set; } = Guid.NewGuid();
        [Browsable(false)]
        [DisplayName("Check ID")]
        public string CheckID { get; set; } = ""; // consists of date, pda code, and unique Van Check ID number. Kind of a guid for the van check

        [DisplayName("Date Completed")]
        public string date_done { get; set; } = string.Empty;


        [Browsable(false)]
        [DisplayName("Complete")]
        public bool bComplete { get; set; }
        [Browsable(false)]
        [DisplayName("Sent")]
        public bool bSent { get; set; }
        [Browsable(false)]

        [DisplayName("Correct Contract")]
        public bool bCorrectContract { get; set; }
        [Display(Order = 0)]
        [DisplayName("Contract")]
        public string ContractCode { get; set; } = string.Empty;
        [Display(Order = 0)]
        [DisplayName("Branch")]
        public string branch { get; set; } = string.Empty;
        [Display(Order = 0)]
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayName("Diary Date")]
        public DateTime DiaryDate { get; set; } = DateTime.Today;
        [Display(Order = 0)]
        [DisplayName("Time")]
        public string Time { get; set; } = "";
        [Display(Order = 1)]
        [DisplayName("Name")]
        public string Name { get; set; } = "";
        [Display(Order = 1)]
        [DisplayName("Address 1")]
        public string Add1 { get; set; } = "";
        [Display(Order = 1)]
        [DisplayName("Address 2")]
        public string Add2 { get; set; } = "";
        [Display(Order = 1)]
        [DisplayName("Address 3")]
        public string Add3 { get; set; } = ""; 
        [Display(Order = 1)]
        [DisplayName("Postcode")]
        public string Postcode { get; set; } = "";
        [DisplayName("Phone 1")]
        public string Phone1 { get; set; } = "";
        [DisplayName("Phone 2")]
        public string Phone2 { get; set; } = "";
        [DisplayName("Phone 3")]
        public string Phone3 { get; set; } = "";
        [DisplayName("Damage")]
        public string DamageDesc { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Instructions")]
        public string Instructions { get; set; } = "";


        [DisplayName("Photos")]
        public int no_of_photos { get; set; }
        [Browsable(false)]
        [DisplayName("Appearance")]
        public int uspot_appearence { get; set; }
        [Browsable(false)]
        [DisplayName("Appearance Improvements")]
        public string uspot_appearence_improvements { get; set; } = string.Empty;
        [Browsable(false)]
        [DisplayName("Quality of Works")]
        public int uspot_qualityofworks { get; set; }
        [Browsable(false)]
        [DisplayName("Quality Improvements")]
        public string uspot_qualityofworks_improvements { get; set; } = string.Empty;
        [Browsable(false)]
        [DisplayName("Customer Satisfaction")]
        public int uspot_customersatisfaction { get; set; }
        [Browsable(false)]
        [DisplayName("Customer Satisfaction Improvements")]
        public string uspot_customersatisfaction_improvements { get; set; } = string.Empty;



        [DisplayName("Other Observations")]
        public string uspot_otherobservations { get; set; } = string.Empty;
        [DisplayName("Fitter")]
        public string uspot_fitter { get; set; } = string.Empty;
        [DisplayName("Trainee")]
        public string uspot_trainee { get; set; } = string.Empty;
        [Browsable(false)]
        [DisplayName("Spot Date")]
        public string uspot_date { get; set; } = string.Empty;
        //char uspot_contract
        [Browsable(false)]
        [DisplayName("Customer")]
        public string uspot_customer { get; set; } = string.Empty;
        [Browsable(false)]
        [DisplayName("Customer Postcode")]
        public string uspot_postcode { get; set; } = string.Empty;
        [Browsable(false)]
        [DisplayName("Insurance Co")]
        public string uspot_insuranceco { get; set; } = string.Empty;
        [DisplayName("Branch")]
        public string uspot_branch { get; set; } = string.Empty;


        public string uspot_customersatisfaction_improvementsOld { get; set; } = string.Empty;
        public string uspot_otherobservationsOld { get; set; } = string.Empty;
        [Browsable(false)]
        [DisplayName("Signed")]
        public bool uspot_signed { get; set; }
        [Browsable(false)]
        [DisplayName("Signed Date")]
        public string uspot_signeddate { get; set; } = string.Empty;
        [Browsable(false)]
        [DisplayName("Replace Fit")]
        public bool uspot_replace_fit { get; set; }
        [Browsable(false)]
        [DisplayName("P1")]
        public int uspot_p1 { get; set; }
        [Browsable(false)]
        [DisplayName("P2")]
        public int uspot_p2 { get; set; }
        [Browsable(false)]
        [DisplayName("P3")]
        public int uspot_p3 { get; set; }
        [Browsable(false)]
        [DisplayName("P4")]
        public int uspot_p4 { get; set; }
        [Browsable(false)]

        [DisplayName("Still on site")]
        public bool still_on_site { get; set; }
        [Browsable(false)]

        [DisplayName("Repair")]
        public bool uspot_repair { get; set; }
        [Browsable(false)]
        [DisplayName("Arrived")]
        public bool uspot_repair_arrived { get; set; }
        [DisplayName("Set Up")]
        public bool uspot_repair_setup { get; set; }
        [DisplayName("Ongoing")]
        public bool uspot_repair_ongoing { get; set; }
        [DisplayName("Completed")]
        public bool uspot_repair_completed { get; set; }
        [DisplayName("Replace")]
        public bool uspot_replace { get; set; }
        [DisplayName("Replace Arrived")]
        public bool uspot_replace_arrived { get; set; }
        [DisplayName("Replace Set Up")]
        public bool uspot_replace_setup { get; set; }
        [DisplayName("Unit Moved")]
        public bool uspot_replace_unitmoved { get; set; }
        [DisplayName("Replace Completed")]
        public bool uspot_replace_completed { get; set; }
        [DisplayName("Door Reviewed")]
        public bool uspot_rev_door { get; set; }
        [DisplayName("Window Reviewed")]
        public bool uspot_rev_window { get; set; }
        [DisplayName("Garage Door Reviewed")]
        public bool uspot_rev_garagedoor { get; set; }
        [DisplayName("Glass Reviewed")]
        public bool uspot_rev_glass { get; set; }
        [DisplayName("Locks Reviewed")]
        public bool uspot_rev_locks { get; set; }
        [DisplayName("Other Reviewed")]
        public bool uspot_rev_other { get; set; }
        [DisplayName("uPVC Material")]
        public bool uspot_revb_upvc { get; set; }
        [DisplayName("Aluminium Material")]
        public bool uspot_revb_ali { get; set; }
        [DisplayName("Timber Material")]
        public bool uspot_revb_timber { get; set; }
        [DisplayName("Other Material")]
        public bool uspot_revb_other { get; set; }





        [DisplayName("Name 1")]
        public string name1 { get; set; } = string.Empty;
        [DisplayName("Name 2")]
        public string name2 { get; set; } = string.Empty;

        [DisplayName("Safety boots (F1)")]
        public bool safety_boots_worn1 { get; set; }
        [DisplayName("Safety gloves (F1)")]
        public bool safety_gloves_worn1 { get; set; }
        [DisplayName("Safety goggles (F1)")]
        public bool safety_googles_worn1 { get; set; }
        [DisplayName("Safety helmet (F1)")]
        public bool safety_helmet_worn1 { get; set; }
        [DisplayName("Wristguards (F1)")]
        public bool wristguards_worn1 { get; set; }
        [DisplayName("Uniform complete (F1)")]
        public bool uniform_worn_complete1 { get; set; }
        [DisplayName("ID card available (F1)")]
        public bool id_card_available1 { get; set; }

        [DisplayName("Safety boots (F2)")]
        public bool safety_boots_worn2 { get; set; }
        [DisplayName("Safety gloves (F2)")]
        public bool safety_gloves_worn2 { get; set; }
        [DisplayName("Safety goggles (F2)")]
        public bool safety_googles_worn2 { get; set; }
        [DisplayName("Safety helmet (F2)")]
        public bool safety_helmet_worn2 { get; set; }
        [DisplayName("Wristguards (F2)")]
        public bool wristguards_worn2 { get; set; }
        [DisplayName("Uniform complete (F2)")]
        public bool uniform_worn_complete2 { get; set; }
        [DisplayName("ID card available (F2)")]
        public bool id_card_available2 { get; set; }

        [DisplayName("Chemicals stored correctly")]
        public bool chemicals_stored_correctly { get; set; }
        [DisplayName("Dust sheets available")]
        public bool are_sheets_available { get; set; }
        [DisplayName("Area above checked")]
        public bool area_above_been_checked { get; set; }
        [DisplayName("Obstructions checked")]
        public bool obstructions_checked { get; set; }
        [DisplayName("Lintel OK")]
        public bool lintel_ok { get; set; }
        [DisplayName("Ladders secure")]
        public bool ladders_secure { get; set; }
        [DisplayName("Safe work at height")]
        public bool safe_work_at_height { get; set; }
        [DisplayName("Condition of ladders")]
        public bool condition_of_ladders { get; set; }
        [DisplayName("Tools set out safely")]
        public bool tools_set_out_safely { get; set; }
        [DisplayName("Fire extinguisher on van")]
        public bool fire_extinguisher_on_van { get; set; }
        [DisplayName("First aid kit on van")]
        public bool first_aid_kit_on_van { get; set; }
        [DisplayName("Electrical equipment tested")]
        public bool electrical_equipment_tested { get; set; }
        [DisplayName("Safety Boots (1)")]
        public string safety_boots_worn1_s { get; set; } = string.Empty;
        [DisplayName("Safety Gloves (1)")]
        public string safety_gloves_worn1_s { get; set; } = string.Empty;
        [DisplayName("Safety Goggles (1)")]
        public string safety_googles_worn1_s { get; set; } = string.Empty;
        [DisplayName("Safety Helmet (1)")]
        public string safety_helmet_worn1_s { get; set; } = string.Empty;
        [DisplayName("Wristguards (1)")]
        public string wristguards_worn1_s { get; set; } = string.Empty;
        [DisplayName("Uniform Complete (1)")]
        public string uniform_worn_complete1_s { get; set; } = string.Empty;
        [DisplayName("ID Card Available (1)")]
        public string id_card_available1_s { get; set; } = string.Empty;
        [DisplayName("Safety Boots (2)")]
        public string safety_boots_worn2_s { get; set; } = string.Empty;
        [DisplayName("Safety Gloves (2)")]
        public string safety_gloves_worn2_s { get; set; } = string.Empty;
        [DisplayName("Safety Goggles (2)")]
        public string safety_googles_worn2_s { get; set; } = string.Empty;
        [DisplayName("Safety Helmet (2)")]
        public string safety_helmet_worn2_s { get; set; } = string.Empty;
        [DisplayName("Wristguards (2)")]
        public string wristguards_worn2_s { get; set; } = string.Empty;
        [DisplayName("Uniform Complete (2)")]
        public string uniform_worn_complete2_s { get; set; } = string.Empty;
        [DisplayName("ID Card Available (2)")]
        public string id_card_available2_s { get; set; } = string.Empty;
        [DisplayName("Chemicals Stored")]
        public string chemicals_stored_correctly_s { get; set; } = string.Empty;
        [DisplayName("Sheets Available")]
        public string are_sheets_available_s { get; set; } = string.Empty;
        [DisplayName("Area Checked Above")]
        public string area_above_been_checked_s { get; set; } = string.Empty;
        [DisplayName("Obstructions Checked")]
        public string obstructions_checked_s { get; set; } = string.Empty;
        [DisplayName("Lintel OK")]
        public string lintel_ok_s { get; set; } = string.Empty;
        [DisplayName("Ladders Secure")]
        public string ladders_secure_s { get; set; } = string.Empty;
        [DisplayName("Safe Work At Height")]
        public string safe_work_at_height_s { get; set; } = string.Empty;
        [DisplayName("Condition Of Ladders")]
        public string condition_of_ladders_s { get; set; } = string.Empty;
        [DisplayName("Tools Set Out Safely")]
        public string tools_set_out_safely_s { get; set; } = string.Empty;
        [DisplayName("Fire Extinguisher On Van")]
        public string fire_extinguisher_on_van_s { get; set; } = string.Empty;
        [DisplayName("First Aid Kit On Van")]
        public string first_aid_kit_on_van_s { get; set; } = string.Empty;
        [DisplayName("Electrical Equipment Tested (S)")]
        public string electrical_equipment_tested_s { get; set; } = string.Empty;
        [DisplayName("Comments")]
        public string comments { get; set; } = string.Empty;

    }
}
