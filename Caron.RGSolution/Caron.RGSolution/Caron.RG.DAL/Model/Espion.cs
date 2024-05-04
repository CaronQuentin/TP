using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Caron.RG.DAL.Model
{
    public class Espion
    {
        public int id { get; set; }

        [MaxLength(30)]
        public string nom { get; set; }

        [MaxLength(50)]
        public string code { get; set; }

        public Espion(string nom, string code)
        {
            this.nom = nom;
            this.code = code;
        }
        public override string ToString()
        {
            return $"nom de l'espion : {nom} nom de code: {code}";
        }
    }
}
