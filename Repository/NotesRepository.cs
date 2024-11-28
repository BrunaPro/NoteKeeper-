using Microsoft.EntityFrameworkCore;
using NoteKeeper.Data;
using NoteKeeper.Models;
using NoteKeeper.Repository.Interface;

namespace NoteKeeper.Repository
{
    public class NotesRepository : INotesRepository
    {

        private readonly NoteSystemDBContext dBContext;

        public NotesRepository(NoteSystemDBContext noteSystemDBContext)
        {
            dBContext = noteSystemDBContext; 
        }


        public async Task<List<NotesModel>> GettingAllNotes()
        {
            return await dBContext.Notes.ToListAsync();
        }

        public async Task<NotesModel> GettingByTitlle(string title)
        {
            return await dBContext.Notes
           .Include(x => x.User)
           .FirstOrDefaultAsync(x => x.Title == title);
        }

        public async Task<NotesModel> GettingById(int id)
        {
            return await dBContext.Notes
           .Include(x => x.User)
           .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<NotesModel> Create(NotesModel note)
        {
            note.Created_at = DateTime.Now; 
            note.Updated_at = null;         
            note.Delete_at = null;          

            await dBContext.Notes.AddAsync(note);
            await dBContext.SaveChangesAsync();
            return note;
        }

        public async Task<NotesModel> Update(NotesModel note, int id)
        {
            var existingNote = await dBContext.Notes.FindAsync(id);
            if (existingNote == null)
            {
                throw new Exception($"This note was not found");
            }

            existingNote.Title = note.Title;
            existingNote.Content = note.Content;
            existingNote.Updated_at = DateTime.Now;  

            await dBContext.SaveChangesAsync();
            return existingNote;
        } 

        public async Task<NotesModel> Delete(int id)
        {
            var note = await dBContext.Notes.FindAsync(id);
            if (note == null)
            {

                throw new Exception($"This note was not found");
            }

            note.Delete_at = DateTime.Now;
            dBContext.Notes.Remove(note); 
            await dBContext.SaveChangesAsync(); 
            return note;
        }



    }
}
