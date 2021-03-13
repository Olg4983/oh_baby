using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class GrowthRepos
    {
        public static Growth_Weight GetGrowth(int childId)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                var growths = db.Growth_Weights
                    .Where(g => g.Child_Id == childId)
                    .OrderBy(g => g.Growth).ToList();

                return growths[growths.Count - 1];
            }
        }

        public static Growth_Weight GetWeight(int childId)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                var weights = db.Growth_Weights
                    .Where(g => g.Child_Id == childId)
                    .OrderBy(w => w.Weight).ToList();

                return weights[weights.Count - 1];
            }
        }

        public static void Add(string ageMonth, string growth, string weight, int childId)
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Growth_Weight new_gw = new Growth_Weight()
                    {
                        AgeMonth = Int32.Parse(ageMonth),
                        Growth = Int32.Parse(growth),
                        Weight = float.Parse(weight)
                    };
                    Child ch = db.Childs.FirstOrDefault(c => c.Id == childId);
                    ch.Growth_Weights.Add(new_gw);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                FormMessage.Show("Ошибка работы с базой при добавлении рост/вес...");
            }
        }

        public static List<Growth_Weight> Find(int childId)
        {
            using (BabyDbContext db = new BabyDbContext())
            {
                return db.Growth_Weights.Where(gr => gr.Child_Id == childId).ToList();
            }
        }
    }
}
