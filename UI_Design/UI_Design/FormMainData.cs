using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DateSpan = System.Data.Linq.SqlClient.SqlMethods;

namespace UI_Design
{
    public partial class FormMainData : Form
    {
        private static Child child = null;
        private static Parent parent = null;
        private static List<Health> health = null;

        public FormMainData(Child _child, Parent _parent)
        {
            InitializeComponent();
            child = _child;
            parent = _parent;
        }

        private void FormMainData_Load(object sender, EventArgs e)
        {
            try
            {
                if (child != null)
                    ChildShowData();
                if (parent != null)
                    lblParentName.Text = $"{parent.FirstName} {parent.LastName}";
            }
            catch (Exception)
            {}          
        }

        private void ChildShowData()//вывод данных о ребенке на главную форму
        {
            try
            {
                lblBirthday.Text = child.Birthday.ToShortDateString();
                lblGender.Text = GetGender(child.Gender);

                lblFeast.Text = ShowFeast(child.Birthday).ToString();

                health = HealthRepos.FindByChild(child);
            }
            catch (Exception)
            { }
            try
            {
                lblDateHealth.Text = HealthRepos.GetDate(health).DateNextMeeting.ToShortDateString().ToString();
            }
            catch (Exception)
            {}
            try
            {
                lblGrowth.Text = GrowthRepos.GetGrowth(child.Id).Growth.ToString() + " см";
            }
            catch (Exception)
            {}
            try
            {
                lblWeight.Text = GrowthRepos.GetWeight(child.Id).Weight.ToString() + " кг";
            }
            catch (Exception)
            { }

        }

        private string ShowFeast(DateTime feast)//показать праздник
        {
            DateTime dateNow = DateTime.Now;

            int yearDiff = Math.Abs(DateSpan.DateDiffYear(feast, dateNow));
            int dayDiff = Math.Abs(DateSpan.DateDiffDay(dateNow, feast));

            if (yearDiff > 0)
            {
                return ((365 * yearDiff) + 1 - dayDiff).ToString() + " дн.";
            }
            else
                return Math.Abs(((365*yearDiff) - dayDiff)).ToString() + " дн.";
        }

        private string GetGender(int gender)//дешифратор пола ребенка
        {
            if (gender == 0)
                return ($"дочь {child.FirstName}");
            else if (gender == 1)
                return ($"сын {child.FirstName}");
            else
                return "нафиг такой пол";
        }
    }
}
