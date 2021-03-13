
namespace UI_Design
{
    partial class FormAddHealth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAddHealth = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpMeeting = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProff = new System.Windows.Forms.Label();
            this.txtProff = new System.Windows.Forms.TextBox();
            this.dtpNextMeeting = new System.Windows.Forms.DateTimePicker();
            this.lblNextDate = new System.Windows.Forms.Label();
            this.chbUploadImg = new System.Windows.Forms.CheckBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDateNext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnAddHealth);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 539);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 107);
            this.panel1.TabIndex = 26;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 418);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(140, 34);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnAddHealth
            // 
            this.btnAddHealth.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnAddHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddHealth.FlatAppearance.BorderSize = 0;
            this.btnAddHealth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnAddHealth.Image = global::UI_Design.Properties.Resources.add_50px21;
            this.btnAddHealth.Location = new System.Drawing.Point(9, 21);
            this.btnAddHealth.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddHealth.Name = "btnAddHealth";
            this.btnAddHealth.Size = new System.Drawing.Size(218, 65);
            this.btnAddHealth.TabIndex = 5;
            this.btnAddHealth.Text = "Добавить";
            this.btnAddHealth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddHealth.UseVisualStyleBackColor = true;
            this.btnAddHealth.Click += new System.EventHandler(this.BtnAddHealth_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnCancel.Image = global::UI_Design.Properties.Resources.unavailable_50px;
            this.btnCancel.Location = new System.Drawing.Point(376, 21);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 65);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // dtpMeeting
            // 
            this.dtpMeeting.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpMeeting.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpMeeting.CustomFormat = "";
            this.dtpMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMeeting.Location = new System.Drawing.Point(274, 336);
            this.dtpMeeting.Name = "dtpMeeting";
            this.dtpMeeting.Size = new System.Drawing.Size(212, 28);
            this.dtpMeeting.TabIndex = 45;
            this.dtpMeeting.Value = new System.DateTime(2021, 2, 28, 0, 0, 0, 0);
            this.dtpMeeting.ValueChanged += new System.EventHandler(this.DtpMeeting_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblDate.Location = new System.Drawing.Point(92, 314);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 50);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Дата приема";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProff
            // 
            this.lblProff.AutoSize = true;
            this.lblProff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblProff.Location = new System.Drawing.Point(103, 261);
            this.lblProff.Name = "lblProff";
            this.lblProff.Size = new System.Drawing.Size(128, 24);
            this.lblProff.TabIndex = 43;
            this.lblProff.Text = "Специалист";
            // 
            // txtProff
            // 
            this.txtProff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtProff.Location = new System.Drawing.Point(273, 261);
            this.txtProff.Name = "txtProff";
            this.txtProff.Size = new System.Drawing.Size(213, 28);
            this.txtProff.TabIndex = 40;
            // 
            // dtpNextMeeting
            // 
            this.dtpNextMeeting.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpNextMeeting.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpNextMeeting.CustomFormat = "";
            this.dtpNextMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNextMeeting.Location = new System.Drawing.Point(273, 415);
            this.dtpNextMeeting.Name = "dtpNextMeeting";
            this.dtpNextMeeting.Size = new System.Drawing.Size(213, 28);
            this.dtpNextMeeting.TabIndex = 48;
            this.dtpNextMeeting.Value = new System.DateTime(2021, 2, 28, 0, 0, 0, 0);
            this.dtpNextMeeting.ValueChanged += new System.EventHandler(this.DtpNextMeeting_ValueChanged);
            // 
            // lblNextDate
            // 
            this.lblNextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblNextDate.Location = new System.Drawing.Point(92, 392);
            this.lblNextDate.Name = "lblNextDate";
            this.lblNextDate.Size = new System.Drawing.Size(139, 79);
            this.lblNextDate.TabIndex = 47;
            this.lblNextDate.Text = "Дата следующего приема";
            this.lblNextDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbUploadImg
            // 
            this.chbUploadImg.AutoSize = true;
            this.chbUploadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.chbUploadImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.chbUploadImg.Location = new System.Drawing.Point(107, 494);
            this.chbUploadImg.Name = "chbUploadImg";
            this.chbUploadImg.Size = new System.Drawing.Size(199, 28);
            this.chbUploadImg.TabIndex = 50;
            this.chbUploadImg.Text = "Загрузить фото?";
            this.chbUploadImg.UseVisualStyleBackColor = true;
            this.chbUploadImg.CheckedChanged += new System.EventHandler(this.ChbUploadImg_CheckedChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblFirstName.Location = new System.Drawing.Point(102, 146);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(49, 24);
            this.lblFirstName.TabIndex = 62;
            this.lblFirstName.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtFirstName.Location = new System.Drawing.Point(272, 142);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 28);
            this.txtFirstName.TabIndex = 61;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblFatherName.Location = new System.Drawing.Point(102, 187);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(106, 24);
            this.lblFatherName.TabIndex = 60;
            this.lblFatherName.Text = "Отчество";
            // 
            // txtFatherName
            // 
            this.txtFatherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtFatherName.Location = new System.Drawing.Point(272, 183);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(213, 28);
            this.txtFatherName.TabIndex = 59;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblLastName.Location = new System.Drawing.Point(102, 106);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(98, 24);
            this.lblLastName.TabIndex = 58;
            this.lblLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtLastName.Location = new System.Drawing.Point(272, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 28);
            this.txtLastName.TabIndex = 57;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtDate.Location = new System.Drawing.Point(272, 336);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(203, 28);
            this.txtDate.TabIndex = 63;
            // 
            // txtDateNext
            // 
            this.txtDateNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDateNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtDateNext.Location = new System.Drawing.Point(272, 415);
            this.txtDateNext.Name = "txtDateNext";
            this.txtDateNext.ReadOnly = true;
            this.txtDateNext.Size = new System.Drawing.Size(203, 28);
            this.txtDateNext.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.label6.Image = global::UI_Design.Properties.Resources.Untitled_8;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(582, 41);
            this.label6.TabIndex = 46;
            this.label6.Text = "ДОБАВИТЬ ВИЗИТ К ВРАЧУ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddHealth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(605, 646);
            this.Controls.Add(this.txtDateNext);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.chbUploadImg);
            this.Controls.Add(this.dtpNextMeeting);
            this.Controls.Add(this.lblNextDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpMeeting);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblProff);
            this.Controls.Add(this.txtProff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddHealth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddHealth";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAddHealth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpMeeting;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProff;
        private System.Windows.Forms.TextBox txtProff;
        private System.Windows.Forms.DateTimePicker dtpNextMeeting;
        private System.Windows.Forms.Label lblNextDate;
        private System.Windows.Forms.CheckBox chbUploadImg;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDateNext;
    }
}