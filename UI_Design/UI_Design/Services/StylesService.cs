using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class StylesService
    {
        public static void ViewClickButton(object sender, Panel senderPanel)//перемещение панели (выделения) к любой нажатой кнопке
        {
            Button senderBtn = sender as Button;// приводим полученный объект к типу Button
            senderPanel.Height = senderBtn.Height;
            senderPanel.Top = senderBtn.Top;
            senderPanel.Left = senderBtn.Left;
            senderPanel.BringToFront();
            senderBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        public static void ViewClickButton(object sender, Panel senderPanel, Label senderLabel, string textLabel)//перемещение панели (выделения) к нажатой кнопке "Главная"
        {
            Button senderBtn = sender as Button;
            senderPanel.Height = senderBtn.Height;
            senderPanel.Top = senderBtn.Top;
            senderPanel.Left = senderBtn.Left;
            senderPanel.BringToFront();

            senderLabel.Text = textLabel;
        }
        public static void CreateForm(Form form, Panel senderPanel, Label senderLable, string titleForm)//стиль "дочерних" форм
        {
            senderLable.Text = titleForm;
            senderPanel.Controls.Clear();

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            senderPanel.Controls.Add(form);
            form.Show();
        }

        public static void ViewEyePassTrue(object senderButton, TextBox txtPass, TextBox txtPassCheck, EventHandler visiblePassTrue, EventHandler visiblePassFalse)//показать пароль регистрация
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '\0';
            txtPassCheck.PasswordChar = '\0';
            senderBtn.BackgroundImage = Properties.Resources.eye_32px;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassTrue);
            senderBtn.Click += new EventHandler(visiblePassFalse);
        }
        public static void ViewEyePassTrue(object senderButton, TextBox txtPass, EventHandler visiblePassTrue, EventHandler visiblePassFalse)//показать пароль логин
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '\0';
            senderBtn.BackgroundImage = Properties.Resources.eye_32px;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassTrue);
            senderBtn.Click += new EventHandler(visiblePassFalse);
        }
        public static void ViewEyePassFalse(object senderButton, TextBox txtPass, TextBox txtPassCheck, EventHandler visiblePassTrue, EventHandler visiblePassFalse)//скрыть пароль регистрация
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '*';
            txtPassCheck.PasswordChar = '*';
            senderBtn.BackgroundImage = Properties.Resources.eyelashes_3d_32px1;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassFalse);
            senderBtn.Click += new EventHandler(visiblePassTrue);
        }
        public static void ViewEyePassFalse(object senderButton, TextBox txtPass, EventHandler visiblePassTrue, EventHandler visiblePassFalse)//скрыть пароль логин
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '*';
            senderBtn.BackgroundImage = Properties.Resources.eyelashes_3d_32px1;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassFalse);
            senderBtn.Click += new EventHandler(visiblePassTrue);
        }

        public static void SetEnabledPropDateTP(DateTimePicker dtp, bool dateTimeNow, bool dateTimeWeek)//установка значений по умолчанию для календаря (DateTimePicker)
        {
            if (dateTimeNow)
            {
                dtp.Value = DateTime.Now;
                dtp.MaxDate = DateTime.Now;
                dtp.MinDate = DateTime.Now.AddYears(-20);//минимальная дата раждения ребенка - 20 лет назад
            }
            else if(dateTimeWeek)
            {
                dtp.Value = DateTime.Now.AddDays(7);
                dtp.MinDate = DateTime.Now.AddDays(1);
            }
            else
                dtp.MinDate = DateTime.Now;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";
        }
    }
}
