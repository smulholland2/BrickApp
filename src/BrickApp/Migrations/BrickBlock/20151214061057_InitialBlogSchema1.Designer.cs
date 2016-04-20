using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BrickApp.Models.BrickBlocks;

namespace BrickApp.Migrations.BrickBlock
{
    [DbContext(typeof(BrickBlockContext))]
    [Migration("20151214061057_InitialBlogSchema1")]
    partial class InitialBlogSchema1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrickApp.Models.BrickBlocks.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("BlogId");
                });

            modelBuilder.Entity("BrickApp.Models.BrickBlocks.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("PostId");
                });

            modelBuilder.Entity("BrickApp.Models.BrickBlocks.Post", b =>
                {
                    b.HasOne("BrickApp.Models.BrickBlocks.Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");
                });
        }
    }
}
