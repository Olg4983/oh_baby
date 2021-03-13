using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class FormViewImage : Form
    {

        private Point MouseHook;
        private readonly FormMain formMain;

        public FormViewImage(byte[] img, FormMain _formMain)
        {
            InitializeComponent();

            formMain = _formMain;
            formMain.Opacity = 0.5;
            pictureBox1.Image = Image.FromStream(new MemoryStream(img));
            btnClose.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
        }
        public FormViewImage(Image img, FormMain _formMain)
        {
            InitializeComponent();

            formMain = _formMain;
            formMain.Opacity = 0.5;
            pictureBox1.Image = img;

            btnClose.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            btnPrint.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
        }
        protected override CreateParams CreateParams  //круто, но оставляет белую рамку вверху
        {
            get
            {
                const int WS_SIZEBOX = 0x40000;

                var cp = base.CreateParams;
                cp.Style |= WS_SIZEBOX;

                return cp;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            formMain.Opacity = 1.0;
            Close();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();// объект для печати            
            printDocument.PrintPage += PrintDocument_PrintPage;// обработчик события печати            
            printDialog.Document = printDocument;// установка объекта печати для его настройки

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.BackgroundImage, new Point(5, 5));
        }
    }
}
