using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }
        [Required]
        [Display(Name = "Code")]
        public string? AgentCode { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Agent Type")]
        public int AgentType { get; set; }
    }
}
