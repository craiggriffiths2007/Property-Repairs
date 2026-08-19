using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Garage
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.garage;

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

        [Browsable(false)]
        public bool bRepair { get; set; }

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";


        // ============================================================
        // COMMON - CHANGES / SUMMARY
        // ============================================================

        [DisplayName("Different From Original")]
        public bool? bDifferentFromOriginal { get; set; } = false;

        [DisplayName("Change Item To")]
        public string ChangeItemTo { get; set; } = "";

        [DisplayName("Print Name")]
        public string print_name { get; set; } = "";

        [DisplayName("Summary")]
        public string Summary { get; set; } = "";


        // ============================================================
        // COMMON - JOB / SECURITY
        // ============================================================

        [DisplayName("Parts to Order")]
        public string parts_to_order { get; set; } = "";

        [DisplayName("Point of Entry")]
        public string point_of_entry { get; set; } = "";

        [DisplayName("Type of Locking System Required")]
        public string type_of_lockng_system_required { get; set; } = "";

        [DisplayName("Was It Locked")]
        public int was_it_locked { get; set; }


        // ============================================================
        // GARAGE - BASIC DOOR DETAILS
        // ============================================================

        [DisplayName("Type of Garage")]
        public string type_of_garage { get; set; } = "";

        [DisplayName("Opening Type")]
        public string opening_type { get; set; } = "";

        [DisplayName("Opening Direction")]
        public string opening_direction { get; set; } = "...";

        [DisplayName("Door Fits Into")]
        public string door_fits_into { get; set; } = "...";

        [DisplayName("Frame Fix Type")]
        public string frame_fix_type { get; set; } = "...";

        [DisplayName("New Subframe Required")]
        public string new_subframe_req { get; set; } = "...";

        [DisplayName("Color")]
        public string color { get; set; } = "";

        [DisplayName("Finish")]
        public string finish { get; set; } = "";

        [DisplayName("Where is Garage")]
        public string where_is_garage { get; set; } = "";


        // ============================================================
        // GARAGE - DOOR SIZE
        // ============================================================

        [DisplayName("Actual Door Width")]
        public string actual_door_width { get; set; } = "";

        [DisplayName("Actual Door Height")]
        public string actual_door_height { get; set; } = "";


        // ============================================================
        // GARAGE - SIDE ELEVATION SIZES
        // ============================================================

        [DisplayName("Side Size A")]
        public string side_size_A { get; set; } = "";

        [DisplayName("Side Size B")]
        public string side_size_B { get; set; } = "";

        [DisplayName("Side Size C")]
        public string side_size_C { get; set; } = "";

        [DisplayName("Side Size D")]
        public string side_size_D { get; set; } = "";

        [DisplayName("Side Size E")]
        public string side_size_E { get; set; } = "";

        [DisplayName("Side Size F")]
        public string side_size_F { get; set; } = "";

        [DisplayName("Side Size G")]
        public string side_size_G { get; set; } = "";

        [DisplayName("Side Timber 1")]
        public string side_timber_1 { get; set; } = "";

        [DisplayName("Side Timber 2")]
        public string side_timber_2 { get; set; } = "";


        // ============================================================
        // GARAGE - PLAN SIZES
        // ============================================================

        [DisplayName("Plan Size A")]
        public string plan_size_A { get; set; } = "";

        [DisplayName("Plan Size B")]
        public string plan_size_B { get; set; } = "";

        [DisplayName("Plan Size C1")]
        public string plan_size_C1 { get; set; } = "";

        [DisplayName("Plan Size C2")]
        public string plan_size_C2 { get; set; } = "";

        [DisplayName("Plan Size D")]
        public string plan_size_D { get; set; } = "";

        [DisplayName("Plan Timber 1")]
        public string plan_timber_1 { get; set; } = "";

        [DisplayName("Plan Timber 2")]
        public string plan_timber_2 { get; set; } = "";


        // ============================================================
        // GARAGE - OBSTRUCTIONS / ACCESS
        // ============================================================

        [DisplayName("Obstruction Outside (Bool)")]
        public bool? obstruction_outside_b { get; set; }

        [DisplayName("Obstruction Outside")]
        public string obstruction_outside { get; set; } = "";

        [DisplayName("Obstruction Inside (Bool)")]
        public bool? obstruction_inside_b { get; set; }

        [DisplayName("Obstruction Inside")]
        public string obstruction_inside { get; set; } = "";

        [DisplayName("Other Access")]
        public bool? other_access { get; set; }

        [DisplayName("Door Within Perimeter")]
        public bool? door_within_perimeter { get; set; }


        // ============================================================
        // GARAGE - ELECTRIC DOOR / OPERATOR
        // ============================================================

        [DisplayName("Electric Door")]
        public bool? electric_door { get; set; }

        [DisplayName("New Electric Operator Required")]
        public string new_electric_operator_req { get; set; } = "";

        [DisplayName("Motor Position")]
        public string motor_position { get; set; } = "...";

        [DisplayName("Power Points")]
        public bool? power_points { get; set; }

        [DisplayName("Socket Within 1m")]
        public bool? socket_within_1m { get; set; }

        [DisplayName("Wire Type")]
        public string wire_type { get; set; } = "";

        [DisplayName("Need Safety Release")]
        public bool? need_safety_release { get; set; }


        // ============================================================
        // GARAGE - DOOR OPTIONS / CONDITIONS
        // ============================================================

        [DisplayName("Handle Outside")]
        public bool? handle_outside { get; set; }

        [DisplayName("Insulated")]
        public bool? insulated { get; set; }

        [DisplayName("Door Stuck Shut")]
        public bool? door_stuck_shut { get; set; }


        // ============================================================
        // GARAGE - ROLLER DOOR DETAILS
        // ============================================================

        [DisplayName("Roller Door Type")]
        public string roller_door_type { get; set; } = "";

        [DisplayName("Roller Box Type")]
        public string roller_box_type { get; set; } = "";

        [DisplayName("Colour Match Roll Box")]
        public int colour_match_roll_box { get; set; }


        // ============================================================
        // GARAGE - DRAWINGS
        // ============================================================

        [DisplayName("Additional Drawn")]
        public bool additional_drawn { get; set; }


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
        public string ItemTitle => "Garage";

        public SurveyItem AsSurveyItem() =>
            new SurveyItem(
                Id,
                enum_item_type.bifold,
                item_number,
                ContractCode,
                ItemTitle);

    }

}
