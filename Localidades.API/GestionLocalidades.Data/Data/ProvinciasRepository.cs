using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionLocalidades.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLocalidades.Data.Data
{
    public class ProvinciasRepository : IProvinciasRepository
    {
        private readonly DataContext _context;

        public ProvinciasRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Provincias>> ObtenerProvinciasPorPaisId(int paisId)
        {
            return await _context.Provincias.Where(x => x.PaisId == paisId).ToListAsync();
        }
    }
}
