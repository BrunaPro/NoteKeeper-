using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteKeeper.Models;
using NoteKeeper.Repository.Interface;

namespace NoteKeeper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> SerachingForAll()
        {
            List<UserModel> note = await _userRepository.SerachingForAll();
            return Ok(note);
        }

     
        [HttpGet("id")]
        public async Task<ActionResult<UserModel>> GettingById(int id)
        {
            UserModel note = await _userRepository.GettingById(id);
            return Ok(note);
        }


    }
}
