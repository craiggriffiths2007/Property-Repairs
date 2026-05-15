using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertySurveyService.Models
{
    public class OKRecordDTO
    {
        public string? comments { get; set; }
        public int DBId { get; set; }
    }
    public class Header
    {
        #region Core Database & System Fields

        [DisplayName("Record ID")]
        public int Id { get; set; }

        public Guid Guid { get; set; } = Guid.NewGuid();

        [DisplayName("Staff Member Name")]
        public string udi_staff { get; set; } = "";

        [DisplayName("Surveyor Name")]
        public string AgentCode { get; set; } = "";

        [DisplayName("Complete")]
        public bool bComplete { get; set; }

        [DisplayName("Sent")]
        public bool bSent { get; set; }

        [DisplayName("Index")]
        public int ind { get; set; }

        [DisplayName("Group")]
        public string Group { get; set; } = "";



        [DisplayName("Processed")]
        public string bProcessed { get; set; } = "";

        [DisplayName("Record Type")]
        public enum_job_type JobType { get; set; }

        [DisplayName("Type A")]
        public string typeA { get; set; } = "";

        [DisplayName("Type B")]
        public string typeB { get; set; } = "";

        [DisplayName("Job Type")]
        public string type { get; set; } = "";

        [DisplayName("Sub Type")]
        public string sub_type { get; set; } = "";

        [DisplayName("Traffic Light")]
        public int udi_tlight { get; set; }

        [DisplayName("Info Seen")]
        public bool bInfoSeen { get; set; }

        #endregion

        #region Client & Contract Information

        [DisplayName("Contract Number")]
        public string udi_cont { get; set; } = "";

        [DisplayName("Policy Number")]
        public string policy_number { get; set; } = "";

        [DisplayName("Claim Reference")]
        public string claim_ref { get; set; } = "";

        [DisplayName("Insurance Company Name")]
        public string sn_name { get; set; } = "";

        [DisplayName("Loss Adjuster Name")]
        public string uc_laname { get; set; } = "";

        [DisplayName("Client Name")]
        public string uc_name { get; set; } = "";

        [DisplayName("Client Address 1")]
        public string uc_add1 { get; set; } = "";

        [DisplayName("Client Address 2")]
        public string uc_add2 { get; set; } = "";

        [DisplayName("Client Address 3")]
        public string uc_add3 { get; set; } = "";

        [DisplayName("Client Address 4")]
        public string uc_add4 { get; set; } = "";

        [DisplayName("Client Postcode")]
        public string uc_postcode { get; set; } = "";

        [DisplayName("Client Phone Number")]
        public string uc_h_phone { get; set; } = "";

        [DisplayName("Client Phone Number 2")]
        public string uc_h_phone2 { get; set; } = "";

        [DisplayName("Client Phone Number 3")]
        public string uc_h_phone3 { get; set; } = "";

        [DisplayName("Additional Phone 1")]
        public string add_phone_1 { get; set; } = "";

        [DisplayName("Additional Phone 2")]
        public string add_phone_2 { get; set; } = "";

        [DisplayName("Additional Address Info")]
        public string add_long { get; set; } = "";

        [DisplayName("Birthday 1")]
        public string si_bday1 { get; set; } = "";

        [DisplayName("Customer Number")]
        public string si_cnum { get; set; } = "";

        [DisplayName("Invoice Number")]
        public string si_inum { get; set; } = "";

        #endregion

        #region Scheduling & Diary Details

        [DisplayName("Diary Date of Job")]
        public string udi_date { get; set; } = "";

        [DisplayName("Start Time")]
        public string udi_start { get; set; } = "";

        [DisplayName("Finish Time")]
        public string udi_fin { get; set; } = "";

        [DisplayName("Old Date")]
        public string old_date { get; set; } = "";

        [DisplayName("Old Start Time")]
        public string old_start { get; set; } = "";

        [DisplayName("Old Finish Time")]
        public string old_finish { get; set; } = "";

        [DisplayName("Incident Date")]
        public string uc_inceden { get; set; } = "";

        [DisplayName("Booked on Day 1")]
        public int booked { get; set; }

        [DisplayName("Reason Not Booked In")]
        public string reason_not_booked_in { get; set; } = "";

        #endregion

        #region Job, Instructions & Progress

        [DisplayName("Go Ahead for Repair")]
        public bool uc_goahead { get; set; }

        [DisplayName("Go Ahead String")]
        public string goaheadstr { get; set; } = "";

        [DisplayName("Instructions")]
        public string udi_inst { get; set; } = "";

        [DisplayName("Cover Instructions")]
        public string cover_instructions { get; set; } = "";

        [DisplayName("Old Cover Instructions")]
        public string old_cover_instructions { get; set; } = "";

        [DisplayName("Job Instructions")]
        public string udi_jobtext { get; set; } = "";

        [DisplayName("Number of Items")]
        public int si_numitem { get; set; }

        [DisplayName("Job Grade")]
        public string job_grade { get; set; } = "";

        [DisplayName("Job Size")]
        public string njs { get; set; } = "";


        [DisplayName("Brief Description")]
        public string uc_desc { get; set; } = "";

        [DisplayName("Report Text")]
        public string rep_text { get; set; } = "";

        [DisplayName("Summary Text")]
        public string summ_text { get; set; } = "";

        [DisplayName("Code Text")]
        public string code_text { get; set; } = "";

        [DisplayName("Additional Comments")]
        public string add_comm { get; set; } = "";

        [DisplayName("Complaint Type Job")]
        public bool b_mrk { get; set; }

        [DisplayName("MSF Job")]
        public bool bMSFJob { get; set; }

        #endregion

        #region Site Logistics, Risks & Health & Safety

        [DisplayName("Alarm Contacts")]
        public int alarm_cont { get; set; }

        [DisplayName("Ladders Required")]
        public int ladder_req { get; set; }

        [DisplayName("Number of Ladders")]
        public int no_ladders { get; set; }

        [DisplayName("Height Restriction")]
        public int height_res { get; set; }

        [DisplayName("Sand and Cement Required")]
        public int sand_cemen { get; set; }

        [DisplayName("Plaster Required")]
        public int plaster { get; set; }

        [DisplayName("Door Bell")]
        public int doorbell { get; set; }

        [DisplayName("Generator Required")]
        public int genreq { get; set; }

        [DisplayName("Architraves Required")]
        public int architreq { get; set; }

        [DisplayName("Acro Prop Required")]
        public int acroreq { get; set; }

        [DisplayName("Acro Prop Boy")]
        public int acrosboy { get; set; }

        [DisplayName("Access Requirements Comments")]
        public string acc_text { get; set; } = "";

        [DisplayName("Obstructive Wires")]
        public int obs_wires { get; set; }

        [DisplayName("Obstructive Wires Comments")]
        public string obs_wires_text { get; set; } = "";

        [DisplayName("Loose Brick Above Item")]
        public int loose_brick { get; set; }

        [DisplayName("Loose Brick Comments")]
        public string loose_brick_text { get; set; } = "";

        [DisplayName("Easy Parking")]
        public int easy_park { get; set; }

        [DisplayName("Access to Rear of Property")]
        public int access_rear { get; set; }

        [DisplayName("Parking at Rear")]
        public int parking_at_rear { get; set; }

        [DisplayName("Work Inside")]
        public int bWorkInside { get; set; }

        [DisplayName("Installation Height")]
        public string inst_height { get; set; } = "";

        [DisplayName("Both Hands (Tower Scaffold)")]
        public int bBothHands { get; set; }

        [DisplayName("Ground Surface")]
        public string ground_surface { get; set; } = "";

        [DisplayName("Type of Equipment")]
        public string type_of_equipment { get; set; } = "";

        [DisplayName("Risks and Dangers")]
        public string risks_and_dangers { get; set; } = "";

        [DisplayName("Work at Height")]
        public int work_at_height { get; set; }

        [DisplayName("Work on Public Footpath")]
        public int work_on_public_footpath { get; set; }

        [DisplayName("Added to Other Risks")]
        public bool added_to_otherrisks { get; set; }

        [DisplayName("Asbestos Visible")]
        public int asbestos_visible { get; set; }

        [DisplayName("Asbestos Visible Explanation")]
        public string asvizex { get; set; } = "";

        [DisplayName("Lintel Present")]
        public int lintel_present { get; set; }

        [DisplayName("Lintel Present Text")]
        public string lintel_present_text { get; set; } = "";

        [DisplayName("Inevitable Damage")]
        public string inevitable_damage { get; set; } = "";

        [DisplayName("Requiring Load Bearing Jacks")]
        public bool requiring_load_bearing_jacks { get; set; }

        #endregion

        #region Fitter Allocation & On-Site Performance

        [DisplayName("Number of Fitters")]
        public int no_of_fitters { get; set; }

        [DisplayName("Fitter Name 1")]
        public string fname1 { get; set; } = "";

        [DisplayName("Fitter Name 2")]
        public string fname2 { get; set; } = "";

        [DisplayName("Fitter Name 3")]
        public string fname3 { get; set; } = "";

        [DisplayName("Fitter Name 4")]
        public string fname4 { get; set; } = "";

        [DisplayName("Fitter Name 5")]
        public string fname5 { get; set; } = "";

        [DisplayName("Fitter Name 6")]
        public string fname6 { get; set; } = "";

        [DisplayName("Fitter Name 7")]
        public string fname7 { get; set; } = "";

        [DisplayName("Fitter Name 8")]
        public string fname8 { get; set; } = "";

        [DisplayName("Fitter Name 1 (Alt)")]
        public string ffitter_name1 { get; set; } = "";

        [DisplayName("Fitter Name 2 (Alt)")]
        public string ffitter_name2 { get; set; } = "";

        [DisplayName("Fit Diary Date")]
        public string fit_diary { get; set; } = "";

        [DisplayName("Fitters Instructions")]
        public string fitters_instructions { get; set; } = "";

        [DisplayName("Fit Start Time")]
        public string fit_start { get; set; } = "";

        [DisplayName("Fit Finish Time")]
        public string fit_fin { get; set; } = "";

        [DisplayName("Fitter Work")]
        public string fitter_work { get; set; } = "";

        [DisplayName("Fitter Comments")]
        public string fitter_comments { get; set; } = "";

        [DisplayName("Time Arrived")]
        public string ftimearr { get; set; } = "";

        [DisplayName("Time Left")]
        public string ftimeleft { get; set; } = "";

        [DisplayName("Fitter Time Arrived")]
        public string ftime_arrived { get; set; } = "";

        [DisplayName("Fitter Time Left")]
        public string ftime_left { get; set; } = "";

        [DisplayName("Work Carried Out")]
        public string wkcartxt { get; set; } = "";

        [DisplayName("Job Comments")]
        public string commtxt { get; set; } = "";

        [DisplayName("Super Fitter Done")]
        public bool si_done { get; set; }

        [DisplayName("Fitting Complete")]
        public int bfitter_complete { get; set; }

        [DisplayName("Fitter Info Done")]
        public int fitter_info_done { get; set; }

        [DisplayName("Fitter Signature Date")]
        public string f_sign_date { get; set; } = "";

        [DisplayName("Surveyor Time Arrived")]
        public string stimea { get; set; } = "";

        [DisplayName("Fitter/Surveyor")]
        public string f1_or_s2 { get; set; } = "";

        [DisplayName("Directive Complete")]
        public int directive_complete { get; set; }

        #endregion

        #region Mandate & Job Completion

        [DisplayName("Job Finished")]
        public bool fjobfin { get; set; }

        [DisplayName("Reason Unfinished")]
        public string freuntxt { get; set; } = "";

        [DisplayName("Unfinished Code")]
        public string funfinished_code { get; set; } = "";

        [DisplayName("Reason Unfinished (Other)")]
        public string freason_unfinished { get; set; } = "";

        [DisplayName("Barrier Size")]
        public string fbunfinother { get; set; } = "";

        [DisplayName("Mandate Signed")]
        public bool fmand { get; set; }

        [DisplayName("Why Mandate Not Signed")]
        public string fmandoth { get; set; } = "";

        [DisplayName("Fitter Mandate Signed")]
        public int fbmandate_signed { get; set; }

        [DisplayName("Reason Mandate Not Signed")]
        public string freason_mandate_not_signed { get; set; } = "";

        [DisplayName("Fitters Mandate Claim Reference")]
        public string fmclrf { get; set; } = "";

        [DisplayName("Fitters Mandate Date")]
        public string fmdate { get; set; } = "";

        [DisplayName("Fitters Mandate Code")]
        public string funfincode { get; set; } = "";

        [DisplayName("Fitters Mandate Other")]
        public string funfinoth { get; set; } = "";

        [DisplayName("Completion Signed")]
        public bool bcompletion_signed { get; set; }

        #endregion

        #region Inventory, Locks & Stock Management

        [DisplayName("Parts Used")]
        public string parts_used { get; set; } = "";

        [DisplayName("Parts Used (Text)")]
        public string parttxt { get; set; } = "";

        [DisplayName("Parts Required")]
        public string fpartreq { get; set; } = "";

        [DisplayName("Fitter Parts Required")]
        public string fparts_required { get; set; } = "";

        [DisplayName("Fitter Stock Usage Complete")]
        public bool fbstockusagecomplete { get; set; }

        [DisplayName("Securing")]
        public bool bSecuring { get; set; }

        [DisplayName("Insurance Board")]
        public int ins_board { get; set; }

        [DisplayName("Insurance Lock")]
        public int ins_lock { get; set; }

        [DisplayName("Insurance Temp")]
        public int ins_temp { get; set; }

        [DisplayName("Insurance Perm")]
        public int ins_perm { get; set; }

        [DisplayName("Number of Locks")]
        public int int_num_of_locks { get; set; }

        [DisplayName("Type of Lock")]
        public string int_type_of_lock { get; set; } = "";

        #endregion

        #region Financials & Payments

        [DisplayName("Account Code")]
        public string si_mpay { get; set; } = "";

        [DisplayName("Method of Payment")]
        public string mop { get; set; } = "";

        [DisplayName("Payment Method")]
        public string paych { get; set; } = "";

        [DisplayName("Card/Cheque Number")]
        public string card_cheq { get; set; } = "";

        [DisplayName("Expiry Date")]
        public string expiry { get; set; } = "";

        [DisplayName("Issue Number")]
        public int issue_no { get; set; }

        [DisplayName("Excess Amount")]
        public double uc_excess { get; set; }

        [DisplayName("Excess Collected")]
        public int bExcessCollected { get; set; }

        [DisplayName("Reason Excess Not Collected")]
        public string reason_excess_not_collected { get; set; } = "";

        [DisplayName("Excess Paid")]
        public bool fexcess { get; set; }

        [DisplayName("Why Excess Paid")]
        public string fexcessoth { get; set; } = "";

        [DisplayName("Fitter Excess Paid")]
        public int fbexcess_paid { get; set; }

        [DisplayName("Reason Excess Not Paid")]
        public string freason_excess_not_paid { get; set; } = "";

        [DisplayName("Additional Paid")]
        public bool faddpaid { get; set; }

        [DisplayName("How Much Additional Paid")]
        public double faddmuch { get; set; }

        [DisplayName("Fitter Additional Paid")]
        public int fbadditional_paid { get; set; }

        [DisplayName("How Much Additional Paid (Fitter)")]
        public string fhow_mutch_additional_paid { get; set; } = "";

        #endregion

        #region Surveys & Measurements

        [DisplayName("Survey")]
        public bool bSurvey { get; set; }

        [DisplayName("Survey Complete")]
        public int survey_complete { get; set; }

        [DisplayName("Reason Not Complete")]
        public string reason_not_complete { get; set; } = "";

        [DisplayName("Survey on Fit")]
        public int survey_on_fit { get; set; }

        [DisplayName("Securing Surveyor Required")]
        public int securing_surveyor_required { get; set; }

        [DisplayName("Survey Required on Securing")]
        public bool bSurveyRequiredOnSecuring { get; set; }

        [DisplayName("Items Matching Up")]
        public int imchup { get; set; }

        [DisplayName("Own Quote")]
        public int ownquote { get; set; }

        #endregion

        #region Remedial Action Details

        [DisplayName("Remedial Number")]
        public string udi_estrem { get; set; } = "";

        [DisplayName("Remedial Number (Alt)")]
        public string remedial_number { get; set; } = "";

        [DisplayName("Remedial Fault")]
        public string r_fault { get; set; } = "";

        [DisplayName("Remedial Excess")]
        public int r_excess { get; set; }

        [DisplayName("Reason No Excess")]
        public string rexcedit { get; set; } = "";

        [DisplayName("Remedial Completed")]
        public int r_comp { get; set; }

        [DisplayName("Remedial Complete (Alt)")]
        public string r_bcomp { get; set; } = "";

        [DisplayName("Remedial Hours to Complete")]
        public string rno_hours { get; set; } = "";

        [DisplayName("Remedial Work Carried Out")]
        public string r_work_txt { get; set; } = "";

        [DisplayName("Remedial Signed")]
        public bool r_bsigned { get; set; }

        [DisplayName("Remedial Signature Date")]
        public string r_sign_date { get; set; } = "";

        [DisplayName("Remedial Additional Image")]
        public bool readditimage { get; set; }

        [DisplayName("Remedial Additional Text")]
        public string readdtxt { get; set; } = "";

        [DisplayName("Remedial Signature Image")]
        public bool r_sigimage { get; set; }

        [DisplayName("Fitters Additional Requirements Text")]
        public string f_add_txt { get; set; } = "";

        #endregion

        #region Quality Assurance & Spot Checks


        #endregion

        #region Security Surveys

        [DisplayName("Security Survey")]
        public int ss_bIsSecuritySurvey { get; set; }

        [DisplayName("Security Survey Complete")]
        public int ss_bIsComplete { get; set; }

        [DisplayName("No Windows (Security Survey)")]
        public string ss_nowindows { get; set; } = "";

        [DisplayName("No Doors (Security Survey)")]
        public string ss_nodoors { get; set; } = "";

        [DisplayName("General Condition (Security Survey)")]
        public string ss_gencondition { get; set; } = "";

        [DisplayName("General Condition Other (Security Survey)")]
        public string ss_gencondition_other { get; set; } = "";

        [DisplayName("Material Windows (Security Survey)")]
        public string ss_matwindows { get; set; } = "";

        [DisplayName("Material Windows Other (Security Survey)")]
        public string ss_matwindows_other { get; set; } = "";

        [DisplayName("Material Doors (Security Survey)")]
        public string ss_matdoors { get; set; } = "";

        [DisplayName("Material Doors Other (Security Survey)")]
        public string ss_matdoors_other { get; set; } = "";

        [DisplayName("Lock Windows (Security Survey)")]
        public string ss_lockwindows { get; set; } = "";

        [DisplayName("Lock Windows Other (Security Survey)")]
        public string ss_lockwindows_other { get; set; } = "";

        [DisplayName("Lock Doors (Security Survey)")]
        public string ss_lockdoors { get; set; } = "";

        [DisplayName("Lock Doors Other (Security Survey)")]
        public string ss_lockdoors_other { get; set; } = "";

        [DisplayName("Add Window Security (Security Survey)")]
        public int ss_add_window_security { get; set; }

        [DisplayName("Location Windows Other (Security Survey)")]
        public string ss_location_windows_other { get; set; } = "";

        [DisplayName("Sec Windows Other (Security Survey)")]
        public string ss_secwindows_other { get; set; } = "";

        [DisplayName("Add Door Security (Security Survey)")]
        public int ss_add_door_security { get; set; }

        [DisplayName("Location Doors Other (Security Survey)")]
        public string ss_location_doors_other { get; set; } = "";

        [DisplayName("Sec Doors Other (Security Survey)")]
        public string ss_secdoors_other { get; set; } = "";

        [DisplayName("Time Required (Security Survey)")]
        public string ss_time_required { get; set; } = "";

        [DisplayName("Number of Security Survey Photos")]
        public int ss_no_of_photos { get; set; }

        #endregion

        #region Photos, Videos & Digital Media

        [DisplayName("Photos Taken")]
        public int photo { get; set; }

        [DisplayName("Number of Photos")]
        public int no_of_photos { get; set; }

        [DisplayName("Photo Front of House")]
        public bool photo_front_of_house { get; set; }

        [DisplayName("Front House Photos")]
        public int front_house_photos { get; set; }

        [DisplayName("Additional Image")]
        public bool faddimage { get; set; }

        [DisplayName("Additional Image Complete")]
        public bool bad_image_complete { get; set; }

        [DisplayName("Mandate Image")]
        public bool fmanimage { get; set; }

        [DisplayName("Signature Image")]
        public bool fsigimage { get; set; }

        [DisplayName("Fitter Videos")]
        public int fitter_videos { get; set; }

        [DisplayName("Number of Fitter Videos")]
        public int fit_no_of_videos { get; set; }

        [DisplayName("All Pictures")]
        public bool bAllPictures { get; set; }

        #endregion

        #region Tracking & GPS Data

        [DisplayName("GPS Distance")]
        public long distance { get; set; }

        [DisplayName("Journey Duration (Seconds)")]
        public long duration { get; set; }

        [DisplayName("Closest")]
        public string bClosest { get; set; } = "";

        #endregion

        #region Framework Integrations, Insurers & External APIs

        [DisplayName("IDAM Password Entered")]
        public bool idampassword_entered { get; set; }

        [DisplayName("Doc L Compliant")]
        public int doc_l_compliant { get; set; }

        [DisplayName("Doc L Compliant Reason")]
        public string doc_l_compliant_reason { get; set; } = "";

        [DisplayName("Shop Front Work")]
        public int shop_front_work { get; set; }

        [DisplayName("Is Halifax")]
        public bool is_halifax { get; set; }

        [DisplayName("Message to Insurer")]
        public string messagetoinsurer { get; set; } = "";

        [DisplayName("Is Message to Insurer")]
        public int is_messagetoinsurer { get; set; }

        [DisplayName("COD Code")]
        public string COD_Code { get; set; } = "";

        [DisplayName("COD String")]
        public string COD_String { get; set; } = "";

        [DisplayName("RCOD Changed")]
        public string rcodchanged { get; set; } = "";

        [DisplayName("BCOD Changed")]
        public bool bcodchanged { get; set; }

        [DisplayName("Reference Message")]
        public string refmessage { get; set; } = "";

        [DisplayName("Subcontract")]
        public int b_subcontract { get; set; }

        [DisplayName("Subcontract Text")]
        public string subcontracttext { get; set; } = "";

        [DisplayName("True Communication")]
        public bool truecomm { get; set; }

        [DisplayName("True Communication Confirmed")]
        public bool truecommconf { get; set; }

        [DisplayName("Signed (Motor Sheet)")]
        public int i_signed { get; set; }

        [DisplayName("Signed Customer (Motor Sheet)")]
        public int i_signed_cust { get; set; }

        #endregion

        #region Materials & Framework Performance Totals

        [DisplayName("Total UPVC")]
        public int total_upvc { get; set; }

        [DisplayName("Total Panels")]
        public int total_panels { get; set; }

        [DisplayName("Total Glass")]
        public int total_glass { get; set; }

        [DisplayName("Total Aluminium")]
        public int total_alum { get; set; }

        [DisplayName("Total Garage")]
        public int total_garage { get; set; }

        [DisplayName("Total Timber")]
        public int total_timber { get; set; }

        [DisplayName("Total Cons")]
        public int total_cons { get; set; }

        [DisplayName("Total Lock")]
        public int total_lock { get; set; }

        [DisplayName("Total Composite")]
        public int total_comp { get; set; }

        [DisplayName("Total Green")]
        public int total_green { get; set; }

        [DisplayName("Total Bifold")]
        public int total_bifold { get; set; }

        [DisplayName("Total Frames")]
        public int total_frames { get; set; }

        [DisplayName("Incomplete Frames")]
        public int incomplete_frames { get; set; }

        [DisplayName("Incomplete UPVC")]
        public int incomplete_upvc { get; set; }

        [DisplayName("Incomplete Panels")]
        public int incomplete_panels { get; set; }

        [DisplayName("Incomplete Glass")]
        public int incomplete_glass { get; set; }

        [DisplayName("Incomplete Aluminium")]
        public int incomplete_alum { get; set; }

        [DisplayName("Incomplete Garage")]
        public int incomplete_garage { get; set; }

        [DisplayName("Incomplete Timber")]
        public int incomplete_timber { get; set; }

        [DisplayName("Incomplete Cons")]
        public int incomplete_cons { get; set; }

        [DisplayName("Incomplete Lock")]
        public int incomplete_lock { get; set; }

        [DisplayName("Incomplete Composite")]
        public int incomplete_comp { get; set; }

        [DisplayName("Incomplete Green")]
        public int incomplete_green { get; set; }

        [DisplayName("Incomplete Bifold")]
        public int incomplete_bifold { get; set; }

        #endregion

        #region Workflow Checkpoints & UI Flags

        [DisplayName("Damage Ticked")]
        public bool bDamTicked { get; set; }

        [DisplayName("SS Ticked")]
        public bool bSSTicked { get; set; }

        [DisplayName("SS Required")]
        public int SSRequired { get; set; }

        [DisplayName("SR Finished")]
        public bool bSRFin { get; set; }

        [DisplayName("MOP Finished")]
        public bool bMOPFin { get; set; }

        [DisplayName("Rep Finished")]
        public bool bRepFin { get; set; }

        [DisplayName("Sum Finished")]
        public bool bSumFin { get; set; }

        [DisplayName("Haz Finished")]
        public bool bHazFin { get; set; }

        [DisplayName("Sub Finished")]
        public bool bSubFin { get; set; }

        [DisplayName("Time to Complete")]
        public string time_to_complete { get; set; } = "";

        [DisplayName("Current Item Number")]
        public int current_item_number { get; set; }

        [DisplayName("Items Above Roof")]
        public int items_above_roof { get; set; }

        [DisplayName("Current Summary Number")]
        public int current_summary_number { get; set; }

        #endregion

        #region Spares & Custom Fields

        [DisplayName("Spare 2")]
        public string spare2 { get; set; } = "";

        [DisplayName("Spare 1")]
        public int i_spare1 { get; set; }

        [DisplayName("Spare 2")]
        public int i_spare2 { get; set; }

        [DisplayName("Spare 3")]
        public int i_spare3 { get; set; }

        [DisplayName("Spare S1")]
        public string s_spare1 { get; set; } = "";

        [DisplayName("Spare S2")]
        public string s_spare2 { get; set; } = "";

        [DisplayName("Spare S3")]
        public string s_spare3 { get; set; } = "";

        [DisplayName("Cill on Subframe")]
        public int new_ispare1 { get; set; }

        [DisplayName("Cill Type")]
        public int new_ispare2 { get; set; }

        [DisplayName("New Spare 9")]
        public int new_ispare9 { get; set; }

        [DisplayName("New SSpare 9")]
        public string new_sspare9 { get; set; } = "";

        [DisplayName("New SSpare 10")]
        public string new_sspare10 { get; set; } = "";

        #endregion
        [DisplayName("Garage Door Motor")]
        public int garage_door_motor { get; set; }
        [DisplayName("Globaldoor Link")]
        public string global_door_link { get; set; } = "";

        [DisplayName("Tower Scaffold")]
        public bool? isTowerScaff { get; set; }

        [DisplayName("Lintel Signed")]
        public bool lintel_signed { get; set; }
    }

}
