using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{ 
    public class ConsTable
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
        [DisplayName("Type")]
        public string? type { get; set; }

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }

        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Material Type")]
        public int material_type { get; set; }

        [DisplayName("Size A")]
        public string? sizeA { get; set; }

        [DisplayName("Size B")]
        public string? sizeB { get; set; }

        [DisplayName("Size C")]
        public string? sizeC { get; set; }

        [DisplayName("Size D")]
        public string? sizeD { get; set; }

        [DisplayName("Size E")]
        public string? sizeE { get; set; }

        [DisplayName("Size F")]
        public string? sizeF { get; set; }

        [DisplayName("Size G")]
        public string? sizeG { get; set; }

        [DisplayName("Angle 1")]
        public string? angle1 { get; set; }

        [DisplayName("Angle 2")]
        public string? angle2 { get; set; }

        [DisplayName("Angle 3")]
        public string? angle3 { get; set; }

        [DisplayName("Angle 4")]
        public string? angle4 { get; set; }

        [DisplayName("Pitch Height")]
        public string? pitch_height { get; set; }

        [DisplayName("Profile Section Size")]
        public string? profile_section_size { get; set; }

        [DisplayName("Sheet Width 1")]
        public string? sheet_width_1 { get; set; }

        [DisplayName("Sheet Height 1")]
        public string? sheet_height_1 { get; set; }

        [DisplayName("Sheet Width 2")]
        public string? sheet_width_2 { get; set; }

        [DisplayName("Sheet Height 2")]
        public string? sheet_height_2 { get; set; }

        [DisplayName("Sheet Width 3")]
        public string? sheet_width_3 { get; set; }

        [DisplayName("Sheet Height 3")]
        public string? sheet_height_3 { get; set; }

        [DisplayName("Sheet Width 4")]
        public string? sheet_width_4 { get; set; }

        [DisplayName("Sheet Height 4")]
        public string? sheet_height_4 { get; set; }

        [DisplayName("Sheet Width 5")]
        public string? sheet_width_5 { get; set; }

        [DisplayName("Sheet Height 5")]
        public string? sheet_height_5 { get; set; }

        [DisplayName("Sheet Width 6")]
        public string? sheet_width_6 { get; set; }

        [DisplayName("Sheet Height 6")]
        public string? sheet_height_6 { get; set; }

        [DisplayName("Sheet Width 7")]
        public string? sheet_width_7 { get; set; }

        [DisplayName("Sheet Height 7")]
        public string? sheet_height_7 { get; set; }

        [DisplayName("Sheet Width 8")]
        public string? sheet_width_8 { get; set; }

        [DisplayName("Sheet Height 8")]
        public string? sheet_height_8 { get; set; }

        [DisplayName("Sheet Width 9")]
        public string? sheet_width_9 { get; set; }

        [DisplayName("Sheet Height 9")]
        public string? sheet_height_9 { get; set; }

        [DisplayName("Sheet Width 10")]
        public string? sheet_width_10 { get; set; }

        [DisplayName("Sheet Height 10")]
        public string? sheet_height_10 { get; set; }

        [DisplayName("Flute Size")]
        public string? flute_size { get; set; }

        [DisplayName("Color")]
        public string? color { get; set; }

        [DisplayName("Roof Color")]
        public string? roof_color { get; set; }

        [DisplayName("New Firrings Required")]
        public int new_firrings_req { get; set; }

        [DisplayName("New Gutters Required")]
        public int new_gutters_req { get; set; }

        [DisplayName("Roof Glazing Thickness")]
        public string? roof_glazing_thickness { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

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

        [DisplayName("Wall Position")]
        public string? wall_pos { get; set; }

        [DisplayName("Pitch Degree")]
        public string? pitch_degree { get; set; }

        [DisplayName("Long Comments")]
        public string? long_comments { get; set; }

        [DisplayName("Drawings Only")]
        public int bDrawingsOnly { get; set; }

        [DisplayName("Roof Under Drawn")]
        public bool cons_roof_under_drawn { get; set; }

        [DisplayName("Does Roof Fit Under")]
        public int does_roof_fit_under { get; set; }

        [DisplayName("Spars Line Up")]
        public int spars_line_up { get; set; }

        [DisplayName("Roof Sheets Quantity 1")]
        public int roof_sheets_quantity_1 { get; set; }

        [DisplayName("Roof Sheets Quantity 2")]
        public int roof_sheets_quantity_2 { get; set; }

        [DisplayName("Roof Sheets Quantity 3")]
        public int roof_sheets_quantity_3 { get; set; }

        [DisplayName("Roof Sheets Quantity 4")]
        public int roof_sheets_quantity_4 { get; set; }

        [DisplayName("Roof Sheets Quantity 5")]
        public int roof_sheets_quantity_5 { get; set; }

        [DisplayName("Roof Sheets Quantity 6")]
        public int roof_sheets_quantity_6 { get; set; }

        [DisplayName("Roof Sheets Quantity 7")]
        public int roof_sheets_quantity_7 { get; set; }

        [DisplayName("Roof Sheets Quantity 8")]
        public int roof_sheets_quantity_8 { get; set; }

        [DisplayName("Roof Sheets Quantity 9")]
        public int roof_sheets_quantity_9 { get; set; }

        [DisplayName("Roof Sheets Quantity 10")]
        public int roof_sheets_quantity_10 { get; set; }

        [DisplayName("Good Conditions")]
        public int good_conditions { get; set; }

        [DisplayName("Ridge Length")]
        public string? ridge_length { get; set; }

        [DisplayName("Parts to Order")]
        public string? parts_to_order { get; set; }

        [DisplayName("Point of Entry")]
        public string? point_of_entry { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string? type_of_lockng_system_required { get; set; }

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }

        [DisplayName("Replace Glass")]
        public int replace_glass { get; set; }

        [DisplayName("Reason Not Repaired")]
        public string? reason_not_repaired { get; set; }

        [DisplayName("Repair Item")]
        public bool bRepair { get; set; }

        [DisplayName("FENSA")]
        public bool fensa { get; set; }

        [DisplayName("WER Rating")]
        public string? WER_rating { get; set; }

        [DisplayName("Overall Length of Sheet")]
        public string? overall_length_of_sheet { get; set; }

        [DisplayName("Lead Diamond Complete")]
        public bool lead_bDiamondComplete { get; set; }

        [DisplayName("Lead Georgian Complete")]
        public bool lead_bGeorgianComplete { get; set; }

        [DisplayName("Lead Bar Complete")]
        public bool lead_bBarComplete { get; set; }

        [DisplayName("Lead C Width (float)")]
        public float lead_CWidthf { get; set; }

        [DisplayName("Lead C Height (float)")]
        public float lead_CHeightf { get; set; }

        [DisplayName("Lead C Widths")]
        public string lead_CWidths { get; set; } = "";

        [DisplayName("Lead C Heights")]
        public string lead_CHeights { get; set; } = "";


        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.cons); }
    }

}
