using AIChat.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AIChat.Api.Data;

public class ChatDbContext : DbContext
{
    public ChatDbContext(DbContextOptions<ChatDbContext> options)
        : base(options)
    {
    }

    public DbSet<Conversation> Conversations =>
        Set<Conversation>();

    public DbSet<ChatMessage> ChatMessages =>
        Set<ChatMessage>();
}