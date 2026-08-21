using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyRepairs.Models
{
    public class Bifolding
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.bifold;

        [Browsable(false)]
        [DisplayName("Header Id")]
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
        // COMMON - BASIC ITEM / REPAIR INFORMATION
        // ============================================================

        [DisplayName("Repair Item")]
        public bool bRepair { get; set; }

        [DisplayName("Gaskets")]
        public string gaskets { get; set; } = "";

        [DisplayName("Gaskets Text")]
        public string gaskets_text { get; set; } = "";

        [DisplayName("Handles Required")]
        public bool? handles_req { get; set; }

        [DisplayName("Handles Text")]
        public string handles_text { get; set; } = "";

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";

        [DisplayName("Reason Not Repaired")]
        public string reason_not_repaired { get; set; } = "";


        // ============================================================
        // COMMON - SIZES
        // ============================================================

        [DisplayName("Internal Width")]
        public string internal_width { get; set; } = "";

        [DisplayName("Internal Height")]
        public string internal_height { get; set; } = "";


        // ============================================================
        // COMMON - DOORS / OPENINGS / HARDWARE
        // ============================================================

        [DisplayName("Opens (In/Out)")]
        public string opens { get; set; } = "";

        [DisplayName("Handle Colour")]
        public string handle_colour { get; set; } = "";

        [DisplayName("Threshold Type")]
        public string threshold_type { get; set; } = "";

        [DisplayName("Trickle Vents (Yes/No)")]
        public bool? trickle_vents { get; set; }


        // ============================================================
        // COMMON - GLASS
        // ============================================================

        [DisplayName("Replace Glass")]
        public bool? replace_glass { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }


        // ============================================================
        // COMMON - COMPLIANCE / CHANGES
        // ============================================================

        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;

        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";

        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";

        [DisplayName("FENSA")]
        public bool bFensa { get; set; } = true;

        [DisplayName("WER Rating")]
        public string WER_rating { get; set; } = "";

        [DisplayName("Summary")]
        public string Summary { get; set; } = "";


        // ============================================================
        // COMMON - JOB / SECURITY
        // ============================================================

        [DisplayName("Parts to Order")]
        public string parts_to_order { get; set; } = "";

        [DisplayName("Point of Entry")]
        public bool? point_of_entry { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string type_of_lockng_system_required { get; set; } = "";

        [DisplayName("Was It Locked")]
        public bool? was_it_locked { get; set; }


        // ============================================================
        // SHARED / SIMILAR TO UPVC & COMPOSITE
        // ============================================================

        [DisplayName("Addons")]
        public bool? addons { get; set; }

        [DisplayName("Addon Width")]
        public string addon_width { get; set; } = "";

        [DisplayName("Addon Height")]
        public string addon_height { get; set; } = "";


        // ============================================================
        // BIFOLDING - SIZE / CONFIGURATION
        // ============================================================

        [DisplayName("Overall Width")]
        public string overall_width { get; set; } = "";

        [DisplayName("Overall Height")]
        public string overall_height { get; set; } = "";

        [DisplayName("Number of Doors")]
        public int number_of_doors { get; set; }

        [DisplayName("Number of Doors (Text)")]
        public string number_of_doors_text { get; set; } = "";

        [DisplayName("Door Type")]
        public string door_type { get; set; } = "";

        [DisplayName("Glazing Options")]
        public string glazing_options { get; set; } = "";


        // ============================================================
        // BIFOLDING - COLOURS / HARDWARE
        // ============================================================

        [DisplayName("Hardware")]
        public string hardware { get; set; } = "";

        [DisplayName("Internal Color")]
        public string color_internal { get; set; } = "";

        [DisplayName("External Color")]
        public string color_external { get; set; } = "";

        [DisplayName("Colour of Doors")]
        public string colour_of_doors { get; set; } = "";

        [DisplayName("Internal Door Colour")]
        public string internal_door_colour { get; set; } = "";

        [DisplayName("Cill Type")]
        public string cill_type { get; set; } = "";

        [DisplayName("Knock On")]
        public string knock_on { get; set; } = "";


        // ============================================================
        // BIFOLDING - OTHER
        // ============================================================

        [DisplayName("Bifold Signed")]
        public int bifold_signed { get; set; }

        [DisplayName("Spare 12")]
        public string s_spare12 { get; set; } = "";


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
        [Browsable(false)]
        public string ItemTitle => "Bifolding" + (bRepair ? " Repair" : " Replace");

        public SurveyItem AsSurveyItem() =>
            new SurveyItem(
                Id,
                item_type,
                enum_item_type.none,
                item_number,
                ContractCode,
                ItemTitle);

    }
}
