using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using DateSpan = System.Data.Linq.SqlClient.SqlMethods;
using System.Threading;

namespace UI_Design
{
    
    public partial class FormMain : Form
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

        readonly BabyDbContext db;

        private static Child child;
        private static Parent parent;
        private static List<Child> children = null;
        private int textLength = 0;

        private Point MouseHook;

        public FormMain()
        {
            db = new BabyDbContext();


            db.Parents.Load();
            db.Childs.Load();
            db.Growth_Weights.Load();
            db.Images.Load();
            db.Healths.Load();

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Opacity = 0.5;
            Show();

            FormLogin logForm = new FormLogin();

            if (logForm.ShowDialog() == DialogResult.OK)//если залогинились
            {
                Opacity = 1.0;

                parent = logForm.GetParent();//получили того кто залогинился

                GetParentChilds();//заполнили всех детей родителя (если есть) + child = cmbBoxNameChild.SelectedIndex(0); (первый ребенок в списке)

                BtnHome.PerformClick();
            }
            else
            {
                Opacity = 1.0;
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav, lblTitle, "> Главная <");

            FormMainData main = new FormMainData(child, parent);

            StylesService.CreateForm(main, pnlFormLoader, lblTitle, "> Главная <");
            if(child != null)
                GetGenderImg(child.Gender);
        }

        private void BtnDocuments_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormDocuments formDoc = new FormDocuments(parent, child, this);
            
            StylesService.CreateForm(formDoc, pnlFormLoader, lblTitle, "> Документы <");
            formDoc.Init();
        }

        private void BtnMed_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormMedicen formMed = new FormMedicen(child, this);
            StylesService.CreateForm(formMed, pnlFormLoader, lblTitle, "> Медицина <");
        }

        private void BtnGrowth_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormGrowth formGr = new FormGrowth(parent, child);
            StylesService.CreateForm(formGr, pnlFormLoader, lblTitle, "> Развитие <");
        }
                        
        private void BtnExit_Click(object sender, EventArgs e)
            
        {
            StylesService.ViewClickButton(sender, pnlNav);
            Application.Exit();
        }

        private void BtnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }        

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            Opacity = 0.5;

            FormAddChild formAddChild = new FormAddChild(parent);//Parent который залогинился передан в форму FormAddChild

            if(formAddChild.ShowDialog() == DialogResult.OK)
            {
                Opacity = 1.0;

                GetParentChilds();
            }
            else
            {
                BtnHome.PerformClick();
                Opacity = 1.0;
            }
        }

        private void CmbBoxNameChild_SelectedIndexChanged(object sender, EventArgs e)//выбрали другого ребенка
        {
            if (cmbBoxNameChild.Items.Count > 0)
                child = ChildRepos.FindByFirstName(FilterByFirstName(cmbBoxNameChild.SelectedItem.ToString()));

            BtnHome.PerformClick();
        }

        private void GetParentChilds()//получаем всех детей родителя и заполняем в ComboBox
        {
            children = ChildRepos.FindByParent(parent);
            cmbBoxNameChild.Items.Clear();
            string tmp=  string.Empty;

            if (children.Count > 0)
            {
                foreach (Child item in children)//заполнили ComboBox всеми детьми родителя
                {
                    tmp = item.FirstName + " " + item.LastName;
                    AutoSizeComboBox(tmp);
                    cmbBoxNameChild.Items.Add(tmp);                    
                }

                cmbBoxNameChild.SelectedIndex = 0;
                child = ChildRepos.FindByFirstName(FilterByFirstName(cmbBoxNameChild.SelectedItem.ToString()));//полчили сущность Child по умолчанию (если она уже есть), после загрузки
            }
        }

        private void AutoSizeComboBox(string txt)//подгоняем размер ComboBox под самое длинное имя ребенка
        {
            int parentWidth = cmbBoxNameChild.Parent.Width;
            float size = cmbBoxNameChild.Font.Size;
            if (textLength == 0)
            {
                textLength = txt.Length;
                lblTmp.Text = txt;
            }
            if(txt.Length > textLength)
                lblTmp.Text = txt;

            cmbBoxNameChild.Width = lblTmp.Width+15;

            if (lblTmp.Width+10 > parentWidth-2)
            {
                while(lblTmp.Width+10 > parentWidth - 2)
                {
                    lblTmp.Font = new Font(FontFamily.GenericSansSerif, size--);// было size = size -1;
                }

                cmbBoxNameChild.Font = new Font(FontFamily.GenericSansSerif, lblTmp.Font.Size);
                cmbBoxNameChild.Width = lblTmp.Width+15;
            }

            cmbBoxNameChild.Location = new Point((parentWidth - cmbBoxNameChild.Width) / 2, cmbBoxNameChild.Location.Y);
        }

        private string FilterByFirstName(string cbxSelItemFullName)//выбираем только имя ребенка, без фамилии
        {
            string[] temp;
            temp = cbxSelItemFullName.Split(' ');
            return temp[0];
        }

        private void GetGenderImg(int gender)//дешифратор пола ребенка
        {
            if (gender == 0)
            {
                pictureBox1.Image = Properties.Resources.sleeping_baby_girl_64px;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.babys_room_64px;            
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
    }
}
