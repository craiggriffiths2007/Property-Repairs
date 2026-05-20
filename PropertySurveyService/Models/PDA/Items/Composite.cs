using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Composite
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }

        public Guid Guid { get; set; }
        [DisplayName("Contract Number")]
        public string? ContractCode { get; set; }

        [DisplayName("Item Number")]
        public int item_number { get; set; }
        [DisplayName("Is Complete")]
        public bool bComplete { get; set; }

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }

        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Door Make")]
        public string? door_make { get; set; }

        [DisplayName("Opens")]
        public int opens { get; set; }

        [DisplayName("Is Lock")]
        public int is_lock { get; set; }

        [DisplayName("Frame Colour Inside")]
        public string? frame_colour_inside { get; set; }

        [DisplayName("Frame Colour Outside")]
        public string? frame_colour_outside { get; set; }

        [DisplayName("Door Colour Inside")]
        public string? door_colour_inside { get; set; }

        [DisplayName("Door Colour Outside")]
        public string? door_colour_outside { get; set; }

        [DisplayName("Door Design")]
        public string? door_design { get; set; }

        [DisplayName("Glass Design")]
        public string? glass_design { get; set; }

        [DisplayName("Internal Width")]
        public string? internal_width { get; set; }

        [DisplayName("Internal Height")]
        public string? internal_height { get; set; }

        [DisplayName("Brick Width")]
        public string? brick_width { get; set; }

        [DisplayName("Brick Height")]
        public string? brick_height { get; set; }

        [DisplayName("Trickle Vents")]
        public string? trickle_vents { get; set; }

        [DisplayName("Addons")]
        public int addons { get; set; }

        [DisplayName("Addons Height")]
        public string? addons_height { get; set; }

        [DisplayName("Addons Width")]
        public string? addons_width { get; set; }

        [DisplayName("Handle Colour")]
        public string? handle_colour { get; set; }

        [DisplayName("Threshold Type")]
        public string? threshold_type { get; set; }

        [DisplayName("Lever Pad Handles")]
        public int lever_pad_handles { get; set; }

        [DisplayName("Glass Pattern")]
        public string? glass_pattern { get; set; }

        [DisplayName("Glass Type")]
        public string? glass_type { get; set; }

        [DisplayName("Spacer Thickness")]
        public string? spacer_thickness { get; set; }

        [DisplayName("Spacer Colour")]
        public string? spacer_colour { get; set; }

        [DisplayName("Profile Type")]
        public int profile_type { get; set; }

        [DisplayName("Room Location")]
        public string? room_location { get; set; }

        [DisplayName("Special Glass")]
        public string? special_glass { get; set; }

        [DisplayName("Comments")]
        public string? comments { get; set; }

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

        [DisplayName("DOCL")]
        public string? docl { get; set; }

        [DisplayName("Letter Edit")]
        public string? letteredit { get; set; }

        [DisplayName("Letter Box Position")]
        public string? letter_box_pos { get; set; }

        [DisplayName("Pet Flap")]
        public string? pet_flap { get; set; }

        [DisplayName("Pet Type")]
        public string? pet_type { get; set; }

        [DisplayName("Pet Magnetic")]
        public int pet_magnetic { get; set; }

        [DisplayName("Glaze")]
        public int glaze { get; set; }

        [DisplayName("Print Name")]
        public string? print_name { get; set; }

        [DisplayName("Lead Diamond Complete")]
        public bool lead_bDiamondComplete { get; set; }

        [DisplayName("Lead Georgian Complete")]
        public bool lead_bGeorgianComplete { get; set; }

        [DisplayName("Lead Bar Complete")]
        public bool lead_bBarComplete { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }

        [DisplayName("Lock Other Text")]
        public string? lock_other_text { get; set; }

        [DisplayName("Head Drip")]
        public int head_drip { get; set; }

        [DisplayName("Change Item To")]
        public string? ChangeItemTo { get; set; }

        [DisplayName("Cills")]
        public string? cills { get; set; }

        [DisplayName("Door Wood")]
        public string? door_wood { get; set; }

        [DisplayName("Hinged On")]
        public int hinged_on { get; set; }

        [DisplayName("Reason Not Repaired")]
        public string? reason_not_repaired { get; set; }

        [DisplayName("Lead Comments")]
        public string? lead_comments { get; set; }

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

        [DisplayName("Fire Door")]
        public int fire_door { get; set; }

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

        [DisplayName("Repair Item")]
        public bool bRepair { get; set; }

        [DisplayName("FENSA")]
        public bool fensa { get; set; }

        [DisplayName("WER Rating")]
        public string? WER_rating { get; set; }

        [DisplayName("Gaskets")]
        public int gaskets { get; set; }

        [DisplayName("Gaskets Text")]
        public string? gaskets_text { get; set; }

        [DisplayName("Handles Required")]
        public int handles_req { get; set; }

        [DisplayName("Handle Drawing Complete")]
        public bool bHandleDrawingComplete { get; set; }

        [DisplayName("Handles Text")]
        public string? handles_text { get; set; }

        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.comp, item_number); }
    }

}
