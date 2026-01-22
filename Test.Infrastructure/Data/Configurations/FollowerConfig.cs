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
    public class FollowerConfig : IEntityTypeConfiguration<Follower>
    {
        public const string PathToFollowerJson = "../Test.Infrastructure/JSONs/followers.json";
        public void Configure(EntityTypeBuilder<Follower> builder)
        {
            builder.HasOne(um => um.FollowerUser)
                .WithMany()
                .HasForeignKey(um => um.FollowerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(um => um.FollowingUser)
                .WithMany()
                .HasForeignKey(um => um.FollowingId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(SeedFollowers());
        }

        public List<Follower> SeedFollowers()
        {
            List<Follower> result = new();

            List<FollowerDTO> followerDTOs = ReadJson();

            foreach (FollowerDTO followerDTO in followerDTOs)
            {
                Follower follower = DTOsToFollower(followerDTO);

                result.Add(follower);
            }

            return result;
        }

        public List<FollowerDTO> ReadJson()
        {
            string text = File.ReadAllText(PathToFollowerJson);

            List<FollowerDTO>? followers = JsonSerializer.Deserialize<List<FollowerDTO>>(text);

            if (followers == null || followers.Count == 0)
            {
                throw new InvalidOperationException("Could not read message json file.");
            }

            return followers;
        }

        public Follower DTOsToFollower(FollowerDTO dto)
        {
            Follower follower = new Follower();
            follower.Id = dto.Id;
            follower.FollowerId = dto.FollowerId;
            follower.FollowingId = dto.FollowingId;
            follower.CreatedAt = dto.CreatedAt;

            return follower;
        }
    }
}
