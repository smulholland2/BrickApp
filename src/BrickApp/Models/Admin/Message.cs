using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.Models.Admin
{
    public class Message
    {
        public int MessageId { get; set; }
        public TeamMember Sender { get; set; }
        public List<TeamMember> Recipient { get; set; }
        public DateTime DateSent { get; set; }
        public bool Status { get; set; }
    }
}
