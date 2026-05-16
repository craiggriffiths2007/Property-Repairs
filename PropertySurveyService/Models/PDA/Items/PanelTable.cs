using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class PanelTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public Guid Guid { get; set; }
        [DisplayName("Contract Number")]
        public string? udi_cont { get; set; } // Key field contract number

        [DisplayName("Item Number")]
        public int item_number { get; set; }

        [DisplayName("Is Complete")]
        public bool bComplete { get; set; }

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }

        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Knock Edit")]
        public string? knockedit { get; set; }

        [DisplayName("Knocol Edit")]
        public string? knocoledit { get; set; }

        [DisplayName("Letter Edit")]
        public string? letteredit { get; set; }
		[DisplayName("Letter Box Position")]
        public string? letter_box_pos { get; set; }

        [DisplayName("Width (text)")]
        public string? wedit { get; set; }

        [DisplayName("Height (text)")]
        public string? hedit { get; set; }

        [DisplayName("Panel Type (text)")]
        public string? typeedit { get; set; }

        [DisplayName("Thickness (text)")]
        public string? thickedit { get; set; }

        [DisplayName("Backg Edit")]
        public string? backgedit { get; set; }

        [DisplayName("Color Edit")]
        public string? coledit { get; set; }

        [DisplayName("Glass Type (text)")]
        public string? gltext { get; set; }

        [DisplayName("Spacer Color Edit")]
        public string? spaccoloedit { get; set; }

        [DisplayName("Pet Flap")]
        public string? pet_flap { get; set; }

        [DisplayName("Pet Type")]
        public string? pet_type { get; set; }

        [DisplayName("Pet Magnetic")]
        public int pet_magnetic { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("Room Location")]
        public string? room_location { get; set; }

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }

        [DisplayName("Change Item To")]
        public string? ChangeItemTo { get; set; }

        [DisplayName("Print Name")]
        public string? print_name { get; set; }

        [DisplayName("Comments")]
        public string? long_sptext { get; set; }


        [DisplayName("Parts to Order")]
        public string? parts_to_order { get; set; }

        [DisplayName("Point of Entry")]
        public string? point_of_entry { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string? type_of_lockng_system_required { get; set; }

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }

        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.panel); }
    }
}
