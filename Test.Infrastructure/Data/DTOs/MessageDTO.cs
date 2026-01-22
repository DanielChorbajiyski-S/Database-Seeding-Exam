using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Test.Infrastructure.Data.Model;
using static Test.Infrastructure.Data.Constants.Constants.MessageConstraints;

namespace Test.Infrastructure.Data.DTOs
{
    public class MessageDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;


        [JsonPropertyName("senderId")]
        [Required(ErrorMessage = "User Id of the sender is required.")]
        public string SenderId { get; set; } = string.Empty;

        [JsonPropertyName("receiverId")]
        [Required(ErrorMessage = "User id of the receiver is required.")]
        public string ReceiverId { get; set; } = string.Empty;


        [JsonPropertyName("content")]
        [MaxLength(ConstentMaxLength, ErrorMessage = "message content cannot exceed 1000 characters")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        [JsonPropertyName("read")]
        public bool Read { get; set; } = false;
    }
}
