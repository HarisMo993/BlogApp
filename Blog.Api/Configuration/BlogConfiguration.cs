using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Api.Database;

namespace Blog.Api.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            List<string> listOfTags1 = new List<string>() { "iOS", "AR" };
            List<string> listOfTags2 = new List<string>() { "iOS", "AR", "Gazzda" };


            builder.HasData(
                    new Post
                    {
                        Id = 1,
                        Slug = "augmented-reality-ios-application",
                        Title = "Augmented Reality iOS Application",
                        Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                        Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                        CreatedAt = new DateTime(),
                        UpdateAt = new DateTime(),
                        tags = JsonConvert.SerializeObject(listOfTags1)
                    },
                    new Post
                    {
                        Id = 2,
                        Slug = "augmented-reality-ios-application-2",
                        Title = "Augmented Reality iOS Application 2",
                        Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                        Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                        CreatedAt = new DateTime(),
                        UpdateAt = new DateTime(),
                        tags = JsonConvert.SerializeObject(listOfTags1)
                    },
                    new Post
                    {
                        Id = 3,
                        Slug = "augmented-reality-ios-application-3",
                        Title = "Augmented Reality iOS Application 3",
                        Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                        Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                        CreatedAt = new DateTime(),
                        UpdateAt = new DateTime(),
                        tags = JsonConvert.SerializeObject(listOfTags2)
                    }
                );
        }
    }
}
