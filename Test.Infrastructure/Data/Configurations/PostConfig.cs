using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Test.Infrastructure.Data.DTOs;
using Test.Infrastructure.Data.Model;

namespace Test.Infrastructure.Data.Configurations
{
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public const string PostJsonPath = "../Test.Infrastructure/JSONs/posts.json";
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(SeedPosts());
        }

        public List<Post> SeedPosts()
        {
            List<Post> result = new();

            List<PostDTO> postDTOs = ReadJson();

            foreach (PostDTO postDTO in postDTOs)
            {
                Post post = DTOsToPost(postDTO);

                result.Add(post);
            }

            return result;
        }

        public List<PostDTO> ReadJson()
        {
            string text = File.ReadAllText(PostJsonPath);

            List<PostDTO>? posts = JsonSerializer.Deserialize<List<PostDTO>>(text);

            if (posts == null || posts.Count == 0)
            {
                throw new InvalidOperationException("Could not read post json file.");
            }

            return posts;
        }

        public Post DTOsToPost(PostDTO dto)
        {
            Post post = new Post();
            post.Id = dto.Id;
            post.Content = dto.Content;
            post.CreatedAt = dto.CreatedAt;
            if (dto.Image == null)
            {
                post.Image = string.Empty;
            }
            else
            {
                post.Image = dto.Image;
            }
                post.UserId = dto.UserId;

            return post;
        }
    }
}
