using Domain.Entities;
using Domain.Interfaces.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Domain.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAcess.Contexts
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Comment>()
                 .HasOne(x => x.Duty)
                 .WithMany(x => x.Comments)
                 .HasForeignKey(x => x.DutyId);

            #region Task
            modelBuilder.Entity<Duty>().HasData(
                new { Id = 1, Title = "First Task", CreatedDate = DateTime.Now, RequiredBy = DateTime.Now, Description = "Description of First Task", Status = DutyStatus.Assigned, Type = DutyType.Duty , NextActionDate = DateTime.Now.AddDays(2) , AssignedTo =UserList.vahit});
            modelBuilder.Entity<Duty>().HasData(
            new { Id = 2, Title = "Second Task", CreatedDate = DateTime.Now, RequiredBy = DateTime.Now, Description = "Description of Second Task", Status = DutyStatus.InProcess, Type = DutyType.Duty , NextActionDate = DateTime.Now.AddDays(2), AssignedTo = UserList.Sara});
            modelBuilder.Entity<Duty>().HasData(
               new { Id = 3, Title = "Tirth Task", CreatedDate = DateTime.Now, RequiredBy = DateTime.Now, Description = "Description of Tirth Task", Status = DutyStatus.Done, Type = DutyType.Bug, NextActionDate = DateTime.Now.AddDays(2), AssignedTo = UserList.sevda });
            modelBuilder.Entity<Duty>().HasData(
            new { Id = 4, Title = "Forth Task", CreatedDate = DateTime.Now, RequiredBy = DateTime.Now, Description = "Description of Forth Task", Status = DutyStatus.Canceld, Type = DutyType.UserStory, NextActionDate = DateTime.Now.AddDays(2), AssignedTo = UserList.hadi});

            #endregion


            #region Comment
            modelBuilder.Entity<Comment>().HasData(
                new { Id = 1, DutyId = 1, Title = "First Comment", AddedDate = DateTime.Now, RequiredBy = DateTime.Now, CommentText = "CommentText of First Task", Type = CommentType.DutyType, ReminderDate=DateTime.Now.AddDays(2) });
            modelBuilder.Entity<Comment>().HasData(
            new { Id = 2, DutyId = 2, Title = "Second Comment", AddedDate = DateTime.Now, RequiredBy = DateTime.Now, CommentText = "CommentText of Second Task", Type = CommentType.DutyType1, ReminderDate = DateTime.Now.AddDays(2) });
            modelBuilder.Entity<Comment>().HasData(
               new { Id = 3, DutyId = 3, Title = "Tirth Comment", AddedDate = DateTime.Now, RequiredBy = DateTime.Now, CommentText = "CommentText of Tirth Task", Type = CommentType.DutyType, ReminderDate = DateTime.Now.AddDays(2) });
            modelBuilder.Entity<Comment>().HasData(
            new { Id = 4, DutyId = 4, Title = "Forth Comment", AddedDate = DateTime.Now, RequiredBy = DateTime.Now, CommentText = "CommentText of Forth Task", Type = CommentType.DutyType1, ReminderDate = DateTime.Now.AddDays(2) });

            #endregion


        }


        public DbSet<Duty> Duties { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public IDbConnection Connection => Database.GetDbConnection();

    }
}
