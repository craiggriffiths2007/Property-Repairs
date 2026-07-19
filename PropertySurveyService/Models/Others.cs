using Microsoft.CodeAnalysis.Elfie.Model.Tree;

namespace PropertySurveyService.Models
{
    public enum enum_special_glass_type
    {
        None = 0,
        BackToBack = 1,
        DiamondLead = 2,
        GeorgainBar = 3,
        GeorgianLead = 4
    }

    public enum enum_job_type
    {
        Survey,
        Fitting,
        Remedial
    }

    public enum agent_type
    {
        Surveyor,
        Fitter,
        Satellite
    }

    public enum enum_vehicle_type
    {
        delivery_hgv, delivery_van, fitter_van, sales_car
    }

    public enum enum_item_type
    {
        none,
        frame,
        panel,
        upvc,
        aluminium,
        conservatory,
        garage,
        timber,
        locking,
        glass,
        composite,
        greenhouse,
        bifold,
        house
    }

    public class VehicleCheckVehicle
    {
        public int Id { get; set; }
        public enum_vehicle_type VehicleType { get; set; }
        public string? VehicleName { get; set; }
        public string Registration { get; set; } = "";
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

        public VehicleCheckVehicle(int id, enum_vehicle_type type, string reg)
        {
            Id = id;
            VehicleType = type;
            VehicleName = NameFromEnumType(type);
            ControllerName = ControllerNameFromEnumType(type);
            Registration = reg;
        }
    }

    public class SurveyItem
    {
        public int Id { get; set; }
        public enum_item_type ItemType { get; set; }
        public string? ItemName { get; set; }
        public int item_number { get; set; }
        public string? ControllerName { get; set; }
        public string ContractCode { get; set; } = "";
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
                case enum_item_type.aluminium: return "Aluminium";
                case enum_item_type.garage: return "Garage";
                case enum_item_type.timber: return "Timber";
                case enum_item_type.bifold: return "Bifolding";
                case enum_item_type.locking: return "Lock-mech";
                case enum_item_type.greenhouse: return "Greenhouse";
                case enum_item_type.conservatory: return "Conservatory";
                case enum_item_type.composite: return "Composite";
                case enum_item_type.frame: return "Material";
            }
            return "";
        }

        public string ControllerNameFromEnumType(enum_item_type type)
        {
            switch (type)
            {
                case enum_item_type.upvc: return "UPVC";
                case enum_item_type.panel: return "Panel";
                case enum_item_type.glass: return "Glass";
                case enum_item_type.aluminium: return "Aluminium";
                case enum_item_type.garage: return "Garage";
                case enum_item_type.timber: return "Timber";
                case enum_item_type.bifold: return "Bifolding";
                case enum_item_type.locking: return "Lockmech";
                case enum_item_type.greenhouse: return "Greenhouse";
                case enum_item_type.conservatory: return "Conservatory";
                case enum_item_type.composite: return "Composite";
                case enum_item_type.frame: return "Material";
            }
            return "";
        }


        public SurveyItem(int id, enum_item_type type, int itemNumber, string contractCode)
        {
            Id = id;
            ItemType = type;
            ItemName = NameFromEnumType(type);
            ControllerName = ControllerNameFromEnumType(type);
            item_number = itemNumber;
            ContractCode = contractCode;
        }
    }
}
