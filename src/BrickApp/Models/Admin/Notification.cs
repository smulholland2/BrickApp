using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.Models.Admin
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Messsage { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public bool Status { get; set; }
    }
}
