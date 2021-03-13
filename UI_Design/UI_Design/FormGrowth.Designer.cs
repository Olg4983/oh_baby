
namespace UI_Design
{
    partial class FormGrowth
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
            this.panelG = new System.Windows.Forms.Panel();
            this.crtsnChrtDiagramm = new LiveCharts.WinForms.CartesianChart();
            this.cmbBoxYear = new System.Windows.Forms.ComboBox();
            this.txtBoxGr = new System.Windows.Forms.TextBox();
            this.txtBoxWght = new System.Windows.Forms.TextBox();
            this.rdBtnMnth = new System.Windows.Forms.RadioButton();
            this.rdBtnYr = new System.Windows.Forms.RadioButton();
            this.cmbBoxMonth = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGr = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBild = new System.Windows.Forms.Button();
            this.panelG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelG
            // 
            this.panelG.Controls.Add(this.crtsnChrtDiagramm);
            this.panelG.Location = new System.Drawing.Point(43, 216);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(1221, 402);
            this.panelG.TabIndex = 0;
            // 
            // crtsnChrtDiagramm
            // 
            this.crtsnChrtDiagramm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.crtsnChrtDiagramm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtsnChrtDiagramm.Location = new System.Drawing.Point(0, 0);
            this.crtsnChrtDiagramm.Name = "crtsnChrtDiagramm";
            this.crtsnChrtDiagramm.Size = new System.Drawing.Size(1221, 402);
            this.crtsnChrtDiagramm.TabIndex = 0;
            this.crtsnChrtDiagramm.Text = "cartesianChart1";
            
            // 
            // cmbBoxYear
            // 
            this.cmbBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxYear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.cmbBoxYear.FormattingEnabled = true;
            this.cmbBoxYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cmbBoxYear.Location = new System.Drawing.Point(364, 83);
            this.cmbBoxYear.Name = "cmbBoxYear";
            this.cmbBoxYear.Size = new System.Drawing.Size(121, 31);
            this.cmbBoxYear.TabIndex = 2;
            this.cmbBoxYear.Text = "лет";
            // 
            // txtBoxGr
            // 
            this.txtBoxGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtBoxGr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxGr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtBoxGr.Location = new System.Drawing.Point(949, 33);
            this.txtBoxGr.Name = "txtBoxGr";
            this.txtBoxGr.Size = new System.Drawing.Size(100, 31);
            this.txtBoxGr.TabIndex = 4;
            // 
            // txtBoxWght
            // 
            this.txtBoxWght.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtBoxWght.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxWght.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.txtBoxWght.Location = new System.Drawing.Point(949, 85);
            this.txtBoxWght.Name = "txtBoxWght";
            this.txtBoxWght.Size = new System.Drawing.Size(100, 31);
            this.txtBoxWght.TabIndex = 6;
            // 
            // rdBtnMnth
            // 
            this.rdBtnMnth.AutoSize = true;
            this.rdBtnMnth.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnMnth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.rdBtnMnth.Location = new System.Drawing.Point(189, 31);
            this.rdBtnMnth.Name = "rdBtnMnth";
            this.rdBtnMnth.Size = new System.Drawing.Size(116, 28);
            this.rdBtnMnth.TabIndex = 8;
            this.rdBtnMnth.TabStop = true;
            this.rdBtnMnth.Text = "До года";
            this.rdBtnMnth.UseVisualStyleBackColor = true;
            this.rdBtnMnth.CheckedChanged += new System.EventHandler(this.RdBtnMnth_CheckedChanged);
            // 
            // rdBtnYr
            // 
            this.rdBtnYr.AutoSize = true;
            this.rdBtnYr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnYr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.rdBtnYr.Location = new System.Drawing.Point(189, 81);
            this.rdBtnYr.Name = "rdBtnYr";
            this.rdBtnYr.Size = new System.Drawing.Size(150, 28);
            this.rdBtnYr.TabIndex = 9;
            this.rdBtnYr.TabStop = true;
            this.rdBtnYr.Text = "После года";
            this.rdBtnYr.UseVisualStyleBackColor = true;
            this.rdBtnYr.CheckedChanged += new System.EventHandler(this.RdBtnYr_CheckedChanged);
            // 
            // cmbBoxMonth
            // 
            this.cmbBoxMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxMonth.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.cmbBoxMonth.FormattingEnabled = true;
            this.cmbBoxMonth.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbBoxMonth.Location = new System.Drawing.Point(364, 28);
            this.cmbBoxMonth.Name = "cmbBoxMonth";
            this.cmbBoxMonth.Size = new System.Drawing.Size(121, 31);
            this.cmbBoxMonth.TabIndex = 11;
            this.cmbBoxMonth.Text = "месяцев";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblAge.Location = new System.Drawing.Point(33, 8);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(124, 28);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Возраст:";
            // 
            // lblGr
            // 
            this.lblGr.AutoSize = true;
            this.lblGr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblGr.Location = new System.Drawing.Point(819, 35);
            this.lblGr.Name = "lblGr";
            this.lblGr.Size = new System.Drawing.Size(60, 24);
            this.lblGr.TabIndex = 13;
            this.lblGr.Text = "Рост";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lbl.Location = new System.Drawing.Point(819, 85);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 24);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(615, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Параметры:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.rdBtnMnth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxWght);
            this.panel1.Controls.Add(this.cmbBoxYear);
            this.panel1.Controls.Add(this.rdBtnYr);
            this.panel1.Controls.Add(this.txtBoxGr);
            this.panel1.Controls.Add(this.cmbBoxMonth);
            this.panel1.Controls.Add(this.lblGr);
            this.panel1.Location = new System.Drawing.Point(43, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 132);
            this.panel1.TabIndex = 16;
            // 
            // btnBild
            // 
            this.btnBild.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_53;
            this.btnBild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBild.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnBild.Location = new System.Drawing.Point(437, 159);
            this.btnBild.Name = "btnBild";
            this.btnBild.Size = new System.Drawing.Size(445, 51);
            this.btnBild.TabIndex = 7;
            this.btnBild.Text = "Построить диаграмму";
            this.btnBild.UseVisualStyleBackColor = true;
            this.btnBild.Click += new System.EventHandler(this.BtnBild_Click);
            // 
            // FormGrowth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1309, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBild);
            this.Controls.Add(this.panelG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGrowth";
            this.Text = "FormGrowht";
           
            this.panelG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelG;
        private LiveCharts.WinForms.CartesianChart crtsnChrtDiagramm;
        private System.Windows.Forms.ComboBox cmbBoxYear;
        private System.Windows.Forms.TextBox txtBoxGr;
        private System.Windows.Forms.TextBox txtBoxWght;
        private System.Windows.Forms.Button btnBild;
        private System.Windows.Forms.RadioButton rdBtnMnth;
        private System.Windows.Forms.RadioButton rdBtnYr;
        private System.Windows.Forms.ComboBox cmbBoxMonth;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGr;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}