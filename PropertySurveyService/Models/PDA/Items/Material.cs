using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models

{
    [Flags]
    public enum MaterialType
    {
        None = 0,
        UPVC = 1,
        Aluminium = 2,
        Timber = 4
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class MaterialForAttribute : Attribute
    {
        public MaterialType Materials { get; }

        public MaterialForAttribute(MaterialType materials)
        {
            Materials = materials;
        }
    }


    public class Material
    {
        // ============================================================
        // COMMON - DATABASE / ITEM IDENTIFICATION
        // ============================================================
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.material;

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

        // ============================================================
        // MATERIAL SELECTION
        // ============================================================
        [DisplayName("Material")]
        public MaterialType material { get; set; } = MaterialType.UPVC;

        [DisplayName("Opening Type")]
        public string opening_type { get; set; } = "";

        [DisplayName("WER Rating")]
        public string WER_Rating { get; set; } = "";

        // ============================================================
        // COMMON - BASIC ITEM / REPAIR INFORMATION
        // ============================================================
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

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";

        // ============================================================
        // COMMON - SIZES
        // ============================================================
        [DisplayName("Brick Width")]
        public string brick_width { get; set; } = "";

        [DisplayName("Brick Height")]
        public string brick_height { get; set; } = "";

        [DisplayName("Internal Width")]
        public string internal_width { get; set; } = "";

        [DisplayName("Internal Height")]
        public string internal_height { get; set; } = "";

        // ============================================================
        // COMMON - DOORS / OPENINGS / HARDWARE
        // ============================================================
        [DisplayName("Opens (In/Out)")]
        public string opens { get; set; } = "...";

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

        [DisplayName("New Locking Mechanism")]
        public bool? bNewLockingMech { get; set; }

        // ============================================================
        // COMMON - GLASS
        // ============================================================
        [DisplayName("Spacer Thickness")]
        public string spacer_thickness { get; set; } = "";

        [DisplayName("Glass Type")]
        public string glass_type { get; set; } = "";

        [DisplayName("Glass Pattern")]
        public string glass_pattern { get; set; } = "";

        [DisplayName("Special Glass")]
        public string special_glass { get; set; } = "";

        [DisplayName("Replace Glass")]
        public bool? replace_glass { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }

        // ============================================================
        // COMMON - COMPLIANCE / LOCATION / CHANGES
        // ============================================================
        [DisplayName("DOCL")]
        public string docl { get; set; } = "";

        [DisplayName("Room Location")]
        public string room_location { get; set; } = "";

        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;

        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";

        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";

        [DisplayName("FENSA")]
        public bool bFensa { get; set; } = true;

        [DisplayName("Summary")]
        public string Summary { get; set; } = "";

        // ============================================================
        // COMMON - JOB / SECURITY
        // ============================================================
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

        // ============================================================
        // UPVC + ALUMINIUM
        // ============================================================
        [MaterialFor(MaterialType.UPVC | MaterialType.Aluminium)]
        [DisplayName("Replace Panel")]
        public bool? replace_panel { get; set; }

        [MaterialFor(MaterialType.UPVC | MaterialType.Aluminium)]
        [DisplayName("Locking Type")]
        public string locking_type { get; set; } = "";

        [MaterialFor(MaterialType.UPVC | MaterialType.Aluminium)]
        [DisplayName("Midrail Height")]
        public string midrail_height { get; set; } = "";

        [MaterialFor(MaterialType.UPVC | MaterialType.Aluminium)]
        [DisplayName("LP Handles")]
        public string LPHandles { get; set; } = "...";

        [MaterialFor(MaterialType.UPVC | MaterialType.Aluminium)]
        [DisplayName("Threshold Type")]
        public string threshold_type { get; set; } = "";

        [MaterialFor(MaterialType.UPVC | MaterialType.Aluminium)]
        [DisplayName("Bead Type")]
        public string bead_type { get; set; } = "...";

        [MaterialFor(MaterialType.UPVC | MaterialType.Aluminium)]
        [DisplayName("Panel Complete")]
        [Browsable(false)]
        public bool bPanelComplete { get; set; }

        // ============================================================
        // UPVC + TIMBER
        // ============================================================
        [MaterialFor(MaterialType.UPVC | MaterialType.Timber)]
        [DisplayName("Cills")]
        public string cills { get; set; } = "";

        [MaterialFor(MaterialType.UPVC | MaterialType.Timber)]
        [DisplayName("Head Drip")]
        public bool? head_drip { get; set; }

        [MaterialFor(MaterialType.UPVC | MaterialType.Timber)]
        [DisplayName("Trickle Vents (Yes/No)")]
        public string trickle_vents { get; set; } = "...";

        [MaterialFor(MaterialType.UPVC | MaterialType.Timber)]
        [DisplayName("Slide Position")]
        public string slide_position { get; set; } = "...";

        // ============================================================
        // ALUMINIUM + TIMBER
        // ============================================================
        [MaterialFor(MaterialType.Aluminium | MaterialType.Timber)]
        [DisplayName("Spacer Color")]
        public string spacer_color { get; set; } = "";

        // ============================================================
        // UPVC ONLY
        // ============================================================
        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("UPVC Item")]
        public string upvc_item { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Colour")]
        public string colour { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Outer Section Size")]
        public string outer_section_size { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Midrail")]
        public bool? midrail { get; set; }

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Addons")]
        public bool? addons { get; set; }

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Addon Width")]
        public string addon_width { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Addon Height")]
        public string addon_height { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Handle Colour")]
        public string handle_colour { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Glaze (Internal/External)")]
        public string glaze { get; set; } = "...";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Spacer Colour")]
        public string spacer_colour { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Double/Tripple")]
        public string double_tripple { get; set; } = "...";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Internal Lock")]
        public int internal_lock { get; set; }

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Frame Depth")]
        public string frame_depth { get; set; } = "";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Profile Type")]
        public string profile_type { get; set; } = "...";

        [MaterialFor(MaterialType.UPVC)]
        [DisplayName("Hinge Colour")]
        public string hinge_colour { get; set; } = "";

        // ============================================================
        // ALUMINIUM ONLY
        // ============================================================
        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Type")]
        public string type { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Section Type")]
        public string section_type { get; set; } = "...";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("New Timber Sub Frame")]
        public bool? new_timber_sub_frame { get; set; }

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Sub Frame Depth")]
        public string sub_frame_depth { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Item Frame Width")]
        public string item_frame_width { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Item Frame Height")]
        public string item_frame_height { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Frame Type")]
        public string frame_type { get; set; } = "...";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Cill")]
        public bool? cill { get; set; }

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Drip")]
        public bool? drip { get; set; }

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Night Vent")]
        public string night_vent { get; set; } = "...";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Midrail Type")]
        public string midrail_type { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Item Color")]
        public string item_color { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Handle Color")]
        public string handle_color { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Sub Frame Color")]
        public string sub_frame_color { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Cill on Subframe")]
        public bool? cill_on_subframe { get; set; }

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Cill Type")]
        public string cill_type { get; set; } = "...";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Spare 3")]
        public int i_spare3 { get; set; }

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Glazed")]
        public string glazed { get; set; } = "...";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Outer Section Width")]
        public string outer_section_width { get; set; } = "";

        [MaterialFor(MaterialType.Aluminium)]
        [DisplayName("Outer Section Height")]
        public string outer_section_height { get; set; } = "";

        // ============================================================
        // TIMBER ONLY
        // ============================================================
        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Timber Item")]
        public string timber_item { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Timber Wood")]
        public string timber_wood { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Timber Frame Wood")]
        public string timber_frame_wood { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("New Timber Frame Required")]
        public bool? timber_new_frame_req { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Repair Frame")]
        public bool? repair_frame { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Door Thickness")]
        public string door_thickness { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Door Width")]
        public string door_width { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Door Height")]
        public string door_height { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("New Sash Required")]
        public bool? new_sash_required { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Draught Strip")]
        public bool? draught_strip { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Require Fire Rated Glass")]
        public bool fire_rated_glass { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Thresher")]
        public bool? thresher { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Single/Double")]
        public string single_double { get; set; } = "...";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Locks")]
        public string locks { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Hardware Color")]
        public string hardware_color { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Door Color")]
        public string door_color { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Frame Color")]
        public string frame_color { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Sash Drawn")]
        public bool bSashDrawn { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Section Drawn")]
        public bool bSectionDrawn { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Moulding Drawn")]
        public bool bMouldingDrawn { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Doc L Compliant Reason")]
        public string doc_l_compliant_reason { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Doc L Compliant")]
        public bool? doc_l_compliant { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Door Color Out")]
        public string door_color_out { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Frame Color Out")]
        public string frame_color_out { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Door Color Code")]
        public string door_color_code { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Door Color Code Out")]
        public string door_color_code_out { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Frame Color Code")]
        public string frame_color_code { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Frame Color Code Out")]
        public string frame_color_code_out { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Signed")]
        public bool b_signed { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Timber Glazed")]
        public string timber_glazed { get; set; } = "...";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Standard Sizes")]
        public string standard_sizes { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Reason Nonstandard")]
        public string reasonnonstandard { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Moulding")]
        public string moulding { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Hinge Type")]
        public string hinge_type { get; set; } = "";

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Pre-glazed Door")]
        public bool? pre_glazed_door { get; set; }

        [MaterialFor(MaterialType.Timber)]
        [DisplayName("Weather Bar")]
        public bool? weather_bar { get; set; }

        // ============================================================
        // COMMON HIDDEN / STATUS FIELDS
        // ============================================================
        [Browsable(false)]
        public bool bComplete { get; set; }

        [Browsable(false)]
        public bool bDifferentFromOriginalSigned { get; set; }

        [Browsable(false)]
        public bool bDoorComplete { get; set; }

        [Browsable(false)]
        public bool bWindowComplete { get; set; }

        [Browsable(false)]
        public bool bLockComplete { get; set; }

        [Browsable(false)]
        public bool bHandleDrawingComplete { get; set; }

        [Browsable(false)]
        public int no_of_photos { get; set; }

        [Browsable(false)]
        public int no_of_drawings { get; set; }


        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.locking, item_number, ContractCode); }

    }
}