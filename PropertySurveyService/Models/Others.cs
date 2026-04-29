using Microsoft.CodeAnalysis.Elfie.Model.Tree;

namespace PropertySurveyService.Models
{
    public enum enum_job_type
    {
        survey,
        fitting
    }

    public enum agent_type
    {
        surveyor,
        fitter,
        satellite
    }

    public enum enum_vehicle_type
    {
        delivery_hgv, delivery_van, fitter_van, sales_car
    }

    public enum enum_item_type
    {
        upvc, panel, glass, alum, garage, timber,
        bifold, cons, lockin, comp, green
    }

    public class VehicleCheckVehicle
    {
        public int Id { get; set; }
        public enum_vehicle_type VehicleType { get; set; }
        public string? VehicleName { get; set; }

        public string? ControllerName { get; set; }
        public string NameFromEnumType()
        {
            return NameFromEnumType(VehicleType);
        }
        public string NameFromEnumType(enum_vehicle_type type)
        {
            switch (type)
            {
                case enum_vehicle_type.delivery_hgv: return "Delivery HGV";
                case enum_vehicle_type.delivery_van: return "Delivery Van";
                case enum_vehicle_type.fitter_van: return "Fitter Van";
                case enum_vehicle_type.sales_car: return "Sales Car";
            }
            return "";
        }
        public string ControllerNameFromEnumType(enum_vehicle_type type)
        {
            switch (type)
            {
                case enum_vehicle_type.delivery_hgv: return "DeliveryHGVs";
                case enum_vehicle_type.delivery_van: return "DeliveryVans";
                case enum_vehicle_type.fitter_van: return "FitterVans";
                case enum_vehicle_type.sales_car: return "SalesCars";
            }
            return "";
        }

        public VehicleCheckVehicle(int id, enum_vehicle_type type)
        {
            Id = id;
            VehicleType = type;
            VehicleName = NameFromEnumType(type);
            ControllerName = ControllerNameFromEnumType(type);
        }
    }

    public class SurveyItem
    {
        public int Id { get; set; }
        public enum_item_type ItemType { get; set; }
        public string? ItemName { get; set; }

        public string? ControllerName { get; set; }
        public string NameFromEnumType()
        {
            return NameFromEnumType(ItemType);
        }
        public string NameFromEnumType(enum_item_type type)
        {
            switch (type)
            {
                case enum_item_type.upvc: return "UPVC";
                case enum_item_type.panel: return "Panel";
                case enum_item_type.glass: return "Glass";
                case enum_item_type.alum: return "Aluminium";
                case enum_item_type.garage: return "Garage";
                case enum_item_type.timber: return "Timber";
                case enum_item_type.bifold: return "Bifold";
                case enum_item_type.lockin: return "Lock-mech";
                case enum_item_type.green: return "Greenhouse";
            }
            return "";
        }

        public string ControllerNameFromEnumType(enum_item_type type)
        {
            switch (type)
            {
                case enum_item_type.upvc: return "UPVCTables";
                case enum_item_type.panel: return "PanelTables";
                case enum_item_type.glass: return "GlassTables";
                case enum_item_type.alum: return "AlumTables";
                case enum_item_type.garage: return "GarageTables";
                case enum_item_type.timber: return "TimberTables";
                case enum_item_type.bifold: return "BifoldTables";
                case enum_item_type.lockin: return "LockingTables";
                case enum_item_type.green: return "GreenTables";
            }
            return "";
        }


        public SurveyItem(int id, enum_item_type type)
        {
            Id = id;
            ItemType = type;
            ItemName = NameFromEnumType(type);
            ControllerName = ControllerNameFromEnumType(type);
        }
    }
}
