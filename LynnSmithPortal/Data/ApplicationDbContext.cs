using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LynnSmithPortal.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LynnSmithPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> //We want to user the application user to extend identityUser fields
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets for each model we have
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var stringListComparer = new ValueComparer<List<string>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList()
            );

            // Handle prerequisite string list as comma-separated strings with a value comparer
            modelBuilder.Entity<Course>()
                .Property(c => c.PrerequisiteCourses)
                .HasConversion(
                    v => string.Join(',', v), // Convert List<string> to string for storage
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Convert string back to List<string>
                )
                .Metadata
                .SetValueComparer(stringListComparer);  // Set the value comparer here

            // Set up many-to-many relationship for CourseEnrollments
            modelBuilder.Entity<CourseEnrollment>()
                .HasKey(e => new { e.CourseEnrollmentId });

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.CourseEnrollments)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.CourseEnrollments)
                .HasForeignKey(e => e.StudentId);
        }
    }
}
