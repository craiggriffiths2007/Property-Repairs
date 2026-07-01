
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Regular expression to remove comments  (\t+|\s+|\r\n)((/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*))

namespace PropertySurveyService.Models
{
    public class Aluminium
    {
        [Key]
        [DisplayName("Record Id")]
        [Browsable(false)]
        public int Id { get; set; }
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
        public int frame_type { get; set; }
        [DisplayName("Cill")]
        public int cill { get; set; }
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
        public int pet_magnetic { get; set; }
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
        public bool? bNewLockingMech { get; set; }			// 0-not selected 1-Yes 2-No
        [DisplayName("Lock Complete")]
        public int bLockComplete { get; set; }				// Is the locking mechanism complete ????????????
        [DisplayName("Handle Drawing Complete")]
        [Browsable(false)]
        public bool bHandleDrawingComplete { get; set; }
        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }	// Number of pictures
        [DisplayName("Midrail Height")]
        public string midrail_height { get; set; } = "";
        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }	                // Number of pictures
        [DisplayName("DOCL")]
        public string docl { get; set; } = "";
        [DisplayName("Room Location")]
        public string room_location { get; set; } = "";
        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }
        [DisplayName("LP Handles")]
        public string LPHandles { get; set; } = "...";
        [DisplayName("Threshold Type")]
        public string threshold_type { get; set; } = "";
        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }
        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";
        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";
        [DisplayName("Fencer")]
        public bool bFencer { get; set; }
        [DisplayName("Fencer Rating")]
        public string FecerRating { get; set; } = "";
        [DisplayName("Long Comments")]
        public string long_comments { get; set; } = "";
        [DisplayName("Door Complete")]
        [Browsable(false)]
        public bool bDoorComplete { get; set; }
        [DisplayName("Window Complete")]
        [Browsable(false)]
        public bool bWindowComplete { get; set; }
        [DisplayName("Lead Size A")]
        public int lead_sizeA { get; set; }
        [DisplayName("Lead Size B")]
        public int lead_sizeB { get; set; }
        [DisplayName("Lead Size C")]
        public int lead_sizeC { get; set; }
        [DisplayName("Lead Size D")]
        public int lead_sizeD { get; set; }
        [DisplayName("Lead C Width")]
        public int lead_CWidth { get; set; }
        [DisplayName("Lead C Height")]
        public int lead_CHeight { get; set; }
        [DisplayName("Lead Anti Rattle")]
        public int lead_anti_rattle { get; set; }
        [DisplayName("Lead Thickness")]
        public string lead_thickness { get; set; } = "";
        [DisplayName("Lead SOD")]
        public string lead_sod { get; set; } = "";
        [DisplayName("Lead Type")]
        public string lead_type { get; set; } = "";
        [DisplayName("Back to Back Complete")]
        public bool lead_bBackToBackComplete { get; set; }
        [DisplayName("Lead Diamond Complete")]
        public bool lead_bDiamondComplete { get; set; }
        [DisplayName("Lead Georgian Complete")]
        public bool lead_bGeorgianComplete { get; set; }
        [DisplayName("Lead Bar Complete")]
        public bool lead_bBarComplete { get; set; }
        [DisplayName("Lead SG Design Complete")]
        public bool lead_bSGDesignComplete { get; set; }
        [DisplayName("Lock Make")]
        public string lock_make { get; set; } = "";
        [DisplayName("Lock Codes")]
        public string lock_codes { get; set; } = "";
        [DisplayName("Panel Complete")]
        [Browsable(false)]
        public bool bPanelComplete { get; set; }
        [DisplayName("Gear Box")]
        public int GearBox { get; set; }
        [DisplayName("Left Bolt")]
        public int left_bolt { get; set; }
        [DisplayName("Right Bolt")]
        public int right_bolt { get; set; }
        [DisplayName("Is Complete")]
        [Browsable(false)]
        public bool bComplete { get; set; }
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
        [DisplayName("Lead Comments")]
        public string lead_comments { get; set; } = "";
        [DisplayName("Is a Flat")]
        public bool? is_a_flat { get; set; }
        [DisplayName("Point of Entry")]
        public string point_of_entry { get; set; } = "";
        [DisplayName("Type of Locking System Required")]
        public string type_of_lockng_system_required { get; set; } = "";
        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }
        [DisplayName("Back to Back Spacer Width")]
        public string back_to_back_spacer_width { get; set; } = "";   // Spacer Thickness - Renamed from ex_s_spare4
        [DisplayName("Back to Back Spacer Height")]
        public string back_to_back_spacer_height { get; set; } = "";  // Overall Spacer Width - Renamed from ex_s_spare5
        [DisplayName("Lock Size 1")]
        public string l_size1 { get; set; } = "";                    // Lock Mech
        [DisplayName("Lock Size 2")]
        public string l_size2 { get; set; } = "";
        [DisplayName("Lock Size A")]
        public string l_sizeA { get; set; } = "";
        [DisplayName("Lock Size B")]
        public string l_sizeB { get; set; } = "";
        [DisplayName("Lock Size C")]
        public string l_sizeC { get; set; } = "";
        [DisplayName("Lock Size D")]
        public string l_sizeD { get; set; } = "";
        [DisplayName("Lock Size E")]
        public string l_sizeE { get; set; } = "";
        [DisplayName("Lock Size F")]
        public string l_sizeF { get; set; } = "";
        [DisplayName("Lock Size G")]
        public string l_sizeG { get; set; } = "";
        [DisplayName("Lock Number")]
        public int l_num { get; set; }
        [DisplayName("Lock FPos1")]
        public float l_fpos1 { get; set; }
        [DisplayName("Lock FPos2")]
        public float l_fpos2 { get; set; }
        [DisplayName("Lock FPos3")]
        public float l_fpos3 { get; set; }
        [DisplayName("Lock FPos4")]
        public float l_fpos4 { get; set; }
        [DisplayName("Lock FPos5")]
        public float l_fpos5 { get; set; }
        [DisplayName("Lock FPos6")]
        public float l_fpos6 { get; set; }
        [DisplayName("Lock FPos7")]
        public float l_fpos7 { get; set; }
        [DisplayName("Lock Position")]
        public float lock_position { get; set; }
        [DisplayName("Lock Type1")]
        public int l_itype1 { get; set; }
        [DisplayName("Lock Type2")]
        public int l_itype2 { get; set; }
        [DisplayName("Lock Type3")]
        public int l_itype3 { get; set; }
        [DisplayName("Lock Type4")]
        public int l_itype4 { get; set; }
        [DisplayName("Lock Type5")]
        public int l_itype5 { get; set; }
        [DisplayName("Lock Type6")]
        public int l_itype6 { get; set; }
        [DisplayName("Lock Type7")]
        public int l_itype7 { get; set; }
        [DisplayName("Lead C Width (float)")]
        public float lead_CWidthf { get; set; }
        [DisplayName("Lead C Height (float)")]
        public float lead_CHeightf { get; set; }
        [DisplayName("Lead C Widths")]
        public string lead_CWidths { get; set; } = "";
        [DisplayName("Lead C Heights")]
        public string lead_CHeights { get; set; } = "";
        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }
        [DisplayName("Replace Glass")]
        public bool? replace_glass { get; set; }
        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.alum,item_number,ContractCode); }

    }



}
