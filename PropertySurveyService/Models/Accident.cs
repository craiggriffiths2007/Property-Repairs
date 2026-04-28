using Microsoft.EntityFrameworkCore;

namespace PropertySurveyService.Models
{
    public class AccidentsVehicleDTO
    {
        public Accident_sheet Accident { get; set; }
        public List<Whitness>? Whitnesses { get; set; }

    }

    public class Whitness
    {
        public int Id { get; set; }
        public int Accident_sheetId { get; set; }
        public string p_name { get; set; }
        public string p_add1 { get; set; }
        public string p_add2 { get; set; }
        public string p_add3 { get; set; }
        public string p_pcode { get; set; }
        public string p_wittel { get; set; }
        public bool complete { get; set; }
    }



    public class Accident_sheet
    {
 
        public int Id { get; set; }
        //Header
        public string date_time { get; set; }
        public bool bSent { get; set; }
        public bool bComplete { get; set; }
        public string brief { get; set; }
        public bool c_instructions { get; set; }
        public bool c_details { get; set; }
        public bool c_you { get; set; }
        public bool c_them { get; set; }
        public bool c_police { get; set; }
        public bool c_witness { get; set; }
        public bool c_photographs { get; set; }
        public bool c_drawings { get; set; }
        // DETAILS ///////////////////
        public bool d_bPolice { get; set; }
        public string d_officers_name { get; set; }
        public string d_officers_number { get; set; }
        public string d_station { get; set; }
        public string d_place { get; set; }
        public string d_speed { get; set; }
        public string d_weather { get; set; }
        public string d_description { get; set; }
        public string d_sign_date { get; set; }
        // YOU ////////////////////
        public string y_make { get; set; }
        public string y_model { get; set; }
        public string y_reg { get; set; }
        public string y_used_for { get; set; }
        public string y_driver_full_name { get; set; }
        public string y_driver_dob { get; set; }
        public string y_address1 { get; set; }
        public string y_address2 { get; set; }
        public string y_address3 { get; set; }
        public string y_pcode { get; set; }
        public string y_occupation { get; set; }
        public string y_years_employed { get; set; }
        public string y_months_employed { get; set; }
        public string y_any_other_accidents { get; set; }
        public string y_infirmity { get; set; }
        public string y_prosecution { get; set; }
        public string y_vehicle_damage { get; set; }
        public int y_driveable { get; set; }
        public string y_damage_to_property { get; set; }
        public string y_injuries_sustained { get; set; }
        public bool y_signed { get; set; }
        // THEM //////////////////
        public string t_name { get; set; }
        public string t_add1 { get; set; }
        public string t_add2 { get; set; }
        public string t_add3 { get; set; }
        public string t_pcode { get; set; }
        public string t_make { get; set; }
        public string t_reg { get; set; }
        public string t_model { get; set; }
        public string t_insurer { get; set; }
        public string t_policy_no { get; set; }
        public string t_telnum { get; set; }
        public int no_of_other_people { get; set; } // Number of other people in the vehicle
                                                    // PERSON ///////////////
        public string p_name { get; set; }
        public string p_add1 { get; set; }
        public string p_add2 { get; set; }
        public string p_add3 { get; set; }
        public string p_pcode { get; set; }
        public string p_wittel { get; set; }
        // VEHICLE ////////////////////
        public string v_reg { get; set; }
        public string v_model { get; set; }

        public string acc_date { get; set; }

        public string acc_time { get; set; }

    }

    public class FAccidents
    {
        public int Id { get; set; } = 0;
        public string date_time { get; set; } = "";
        public bool bSent { get; set; }
        public bool bComplete { get; set; }
        public string full_name { get; set; } = "";
        public string add1 { get; set; } = "";
        public string add2 { get; set; } = "";
        public string add3 { get; set; } = "";
        public string pcode { get; set; } = "";
        public string occupation { get; set; } = "";
        public string filer_full_name { get; set; } = "";
        public string filer_add1 { get; set; } = "";
        public string filer_add2 { get; set; } = "";
        public string filer_add3 { get; set; } = "";
        public string filer_pcode { get; set; } = "";
        public string filer_occupation { get; set; } = "";
        public string sign_date { get; set; } = "";
        public string filer_sign_date { get; set; } = "";
        public string date_happened { get; set; } = "";
        public string time_happened { get; set; } = "";
        public string how_did_accident_happen { get; set; } = "";
        public string materials_used_in_treatment { get; set; } = "";
        public int person_signed { get; set; }
        public int supervisor_signed { get; set; }
        public int num_of_photographs { get; set; }
        public string sig_fname1 { get; set; } = "";
        public string sig_fname2 { get; set; } = "";
        public Guid GUID { get; set; } = Guid.NewGuid();
        public string injuries { get; set; } = "";
        public string where_happ_acc { get; set; } = "";
        public string Type { get; set; } = "";
        public string what_happened { get; set; } = "";
        public string where_abouts { get; set; } = "";
        public string anon_or_name { get; set; } = "";
    }
}
