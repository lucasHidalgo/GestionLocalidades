using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GestionLocalidades.Data.Models;

namespace GestionLocalidades.Data.Data
{
    public interface IProvinciasRepository
    {
        Task<List<Provincias>> ObtenerProvinciasPorPaisId(int paisId);
    }
}
