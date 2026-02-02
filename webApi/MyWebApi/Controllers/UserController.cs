using Microsoft.AspNetCore.Mvc;
using MyWebApi.model;
using MyWebApi.service;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    public class UserController: ControllerBase
    {

        private IUserService _service;
        public UserController(IUserService user)
        {
            this._service = user;
        }

        [HttpGet]        
        public IActionResult Get() {
            var users = _service.List().ToHashSet();

            return  Ok(users); 
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _service.Save(new User { ID = user.ID, LastName = user.LastName, Name = user.Name});
            return Created();
        }
    }
}
