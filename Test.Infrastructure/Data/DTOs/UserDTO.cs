using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Test.Infrastructure.Data.Constants.Constants.UserConstraints;

namespace Test.Infrastructure.Data.DTOs
{
    public class UserDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("username")]
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Email adress is required.")]
        [EmailAddress(ErrorMessage = "Invalid email adress.")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = string.Empty;

        [JsonPropertyName("bio")]
        [MaxLength(BioMaxLength, ErrorMessage = "Username must be between 5 and 150 symbols.")]
        public string Bio { get; set; } = string.Empty;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
