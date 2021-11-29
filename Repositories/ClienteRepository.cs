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
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Insert(Cliente entity)
        {
            var result = await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Cliente> GetById(Guid id)
        {
            return await _context.Cliente.Where(Cliente => Cliente.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<Cliente> Update(Cliente entity)
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
                _context.Cliente.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        
    }
}
