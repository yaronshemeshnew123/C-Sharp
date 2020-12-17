﻿// <auto-generated />
using BeautyForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BeautyForum.Migrations
{
    [DbContext(typeof(BeautyForumContext))]
    partial class BeautyForumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeautyForum.Models.Forum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Forums");
                });

            modelBuilder.Entity("BeautyForum.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("ForumID");

                    b.Property<bool>("IsVisible");

                    b.Property<string>("Massage")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ForumID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BeautyForum.Models.Post", b =>
                {
                    b.HasOne("BeautyForum.Models.Forum", "Forum")
                        .WithMany("PostList")
                        .HasForeignKey("ForumID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
