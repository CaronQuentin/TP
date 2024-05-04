using Caron.RG.DAL.Model;
using Microsoft.EntityFrameworkCore;
public class EspionMissionService : IEspionMissionService
{

    private CaronDbContext _db;
    public EspionMissionService(CaronDbContext dbContext)
    {
        this._db = dbContext;
    }

    public void AjouterEspion(Espion espion)
    {
        this._db.Espions.Add(espion);
        this._db.SaveChanges();
    }
    public void SupprimerEspion(Espion espion)
    {
        this._db.Espions.Remove(espion);
        this._db.SaveChanges();
    }

    public void AjouterMission(Mission mission)
    {
        this._db.Missions.Add(mission);
        this._db.SaveChanges();
    }
    public void SupprimerMission(Mission mission)
    {
        this._db.Missions.Remove(mission);
        this._db.SaveChanges();
    }


    
}
