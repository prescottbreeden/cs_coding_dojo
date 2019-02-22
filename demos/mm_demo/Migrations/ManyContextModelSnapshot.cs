﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mm_demo.Models;

namespace mm_demo.Migrations
{
    [DbContext(typeof(ManyContext))]
    partial class ManyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("mm_demo.Models.Magazine", b =>
                {
                    b.Property<int>("MagazineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("MagazineId");

                    b.ToTable("Magazines");
                });

            modelBuilder.Entity("mm_demo.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("mm_demo.Models.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MagazineId");

                    b.Property<int>("PersonId");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("MagazineId");

                    b.HasIndex("PersonId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("mm_demo.Models.Subscription", b =>
                {
                    b.HasOne("mm_demo.Models.Magazine", "Magazine")
                        .WithMany("Readers")
                        .HasForeignKey("MagazineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mm_demo.Models.Person", "Person")
                        .WithMany("Subscriptions")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
