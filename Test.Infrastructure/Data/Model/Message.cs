using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Test.Infrastructure.Data.Constants.Constants.MessageConstraints;

namespace Test.Infrastructure.Data.Model
{
    public class Message
    {
        public Message()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }



        [Required]
        public string SenderId { get; set; } = string.Empty;
        [ForeignKey(nameof(SenderId))]
        public virtual User Sender { get; set; } = null!;

        [Required]
        public string ReceiverId {  get; set; } = string.Empty;
        [ForeignKey(nameof(ReceiverId))]
        public virtual User Receiver { get; set; } = null!;



        [MaxLength(ConstentMaxLength)]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public bool Read { get; set; } = false;
    }
}
