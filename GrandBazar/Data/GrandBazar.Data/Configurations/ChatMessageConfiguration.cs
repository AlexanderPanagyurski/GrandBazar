namespace GrandBazar.Data.Configurations
{
    using GrandBazar.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ChatMessageConfiguration : IEntityTypeConfiguration<ChatMessage>
    {
        public void Configure(EntityTypeBuilder<ChatMessage> chatMessage)
        {
            chatMessage
                    .Property(m => m.ReceiverName)
                    .IsUnicode(true);

            chatMessage
                    .Property(m => m.SenderName)
                    .IsUnicode(true);

            chatMessage
                    .Property(m => m.Content)
                    .IsUnicode(true);

            chatMessage
                    .HasOne(m => m.User)
                    .WithMany(u => u.ChatMessages)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
