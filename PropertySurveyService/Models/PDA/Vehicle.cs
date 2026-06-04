using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class JsonDTO
    {
        public string json { get; set; } = "";
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public int BranchId { get; set; } = 0;
        public string? Name { get; set; } = null;
        public string? Registration { get; set; } = null;
        public string? Description { get; set; } = null;
        public enum_vehicle_type Type { get; set; }

        public Branch? Branch { get; set; }
    }

    public class VehicleDTO
    {
        public int Id { get; set; }
        public int BranchId { get; set; } = 0;
        public string? Name { get; set; } = null;
        public string? Registration { get; set; } = null;
        public string? Description { get; set; } = null;
        public enum_vehicle_type Type { get; set; }

        public VehicleDTO(Vehicle vehicle)
        {
            {
                Id = vehicle.Id;
                BranchId = vehicle.BranchId;
                Name = vehicle.Name;
                Registration = vehicle.Registration;
                Description = vehicle.Description;
                Type = vehicle.Type;
            }
        }
    }

    public class VehicleCheckDTO
    {
        public VehicleCheckHeader VehicleCheckHeader { get; set; } = new VehicleCheckHeader();

        public List<DeliveryHGV> DeliveryHGVs = new List<DeliveryHGV>();
        public List<DeliveryVan> DeliveryVans = new List<DeliveryVan>();
        public List<FitterVan> FitterVans = new List<FitterVan>();
        public List<SalesCar> SalesCars = new List<SalesCar>();

    }

    public class VehicleCheckHeader
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; } = new Guid();

        [DisplayName("Check Week")]
        public string CheckWeekDate { get; set; } = "";
        [DisplayName("Branch Code")]
        public string BranchCode { get; set; } = "";  // branch code
        public string CheckID { get; set; } = ""; // consists of date, pda code, and unique Van Check ID number. Kind of a guid for the van check
        public bool bComplete { get; set; }
        public bool bSent { get; set; }
        public int TotalDeliveryHGVs { get; set; }
        public int TotalDeliveryVans { get; set; }
        public int TotalFitterVans { get; set; }
        public int TotalSalesCars { get; set; }
        public int CompleteDeliveryHGVs { get; set; }
        public int CompleteDeliveryVans { get; set; }
        public int CompleteFitterVans { get; set; }
        public int CompleteSalesCars { get; set; }

    }

    public class VehicleCheck
    {
        // --- System & Metadata Fields ---
        [Browsable(false)]
        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();
        [Browsable(false)]
        [DisplayName("Vehicle Check Header ID")]
        public int VehicleCheckHeaderId { get; set; }
        [Browsable(false)]
        [DisplayName("Check ID")]
        public string CheckID { get; set; }
        [Browsable(false)]
        [DisplayName("Item Number")]
        public int item_number { get; set; } = 0;

        [DisplayName("Destination")]
        public string Destination { get; set; } = "";

        [DisplayName("Check Completed Date")]
        public string CheckDoneDate { get; set; } = "";

        [DisplayName("Vehicle Registration")]
        public string Registration { get; set; } = "";

        [DisplayName("Current Mileage")]
        public string Mileage { get; set; } = "";

        [DisplayName("Branch Code")]
        public string BranchCode { get; set; } = "";

        [DisplayName("PDA Application Version Date")]
        public string PDAVersionDate { get; set; } = "";


        // --- Check Status & Workflow ---

        [DisplayName("Is Complete Status (Value)")]
        public bool is_complete { get; set; } // relates to reason not complete question

        [DisplayName("Reason Not Completed")]
        public string ReasonNotCompleted { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Is Completed")]
        public bool bComplete { get; set; }
        [Browsable(false)]
        [DisplayName("Sent to Server")]
        public bool bSent { get; set; }
        [Browsable(false)]
        [DisplayName("External Photos Taken")]
        public bool bPhotosOutsideComplete { get; set; }
        [Browsable(false)]
        [DisplayName("Internal Photos Taken")]
        public bool bPhotosInsideComplete { get; set; }
        [Browsable(false)]
        [DisplayName("Damage Diagrams Completed")]
        public bool bDiagramsComplete { get; set; }
        [Browsable(false)]
        [DisplayName("Signatures Completed")]
        public bool bSignaturesComplete { get; set; }


        // --- Tyre Pressures ---

        [DisplayName("Tyre Pressure - Passenger Front")]
        public bool pressure_passenger_front { get; set; }

        [DisplayName("Tyre Pressure - Passenger Rear")]
        public bool pressure_passenger_rear { get; set; }

        [DisplayName("Tyre Pressure - Driver Front")]
        public bool pressure_driver_front { get; set; }

        [DisplayName("Tyre Pressure - Driver Rear")]
        public bool pressure_driver_rear { get; set; }

        [DisplayName("Tyre Pressure - Spare")]
        public bool pressure_spare { get; set; }


        // --- Tyre Pressure Notes / Serial Numbers ---

        [DisplayName("Tyre Pressure - Passenger Front (Notes)")]
        public string pressure_passenger_front_s { get; set; } = "";

        [DisplayName("Tyre Pressure - Passenger Rear (Notes)")]
        public string pressure_passenger_rear_s { get; set; } = "";

        [DisplayName("Tyre Pressure - Driver Front (Notes)")]
        public string pressure_driver_front_s { get; set; } = "";

        [DisplayName("Tyre Pressure - Driver Rear (Notes)")]
        public string pressure_driver_rear_s { get; set; } = "";

        [DisplayName("Tyre Pressure - Spare (Notes)")]
        public string pressure_spare_s { get; set; } = "";


        // --- Vehicle Damage Descriptions ---

        [DisplayName("Damage Description - Passenger Side")]
        public string damage_pass { get; set; } = "";

        [DisplayName("Damage Description - Driver Side")]
        public string damage_driver { get; set; } = "";

        [DisplayName("Damage Description - Front")]
        public string damage_front { get; set; } = "";

        [DisplayName("Damage Description - Rear")]
        public string damage_back { get; set; } = "";


        // --- Photo Verification Counts ---

        [DisplayName("Front Photos Count")]
        public int photos_front { get; set; }

        [DisplayName("Rear Photos Count")]
        public int photos_rear { get; set; }

        [DisplayName("Left Side Photos Count")]
        public int photos_left { get; set; }

        [DisplayName("Right Side Photos Count")]
        public int photos_right { get; set; }


        // --- Signatures & Verification ---
        [Browsable(false)]
        [DisplayName("Driver Signed")]
        public bool bDriverSigned { get; set; }
        [Browsable(false)]
        [DisplayName("Checked By Signed")]
        public bool bCheckedBySigned { get; set; }
        [Browsable(false)]
        [DisplayName("Driver Printed Name")]
        public string driver_printed { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Auditor/Checker Printed Name")]
        public string checked_printed { get; set; } = "";
    }


    public class DeliveryHGV : VehicleCheck
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("National Tyres Card")]
        public bool national_tyres_card { get; set; }

        [DisplayName("FMG Support Sticker")]
        public bool fmg_support_sticker { get; set; }

        [DisplayName("Fuel Card")]
        public bool fuel_card { get; set; }

        [DisplayName("Clean External")]
        public bool clean_external { get; set; }

        [DisplayName("Clean Internal")]
        public bool clean_internal { get; set; }

        [DisplayName("Fan Belt")]
        public bool fan_belt { get; set; }

        [DisplayName("Fire Extinguisher")]
        public bool fire_extinguisher { get; set; }

        [DisplayName("First Aid Box")]
        public bool first_aid_box { get; set; }

        [DisplayName("Horn (Cab)")]
        public bool horn { get; set; }

        [DisplayName("Oil & Water Checked")]
        public bool oil_and_water_checked { get; set; }

        [DisplayName("Accident Pack")]
        public bool accident_pack { get; set; }

        [DisplayName("Portable Lighting")]
        public bool portable_lighting { get; set; }

        [DisplayName("AdBlue Level Checked")]
        public bool ad_blue_level_check { get; set; }

        [DisplayName("Racks & Poles")]
        public bool racks_and_poles { get; set; }

        [DisplayName("Ratchet Straps")]
        public bool ratchet_straps { get; set; }

        [DisplayName("Service Due Sticker")]
        public bool service_due_sticker { get; set; }

        [DisplayName("No Smoking Sticker")]
        public bool no_smoking_sticker { get; set; }

        [DisplayName("Spare Oil")]
        public bool spare_oil { get; set; }

        [DisplayName("Coolant & Anti-freeze")]
        public bool coolant_anti_freez { get; set; }

        [DisplayName("Tyre Pressure")]
        public bool tyre_pressure { get; set; }

        [DisplayName("Van Height Sticker")]
        public bool van_height_sticker { get; set; }

        [DisplayName("Van Locks")]
        public bool van_locks { get; set; }

        [DisplayName("Wheel Nut Check Sticker")]
        public bool wheel_nut_check_sticker { get; set; }

        [DisplayName("Windscreen Washer")]
        public bool windscreen_washer { get; set; }

        [DisplayName("Fuel & Oil Leaks")]
        public bool fuel_oil_leaks { get; set; }

        [DisplayName("Battery Security & Condition")]
        public bool battery_security_condition { get; set; }

        [DisplayName("Tyres & Wheel Fixing")]
        public bool tyres_and_wheel_fixing { get; set; }

        [DisplayName("Spray Suppression")]
        public bool spray_suppression { get; set; }

        [DisplayName("Steering")]
        public bool steering { get; set; }

        [DisplayName("Security of Load")]
        public bool security_of_load { get; set; }

        [DisplayName("Mirrors")]
        public bool mirrors { get; set; }

        [DisplayName("Lights")]
        public bool lights { get; set; }

        [DisplayName("Reflectors")]
        public bool reflectors { get; set; }

        [DisplayName("Indicators")]
        public bool inducators { get; set; }

        [DisplayName("Wipers")]
        public bool wipers { get; set; }

        [DisplayName("Washers")]
        public bool washers { get; set; }

        [DisplayName("Horn (Compliance)")]
        public bool horn_comp { get; set; }

        [DisplayName("Excessive Exhaust Smoke")]
        public bool excessive_exhaust_smoke { get; set; }

        [DisplayName("Brakes")]
        public bool brakes { get; set; }

        [DisplayName("Security of Body")]
        public bool security_of_body { get; set; }

        [DisplayName("Markers")]
        public bool markers { get; set; }

        [DisplayName("Glass & Windscreen")]
        public bool glass_windscreen { get; set; }

        [DisplayName("Receipt Book")]
        public bool receipt_book { get; set; }

        [DisplayName("Keys for Branches (Sat)")]
        public bool keys_for_branches_sat { get; set; }

        [DisplayName("PDA, Phone & Accident Pack")]
        public bool pda_phone_accident_pack { get; set; }

        [DisplayName("Trade Invoices")]
        public bool trade_invoices { get; set; }

        [DisplayName("Blue Bags")]
        public bool blue_bags { get; set; }

        [DisplayName("Delivery Lists")]
        public bool delivery_lists { get; set; }

        [DisplayName("Collection Lists")]
        public bool collection_lists { get; set; }

        [DisplayName("Trade Delivery Notes")]
        public bool trade_delivery_notes { get; set; }

        [DisplayName("Reported Defects")]
        public string report_defects { get; set; } = "";

        [DisplayName("Date Signed")]
        public string date_signed { get; set; } = "";

        [DisplayName("Loading Area Good Condition")]
        public bool loading_storage { get; set; }// No of additional photos
        [DisplayName("Reason Loading Area Not Good Condition")]
        public string loading_storage_s { get; set; } = "";

        [DisplayName("Shell Fuel Card")]
        public bool shell_fuel_card { get; set; }

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.delivery_hgv,Registration); }
    }
    public class DeliveryVan : VehicleCheck
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("ATS Card")]
        public bool ats_card { get; set; }
        [DisplayName("Bodywork Check")]
        public bool bodywork_check { get; set; }
        [DisplayName("Breakdown Card")]
        public bool breakdown_card { get; set; }
        [DisplayName("Clean External")]
        public bool clean_external { get; set; }
        [DisplayName("Clean Internal")]
        public bool clean_internal { get; set; }
        [DisplayName("Fan Belt")]
        public bool fan_belt { get; set; }
        [DisplayName("Fire Extinguisher")]
        public bool fire_extinguisher { get; set; }
        [DisplayName("First Aid Box")]
        public bool first_aid_box { get; set; }
        [DisplayName("Fuel Card")]
        public bool fuel_card { get; set; }
        [DisplayName("Horn")]
        public bool horn { get; set; }
        [DisplayName("Jack")]
        public bool jack { get; set; }
        [DisplayName("Jump Leads")]
        public bool jump_leads { get; set; }
        [DisplayName("Keys for Branches")]
        public bool keys_for_branches { get; set; }
        [DisplayName("Lights/Indicators")]
        public bool lights_inducators { get; set; }
        [DisplayName("Oil/Water Checked")]
        public bool oil_water_checked { get; set; }
        [DisplayName("Racks/Poles")]
        public bool racks_poles { get; set; }
        [DisplayName("Ratchet Straps")]
        public bool ratchet_straps { get; set; }
        [DisplayName("Receipt Book")]
        public bool receipt_book { get; set; }
        [DisplayName("Bump Hats")]
        public bool bump_hats { get; set; }
        [DisplayName("Service Due Sticker")]
        public bool service_due_sticker { get; set; }
        [DisplayName("Spanners for Rack Removal")]
        public bool spanners_for_rack_removal { get; set; }
        [DisplayName("Spare Oil")]
        public bool spare_oil { get; set; }
        [DisplayName("Coolant/Antifreeze Mix")]
        public bool coolant_anti_freeze_mix { get; set; }
        [DisplayName("Spare Wheel")]
        public bool spare_wheel { get; set; }
        [DisplayName("Tow Ropes")]
        public bool tow_ropes { get; set; }
        [DisplayName("Tyre Pressure")]
        public bool tyre_pressure { get; set; }
        [DisplayName("Van Height Sticker")]
        public bool van_height_sticker { get; set; }
        [DisplayName("Van Locks")]
        public bool van_locks { get; set; }
        [DisplayName("Wheel Nut Check Sticker")]
        public bool wheel_nut_check_sticker { get; set; }
        [DisplayName("Wheelbrace")]
        public bool wheelbrace { get; set; }
        [DisplayName("Windscreen Washer")]
        public bool windscreen_washer { get; set; }
        [DisplayName("PDA/Phone/Accident Pack")]
        public bool pda_phone_accident_pack { get; set; }
        [DisplayName("Branch Keys")]
        public bool branch_keys { get; set; }
        [DisplayName("ATS Card (String)")]
        public string ats_card_s { get; set; } = "";
        [DisplayName("Bodywork Check (String)")]
        public string bodywork_check_s { get; set; } = "";
        [DisplayName("Breakdown Card (String)")]
        public string breakdown_card_s { get; set; } = "";
        [DisplayName("Clean External (String)")]
        public string clean_external_s { get; set; } = "";
        [DisplayName("Clean Internal (String)")]
        public string clean_internal_s { get; set; } = "";
        [DisplayName("Fan Belt (String)")]
        public string fan_belt_s { get; set; } = "";
        [DisplayName("Fire Extinguisher (String)")]
        public string fire_extinguisher_s { get; set; } = "";
        [DisplayName("First Aid Box (String)")]
        public string first_aid_box_s { get; set; } = "";
        [DisplayName("Fuel Card (String)")]
        public string fuel_card_s { get; set; } = "";
        [DisplayName("Horn (String)")]
        public string horn_s { get; set; } = "";
        [DisplayName("Jack (String)")]
        public string jack_s { get; set; } = "";
        [DisplayName("Jump Leads (String)")]
        public string jump_leads_s { get; set; } = "";
        [DisplayName("Keys for Branches (String)")]
        public string keys_for_branches_s { get; set; } = "";
        [DisplayName("Lights/Indicators (String)")]
        public string lights_inducators_s { get; set; } = "";
        [DisplayName("Oil/Water Checked (String)")]
        public string oil_water_checked_s { get; set; } = "";
        [DisplayName("Racks/Poles (String)")]
        public string racks_poles_s { get; set; } = "";
        [DisplayName("Ratchet Straps (String)")]
        public string ratchet_straps_s { get; set; } = "";
        [DisplayName("Receipt Book (String)")]
        public string receipt_book_s { get; set; } = "";
        [DisplayName("Bump Hats (String)")]
        public string bump_hats_s { get; set; } = "";
        [DisplayName("Service Due Sticker (String)")]
        public string service_due_sticker_s { get; set; } = "";
        [DisplayName("Spanners for Rack Removal (String)")]
        public string spanners_for_rack_removal_s { get; set; } = "";
        [DisplayName("Spare Oil (String)")]
        public string spare_oil_s { get; set; } = "";
        [DisplayName("Coolant/Antifreeze Mix (String)")]
        public string coolant_anti_freeze_mix_s { get; set; } = "";
        [DisplayName("Spare Wheel (String)")]
        public string spare_wheel_s { get; set; } = "";
        [DisplayName("Tow Ropes (String)")]
        public string tow_ropes_s { get; set; } = "";
        [DisplayName("Tyre Pressure (String)")]
        public string tyre_pressure_s { get; set; } = "";
        [DisplayName("Van Height Sticker (String)")]
        public string van_height_sticker_s { get; set; } = "";
        [DisplayName("Van Locks (String)")]
        public string van_locks_s { get; set; } = "";
        [DisplayName("Wheel Nut Check Sticker (String)")]
        public string wheel_nut_check_sticker_s { get; set; } = "";
        [DisplayName("Wheelbrace (String)")]
        public string wheelbrace_s { get; set; } = "";
        [DisplayName("Windscreen Washer (String)")]
        public string windscreen_washer_s { get; set; } = "";
        [DisplayName("PDA/Phone/Accident Pack (String)")]
        public string pda_phone_accident_pack_s { get; set; } = "";
        [DisplayName("Branch Keys (String)")]
        public string branch_keys_s { get; set; } = "";
        [DisplayName("Loading Area Good Condition")]
        public bool loading_storage { get; set; }// No of additional photos
        [DisplayName("Reason Loading Area Not Good Condition")]
        public string loading_storage_s { get; set; } = "";
        [DisplayName("Shell Fuel Card")]
        public bool shell_fuel_card { get; set; }
        [DisplayName("Shell Fuel Card (string)")]
        public string shell_fuel_card_s { get; set; } = ""; // Shell Fuel Card

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.delivery_van, Registration); }
    }
    public class FitterVan : VehicleCheck
    {
        public int Id { get; set; }

        // --- Core Tools & Equipment ---

        [DisplayName("Loading Area Good Condition")]
        public bool loading_storage { get; set; }// No of additional photos
        [DisplayName("Reason Loading Area Not Good Condition")]
        public string loading_storage_s { get; set; } = "";

        [DisplayName("Circuit Breaker")]
        public bool circuit_breaker { get; set; }

        [DisplayName("Power Breaker")]
        public bool power_breaker { get; set; }

        [DisplayName("Hammer Drill")]
        public bool hammer_drill { get; set; }

        [DisplayName("Ordinary Drill")]
        public bool ordinary_drill { get; set; }

        [DisplayName("Cordless Drill")]
        public bool cordless_drill { get; set; }

        [DisplayName("Spare Battery & Charger")]
        public bool spare_battery_and_charger { get; set; }

        [DisplayName("Circular Saw")]
        public bool circular_saw { get; set; }

        [DisplayName("Jig Saw")]
        public bool jig_saw { get; set; }

        [DisplayName("Planer (Check Blade)")]
        public bool planer_check_blade { get; set; }

        [DisplayName("Heat Gun")]
        public bool heat_gun { get; set; }

        [DisplayName("Sander")]
        public bool sander { get; set; }

        [DisplayName("Grinder")]
        public bool grinder { get; set; }

        [DisplayName("Hoover")]
        public bool hoover { get; set; }

        [DisplayName("Halogen Lamp")]
        public bool halogen_lamp { get; set; }

        [DisplayName("Extension Lead")]
        public bool extension_lead { get; set; }

        [DisplayName("Router")]
        public bool router { get; set; }

        // --- Ladders & Securing ---

        [DisplayName("Industrial Ladders")]
        public bool industrial_ladders { get; set; }

        [DisplayName("Ladder Clamps")]
        public bool ladder_clamps { get; set; }

        [DisplayName("Step Ladders")]
        public bool step_ladders { get; set; }

        [DisplayName("Ladder Stopper")]
        public bool ladder_stopper { get; set; }

        // --- Hand Tools & Accessories ---

        [DisplayName("Philips Bit")]
        public bool philips_bit { get; set; }

        [DisplayName("Screw Box")]
        public bool screw_box { get; set; }

        [DisplayName("Trestles (x2)")]
        public bool tresles_x2 { get; set; }

        [DisplayName("Working Torch")]
        public bool torch_working { get; set; }

        [DisplayName("Ratchet Straps (x4)")]
        public bool ratchett_straps_x4 { get; set; }

        // --- Housekeeping & Protection ---

        [DisplayName("Blue External Dust Sheet")]
        public bool blue_external_dust_sheet { get; set; }

        [DisplayName("Internal Dust Sheets (x3)")]
        public bool Internal_dust_sheets_x3 { get; set; }

        [DisplayName("Brush & Shovel")]
        public bool brush_and_shovel { get; set; }

        [DisplayName("Cleaner Bottle")]
        public bool cleaner_bottle { get; set; }

        [DisplayName("E-Cloth")]
        public bool ecloth { get; set; }

        [DisplayName("Mastic Guns")]
        public bool mastic_guns { get; set; }

        [DisplayName("Glass Suckers")]
        public bool glass_suckers { get; set; }

        // --- Safety Wear (PPE) ---

        [DisplayName("Safety Helmets")]
        public int safety_helmets { get; set; }

        [DisplayName("Helmet Manufacture Date Check")]
        public bool helmet_manufacture_date { get; set; }

        [DisplayName("Gloves")]
        public int gloves { get; set; }

        [DisplayName("Wrist Guards")]
        public int wrist_guards { get; set; }

        [DisplayName("Goggles")]
        public int goggles { get; set; }

        [DisplayName("Ear Defenders")]
        public int ear_defenders { get; set; }

        [DisplayName("Dust Masks")]
        public int dust_masks { get; set; }

        [DisplayName("Hi-Vis Vests")]
        public bool hi_vis_vests { get; set; }

        // --- Forms & Documentation ---

        [DisplayName("Customer Care Cards")]
        public bool customer_care_cards { get; set; }

        [DisplayName("Completion Forms")]
        public bool completion_forms { get; set; }

        [DisplayName("Freepost Envelopes")]
        public bool freepost_envelopes { get; set; }

        [DisplayName("Mandate Forms")]
        public bool mandate_forms { get; set; }

        [DisplayName("Quality Manuals")]
        public bool quality_manuals { get; set; }

        [DisplayName("Stapler")]
        public bool stapler { get; set; }

        [DisplayName("Worksheets")]
        public bool worksheets { get; set; }

        // --- First Aid Kit ---

        [DisplayName("Plasters")]
        public bool plasters { get; set; }

        [DisplayName("Dressing")]
        public bool dressing { get; set; }

        [DisplayName("Eyewashers")]
        public bool eyewashers { get; set; }

        [DisplayName("Steri-wipes")]
        public bool steri_wipes { get; set; }

        [DisplayName("First Aid Bag")]
        public bool bag { get; set; }

        // --- Specialist Meters ---

        [DisplayName("Flexi-Meter")]
        public bool flexi_meter { get; set; }

        [DisplayName("Merlin Low-E Detector")]
        public bool merlin_low_e_detector { get; set; }

        // --- Vehicle Cards, Safety & Essentials ---

        [DisplayName("Cabin Condition")]
        public bool cabin_condition { get; set; }

        [DisplayName("National Tyres Card")]
        public bool national_tyres_card { get; set; }

        [DisplayName("Breakdown Card")]
        public bool breakdown_card { get; set; }

        [DisplayName("Fuel Card")]
        public bool fuel_card { get; set; }

        [DisplayName("Shell Points Card")]
        public bool shell_points_card { get; set; }

        [DisplayName("Fire Extinguisher")]
        public bool fire_extinguisher { get; set; }

        [DisplayName("Jack")]
        public bool jack { get; set; }

        [DisplayName("Wheelbrace")]
        public bool wheelbrace { get; set; }

        [DisplayName("Spare Wheel")]
        public bool spare_wheel { get; set; }

        [DisplayName("Jump Leads")]
        public bool jump_leads { get; set; }

        [DisplayName("Fan Belt")]
        public bool fan_belt { get; set; }

        [DisplayName("Tow Ropes")]
        public bool tow_ropes { get; set; }

        [DisplayName("Spare Oil")]
        public bool spare_oil { get; set; }

        [DisplayName("Coolant & Anti-freeze")]
        public bool coolant_anti_freeze { get; set; }

        [DisplayName("Van Height Sticker")]
        public bool van_height_sticker { get; set; }

        [DisplayName("Wheel Nut Check Sticker")]
        public bool wheel_nut_check_sticker { get; set; }

        [DisplayName("No Smoking Sticker")]
        public bool no_smoking_sticker { get; set; }

        [DisplayName("Racks & Poles")]
        public bool racks_and_poles { get; set; }

        [DisplayName("Tyre Conditions")]
        public bool tyre_conditions { get; set; }

        [DisplayName("Van Locks")]
        public bool van_locks { get; set; }

        [DisplayName("Oil & Water Checked")]
        public bool oil_and_water_checked { get; set; }

        [DisplayName("How's My Driving Sticker")]
        public bool hows_my_driving_sticker { get; set; }

        [DisplayName("PDA Setup Date")]
        public bool pda_setup_date { get; set; }

        [DisplayName("Accident Pack on PDA")]
        public bool accident_pack_on_pda { get; set; }

        [DisplayName("Windscreen Condition")]
        public bool windscreen_good_contidion { get; set; }


        // ==========================================
        // String Fields (Serial Numbers / Statuses)
        // ==========================================

        [DisplayName("Circuit Breaker (Serial/Notes)")]
        public string circuit_breaker_s { get; set; } = "";

        [DisplayName("Power Breaker (Serial/Notes)")]
        public string power_breaker_s { get; set; } = "";

        [DisplayName("Hammer Drill (Serial/Notes)")]
        public string hammer_drill_s { get; set; } = "";

        [DisplayName("Ordinary Drill (Serial/Notes)")]
        public string ordinary_drill_s { get; set; } = "";

        [DisplayName("Cordless Drill (Serial/Notes)")]
        public string cordless_drill_s { get; set; } = "";

        [DisplayName("Spare Battery & Charger (Serial/Notes)")]
        public string spare_battery_and_charger_s { get; set; } = "";

        [DisplayName("Circular Saw (Serial/Notes)")]
        public string circular_saw_s { get; set; } = "";

        [DisplayName("Jig Saw (Serial/Notes)")]
        public string jig_saw_s { get; set; } = "";

        [DisplayName("Planer (Serial/Notes)")]
        public string planer_check_blade_s { get; set; } = "";

        [DisplayName("Heat Gun (Serial/Notes)")]
        public string heat_gun_s { get; set; } = "";

        [DisplayName("Sander (Serial/Notes)")]
        public string sander_s { get; set; } = "";

        [DisplayName("Hoover (Serial/Notes)")]
        public string hoover_s { get; set; } = "";

        [DisplayName("Halogen Lamp (Serial/Notes)")]
        public string halogen_lamp_s { get; set; } = "";

        [DisplayName("Extension Lead (Serial/Notes)")]
        public string extension_lead_s { get; set; } = "";

        [DisplayName("Router (Serial/Notes)")]
        public string router_s { get; set; } = "";

        [DisplayName("Industrial Ladders (Serial/Notes)")]
        public string industrial_ladders_s { get; set; } = "";

        [DisplayName("Ladder Clamps (Serial/Notes)")]
        public string ladder_clamps_s { get; set; } = "";

        [DisplayName("Step Ladders (Serial/Notes)")]
        public string step_ladders_s { get; set; } = "";

        [DisplayName("Ladder Stopper (Serial/Notes)")]
        public string ladder_stopper_s { get; set; } = "";

        [DisplayName("Philips Bit (Serial/Notes)")]
        public string philips_bit_s { get; set; } = "";

        [DisplayName("Screw Box (Serial/Notes)")]
        public string screw_box_s { get; set; } = "";

        [DisplayName("Trestles (x2) (Serial/Notes)")]
        public string tresles_x2_s { get; set; } = "";

        [DisplayName("Working Torch (Serial/Notes)")]
        public string torch_working_s { get; set; } = "";

        [DisplayName("Ratchet Straps (x4) (Serial/Notes)")]
        public string ratchett_straps_x4_s { get; set; } = "";

        [DisplayName("Spare Wheel (Serial/Notes)")]
        public string spare_wheel_s { get; set; } = "";

        [DisplayName("Blue External Dust Sheet (Serial/Notes)")]
        public string blue_external_dust_sheet_s { get; set; } = "";

        [DisplayName("Internal Dust Sheets (x3) (Serial/Notes)")]
        public string internal_dust_sheets_x3_s { get; set; } = "";

        [DisplayName("Brush & Shovel (Serial/Notes)")]
        public string brush_and_shovel_s { get; set; } = "";

        [DisplayName("Cleaner Bottle (Serial/Notes)")]
        public string cleaner_bottle_s { get; set; } = "";

        [DisplayName("E-Cloth (Serial/Notes)")]
        public string ecloth_s { get; set; } = "";

        [DisplayName("Mastic Guns (Serial/Notes)")]
        public string mastic_guns_s { get; set; } = "";

        [DisplayName("Glass Suckers (Serial/Notes)")]
        public string glass_suckers_s { get; set; } = "";

        [DisplayName("Safety Helmets (Serial/Notes)")]
        public string safety_helmets_s { get; set; } = "";

        [DisplayName("Helmet Manufacture Date (Serial/Notes)")]
        public string helmet_manufacture_date_s { get; set; } = "";

        [DisplayName("Gloves (Serial/Notes)")]
        public string gloves_s { get; set; } = "";

        [DisplayName("Wrist Guards (Serial/Notes)")]
        public string wrist_guards_s { get; set; } = "";

        [DisplayName("Goggles (Serial/Notes)")]
        public string goggles_s { get; set; } = "";

        [DisplayName("Ear Defenders (Serial/Notes)")]
        public string ear_defenders_s { get; set; } = "";

        [DisplayName("Dust Masks (Serial/Notes)")]
        public string dust_masks_s { get; set; } = "";

        [DisplayName("Customer Care Cards (Serial/Notes)")]
        public string customer_care_cards_s { get; set; } = "";

        [DisplayName("Completion Forms (Serial/Notes)")]
        public string completion_forms_s { get; set; } = "";

        [DisplayName("Freepost Envelopes (Serial/Notes)")]
        public string freepost_envelopes_s { get; set; } = "";

        [DisplayName("Mandate Forms (Serial/Notes)")]
        public string mandate_forms_s { get; set; } = "";

        [DisplayName("Quality Manuals (Serial/Notes)")]
        public string quality_manuals_s { get; set; } = "";

        [DisplayName("Stapler (Serial/Notes)")]
        public string stapler_s { get; set; } = "";

        [DisplayName("Worksheets (Serial/Notes)")]
        public string worksheets_s { get; set; } = "";

        [DisplayName("Plasters (Serial/Notes)")]
        public string plasters_s { get; set; } = "";

        [DisplayName("Dressing (Serial/Notes)")]
        public string dressing_s { get; set; } = "";

        [DisplayName("Eyewashers (Serial/Notes)")]
        public string eyewashers_s { get; set; } = "";

        [DisplayName("Steri-wipes (Serial/Notes)")]
        public string steri_wipes_s { get; set; } = "";

        [DisplayName("First Aid Bag (Serial/Notes)")]
        public string bag_s { get; set; } = "";

        [DisplayName("Flexi-Meter (Serial/Notes)")]
        public string flexi_meter_s { get; set; } = "";

        [DisplayName("Merlin Low-E Detector (Serial/Notes)")]
        public string merlin_low_e_detector_s { get; set; } = "";

        [DisplayName("Cabin Condition (Notes)")]
        public string cabin_condition_s { get; set; } = "";

        [DisplayName("National Tyres Card (Serial/Notes)")]
        public string national_tyres_card_s { get; set; } = "";

        [DisplayName("Breakdown Card (Serial/Notes)")]
        public string breakdown_card_s { get; set; } = "";

        [DisplayName("Fuel Card (Serial/Notes)")]
        public string fuel_card_s { get; set; } = "";

        [DisplayName("Shell Points Card (Serial/Notes)")]
        public string shell_points_card_s { get; set; } = "";

        [DisplayName("Fire Extinguisher (Serial/Notes)")]
        public string fire_extinguisher_s { get; set; } = "";

        [DisplayName("Jack (Serial/Notes)")]
        public string jack_s { get; set; } = "";

        [DisplayName("Wheelbrace (Serial/Notes)")]
        public string wheelbrace_s { get; set; } = "";

        [DisplayName("Jump Leads (Serial/Notes)")]
        public string jump_leads_s { get; set; } = "";

        [DisplayName("Fan Belt (Serial/Notes)")]
        public string fan_belt_s { get; set; } = "";

        [DisplayName("Tow Ropes (Serial/Notes)")]
        public string tow_ropes_s { get; set; } = "";

        [DisplayName("Spare Oil (Serial/Notes)")]
        public string spare_oil_s { get; set; } = "";

        [DisplayName("Coolant & Anti-freeze (Serial/Notes)")]
        public string coolant_anti_freeze_s { get; set; } = "";

        [DisplayName("Van Height Sticker (Serial/Notes)")]
        public string van_height_sticker_s { get; set; } = "";

        [DisplayName("Wheel Nut Check Sticker (Serial/Notes)")]
        public string wheel_nut_check_sticker_s { get; set; } = "";

        [DisplayName("No Smoking Sticker (Serial/Notes)")]
        public string no_smoking_sticker_s { get; set; } = "";

        [DisplayName("Racks & Poles (Serial/Notes)")]
        public string racks_and_poles_s { get; set; } = "";

        [DisplayName("Tyre Conditions (Serial/Notes)")]
        public string tyre_conditions_s { get; set; } = "";

        [DisplayName("Van Locks (Serial/Notes)")]
        public string van_locks_s { get; set; } = "";

        [DisplayName("Oil & Water Checked (Serial/Notes)")]
        public string oil_and_water_checked_s { get; set; } = "";

        [DisplayName("How's My Driving Sticker (Serial/Notes)")]
        public string hows_my_driving_sticker_s { get; set; } = "";

        [DisplayName("PDA Setup Date (Notes)")]
        public string pda_setup_date_s { get; set; } = "";

        [DisplayName("Accident Pack on PDA (Serial/Notes)")]
        public string accident_pack_on_pda_s { get; set; } = "";

        [DisplayName("Hi-Vis Vests (Serial/Notes)")]
        public string hi_vis_vests_s { get; set; } = "";

        [DisplayName("Grinder (Serial/Notes)")]
        public string grinder_s { get; set; } = "";

        [DisplayName("Windscreen Condition (Notes)")]
        public string windscreen_good_contidion_s { get; set; } = "";


        // ==========================================
        // Miscellaneous & Safety Dates
        // ==========================================

        [DisplayName("Fitter's Own Power Tools & Ladders on Van")]
        public int fitters_own_power_tools_ladders_on_van { get; set; }

        [DisplayName("Auditor Score (Marks out of 10)")]
        public string marks_out_of_10 { get; set; } = "";

        [DisplayName("Vehicle Registration")]
        public string vehicle_reg { get; set; } = "";

        [DisplayName("Shell Fuel Card (string)")]
        public string shell_fuel_card_s { get; set; } = "";

        [DisplayName("Spare Text Field 3")]
        public string spare_s_3 { get; set; } = "";

        [DisplayName("Spare Text Field 4")]
        public string spare_s_4 { get; set; } = "";

        [DisplayName("Shell Fuel Card")]
        public bool shell_fuel_card { get; set; }



        [DisplayName("Helmet 1 Manufacture Date")]
        public string ManufactureDateOnHelmet { get; set; } = "";

        [DisplayName("Helmet 2 Manufacture Date")]
        public string ManufactureDateOnHelmet2 { get; set; } = "";

        [DisplayName("Helmet 3 Manufacture Date")]
        public string ManufactureDateOnHelmet3 { get; set; } = "";

        [DisplayName("Helmet 4 Manufacture Date")]
        public string ManufactureDateOnHelmet4 { get; set; } = "";

        [DisplayName("Helmet 5 Manufacture Date")]
        public string ManufactureDateOnHelmet5 { get; set; } = "";

        [DisplayName("Helmet 6 Manufacture Date")]
        public string ManufactureDateOnHelmet6 { get; set; } = "";

        [DisplayName("Helmet 7 Manufacture Date")]
        public string ManufactureDateOnHelmet7 { get; set; } = "";

        [DisplayName("Helmet 8 Manufacture Date")]
        public string ManufactureDateOnHelmet8 { get; set; } = "";

        [DisplayName("Helmet 9 Manufacture Date")]
        public string ManufactureDateOnHelmet9 { get; set; } = "";

        [DisplayName("Helmet 10 Manufacture Date")]
        public string ManufactureDateOnHelmet10 { get; set; } = "";

        [DisplayName("Letterbox Jig Checked")]
        public bool letterbox_jig { get; set; }

        [DisplayName("Letterbox Jig Checked (string)")]
        public string letterbox_jig_s { get; set; } = "";

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.fitter_van, Registration); }
    }
    public class SalesCar : VehicleCheck
    {
        public int Id { get; set; }

        // --- Core Vehicle Checks ---

        [DisplayName("Fuel Card")]
        public bool fuel_card { get; set; }

        [DisplayName("Shell Points Card")]
        public bool shell_points_card { get; set; }

        [DisplayName("Shell Fuel Card")]
        public bool shell_fuel_card { get; set; }

        [DisplayName("boolerior Cleanliness")]
        public bool interior_clean { get; set; }

        [DisplayName("Oil Level")]
        public bool oil_level { get; set; }

        [DisplayName("Water Level")]
        public bool water_level { get; set; }

        [DisplayName("Windscreen Wash")]
        public bool windscreen_wash { get; set; }

        [DisplayName("Spare Wheel")]
        public bool spare_wheel { get; set; }

        [DisplayName("Jack")]
        public bool jack { get; set; }

        [DisplayName("Wheel Brace")]
        public bool wheel_brace { get; set; }

        [DisplayName("Tools")]
        public bool tools { get; set; }

        [DisplayName("Tyre Condition")]
        public bool tyre_condition { get; set; }


        // ==========================================
        // String Fields (Serial Numbers / Statuses)
        // ==========================================

        [DisplayName("Fuel Card (Serial/Notes)")]
        public string fuel_card_s { get; set; } = "";

        [DisplayName("Shell Points Card (Serial/Notes)")]
        public string shell_points_card_s { get; set; } = "";

        [DisplayName("Shell Fuel Card (Serial/Notes)")]
        public string shell_fuel_card_s { get; set; } = "";

        [DisplayName("Interior Cleanliness (Notes)")]
        public string interior_clean_s { get; set; } = "";

        [DisplayName("Oil Level (Notes)")]
        public string oil_level_s { get; set; } = "";

        [DisplayName("Water Level (Notes)")]
        public string water_level_s { get; set; } = "";

        [DisplayName("Windscreen Wash (Notes)")]
        public string windscreen_wash_s { get; set; } = "";

        [DisplayName("Spare Wheel (Serial/Notes)")]
        public string spare_wheel_s { get; set; } = "";

        [DisplayName("Jack (Serial/Notes)")]
        public string jack_s { get; set; } = "";

        [DisplayName("Wheel Brace (Serial/Notes)")]
        public string wheel_brace_s { get; set; } = "";

        [DisplayName("Tools (Serial/Notes)")]
        public string tools_s { get; set; } = "";

        [DisplayName("Tyre Condition (Notes)")]
        public string tyre_condition_s { get; set; } = "";

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.sales_car, Registration); }
    }
}
