using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GestionLocalidades.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLocalidades.Data.Data
{
    public class PaisesRepository : IPaisesRepository
    {
        private readonly DataContext _context;

        public PaisesRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Paises>> ObtenerPaises()
        {
            return await _context.Paises.ToListAsync();
        }
    }
}
