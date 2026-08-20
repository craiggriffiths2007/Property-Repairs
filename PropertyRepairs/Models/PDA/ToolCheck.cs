using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyRepairs.Models
{
    public class ToolCheck
    {
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        [DisplayName("Unique Record ID (GUID)")]
        public Guid Guid { get; set; } = Guid.NewGuid();


        // ==========================================================
        // AUDITOR CHECKS (_a)
        // ==========================================================

        [DisplayName("Files")]
        public bool files_a { get; set; }

        [DisplayName("Pliers")]
        public bool pliers_a { get; set; }

        [DisplayName("Chisels")]
        public bool chisels_a { get; set; }

        [DisplayName("Pincers")]
        public bool pincers_a { get; set; }

        [DisplayName("Scraper")]
        public bool scraper_a { get; set; }

        [DisplayName("Hacksaw")]
        public bool hacksaw_a { get; set; }

        [DisplayName("Crowbar")]
        public bool crowbar_a { get; set; }

        [DisplayName("Handsaw")]
        public bool handsaw_a { get; set; }

        [DisplayName("Mole Grips")]
        public bool molegrips_a { get; set; }

        [DisplayName("Side Cutters")]
        public bool sidecutters_a { get; set; }

        [DisplayName("Hammer")]
        public bool hammer_a { get; set; }

        [DisplayName("Spirit Level")]
        public bool spiritlevel_a { get; set; }

        [DisplayName("Screwdrivers")]
        public bool screwdrivers_a { get; set; }

        [DisplayName("Bolster Chisel")]
        public bool bolsterchisel_a { get; set; }

        [DisplayName("Set Square")]
        public bool setsquare_a { get; set; }

        [DisplayName("Stanley Knife")]
        public bool stanleyknife_a { get; set; }

        [DisplayName("Club Hammer")]
        public bool clubhammer_a { get; set; }

        [DisplayName("Tape Measure")]
        public bool tapemeasure_a { get; set; }

        [DisplayName("Sliding Bevel")]
        public bool slidingbevel_a { get; set; }

        [DisplayName("Glazing Shovel")]
        public bool glazingshovel_a { get; set; }

        [DisplayName("Pointing Trowel")]
        public bool pointingtrowel_a { get; set; }

        [DisplayName("Set of Allen Keys")]
        public bool setofallenkeys_a { get; set; }

        [DisplayName("Adjustable Spanner")]
        public bool adjustablespanner_a { get; set; }

        [DisplayName("Auger Bits")]
        public bool augerbits_a { get; set; }

        [DisplayName("Nail Punch")]
        public bool nailpunch_a { get; set; }

        [DisplayName("Putty Knife")]
        public bool puttyknife_a { get; set; }

        [DisplayName("Socket Set")]
        public bool socketset_a { get; set; }

        [DisplayName("Coping Saw")]
        public bool copingsaw_a { get; set; }

        // --- Joinery Tools ---

        [DisplayName("Auger Bits - Joinery")]
        public bool augerbitsjoin_a { get; set; }

        [DisplayName("Nail Punch - Joinery")]
        public bool nailpunchjoin_a { get; set; }

        [DisplayName("Putty Knife - Joinery")]
        public bool puttyknifejoin_a { get; set; }

        [DisplayName("Socket Set - Joinery")]
        public bool socketsetjoin_a { get; set; }

        [DisplayName("Coping Saw - Joinery")]
        public bool copingsawjoin_a { get; set; }

        [DisplayName("Rivet Gun - Joinery")]
        public bool rivetgunjoin_a { get; set; }



        // ==========================================================
        // FITTER CHECKS (_f)
        // ==========================================================

        [DisplayName("Files")]
        public bool files_f { get; set; }

        [DisplayName("Pliers")]
        public bool pliers_f { get; set; }

        [DisplayName("Chisels")]
        public bool chisels_f { get; set; }

        [DisplayName("Pincers")]
        public bool pincers_f { get; set; }

        [DisplayName("Scraper")]
        public bool scraper_f { get; set; }

        [DisplayName("Hacksaw")]
        public bool hacksaw_f { get; set; }

        [DisplayName("Crowbar")]
        public bool crowbar_f { get; set; }

        [DisplayName("Handsaw")]
        public bool handsaw_f { get; set; }

        [DisplayName("Mole Grips")]
        public bool molegrips_f { get; set; }

        [DisplayName("Side Cutters")]
        public bool sidecutters_f { get; set; }

        [DisplayName("Hammer")]
        public bool hammer_f { get; set; }

        [DisplayName("Spirit Level")]
        public bool spiritlevel_f { get; set; }

        [DisplayName("Screwdrivers")]
        public bool screwdrivers_f { get; set; }

        [DisplayName("Bolster Chisel")]
        public bool bolsterchisel_f { get; set; }

        [DisplayName("Set Square")]
        public bool setsquare_f { get; set; }

        [DisplayName("Stanley Knife")]
        public bool stanleyknife_f { get; set; }

        [DisplayName("Club Hammer")]
        public bool clubhammer_f { get; set; }

        [DisplayName("Tape Measure")]
        public bool tapemeasure_f { get; set; }

        [DisplayName("Sliding Bevel")]
        public bool slidingbevel_f { get; set; }

        [DisplayName("Glazing Shovel")]
        public bool glazingshovel_f { get; set; }

        [DisplayName("Pointing Trowel")]
        public bool pointingtrowel_f { get; set; }

        [DisplayName("Set of Allen Keys")]
        public bool setofallenkeys_f { get; set; }

        [DisplayName("Adjustable Spanner")]
        public bool adjustablespanner_f { get; set; }

        [DisplayName("Auger Bits")]
        public bool augerbits_f { get; set; }

        [DisplayName("Nail Punch")]
        public bool nailpunch_f { get; set; }

        [DisplayName("Putty Knife")]
        public bool puttyknife_f { get; set; }

        [DisplayName("Socket Set")]
        public bool socketset_f { get; set; }

        [DisplayName("Coping Saw")]
        public bool copingsaw_f { get; set; }

        // --- Joinery Tools ---

        [DisplayName("Auger Bits - Joinery")]
        public bool augerbitsjoin_f { get; set; }

        [DisplayName("Nail Punch - Joinery")]
        public bool nailpunchjoin_f { get; set; }

        [DisplayName("Putty Knife - Joinery")]
        public bool puttyknifejoin_f { get; set; }

        [DisplayName("Socket Set - Joinery")]
        public bool socketsetjoin_f { get; set; }

        [DisplayName("Coping Saw - Joinery")]
        public bool copingsawjoin_f { get; set; }

        [DisplayName("Rivet Gun - Joinery")]
        public bool rivetgunjoin_f { get; set; }


        // ==========================================================
        // METADATA & WORKFLOW SIGN-OFF
        // ==========================================================
        [Display(Order = -1)]
        [DisplayName("Date Completed")]
        public string date_done { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Is Completed")]
        public bool bComplete { get; set; }
        [Browsable(false)]
        [DisplayName("Sent to Server")]
        public bool bSent { get; set; }
        [Browsable(false)]
        [DisplayName("Fitter Signed")]
        public bool bSigned { get; set; }
        [Browsable(false)]
        [DisplayName("Auditor Signed")]
        public bool bSigned2 { get; set; }
        [Browsable(false)]
        [DisplayName("Fitter Signature Filename")]
        public string signature_filename { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Auditor Signature Filename")]
        public string signature_filename2 { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Fitter Printed Name")]
        public string signature_printed { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Auditor Printed Name")]
        public string signature_printed2 { get; set; } = "";
        [Display(Order = 1)]
        [DisplayName("Vehicle Registration")]
        public string registration { get; set; } = "";

        [Display(Order = 0)]
        [DisplayName("Branch")]
        public string branch { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Check ID")]
        public string CheckID { get; set; } = "";
        [Browsable(false)]
        [DisplayName("Photo Filename")]
        public string photo_filename { get; set; } = "";
    }
}
