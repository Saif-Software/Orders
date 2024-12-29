using Hamada.Models.Entity;
using Hamada.Models.ViewModels;

namespace Hamada.Repos.IRepo
{
    public interface Habit
    {
        public Task<IEnumerable<Habits>> GetAllHabits();
        public Task<Habits> GetHabitsbyID(int id);    
        public Task addHabit(HabitViewModel habits);    
        public Task updateHabit(HabitViewModel habit,int HID);
        public Task deleteHabit(int id);



    }
}
