using System.Collections.Generic;
using System.Threading.Tasks;
using GestionLocalidades.Data.Models;

namespace GestionLocalidades.Data.Data
{
    public interface ILocalidadesRepository
    {
        Task CrearLocalidad(Localidades localidad);
        Task BorrarLocalidad(int id);
        Task<List<Localidades>> ObtenerLocalidades();
        bool EstaValidado(Localidades localidad);
        Task EditarLocalidad(Localidades localidad);
        Task<Localidades> ObtenerLocalidadPorId(int id);
    }
}
