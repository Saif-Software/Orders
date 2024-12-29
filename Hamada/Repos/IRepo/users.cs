using Hamada.Models.Entity;

namespace Hamada.Repos.IRepo
{
    public interface users
    {
        // getalluser
        //add user
        // update user
        // delete user
        //getbyId

        public  Task<IEnumerable<User>> GetAllUsers();
        public Task<User> GetUsersID(int id);
        public Task CreateUser(User user);
        public Task DeleteUser(int id);
        public Task updateUser(User user,int ID);


    }
}
