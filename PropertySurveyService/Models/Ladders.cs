using Microsoft.EntityFrameworkCore;

namespace PropertySurveyService.Models
{
    public class LaddersTable
    {
        public int Id { get; set; }
        public string date_done { get; set; }
        public string branch { get; set; }
        public string ladder_number { get; set; }
        public string registration { get; set; }
        public string fitter_surveyor_name { get; set; }
        public string managers_name { get; set; }
        public string CheckID { get; set; }
        public int in_reasonable_condition { get; set; }
        public int rungs_missing_or_loose { get; set; }
        public int stiles_damaged_or_bent { get; set; }
        public int any_cracks { get; set; }
        public int any_corrosion { get; set; }
        public int rubber_plastic_feet { get; set; }
        public int sharp_or_metal_splinters { get; set; }
        public int rungs_dented { get; set; }
        public int painted_or_decorated { get; set; }
        public int hooks_sit_properly { get; set; }
        public int ladders_been_repaired { get; set; }
        public string comments { get; set; }
        public bool bSent { get; set; }
        public bool bComplete { get; set; }
        public bool bSigned { get; set; }
        public bool bSigned2 { get; set; }
        public string signature_filename { get; set; }
        public int any_damage { get; set; } // ANY DAMAGE
        public string signature_filename_2 { get; set; }  // signature_filename_2
        public string ladder_type { get; set; }  // type of ladder
        public int total_photos { get; set; }
    }
}
