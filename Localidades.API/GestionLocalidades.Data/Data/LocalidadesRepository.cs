using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionLocalidades.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLocalidades.Data.Data
{
    public class LocalidadesRepository : ILocalidadesRepository
    {
        private readonly DataContext _context;

        public LocalidadesRepository(DataContext context)
        {
            _context = context;
        }
        public async Task CrearLocalidad(Localidades localidad)
        {
            await _context.Localidades.AddAsync(localidad);
            await _context.SaveChangesAsync();
        }

        public async Task BorrarLocalidad(int id)
        {
            // obtener localidad por id
            var localidad = await _context.Localidades.FindAsync(id);
            //borrar localidad
            _context.Localidades.Remove(localidad);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Localidades>> ObtenerLocalidades()
        {
            return await _context.Localidades.Include(x=>x.Provincias).ToListAsync(); 
        }

        public bool EstaValidado(Localidades localidad)
        {
            // Si el nombre esta vacio, retorna true
            return string.IsNullOrEmpty(localidad.Nombre);
        }

        public async Task EditarLocalidad(Localidades localidad)
        {
            _context.Localidades.Update(localidad);
            await _context.SaveChangesAsync();
        }

        public async Task<Localidades> ObtenerLocalidadPorId(int id)
        {
            return await _context.Localidades.Include(x => x.Provincias).ThenInclude(x => x.Pais).FirstAsync(x => x.Id == id);
        }
    }
}
