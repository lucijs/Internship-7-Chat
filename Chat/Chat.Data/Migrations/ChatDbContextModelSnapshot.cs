﻿// <auto-generated />
using System;
using Chat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Chat.Data.Migrations
{
    [DbContext(typeof(ChatDbContext))]
    partial class ChatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Chat.Data.Entities.Models.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Channels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Da van se zalin malo"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Goz"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Parizzz"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Girls"
                        });
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.ChannelUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ChannelId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("UserId");

                    b.ToTable("ChannelUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChannelId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ChannelId = 1,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            ChannelId = 1,
                            UserId = 6
                        },
                        new
                        {
                            Id = 4,
                            ChannelId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            ChannelId = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            ChannelId = 2,
                            UserId = 5
                        },
                        new
                        {
                            Id = 7,
                            ChannelId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            ChannelId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 9,
                            ChannelId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 10,
                            ChannelId = 3,
                            UserId = 6
                        },
                        new
                        {
                            Id = 11,
                            ChannelId = 4,
                            UserId = 1
                        },
                        new
                        {
                            Id = 12,
                            ChannelId = 4,
                            UserId = 3
                        },
                        new
                        {
                            Id = 13,
                            ChannelId = 4,
                            UserId = 7
                        });
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.MessagesInTheChannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChannelId")
                        .HasColumnType("integer");

                    b.Property<int>("ChannelUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeSent")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("ChannelUserId");

                    b.HasIndex("UserId");

                    b.ToTable("MessagesInTheChannel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChannelUserId = 1,
                            Content = "Fun fact",
                            TimeSent = new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            ChannelUserId = 1,
                            Content = "Pukla mi je cizme",
                            TimeSent = new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            ChannelUserId = 1,
                            Content = "",
                            TimeSent = new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 4,
                            ChannelUserId = 1,
                            Content = "Josip je dozivia tu svadu",
                            TimeSent = new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 5,
                            ChannelUserId = 1,
                            Content = "Al kupuje mi nove",
                            TimeSent = new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 6,
                            ChannelUserId = 2,
                            Content = "bro",
                            TimeSent = new DateTime(2023, 11, 10, 22, 21, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 7,
                            ChannelUserId = 2,
                            Content = "kako ih je pukla",
                            TimeSent = new DateTime(2023, 11, 10, 22, 21, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 8,
                            ChannelUserId = 3,
                            Content = "STA",
                            TimeSent = new DateTime(2023, 11, 10, 22, 35, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 9,
                            ChannelUserId = 4,
                            Content = "Jel iko od vas auto",
                            TimeSent = new DateTime(2023, 4, 16, 10, 10, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 10,
                            ChannelUserId = 6,
                            Content = "Ja vas mogu skupit",
                            TimeSent = new DateTime(2023, 4, 16, 10, 12, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 11,
                            ChannelUserId = 5,
                            Content = "ma ja cu ic",
                            TimeSent = new DateTime(2023, 4, 16, 10, 13, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 12,
                            ChannelUserId = 5,
                            Content = "ne kasni mi se",
                            TimeSent = new DateTime(2023, 4, 16, 10, 13, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 13,
                            ChannelUserId = 6,
                            Content = "Nece ti nista bit ako jednom zakasnis",
                            TimeSent = new DateTime(2023, 4, 16, 10, 13, 30, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 14,
                            ChannelUserId = 5,
                            Content = "ma ne zelin kasnit",
                            TimeSent = new DateTime(2023, 4, 16, 10, 14, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 15,
                            ChannelUserId = 4,
                            Content = "Kad me kupis",
                            TimeSent = new DateTime(2023, 4, 16, 10, 14, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 16,
                            ChannelUserId = 9,
                            Content = "kakav nan je apartman",
                            TimeSent = new DateTime(2022, 10, 1, 14, 13, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 17,
                            ChannelUserId = 9,
                            Content = "i luci se ugasia mob",
                            TimeSent = new DateTime(2022, 10, 1, 14, 13, 18, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 18,
                            ChannelUserId = 8,
                            Content = "Standardno",
                            TimeSent = new DateTime(2022, 10, 1, 14, 14, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 19,
                            ChannelUserId = 10,
                            Content = "predobro je",
                            TimeSent = new DateTime(2022, 10, 1, 14, 16, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 20,
                            ChannelUserId = 10,
                            Content = "ima masu prostpra",
                            TimeSent = new DateTime(2022, 10, 1, 14, 16, 23, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 21,
                            ChannelUserId = 12,
                            Content = "jel mogu napisat",
                            TimeSent = new DateTime(2023, 8, 15, 20, 0, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 22,
                            ChannelUserId = 12,
                            Content = "pala je na thirst trap",
                            TimeSent = new DateTime(2023, 8, 15, 20, 0, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 23,
                            ChannelUserId = 11,
                            Content = "Zato ne smin lajkat sliku",
                            TimeSent = new DateTime(2023, 8, 15, 20, 1, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 24,
                            ChannelUserId = 11,
                            Content = "I pisi sta oces",
                            TimeSent = new DateTime(2023, 8, 15, 20, 2, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 25,
                            ChannelUserId = 12,
                            Content = "hvala",
                            TimeSent = new DateTime(2023, 8, 15, 20, 3, 10, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 26,
                            ChannelUserId = 11,
                            Content = "Al ces mi poslat sta odg",
                            TimeSent = new DateTime(2023, 8, 15, 20, 4, 10, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.PrivateMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeSent")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserReceivedId")
                        .HasColumnType("integer");

                    b.Property<int>("UserSentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserReceivedId");

                    b.HasIndex("UserSentId");

                    b.ToTable("PrivateMessages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Sretan rodendan sunce Voli  te puuuuno",
                            TimeSent = new DateTime(2017, 6, 23, 0, 0, 10, 0, DateTimeKind.Utc),
                            UserReceivedId = 3,
                            UserSentId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "hvala tii",
                            TimeSent = new DateTime(2017, 6, 23, 0, 1, 10, 0, DateTimeKind.Utc),
                            UserReceivedId = 1,
                            UserSentId = 3
                        },
                        new
                        {
                            Id = 3,
                            Content = "Sretan rockas Love you",
                            TimeSent = new DateTime(2017, 7, 24, 0, 0, 10, 0, DateTimeKind.Utc),
                            UserReceivedId = 1,
                            UserSentId = 3
                        },
                        new
                        {
                            Id = 4,
                            Content = "Hvala tiiii",
                            TimeSent = new DateTime(2017, 7, 24, 0, 5, 10, 0, DateTimeKind.Utc),
                            UserReceivedId = 3,
                            UserSentId = 1
                        },
                        new
                        {
                            Id = 5,
                            Content = "Opet me zaustavila policija",
                            TimeSent = new DateTime(2023, 8, 27, 2, 7, 10, 0, DateTimeKind.Utc),
                            UserReceivedId = 1,
                            UserSentId = 4
                        },
                        new
                        {
                            Id = 6,
                            Content = "Naplatili su mi kaznu zbog registracije",
                            TimeSent = new DateTime(2023, 8, 27, 2, 7, 30, 0, DateTimeKind.Utc),
                            UserReceivedId = 1,
                            UserSentId = 4
                        },
                        new
                        {
                            Id = 7,
                            Content = "Nemoj me zezat",
                            TimeSent = new DateTime(2023, 8, 27, 2, 31, 10, 0, DateTimeKind.Utc),
                            UserReceivedId = 4,
                            UserSentId = 1
                        });
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "luce@pmf.st",
                            IsAdmin = true,
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ana@fesb.hr",
                            IsAdmin = false,
                            Password = "12345"
                        },
                        new
                        {
                            Id = 3,
                            Email = "paula@fesb.hr",
                            IsAdmin = false,
                            Password = "lucijalucija"
                        },
                        new
                        {
                            Id = 4,
                            Email = "josip@fesb.hr",
                            IsAdmin = false,
                            Password = "4321"
                        },
                        new
                        {
                            Id = 5,
                            Email = "jurin@efst.hr",
                            IsAdmin = false,
                            Password = "01.12."
                        },
                        new
                        {
                            Id = 6,
                            Email = "gabi@fesb.hr",
                            IsAdmin = false,
                            Password = "fesb"
                        },
                        new
                        {
                            Id = 7,
                            Email = "nada@mefst.hr",
                            IsAdmin = false,
                            Password = "sokol"
                        });
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.ChannelUser", b =>
                {
                    b.HasOne("Chat.Data.Entities.Models.Channel", "Channel")
                        .WithMany("ChannelUsers")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat.Data.Entities.Models.User", "User")
                        .WithMany("UserChannels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.MessagesInTheChannel", b =>
                {
                    b.HasOne("Chat.Data.Entities.Models.Channel", null)
                        .WithMany("MessagesInTheChannel")
                        .HasForeignKey("ChannelId");

                    b.HasOne("Chat.Data.Entities.Models.ChannelUser", "ChannelUser")
                        .WithMany("MessagesInTheChannel")
                        .HasForeignKey("ChannelUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat.Data.Entities.Models.User", null)
                        .WithMany("MessagesInTheChannel")
                        .HasForeignKey("UserId");

                    b.Navigation("ChannelUser");
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.PrivateMessage", b =>
                {
                    b.HasOne("Chat.Data.Entities.Models.User", "UserReceived")
                        .WithMany()
                        .HasForeignKey("UserReceivedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chat.Data.Entities.Models.User", "UserSent")
                        .WithMany("DirectMessages")
                        .HasForeignKey("UserSentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserReceived");

                    b.Navigation("UserSent");
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.Channel", b =>
                {
                    b.Navigation("ChannelUsers");

                    b.Navigation("MessagesInTheChannel");
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.ChannelUser", b =>
                {
                    b.Navigation("MessagesInTheChannel");
                });

            modelBuilder.Entity("Chat.Data.Entities.Models.User", b =>
                {
                    b.Navigation("DirectMessages");

                    b.Navigation("MessagesInTheChannel");

                    b.Navigation("UserChannels");
                });
#pragma warning restore 612, 618
        }
    }
}
