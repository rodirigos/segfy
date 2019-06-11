using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seg.API.Models;

namespace Seg.API.Data
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly DataContext _context;
        public InsuranceRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Edit<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<List<Insurance>> GetAllInsurances()
        {
            return await _context.Insurances.ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;;
        }

        public async Task<Insurance> GetInsurance(int id)
        {
            return await _context.Insurances.FirstOrDefaultAsync(x=> x.Id == id);
        }
    }
}