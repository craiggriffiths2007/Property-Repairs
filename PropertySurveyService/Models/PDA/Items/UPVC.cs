using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class UPVC
    {
        [Key]
        [DisplayName("Record Id")]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.upvc;

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

        [DisplayName("Replace Panel")]
        public bool? replace_panel { get; set; }

        [DisplayName("Replace Reason")]
        public string replace_reason { get; set; } = "";

        [DisplayName("Replace Explain")]
        public string replace_explain { get; set; } = "";

        [DisplayName("UPVC Item")]
        public string upvc_item { get; set; } = "";

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";

        [DisplayName("Colour")]
        public string colour { get; set; } = "";

        [DisplayName("Cills")]
        public string cills { get; set; } = "";

        [DisplayName("Outer Section Size")]
        public string outer_section_size { get; set; } = "";

        [DisplayName("Internal Width")]
        public string internal_width { get; set; } = "";

        [DisplayName("Internal Height")]
        public string internal_height { get; set; } = "";

        [DisplayName("Brick Width")]
        public string brick_width { get; set; } = "";

        [DisplayName("Brick Height")]
        public string brick_height { get; set; } = "";

        [DisplayName("Midrail")]
        public bool? midrail { get; set; }

        [DisplayName("Addons")]
        public bool? addons { get; set; }

        [DisplayName("Addon Width")]
        public string addon_width { get; set; } = "";

        [DisplayName("Addon Height")]
        public string addon_height { get; set; } = "";

        [DisplayName("Head Drip")]
        public bool? head_drip { get; set; }

        [DisplayName("Handle Colour")]
        public string handle_colour { get; set; } = "";

        [DisplayName("Locking Type")]
        public string locking_type { get; set; } = "";

        [DisplayName("Letter Box")]
        public string letter_box { get; set; } = "";

        [DisplayName("Letter Box Position")]
        public string letter_box_pos { get; set; } = "";

        [DisplayName("Pet Flap")]
        public string pet_flap { get; set; } = "";

        [DisplayName("Pet Type")]
        public string pet_type { get; set; } = "";

        [DisplayName("Pet Magnetic")]
        public string pet_magnetic { get; set; } = "...";

        [DisplayName("Bead Type")]
        public string bead_type { get; set; } = "";

        [DisplayName("Opens (In/Out)")]
        public string opens { get; set; } = "...";

        [DisplayName("Glaze (Internal/External)")]
        public string glaze { get; set; } = "...";

        [DisplayName("Trickle Vents (Yes/No)")]
        public string trickle_vents { get; set; } = "...";

        [DisplayName("Spacer Thickness")]
        public string spacer_thickness { get; set; } = "";

        [DisplayName("Spacer Colour")]
        public string spacer_colour { get; set; } = "";

        [DisplayName("Glass Type")]
        public string glass_type { get; set; } = "";

        [DisplayName("Glass Pattern")]
        public string glass_pattern { get; set; } = "";

        [DisplayName("Special Glass")]
        public string special_glass { get; set; } = "";

        [DisplayName("Double/Tripple")]
        public string double_tripple { get; set; } = "...";

        [DisplayName("Internal Lock")]
        public int internal_lock { get; set; }

        [DisplayName("New Locking Mechanism")]
        public bool? bNewLockingMech { get; set; }



        [DisplayName("Midrail Height")]
        public string midrail_height { get; set; } = "";



        [DisplayName("Frame Depth")]
        public string frame_depth { get; set; } = "";

        [DisplayName("DOCL")]
        public string docl { get; set; } = "";

        [DisplayName("Profile Type")]
        public string profile_type { get; set; } = "...";

        [DisplayName("Room Location")]
        public string room_location { get; set; } = "";



        [DisplayName("LP Handles")]
        public string LPHandles { get; set; } = "...";

        [DisplayName("Slide Position")]
        public string slide_position { get; set; } = "...";

        [DisplayName("Threshold Type")]
        public string threshold_type { get; set; } = "";

        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;

        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";

        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";

        [DisplayName("FENSA")]
        public bool bFensa { get; set; } = true;

        [DisplayName("WER Rating")]
        public string WER_Rating { get; set; } = "";

        [DisplayName("Summary")]
        public string Summary { get; set; } = "";





        [DisplayName("Panel Complete")]
        public bool bPanelComplete { get; set; }

        [DisplayName("Hinge Colour")]
        public string hinge_colour { get; set; } = "";

        [DisplayName("Collect and Copy")]
        public bool? collect_and_copy { get; set; }

        [DisplayName("Temporary")]
        public string temporary { get; set; } = "...";

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




        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.upvc, item_number, ContractCode); }
    }

}
