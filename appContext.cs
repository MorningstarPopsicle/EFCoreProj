using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server = localhost;user = root;database = StudentApp; port = 3306;password = Azeemah@1");
        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Department> Departments {get; set;}
    }