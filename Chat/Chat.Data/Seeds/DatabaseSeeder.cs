using Microsoft.EntityFrameworkCore;
using Chat.Data.Entities.Models;

namespace Chat.Data.Seeds
{
    public  class DatabaseSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new List<User>
                {
                new User("luce@pmf.st", "1234")
                {
                    Id = 1,
                    IsAdmin = true,
                },
                new User("ana@fesb.hr", "12345")
                {
                    Id = 2,
                },
                new User("paula@fesb.hr", "lucijalucija")
                {
                    Id = 3,
                },
                new User("josip@fesb.hr", "4321")
                {
                    Id = 4,
                },
                new User("jurin@efst.hr", "01.12.")
                {
                    Id = 5,
                },
                new User("gabi@fesb.hr", "fesb")
                {
                    Id = 6,
                },
                new User("nada@mefst.hr", "sokol")
                {
                    Id = 7,
                },
                });

            builder.Entity<Channel>()
                .HasData(new List<Channel>
                {
                new Channel("Da van se zalin malo")
                {
                    Id = 1,
                },
                new Channel("Goz")
                {
                    Id = 2,
                },
                new Channel("Parizzz")
                {
                    Id = 3,
                },
                new Channel("Girls")
                {
                    Id = 4,
                }
                });

             builder.Entity<PrivateMessage>()
                .HasData(new List<PrivateMessage>
                {
                new PrivateMessage()
                {
                    Id = 1,
                    TimeSent = new DateTime(2017, 6, 23, 0, 0, 10, DateTimeKind.Utc),
                    Content = "Sretan rodendan sunce Voli  te puuuuno",
                    UserSentId = 1,
                    UserReceivedId=3,
                },
                new PrivateMessage()
                {
                    Id = 2,
                    TimeSent = new DateTime(2017, 6, 23, 0, 1, 10, DateTimeKind.Utc),
                    Content = "hvala tii",
                    UserSentId = 3,
                    UserReceivedId=1,
                },
                new PrivateMessage()
                {
                    Id = 3,
                    TimeSent = new DateTime(2017, 7, 24, 0, 0, 10, DateTimeKind.Utc),
                    Content = "Sretan rockas Love you",
                    UserSentId = 3,
                    UserReceivedId=1,
                },
                new PrivateMessage()
                {
                    Id = 4,
                    TimeSent = new DateTime(2017, 7, 24, 0, 5, 10, DateTimeKind.Utc),
                    Content = "Hvala tiiii",
                    UserSentId = 1,
                    UserReceivedId=3,
                },
                new PrivateMessage()
                {
                    Id = 5,
                    TimeSent = new DateTime(2023, 8, 27, 2, 7, 10, DateTimeKind.Utc),
                    Content = "Opet me zaustavila policija",
                    UserSentId = 4,
                    UserReceivedId=1,
                },
                new PrivateMessage()
                {
                    Id = 6,
                    TimeSent = new DateTime(2023, 8, 27, 2, 7, 30, DateTimeKind.Utc),
                    Content = "Naplatili su mi kaznu zbog registracije",
                    UserSentId = 4,
                    UserReceivedId=1,
                },
                new PrivateMessage()
                {
                    Id = 7,
                    TimeSent = new DateTime(2023, 8, 27, 2, 31, 10, DateTimeKind.Utc),
                    Content = "Nemoj me zezat",
                    UserSentId = 1,
                    UserReceivedId=4,
                }
                });

            builder.Entity<ChannelUser>()
                .HasData(new List<ChannelUser>
                {
                new ChannelUser
                {
                    Id = 1,
                    ChannelId= 1,
                    UserId= 1,
                },
                new ChannelUser
                {
                    Id = 2,
                    ChannelId= 1,
                    UserId= 3,
                },
                new ChannelUser
                {
                    Id = 3,
                    ChannelId= 1,
                    UserId= 6,
                },
                new ChannelUser
                {
                    Id = 4,
                    ChannelId= 2,
                    UserId= 1,
                },
                new ChannelUser
                {
                    Id = 5,
                    ChannelId= 2,
                    UserId= 3,
                },
                new ChannelUser
                {
                    Id = 6,
                    ChannelId= 2,
                    UserId= 5,
                },
                new ChannelUser
                {
                    Id = 7,
                    ChannelId= 3,
                    UserId= 1,
                },
                new ChannelUser
                {
                    Id = 8,
                    ChannelId= 3,
                    UserId= 2,
                },
                new ChannelUser
                {
                    Id = 9,
                    ChannelId= 3,
                    UserId= 3,
                },
                new ChannelUser
                {
                    Id = 10,
                    ChannelId= 3,
                    UserId= 6,
                },
                new ChannelUser
                {
                    Id = 11,
                    ChannelId= 4,
                    UserId= 1,
                },
                new ChannelUser
                {
                    Id = 12,
                    ChannelId= 4,
                    UserId= 3,
                },
                new ChannelUser
                {
                    Id = 13,
                    ChannelId= 4,
                    UserId= 7,
                },
                });

            builder.Entity<MessagesInTheChannel>()
                .HasData(new List<MessagesInTheChannel>
                {
                new MessagesInTheChannel()
                {
                    Id = 1,
                    TimeSent = new DateTime(2023,11, 10, 22, 18, 10, DateTimeKind.Utc),
                    Content = "Fun fact",
                    ChannelUserId = 1,
                },
                new MessagesInTheChannel()
                {
                    Id = 2,
                    TimeSent = new DateTime(2023,11, 10, 22, 18, 10, DateTimeKind.Utc),
                    Content = "Pukla mi je cizme",
                    ChannelUserId = 1,
                },
                new MessagesInTheChannel()
                {
                    Id = 3,
                    TimeSent = new DateTime(2023,11, 10, 22, 18, 10, DateTimeKind.Utc),
                    Content = "",
                    ChannelUserId = 1,
                },
                new MessagesInTheChannel()
                {
                    Id = 4,
                    TimeSent = new DateTime(2023,11, 10, 22, 18, 10, DateTimeKind.Utc),
                    Content = "Josip je dozivia tu svadu",
                    ChannelUserId = 1,
                },
                new MessagesInTheChannel()
                {
                    Id = 5,
                    TimeSent = new DateTime(2023,11, 10, 22, 18, 10, DateTimeKind.Utc),
                    Content = "Al kupuje mi nove",
                    ChannelUserId = 1,
                },
                new MessagesInTheChannel()
                {
                    Id = 6,
                    TimeSent = new DateTime(2023,11, 10, 22, 21, 10, DateTimeKind.Utc),
                    Content = "bro",
                    ChannelUserId = 2,
                },
                new MessagesInTheChannel()
                {
                    Id = 7,
                    TimeSent = new DateTime(2023,11, 10, 22, 21, 10, DateTimeKind.Utc),
                    Content = "kako ih je pukla",
                    ChannelUserId = 2,
                },
                new MessagesInTheChannel()
                {
                    Id = 8,
                    TimeSent = new DateTime(2023,11, 10, 22, 35, 10, DateTimeKind.Utc),
                    Content = "STA",
                    ChannelUserId = 3,
                },
                new MessagesInTheChannel()
                {
                    Id = 9,
                    TimeSent = new DateTime(2023, 4, 16, 10, 10, 10, DateTimeKind.Utc),
                    Content = "Jel iko od vas auto",
                    ChannelUserId = 4,
                },
                new MessagesInTheChannel()
                {
                    Id = 10,
                    TimeSent = new DateTime(2023, 4, 16, 10, 12, 10, DateTimeKind.Utc),
                    Content = "Ja vas mogu skupit",
                    ChannelUserId = 6,
                },
                new MessagesInTheChannel()
                {
                    Id = 11,
                    TimeSent = new DateTime(2023, 4, 16, 10, 13, 10, DateTimeKind.Utc),
                    Content = "ma ja cu ic",
                    ChannelUserId = 5,
                },
                new MessagesInTheChannel()
                {
                    Id = 12,
                    TimeSent = new DateTime(2023, 4, 16, 10, 13, 10, DateTimeKind.Utc),
                    Content = "ne kasni mi se",
                    ChannelUserId = 5,
                },
                new MessagesInTheChannel()
                {
                    Id = 13,
                    TimeSent = new DateTime(2023, 4, 16, 10, 13, 30, DateTimeKind.Utc),
                    Content = "Nece ti nista bit ako jednom zakasnis",
                    ChannelUserId = 6,
                },
                new MessagesInTheChannel()
                {
                    Id = 14,
                    TimeSent = new DateTime(2023, 4, 16, 10, 14, 10, DateTimeKind.Utc),
                    Content = "ma ne zelin kasnit",
                    ChannelUserId = 5,
                },
                new MessagesInTheChannel()
                {
                    Id = 15,
                    TimeSent = new DateTime(2023, 4, 16, 10, 14, 10, DateTimeKind.Utc),
                    Content = "Kad me kupis",
                    ChannelUserId = 4,
                },
                new MessagesInTheChannel()
                {
                    Id = 16,
                    TimeSent = new DateTime(2022, 10, 1, 14, 13, 10, DateTimeKind.Utc),
                    Content = "kakav nan je apartman",
                    ChannelUserId = 9,
                },
                new MessagesInTheChannel()
                {
                    Id = 17,
                    TimeSent = new DateTime(2022, 10, 1, 14, 13, 18, DateTimeKind.Utc),
                    Content = "i luci se ugasia mob",
                    ChannelUserId = 9,
                },
                new MessagesInTheChannel()
                {
                    Id = 18,
                    TimeSent = new DateTime(2022, 10, 1, 14, 14, 10, DateTimeKind.Utc),
                    Content = "Standardno",
                    ChannelUserId = 8,
                },
                new MessagesInTheChannel()
                {
                    Id = 19,
                    TimeSent = new DateTime(2022, 10, 1, 14, 16, 10, DateTimeKind.Utc),
                    Content = "predobro je",
                    ChannelUserId = 10,
                },
                new MessagesInTheChannel()
                {
                    Id = 20,
                    TimeSent = new DateTime(2022, 10, 1, 14, 16, 23, DateTimeKind.Utc),
                    Content = "ima masu prostpra",
                    ChannelUserId = 10,
                },
                new MessagesInTheChannel()
                {
                    Id = 21,
                    TimeSent = new DateTime(2023, 8, 15, 20, 00, 10, DateTimeKind.Utc),
                    Content = "jel mogu napisat",
                    ChannelUserId = 12,
                },
                new MessagesInTheChannel()
                {
                    Id = 22,
                    TimeSent = new DateTime(2023, 8, 15, 20, 00, 10, DateTimeKind.Utc),
                    Content = "pala je na thirst trap",
                    ChannelUserId = 12,
                },
                new MessagesInTheChannel()
                {
                    Id = 23,
                    TimeSent = new DateTime(2023, 8, 15, 20, 01, 10, DateTimeKind.Utc),
                    Content = "Zato ne smin lajkat sliku",
                    ChannelUserId = 11,
                },
                new MessagesInTheChannel()
                {
                    Id = 24,
                    TimeSent = new DateTime(2023, 8, 15, 20, 02, 10, DateTimeKind.Utc),
                    Content = "I pisi sta oces",
                    ChannelUserId = 11,
                },
                new MessagesInTheChannel()
                {
                    Id = 25,
                    TimeSent = new DateTime(2023, 8, 15, 20, 03, 10, DateTimeKind.Utc),
                    Content = "hvala",
                    ChannelUserId = 12,
                },
                new MessagesInTheChannel()
                {
                    Id = 26,
                    TimeSent = new DateTime(2023, 8, 15, 20, 04, 10, DateTimeKind.Utc),
                    Content = "Al ces mi poslat sta odg",
                    ChannelUserId = 11,
                },
                });
        }
    }
}
