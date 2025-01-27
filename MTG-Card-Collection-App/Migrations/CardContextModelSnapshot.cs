﻿// <auto-generated />
using System;
using MTG_Card_Collection_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MTG_Card_Collection_App.Migrations
{
    [DbContext(typeof(CardContext))]
    partial class CardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MTG_Card_Collection_App.Models.Card", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("CMC")
                        .HasColumnType("real");

                    b.Property<string>("ColorIdentity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Layout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManaCost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Power")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Printings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Set")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("SetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supertypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toughness")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Types")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = "507585",
                            Artist = "Piotr Dura",
                            CMC = 0f,
                            ColorIdentity = "[\"W\"]",
                            ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507585&type=card",
                            Layout = "normal",
                            Name = "Plains",
                            Number = "394",
                            Printings = "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DDC\",\"DDE\",\"DDF\",\"DDG\",\"DDH\",\"DDI\",\"DDK\",\"DDL\",\"DDN\",\"DDO\",\"DDP\",\"DDQ\",\"DMU\",\"DOM\",\"DTK\",\"DVD\",\"E01\",\"ELD\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"MD1\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PDGM\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PLIST\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC02\",\"WC03\",\"WC04\",\"WC97\",\"WC98\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]",
                            Rarity = "Common",
                            Set = "KHM",
                            SetName = "Kaldheim",
                            Subtypes = "[\"Plains\"]",
                            Supertypes = "[\"Basic\"]",
                            Text = "({T}: Add {W}.)",
                            Type = "Basic Land — Plains",
                            Types = "[\"Land\"]"
                        },
                        new
                        {
                            Id = "507586",
                            Artist = "Johannes Voss",
                            CMC = 0f,
                            ColorIdentity = "[\"U\"]",
                            ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507586&type=card",
                            Layout = "normal",
                            Name = "Island",
                            Number = "395",
                            Printings = "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DD2\",\"DDE\",\"DDF\",\"DDH\",\"DDI\",\"DDJ\",\"DDM\",\"DDN\",\"DDO\",\"DDQ\",\"DDS\",\"DDT\",\"DDU\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"E01\",\"ELD\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"JVC\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL02\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PHED\",\"PLIST\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC01\",\"WC02\",\"WC03\",\"WC04\",\"WC97\",\"WC98\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]",
                            Rarity = "Common",
                            Set = "KHM",
                            SetName = "Kaldheim",
                            Subtypes = "[\"Island\"]",
                            Supertypes = "[\"Basic\"]",
                            Text = "({T}: Add {U}.)",
                            Type = "Basic Land — Island",
                            Types = "[\"Land\"]"
                        },
                        new
                        {
                            Id = "507587",
                            Artist = "Piotr Dura",
                            CMC = 0f,
                            ColorIdentity = "[\"B\"]",
                            ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507587&type=card",
                            Layout = "normal",
                            Name = "Swamp",
                            Number = "396",
                            Printings = "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CST\",\"DDC\",\"DDD\",\"DDE\",\"DDH\",\"DDJ\",\"DDK\",\"DDM\",\"DDN\",\"DDP\",\"DDQ\",\"DDR\",\"DKM\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"DVD\",\"E01\",\"ELD\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GVL\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"MD1\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PD3\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PHUK\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC01\",\"WC02\",\"WC03\",\"WC97\",\"WC98\",\"WC99\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]",
                            Rarity = "Common",
                            Set = "KHM",
                            SetName = "Kaldheim",
                            Subtypes = "[\"Swamp\"]",
                            Supertypes = "[\"Basic\"]",
                            Text = "({T}: Add {B}.)",
                            Type = "Basic Land — Swamp",
                            Types = "[\"Land\"]"
                        },
                        new
                        {
                            Id = "507588",
                            Artist = "Sam Burley",
                            CMC = 0f,
                            ColorIdentity = "[\"R\"]",
                            ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507588&type=card",
                            Layout = "normal",
                            Name = "Mountain",
                            Number = "397",
                            Printings = "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ARN\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DD1\",\"DD2\",\"DDE\",\"DDG\",\"DDH\",\"DDI\",\"DDJ\",\"DDK\",\"DDL\",\"DDN\",\"DDP\",\"DDS\",\"DDT\",\"DDU\",\"DKM\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"E01\",\"ELD\",\"EVG\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"JVC\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PD2\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PHED\",\"PLIST\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC01\",\"WC02\",\"WC03\",\"WC97\",\"WC98\",\"WC99\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]",
                            Rarity = "Common",
                            Set = "KHM",
                            SetName = "Kaldheim",
                            Subtypes = "[\"Mountain\"]",
                            Supertypes = "[\"Basic\"]",
                            Text = "({T}: Add {R}.)",
                            Type = "Basic Land — Mountain",
                            Types = "[\"Land\"]"
                        },
                        new
                        {
                            Id = "507589",
                            Artist = "Sam Burley",
                            CMC = 0f,
                            ColorIdentity = "[\"G\"]",
                            ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507589&type=card",
                            Layout = "normal",
                            Name = "Forest",
                            Number = "398",
                            Printings = "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DD1\",\"DDD\",\"DDE\",\"DDG\",\"DDH\",\"DDJ\",\"DDL\",\"DDM\",\"DDO\",\"DDP\",\"DDR\",\"DDS\",\"DDU\",\"DKM\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"E01\",\"ELD\",\"EVG\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"GVL\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC01\",\"WC02\",\"WC03\",\"WC04\",\"WC97\",\"WC98\",\"WC99\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]",
                            Rarity = "Common",
                            Set = "KHM",
                            SetName = "Kaldheim",
                            Subtypes = "[\"Forest\"]",
                            Supertypes = "[\"Basic\"]",
                            Text = "({T}: Add {G}.)",
                            Type = "Basic Land — Forest",
                            Types = "[\"Land\"]"
                        });
                });

            modelBuilder.Entity("MTG_Card_Collection_App.Models.CardCollection", b =>
                {
                    b.Property<string>("CardId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CardId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CardCollections");
                });

            modelBuilder.Entity("MTG_Card_Collection_App.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MTG_Card_Collection_App.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MTG_Card_Collection_App.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MTG_Card_Collection_App.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MTG_Card_Collection_App.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MTG_Card_Collection_App.Models.CardCollection", b =>
                {
                    b.HasOne("MTG_Card_Collection_App.Models.Card", "Card")
                        .WithMany("Users")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MTG_Card_Collection_App.Models.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MTG_Card_Collection_App.Models.Card", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("MTG_Card_Collection_App.Models.User", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
