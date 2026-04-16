using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertySurveyService.Migrations
{
    /// <inheritdoc />
    public partial class vehiclechecks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_clean_external",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_clean_internal",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_fan_belt",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_fire_extinguisher",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_first_aid_box",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_fuel_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_horn",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_loading_area_good_condition",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_national_tyres_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_no_smoking_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_oil_and_water_checked",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_pda_phone_accident_pack",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_racks_and_poles",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_ratchet_straps",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryHGV_reason_loading_area_not_good_condition",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_receipt_book",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_service_due_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_shell_fuel_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_spare_oil",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_tyre_pressure",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_van_height_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_van_locks",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_wheel_nut_check_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryHGV_windscreen_washer",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_breakdown_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_breakdown_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_fan_belt",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_fan_belt_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_fire_extinguisher",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_fire_extinguisher_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_fuel_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_fuel_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_jack",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_jack_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_jump_leads",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_jump_leads_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_spare_oil",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_spare_oil_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_spare_s_1",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_spare_wheel",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_spare_wheel_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_tow_ropes",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_tow_ropes_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_van_height_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_van_height_sticker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_van_locks",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_van_locks_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_wheel_nut_check_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_wheel_nut_check_sticker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryVan_wheelbrace",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryVan_wheelbrace_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Vehicles",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FitterVan_fuel_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FitterVan_fuel_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FitterVan_jack",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FitterVan_jack_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FitterVan_shell_points_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FitterVan_shell_points_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FitterVan_spare_wheel",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FitterVan_spare_wheel_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet10",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet2",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet3",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet4",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet5",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet6",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet7",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet8",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufactureDateOnHelmet9",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "accident_pack",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "accident_pack_on_pda",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "accident_pack_on_pda_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ad_blue_level_check",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ats_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ats_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bag",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bag_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "battery_security_condition",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "blue_bags",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "blue_external_dust_sheet",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "blue_external_dust_sheet_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bodywork_check",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bodywork_check_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "brakes",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "branch_keys",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "branch_keys_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "breakdown_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "breakdown_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "brush_and_shovel",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "brush_and_shovel_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bump_hats",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bump_hats_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cabin_condition",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cabin_condition_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "circuit_breaker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "circuit_breaker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "circular_saw",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "circular_saw_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clean_external",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "clean_external_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clean_internal",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "clean_internal_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cleaner_bottle",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cleaner_bottle_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "collection_lists",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "completion_forms",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "completion_forms_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "coolant_anti_freez",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "coolant_anti_freeze",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "coolant_anti_freeze_mix",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "coolant_anti_freeze_mix_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "coolant_anti_freeze_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cordless_drill",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cordless_drill_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customer_care_cards",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customer_care_cards_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "date_signed",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "delivery_lists",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "dressing",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dressing_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "dust_masks",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dust_masks_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ear_defenders",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ear_defenders_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ecloth",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ecloth_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "excessive_exhaust_smoke",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "extension_lead",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "extension_lead_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "eyewashers",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "eyewashers_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fan_belt",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fan_belt_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fire_extinguisher",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fire_extinguisher_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "first_aid_box",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "first_aid_box_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fitters_own_power_tools_ladders_on_van",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "flexi_meter",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "flexi_meter_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fmg_support_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "freepost_envelopes",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "freepost_envelopes_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fuel_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fuel_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fuel_oil_leaks",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "glass_suckers",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "glass_suckers_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "glass_windscreen",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gloves",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gloves_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "goggles",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "goggles_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "grinder",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "grinder_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "halogen_lamp",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "halogen_lamp_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hammer_drill",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hammer_drill_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "heat_gun",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "heat_gun_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "helmet_manufacture_date",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "helmet_manufacture_date_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hi_vis_vests",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hi_vis_vests_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hoover",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hoover_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "horn",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "horn_comp",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "horn_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hows_my_driving_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hows_my_driving_sticker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "inducators",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "industrial_ladders",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "industrial_ladders_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "interior_clean",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "interior_clean_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "internal_dust_sheets_x3",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "internal_dust_sheets_x3_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jack",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "jack_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jig_saw",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "jig_saw_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jump_leads",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "jump_leads_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "keys_for_branches",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "keys_for_branches_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "keys_for_branches_sat",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ladder_clamps",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ladder_clamps_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ladder_stopper",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ladder_stopper_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "letterbox_jig",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "lights",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "lights_inducators",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lights_inducators_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "loading_area_good_condition",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mandate_forms",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mandate_forms_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "markers",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "marks_out_of_10",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mastic_guns",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mastic_guns_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "merlin_low_e_detector",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "merlin_low_e_detector_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mirrors",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "national_tyres_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "national_tyres_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "no_smoking_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_smoking_sticker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "oil_and_water_checked",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "oil_and_water_checked_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "oil_level",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "oil_level_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "oil_water_checked",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "oil_water_checked_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ordinary_drill",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ordinary_drill_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pda_phone_accident_pack",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pda_phone_accident_pack_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pda_setup_date",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pda_setup_date_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "philips_bit",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "philips_bit_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planer_check_blade",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "planer_check_blade_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "plasters",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "plasters_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "portable_lighting",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "power_breaker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "power_breaker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quality_manuals",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "quality_manuals_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "racks_and_poles",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "racks_and_poles_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "racks_poles",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "racks_poles_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ratchet_straps",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ratchet_straps_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ratchett_straps_x4",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ratchett_straps_x4_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "reason_loading_area_not_good_condition",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "receipt_book",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "receipt_book_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "reflectors",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "report_defects",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "router",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "router_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "safety_helmets",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "safety_helmets_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sander",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sander_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "screw_box",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "screw_box_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "security_of_body",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "security_of_load",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "service_due_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "service_due_sticker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shell_fuel_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shell_fuel_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shell_points_card",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shell_points_card_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spanners_for_rack_removal",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spanners_for_rack_removal_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spare_battery_and_charger",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spare_battery_and_charger_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spare_i_1",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spare_i_2",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spare_i_3",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spare_i_4",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spare_oil",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spare_oil_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spare_s_1",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spare_s_2",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spare_s_3",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spare_s_4",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spare_wheel",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "spare_wheel_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "spray_suppression",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stapler",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "stapler_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "steering",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "step_ladders",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step_ladders_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "steri_wipes",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "steri_wipes_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tools",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tools_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "torch_working",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "torch_working_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tow_ropes",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tow_ropes_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "trade_delivery_notes",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "trade_invoices",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tresles_x2",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tresles_x2_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tyre_condition",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tyre_condition_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tyre_conditions",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tyre_conditions_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tyre_pressure",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tyre_pressure_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tyres_and_wheel_fixing",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "van_height_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "van_height_sticker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "van_locks",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "van_locks_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vehicle_reg",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "washers",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "water_level",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "water_level_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wheel_brace",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wheel_brace_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wheel_nut_check_sticker",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wheel_nut_check_sticker_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wheelbrace",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wheelbrace_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "windscreen_good_contidion",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "windscreen_good_contidion_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "windscreen_wash",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "windscreen_wash_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "windscreen_washer",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "windscreen_washer_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wipers",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "worksheets",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "worksheets_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wrist_guards",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "wrist_guards_s",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VehicleCheckHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckWeekDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bComplete = table.Column<bool>(type: "bit", nullable: false),
                    bSent = table.Column<bool>(type: "bit", nullable: false),
                    TotalDeliveryHGVs = table.Column<int>(type: "int", nullable: false),
                    TotalDeliveryVans = table.Column<int>(type: "int", nullable: false),
                    TotalFitterVans = table.Column<int>(type: "int", nullable: false),
                    TotalSalesCars = table.Column<int>(type: "int", nullable: false),
                    CompleteDeliveryHGVs = table.Column<int>(type: "int", nullable: false),
                    CompleteDeliveryVans = table.Column<int>(type: "int", nullable: false),
                    CompleteFitterVans = table.Column<int>(type: "int", nullable: false),
                    CompleteSalesCars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCheckHeaders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleCheckHeaders");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_clean_external",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_clean_internal",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_fan_belt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_fire_extinguisher",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_first_aid_box",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_fuel_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_horn",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_loading_area_good_condition",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_national_tyres_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_no_smoking_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_oil_and_water_checked",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_pda_phone_accident_pack",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_racks_and_poles",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_ratchet_straps",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_reason_loading_area_not_good_condition",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_receipt_book",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_service_due_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_shell_fuel_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_spare_oil",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_tyre_pressure",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_van_height_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_van_locks",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_wheel_nut_check_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryHGV_windscreen_washer",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_breakdown_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_breakdown_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_fan_belt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_fan_belt_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_fire_extinguisher",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_fire_extinguisher_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_fuel_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_fuel_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_jack",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_jack_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_jump_leads",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_jump_leads_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_spare_oil",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_spare_oil_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_spare_s_1",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_spare_wheel",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_spare_wheel_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_tow_ropes",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_tow_ropes_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_van_height_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_van_height_sticker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_van_locks",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_van_locks_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_wheel_nut_check_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_wheel_nut_check_sticker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_wheelbrace",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DeliveryVan_wheelbrace_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_fuel_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_fuel_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_jack",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_jack_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_shell_points_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_shell_points_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_spare_wheel",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FitterVan_spare_wheel_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet10",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet2",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet3",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet4",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet5",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet6",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet7",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet8",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufactureDateOnHelmet9",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "accident_pack",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "accident_pack_on_pda",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "accident_pack_on_pda_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ad_blue_level_check",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ats_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ats_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "bag",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "bag_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "battery_security_condition",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "blue_bags",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "blue_external_dust_sheet",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "blue_external_dust_sheet_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "bodywork_check",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "bodywork_check_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "brakes",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "branch_keys",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "branch_keys_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "breakdown_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "breakdown_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "brush_and_shovel",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "brush_and_shovel_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "bump_hats",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "bump_hats_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "cabin_condition",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "cabin_condition_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "circuit_breaker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "circuit_breaker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "circular_saw",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "circular_saw_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "clean_external",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "clean_external_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "clean_internal",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "clean_internal_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "cleaner_bottle",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "cleaner_bottle_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "collection_lists",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "completion_forms",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "completion_forms_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "coolant_anti_freez",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "coolant_anti_freeze",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "coolant_anti_freeze_mix",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "coolant_anti_freeze_mix_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "coolant_anti_freeze_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "cordless_drill",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "cordless_drill_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "customer_care_cards",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "customer_care_cards_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "date_signed",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "delivery_lists",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "dressing",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "dressing_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "dust_masks",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "dust_masks_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ear_defenders",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ear_defenders_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ecloth",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ecloth_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "excessive_exhaust_smoke",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "extension_lead",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "extension_lead_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "eyewashers",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "eyewashers_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fan_belt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fan_belt_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fire_extinguisher",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fire_extinguisher_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "first_aid_box",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "first_aid_box_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fitters_own_power_tools_ladders_on_van",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "flexi_meter",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "flexi_meter_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fmg_support_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "freepost_envelopes",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "freepost_envelopes_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fuel_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fuel_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "fuel_oil_leaks",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "glass_suckers",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "glass_suckers_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "glass_windscreen",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "gloves",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "gloves_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "goggles",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "goggles_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "grinder",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "grinder_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "halogen_lamp",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "halogen_lamp_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hammer_drill",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hammer_drill_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "heat_gun",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "heat_gun_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "helmet_manufacture_date",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "helmet_manufacture_date_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hi_vis_vests",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hi_vis_vests_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hoover",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hoover_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "horn",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "horn_comp",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "horn_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hows_my_driving_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "hows_my_driving_sticker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "inducators",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "industrial_ladders",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "industrial_ladders_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "interior_clean",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "interior_clean_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "internal_dust_sheets_x3",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "internal_dust_sheets_x3_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "jack",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "jack_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "jig_saw",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "jig_saw_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "jump_leads",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "jump_leads_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "keys_for_branches",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "keys_for_branches_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "keys_for_branches_sat",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ladder_clamps",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ladder_clamps_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ladder_stopper",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ladder_stopper_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "letterbox_jig",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "lights",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "lights_inducators",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "lights_inducators_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "loading_area_good_condition",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "mandate_forms",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "mandate_forms_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "markers",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "marks_out_of_10",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "mastic_guns",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "mastic_guns_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "merlin_low_e_detector",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "merlin_low_e_detector_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "mirrors",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "national_tyres_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "national_tyres_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "no_smoking_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "no_smoking_sticker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "oil_and_water_checked",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "oil_and_water_checked_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "oil_level",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "oil_level_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "oil_water_checked",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "oil_water_checked_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ordinary_drill",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ordinary_drill_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "pda_phone_accident_pack",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "pda_phone_accident_pack_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "pda_setup_date",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "pda_setup_date_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "philips_bit",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "philips_bit_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "planer_check_blade",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "planer_check_blade_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "plasters",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "plasters_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "portable_lighting",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "power_breaker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "power_breaker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "quality_manuals",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "quality_manuals_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "racks_and_poles",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "racks_and_poles_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "racks_poles",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "racks_poles_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ratchet_straps",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ratchet_straps_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ratchett_straps_x4",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ratchett_straps_x4_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "reason_loading_area_not_good_condition",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "receipt_book",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "receipt_book_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "reflectors",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "report_defects",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "router",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "router_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "safety_helmets",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "safety_helmets_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "sander",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "sander_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "screw_box",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "screw_box_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "security_of_body",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "security_of_load",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "service_due_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "service_due_sticker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "shell_fuel_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "shell_fuel_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "shell_points_card",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "shell_points_card_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spanners_for_rack_removal",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spanners_for_rack_removal_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_battery_and_charger",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_battery_and_charger_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_i_1",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_i_2",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_i_3",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_i_4",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_oil",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_oil_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_s_1",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_s_2",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_s_3",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_s_4",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_wheel",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spare_wheel_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "spray_suppression",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "stapler",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "stapler_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "steering",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "step_ladders",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "step_ladders_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "steri_wipes",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "steri_wipes_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tools",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tools_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "torch_working",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "torch_working_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tow_ropes",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tow_ropes_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "trade_delivery_notes",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "trade_invoices",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tresles_x2",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tresles_x2_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tyre_condition",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tyre_condition_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tyre_conditions",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tyre_conditions_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tyre_pressure",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tyre_pressure_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "tyres_and_wheel_fixing",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "van_height_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "van_height_sticker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "van_locks",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "van_locks_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "vehicle_reg",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "washers",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "water_level",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "water_level_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wheel_brace",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wheel_brace_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wheel_nut_check_sticker",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wheel_nut_check_sticker_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wheelbrace",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wheelbrace_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "windscreen_good_contidion",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "windscreen_good_contidion_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "windscreen_wash",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "windscreen_wash_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "windscreen_washer",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "windscreen_washer_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wipers",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "worksheets",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "worksheets_s",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wrist_guards",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "wrist_guards_s",
                table: "Vehicles");
        }
    }
}
