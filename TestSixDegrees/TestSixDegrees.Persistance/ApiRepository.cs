using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TestSixDegrees.Domain;

namespace TestSixDegrees.Persistance
{
    public class ApiRepository
    {
        private readonly PruebaSDDbContext _context;
        public ApiRepository()
        {
            _context = new PruebaSDDbContext();
        }

        public async Task<IEnumerable<Usuario>> GetUsersAsync()
        {
            var users = await _context.Usuarios.ToListAsync();
            return users;
        }
    }
}
