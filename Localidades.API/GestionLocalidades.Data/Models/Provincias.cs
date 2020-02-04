using System.Collections.Generic;

namespace GestionLocalidades.Data.Models
{
    public class Provincias
    {
        public Provincias()
        {
            Localidades = new HashSet<Localidades>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PaisId { get; set; }
        public Paises Pais { get; set; }
        public ICollection<Localidades> Localidades { get; set; }
    }
}
