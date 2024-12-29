using Hamada.Models.appContext;
using Hamada.Models.Entity;
using Hamada.Repos.IRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Hamada.Repos.Implemntion
{
    public class Iusers : users
    {
     protected readonly AppDBContext db;
        public Iusers(AppDBContext db)
        {
            this.db = db;
        }
        public async Task CreateUser(User user)
        {
          await  db.users.AddAsync(user);
           await db.SaveChangesAsync();
        }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await db.users.ToListAsync();
        }
        public async Task<User> GetUsersID(int id)
        {
            return await db.users.FirstAsync(x=>x.Id == id);
        }
        public async Task DeleteUser(int id)
        {
            User user = new User();
            user = await db.users.FirstAsync(x=>x.Id==id);
            db.users.Remove(user);
            await db.SaveChangesAsync();
        }
        public async Task updateUser(User user, int ID)
        {
            user = await db.users.FirstAsync(x => x.Id == ID);
            db.users.Update(user);
            await db.SaveChangesAsync();
        }
    }
}
