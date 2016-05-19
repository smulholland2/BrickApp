using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.Models.Admin
{
    public class Notification
    {
        [Key]
        [Required]
        public int NotificationId { get; set; }
        [Required]
        public string Messsage { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
