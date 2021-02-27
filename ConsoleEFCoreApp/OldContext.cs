using Microsoft.EntityFrameworkCore;

namespace ConsoleEFCoreApp
{
    public class OldContext : DbContext
    {
       
        string cs = "server=localhost; port=3306; database=old; user=root; password=; Persist Security Info=False; Connect Timeout=300";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseMySql(cs, ServerVersion.AutoDetect(cs));
        }
    }
}
