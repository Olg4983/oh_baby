using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class HealthRepos
    {
        public static void AddData(string childFirstName, string lastName, string firstName, string fatherName, string proff, DateTime dateMeeting, DateTime dateNextMeeting, byte[] img)
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Health health = new Health
                    {
                        LastName = lastName,
                        FirstName = firstName,
                        FatherName = fatherName,
                        Proff = proff,
                        DateMeeting = dateMeeting,
                        DateNextMeeting = dateNextMeeting,
                        ImageView = img
                    };
                    Child child = db.Childs.FirstOrDefault(c => c.FirstName == childFirstName);
                    child.Healths.Add(health);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                FormMessage.Show("При добавлении данных произошла ошибка...");
            }
        }

        public static List<Health> FindByChild(Child child)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Healths.Where(health => health.Child_Id == child.Id).ToList();
            }
        }

        public static void UpdateImage(int healthId, byte[] img)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                var health = db.Healths.Where(c => c.Id == healthId).FirstOrDefault();
                health.ImageView = img;
                db.SaveChanges();
            }
        }

        public static void Remove(int healthId)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                db.Healths.Remove(db.Healths.Where(c => c.Id == healthId).FirstOrDefault());
                db.SaveChanges();
            }
        }

        public static Health GetDate(List<Health> healths)
        {
            var i = healths
                .Where(h => h.DateNextMeeting.Date > DateTime.Now.Date)
                .OrderBy(h => h.DateNextMeeting.Date)
                .FirstOrDefault();

            return i;
        }
    }
}
