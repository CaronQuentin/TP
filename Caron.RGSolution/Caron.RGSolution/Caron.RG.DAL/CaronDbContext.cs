using Caron.RG.DAL.Model;
using Microsoft.EntityFrameworkCore;
public class CaronDbContext : DbContext, ICaronDbContext
{
    public DbSet<Espion> Espions { get; set; }
    public DbSet<Mission> Missions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Port=3306;Database=renseignements;Uid=root;Pwd=;";
        var serverVersion = new MySqlServerVersion(new Version(8, 2, 4));
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
