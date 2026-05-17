using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class UPVCTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public Guid Guid { get; set; }

        [DisplayName("Contract Number")]
        public string? udi_cont { get; set; }

        [DisplayName("Item Number")]
        public int item_number { get; set; }

        [DisplayName("Is Complete")]
        public bool bComplete { get; set; }

        [DisplayName("Repair Item")]
        public bool bRepair { get; set; }
        [DisplayName("Cosmetic Damage")]
        public int cosmetic_damage { get; set; }

        [DisplayName("Additional Locks")]
        public string? additional_locks { get; set; }

        [DisplayName("Gaskets")]
        public int gaskets { get; set; }

        [DisplayName("Gaskets Text")]
        public string? gaskets_text { get; set; }

        [DisplayName("Handles Required")]
        public int handles_req { get; set; }

        [DisplayName("Handles Text")]
        public string? handles_text { get; set; }

        [DisplayName("Replace Panel")]
        public int replace_panel { get; set; }

        [DisplayName("Replace Reason")]
        public string? replace_reason { get; set; }

        [DisplayName("Replace Explain")]
        public string? replace_explain { get; set; }

        [DisplayName("UPVC Item")]
        public string? upvc_item { get; set; }

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }

        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Colour")]
        public string? colour { get; set; }

        [DisplayName("Cills")]
        public string? cills { get; set; }

        [DisplayName("Outer Section Size")]
        public string? outer_section_size { get; set; }

        [DisplayName("Internal Width")]
        public string? internal_width { get; set; }

        [DisplayName("Internal Height")]
        public string? internal_height { get; set; }

        [DisplayName("Brick Width")]
        public string? brick_width { get; set; }

        [DisplayName("Brick Height")]
        public string? brick_height { get; set; }

        [DisplayName("Midrail")]
        public int midrail { get; set; }

        [DisplayName("Addons")]
        public int addons { get; set; }

        [DisplayName("Addon Width")]
        public string? addon_width { get; set; }

        [DisplayName("Addon Height")]
        public string? addon_height { get; set; }

        [DisplayName("Head Drip")]
        public int head_drip { get; set; }

        [DisplayName("Handle Colour")]
        public string? handle_colour { get; set; }

        [DisplayName("Locking Type")]
        public string? locking_type { get; set; }

        [DisplayName("Letter Box")]
        public string? letter_box { get; set; }

        [DisplayName("Letter Box Position")]
        public string? letter_box_pos { get; set; }

        [DisplayName("Pet Flap")]
        public string? pet_flap { get; set; }

        [DisplayName("Pet Type")]
        public string? pet_type { get; set; }

        [DisplayName("Pet Magnetic")]
        public int pet_magnetic { get; set; }

        [DisplayName("Bead Type")]
        public string? bead_type { get; set; }

        [DisplayName("Opens (In/Out)")]
        public int opens { get; set; }

        [DisplayName("Glaze (Internal/External)")]
        public int glaze { get; set; }

        [DisplayName("Trickle Vents (Yes/No)")]
        public int trickle_vents { get; set; }

        [DisplayName("Spacer Thickness")]
        public string? spacer_thickness { get; set; }

        [DisplayName("Spacer Colour")]
        public string? spacer_colour { get; set; }

        [DisplayName("Glass Type")]
        public string? glass_type { get; set; }

        [DisplayName("Glass Pattern")]
        public string? glass_pattern { get; set; }

        [DisplayName("Special Glass")]
        public string? special_glass { get; set; }

        [DisplayName("Double/Tripple")]
        public int double_tripple { get; set; }

        [DisplayName("Internal Lock")]
        public int internal_lock { get; set; }

        [DisplayName("New Locking Mechanism")]
        public int bNewLockingMech { get; set; }

        [DisplayName("Lock Complete")]
        public bool bLockComplete { get; set; }

        [DisplayName("Handle Drawing Complete")]
        public bool bHandleDrawingComplete { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Midrail Height")]
        public string? midrail_height { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Frame Depth")]
        public string? frame_depth { get; set; }

        [DisplayName("DOCL")]
        public string? docl { get; set; }

        [DisplayName("Profile Type")]
        public int profile_type { get; set; }

        [DisplayName("Room Location")]
        public string? room_location { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("LP Handles")]
        public int LPHandles { get; set; }

        [DisplayName("Slide Position")]
        public int slide_position { get; set; }

        [DisplayName("Threshold Type")]
        public string? threshold_type { get; set; }

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }

        [DisplayName("Change Item To")]
        public string? ChangeItemTo { get; set; }

        [DisplayName("Print Name")]
        public string? print_name { get; set; }

        [DisplayName("FENSA")]
        public bool fensa { get; set; }

        [DisplayName("WER Rating")]
        public string? WER_Rating { get; set; }

        [DisplayName("Long Comments")]
        public string? long_comments { get; set; }

        [DisplayName("Door Complete")]
        public bool bDoorComplete { get; set; }

        [DisplayName("Window Complete")]
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
        public string? lead_thickness { get; set; }

        [DisplayName("Lead SOD")]
        public string? lead_sod { get; set; }

        [DisplayName("Lead Type")]
        public string? lead_type { get; set; }

        [DisplayName("Lead Diamond Complete")]
        public bool lead_bDiamondComplete { get; set; }

        [DisplayName("Lead Georgian Complete")]
        public bool lead_bGeorgianComplete { get; set; }

        [DisplayName("Lead Bar Complete")]
        public bool lead_bBarComplete { get; set; }

        [DisplayName("Lead SG Design Complete")]
        public bool lead_bSGDesignComplete { get; set; }

        [DisplayName("Lock Make")]
        public string? lock_make { get; set; }

        [DisplayName("Lock Codes")]
        public string? lock_codes { get; set; }

        [DisplayName("Panel Complete")]
        public bool bPanelComplete { get; set; }

        [DisplayName("Left Bolt")]
        public int left_bolt { get; set; }

        [DisplayName("Right Bolt")]
        public int right_bolt { get; set; }

        [DisplayName("Gear Box")]
        public int GearBox { get; set; }

        [DisplayName("Hinge Colour")]
        public string? hinge_colour { get; set; }

        [DisplayName("Lead Comments")]
        public string? lead_comments { get; set; }

        [DisplayName("Collect and Copy")]
        public int collect_and_copy { get; set; }

        [DisplayName("Temporary")]
        public int temporary { get; set; }

        [DisplayName("Parts to Order")]
        public string? parts_to_order { get; set; }

        [DisplayName("Is a Flat")]
        public int is_a_flat { get; set; }

        [DisplayName("Point of Entry")]
        public string? point_of_entry { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string? type_of_lockng_system_required { get; set; }

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }

        [DisplayName("Back to Back Spacer Width")]
        public string? back_to_back_spacer_width { get; set; }

        [DisplayName("Back to Back Spacer Height")]
        public string? back_to_back_spacer_height { get; set; }

        [DisplayName("Lock Size 1")]
        public string? l_size1 { get; set; }

        [DisplayName("Lock Size 2")]
        public string? l_size2 { get; set; }

        [DisplayName("Lock Size A")]
        public string? l_sizeA { get; set; }

        [DisplayName("Lock Size B")]
        public string? l_sizeB { get; set; }

        [DisplayName("Lock Size C")]
        public string? l_sizeC { get; set; }

        [DisplayName("Lock Size D")]
        public string? l_sizeD { get; set; }

        [DisplayName("Lock Size E")]
        public string? l_sizeE { get; set; }

        [DisplayName("Lock Size F")]
        public string? l_sizeF { get; set; }

        [DisplayName("Lock Size G")]
        public string? l_sizeG { get; set; }

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

        [DisplayName("Lock IType1")]
        public int l_itype1 { get; set; }

        [DisplayName("Lock IType2")]
        public int l_itype2 { get; set; }

        [DisplayName("Lock IType3")]
        public int l_itype3 { get; set; }

        [DisplayName("Lock IType4")]
        public int l_itype4 { get; set; }

        [DisplayName("Lock IType5")]
        public int l_itype5 { get; set; }

        [DisplayName("Lock IType6")]
        public int l_itype6 { get; set; }

        [DisplayName("Lock IType7")]
        public int l_itype7 { get; set; }

        [DisplayName("Lead C Width (float)")]
        public float lead_CWidthf { get; set; }

        [DisplayName("Lead C Height (float)")]
        public float lead_CHeightf { get; set; }

        [DisplayName("Lead C Widths")]
        public string? lead_CWidths { get; set; }

        [DisplayName("Lead C Heights")]
        public string? lead_CHeights { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }

        [DisplayName("Replace Glass")]
        public int replace_glass { get; set; }
        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.upvc, item_number); }
    }

}
