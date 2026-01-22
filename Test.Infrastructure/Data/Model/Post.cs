using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Test.Infrastructure.Data.Constants.Constants.PostConstraints;

namespace Test.Infrastructure.Data.Model
{
    public class Post
    {
        public Post()
        {
             this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }



        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public virtual User user { get; set; } = null!;



        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
