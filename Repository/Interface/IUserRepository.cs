using NoteKeeper.Models;

namespace NoteKeeper.Repository.Interface
{
    public interface IUserRepository
    {
        Task<List<UserModel>> SerachingForAll();

        Task<UserModel> GettingById(int id);

        Task<UserModel> Register(UserModel user); 

        Task<UserModel> Update(UserModel user, int id);    

        Task<bool> Delete(int id);

           

    }
}
