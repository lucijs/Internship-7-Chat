using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Chat.Data.Entities.Models;
using Chat.Data.Seeds;

namespace Chat.Data.Entities;
public class ChatDbContext: DbContext
{
    public ChatDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Channel> Channels => Set<Channel>();
    public DbSet<User> Users => Set<User>();
    public DbSet<ChannelUser> ChannelUsers => Set<ChannelUser>();
    public DbSet<MessagesInTheChannel> MessagesInTheChannel => Set<MessagesInTheChannel>();

    public DbSet<PrivateMessage> PrivateMessages => Set<PrivateMessage>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChannelUser>()
            .HasOne(c => c.Channel)
            .WithMany(c=> c.ChannelUsers)
            .HasForeignKey(cu => cu.ChannelId);

        modelBuilder.Entity<ChannelUser>()
            .HasOne(u => u.User)
            .WithMany(u => u.UserChannels)
            .HasForeignKey(cu => cu.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PrivateMessage>()
            .HasOne(u => u.UserSent)
            .WithMany(pm => pm.PrivateMessages)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<MessagesInTheChannel>()
            .HasOne(c => c.ChannelUser)
            .WithMany(mc => mc.MessagesInTheChannel)
            .HasForeignKey(mc => mc.ChannelUserId)
            .OnDelete(DeleteBehavior.Cascade);

        DatabaseSeeder.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
}

public class TodoAppDbContextFactory : IDesignTimeDbContextFactory<ChatDbContext>
{
    public ChatDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddXmlFile("App.config")
            .Build();

        config.Providers
            .First()
            .TryGet("connectionStrings:add:Chat:connectionString", out var connectionString);

        var options = new DbContextOptionsBuilder<ChatDbContext>()
            .UseNpgsql(connectionString)
            .Options;

        return new ChatDbContext(options);
    }
}

