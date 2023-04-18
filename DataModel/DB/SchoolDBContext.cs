using DataModel.Entity;
using DataModel.Entity.EntityEShop;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataModel.DB
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                    .HasIndex(p => p.Email)
                    .IsUnique();

            modelBuilder.Entity<School>()
                   .HasIndex(s => new { s.Code })
                   .IsUnique(true);
            
            modelBuilder.Entity<SchoolYear>()
                .HasIndex(s => new { s.Year })
                .IsUnique(true);

            modelBuilder.Entity<Product>()
                .HasIndex(p => new { p.Code })
                .IsUnique(true);

            modelBuilder.Entity<Category>()
                .HasIndex(c => new { c.Code })
                .IsUnique(true);

            modelBuilder.Entity<Promotion>()
                .HasIndex(p => new { p.Code})
                .IsUnique(true);

            modelBuilder.Entity<Enroll>()
                .HasIndex(e => new { e.UserId, e.CourseId })
                .IsUnique();

            modelBuilder.Entity<Score>()
                .HasIndex(s => new { s.EnrollmentID, s.AssessmentID })
                .IsUnique();

            modelBuilder.Entity<Prerequisite>()
                .HasIndex(p => new { p.CourseID, p.PrerequisiteCourseId })
                .IsUnique();

            modelBuilder.Entity<CourseSubject>()
              .HasKey(co => new { co.CourseId, co.SubjectId });

            modelBuilder.Entity<UserRole>()
              .HasKey(ur => new { ur.UserId, ur.RoleId});

            modelBuilder.Entity<Subject>()
               .HasMany(s => s.Assessment).WithOne(s => s.Subject).IsRequired().OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CourseSubject>()
                .HasOne(c => c.Subject).WithMany(s => s.CourseSubject).IsRequired().OnDelete(DeleteBehavior.Cascade);


            /*.HasOne(pt => pt.CourseSubject).WithMany(p => p.c).IsRequired().OnDelete(DeleteBehavior.Cascade);
            .HasOne(pt => pt.Subject).WithMany(p => p.Assessment).IsRequired().OnDelete(DeleteBehavior.NoAction);*/



            // The following fluent API would set a restrict rule and disable cascade delete.

            //modelBuilder.Entity<Department>()
            //    .HasOne(d => d.Administrator)
            //    .WithMany()
            //    .OnDelete(DeleteBehavior.Restrict)

            ModelBuilderExt.SeedRole(modelBuilder);
            ModelBuilderExt.SeedUserType(modelBuilder);
            ModelBuilderExt.SeedUser(modelBuilder);
            ModelBuilderExt.SeedUserRoles(modelBuilder);
            ModelBuilderExt.SeedSchool(modelBuilder);
            ModelBuilderExt.SeedTerm(modelBuilder);
            ModelBuilderExt.SeedSchoolYear(modelBuilder);
            ModelBuilderExt.SeedClassRoom(modelBuilder);
            ModelBuilderExt.SeedCourse(modelBuilder);
            ModelBuilderExt.SeedSubject(modelBuilder); 
            ModelBuilderExt.SeedCourseSubject(modelBuilder);
            ModelBuilderExt.SeedAssessment(modelBuilder);
            ModelBuilderExt.SeedPrerequisite(modelBuilder);
            ModelBuilderExtEShop.SeedCategory(modelBuilder);
            ModelBuilderExtEShop.SeedSupplier(modelBuilder);
            ModelBuilderExtEShop.SeedProductUnit(modelBuilder);
            ModelBuilderExtEShop.SeedProduct(modelBuilder);
            ModelBuilderExtEShop.SeedProductImage(modelBuilder);
        }


        public virtual DbSet<User> User { get; set; } = null!;
        public virtual DbSet<Role> Role { get; set; } = null!;
        public virtual DbSet<School> School { get; set; } = null!;
        public virtual DbSet<SchoolYear> SchoolYear { get; set; } = null!;
        public virtual DbSet<Course> Course { get; set; } = null!;
        public virtual DbSet<Subject> Subject { get; set; } = null!;    
        public virtual DbSet<RefreshToken> RefreshToken { get; set; } = null!;
        public virtual DbSet<UserType> UserType { get; set; } = null!;
        public virtual DbSet<Assessment> Assessment { get; set; } = null!;
        public virtual DbSet<CourseSubject> CourseSubject { get; set; } = null!;
        public virtual DbSet<Enroll> Enroll { get; set; } = null!;
        public virtual DbSet<Score> Score { get; set; } = null!;
        public virtual DbSet<Prerequisite> Prerequisite { get; set; } = null!;

        public virtual DbSet<Product> Product { get; set; } = null!;
        public virtual DbSet<Category> Category { get; set; } = null!;
        public virtual DbSet<Supplier> Supplier { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImage { get; set; } = null!;
        public virtual DbSet<Promotion> Promotion { get; set; } = null!;
        public virtual DbSet<ProductUnit> ProductUnit { get; set; } = null!;
        public virtual DbSet<CartItem> CartItem { get; set; } = null!;
        public virtual DbSet<Payment> Payment { get; set; } = null!;
        public virtual DbSet<Customer> Customer { get; set; } = null!;

    }
}
