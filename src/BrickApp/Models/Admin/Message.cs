using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.Models.Admin
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [Required]
        public TeamMember Sender { get; set; }
        [Required]
        public DateTime DateSent { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public List<TeamMember> TeamMembers { get; set; }
    }
}
