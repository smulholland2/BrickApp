using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BrickApp.Models.Admin;

namespace brickapp.Migrations.Admin
{
    [DbContext(typeof(AdminContext))]
    [Migration("20160519094713_AdminModulesAdd1")]
    partial class AdminModulesAdd1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrickApp.Models.Admin.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSent");

                    b.Property<int?>("SenderTeamMemberId");

                    b.Property<bool>("Status");

                    b.HasKey("MessageId");
                });

            modelBuilder.Entity("BrickApp.Models.Admin.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Messsage");

                    b.Property<bool>("Status");

                    b.Property<string>("User");

                    b.HasKey("NotificationId");
                });

            modelBuilder.Entity("BrickApp.Models.Admin.TeamMember", b =>
                {
                    b.Property<int>("TeamMemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("MemberName")
                        .IsRequired();

                    b.Property<int?>("MessageMessageId");

                    b.Property<int>("Status");

                    b.Property<int?>("TeamTaskTeamTaskId");

                    b.HasKey("TeamMemberId");
                });

            modelBuilder.Entity("BrickApp.Models.Admin.TeamTask", b =>
                {
                    b.Property<int>("TeamTaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Status");

                    b.Property<string>("Task");

                    b.HasKey("TeamTaskId");
                });

            modelBuilder.Entity("BrickApp.Models.Admin.Warning", b =>
                {
                    b.Property<int>("WarningId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.Property<DateTime>("WarningDate");

                    b.HasKey("WarningId");
                });

            modelBuilder.Entity("BrickApp.Models.Admin.Message", b =>
                {
                    b.HasOne("BrickApp.Models.Admin.TeamMember")
                        .WithMany()
                        .HasForeignKey("SenderTeamMemberId");
                });

            modelBuilder.Entity("BrickApp.Models.Admin.TeamMember", b =>
                {
                    b.HasOne("BrickApp.Models.Admin.Message")
                        .WithMany()
                        .HasForeignKey("MessageMessageId");

                    b.HasOne("BrickApp.Models.Admin.TeamTask")
                        .WithMany()
                        .HasForeignKey("TeamTaskTeamTaskId");
                });
        }
    }
}
