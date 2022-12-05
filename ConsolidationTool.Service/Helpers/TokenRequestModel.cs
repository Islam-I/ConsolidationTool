using System.ComponentModel.DataAnnotations;

namespace ConsolidationTool.Service.Helpers
{
    public class TokenRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
