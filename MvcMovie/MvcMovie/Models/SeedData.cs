using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Password.Any())
                {
                    return;
                }

                context.Password.AddRange(
                    new Password
                    {
                        Id = "Polina",
                        Website = "www.pinterest.ru",
                        Login = "Polina",
                        Passwords = "123"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}