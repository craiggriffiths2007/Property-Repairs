using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class BifoldTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }
        [DisplayName("Contract Number")]
        public string? udi_cont { get; set; } // Key field contract number

        [DisplayName("Item Number")]
        public int item_number { get; set; }

        [DisplayName("Internal Width")]
        public string? internal_width { get; set; }

        [DisplayName("Internal Height")]
        public string? internal_height { get; set; }

        [DisplayName("Overall Width")]
        public string? overall_width { get; set; }

        [DisplayName("Overall Height")]
        public string? overall_height { get; set; }

        [DisplayName("Opens (In/Out)")]
        public int opens { get; set; }

        [DisplayName("Trickle Vents (Yes/No)")]
        public int trickle_vents { get; set; }

        [DisplayName("Hardware")]
        public string? hardware { get; set; }

        [DisplayName("Internal Color")]
        public string? color_internal { get; set; }

        [DisplayName("External Color")]
        public string? color_external { get; set; }

        [DisplayName("Threshold Type")]
        public string? threshold_type { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("Is Complete")]
        public int isComplete { get; set; }

        [DisplayName("Comments")]
        public string? comments { get; set; }

        [DisplayName("Bifold Signed")]
        public int bifold_signed { get; set; }

        [DisplayName("Number of Doors")]
        public int number_of_doors { get; set; }

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }

        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Door Type")]
        public string? door_type { get; set; }

        [DisplayName("Glazing Options")]
        public string? glazing_options { get; set; }

        [DisplayName("Number of Doors (Text)")]
        public string? number_of_doors_text { get; set; }

        [DisplayName("Colour of Doors")]
        public string? colour_of_doors { get; set; }

        [DisplayName("Handle Colour")]
        public string? handle_colour { get; set; }

        [DisplayName("Cill Type")]
        public string? cill_type { get; set; }

        [DisplayName("Knock On")]
        public string? knock_on { get; set; }

        [DisplayName("Internal Door Colour")]
        public string? internal_door_colour { get; set; }

        [DisplayName("Spare 12")]
        public string? s_spare12 { get; set; }

        [DisplayName("Parts to Order")]
        public string? parts_to_order { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string? type_of_lockng_system_required { get; set; }

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }

        [DisplayName("Point of Entry")]
        public int point_of_entry { get; set; }

        [DisplayName("Change Item To")]
        public string? ChangeItemTo { get; set; }

        [DisplayName("Print Name")]
        public string? print_name { get; set; }

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }

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

        [DisplayName("Addons")]
        public int addons { get; set; }

        [DisplayName("Addon Width")]
        public string? addon_width { get; set; }

        [DisplayName("Addon Height")]
        public string? addon_height { get; set; }

        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.bifold); }

    }
}
