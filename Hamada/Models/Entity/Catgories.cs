namespace Hamada.Models.Entity
{
    public class Catgories
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Habits> Habit { get; set; }
    }
}
