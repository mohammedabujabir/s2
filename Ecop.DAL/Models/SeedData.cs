using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    internal class SeedData
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            // تعريف الأدوار (Roles)
            var roles = new[]
            {
            new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "2", Name = "Citizen", NormalizedName = "CITIZEN" },
            new IdentityRole { Id = "3", Name = "Police", NormalizedName = "POLICE" },
            new IdentityRole { Id = "4", Name = "Judge", NormalizedName = "JUDGE" }
        };

            // تعريف المستخدمين (ApplicationUsers)
            var users = new[]
            {
            new ApplicationUser
            {
                Id = "1",
                UserName = "AdminUser",
                NormalizedUserName = "ADMINUSER",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@Gmail.COM",
                PasswordHash = "Admin@123"
            },
            new ApplicationUser
            {
                Id = "2",
                UserName = "CitizenUser1",
                NormalizedUserName = "CITIZENUSER1",
                Email = "citizen1@gmail.com",
                NormalizedEmail = "CITIZEN1@Gmail.COM",
                PasswordHash = "Citizen@123"
            },
            new ApplicationUser
            {
                Id = "3",
                UserName = "CitizenUser2",
                NormalizedUserName = "CITIZENUSER2",
                Email = "citizen@gmail.com",
                NormalizedEmail = "CITIZEN2@Gmail.COM",
                PasswordHash = "Citizen@123"
            },
            new ApplicationUser
            {
                Id = "4",
                UserName = "PoliceUser1",
                NormalizedUserName = "POLICEUSER1",
                Email = "police1@gmail.com",
                NormalizedEmail = "POLICE1@Gmail.COM",
                PasswordHash = "Police@123"
            },
            new ApplicationUser
            {
                Id = "5",
                UserName = "PoliceUser2",
                NormalizedUserName = "POLICEUSER2",
                Email = "police2@gmail.com",
                NormalizedEmail = "POLICE2@Gmail.COM",
                PasswordHash = "Police@123"
            },
            new ApplicationUser
            {
                Id = "6",
                UserName = "JudgeUser1",
                NormalizedUserName = "JUDGEUSER1",
                Email = "judge1@gmail.com",
                NormalizedEmail = "JUDGE1@Gmail.COM",
                PasswordHash = "Judge@123"
            },
            new ApplicationUser
            {
                Id = "7",
                UserName = "JudgeUser2",
                NormalizedUserName = "JUDGEUSER2",
                Email = "judge2@gmail.com",
                NormalizedEmail = "JUDGE2@Gmail.COM",
                PasswordHash = "Judge@123"
            }
        };

            // ربط المستخدمين بالأدوار (UserRole)
            var userRoles = new[]
            {
            new { UserId = "1", RoleId = "1" }, // AdminUser -> Admin
            new { UserId = "2", RoleId = "2" }, // CitizenUser1 -> Citizen
            new { UserId = "3", RoleId = "2" }, // CitizenUser2 -> Citizen
            new { UserId = "4", RoleId = "3" }, // PoliceUser1 -> Police
            new { UserId = "5", RoleId = "3" }, // PoliceUser2 -> Police
            new { UserId = "6", RoleId = "4" }, // JudgeUser1 -> Judge
            new { UserId = "7", RoleId = "4" }  // JudgeUser2 -> Judge
        };

            // بيانات المواطنين (Citizens)
            var citizens = new[]
            {
            new {CitizenId = 1, Name = "Mohammed",Email="mohammed@gmail.com",Phone="0568089936",Address="jenin",Password="Mohammed@123",Camera_id="CAM123",UserId = "2" },
           new { CitizenId = 2, Name = "Noor",Email="noor@gmail.com",Phone="0568086536",Address="jenin",Password="Noor@123",Camera_id="CAM123",UserId = "3" }
        };

            // بيانات الشرطة (PoliceOfficers)
            var policeOfficers = new[]
            {
            new { PolicemanId = 1, Name = "Mahdi",Badge_Number="123",Email="mahdi@gmail.com",Phone="0599086536",Password="Mahdi@123", UserId = "4" },
            new {PolicemanId = 2, Name = "Ali",Badge_Number="1521",Email="ali@gmail.com",Phone="0599086777",Password="Ali@123", UserId = "5" }
        };

            // بيانات القضاة (Judges)
            var judges = new[]
            {
            new { JudgeId = 1, Name = "Hadi",Email="hadi@gmail.com",Phone="0598086536",Address="jenin",Password="Hadi@123", UserId = "6" },
            new { JudgeId = 2, Name = "Braa",Email="braa@gmail.com",Phone="0528086536",Address="nablus",Password="Braa@123", UserId = "7" },
        };

            // إضافة البيانات إلى الجداول
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            modelBuilder.Entity<ApplicationUser>().HasData(users);
            modelBuilder.Entity<Citizen>().HasData(citizens);
            modelBuilder.Entity<Policeman>().HasData(policeOfficers);
            modelBuilder.Entity<Judge>().HasData(judges);
        }





    }
}
