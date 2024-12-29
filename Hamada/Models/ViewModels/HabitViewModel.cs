using Hamada.Models.Entity;

namespace Hamada.Models.ViewModels
{
    public class HabitViewModel
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public int userID { get; set; }
        public int CatID { get; set; }  

        public IEnumerable<Catgories> catgories { get; set; }
        public IEnumerable<User> users { get; set; }

    }
}
