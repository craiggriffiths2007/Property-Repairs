using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class GarageTable
    {
        [Key]
        public int Id { get; set; }
        public int HeaderId { get; set; }

        public Guid Guid { get; set; }
        [DisplayName("Contract Number")]
        public string? udi_cont { get; set; }            // Key fieled contract number			CONTRACT NUMBER

        [DisplayName("Item Number")]
        public int item_number { get; set; }

        [DisplayName("Opening Direction")]
        public int opening_direction { get; set; }      // Renamed from item_attached_to

        [DisplayName("Cause of Damage")]
        public string? cause_of_damage { get; set; }

        [DisplayName("Reason Damage Different")]
        public string? cause_of_damage_reason_different { get; set; }

        [DisplayName("Door Fits Into")]
        public int door_fits_into { get; set; }

        [DisplayName("New Subframe Required")]
        public int new_subframe_req { get; set; }
        [DisplayName("Obstruction Outside (Bool)")]
        public int obstruction_outside_b { get; set; }

        [DisplayName("Obstruction Outside")]
        public string? obstruction_outside { get; set; }

        [DisplayName("Obstruction Inside (Bool)")]
        public int obstruction_inside_b { get; set; }

        [DisplayName("Obstruction Inside")]
        public string? obstruction_inside { get; set; }

        [DisplayName("Actual Door Width")]
        public string? actual_door_width { get; set; }

        [DisplayName("Actual Door Height")]
        public string? actual_door_height { get; set; }

        [DisplayName("Frame Fix Type")]
        public int frame_fix_type { get; set; }

        [DisplayName("Type of Garage")]
        public string? type_of_garage { get; set; }

        [DisplayName("New Electric Operator Required")]
        public string? new_electric_operator_req { get; set; }

        [DisplayName("Side Size A")]
        public string? side_size_A { get; set; }

        [DisplayName("Side Size B")]
        public string? side_size_B { get; set; }

        [DisplayName("Side Size C")]
        public string? side_size_C { get; set; }

        [DisplayName("Side Size D")]
        public string? side_size_D { get; set; }

        [DisplayName("Side Size E")]
        public string? side_size_E { get; set; }

        [DisplayName("Side Size F")]
        public string? side_size_F { get; set; }

        [DisplayName("Side Size G")]
        public string? side_size_G { get; set; }

        [DisplayName("Side Timber 1")]
        public string? side_timber_1 { get; set; }

        [DisplayName("Side Timber 2")]
        public string? side_timber_2 { get; set; }

        [DisplayName("Plan Size A")]
        public string? plan_size_A { get; set; }

        [DisplayName("Plan Size B")]
        public string? plan_size_B { get; set; }

        [DisplayName("Plan Size C1")]
        public string? plan_size_C1 { get; set; }

        [DisplayName("Plan Size C2")]
        public string? plan_size_C2 { get; set; }

        [DisplayName("Plan Size D")]
        public string? plan_size_D { get; set; }

        [DisplayName("Plan Timber 1")]
        public string? plan_timber_1 { get; set; }

        [DisplayName("Plan Timber 2")]
        public string? plan_timber_2 { get; set; }

        [DisplayName("Color")]
        public string? color { get; set; }

        [DisplayName("Opening Type")]
        public string? opening_type { get; set; }

        [DisplayName("Finish")]
        public string? finish { get; set; }

        [DisplayName("Power Points")]
        public int power_points { get; set; }

        [DisplayName("Electric Door")]
        public int electric_door { get; set; }

        [DisplayName("Handle Outside")]
        public int handle_outside { get; set; }

        [DisplayName("Other Access")]
        public int other_access { get; set; }

        [DisplayName("Need Safety Release")]
        public int need_safety_release { get; set; }

        [DisplayName("Number of Pictures")]
        public int no_of_pics { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }	// Number of pictures

        [DisplayName("Insulated")]
        public int insulated { get; set; }

        [DisplayName("Door Stuck Shut")]
        public int door_stuck_shut { get; set; }

        [DisplayName("Motor Position")]
        public int motor_position { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_vids { get; set; }

        [DisplayName("Different From Original")]
        public bool bDifferentFromOriginal { get; set; }

        [DisplayName("Change Item To")]
        public string? ChangeItemTo { get; set; }

        [DisplayName("Print Name")]
        public string? print_name { get; set; }

        [DisplayName("Long Comments")]
        public string? long_comments { get; set; }

        [DisplayName("Is Complete")]
        public bool bComplete { get; set; }

        [DisplayName("Door Within Perimeter")]
        public int door_within_perimeter { get; set; }      // Is the garage door in the customers house perimeter? Renamed from i_spare1

        [DisplayName("Socket Within 1m")]
        public int socket_within_1m { get; set; }           // Renamed from i_spare2

        [DisplayName("Wire Type")]
        public string? wire_type { get; set; }               // wire type - Renamed from s_spare3

        [DisplayName("Colour Match Roll Box")]
        public int colour_match_roll_box { get; set; }      // Coloured match roll box - Renamed from new_ispare3

        [DisplayName("Additional Drawn")]
        public bool additional_drawn { get; set; }

        [DisplayName("Roller Door Type")]
        public string? roller_door_type { get; set; }        // Type of roller door-  Renamed from new_sspare1

        [DisplayName("Roller Box Type")]
        public string? roller_box_type { get; set; }         // Roll box type - Renamed from new_sspare2

        [DisplayName("Parts to Order")]
        public string? parts_to_order { get; set; }          // renamed from new_sspare4

        [DisplayName("Point of Entry")]
        public string? point_of_entry { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string? type_of_lockng_system_required { get; set; }

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }

        [DisplayName("Where is Garage")]
        public string? where_is_garage { get; set; }
        public SurveyItem AsSurveyItem() { return new SurveyItem(Id, enum_item_type.garage); }

    }

}
