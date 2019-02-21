﻿// <auto-generated />
using System;
using AmazonCognitoSpike.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmazonCognitoSpike.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190221193746_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("AmazonCognitoSpike.Data.Models.Organization", b =>
                {
                    b.Property<Guid>("OrganizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CognitoAudience");

                    b.Property<string>("CognitoAuthority");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });
#pragma warning restore 612, 618
        }
    }
}
