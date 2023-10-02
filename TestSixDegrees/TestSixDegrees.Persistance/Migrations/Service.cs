using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TestSixDegrees.Domain;
using TestSixDegrees.Persistance;

namespace TestSixDegreess.Services
{
    public class Service
    {
        private readonly ApiRepository _apiRepository;

        public Service(ApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public async Task<IEnumerable<Usuario>> GetUsersAsync()
        {
            var users = await _apiRepository.GetUsersAsync();
            return users;
        }
    }
}
