using AutoMapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TestSixDegrees.Domain;
using TestSixDegrees.Domain.Dtos;
using TestSixDegrees.Persistance;

namespace TestSixDegreess.Services
{
    public class Service
    {
        private readonly ApiRepository _apiRepository;
        private readonly IMapper _mapper;

        public Service()
        {
            _apiRepository =  new ApiRepository();
            
        }

        public async Task<IEnumerable<DataUsuario>> GetUsersAsync()
        {
            var users = await _apiRepository.GetUsersAsync();
            var dataUsuarios = new List<DataUsuario>();

            foreach (var user in users)
            {
                var dataUsuario = new DataUsuario
                {
                    UsuID = user.UsuID,
                    NombreCompleto = user.Nombre + " " + user.Apellido
                };

                dataUsuarios.Add(dataUsuario);
            }

            return dataUsuarios;
        }
    }
}
