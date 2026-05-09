using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PropertySurveyService.Models
{
    public class ToolsTable
    {
        public int Id { get; set; }

        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();


        // ==========================================================
        // AUDITOR CHECKS (_a)
        // ==========================================================

        [DisplayName("Files (Auditor)")]
        public int files_a { get; set; }

        [DisplayName("Pliers (Auditor)")]
        public int pliers_a { get; set; }

        [DisplayName("Chisels (Auditor)")]
        public int chisels_a { get; set; }

        [DisplayName("Pincers (Auditor)")]
        public int pincers_a { get; set; }

        [DisplayName("Scraper (Auditor)")]
        public int scraper_a { get; set; }

        [DisplayName("Hacksaw (Auditor)")]
        public int hacksaw_a { get; set; }

        [DisplayName("Crowbar (Auditor)")]
        public int crowbar_a { get; set; }

        [DisplayName("Handsaw (Auditor)")]
        public int handsaw_a { get; set; }

        [DisplayName("Mole Grips (Auditor)")]
        public int molegrips_a { get; set; }

        [DisplayName("Side Cutters (Auditor)")]
        public int sidecutters_a { get; set; }

        [DisplayName("Hammer (Auditor)")]
        public int hammer_a { get; set; }

        [DisplayName("Spirit Level (Auditor)")]
        public int spiritlevel_a { get; set; }

        [DisplayName("Screwdrivers (Auditor)")]
        public int screwdrivers_a { get; set; }

        [DisplayName("Bolster Chisel (Auditor)")]
        public int bolsterchisel_a { get; set; }

        [DisplayName("Set Square (Auditor)")]
        public int setsquare_a { get; set; }

        [DisplayName("Stanley Knife (Auditor)")]
        public int stanleyknife_a { get; set; }

        [DisplayName("Club Hammer (Auditor)")]
        public int clubhammer_a { get; set; }

        [DisplayName("Tape Measure (Auditor)")]
        public int tapemeasure_a { get; set; }

        [DisplayName("Sliding Bevel (Auditor)")]
        public int slidingbevel_a { get; set; }

        [DisplayName("Glazing Shovel (Auditor)")]
        public int glazingshovel_a { get; set; }

        [DisplayName("Pointing Trowel (Auditor)")]
        public int pointingtrowel_a { get; set; }

        [DisplayName("Set of Allen Keys (Auditor)")]
        public int setofallenkeys_a { get; set; }

        [DisplayName("Adjustable Spanner (Auditor)")]
        public int adjustablespanner_a { get; set; }

        [DisplayName("Auger Bits (Auditor)")]
        public int augerbits_a { get; set; }

        [DisplayName("Nail Punch (Auditor)")]
        public int nailpunch_a { get; set; }

        [DisplayName("Putty Knife (Auditor)")]
        public int puttyknife_a { get; set; }

        [DisplayName("Socket Set (Auditor)")]
        public int socketset_a { get; set; }

        [DisplayName("Coping Saw (Auditor)")]
        public int copingsaw_a { get; set; }

        // --- Joinery Tools (Auditor) ---

        [DisplayName("Auger Bits - Joinery (Auditor)")]
        public int augerbitsjoin_a { get; set; }

        [DisplayName("Nail Punch - Joinery (Auditor)")]
        public int nailpunchjoin_a { get; set; }

        [DisplayName("Putty Knife - Joinery (Auditor)")]
        public int puttyknifejoin_a { get; set; }

        [DisplayName("Socket Set - Joinery (Auditor)")]
        public int socketsetjoin_a { get; set; }

        [DisplayName("Coping Saw - Joinery (Auditor)")]
        public int copingsawjoin_a { get; set; }

        [DisplayName("Rivet Gun - Joinery (Auditor)")]
        public int rivetgunjoin_a { get; set; }


        // ==========================================================
        // FITTER CHECKS (_f)
        // ==========================================================

        [DisplayName("Files (Fitter)")]
        public int files_f { get; set; }

        [DisplayName("Pliers (Fitter)")]
        public int pliers_f { get; set; }

        [DisplayName("Chisels (Fitter)")]
        public int chisels_f { get; set; }

        [DisplayName("Pincers (Fitter)")]
        public int pincers_f { get; set; }

        [DisplayName("Scraper (Fitter)")]
        public int scraper_f { get; set; }

        [DisplayName("Hacksaw (Fitter)")]
        public int hacksaw_f { get; set; }

        [DisplayName("Crowbar (Fitter)")]
        public int crowbar_f { get; set; }

        [DisplayName("Handsaw (Fitter)")]
        public int handsaw_f { get; set; }

        [DisplayName("Mole Grips (Fitter)")]
        public int molegrips_f { get; set; }

        [DisplayName("Side Cutters (Fitter)")]
        public int sidecutters_f { get; set; }

        [DisplayName("Hammer (Fitter)")]
        public int hammer_f { get; set; }

        [DisplayName("Spirit Level (Fitter)")]
        public int spiritlevel_f { get; set; }

        [DisplayName("Screwdrivers (Fitter)")]
        public int screwdrivers_f { get; set; }

        [DisplayName("Bolster Chisel (Fitter)")]
        public int bolsterchisel_f { get; set; }

        [DisplayName("Set Square (Fitter)")]
        public int setsquare_f { get; set; }

        [DisplayName("Stanley Knife (Fitter)")]
        public int stanleyknife_f { get; set; }

        [DisplayName("Club Hammer (Fitter)")]
        public int clubhammer_f { get; set; }

        [DisplayName("Tape Measure (Fitter)")]
        public int tapemeasure_f { get; set; }

        [DisplayName("Sliding Bevel (Fitter)")]
        public int slidingbevel_f { get; set; }

        [DisplayName("Glazing Shovel (Fitter)")]
        public int glazingshovel_f { get; set; }

        [DisplayName("Pointing Trowel (Fitter)")]
        public int pointingtrowel_f { get; set; }

        [DisplayName("Set of Allen Keys (Fitter)")]
        public int setofallenkeys_f { get; set; }

        [DisplayName("Adjustable Spanner (Fitter)")]
        public int adjustablespanner_f { get; set; }

        [DisplayName("Auger Bits (Fitter)")]
        public int augerbits_f { get; set; }

        [DisplayName("Nail Punch (Fitter)")]
        public int nailpunch_f { get; set; }

        [DisplayName("Putty Knife (Fitter)")]
        public int puttyknife_f { get; set; }

        [DisplayName("Socket Set (Fitter)")]
        public int socketset_f { get; set; }

        [DisplayName("Coping Saw (Fitter)")]
        public int copingsaw_f { get; set; }

        // --- Joinery Tools (Fitter) ---

        [DisplayName("Auger Bits - Joinery (Fitter)")]
        public int augerbitsjoin_f { get; set; }

        [DisplayName("Nail Punch - Joinery (Fitter)")]
        public int nailpunchjoin_f { get; set; }

        [DisplayName("Putty Knife - Joinery (Fitter)")]
        public int puttyknifejoin_f { get; set; }

        [DisplayName("Socket Set - Joinery (Fitter)")]
        public int socketsetjoin_f { get; set; }

        [DisplayName("Coping Saw - Joinery (Fitter)")]
        public int copingsawjoin_f { get; set; }

        [DisplayName("Rivet Gun - Joinery (Fitter)")]
        public int rivetgunjoin_f { get; set; }


        // ==========================================================
        // METADATA & WORKFLOW SIGN-OFF
        // ==========================================================

        [DisplayName("Date Completed")]
        public string date_done { get; set; } = "";

        [DisplayName("Is Completed")]
        public bool bComplete { get; set; }

        [DisplayName("Sent to Server")]
        public bool bSent { get; set; }

        [DisplayName("Fitter Signed")]
        public bool bSigned { get; set; }

        [DisplayName("Auditor Signed")]
        public bool bSigned2 { get; set; }

        [DisplayName("Fitter Signature Filename")]
        public string signature_filename { get; set; } = "";

        [DisplayName("Auditor Signature Filename")]
        public string signature_filename2 { get; set; } = "";

        [DisplayName("Fitter Printed Name")]
        public string signature_printed { get; set; } = "";

        [DisplayName("Auditor Printed Name")]
        public string signature_printed2 { get; set; } = "";

        [DisplayName("Vehicle Registration")]
        public string registration { get; set; } = "";

        [DisplayName("Branch")]
        public string branch { get; set; } = "";

        [DisplayName("Check ID")]
        public string CheckID { get; set; } = "";

        [DisplayName("Photo Filename")]
        public string photo_filename { get; set; } = "";
    }
}
