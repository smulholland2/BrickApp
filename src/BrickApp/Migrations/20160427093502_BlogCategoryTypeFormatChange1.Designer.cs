using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BrickApp.Models.Bricks;

namespace brickapp.Migrations
{
    [DbContext(typeof(BrickContext))]
    [Migration("20160427093502_BlogCategoryTypeFormatChange1")]
    partial class BlogCategoryTypeFormatChange1
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

                    b.HasKey("BlogId");
                });

            modelBuilder.Entity("BrickApp.Models.Bricks.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.HasKey("PostId");
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
