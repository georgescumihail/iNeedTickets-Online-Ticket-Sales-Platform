﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iNeedTickets.Models;

namespace iNeedTickets.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("iNeedTickets.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("PhotoLink");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("iNeedTickets.Models.TicketType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaName");

                    b.Property<int>("Capacity");

                    b.Property<int?>("EventRefId");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.HasIndex("EventRefId");

                    b.ToTable("TicketTypes");
                });

            modelBuilder.Entity("iNeedTickets.Models.TicketType", b =>
                {
                    b.HasOne("iNeedTickets.Models.Event", "EventRef")
                        .WithMany("TicketTypes")
                        .HasForeignKey("EventRefId");
                });
#pragma warning restore 612, 618
        }
    }
}
