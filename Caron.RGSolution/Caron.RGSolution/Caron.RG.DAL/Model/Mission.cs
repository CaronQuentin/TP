using Caron.RG.DAL;
using System.Collections.Generic;
using System.Reflection.Emit;

public class Mission
{
    public int id { get; set; }

    public int annee { get; set; }
    public int idEspion { get; set; }
    public string localisation { get; set; }

    public Mission(int idEspion, string localisation, int annee)
    {
        this.idEspion = idEspion;
        this.localisation = localisation;
        this.annee = annee;
    }

    public override string ToString()
    {
        return $"Mission à {this.localisation} en {this.annee} par l'espion :{this.idEspion}.";
    }
}
