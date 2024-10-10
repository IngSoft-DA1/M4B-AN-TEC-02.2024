using BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class SqlContext: DbContext{
    public DbSet<Movie> Movies { get; set; }
   
   public  SqlContext(DbContextOptions<SqlContext> options) : base(options){
       Database.Migrate(); 
    }
    // como hacer la conexción a la base de datos
}