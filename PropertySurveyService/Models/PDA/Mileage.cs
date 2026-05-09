using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PropertySurveyService.Models
{
    public class MileageSheet
    {
        public int Id { get; set; }

        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();

        [DisplayName("Sheet Date")]
        public string sheet_date { get; set; } = "";

        [DisplayName("Vehicle Registration")]
        public string registration { get; set; } = "";


        // --- Core Trip Details ---

        [DisplayName("Start Postcode")]
        public string start_postcode { get; set; } = "";

        [DisplayName("Finish Postcode")]
        public string finish_postcode { get; set; } = "";

        [DisplayName("Start Mileage")]
        public string start_mileage { get; set; } = "";

        [DisplayName("End Mileage")]
        public string end_mileage { get; set; } = "";

        [DisplayName("Start Time")]
        public string start_time { get; set; } = "";

        [DisplayName("End Time")]
        public string end_time { get; set; } = "";


        // --- Intermediate / Additional Stops (Standard) ---

        [DisplayName("Number of Other Places")]
        public int no_of_other_places { get; set; }

        [DisplayName("Stop 1 Time")]
        public string time1 { get; set; } = "";

        [DisplayName("Stop 1 Postcode")]
        public string pcode1 { get; set; } = "";

        [DisplayName("Stop 2 Time")]
        public string time2 { get; set; } = "";

        [DisplayName("Stop 2 Postcode")]
        public string pcode2 { get; set; } = "";

        [DisplayName("Stop 3 Time")]
        public string time3 { get; set; } = "";

        [DisplayName("Stop 3 Postcode")]
        public string pcode3 { get; set; } = "";


        // --- Other Places (Alternative / Overflow Stops) ---

        [DisplayName("Other Place Number Selection")]
        public int OtehrPlaceNo { get; set; }

        [DisplayName("Other Place 1 Time")]
        public string op_time1 { get; set; } = "";

        [DisplayName("Other Place 1 Postcode")]
        public string op_postcode1 { get; set; } = "";

        [DisplayName("Other Place 2 Time")]
        public string op_time2 { get; set; } = "";

        [DisplayName("Other Place 2 Postcode")]
        public string op_postcode2 { get; set; } = "";

        [DisplayName("Other Place 3 Time")]
        public string op_time3 { get; set; } = "";

        [DisplayName("Other Place 3 Postcode")]
        public string op_postcode3 { get; set; } = "";


        // --- Toll & Expenses ---

        [DisplayName("Toll Charges Incurred")]
        public int toll_charges { get; set; } = 0;

        [DisplayName("Toll Charge Location/Reason")]
        public string toll_charge_for { get; set; } = "";

        [DisplayName("Toll Charge Amount")]
        public string toll_charge_ammount { get; set; } = "";


        // --- Odometer / Verification Photos ---

        [DisplayName("Odometer Photo (AM/Start)")]
        public string photo_am { get; set; } = "";

        [DisplayName("Odometer Photo (PM/End)")]
        public string photo_pm { get; set; } = "";


        // --- Sign-off & Status ---

        [DisplayName("Driver Signed")]
        public bool bSigned { get; set; }

        [DisplayName("Signature Filename")]
        public string signature_filename { get; set; } = "";

        [DisplayName("Is Completed")]
        public bool bComplete { get; set; }

        [DisplayName("Sent to Server")]
        public bool bSent { get; set; }

        [DisplayName("Comments/Notes")]
        public string comments { get; set; } = "";
    }
}
