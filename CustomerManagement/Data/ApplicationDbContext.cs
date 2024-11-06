using CustomerManagement.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

        public DbSet<AccountingDay> AccountingDays { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountingDay>(a =>
			{
				a.HasData(
					new AccountingDay { Id = 1, Name = "يوم المحاسبة 1" },
					new AccountingDay { Id = 2, Name = "يوم المحاسبة 2" },
					new AccountingDay { Id = 3, Name = "يوم المحاسبة 3" });
			});	

			modelBuilder.Entity<Application>(a =>
			{
				a.HasData(
					new Application { Id = 1, Name = "Facebook" },
					new Application { Id = 2, Name = "WhatsApp" },
					new Application { Id = 3, Name = "Instagram" });
			});

			modelBuilder.Entity<Area>(a =>
			{
				a.HasData(
					new Area { Id = 1, Name = "المنطقة الاولي" },
					new Area { Id = 2, Name = "المنطقة الثالثة" },
					new Area { Id = 3, Name = "المنطقة الرابعة" });
			});	

			modelBuilder.Entity<Branch>(a =>
			{
				a.HasData(
					new Branch { Id = 1, Name = "الفرع الاولي" },
					new Branch { Id = 2, Name = "الفرع الثالثة" },
					new Branch { Id = 3, Name = "الفرع الرابعة" });
			});


			modelBuilder.Entity<ClientType>(c =>
			{
				c.HasData(
					new ClientType { Id = 1, Name = "مندوب" },
					new ClientType { Id = 2, Name = "عميل" },
					new ClientType { Id = 3, Name = "مورد" },
					new ClientType { Id = 4, Name = "اخري" },
					new ClientType { Id = 5, Name = "منسق" });
			});		

			modelBuilder.Entity<Currency>(c =>
			{
				c.HasData(
					new Currency { Id = 1, Name = "الجنية" },
					new Currency { Id = 2, Name = "الريال" },
					new Currency { Id = 3, Name = "الدولار" });
			});		

			modelBuilder.Entity<Moderator>(c =>
			{
				c.HasData(
					new Moderator { Id = 1, Name = "أشرف" },
					new Moderator { Id = 2, Name = "أيمن" },
					new Moderator { Id = 3, Name = "محمود" });
			});

			modelBuilder.Entity<Nationality>(c =>
			{
				c.HasData(
					new Nationality { Id = 1, Name = "مصري" },
					new Nationality { Id = 2, Name = "سعودي" },
					new Nationality { Id = 3, Name = "امريكي" });
			});

			base.OnModelCreating(modelBuilder);
		}
	}
}
