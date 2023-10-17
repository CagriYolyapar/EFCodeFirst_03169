using EFCodeFirst_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.ContextClasses
{
    //DbContext sınıfınız veritabanı işlemlerinizin hepsini yapabilen bir sınıfınızdır...Siz veritabanı işlemlerinizi yapabilmek icin DbContext'ten miras alırsınız...


    //Bir sınıf DbContext'ten miras alıyor ise  o bir veritabanı sınıfıdır...
    public class MyContext : DbContext
    {
        //Asagıdaki adres belirleme sistemi tercih ettigimiz bir yöntem degildir. Cünkü esnekligi bitirir
        //public MyContext()
        //{
        //    Database.Connection.ConnectionString = "server = . ; database ...";
        //}

        //BUradaki base'in (DbContext'in COnstructor'inin) string parametre alan overload'i calısacak ve projenin (su anda tek bir projemiz var, eger birden fazla olsaydı startup olarak set'lenen projenin) config dosyasındaki connectionString isimlerini arayacak...Oradan ismini buldugu adresi algılayacak...

        //EF entegrasyonlarında bir connectionString ismi algılandıgı anda mevcut solution'da hangi proje calısmak icin görevlendirildi ise o projenin config'ine bakılır

        public MyContext():base("MyConnection")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Category>().ToTable("Kategoriler");
            //modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasColumnName("Kategori Ismi");
            //modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("money");

            modelBuilder.Entity<AppUser>().HasOptional(x => x.Profile).WithRequired( x => x.AppUser ); //Birebir ilişki ifadesinin ikinci fazının tamamlanmıs halidir...BUrada anlatılmak istenen ifade : Bir AppUser'in Profil'i olmayabilir (HasOptional(x=>x.Profile)...Lakin bir Profilin AppUser'i olmak zorundadır (WithRequired(x=>x.AppUser) HasOptional(Opsiyonel), WithRequired(Gerekli)

            modelBuilder.Entity<OrderDetail>().Ignore(x => x.ID); //Buradaki Ignore metodu bizim belirledigimiz bir property'nin SQL'e gönderilmesini engeller...

            //modelBuilder.Entity<Product>().HasKey(x=> x.ASd)

            modelBuilder.Entity<OrderDetail>().HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            }); //HasKey metodu sizin tablo olacak class'inizin tablo olacagı zaman nasıl bir key'e sahip olacagını belirtir...
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



    }
}
