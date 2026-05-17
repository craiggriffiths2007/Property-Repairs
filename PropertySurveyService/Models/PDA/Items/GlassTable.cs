using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class GlassTable
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

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }
        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Units Required")]
        public int units_required { get; set; }

        [DisplayName("Glass Width")]
        public string? glass_width { get; set; }

        [DisplayName("Glass Height")]
        public string? glass_height { get; set; }

        [DisplayName("Glass Width 2")]
        public string? glass_width2 { get; set; }

        [DisplayName("Glass Height 2")]
        public string? glass_height2 { get; set; }

        [DisplayName("Glass Width 3")]
        public string? glass_width3 { get; set; }

        [DisplayName("Glass Height 3")]
        public string? glass_height3 { get; set; }

        [DisplayName("Glass Width 4")]
        public string? glass_width4 { get; set; }

        [DisplayName("Glass Height 4")]
        public string? glass_height4 { get; set; }

        [DisplayName("Glass Width 5")]
        public string? glass_width5 { get; set; }

        [DisplayName("Glass Height 5")]
        public string? glass_height5 { get; set; }

        [DisplayName("Glass Width 6")]
        public string? glass_width6 { get; set; }

        [DisplayName("Glass Height 6")]
        public string? glass_height6 { get; set; }

        [DisplayName("Glass Width 7")]
        public string? glass_width7 { get; set; }

        [DisplayName("Glass Height 7")]
        public string? glass_height7 { get; set; }

        [DisplayName("Glass Width 8")]
        public string? glass_width8 { get; set; }

        [DisplayName("Glass Height 8")]
        public string? glass_height8 { get; set; }

        [DisplayName("Stepped Unit")]
        public int stepped_unit { get; set; }

        [DisplayName("Internal Width")]
        public string? int_width { get; set; }

        [DisplayName("Internal Height")]
        public string? int_height { get; set; }

        [DisplayName("Single or Double")]
        public int single_or_double { get; set; }

        [DisplayName("Glass Type")]
        public string? glass_type { get; set; }

        [DisplayName("Size A")]
        public string? sizeA { get; set; }

        [DisplayName("Size B")]
        public string? sizeB { get; set; }

        [DisplayName("Size C")]
        public string? sizeC { get; set; }

        [DisplayName("Size D")]
        public string? sizeD { get; set; }

        [DisplayName("Lead C Width")]
        public string? lead_CWidth { get; set; }

        [DisplayName("Lead C Height")]
        public string? lead_CHeight { get; set; }

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

        [DisplayName("Glass Pattern")]
        public string? glass_pattern { get; set; }

        [DisplayName("Spacer Color")]
        public string? spacer_color { get; set; }

        [DisplayName("Spacer Thickness")]
        public string? spacer_thickness { get; set; }

        [DisplayName("Special Glass")]
        public string? special_glass { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("DOCL Old")]
        public string? docl_old { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Georgian Bar Trim")]
        public int gb_trim { get; set; }

        [DisplayName("DOCL")]
        public string? docl { get; set; }

        [DisplayName("Room Location")]
        public string? room_location { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }

        [DisplayName("Change Item To")]
        public string? ChangeItemTo { get; set; }

        [DisplayName("Print Name")]
        public string? print_name { get; set; }

        [DisplayName("Product Into")]
        public string? ProductInto { get; set; }

        [DisplayName("Glazing Type")]
        public string? glazing_type { get; set; }

        [DisplayName("Long Comments")]
        public string? long_comments { get; set; }

        [DisplayName("Lead Pos X")]
        public float lead_posX { get; set; }

        [DisplayName("Lead Pos Y")]
        public float lead_posY { get; set; }

        [DisplayName("Tape or Gasket")]
        public string? TapeorGasket { get; set; }

        [DisplayName("Glaze")]
        public int glaze { get; set; }

        [DisplayName("Lead Comments")]
        public string? lead_comments { get; set; }

        [DisplayName("Collect and Copy")]
        public int collect_and_copy { get; set; }

        [DisplayName("Temporary")]
        public int temporary { get; set; }

        [DisplayName("Parts to Order")]
        public string? parts_to_order { get; set; }

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

        [DisplayName("Lead C Width (float)")]
        public float lead_CWidthf { get; set; }

        [DisplayName("Lead C Height (float)")]
        public float lead_CHeightf { get; set; }

        [DisplayName("Size A (float)")]
        public float sizeAf { get; set; }

        [DisplayName("Size B (float)")]
        public float sizeBf { get; set; }

        [DisplayName("Size C (float)")]
        public float sizeCf { get; set; }

        [DisplayName("Size D (float)")]
        public float sizeDf { get; set; }

        [DisplayName("Lead C Widths")]
        public string? lead_CWidths { get; set; }

        [DisplayName("Lead C Heights")]
        public string? lead_CHeights { get; set; }

        [DisplayName("Parent Item")]
        public int parent_item { get; set; }

        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.glass, item_number); }
    }

}
