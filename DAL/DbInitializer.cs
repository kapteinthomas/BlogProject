using System;
using System.Linq;
using Blog.Models;

namespace Blog.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            if (context.BlogPosts.Any())
            {
                Console.WriteLine("No need to seed. DB has entities");
                return; //DB hase been seeded
            }

            Console.WriteLine("Seeding Database!");
            var blogPosts = new BlogPost[] 
            {
                new BlogPost{Title="Exam",Content="Today I had my statistics and probability exam. It wen well.",PostDate=DateTime.Parse("2021-05-26"),Likes=5},
                new BlogPost{Title="Started working on Blog engine",Content="Practicing my ASP.NET and React skills, by making a blog engine.",PostDate=DateTime.Now}
            };

            context.BlogPosts.AddRange(blogPosts);
            context.SaveChanges();

            var comments = new Comment[]
            {
                new Comment{BlogID=1, PostDate=DateTime.Parse("2021-05-27"), Content="Congrats!", Likes=1}
            };

            context.Comments.AddRange(comments);
            context.SaveChanges();

        }
    }
}