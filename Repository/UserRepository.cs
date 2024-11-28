using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Spreadsheet;
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

            var user = await dBContext.Users
        .Where(x => x.id == id)
        .Include(x => x.Notes)
        .FirstOrDefaultAsync();

            
            if (user == null)
            {
                return null;
            }

            
            return user;
        }

        public async Task<UserModel> Register(UserModel user)
        {
            await dBContext.Users.AddAsync(user);
            await dBContext.SaveChangesAsync();

            return user;
        }

        async Task<UserModel> IUserRepository.Update(UserModel user, int id)
        {
            UserModel userbyId = await GettingById(id);

            if (userbyId == null)
            {
                throw new Exception($"User by ID: {id} it was not found");
            }

            userbyId.userName = user.userName;
            userbyId.email = user.email;

            dBContext.Users.Update(userbyId);
            await dBContext.SaveChangesAsync();

            return userbyId;
        }

        public async Task<bool> Delete(int id)
        {
            UserModel userbyId = await GettingById(id);

            if (userbyId == null)
            {
                throw new Exception($"User by ID: {id} it was not found");
            }

            dBContext.Users.Remove(userbyId);
            await dBContext.SaveChangesAsync();
            return true;

        }


    }
}
