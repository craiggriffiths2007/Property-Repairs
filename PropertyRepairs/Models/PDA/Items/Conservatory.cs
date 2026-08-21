using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyRepairs.Models
{ 
    public class Conservatory
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.conservatory;

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
        // COMMON - BASIC ITEM / REPAIR INFORMATION
        // ============================================================

        [DisplayName("Repair Item")]
        public bool bRepair { get; set; }

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";

        [DisplayName("Reason Not Repaired")]
        public string reason_not_repaired { get; set; } = "";


        // ============================================================
        // COMMON - GLASS
        // ============================================================

        [DisplayName("Replace Glass")]
        public bool? replace_glass { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }


        // ============================================================
        // COMMON - COMPLIANCE / LOCATION / CHANGES
        // ============================================================

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
        // CONSERVATORY - BASIC DETAILS
        // ============================================================

        [DisplayName("Type")]
        public string type { get; set; } = "";

        [DisplayName("Material Type")]
        public string material_type { get; set; } = "";

        [DisplayName("Color")]
        public string color { get; set; } = "";

        [DisplayName("Roof Color")]
        public string roof_color { get; set; } = "";

        [DisplayName("Profile Section Size")]
        public string profile_section_size { get; set; } = "";


        // ============================================================
        // CONSERVATORY - MAIN SIZES
        // ============================================================

        [DisplayName("Size A")]
        public string sizeA { get; set; } = "";

        [DisplayName("Size B")]
        public string sizeB { get; set; } = "";

        [DisplayName("Size C")]
        public string sizeC { get; set; } = "";

        [DisplayName("Size D")]
        public string sizeD { get; set; } = "";

        [DisplayName("Size E")]
        public string sizeE { get; set; } = "";

        [DisplayName("Size F")]
        public string sizeF { get; set; } = "";

        [DisplayName("Size G")]
        public string sizeG { get; set; } = "";

        [DisplayName("Pitch Height")]
        public string pitch_height { get; set; } = "";

        [DisplayName("Pitch Degree")]
        public string pitch_degree { get; set; } = "";

        [DisplayName("Ridge Length")]
        public string ridge_length { get; set; } = "";

        [DisplayName("Wall Position")]
        public string wall_pos { get; set; } = "";


        // ============================================================
        // CONSERVATORY - ANGLES
        // ============================================================

        [DisplayName("Angle 1")]
        public string angle1 { get; set; } = "";

        [DisplayName("Angle 2")]
        public string angle2 { get; set; } = "";

        [DisplayName("Angle 3")]
        public string angle3 { get; set; } = "";

        [DisplayName("Angle 4")]
        public string angle4 { get; set; } = "";


        // ============================================================
        // CONSERVATORY - ROOF / FITTING
        // ============================================================

        [DisplayName("Flute Size")]
        public string flute_size { get; set; } = "";

        [DisplayName("Roof Glazing Thickness")]
        public string roof_glazing_thickness { get; set; } = "";

        [DisplayName("Overall Length of Sheet")]
        public string overall_length_of_sheet { get; set; } = "";

        [DisplayName("New Firrings Required")]
        public bool? new_firrings_req { get; set; }

        [DisplayName("New Gutters Required")]
        public bool? new_gutters_req { get; set; }

        [DisplayName("Drawings Only")]
        public bool? bDrawingsOnly { get; set; }

        [DisplayName("Roof Under Drawn")]
        public bool cons_roof_under_drawn { get; set; }

        [DisplayName("Does Roof Fit Under")]
        public bool? does_roof_fit_under { get; set; }

        [DisplayName("Spars Line Up")]
        public bool? spars_line_up { get; set; }

        [DisplayName("Good Conditions")]
        public bool? good_conditions { get; set; }


        // ============================================================
        // CONSERVATORY - ROOF SHEET SIZES
        // ============================================================

        [DisplayName("Sheet Width 1")]
        public string sheet_width_1 { get; set; } = "";

        [DisplayName("Sheet Height 1")]
        public string sheet_height_1 { get; set; } = "";

        [DisplayName("Sheet Width 2")]
        public string sheet_width_2 { get; set; } = "";

        [DisplayName("Sheet Height 2")]
        public string sheet_height_2 { get; set; } = "";

        [DisplayName("Sheet Width 3")]
        public string sheet_width_3 { get; set; } = "";

        [DisplayName("Sheet Height 3")]
        public string sheet_height_3 { get; set; } = "";

        [DisplayName("Sheet Width 4")]
        public string sheet_width_4 { get; set; } = "";

        [DisplayName("Sheet Height 4")]
        public string sheet_height_4 { get; set; } = "";

        [DisplayName("Sheet Width 5")]
        public string sheet_width_5 { get; set; } = "";

        [DisplayName("Sheet Height 5")]
        public string sheet_height_5 { get; set; } = "";

        [DisplayName("Sheet Width 6")]
        public string sheet_width_6 { get; set; } = "";

        [DisplayName("Sheet Height 6")]
        public string sheet_height_6 { get; set; } = "";

        [DisplayName("Sheet Width 7")]
        public string sheet_width_7 { get; set; } = "";

        [DisplayName("Sheet Height 7")]
        public string sheet_height_7 { get; set; } = "";

        [DisplayName("Sheet Width 8")]
        public string sheet_width_8 { get; set; } = "";

        [DisplayName("Sheet Height 8")]
        public string sheet_height_8 { get; set; } = "";

        [DisplayName("Sheet Width 9")]
        public string sheet_width_9 { get; set; } = "";

        [DisplayName("Sheet Height 9")]
        public string sheet_height_9 { get; set; } = "";

        [DisplayName("Sheet Width 10")]
        public string sheet_width_10 { get; set; } = "";

        [DisplayName("Sheet Height 10")]
        public string sheet_height_10 { get; set; } = "";


        // ============================================================
        // CONSERVATORY - ROOF SHEET QUANTITIES
        // ============================================================

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
        public string ItemTitle => "Conservatory" + (bRepair ? " Repair" : " Replace");

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
