using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteKeeper.Models;
using NoteKeeper.Repository.Interface;

namespace NoteKeeper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {

        private readonly INotesRepository _noteRepository;

        public NotesController(INotesRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }



        //seraching all notes
        [HttpGet]
        public async Task<ActionResult<List<NotesModel>>> GettingAllNotes()
        {
            List<NotesModel> note = await _noteRepository.GettingAllNotes();
            return Ok(note);
        }

        //searching all notes by name 
        [HttpGet("title")]
        public async Task<ActionResult<NotesModel>> GettingByTitlle(string title)
        {
            NotesModel note = await _noteRepository.GettingByTitlle(title);
            if (note == null)
            {
                return NotFound($"Note with title '{title}' not found.");
            }
            return Ok(note);
        }

        //searching all notes by id
        [HttpGet("id")]
        public async Task<ActionResult<NotesModel>> GettingById(int id)
        {
            NotesModel note = await _noteRepository.GettingById(id);
            if (note == null)
            {
                return NotFound($"Note with id '{id}' not found.");
            }
            return Ok(note);
        }

        //add a note
        [HttpPost]
        public async Task<ActionResult<NotesModel>>Create([FromBody] NotesModel NoteModel)
        {
            NotesModel note = await _noteRepository.Create(NoteModel);
            return Ok(note);
        }

        //change a note by id
        [HttpPut]
        public async Task<ActionResult<NotesModel>> Update([FromBody] NotesModel noteModel, int id)
        {
            var existingNote = await _noteRepository.GettingById(id);
            if (existingNote == null)
            {
                return NotFound($"Note with id '{id}' not found."); 
            }

            
            existingNote.Title = noteModel.Title;
            existingNote.Content = noteModel.Content;
            var updatedNote = await _noteRepository.Update(existingNote,id);
            return Ok(updatedNote);    
        }

        // deleting a note by id
        [HttpDelete]
        public async Task<ActionResult<NotesModel>> Delete(int id)
        {

            var delete = await _noteRepository.Delete(id);  
            return Ok(delete);
        }

    }
}
