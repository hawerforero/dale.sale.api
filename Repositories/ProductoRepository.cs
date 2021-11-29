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
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Producto> Insert(Producto entity)
        {
            var result = await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Producto> GetById(Guid id)
        {
            return await _context.Producto.Where(Producto => Producto.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _context.Producto.ToListAsync();
        }

        public async Task<Producto> Update(Producto entity)
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
                _context.Producto.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        
    }
}
