using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyRepairs.Models
{
    public class Glass
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.glass;

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

        [DisplayName("Product Into")]
        public string ProductInto { get; set; } = "";
        // ============================================================
        // SUB-ITEM - PARENT RELATIONSHIP
        // ============================================================
        [Browsable(false)]
        [DisplayName("Parent Item")]
        public enum_item_type base_item { get; set; } = enum_item_type.none;


        // ============================================================
        // COMMON - BASIC ITEM / REPAIR INFORMATION
        // ============================================================

        [Browsable(false)]
        public bool bRepair { get; set; }

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";


        // ============================================================
        // COMMON - CHANGES / LOCATION / SUMMARY
        // ============================================================

        [DisplayName("Room Location")]
        public string room_location { get; set; } = "";

        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;

        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";

        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";

        [DisplayName("Summary")]
        public string Summary { get; set; } = "";


        // ============================================================
        // COMMON - JOB / SECURITY
        // ============================================================

        [DisplayName("Collect and Copy")]
        public bool? collect_and_copy { get; set; }

        [DisplayName("Temporary")]
        public string temporary { get; set; } = "";

        [DisplayName("Parts to Order")]
        public string parts_to_order { get; set; } = "";

        [DisplayName("Point of Entry")]
        public string point_of_entry { get; set; } = "";

        [DisplayName("Type of Locking System Required")]
        public string type_of_lockng_system_required { get; set; } = "";

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }


        // ============================================================
        // GLASS - BASIC UNIT DETAILS
        // ============================================================

        [DisplayName("Units Required")]
        public int units_required { get; set; }

        [DisplayName("Single or Double")]
        public string single_or_double { get; set; } = "";

        [DisplayName("Glass Type")]
        public string glass_type { get; set; } = "";

        [DisplayName("Glass Pattern")]
        public string glass_pattern { get; set; } = "";

        [DisplayName("Special Glass")]
        public string special_glass { get; set; } = "";

        [DisplayName("Special Glass Type")]
        public enum_special_glass_type SpecialGlassType { get; set; } = enum_special_glass_type.None;

        [DisplayName("Special Glass Complete")]
        public bool bSpecialGlassComplete { get; set; }

        [DisplayName("Spacer Color")]
        public string spacer_color { get; set; } = "";

        [DisplayName("Spacer Thickness")]
        public string spacer_thickness { get; set; } = "";

        [DisplayName("Stepped Unit")]
        public bool? stepped_unit { get; set; }

        [DisplayName("Glazing Type")]
        public string glazing_type { get; set; } = "";

        [DisplayName("Glaze")]
        public string glaze { get; set; } = "";

        [DisplayName("Tape or Gasket")]
        public string TapeorGasket { get; set; } = "";


        // ============================================================
        // GLASS - UNIT SIZES
        // ============================================================

        [DisplayName("Glass Width")]
        public string glass_width { get; set; } = "";

        [DisplayName("Glass Height")]
        public string glass_height { get; set; } = "";

        [DisplayName("Glass Width 2")]
        public string glass_width2 { get; set; } = "";

        [DisplayName("Glass Height 2")]
        public string glass_height2 { get; set; } = "";

        [DisplayName("Glass Width 3")]
        public string glass_width3 { get; set; } = "";

        [DisplayName("Glass Height 3")]
        public string glass_height3 { get; set; } = "";

        [DisplayName("Glass Width 4")]
        public string glass_width4 { get; set; } = "";

        [DisplayName("Glass Height 4")]
        public string glass_height4 { get; set; } = "";

        [DisplayName("Glass Width 5")]
        public string glass_width5 { get; set; } = "";

        [DisplayName("Glass Height 5")]
        public string glass_height5 { get; set; } = "";

        [DisplayName("Glass Width 6")]
        public string glass_width6 { get; set; } = "";

        [DisplayName("Glass Height 6")]
        public string glass_height6 { get; set; } = "";

        [DisplayName("Glass Width 7")]
        public string glass_width7 { get; set; } = "";

        [DisplayName("Glass Height 7")]
        public string glass_height7 { get; set; } = "";

        [DisplayName("Glass Width 8")]
        public string glass_width8 { get; set; } = "";

        [DisplayName("Glass Height 8")]
        public string glass_height8 { get; set; } = "";

        [DisplayName("Internal Width")]
        public string int_width { get; set; } = "";

        [DisplayName("Internal Height")]
        public string int_height { get; set; } = "";


        // ============================================================
        // GLASS - SHAPE / SPECIAL SIZES
        // ============================================================

        [DisplayName("Size A")]
        public string sizeA { get; set; } = "";

        [DisplayName("Size B")]
        public string sizeB { get; set; } = "";

        [DisplayName("Size C")]
        public string sizeC { get; set; } = "";

        [DisplayName("Size D")]
        public string sizeD { get; set; } = "";

        [DisplayName("Size A (float)")]
        public float sizeAf { get; set; }

        [DisplayName("Size B (float)")]
        public float sizeBf { get; set; }

        [DisplayName("Size C (float)")]
        public float sizeCf { get; set; }

        [DisplayName("Size D (float)")]
        public float sizeDf { get; set; }


        // ============================================================
        // GLASS - LEAD / GEORGIAN DETAILS
        // ============================================================

        [DisplayName("Lead Type")]
        public string lead_type { get; set; } = "";

        [DisplayName("Lead C Width")]
        public string lead_CWidth { get; set; } = "";

        [DisplayName("Lead C Height")]
        public string lead_CHeight { get; set; } = "";

        [DisplayName("Lead C Widths")]
        public string lead_CWidths { get; set; } = "";

        [DisplayName("Lead C Heights")]
        public string lead_CHeights { get; set; } = "";

        [DisplayName("Lead Anti Rattle")]
        public string lead_anti_rattle { get; set; } = "";

        [DisplayName("Lead Thickness")]
        public string lead_thickness { get; set; } = "";

        [DisplayName("Lead SOD")]
        public string lead_sod { get; set; } = "";

        [DisplayName("Georgian Bar Thickness")]
        public string bar_thickness { get; set; } = "";

        [DisplayName("Georgian Bar Trim")]
        public bool gb_trim { get; set; }

        [DisplayName("Lead Pos X")]
        public float lead_posX { get; set; }

        [DisplayName("Lead Pos Y")]
        public float lead_posY { get; set; }

        [DisplayName("Lead Comments")]
        public string lead_comments { get; set; } = "";

        [DisplayName("Back to Back Spacer Width")]
        public string back_to_back_spacer_width { get; set; } = "";

        [DisplayName("Back to Back Spacer Height")]
        public string back_to_back_spacer_height { get; set; } = "";


        // ============================================================
        // GLASS - LEAD COMPLETION
        // ============================================================

        [DisplayName("Back to Back Complete")]
        public bool lead_bBackToBackComplete { get; set; }

        [DisplayName("Lead Diamond Complete")]
        public bool lead_bDiamondComplete { get; set; }

        [DisplayName("Lead Georgian Complete")]
        public bool lead_bGeorgianComplete { get; set; }

        [DisplayName("Lead Bar Complete")]
        public bool lead_bBarComplete { get; set; }


        // ============================================================
        // GLASS - DOCL
        // ============================================================

        [DisplayName("DOCL")]
        public string docl { get; set; } = "";

        [DisplayName("DOCL Old")]
        public string docl_old { get; set; } = "";


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
        public string ItemTitle => (base_item == enum_item_type.none? "":
                                    base_item == enum_item_type.assembly? ProductInto + " ": 
                                    base_item.ToString()) + "Glass";

        public SurveyItem AsSurveyItem() =>
            new SurveyItem(
                Id,
                item_type,
                base_item,
                item_number,
                ContractCode,
                ItemTitle);
    }

}
