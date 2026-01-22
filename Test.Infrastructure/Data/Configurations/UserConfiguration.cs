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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public const string UserPathForJson = "../Test.Infrastructure/JSONs/users.json";
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(SeedUser());
        }

        public List<User> SeedUser()
        {
            List<User> result = new();

            List<UserDTO> userDTOs = ReadJsonUsers();

            foreach (UserDTO userDTO in userDTOs)
            {
                User user = DTOsToUser(userDTO);

                result.Add(user);
            }

            return result;
        }

        public List<UserDTO> ReadJsonUsers()
        {
            string text = File.ReadAllText(UserPathForJson);

            List<UserDTO>? users = JsonSerializer.Deserialize<List<UserDTO>>(text);

            if (users == null || users.Count == 0)
            {
                throw new InvalidOperationException("Could not read user json file.");
            }

            return users;
        }

        public User DTOsToUser(UserDTO dto)
        {
            User user = new User();
            user.Id = dto.Id;
            user.UserName = dto.UserName;
            user.Avatar = dto.Avatar;
            user.Email = dto.Email;
            user.Bio = dto.Bio;
            user.CreatedAt = dto.CreatedAt;

            return user;
        }
    }
}
