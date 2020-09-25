using GrandBazar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.EntityConfigurations
{
    public class ChatMessageConfiguration : IEntityTypeConfiguration<ChatMessage>
    {
        public void Configure(EntityTypeBuilder<ChatMessage> chatMessage)
        {
            chatMessage
                    .Property(m => m.ReceiverName)
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
