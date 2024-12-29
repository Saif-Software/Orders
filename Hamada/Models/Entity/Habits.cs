using System.ComponentModel.DataAnnotations.Schema;

namespace Hamada.Models.Entity
{
    public class Habits
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public User User { get; set; }

        public int CatID { get; set; }
        [ForeignKey("CatID")]
        public Catgories Categories { get; set; }
    }
}
