using Microsoft.EntityFrameworkCore;
using NoteKeeper.Data;
using NoteKeeper.Models;
using NoteKeeper.Repository.Interface;
using System.Runtime.CompilerServices;

namespace NoteKeeper.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly NoteSystemDBContext dBContext;

        public UserRepository(NoteSystemDBContext noteSystemDBContext)
        {
            dBContext = noteSystemDBContext;
        }

        public async Task<List<UserModel>> SerachingForAll()
        {
            return await dBContext.Users.ToListAsync(); 
        }

        public async Task<UserModel> GettingById(int id)
        {
            return await dBContext.Users.FirstOrDefaultAsync(x => x.id == id);
        }

        
    }
}
