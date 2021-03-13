using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class FormAddChild : Form
    {
        private static Parent parent;
        private Point MouseHook;

        public FormAddChild(Parent _parent)//приняли сущность Parent
        {
            InitializeComponent();
            parent = _parent;
            StylesService.SetEnabledPropDateTP(dtpBirthday, true, false);
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if(ValidateService.VerifyAddChild(txtFirstName.Text, txtLastName.Text, cbxGender.Text))
            {
                ChildRepos.Create(txtFirstName.Text, txtLastName.Text, dtpBirthday.Value, parent, cbxGender.SelectedIndex);//добавляем нового ребенка
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void DtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            txtDtp.Text = dtpBirthday.Value.ToShortDateString().ToString();
        }
    }
}
