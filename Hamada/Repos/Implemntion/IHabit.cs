using Hamada.Models.appContext;
using Hamada.Models.Entity;
using Hamada.Models.ViewModels;
using Hamada.Repos.IRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Hamada.Repos.Implemntion
{
    public class IHabit : Habit
    {
        protected readonly AppDBContext db;
        public IHabit(AppDBContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Habits>> GetAllHabits()
        {
            return await db.habits.ToListAsync();
        }

        public async Task<Habits> GetHabitsbyID(int id)
        {
            Habits hab = await db.habits.FirstAsync(x => x.Id == id);
            return hab;
        }
        public async Task addHabit(HabitViewModel habi)
        {
            Habits habit = new Habits()
            {
                CatID = habi.CatID,
                userID = habi.userID,
                Name = habi.name,
                StartDate = DateTime.Now,
            };
             await db.habits.AddAsync(habit);
             await db.SaveChangesAsync();
        }
        public async Task updateHabit(HabitViewModel habit, int HID)
        {
            var habi = await db.habits.FirstAsync(x => x.Id == HID);

            habi.Name = habit.name;
            habi.StartDate = habit.date;
                habi.userID = habit.userID;
            habi.CatID = habit.CatID;

             db.habits.Update(habi);
             await db.SaveChangesAsync();
           
        }

        public async Task deleteHabit(int id)
        {
          var e = await db.habits.FirstAsync(x => x.Id == id);

            db.habits.Remove(e);
            await db.SaveChangesAsync();
        }
    }
}
