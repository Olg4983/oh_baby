using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class FormRegister : Form
    {
        private Point MouseHook;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(ValidateService.VerifyRegister(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPass.Text,txtPassCheck.Text))
            {
                ParentRepos.Add(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPass.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnVisiblePassTrue_Click(object sender, EventArgs e)//показать пароль
        {
            StylesService.ViewEyePassTrue(sender, txtPass, txtPassCheck, BtnVisiblePassTrue_Click, BtnVisiblePassFalse_Click);
        }
        private void BtnVisiblePassFalse_Click(object sender, EventArgs e)//скрыть пароль
        {
            StylesService.ViewEyePassFalse(sender, txtPass, txtPassCheck, BtnVisiblePassTrue_Click, BtnVisiblePassFalse_Click);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
    }
}
