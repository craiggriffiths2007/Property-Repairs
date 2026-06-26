
using System.ComponentModel.DataAnnotations;

namespace PropertySurveyService.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Code")]
        public string? Code { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Agent Type")]
        public agent_type Type { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Authentication String")]
        public string AuthenticationString { get; set; } = string.Empty;
    }
}
