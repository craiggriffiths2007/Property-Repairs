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

        public string CheckWeekDate { get; set; } = "";
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
        public Guid Guid { get; set; } = new Guid();
        public int VehicleCheckHeaderId { get; set; }
        public string CheckID { get; set; }
        public string Destination { get; set; } = "";
        public string CheckDoneDate { get; set; } = "";
        public string Registration { get; set; } = "";
        public string Mileage { get; set; } = "";
        public string BranchCode { get; set; } = "";
        public string PDAVersionDate { get; set; } = "";
        public int is_complete { get; set; } // relates to reason not complete question
        public string ReasonNotCompleted { get; set; } = "";
        public bool bComplete { get; set; }
        public bool bSent { get; set; }
        public int pressure_passenger_front { get; set; }
        public int pressure_passenger_rear { get; set; }
        public int pressure_driver_front { get; set; }
        public int pressure_driver_rear { get; set; }
        public int pressure_spare { get; set; }
        public string pressure_passenger_front_s { get; set; } = "";
        public string pressure_passenger_rear_s { get; set; } = "";
        public string pressure_driver_front_s { get; set; } = "";
        public string pressure_driver_rear_s { get; set; } = "";
        public string pressure_spare_s { get; set; } = "";
        public bool bPhotosOutsideComplete { get; set; }
        public bool bPhotosInsideComplete { get; set; }
        public bool bDiagramsComplete { get; set; }
        public bool bSignaturesComplete { get; set; }

        public string damage_pass { get; set; } = "";
        public string damage_driver { get; set; } = "";
        public string damage_front { get; set; } = "";
        public string damage_back { get; set; } = "";

        public int photos_front { get; set; }
        public int photos_rear { get; set; }
        public int photos_left { get; set; }
        public int photos_right { get; set; }

        public bool bDriverSigned { get; set; }
        public bool bCheckedBySigned { get; set; }
        public string driver_printed { get; set; } = "";
        public string checked_printed { get; set; } = "";
    }

 
    public class DeliveryHGV : VehicleCheck
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("National Tyres Card")]
        public int national_tyres_card { get; set; }

        [DisplayName("FMG Support Sticker")]
        public int fmg_support_sticker { get; set; }

        [DisplayName("Fuel Card")]
        public int fuel_card { get; set; }

        [DisplayName("Clean External")]
        public int clean_external { get; set; }

        [DisplayName("Clean Internal")]
        public int clean_internal { get; set; }

        [DisplayName("Fan Belt")]
        public int fan_belt { get; set; }

        [DisplayName("Fire Extinguisher")]
        public int fire_extinguisher { get; set; }

        [DisplayName("First Aid Box")]
        public int first_aid_box { get; set; }

        [DisplayName("Horn (Cab)")]
        public int horn { get; set; }

        [DisplayName("Oil & Water Checked")]
        public int oil_and_water_checked { get; set; }

        [DisplayName("Accident Pack")]
        public int accident_pack { get; set; }

        [DisplayName("Portable Lighting")]
        public int portable_lighting { get; set; }

        [DisplayName("AdBlue Level Checked")]
        public int ad_blue_level_check { get; set; }

        [DisplayName("Racks & Poles")]
        public int racks_and_poles { get; set; }

        [DisplayName("Ratchet Straps")]
        public int ratchet_straps { get; set; }

        [DisplayName("Service Due Sticker")]
        public int service_due_sticker { get; set; }

        [DisplayName("No Smoking Sticker")]
        public int no_smoking_sticker { get; set; }

        [DisplayName("Spare Oil")]
        public int spare_oil { get; set; }

        [DisplayName("Coolant & Anti-freeze")]
        public int coolant_anti_freez { get; set; }

        [DisplayName("Tyre Pressure")]
        public int tyre_pressure { get; set; }

        [DisplayName("Van Height Sticker")]
        public int van_height_sticker { get; set; }

        [DisplayName("Van Locks")]
        public int van_locks { get; set; }

        [DisplayName("Wheel Nut Check Sticker")]
        public int wheel_nut_check_sticker { get; set; }

        [DisplayName("Windscreen Washer")]
        public int windscreen_washer { get; set; }

        [DisplayName("Fuel & Oil Leaks")]
        public int fuel_oil_leaks { get; set; }

        [DisplayName("Battery Security & Condition")]
        public int battery_security_condition { get; set; }

        [DisplayName("Tyres & Wheel Fixing")]
        public int tyres_and_wheel_fixing { get; set; }

        [DisplayName("Spray Suppression")]
        public int spray_suppression { get; set; }

        [DisplayName("Steering")]
        public int steering { get; set; }

        [DisplayName("Security of Load")]
        public int security_of_load { get; set; }

        [DisplayName("Mirrors")]
        public int mirrors { get; set; }

        [DisplayName("Lights")]
        public int lights { get; set; }

        [DisplayName("Reflectors")]
        public int reflectors { get; set; }

        [DisplayName("Indicators")]
        public int inducators { get; set; }

        [DisplayName("Wipers")]
        public int wipers { get; set; }

        [DisplayName("Washers")]
        public int washers { get; set; }

        [DisplayName("Horn (Compliance)")]
        public int horn_comp { get; set; }

        [DisplayName("Excessive Exhaust Smoke")]
        public int excessive_exhaust_smoke { get; set; }

        [DisplayName("Brakes")]
        public int brakes { get; set; }

        [DisplayName("Security of Body")]
        public int security_of_body { get; set; }

        [DisplayName("Markers")]
        public int markers { get; set; }

        [DisplayName("Glass & Windscreen")]
        public int glass_windscreen { get; set; }

        [DisplayName("Receipt Book")]
        public int receipt_book { get; set; }

        [DisplayName("Keys for Branches (Sat)")]
        public int keys_for_branches_sat { get; set; }

        [DisplayName("PDA, Phone & Accident Pack")]
        public int pda_phone_accident_pack { get; set; }

        [DisplayName("Trade Invoices")]
        public int trade_invoices { get; set; }

        [DisplayName("Blue Bags")]
        public int blue_bags { get; set; }

        [DisplayName("Delivery Lists")]
        public int delivery_lists { get; set; }

        [DisplayName("Collection Lists")]
        public int collection_lists { get; set; }

        [DisplayName("Trade Delivery Notes")]
        public int trade_delivery_notes { get; set; }

        [DisplayName("Reported Defects")]
        public string report_defects { get; set; } = "";

        [DisplayName("Date Signed")]
        public string date_signed { get; set; } = "";

        [DisplayName("Loading Area Condition (Photo Count)")]
        public int loading_area_good_condition { get; set; }

        [DisplayName("Reason Loading Area Not OK")]
        public string reason_loading_area_not_good_condition { get; set; } = "";

        [DisplayName("Shell Fuel Card")]
        public int shell_fuel_card { get; set; }

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.delivery_hgv); }
    }
    public class DeliveryVan : VehicleCheck
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("ATS Card")]
        public int ats_card { get; set; }
        [DisplayName("Bodywork Check")]
        public int bodywork_check { get; set; }
        [DisplayName("Breakdown Card")]
        public int breakdown_card { get; set; }
        [DisplayName("Clean External")]
        public int clean_external { get; set; }
        [DisplayName("Clean Internal")]
        public int clean_internal { get; set; }
        [DisplayName("Fan Belt")]
        public int fan_belt { get; set; }
        [DisplayName("Fire Extinguisher")]
        public int fire_extinguisher { get; set; }
        [DisplayName("First Aid Box")]
        public int first_aid_box { get; set; }
        [DisplayName("Fuel Card")]
        public int fuel_card { get; set; }
        [DisplayName("Horn")]
        public int horn { get; set; }
        [DisplayName("Jack")]
        public int jack { get; set; }
        [DisplayName("Jump Leads")]
        public int jump_leads { get; set; }
        [DisplayName("Keys for Branches")]
        public int keys_for_branches { get; set; }
        [DisplayName("Lights/Indicators")]
        public int lights_inducators { get; set; }
        [DisplayName("Oil/Water Checked")]
        public int oil_water_checked { get; set; }
        [DisplayName("Racks/Poles")]
        public int racks_poles { get; set; }
        [DisplayName("Ratchet Straps")]
        public int ratchet_straps { get; set; }
        [DisplayName("Receipt Book")]
        public int receipt_book { get; set; }
        [DisplayName("Bump Hats")]
        public int bump_hats { get; set; }
        [DisplayName("Service Due Sticker")]
        public int service_due_sticker { get; set; }
        [DisplayName("Spanners for Rack Removal")]
        public int spanners_for_rack_removal { get; set; }
        [DisplayName("Spare Oil")]
        public int spare_oil { get; set; }
        [DisplayName("Coolant/Antifreeze Mix")]
        public int coolant_anti_freeze_mix { get; set; }
        [DisplayName("Spare Wheel")]
        public int spare_wheel { get; set; }
        [DisplayName("Tow Ropes")]
        public int tow_ropes { get; set; }
        [DisplayName("Tyre Pressure")]
        public int tyre_pressure { get; set; }
        [DisplayName("Van Height Sticker")]
        public int van_height_sticker { get; set; }
        [DisplayName("Van Locks")]
        public int van_locks { get; set; }
        [DisplayName("Wheel Nut Check Sticker")]
        public int wheel_nut_check_sticker { get; set; }
        [DisplayName("Wheelbrace")]
        public int wheelbrace { get; set; }
        [DisplayName("Windscreen Washer")]
        public int windscreen_washer { get; set; }
        [DisplayName("PDA/Phone/Accident Pack")]
        public int pda_phone_accident_pack { get; set; }
        [DisplayName("Branch Keys")]
        public int branch_keys { get; set; }
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
        public int loading_area_good_condition { get; set; }// No of additional photos
        [DisplayName("Reason Loading Area Not Good Condition")]
        public string reason_loading_area_not_good_condition { get; set; } = "";
        [DisplayName("Spare 1 (Shell Fuel Card)")]
        public string spare_s_1 { get; set; } = ""; // Shell Fuel Card

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.delivery_van); }
    }
    public class FitterVan : VehicleCheck
    {
        public int Id { get; set; }

        // --- Core Tools & Equipment ---

        [DisplayName("Circuit Breaker")]
        public int circuit_breaker { get; set; }

        [DisplayName("Power Breaker")]
        public int power_breaker { get; set; }

        [DisplayName("Hammer Drill")]
        public int hammer_drill { get; set; }

        [DisplayName("Ordinary Drill")]
        public int ordinary_drill { get; set; }

        [DisplayName("Cordless Drill")]
        public int cordless_drill { get; set; }

        [DisplayName("Spare Battery & Charger")]
        public int spare_battery_and_charger { get; set; }

        [DisplayName("Circular Saw")]
        public int circular_saw { get; set; }

        [DisplayName("Jig Saw")]
        public int jig_saw { get; set; }

        [DisplayName("Planer (Check Blade)")]
        public int planer_check_blade { get; set; }

        [DisplayName("Heat Gun")]
        public int heat_gun { get; set; }

        [DisplayName("Sander")]
        public int sander { get; set; }

        [DisplayName("Grinder")]
        public int grinder { get; set; }

        [DisplayName("Hoover")]
        public int hoover { get; set; }

        [DisplayName("Halogen Lamp")]
        public int halogen_lamp { get; set; }

        [DisplayName("Extension Lead")]
        public int extension_lead { get; set; }

        [DisplayName("Router")]
        public int router { get; set; }

        // --- Ladders & Securing ---

        [DisplayName("Industrial Ladders")]
        public int industrial_ladders { get; set; }

        [DisplayName("Ladder Clamps")]
        public int ladder_clamps { get; set; }

        [DisplayName("Step Ladders")]
        public int step_ladders { get; set; }

        [DisplayName("Ladder Stopper")]
        public int ladder_stopper { get; set; }

        // --- Hand Tools & Accessories ---

        [DisplayName("Philips Bit")]
        public int philips_bit { get; set; }

        [DisplayName("Screw Box")]
        public int screw_box { get; set; }

        [DisplayName("Trestles (x2)")]
        public int tresles_x2 { get; set; }

        [DisplayName("Working Torch")]
        public int torch_working { get; set; }

        [DisplayName("Ratchet Straps (x4)")]
        public int ratchett_straps_x4 { get; set; }

        // --- Housekeeping & Protection ---

        [DisplayName("Blue External Dust Sheet")]
        public int blue_external_dust_sheet { get; set; }

        [DisplayName("Internal Dust Sheets (x3)")]
        public int internal_dust_sheets_x3 { get; set; }

        [DisplayName("Brush & Shovel")]
        public int brush_and_shovel { get; set; }

        [DisplayName("Cleaner Bottle")]
        public int cleaner_bottle { get; set; }

        [DisplayName("E-Cloth")]
        public int ecloth { get; set; }

        [DisplayName("Mastic Guns")]
        public int mastic_guns { get; set; }

        [DisplayName("Glass Suckers")]
        public int glass_suckers { get; set; }

        // --- Safety Wear (PPE) ---

        [DisplayName("Safety Helmets")]
        public int safety_helmets { get; set; }

        [DisplayName("Helmet Manufacture Date Check")]
        public int helmet_manufacture_date { get; set; }

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
        public int hi_vis_vests { get; set; }

        // --- Forms & Documentation ---

        [DisplayName("Customer Care Cards")]
        public int customer_care_cards { get; set; }

        [DisplayName("Completion Forms")]
        public int completion_forms { get; set; }

        [DisplayName("Freepost Envelopes")]
        public int freepost_envelopes { get; set; }

        [DisplayName("Mandate Forms")]
        public int mandate_forms { get; set; }

        [DisplayName("Quality Manuals")]
        public int quality_manuals { get; set; }

        [DisplayName("Stapler")]
        public int stapler { get; set; }

        [DisplayName("Worksheets")]
        public int worksheets { get; set; }

        // --- First Aid Kit ---

        [DisplayName("Plasters")]
        public int plasters { get; set; }

        [DisplayName("Dressing")]
        public int dressing { get; set; }

        [DisplayName("Eyewashers")]
        public int eyewashers { get; set; }

        [DisplayName("Steri-wipes")]
        public int steri_wipes { get; set; }

        [DisplayName("First Aid Bag")]
        public int bag { get; set; }

        // --- Specialist Meters ---

        [DisplayName("Flexi-Meter")]
        public int flexi_meter { get; set; }

        [DisplayName("Merlin Low-E Detector")]
        public int merlin_low_e_detector { get; set; }

        // --- Vehicle Cards, Safety & Essentials ---

        [DisplayName("Cabin Condition")]
        public int cabin_condition { get; set; }

        [DisplayName("National Tyres Card")]
        public int national_tyres_card { get; set; }

        [DisplayName("Breakdown Card")]
        public int breakdown_card { get; set; }

        [DisplayName("Fuel Card")]
        public int fuel_card { get; set; }

        [DisplayName("Shell Points Card")]
        public int shell_points_card { get; set; }

        [DisplayName("Fire Extinguisher")]
        public int fire_extinguisher { get; set; }

        [DisplayName("Jack")]
        public int jack { get; set; }

        [DisplayName("Wheelbrace")]
        public int wheelbrace { get; set; }

        [DisplayName("Spare Wheel")]
        public int spare_wheel { get; set; }

        [DisplayName("Jump Leads")]
        public int jump_leads { get; set; }

        [DisplayName("Fan Belt")]
        public int fan_belt { get; set; }

        [DisplayName("Tow Ropes")]
        public int tow_ropes { get; set; }

        [DisplayName("Spare Oil")]
        public int spare_oil { get; set; }

        [DisplayName("Coolant & Anti-freeze")]
        public int coolant_anti_freeze { get; set; }

        [DisplayName("Van Height Sticker")]
        public int van_height_sticker { get; set; }

        [DisplayName("Wheel Nut Check Sticker")]
        public int wheel_nut_check_sticker { get; set; }

        [DisplayName("No Smoking Sticker")]
        public int no_smoking_sticker { get; set; }

        [DisplayName("Racks & Poles")]
        public int racks_and_poles { get; set; }

        [DisplayName("Tyre Conditions")]
        public int tyre_conditions { get; set; }

        [DisplayName("Van Locks")]
        public int van_locks { get; set; }

        [DisplayName("Oil & Water Checked")]
        public int oil_and_water_checked { get; set; }

        [DisplayName("How's My Driving Sticker")]
        public int hows_my_driving_sticker { get; set; }

        [DisplayName("PDA Setup Date")]
        public int pda_setup_date { get; set; }

        [DisplayName("Accident Pack on PDA")]
        public int accident_pack_on_pda { get; set; }

        [DisplayName("Windscreen Condition")]
        public int windscreen_good_contidion { get; set; }


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

        [DisplayName("Shell Fuel Card")]
        public string spare_s_1 { get; set; } = "";

        [DisplayName("Spare Text Field 2")]
        public string spare_s_2 { get; set; } = "";

        [DisplayName("Spare Text Field 3")]
        public string spare_s_3 { get; set; } = "";

        [DisplayName("Spare Text Field 4")]
        public string spare_s_4 { get; set; } = "";

        [DisplayName("Spare Numeric Field 1")]
        public int spare_i_1 { get; set; }

        [DisplayName("Additional Photos Count")]
        public int spare_i_2 { get; set; }

        [DisplayName("Diagrams Viewed (0 = No, 1 = Yes)")]
        public int spare_i_3 { get; set; }

        [DisplayName("Spare Numeric Field 4")]
        public int spare_i_4 { get; set; }

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
        public string letterbox_jig { get; set; } = "";

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.fitter_van); }
    }
    public class SalesCar : VehicleCheck
    {
        public int Id { get; set; }

        // --- Core Vehicle Checks ---

        [DisplayName("Fuel Card")]
        public int fuel_card { get; set; }

        [DisplayName("Shell Points Card")]
        public int shell_points_card { get; set; }

        [DisplayName("Shell Fuel Card")]
        public int shell_fuel_card { get; set; }

        [DisplayName("Interior Cleanliness")]
        public int interior_clean { get; set; }

        [DisplayName("Oil Level")]
        public int oil_level { get; set; }

        [DisplayName("Water Level")]
        public int water_level { get; set; }

        [DisplayName("Windscreen Wash")]
        public int windscreen_wash { get; set; }

        [DisplayName("Spare Wheel")]
        public int spare_wheel { get; set; }

        [DisplayName("Jack")]
        public int jack { get; set; }

        [DisplayName("Wheel Brace")]
        public int wheel_brace { get; set; }

        [DisplayName("Tools")]
        public int tools { get; set; }

        [DisplayName("Tyre Condition")]
        public int tyre_condition { get; set; }


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

        public VehicleCheckVehicle AsVehicleCheckVehicle() { return new VehicleCheckVehicle(Id, enum_vehicle_type.sales_car); }
    }
}
