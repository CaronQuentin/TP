using Caron.RG.DAL.Model;

public interface IEspionMissionService
{
    void AjouterEspion(Espion espion);

    void SupprimerEspion(Espion espion);
    
    void AjouterMission(Mission mission);

    void SupprimerMission(Mission mission);
}
