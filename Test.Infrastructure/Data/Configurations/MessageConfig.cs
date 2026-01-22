using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Test.Infrastructure.Data.DTOs;
using Test.Infrastructure.Data.Model;

namespace Test.Infrastructure.Data.Configurations
{
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public const string PathToMessageJson = "../Test.Infrastructure/JSONs/messages.json";
        public void Configure(EntityTypeBuilder<Message> builder)
        {

            builder
                .HasOne(um => um.Sender)
                .WithMany()
                .HasForeignKey(um => um.SenderId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(um => um.Receiver)
                .WithMany()
                .HasForeignKey(um => um.ReceiverId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(SeedMessages());
        }

        public List<Message> SeedMessages()
        {
            List<Message> result = new();

            List<MessageDTO> messageDTOs = ReadJson();

            foreach (MessageDTO messageDTO in messageDTOs)
            {
                Message message = DTOsToMessage(messageDTO);

                result.Add(message);
            }

            return result;
        }

        public List<MessageDTO> ReadJson()
        {
            string text = File.ReadAllText(PathToMessageJson);

            List<MessageDTO>? messages = JsonSerializer.Deserialize<List<MessageDTO>>(text);

            if (messages == null || messages.Count == 0)
            {
                throw new InvalidOperationException("Could not read message json file.");
            }

            return messages;
        }

        public Message DTOsToMessage(MessageDTO dto)
        {
            Message message = new Message();
            message.SenderId = dto.SenderId;
            message.ReceiverId = dto.ReceiverId;
            message.Id = dto.Id;
            message.Content = dto.Content;
            message.CreatedAt = dto.CreatedAt;
            message.Read = dto.Read;

            return message;
        }
    }
}
