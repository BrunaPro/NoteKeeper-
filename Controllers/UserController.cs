using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteKeeper.Models;
using NoteKeeper.Repository;
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

        //Register user  
        [HttpPost]
        public async Task<ActionResult<UserModel>> Register([FromBody] UserModel userModel)
        {
            UserModel user = await _userRepository.Register(userModel); 
            return Ok(user);
        }

        //Update user  
        [HttpPut("{id}")]
        public async Task<ActionResult<UserModel>> Update([FromBody] UserModel userModel, int id)
        {
            userModel.id = id;
            UserModel user = await _userRepository.Update(userModel, id);
            return Ok(user);
        }

        //Delete user  
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserModel>> Delete(int id)
        {

            bool delete = await _userRepository.Delete(id); 
            return Ok(delete);
        }





    }
}
