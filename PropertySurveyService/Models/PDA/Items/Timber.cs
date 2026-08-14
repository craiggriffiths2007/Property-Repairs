using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Timber
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.timber;

        [DisplayName("Header Id")]
        [Browsable(false)]
        public int HeaderId { get; set; }
        [Browsable(false)]
        public Guid Guid { get; set; } = Guid.NewGuid();

        [DisplayName("Contract Number")]
        [Browsable(false)]
        public string ContractCode { get; set; } = "";

        [DisplayName("Item Number")]
        [Browsable(false)]
        public int item_number { get; set; }

        [DisplayName("Repair Item")]
        public bool bRepair { get; set; }

        [DisplayName("Cosmetic Damage")]
        public bool? cosmetic_damage { get; set; }

        [DisplayName("Additional Locks")]
        public string additional_locks { get; set; } = "";

        [DisplayName("Gaskets")]
        public string gaskets { get; set; } = "...";

        [DisplayName("Gaskets Text")]
        public string gaskets_text { get; set; } = "";

        [DisplayName("Handles Required")]
        public bool? handles_req { get; set; }

        [DisplayName("Handles Text")]
        public string handles_text { get; set; } = "";

        [DisplayName("Replace Reason")]
        public string replace_reason { get; set; } = "";

        [DisplayName("Replace Explain")]
        public string replace_explain { get; set; } = "";

        [DisplayName("Timber Item")]
        public string timber_item { get; set; } = "";

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";

        [DisplayName("Timber Wood")]
        public string timber_wood { get; set; } = "";

        [DisplayName("Timber Frame Wood")]
        public string timber_frame_wood { get; set; } = "";

        [DisplayName("New Timber Frame Required")]
        public bool? timber_new_frame_req { get; set; }

        [DisplayName("Brick Width")]
        public string brick_width { get; set; } = "";

        [DisplayName("Brick Height")]
        public string brick_height { get; set; } = "";

        [DisplayName("Internal Width")]
        public string internal_width { get; set; } = "";

        [DisplayName("Internal Height")]
        public string internal_height { get; set; } = "";

        [DisplayName("Repair Frame")]
        public bool? repair_frame { get; set; }

        [DisplayName("Door Thickness")]
        public string door_thickness { get; set; } = "";

        [DisplayName("Door Width")]
        public string door_width { get; set; } = "";

        [DisplayName("Door Height")]
        public string door_height { get; set; } = "";

        [DisplayName("Opens (In/Out)")]
        public string opens { get; set; } = "...";

        [DisplayName("New Sash Required")]
        public bool? new_sash_required { get; set; }

        [DisplayName("Head Drip")]
        public bool? head_drip { get; set; }

        [DisplayName("Cills")]
        public string cills { get; set; } = "";

        [DisplayName("Draught Strip")]
        public bool? draught_strip { get; set; }

        [DisplayName("Pet Flap")]
        public string pet_flap { get; set; } = "";

        [DisplayName("Pet Type")]
        public string pet_type { get; set; } = "";

        [DisplayName("Pet Magnetic")]
        public string pet_magnetic { get; set; } = "...";


        [DisplayName("Require Fire Rated Glass")]
        public bool fire_rated_glass { get; set; }

        [DisplayName("Thresher")]
        public bool? thresher { get; set; }

        [DisplayName("Single/Double")]
        public string single_double { get; set; } = "...";

        [DisplayName("Trickle Vents")]
        public string trickle_vents { get; set; } = "";

        [DisplayName("Locks")]
        public string locks { get; set; } = "";

        [DisplayName("Hardware Color")]
        public string hardware_color { get; set; } = "";

        [DisplayName("Door Color")]
        public string door_color { get; set; } = "";

        [DisplayName("Frame Color")]
        public string frame_color { get; set; } = "";

        [DisplayName("Spacer Thickness")]
        public string spacer_thickness { get; set; } = "";

        [DisplayName("Spacer Color")]
        public string spacer_color { get; set; } = "";

        [DisplayName("Glass Type")]
        public string glass_type { get; set; } = "";

        [DisplayName("Glass Pattern")]
        public string glass_pattern { get; set; } = "";

        [DisplayName("Special Glass")]
        public string special_glass { get; set; } = "";

        [DisplayName("New Locking Mechanism")]
        public bool? bNewLockingMech { get; set; }

        [DisplayName("DOCL")]
        public string docl { get; set; } = "";

        [DisplayName("Sash Drawn")]
        public bool bSashDrawn { get; set; }

        [DisplayName("Section Drawn")]
        public bool bSectionDrawn { get; set; }

        [DisplayName("Moulding Drawn")]
        public bool bMouldingDrawn { get; set; }

        [DisplayName("Room Location")]
        public string room_location { get; set; } = "";

        [DisplayName("Doc L Compliant Reason")]
        public string doc_l_compliant_reason { get; set; } = "";

        [DisplayName("Doc L Compliant")]
        public bool? doc_l_compliant { get; set; }

        [DisplayName("Door Color Out")]
        public string door_color_out { get; set; } = "";

        [DisplayName("Frame Color Out")]
        public string frame_color_out { get; set; } = "";

        [DisplayName("Door Color Code")]
        public string door_color_code { get; set; } = "";

        [DisplayName("Door Color Code Out")]
        public string door_color_code_out { get; set; } = "";

        [DisplayName("Frame Color Code")]
        public string frame_color_code { get; set; } = "";

        [DisplayName("Frame Color Code Out")]
        public string frame_color_code_out { get; set; } = "";

        [DisplayName("Signed")]
        public bool b_signed { get; set; }

        [DisplayName("Slide Position")]
        public string slide_position { get; set; } = "...";

        [DisplayName("Timber Glazed")]
        public string timber_glazed { get; set; } = "...";

        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;

        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";

        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";

        [DisplayName("Standard Sizes")]
        public string standard_sizes { get; set; } = "";

        [DisplayName("Reason Nonstandard")]
        public string reasonnonstandard { get; set; } = "";

        [DisplayName("FENSA")]
        public bool bFensa { get; set; } = true;

        [DisplayName("WER Rating")]
        public string WER_rating { get; set; } = "";

        [DisplayName("Summary")]
        public string Summary { get; set; } = "";

        [DisplayName("Letter Box")]
        public string letter_box { get; set; } = "";

        [DisplayName("Letter Box Position")]
        public string letter_box_pos { get; set; } = "";

        [DisplayName("Moulding")]
        public string moulding { get; set; } = "";

        [DisplayName("Hinge Type")]
        public string hinge_type { get; set; } = "";

        [DisplayName("Collect and Copy")]
        public bool? collect_and_copy { get; set; }

        [DisplayName("Temporary")]
        public string temporary { get; set; } = "...";

        [DisplayName("Pre-glazed Door")]
        public bool? pre_glazed_door { get; set; }

        [DisplayName("Weather Bar")]
        public bool? weather_bar { get; set; }

        [DisplayName("Parts to Order")]
        public string parts_to_order { get; set; } = "";

        [DisplayName("Is a Flat")]
        public bool? is_a_flat { get; set; }

        [DisplayName("Point of Entry")]
        public string point_of_entry { get; set; } = "";

        [DisplayName("Type of Locking System Required")]
        public string type_of_lockng_system_required { get; set; } = "";

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }

        [DisplayName("Replace Glass")]
        public bool? replace_glass { get; set; }



        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.timber, item_number, ContractCode); }
    }

}
