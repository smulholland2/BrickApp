using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace BrickApp.Models.Admin
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options)
            : base(options)
        { }

        public DbSet<Warning> Warnings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<TeamTask> Tasks { get; set; }
    }
}