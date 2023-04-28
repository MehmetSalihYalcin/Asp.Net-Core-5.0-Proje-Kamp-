using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context : DbContext  // dbcontext özelliğini al
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ASUS\\SQLEXPRESS;database=FirstCoreBlog_DB;integrated security=true;Encrypt=false;"); // veritabanına bağlanmak için
        }

        public DbSet<About> Abouts { get; set; }  // entity ile çalışmak istediğimi söylüyorum

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Writer> Writerrs { get; set; }

        public DbSet<NewsLetter> NewsLetters { get; set; }

    }
}
