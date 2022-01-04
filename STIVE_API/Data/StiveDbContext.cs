using Microsoft.EntityFrameworkCore;
using STIVE_API.Data.Models.Articles;
using STIVE_API.Data.Models.Orders;
using STIVE_API.Data.Models.Users;
using System.Collections.Generic;
using System.Linq;

namespace STIVE_API.Data
{
    public class StiveDbContext : DbContext
    {

        #region Ctor

        public StiveDbContext() : base()
        {

        }

        #endregion

        #region DbSet

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<ClientOrder> ClientOrder { get; set; }
        public DbSet<Annee> Annee { get; set; }
        public DbSet<Capacity> Capacity { get; set; }
        public DbSet<ArticleRow> ArticleRow { get; set; }
        public DbSet<Cepage> Cepage { get; set; }
        public DbSet<Family> Family { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<Status> Status { get; set; }

        public DbSet<Supplier> Supplier { get; set; }



        #endregion

        #region Configuration
        public static string GetConnectionString()
        {
            return "Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var _connectionString = GetConnectionString();

                optionsBuilder.UseSqlServer(_connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        #endregion

        #region Creation Database & Seeder

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var customer = SeedCustomer();
            modelBuilder.Entity<Customer>().HasData(customer);

            var employee = SeedEmployee();
            modelBuilder.Entity<Employee>().HasData(employee);

            var status = SeedStatus();
            modelBuilder.Entity<Status>().HasData(status);

            var annees = SeedAnnee();
            modelBuilder.Entity<Annee>().HasData(annees);

            var capacity = SeedCapacity();
            modelBuilder.Entity<Capacity>().HasData(capacity);

            var cepage = SeedCepages();
            modelBuilder.Entity<Cepage>().HasData(cepage);

            var families = SeedFamilies();
            modelBuilder.Entity<Family>().HasData(families);

            var supplier = SeedSupplier();
            modelBuilder.Entity<Supplier>().HasData(supplier);

            var stock = SeedStock();
            modelBuilder.Entity<Stock>().HasData(stock);

            modelBuilder.Entity<Article>().HasOne<Annee>( a => a.Annee ).WithMany().OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Article>().HasOne<Capacity>(c => c.Capacity).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Article>().HasOne<Cepage>(c => c.Cepage).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Article>().HasOne<Family>(f => f.Family ).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Article>().HasOne<Supplier>(s => s.Supplier).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Article>().HasOne<Stock>(s => s.Stock).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Article>()
                .HasData(new Article("Bouteille de vin", "152DER147DFM9", "Description à venir", 5.60, annees.First().AnneeId, capacity.First().CapacityId, cepage.First().CepageId, families.First().FamilyId, supplier.First().SupplierId, stock.First().StockId));
            modelBuilder.Entity<Article>()
               .HasData(new Article("Bouteille de bordeau", "452SER197DRP9", "Description à venir", 3.50, annees.Last().AnneeId, capacity.Last().CapacityId, cepage.Last().CepageId, families.Last().FamilyId, supplier.First().SupplierId, stock.Last().StockId));
            modelBuilder.Entity<Stock>();
            modelBuilder.Entity<ClientOrder>()
                .HasData(
                new ClientOrder("TEST123456", customer.First().Id, status.First().StatusId),
                new ClientOrder("TEST234567", customer.Last().Id, status.First().StatusId)
                );
            modelBuilder.Entity<PurchaseOrder>();
            modelBuilder.Entity<ArticleRow>();

        }

        private static List<Customer> SeedCustomer()
        {
            return new List<Customer>
            {
                new Customer ("TRIPIER", "Lucile", "luciole.trp@gmail.com", "123", "0699318613", "1 chemin des alisiers 67700 Saverne", "67700", "Saverne"),
                new Customer ("LEBLOND", "Gregory", "gregory.lbl@gmail.com", "123", "0631258641", "123 rue des chats", "000009", "CroquetteLand"),
            };
        }

        private static List<Employee> SeedEmployee()
        {
            return new List<Employee>
            {
                new Employee ("EL-ALLALI", "Mariam", "mariam.el@gmail.com", "123", "0698574123", "3 Grande rue", "76000", "Rouen"),
                new Employee ("DUPONT", "François", "francois.dupont@yahoo.com", "123", "0635241896", "57 Boulevard Gambetta", "27000", "Evreux"),
                new Employee ("DUPONT", "Francine", "francine.dupont@gmail.com", "123", "0632547896", "21 Rue Victor Hugo", "27000", "Evreux"),
                new Employee ("PETIT", "Jeremy", "jeremy.petit@outlook.com", "123", "0652341254", "3 Rue du Bout au Roussel", "27600", "Champenard"),
            };
        }

        private static List<Annee> SeedAnnee()
        {
            return new List<Annee>
            {
                new Annee(2010),
                new Annee(2011),
                new Annee(2012),
                new Annee(2013),
                new Annee(2014),
                new Annee(2015),
                new Annee(2016),
                new Annee(2017),
                new Annee(2018),
                new Annee(2019),
                new Annee(2020),
                new Annee(2021),
            };
        }

        private static List<Capacity> SeedCapacity()
        {
            return new List<Capacity>
            {
                new Capacity(75),
                new Capacity(37.5),
            };
        }

        private static List<Cepage> SeedCepages()
        {
            return new List<Cepage>
            {
                new Cepage("Chardonnay", "France"),
                new Cepage("Sauvignon", "France"),
                new Cepage("Pinot Noir", "Allemagne"),
                new Cepage("Riesling", "France"),
                new Cepage("Gewurztraminer", "France"),
                new Cepage("Merlot noir", "France"),
                new Cepage("Mauzac rosé", "France"),
            };
        }
        
        private static List<Family> SeedFamilies()
        {
            return new List<Family>
            {
                new Family("Rosé"),
                new Family("Vin blanc"),
                new Family("Vin rouge"),
                new Family("Muscat"),
                new Family("Vin cuit"),
                new Family("Mousseux"),
  
            };
            
        }

        private static List<Status> SeedStatus()
        {
            return new List<Status>
            {
                new Status("Vérification en cours"),
                new Status("Terminée"),
                new Status("Archivée"),
                new Status("Livrée"),
                new Status("En cours d'approvisionnement"),
                new Status("En cours de traitement"),
                new Status("En préparation"),
                new Status("En cours d'acheminement"),
                new Status("j'ai volé votre bouteille, merci, bisous, de Greg."),
            };
        }

        private static List<Supplier> SeedSupplier()
        {
            return new List<Supplier>
            {
                new Supplier("La Centrale des Vins", "14 Rue Louis Ruquier", "76300", "Sotteville-lès-Rouen", "38862771300067", "02 35 73 03 93")
            };
        }

        private static List<Stock> SeedStock()
        {

            return new List<Stock>
            {
                new Stock(10, 5, 15),
                new Stock(2, 1, 5),
                new Stock(50,20,100),
            };

        }


        #endregion

    }


}
