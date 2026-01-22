using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Test.Infrastructure.Data.Model;

namespace Test.Infrastructure.Data.DTOs
{
    public class FollowerDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;


        [JsonPropertyName("followerId")]
        [Required(ErrorMessage = "Id of the follower is required.")]
        public string FollowerId { get; set; } = string.Empty;


        [JsonPropertyName("followingId")]
        [Required(ErrorMessage = "Id of the person you are trying to follow is required.")]
        public string FollowingId { get; set; } = string.Empty;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
