using System.Threading.Tasks;
using System.Web.Http;
using TestSixDegreess.Services;

namespace TestSixDegrees.API.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly Service _userService;

        public ValuesController()
        {
            _userService = new Service();
        }
        // GET api/values
        public async Task<IHttpActionResult> Get()
        {
            var users = await _userService.GetUsersAsync();

            return Ok(users);
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
