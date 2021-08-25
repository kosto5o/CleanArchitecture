using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Models;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Infrastructure.Data.Context
{
    public class UniversityDbContextSeed
    {
        public static async Task SeedAsync(UniversityDbContext universityDbContext, ILogger<UniversityDbContextSeed> logger)
        {
            if (!universityDbContext.Courses.Any())
            {
                universityDbContext.Courses.AddRange(GetPreconfiguredCourses());
                await universityDbContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(UniversityDbContext).Name);
            }
        }

        private static IEnumerable<Course> GetPreconfiguredCourses()
        {
            return new List<Course>
            {
                new Course() { Name = "Physics", Description = "Intro", ImageUrl = "/images/1.jpg" },
                new Course() { Name = "Chemistry", Description = "Intro chem", ImageUrl = "/images/2.jpg" },
                new Course() { Name = "Mathematics", Description = "Intro Math", ImageUrl = "/images/3.jpg" }
            };
        }
    }
}
