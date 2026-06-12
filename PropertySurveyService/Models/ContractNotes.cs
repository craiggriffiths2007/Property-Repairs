using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public enum NoteType
    {
        General,
        Update,
        Warning,
        Resolution
    }
    public class ContractNotes
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Contract Code")]
        public string ContractCode { get; set; } = "";

        [DisplayName("Date Added")]
        public string DateAdded { get; set; } = "";

        [DisplayName("Note")]
        public string Note { get; set; } = "";
        [DisplayName("Added By")]
        public string AddedBy { get; set; } = "";
        [DisplayName("Note Type")]
        public NoteType NoteType { get; set; } = NoteType.General;
    }
}
