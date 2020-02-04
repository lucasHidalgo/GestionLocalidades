using System.Collections.Generic;

namespace GestionLocalidades.Data.Models
{
    public class Paises
    {
        public Paises()
        {
            Provincias = new HashSet<Provincias>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Provincias> Provincias { get; set; }
    }
}
