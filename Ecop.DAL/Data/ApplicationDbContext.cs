using Ecop.DAL.Models;
using Ecop.PL.Data.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Ecop.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<Judge> Judges { get; set; }
        public DbSet<Policeman> Policemans { get; set; }
        public DbSet<TrafficViolation> TrafficViolations { get; set; }
        public DbSet<CourtDecisions> CourtDecisions { get; set; }
        public DbSet<PolicemanDecision> PolicemanDecisions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          

            builder.Entity<Car>()
             .HasOne(c => c.Citizen)  // علاقة "One-to-Many" من Car إلى Citizen
             .WithMany(citizen => citizen.Cars)  // كل Citizen يمكنه امتلاك العديد من السيارات
             .HasForeignKey(c => c.CitizenId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TrafficViolation>()
            .HasOne(c => c.Citizen)  // الشكوى تكون مرتبطة بمواطن واحد
            .WithMany(c => c.TrafficViolations)  // كل مواطن يمكنه تقديم العديد من الشكاوى
            .HasForeignKey(c => c.CitizenId).OnDelete(DeleteBehavior.Cascade);  // المفتاح الأجنبي الذي يشير إلى المواطن
            builder.Entity<PolicemanDecision>()
              .HasOne(d => d.Policeman)  // القرار مرتبط بشرطي واحد فقط
              .WithMany(o => o.Decisions)  // الشرطي يمكنه تقديم عدة قرارات
              .HasForeignKey(d => d.PolicemanDecisionId).OnDelete(DeleteBehavior.Cascade);  // المفتاح الأجنبي المرتبط بالشرطي
            builder.Entity<TrafficViolation>()
               .HasOne(v => v.Decision)  // كل مخالفة مرتبطة بقرار واحد فقط
               .WithOne(d => d.TrafficViolation)  // وكل قرار مرتبط بمخالفة واحدة فقط
               .HasForeignKey<TrafficViolation>(v => v.DecisionId);  // المفتاح الأجنبي في المخالفة
            builder.Entity<PolicemanDecision>()
               .HasOne(d => d.TrafficViolation)  // كل قرار مرتبط بمخالفة واحدة فقط
               .WithOne(v => v.Decision)  // وكل مخالفة مرتبطة بقرار واحد فقط
               .HasForeignKey<PolicemanDecision>(d => d.Violationid);  // المفتاح الأجنبي في القرار




            // تحديد العلاقة One-to-Many بين Court و JudicialDecision
            builder.Entity<CourtDecisions>()
                .HasOne(jd => jd.Court)  // القرار مرتبط بمحكمة واحدة فقط
                .WithMany(c => c.CourtDecisions)  // المحكمة يمكنها إصدار عدة قرارات
                .HasForeignKey(jd => jd.Courtid).OnDelete(DeleteBehavior.Cascade); // المفتاح الأجنبي المرتبط بالمحكمة
            builder.Entity<PolicemanDecision>()
          .HasOne(pd => pd.CourtDecision)  // كل قرار شرطي مرتبط بقرار محكمة واحد فقط
          .WithOne(cd => cd.PoliceDecision)  // وكل قرار محكمة مرتبط بقرار شرطي واحد فقط
          .HasForeignKey<PolicemanDecision>(pd => pd.CourtDecisionId);  // المفتاح الأجنبي في قرار الشرطي
            builder.Entity<CourtDecisions>()
                .HasOne(cd => cd.PoliceDecision)  // كل قرار محكمة مرتبط بقرار شرطي واحد فقط
                .WithOne(pd => pd.CourtDecision)  // وكل قرار شرطي مرتبط بقرار محكمة واحد فقط
                .HasForeignKey<CourtDecisions>(cd => cd.PoliceDecisionId);  // المفتاح الأجنبي في قرار المحكمة

            builder.Entity<TrafficViolation>()
           .HasOne(vs => vs.CourtDecision)  // كل حالة مخالفة مرتبطة بقرار قاضي واحد فقط
           .WithOne(cd => cd.ViolationStatus)  // وكل قرار قاضي مرتبط بحالة مخالفة واحدة فقط
           .HasForeignKey<TrafficViolation>(vs => vs.CourtDecisionId).OnDelete(DeleteBehavior.Restrict);  // المفتاح الأجنبي في حالة المخالفة

            builder.Entity<CourtDecisions>()
                .HasOne(cd => cd.ViolationStatus)  // كل قرار قاضي مرتبط بحالة مخالفة واحدة فقط
                .WithOne(vs => vs.CourtDecision)  // وكل حالة مخالفة مرتبطة بقرار قاضي واحد فقط
                .HasForeignKey<CourtDecisions>(cd => cd.Violationid);  // المفتاح الأجنبي في قرار القاضي

            builder.Entity<Judge>()
            .HasMany(j => j.CourtDecisions)  // القاضي يمكن أن يحكم في العديد من المخالفات
            .WithOne(v => v.Judge)  // كل مخالفة تتعلق بقاضي واحد فقط
            .HasForeignKey(v => v.JudgeId).OnDelete(DeleteBehavior.Cascade); // المفتاح الأجنبي في جدول المخالفات

            // تعريف العلاقة بين Citizen و ApplicationUser
            builder.Entity<Citizen>()
                .HasOne(c => c.User)
                .WithMany() // إذا لم يكن هناك قائمة مواطنين في المستخدم
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Policeman>()
               .HasOne(c => c.User)
               .WithMany() // إذا لم يكن هناك قائمة مواطنين في المستخدم
               .HasForeignKey(c => c.UserId)
               .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Judge>()
             .HasOne(c => c.User)
             .WithMany() // إذا لم يكن هناك قائمة مواطنين في المستخدم
             .HasForeignKey(c => c.UserId)
             .OnDelete(DeleteBehavior.Cascade);


            // استدعاء Seed Data
            SeedData.Initialize(builder);

        }


    }
}
