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
    public class JobHeader
    {

        [DisplayName("Record ID")]
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public Guid Guid { get; set; } = Guid.NewGuid();


        [DisplayName("Job Type")]
        public enum_job_type JobType { get; set; }

        [DisplayName("Agent Code")]
        public string AgentCode { get; set; } = "";

        [DisplayName("Complete")]
        [Browsable(false)]
        public bool bComplete { get; set; }

        [DisplayName("Sent")]
        [Browsable(false)]
        public bool bSent { get; set; }

        #region Scheduling & Diary Details

        [DisplayName("Diary Date")]
        public DateTime DiaryDate { get; set; } = DateTime.Today;

        [DisplayName("Surveyor Start Time")]
        public string StartTime { get; set; } = "";

        [DisplayName("Surveyor Finish Time")]
        public string FinishTime { get; set; } = "";

        [DisplayName("Surveyor Time Arrived")]
        public string TimeArrived { get; set; } = "";


        [DisplayName("Fit Diary Date")]
        public string FitDate { get; set; } = "";

        [DisplayName("Fit Start Time")]
        public string FitStartTime { get; set; } = "";

        [DisplayName("Fit Finish Time")]
        public string FitFinishTime { get; set; } = "";



        #endregion


        #region Client & Contract Information

        //[Indexed]
        [Browsable(false)]
        [DisplayName("Contract Code")]
        public string ContractCode { get; set; } = "";

        [DisplayName("Policy Number")]
        public string PolicyNumber { get; set; } = "";

        [DisplayName("Invoice Number")]
        public string InvoiceNumber { get; set; } = "";

        [DisplayName("Insurance Company Name")]
        public string InsuranceCompanyName { get; set; } = "";

        [DisplayName("Loss Adjuster Name")]
        public string LossAdjusterName { get; set; } = "";





        [DisplayName("Incident Date")]
        public string IncidentDate { get; set; } = "";

        [DisplayName("COD String")]
        public string CauseOfDamage { get; set; } = "";

        [DisplayName("Damage Description")]
        public string DamageDescription { get; set; } = "";





        [DisplayName("Client Name")]
        public string ClientName { get; set; } = "";

        [DisplayName("Client Address 1")]
        public string ClientAddressLine1 { get; set; } = "";

        [DisplayName("Client Address 2")]
        public string ClientAddressLine2 { get; set; } = "";

        [DisplayName("Client Address 3")]
        public string ClientAddressLine3 { get; set; } = "";

        [DisplayName("Client Address 4")]
        public string ClientAddressLine4 { get; set; } = "";

        [DisplayName("Client Postcode")]
        public string ClientPostcode { get; set; } = "";

        [DisplayName("Client Phone Number")]
        public string ClientPhoneNumber { get; set; } = "";

        [DisplayName("Client Phone Number 2")]
        public string ClientPhoneNumber2 { get; set; } = "";

        [DisplayName("Client Phone Number 3")]
        public string ClientPhoneNumber3 { get; set; } = "";

        [DisplayName("Additional Phone 1")]
        public string ClientAddPhoneNumber1 { get; set; } = "";

        [DisplayName("Additional Phone 2")]
        public string ClientAddPhoneNumber2 { get; set; } = "";



        [DisplayName("Customer Number")]
        public string CustomerNumber { get; set; } = "";


        [DisplayName("Type A")]
        public string typeA { get; set; } = "";

        [DisplayName("Type B")]
        public string typeB { get; set; } = "";

        [DisplayName("Traffic Light")]
        public int udi_tlight { get; set; }

        #endregion

        #region Job, Instructions & Progress

        [DisplayName("Instructions")]
        public string Instructions { get; set; } = "";

        [DisplayName("Job Instructions")]
        public string JobInstructions { get; set; } = "";

        [DisplayName("Booked on Day 1")]
        public bool? BookedOnDay1 { get; set; }

        [DisplayName("Reason Not Booked In")]
        public string ReasonNotBookedOnDay1 { get; set; } = "";

        [DisplayName("Number of Items")]
        public int NumberOfItems { get; set; }

        [DisplayName("Job Grade")]
        public string job_grade { get; set; } = "";

        [DisplayName("Job Size")]
        public string njs { get; set; } = "";

        [DisplayName("Report Text")]
        public string Report { get; set; } = "";

        [DisplayName("Summary Text")]
        public string Summary { get; set; } = "";

        #endregion

        #region Site Logistics, Risks & Health & Safety

        [DisplayName("Door Bell")]
        public bool? doorbell { get; set; }

        [DisplayName("Alarm Contacts")]
        public bool? alarm_cont { get; set; }

        [DisplayName("Acro Prop Required")]
        public bool? acroreq { get; set; }

        [DisplayName("Acro Prop Boy")]
        public bool? acrosboy { get; set; }

        [DisplayName("Sand and Cement Required")]
        public bool? sand_cemen { get; set; }

        [DisplayName("Plaster Required")]
        public bool? plaster { get; set; }

        [DisplayName("Generator Required")]
        public bool? genreq { get; set; }

        [DisplayName("Architraves Required")]
        public bool? architreq { get; set; }

        [DisplayName("Access Requirements Comments")]
        public string acc_text { get; set; } = "";

        [DisplayName("Number of Ladders")]
        public bool? no_ladders { get; set; }

        [DisplayName("Obstructive Wires")]
        public bool? obs_wires { get; set; }

        [DisplayName("Obstructive Wires Comments")]
        public string obs_wires_text { get; set; } = "";

        [DisplayName("Loose Brick Above Item")]
        public bool? loose_brick { get; set; }

        [DisplayName("Loose Brick Comments")]
        public string loose_brick_text { get; set; } = "";

        [DisplayName("Easy Parking")]
        public bool? easy_park { get; set; }

        [DisplayName("Access to Rear of Property")]
        public bool? access_rear { get; set; }

        [DisplayName("Parking at Rear")]
        public bool? parking_at_rear { get; set; }

        [DisplayName("Work Inside")]
        public bool? bWorkInside { get; set; }

        [DisplayName("Installation Height")]
        public string inst_height { get; set; } = "";

        [DisplayName("Ground Surface")]
        public string ground_surface { get; set; } = "";

        [DisplayName("Type of Equipment")]
        public string type_of_equipment { get; set; } = "";

        [DisplayName("Risks and Dangers")]
        public string risks_and_dangers { get; set; } = "";

        [DisplayName("Work at Height")]
        public bool? work_at_height { get; set; }

        [DisplayName("Work on Public Footpath")]
        public bool? work_on_public_footpath { get; set; }

        [DisplayName("Added to Other Risks")]
        public bool added_to_otherrisks { get; set; }

        [DisplayName("Asbestos Visible")]
        public bool? asbestos_visible { get; set; }

        [DisplayName("Asbestos Visible Explanation")]
        public string asvizex { get; set; } = "";

        [DisplayName("Lintel Present")]
        public string lintel_present { get; set; } = "...";

        [DisplayName("Lintel Present Text")]
        public string lintel_present_text { get; set; } = "";

        [DisplayName("InevitableDamage")]
        public bool? InevitableDamage { get; set; }

        [DisplayName("Explain Inevitable Damage")]
        public string InevitableDamageExplain { get; set; } = "";

        [DisplayName("Subcontract")]
        public bool? b_subcontract { get; set; }

        [DisplayName("Shop Front Work")]
        public bool? shop_front_work { get; set; }

        [DisplayName("Subcontract Text")]
        public string subcontracttext { get; set; } = "";

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

        [DisplayName("Fitters Instructions")]
        public string FitInstructions { get; set; } = "";

        [DisplayName("Fitter Work")]
        public string FitWorkCarriedOut { get; set; } = "";

        [DisplayName("Parts Used")]
        public string FitPartsUsed { get; set; } = "";

        [DisplayName("Fitter Comments")]
        public string FitComments { get; set; } = "";

        [DisplayName("Time Arrived")]
        public string FitTimeArrived { get; set; } = "";

        [DisplayName("Time Left")]
        public string FitTimeLeft { get; set; } = "";


        [DisplayName("Super Fitter Done")]
        public bool si_done { get; set; }

        [DisplayName("Fitting Complete")]
        public int bfitter_complete { get; set; }

        [DisplayName("Fitter Signature Date")]
        public string f_sign_date { get; set; } = "";

        [DisplayName("Directive Complete")]
        public int directive_complete { get; set; }

        #endregion

        #region Mandate & Job Completion


        [DisplayName("Unfinished Code")]
        public string funfinished_code { get; set; } = "";

        [DisplayName("Reason Unfinished (Other)")]
        public string freason_unfinished { get; set; } = "";

        [DisplayName("Barrier Size")]
        public string size_of_barriers_required { get; set; } = "";


        [DisplayName("Fitter Mandate Signed")]
        public int fbmandate_signed { get; set; }

        [DisplayName("Reason Mandate Not Signed")]
        public string freason_mandate_not_signed { get; set; } = "";




        [DisplayName("Fitters Mandate Other")]
        public string funfinoth { get; set; } = "";

        [DisplayName("Completion Signed")]
        public bool bcompletion_signed { get; set; }



        [DisplayName("Fitter Parts Required")]
        public string fparts_required { get; set; } = "";

        [DisplayName("Fitter Stock Usage Complete")]
        public bool fbstockusagecomplete { get; set; }


        #endregion

        #region Financials & Payments

        [DisplayName("Account Code")]
        public string si_mpay { get; set; } = "";

        [DisplayName("Method of Payment")]
        public string mop { get; set; } = "";


        [DisplayName("Excess Amount")]
        public double uc_excess { get; set; }

        [DisplayName("Additional Amount")]
        public string additional_ammount_str { get; set; } = "";

        [DisplayName("Excess Collected")]
        public bool? bExcessCollected { get; set; }

        [DisplayName("Reason Excess Not Collected")]
        public string reason_excess_not_collected { get; set; } = "";


        [DisplayName("Fitter Excess Paid")]
        public int fbexcess_paid { get; set; }

        [DisplayName("Reason Excess Not Paid")]
        public string freason_excess_not_paid { get; set; } = "";


        [DisplayName("Fitter Additional Paid")]
        public int fbadditional_paid { get; set; }

        [DisplayName("How Much Additional Paid (Fitter)")]
        public string fhow_mutch_additional_paid { get; set; } = "";


        [DisplayName("Survey")]
        public bool bSurvey { get; set; }

        [DisplayName("Survey Complete")]
        public bool? survey_complete { get; set; }

        [DisplayName("Reason Not Complete")]
        public string reason_not_complete { get; set; } = "";





        #region Remedial Action Details


        [DisplayName("Remedial Fault")]
        public string r_fault { get; set; } = "";




        [DisplayName("Remedial Hours to Complete")]
        public string rno_hours { get; set; } = "";

        [DisplayName("Remedial Work Carried Out")]
        public string r_work_txt { get; set; } = "";

        [DisplayName("Remedial Signed")]
        public bool r_bsigned { get; set; }


        [DisplayName("Remedial Additional Image")]
        public bool readditimage { get; set; }

        [DisplayName("Remedial Additional Text")]
        public string readdtxt { get; set; } = "";


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


        #endregion



        #region Framework Integrations, Insurers & External APIs







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
        [Browsable(false)]
        public int incomplete_frames { get; set; }

        [DisplayName("Incomplete UPVC")]
        [Browsable(false)]
        public int incomplete_upvc { get; set; }

        [DisplayName("Incomplete Panels")]
        [Browsable(false)]
        public int incomplete_panels { get; set; }

        [DisplayName("Incomplete Glass")]
        [Browsable(false)]
        public int incomplete_glass { get; set; }

        [DisplayName("Incomplete Aluminium")]
        [Browsable(false)]
        public int incomplete_alum { get; set; }

        [DisplayName("Incomplete Garage")]
        [Browsable(false)]
        public int incomplete_garage { get; set; }

        [DisplayName("Incomplete Timber")]
        [Browsable(false)]
        public int incomplete_timber { get; set; }

        [DisplayName("Incomplete Cons")]
        [Browsable(false)]
        public int incomplete_cons { get; set; }

        [DisplayName("Incomplete Lock")]
        [Browsable(false)]
        public int incomplete_lock { get; set; }

        [DisplayName("Incomplete Composite")]
        [Browsable(false)]
        public int incomplete_comp { get; set; }

        [DisplayName("Incomplete Green")]
        [Browsable(false)]
        public int incomplete_green { get; set; }

        [DisplayName("Incomplete Bifold")]
        [Browsable(false)]
        public int incomplete_bifold { get; set; }

        #endregion





        #region Workflow Checkpoints & UI Flags

        [DisplayName("Damage Ticked")]
        [Browsable(false)]
        public bool bDamTicked { get; set; }

        [DisplayName("SS Ticked")]
        [Browsable(false)]
        public bool bSSTicked { get; set; }

        [DisplayName("SR Finished")]
        [Browsable(false)]
        public bool bSRFin { get; set; }

        [DisplayName("MOP Finished")]
        [Browsable(false)]
        public bool bMOPFin { get; set; }

        [DisplayName("Rep Finished")]
        [Browsable(false)]
        public bool bRepFin { get; set; }

        [DisplayName("Sum Finished")]
        [Browsable(false)]
        public bool bSumFin { get; set; }

        [DisplayName("Haz Finished")]
        [Browsable(false)]
        public bool bHazFin { get; set; }

        [DisplayName("Sub Finished")]
        [Browsable(false)]
        public bool bSubFin { get; set; }

        [DisplayName("Time to Complete")]
        public string time_to_complete { get; set; } = "";

        [DisplayName("Current Item Number")]
        [Browsable(false)]
        public int current_item_number { get; set; }

        [DisplayName("Items Above Roof")]
        public bool? items_above_roof { get; set; }

        [DisplayName("Current Summary Number")]
        [Browsable(false)]
        public int current_summary_number { get; set; }

        #endregion


        [DisplayName("Request Repudiation")]
        public bool bRequestRepudiation { get; set; } = false;


        [DisplayName("Repudiation completed")]
        [Browsable(false)]
        public bool bRepCom { get; set; }

        [DisplayName("Have you repudiated?")]
        public bool? have_you_repudiated { get; set; }

        [DisplayName("Reason not repudiated")]
        public string reason_not_repudiated { get; set; } = "";

        [DisplayName("Repudiation reason different")]
        public string repudiation_reason_different { get; set; } = "";


        [DisplayName("Repudiation other information")]
        public string repudiation_other_information { get; set; } = "";





        [DisplayName("Hire equipment used")]
        public string hire_equipment_used { get; set; } = "...";

        [DisplayName("Hire equipment used text")]
        public string hire_equipment_used_text { get; set; } = "";




        [DisplayName("Additional Summary Information")]
        public bool? additional_summary_info { get; set; }




        #endregion

        [DisplayName("Garage Door Motor")]
        public int garage_door_motor { get; set; }



        [DisplayName("GD Type")]
        public string gdm_door_type { get; set; } = "";
        [DisplayName("GD Model Type")]
        public string gdm_model_type { get; set; } = "";
        [DisplayName("GD Unique Serial Number")]
        public string gdm_unique_serial { get; set; } = "";
        [DisplayName("GD Size")]
        public string gdm_door_size { get; set; } = "";
        [DisplayName("GD Manufacturer")]
        public string gdm_door_manufacturer { get; set; } = "";
        [DisplayName("GD Powered Operator Type")]
        public string gdm_powerered_operator_type { get; set; } = "";
        [DisplayName("GD Operator Type")]
        public string gdm_operator_type { get; set; } = "";
        [DisplayName("GD Operator Manufactured By")]
        public string gdm_operator_manufacturer { get; set; } = "";
        [DisplayName("GD Site Address")]

        public string gdm_site_address { get; set; } = "";
        [DisplayName("GD Decleration made by")]
        public string gdm_dec_made_by { get; set; } = "";
        [DisplayName("GD Customer Name")]
        public string gdm_cust_name { get; set; } = "";
        [DisplayName("GD Sign Date")]
        public string gdm_sign_date { get; set; } = "";




        [DisplayName("Globaldoor Link")]
        public string global_door_link { get; set; } = "";
        [DisplayName("Tower Scaffold")]
        public bool? isTowerScaff { get; set; }

        [DisplayName("Lintel Signed")]
        public bool lintel_signed { get; set; }

        [DisplayName("Number of Videos")]
        public int no_of_videos { get; set; }

        [DisplayName("Additional Summary Information")]
        [Browsable(false)]
        public bool? bAddSummaryInfo { get; set; }

    }

}
