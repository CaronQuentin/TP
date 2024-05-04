using Caron.RG.DAL.Model;
using Microsoft.EntityFrameworkCore;

public interface ICaronDbContext
{
    public DbSet<Espion> Espions { get; set; }
    public DbSet<Mission> Missions { get; set; }
}
