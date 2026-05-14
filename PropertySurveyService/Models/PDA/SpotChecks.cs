using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PropertySurveyService.Models
{
    public class SpotCheck
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();

        [DisplayName("Date Completed")]
        public string date_done { get; set; } = string.Empty;

        public bool bComplete { get; set; }
        public bool bSent { get; set; }

        public bool bCorrectContract { get; set; }

        public string udi_cont { get; set; } = string.Empty;
        public string branch { get; set; } = string.Empty;

        public string Date { get; set; } = "";
        public string Time { get; set; } = "";
        public string Name { get; set; } = "";
        public string Add1 { get; set; } = "";
        public string Add2 { get; set; } = "";
        public string Add3 { get; set; } = "";
        public string Postcode { get; set; } = "";
        public string Phone1 { get; set; } = "";
        public string Phone2 { get; set; } = "";
        public string Phone3 { get; set; } = "";
        public string DamageDesc { get; set; } = "";
        public string Instructions { get; set; } = "";


        public int no_of_photos { get; set; }
        public int uspot_appearence { get; set; }

        public string uspot_appearence_improvements { get; set; } = string.Empty;

        public int uspot_qualityofworks { get; set; }

        public string uspot_qualityofworks_improvements { get; set; } = string.Empty;

        public int uspot_customersatisfaction { get; set; }

        public string uspot_customersatisfaction_improvements { get; set; } = string.Empty;



        public string uspot_otherobservations { get; set; } = string.Empty;
        public string uspot_fitter { get; set; } = string.Empty;
        public string uspot_trainee { get; set; } = string.Empty;
        public string uspot_date { get; set; } = string.Empty;
        //char uspot_contract
        public string uspot_customer { get; set; } = string.Empty;
        public string uspot_postcode { get; set; } = string.Empty;
        public string uspot_insuranceco { get; set; } = string.Empty;
        public string uspot_branch { get; set; } = string.Empty;


        public string uspot_customersatisfaction_improvementsOld { get; set; } = string.Empty;
        public string uspot_otherobservationsOld { get; set; } = string.Empty;
        public bool uspot_signed { get; set; }
        public string uspot_signeddate { get; set; } = string.Empty;

        public bool uspot_replace_fit { get; set; }
        public int uspot_p1 { get; set; }
        public int uspot_p2 { get; set; }
        public int uspot_p3 { get; set; }
        public int uspot_p4 { get; set; }

        public bool? still_on_site { get; set; }

        public bool? uspot_repair { get; set; }
        public bool? uspot_repair_arrived { get; set; }
        public bool? uspot_repair_setup { get; set; }
        public bool? uspot_repair_ongoing { get; set; }
        public bool? uspot_repair_completed { get; set; }
        public bool? uspot_replace { get; set; }
        public bool? uspot_replace_arrived { get; set; }
        public bool? uspot_replace_setup { get; set; }
        public bool? uspot_replace_unitmoved { get; set; }
        public bool? uspot_replace_completed { get; set; }
        public bool? uspot_rev_door { get; set; }
        public bool? uspot_rev_window { get; set; }
        public bool? uspot_rev_garagedoor { get; set; }
        public bool? uspot_rev_glass { get; set; }
        public bool? uspot_rev_locks { get; set; }
        public bool? uspot_rev_other { get; set; }
        public bool? uspot_revb_upvc { get; set; }
        public bool? uspot_revb_ali { get; set; }
        public bool? uspot_revb_timber { get; set; }
        public bool? uspot_revb_other { get; set; }





        public string name1 { get; set; } = string.Empty;
        public string name2 { get; set; } = string.Empty;

        public bool? safety_boots_worn1 { get; set; }
        public bool? safety_gloves_worn1 { get; set; }
        public bool? safety_googles_worn1 { get; set; }
        public bool? safety_helmet_worn1 { get; set; }
        public bool? wristguards_worn1 { get; set; }
        public bool? uniform_worn_complete1 { get; set; }
        public bool? id_card_available1 { get; set; }

        public bool? safety_boots_worn2 { get; set; }
        public bool? safety_gloves_worn2 { get; set; }
        public bool? safety_googles_worn2 { get; set; }
        public bool? safety_helmet_worn2 { get; set; }
        public bool? wristguards_worn2 { get; set; }
        public bool? uniform_worn_complete2 { get; set; }
        public bool? id_card_available2 { get; set; }

        public bool? chemicals_stored_correctly { get; set; }
        public bool? are_sheets_available { get; set; }
        public bool? area_above_been_checked { get; set; }
        public bool? obstructions_checked { get; set; }
        public bool? lintel_ok { get; set; }
        public bool? ladders_secure { get; set; }
        public bool? safe_work_at_height { get; set; }
        public bool? condition_of_ladders { get; set; }
        public bool? tools_set_out_safely { get; set; }
        public bool? fire_extinguisher_on_van { get; set; }
        public bool? first_aid_kit_on_van { get; set; }
        public bool? electrical_equipment_tested { get; set; }
        public string safety_boots_worn1_s { get; set; } = string.Empty;
        public string safety_gloves_worn1_s { get; set; } = string.Empty;
        public string safety_googles_worn1_s { get; set; } = string.Empty;
        public string safety_helmet_worn1_s { get; set; } = string.Empty;
        public string wristguards_worn1_s { get; set; } = string.Empty;
        public string uniform_worn_complete1_s { get; set; } = string.Empty;
        public string id_card_available1_s { get; set; } = string.Empty;
        public string safety_boots_worn2_s { get; set; } = string.Empty;
        public string safety_gloves_worn2_s { get; set; } = string.Empty;
        public string safety_googles_worn2_s { get; set; } = string.Empty;
        public string safety_helmet_worn2_s { get; set; } = string.Empty;
        public string wristguards_worn2_s { get; set; } = string.Empty;
        public string uniform_worn_complete2_s { get; set; } = string.Empty;
        public string id_card_available2_s { get; set; } = string.Empty;
        public string chemicals_stored_correctly_s { get; set; } = string.Empty;
        public string are_sheets_available_s { get; set; } = string.Empty;
        public string area_above_been_checked_s { get; set; } = string.Empty;
        public string obstructions_checked_s { get; set; } = string.Empty;
        public string lintel_ok_s { get; set; } = string.Empty;
        public string ladders_secure_s { get; set; } = string.Empty;
        public string safe_work_at_height_s { get; set; } = string.Empty;
        public string condition_of_ladders_s { get; set; } = string.Empty;
        public string tools_set_out_safely_s { get; set; } = string.Empty;
        public string fire_extinguisher_on_van_s { get; set; } = string.Empty;
        public string first_aid_kit_on_van_s { get; set; } = string.Empty;
        public string electrical_equipment_tested_s { get; set; } = string.Empty;
        public string comments { get; set; } = string.Empty;

    }
}
