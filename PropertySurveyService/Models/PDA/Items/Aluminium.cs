
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Regular expression to remove comments  (\t+|\s+|\r\n)((/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*))

namespace PropertySurveyService.Models
{
    public class Aluminium
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.aluminium;

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
        [DisplayName("Type")]
        public string type { get; set; } = "";
        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";
        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";
        [DisplayName("Section Type")]
        public string section_type { get; set; } = "...";
        [DisplayName("New Timber Sub Frame")]
        public bool? new_timber_sub_frame { get; set; }
        [DisplayName("Sub Frame Depth")]
        public string sub_frame_depth { get; set; } = "";
        [DisplayName("Item Frame Width")]
        public string item_frame_width { get; set; } = "";
        [DisplayName("Item Frame Height")]
        public string item_frame_height { get; set; } = "";
        [DisplayName("Brick Width")]
        public string brick_width { get; set; } = "";
        [DisplayName("Brick Height")]
        public string brick_height { get; set; } = "";
        [DisplayName("Internal Width")]
        public string internal_width { get; set; } = "";
        [DisplayName("Internal Height")]
        public string internal_height { get; set; } = "";
        [DisplayName("Frame Type")]
        public string frame_type { get; set; } = "...";
        [DisplayName("Cill")]
        public bool? cill { get; set; }
        [DisplayName("Drip")]
        public bool? drip { get; set; }
        [DisplayName("Night Vent")]
        public string night_vent { get; set; } = "...";
        [DisplayName("Midrail Type")]
        public string midrail_type { get; set; } = "";
        [DisplayName("Item Color")]
        public string item_color { get; set; } = "";
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
        [DisplayName("Opens")]
        public string opens { get; set; } = "...";
        [DisplayName("Handle Color")]
        public string handle_color { get; set; } = "";
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
        [DisplayName("Sub Frame Color")]
        public string sub_frame_color { get; set; } = "";
        [DisplayName("New Locking Mechanism")]
        public bool? bNewLockingMech { get; set; }


        [DisplayName("Midrail Height")]
        public string midrail_height { get; set; } = "";
        [DisplayName("DOCL")]
        public string docl { get; set; } = "";
        [DisplayName("Room Location")]
        public string room_location { get; set; } = "";

        [DisplayName("LP Handles")]
        public string LPHandles { get; set; } = "...";
        [DisplayName("Threshold Type")]
        public string threshold_type { get; set; } = "";

        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;
        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";
        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";
        [DisplayName("Fencer")]
        public bool bFensa { get; set; } = true;
        [DisplayName("Fencer Rating")]
        public string FecerRating { get; set; } = "";
        [DisplayName("Summary")]
        public string Summary { get; set; } = "";


        [DisplayName("Panel Complete")]
        [Browsable(false)]
        public bool bPanelComplete { get; set; }

        [DisplayName("Cill on Subframe")]
        public bool? cill_on_subframe { get; set; }               // Renamed from i_spare1
        [DisplayName("Cill Type")]
        public string cill_type { get; set; } = "...";                     // Renamed from i_spare2
        [DisplayName("Spare 3")]
        public int i_spare3 { get; set; }
        [DisplayName("Collect and Copy")]
        public bool? collect_and_copy { get; set; }               // Renamed from new_ispare1
        [DisplayName("Temporary")]
        public string temporary { get; set; } = "...";                      // Renamed from new_ispare2
        [DisplayName("Glazed")]
        public string glazed { get; set; } = "...";                         // Renamed from new_ispare4 - 0=Unset, 1=Internal, 2=External. 3=None
        [DisplayName("Bead Type")]
        public string bead_type { get; set; } = "...";                      // Renamed from new_ispare5 - 0=Unset, 1=Chamfered, 2=Sculpted, 3=Square
        [DisplayName("Outer Section Width")]
        public string outer_section_width { get; set; } = "";       // Renamed from new_sspare1
        [DisplayName("Outer Section Height")]
        public string outer_section_height { get; set; } = "";       // Renamed from new_sspare2
        [DisplayName("Parts to Order")]
        public string parts_to_order { get; set; } = "";          // renamed from new_sspare4

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


        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.aluminium,item_number,ContractCode); }

    }



}
