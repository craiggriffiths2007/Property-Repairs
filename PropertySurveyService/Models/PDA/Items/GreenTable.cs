using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class GreenTable
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

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }
        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Repair Reason")]
        public string? rep_reason { get; set; }

        [DisplayName("Material Type")]
        public string? material_type { get; set; }

        [DisplayName("Colour")]
        public string? colour { get; set; }

        [DisplayName("Glaze Type")]
        public string? glaze_type { get; set; }

        [DisplayName("Base Size")]
        public string? base_size { get; set; }

        [DisplayName("Base Size X")]
        public string? base_size_x { get; set; }

        [DisplayName("Base Size Y")]
        public string? base_size_y { get; set; }

        [DisplayName("Type of Glass")]
        public string? type_of_glass { get; set; }

        [DisplayName("Door Opening Type")]
        public string? door_opening_type { get; set; }

        [DisplayName("Window Opening Type")]
        public string? window_opening_type { get; set; }

        [DisplayName("Roof Opening Lights")]
        public int roof_opening_lights { get; set; }

        [DisplayName("Auto or Manual")]
        public int auto_or_manual { get; set; }

        [DisplayName("Overall Height")]
        public string? overall_height { get; set; }

        [DisplayName("Summary")]
        public string? summary { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("Parts to Order")]
        public string? parts_to_order { get; set; }

        [DisplayName("Point of Entry")]
        public string? point_of_entry { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string? type_of_lockng_system_required { get; set; }

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }

        [DisplayName("Change Item To")]
        public string? ChangeItemTo { get; set; }

        [DisplayName("Print Name")]
        public string? print_name { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }

        [DisplayName("Replace Glass")]
        public int replace_glass { get; set; }

        [DisplayName("Repair or Replace")]
        public int repair_or_replace { get; set; }

        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.green, item_number); }
    }


}
