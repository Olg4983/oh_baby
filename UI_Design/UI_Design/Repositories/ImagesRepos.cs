﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    class ImagesRepos
    {
        private static Imagge tempImg;
        public static void AddImg(string TitleImg, byte[] Img, Child inputChild)//добавление img в базу
        {
            //try
            //{
            //    using (BabyDbContext db = new BabyDbContext())
            //    {
            //        tempImg = null;

                    

            //        Parent par = db.Parents.FirstOrDefault(p => p.Id == inputParent.Id);
                  
            //        ICollection<Child> result = par.Children;
            //        Child child = result.FirstOrDefault<Child>();
               
            //        child.Images.Add(newImg);
            //        db.SaveChanges();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    FormMessage.Show(ex.Message);
            //}
            using (BabyDbContext db = new BabyDbContext())
            {
                Imagge newImg = new Imagge()
                {
                    Title = TitleImg,
                    ImageView = Img
                };
                var childd = db.Childs.FirstOrDefault(c => c.Id == inputChild.Id);
                childd.Images.Add(newImg);
                db.SaveChanges();               
            }
        }
    }
}
