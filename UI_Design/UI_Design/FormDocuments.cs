using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    
    public partial class FormDocuments : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
       
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        ); 
        
        private static Child child;
        private static Parent parent;
        public static string nameButton=null;
        public static Imagge img = null;
        public static List<Imagge> imagges = new List<Imagge>();
        int i=0;
        public static byte[] byteImg = null;
        private readonly FormMain formMain;

        public FormDocuments(Parent _parent, Child _child, FormMain _formMain)
        {
            InitializeComponent();

            formMain = _formMain;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            child = _child;
            parent = _parent;

        }

        private void FormDocuments_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                imagges.Clear();
                using (BabyDbContext db = new BabyDbContext())
                {
                    List<Imagge> img = db.Images.ToList();

                    for (int i = 0; i < img.Count; i++)
                    {
                        if (img[i].Child_Id == child.Id && img[i].Categor == nameButton)
                        {
                            imagges.Add(img[i]);
                        }
                    }
                }
                using (BabyDbContext db = new BabyDbContext())
                {
                    i++;
                    if (i >= imagges.Count)
                        i = 0;

                        byteImg = imagges[i].ImageView;
                    using (MemoryStream ms = new MemoryStream(byteImg, 0, byteImg.Length))
                    {
                            pictureBox1.BackgroundImage = Image.FromStream(ms);                 
                    }                 
                }
            }
            catch
            { }                
        }
        
        private void butAdd_Click(object sender, EventArgs e)
        {
            if(nameButton!=null)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.CheckFileExists = true;
                dialog.Multiselect = false;
                dialog.Filter = "Image Files(*.bmp;*.png;*.jpg;*.jpeg;)|*.bmp;*.png;*.jpg;*.jpeg;";
                byte[] byteImg1 = null;
                if(dialog.ShowDialog()==DialogResult.OK)
                {
                    byteImg1 = File.ReadAllBytes(dialog.FileName);
                    ImagesRepos.AddImg(dialog.FileName, byteImg1, child, nameButton);
                }
                ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
            }         
        }
        private void FormDocuments_Load_1(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage =null;
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Imagge img = db.Images.FirstOrDefault(i => i.Child_Id == child.Id && i.ImageView == byteImg);
                    db.Images.Remove(img);
                
                    db.SaveChanges();               
                }
                pictureBox1.BackgroundImage = Properties.Resources.dell;
                if (imagges.Count==0)
                    pictureBox1.BackgroundImage = Properties.Resources.noImg;
            }
            catch
            {
                
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            { 
                imagges.Clear();
                using (BabyDbContext db = new BabyDbContext())
                {
                    List<Imagge> img = db.Images.ToList();

                    for (int i = 0; i < img.Count; i++)
                    {
                        if (img[i].Child_Id == child.Id && img[i].Categor == nameButton)
                        {
                            imagges.Add(img[i]);
                        }
                    }
                }
                using (BabyDbContext db = new BabyDbContext())
                {
                    i--;
                    if (i <0)
                    i = imagges.Count-1;
                    byteImg = imagges[i].ImageView;
                    using (MemoryStream ms = new MemoryStream(byteImg, 0, byteImg.Length))
                    {
                      pictureBox1.BackgroundImage = Image.FromStream(ms);                  
                    }
                }
            }
            catch
            {
                       
            }
        }
        private void butSv_Click(object sender, EventArgs e)
        {
            nameButton = butSv.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void butUaPas_Click(object sender, EventArgs e)
        {
            nameButton = butUaPas.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void butZagPas_Click(object sender, EventArgs e)
        {
            nameButton = butZagPas.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void butInn_Click(object sender, EventArgs e)
        {
            nameButton = butInn.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void butStrah_Click(object sender, EventArgs e)
        {
            nameButton = butStrah.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void butUch_Click(object sender, EventArgs e)
        {
            nameButton = butUch.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void butSport_Click(object sender, EventArgs e)
        {
            nameButton = butSport.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void btnElse_Click(object sender, EventArgs e)
        {
            nameButton = btnElse.Text;
            ImagesRepos.ViewImgCateg(nameButton, imagges, child, byteImg, pictureBox1);
        }

        private void ButPrint_Click(object sender, EventArgs e)
        {            
            PrintDocument printDocument = new PrintDocument();// объект для печати            
            printDocument.PrintPage += PrintDocument_PrintPage;// обработчик события печати            
            printDialog.Document = printDocument;// установка объекта печати для его настройки

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.BackgroundImage, new Point(5, 5));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                FormViewImage formView = new FormViewImage(pictureBox1.BackgroundImage, formMain);
                formView.ShowDialog();
            }
            catch (Exception)
            {
                FormMessage.Show("Не удается открыть картинку...");
            }
        }

        public void Init()
        {
            butSv.PerformClick();
        }
    }
}
