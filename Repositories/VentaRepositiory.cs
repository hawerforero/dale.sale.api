using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dale.sale.api.Contexts;
using dale.sale.api.Models;

namespace dale.sale.api.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly ApplicationDbContext _context;

        public VentaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Venta> Insert(Venta entity)
        {
            var result = await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Venta> GetById(Guid id)
        {
            return await _context.Venta.Where(Venta => Venta.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Venta>> GetAll()
        {
            return await _context.Venta.ToListAsync();
        }

        public async Task<Venta> Update(Venta entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                _context.Venta.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        
    }
}
