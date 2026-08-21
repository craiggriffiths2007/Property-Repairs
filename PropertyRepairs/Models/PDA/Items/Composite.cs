using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyRepairs.Models
{
    public class Composite
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.composite;

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

        [DisplayName("Gaskets")]
        public string gaskets { get; set; } = "";

        [DisplayName("Gaskets Text")]
        public string gaskets_text { get; set; } = "";

        [DisplayName("Handles Required")]
        public bool? handles_req { get; set; }

        [DisplayName("Handles Text")]
        public string handles_text { get; set; } = "";

        [DisplayName("Cause of Damage")]
        public string cause_of_damage { get; set; } = "";

        [DisplayName("Reason Damage Different")]
        public string cause_of_damage_reason_different { get; set; } = "";

        [DisplayName("Reason Not Repaired")]
        public string reason_not_repaired { get; set; } = "";


        // ============================================================
        // COMMON - SIZES
        // ============================================================

        [DisplayName("Brick Width")]
        public string brick_width { get; set; } = "";

        [DisplayName("Brick Height")]
        public string brick_height { get; set; } = "";

        [DisplayName("Internal Width")]
        public string internal_width { get; set; } = "";

        [DisplayName("Internal Height")]
        public string internal_height { get; set; } = "";


        // ============================================================
        // COMMON - DOORS / OPENINGS / HARDWARE
        // ============================================================

        [DisplayName("Opens")]
        public string opens { get; set; } = "";

        [DisplayName("Letter Box Position")]
        public string letter_box_pos { get; set; } = "";

        [DisplayName("Pet Flap")]
        public string pet_flap { get; set; } = "";

        [DisplayName("Pet Type")]
        public string pet_type { get; set; } = "";

        [DisplayName("Pet Magnetic")]
        public string pet_magnetic { get; set; } = "";

        [DisplayName("Handle Colour")]
        public string handle_colour { get; set; } = "";

        [DisplayName("Threshold Type")]
        public string threshold_type { get; set; } = "";

        [DisplayName("Head Drip")]
        public bool? head_drip { get; set; }

        [DisplayName("Cills")]
        public string cills { get; set; } = "";

        [DisplayName("Trickle Vents")]
        public string trickle_vents { get; set; } = "";


        // ============================================================
        // COMMON - GLASS
        // ============================================================

        [DisplayName("Spacer Thickness")]
        public string spacer_thickness { get; set; } = "";

        [DisplayName("Spacer Colour")]
        public string spacer_colour { get; set; } = "";

        [DisplayName("Glass Type")]
        public string glass_type { get; set; } = "";

        [DisplayName("Glass Pattern")]
        public string glass_pattern { get; set; } = "";

        [DisplayName("Special Glass")]
        public string special_glass { get; set; } = "";

        [DisplayName("Replace Glass")]
        public bool? replace_glass { get; set; }

        [DisplayName("Glass Complete")]
        public bool glass_complete { get; set; }


        // ============================================================
        // COMMON - COMPLIANCE / LOCATION / CHANGES
        // ============================================================

        [DisplayName("DOCL")]
        public string docl { get; set; } = "";

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

        [DisplayName("Is a Flat")]
        public bool? is_a_flat { get; set; }

        [DisplayName("Point of Entry")]
        public bool? point_of_entry { get; set; }

        [DisplayName("Type of Locking System Required")]
        public string type_of_lockng_system_required { get; set; } = "";

        [DisplayName("Was It Locked")]
        public bool? was_it_locked { get; set; }


        // ============================================================
        // SHARED / SIMILAR TO UPVC & TIMBER
        // ============================================================

        [DisplayName("Addons")]
        public bool? addons { get; set; }

        [DisplayName("Addons Height")]
        public string addons_height { get; set; } = "";

        [DisplayName("Addons Width")]
        public string addons_width { get; set; } = "";

        [DisplayName("Profile Type")]
        public string profile_type { get; set; } = "";

        [DisplayName("Glaze")]
        public string glaze { get; set; } = "";


        // ============================================================
        // COMPOSITE - DOOR DETAILS
        // ============================================================

        [DisplayName("Door Make")]
        public string door_make { get; set; } = "";

        [DisplayName("Door Design")]
        public string door_design { get; set; } = "";

        [DisplayName("Door Wood")]
        public string door_wood { get; set; } = "";

        [DisplayName("Frame Colour Inside")]
        public string frame_colour_inside { get; set; } = "";

        [DisplayName("Frame Colour Outside")]
        public string frame_colour_outside { get; set; } = "";

        [DisplayName("Door Colour Inside")]
        public string door_colour_inside { get; set; } = "";

        [DisplayName("Door Colour Outside")]
        public string door_colour_outside { get; set; } = "";

        [DisplayName("Hinged On")]
        public string hinged_on { get; set; } = "";

        [DisplayName("Fire Door")]
        public bool? fire_door { get; set; }


        // ============================================================
        // COMPOSITE - LOCKING / HANDLES
        // ============================================================

        [DisplayName("Is Lock")]
        public string is_lock { get; set; } = "";

        [DisplayName("Lock Other Text")]
        public string lock_other_text { get; set; } = "";

        [DisplayName("Lever Pad Handles")]
        public string lever_pad_handles { get; set; } = "";

        // ============================================================
        // COMPOSITE - OTHER
        // ============================================================

        [DisplayName("Letter Edit")]
        public string letteredit { get; set; } = "";


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
        public string ItemTitle => "Composite" + (bRepair ? " Repair" : " Replace");

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
