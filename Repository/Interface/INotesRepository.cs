using NoteKeeper.Models;

namespace NoteKeeper.Repository.Interface
{
    public interface INotesRepository
    {
        Task<List<NotesModel>> GettingAllNotes();

        Task<NotesModel> GettingByTitlle(string title);

        Task<NotesModel> Create(NotesModel note);

        Task<NotesModel> Update(NotesModel note, int id);

        Task<bool> Delete(int id);

        Task<NotesModel> Recover(NotesModel note, int id);
       

    } 
}
