using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class FormAddHealth : Form
    {
        private static Child child = null;
        private static byte[] tempImg;
        private Point MouseHook;

        public FormAddHealth(Child _child)
        {
            InitializeComponent();
            child = _child;
            StylesService.SetEnabledPropDateTP(dtpMeeting, false, false);
            StylesService.SetEnabledPropDateTP(dtpNextMeeting, false, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnAddHealth_Click(object sender, EventArgs e)
        {
            if (ValidateService.VerifyAddHealth(txtLastName.Text, txtFirstName.Text, txtFatherName.Text, txtProff.Text))
            {
                HealthRepos.AddData(child.FirstName, txtLastName.Text, txtFirstName.Text, txtFatherName.Text, txtProff.Text, dtpMeeting.Value, dtpNextMeeting.Value, tempImg);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ChbUploadImg_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUploadImg.Checked == true)
                tempImg = AddImage();
            else
                tempImg = null;
        }

        private byte[] AddImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.Filter = "Image Files(*.bmp;*.png;*.jpg;*.jpeg;)|*.bmp;*.png;*.jpg;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
                return File.ReadAllBytes(dialog.FileName);
            else
                return null;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void DtpMeeting_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dtpMeeting.Value.ToShortDateString().ToString();
        }

        private void DtpNextMeeting_ValueChanged(object sender, EventArgs e)
        {
            txtDateNext.Text = dtpNextMeeting.Value.ToShortDateString().ToString();
        }
    }
}
