using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models
{
    public static class StatusHelper
    {
        public static bool ToBool(Status status)
        {
            if (status == Status.Active)
                return true;
            else return false;                   
        }

        internal static Status ToStatus(bool active)
        {
            if (active == true)
                return Status.Active;
            else return Status.Inactive;
        }
    }
    public enum Status
    {
        Active,
        Inactive        
    }    
}
