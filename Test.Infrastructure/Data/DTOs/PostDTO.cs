using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Test.Infrastructure.Data.Model;
using static Test.Infrastructure.Data.Constants.Constants.PostConstraints;

namespace Test.Infrastructure.Data.DTOs
{
    public class PostDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("userId")]
        [Required(ErrorMessage = "An id for the user is required.")]
        public string UserId { get; set; } = string.Empty;

        [JsonPropertyName("content")]
        [MaxLength(ContentMaxLength, ErrorMessage = "The content of your message must not exceed 300 characters")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
