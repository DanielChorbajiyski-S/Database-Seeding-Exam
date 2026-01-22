using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Infrastructure.Data.Model
{
    public class Follower
    {
        public Follower()
        {
           this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }




        [Required]
        public string FollowerId { get; set; } = string.Empty;
        [ForeignKey(nameof(FollowerId))]
        public virtual User FollowerUser { get; set; } = null!;


        [Required]
        public string FollowingId { get; set; } = string.Empty;
        [ForeignKey(nameof(FollowingId))]
        public virtual User FollowingUser { get; set; } = null!;





        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
