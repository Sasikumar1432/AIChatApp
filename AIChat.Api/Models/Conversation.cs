namespace AIChat.Api.Models;

public class Conversation
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public List<ChatMessage> Messages { get; set; } = new();
}