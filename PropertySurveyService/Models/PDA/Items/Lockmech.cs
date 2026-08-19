using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Lockmech
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Item Type")]
        public enum_item_type item_type => enum_item_type.locking;

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

        [DisplayName("Product Into")]
        public string ProductInto { get; set; } = "";

        // ============================================================
        // SUB-ITEM - PARENT RELATIONSHIP
        // ============================================================

        [DisplayName("Parent Item")]
        public enum_item_type base_item { get; set; } = enum_item_type.none;


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
        // LOCK - BASIC DETAILS
        // ============================================================

        [DisplayName("Multipoint Locking")]
        public bool bMulti { get; set; }

        [DisplayName("Lock Item")]
        public string item { get; set; } = "";

        [DisplayName("Locking Make")]
        public string locking_make { get; set; } = "";

        [DisplayName("Locking Codes")]
        public string locking_codes { get; set; } = "";

        [DisplayName("Lock Colour")]
        public string lock_colour { get; set; } = "";

        [DisplayName("COD Code")]
        public string COD_Code { get; set; } = "";

        [DisplayName("Gear Box")]
        public string GearBox { get; set; } = "...";

        [DisplayName("Page Number")]
        public string pagenum { get; set; } = "";


        // ============================================================
        // LOCK - MAIN SIZES
        // ============================================================

        [DisplayName("Lock Size 1")]
        public string l_size1 { get; set; } = "";

        [DisplayName("Lock Size 2")]
        public string l_size2 { get; set; } = "";

        [DisplayName("Lock Size A")]
        public string l_sizeA { get; set; } = "";

        [DisplayName("Lock Size B")]
        public string l_sizeB { get; set; } = "";

        [DisplayName("Lock Size C")]
        public string l_sizeC { get; set; } = "";

        [DisplayName("Lock Size D")]
        public string l_sizeD { get; set; } = "";

        [DisplayName("Lock Size E")]
        public string l_sizeE { get; set; } = "";

        [DisplayName("Lock Size F")]
        public string l_sizeF { get; set; } = "";

        [DisplayName("Lock Size G")]
        public string l_sizeG { get; set; } = "";


        // ============================================================
        // LOCK - BOLTS / LOCK COUNT
        // ============================================================

        [DisplayName("Left Bolt")]
        public int left_bolt { get; set; }

        [DisplayName("Right Bolt")]
        public int right_bolt { get; set; }

        [DisplayName("Lock Number")]
        public int l_num { get; set; }


        // ============================================================
        // LOCK - POSITIONS
        // ============================================================

        [DisplayName("Lock Position")]
        public float lock_position { get; set; }

        [DisplayName("Lock FPos1")]
        public float l_fpos1 { get; set; }

        [DisplayName("Lock FPos2")]
        public float l_fpos2 { get; set; }

        [DisplayName("Lock FPos3")]
        public float l_fpos3 { get; set; }

        [DisplayName("Lock FPos4")]
        public float l_fpos4 { get; set; }

        [DisplayName("Lock FPos5")]
        public float l_fpos5 { get; set; }

        [DisplayName("Lock FPos6")]
        public float l_fpos6 { get; set; }

        [DisplayName("Lock FPos7")]
        public float l_fpos7 { get; set; }


        // ============================================================
        // LOCK - LOCK POINT TYPES
        // ============================================================

        [DisplayName("Lock IType1")]
        public string l_type1 { get; set; } = "";

        [DisplayName("Lock IType2")]
        public string l_type2 { get; set; } = "";

        [DisplayName("Lock IType3")]
        public string l_type3 { get; set; } = "";

        [DisplayName("Lock IType4")]
        public string l_type4 { get; set; } = "";

        [DisplayName("Lock IType5")]
        public string l_type5 { get; set; } = "";

        [DisplayName("Lock IType6")]
        public string l_type6 { get; set; } = "";

        [DisplayName("Lock IType7")]
        public string l_type7 { get; set; } = "";


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
        public string ItemTitle => (base_item == enum_item_type.none ? "" :
                                    base_item == enum_item_type.assembly ? ProductInto + " " :
                                    base_item.ToString()) + "Lockmech";

        public SurveyItem AsSurveyItem() =>
            new SurveyItem(
                Id,
                enum_item_type.bifold,
                item_number,
                ContractCode,
                ItemTitle);


    }
}
