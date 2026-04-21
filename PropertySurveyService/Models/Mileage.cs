using Microsoft.EntityFrameworkCore;

namespace PropertySurveyService.Models
{
    public class MileageSheet
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string sheet_date { get; set; }
        public string start_postcode { get; set; }
        public string finish_postcode { get; set; }
        public string start_mileage { get; set; }
        public string end_mileage { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public int no_of_other_places { get; set; }
        public string time1 { get; set; }
        public string pcode1 { get; set; }
        public string time2 { get; set; }
        public string pcode2 { get; set; }
        public string time3 { get; set; }
        public string pcode3 { get; set; }
        public string registration { get; set; }
        public bool bSigned { get; set; }
        public string signature_filename { get; set; }
        public bool bComplete { get; set; }
        public bool bSent { get; set; }
        public string comments { get; set; }
        public int OtehrPlaceNo { get; set; }

        public string op_time1 { get; set; }
        public string op_postcode1 { get; set; }
        public string op_time2 { get; set; }
        public string op_postcode2 { get; set; }
        public string op_time3 { get; set; }
        public string op_postcode3 { get; set; }
        public string op_time4 { get; set; }
        public string op_postcode4 { get; set; }
        public string op_time5 { get; set; }
        public string op_postcode5 { get; set; }
        public string op_time6 { get; set; }
        public string op_postcode6 { get; set; }
        public string op_time7 { get; set; }
        public string op_postcode7 { get; set; }
        public string op_time8 { get; set; }
        public string op_postcode8 { get; set; }
        public string op_time9 { get; set; }
        public string op_postcode9 { get; set; }
        public string op_time10 { get; set; }
        public string op_postcode10 { get; set; }
        public string op_time11 { get; set; }
        public string op_postcode11 { get; set; }
        public string op_time12 { get; set; }
        public string op_postcode12 { get; set; }
        public string op_time13 { get; set; }
        public string op_postcode13 { get; set; }
        public string op_time14 { get; set; }
        public string op_postcode14 { get; set; }
        public string op_time15 { get; set; }
        public string op_postcode15 { get; set; }

        public int toll_charges { get; set; }
        public string toll_charge_for { get; set; }
        public string toll_charge_ammount { get; set; }

        public string photo_am { get; set; }
        public string photo_pm { get; set; }
    }
}
