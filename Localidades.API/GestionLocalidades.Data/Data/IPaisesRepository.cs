using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GestionLocalidades.Data.Models;

namespace GestionLocalidades.Data.Data
{
    public interface IPaisesRepository
    {
        Task<List<Paises>> ObtenerPaises();
    }
}
