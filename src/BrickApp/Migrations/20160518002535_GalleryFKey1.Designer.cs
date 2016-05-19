using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BrickApp.Models.Bricks;

namespace brickapp.Migrations
{
    [DbContext(typeof(BrickContext))]
    [Migration("20160518002535_GalleryFKey1")]
    partial class GalleryFKey1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrickApp.Models.Bricks.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<int>("Status");

                    b.HasKey("BlogId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.Gallery", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GalleryName")
                        .IsRequired();

                    b.HasKey("GalleryId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.GalleryContent", b =>
                {
                    b.Property<int>("GalleryContentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentType")
                        .IsRequired();

                    b.Property<string>("ContentUrl")
                        .IsRequired();

                    b.Property<int>("GalleryId");

                    b.HasKey("GalleryContentId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<int>("Status");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.HasKey("PostId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.Redirect", b =>
                {
                    b.Property<int>("RedirectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NewUrl")
                        .IsRequired();

                    b.Property<string>("OldUrl")
                        .IsRequired();

                    b.HasKey("RedirectId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.Testimonial", b =>
                {
                    b.Property<int>("TestimonialId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Customer");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Location");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.HasKey("TestimonialId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.GalleryContent", b =>
                {
                    b.HasOne("BrickApp.Models.Bricks.Gallery")
                        .WithMany()
                        .HasForeignKey("GalleryId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.Post", b =>
                {
                    b.HasOne("BrickApp.Models.Bricks.Blog")
                        .WithMany()
                        .HasForeignKey("BlogId");
                });
        }
    }
}
