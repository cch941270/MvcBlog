using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBlog.Data;
using System;
using System.Linq;

namespace MvcBlog.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBlogContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBlogContext>>()))
        {
            // Look for any Blogs.
            if (context.Blog.Any())
            {
                return;   // DB has been seeded
            }
            context.Blog.AddRange(
                new Blog
                {
                    Title = "John Wick: Chapter 3 Parabellum",
                    Content = "Si vis pacem, para bellum",
                    CreateDate = DateTime.Today,
                    UpdateDate = DateTime.Today,
                },
                new Blog
                {
                    Title = "Star Trek",
                    Content = "Beam me up, Scotty",
                    CreateDate = DateTime.Today,
                    UpdateDate = DateTime.Today,
                },
                new Blog
                {
                    Title = "Harry Potter",
                    Content = "Expecto Patronum",
                    CreateDate = DateTime.Today,
                    UpdateDate = DateTime.Today,
                },
                new Blog
                {
                    Title = "Nobody",
                    Content = "Make a short story long",
                    CreateDate = DateTime.Today,
                    UpdateDate = DateTime.Today,
                }
            );
            context.SaveChanges();
        }
    }
}