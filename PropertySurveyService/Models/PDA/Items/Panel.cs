using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Panel
    {
        [Key]
        [Browsable(false)]
        [DisplayName("Record Id")]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.panel;

        [Browsable(false)]
        [DisplayName("Header Id")]
        public int HeaderId { get; set; }
        [Browsable(false)]
        public Guid Guid { get; set; } = Guid.NewGuid();
        [Browsable(false)]
        [DisplayName("Contract Number")]
        public string ContractCode { get; set; } = "";// Key field contract number
        [Browsable(false)]
        [DisplayName("Item Number")]
        public int item_number { get; set; }
        [Browsable(false)]
        [DisplayName("Is Complete")]
        public bool bComplete { get; set; }

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";

        [DisplayName("Knock Edit")]
        public string knockedit { get; set; } = "";

        [DisplayName("Knocol Edit")]
        public string knocoledit { get; set; } = "";

        [DisplayName("Letter Edit")]
        public string letteredit { get; set; } = "";

        [DisplayName("Letter Box Position")]
        public string letter_box_pos { get; set; } = "";

        [DisplayName("Width (text)")]
        public string wedit { get; set; } = "";

        [DisplayName("Height (text)")]
        public string hedit { get; set; } = "";

        [DisplayName("Panel Type (text)")]
        public string typeedit { get; set; } = "";

        [DisplayName("Thickness (text)")]
        public string thickedit { get; set; } = "";

        [DisplayName("Backg Edit")]
        public string backgedit { get; set; } = "";

        [DisplayName("Color Edit")]
        public string coledit { get; set; } = "";

        [DisplayName("Glass Type (text)")]
        public string gltext { get; set; } = "";

        [DisplayName("Spacer Color Edit")]
        public string spaccoloedit { get; set; } = "";

        [DisplayName("Pet Flap")]
        public string pet_flap { get; set; } = "";

        [DisplayName("Pet Type")]
        public string pet_type { get; set; } = "";

        [DisplayName("Pet Magnetic")]
        public string pet_magnetic { get; set; } = "...";

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("Room Location")]
        public string room_location { get; set; } = "";

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginalSigned { get; set; }


        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;

        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";

        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";

        [DisplayName("Summary")]
        public string Summary { get; set; } = "";

        [DisplayName("Parts to Order")]
        public string parts_to_order { get; set; } = "";

        [DisplayName("Point of Entry")]
        public string point_of_entry { get; set; } = "";

        [DisplayName("Type of Locking System Required")]
        public string type_of_lockng_system_required { get; set; } = "";

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }
        [DisplayName("Parent Item")]
        public enum_item_type base_item { get; set; } = enum_item_type.none;

        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.panel, item_number, ContractCode); }
    }
}
