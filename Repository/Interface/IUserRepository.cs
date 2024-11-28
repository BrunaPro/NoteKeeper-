using NoteKeeper.Models;

namespace NoteKeeper.Repository.Interface
{
    public interface IUserRepository
    {
        Task<List<UserModel>> SerachingForAll();

        Task<UserModel> GettingById(int id);

    }
}
