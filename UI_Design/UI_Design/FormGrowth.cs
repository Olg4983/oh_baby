using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace UI_Design
{
    public partial class FormGrowth : Form
    {
        private static Child child;
        private static Parent parent;

        private static ChartValues<float> weight = new ChartValues<float>();
        private static ChartValues<int> growth = new ChartValues<int>();

        private static List<string> ageMonth = new List<string>();
        private static string x = null;

        public FormGrowth(Parent _parent, Child _child)
        {
            InitializeComponent();
            child = _child;
            parent = _parent;

            ShowDiagramm(cmbBoxYear.Enabled);
        }        
       
        private void BtnBild_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdBtnMnth.Checked == false && rdBtnYr.Checked == false)
                    FormMessage.Show("Выберите варианты построения диаграммы...");
                if (rdBtnYr.Checked == true)
                {
                    cmbBoxYear.Text = "0";
                    x = (Int32.Parse(cmbBoxYear.Text) * 12).ToString();
                }
                if (rdBtnMnth.Checked == true)
                {
                    cmbBoxMonth.Text = "0";
                    x = cmbBoxMonth.Text;
                }

                if (ValidateService.VerifiyAddDataDiagramm(x, txtBoxGr.Text, txtBoxWght.Text))
                {
                    GrowthRepos.Add(x, txtBoxGr.Text, txtBoxWght.Text, child.Id);//добавляем данные в базу
                    ShowDiagramm(cmbBoxYear.Enabled);
                }
            }
            catch { }
        }

        private void FillDataDiag(List<Growth_Weight> growths)//заполнить диаграмму данными
        {
            ageMonth.Clear();
            growth.Clear();
            weight.Clear();

            foreach (var i in growths)
            {
                if (i.Child_Id == child.Id)
                {
                    growth.Add(i.Growth);
                    weight.Add(i.Weight);
                    ageMonth.Add(i.AgeMonth.ToString());
                }
            }
        }

        private void ShowDiagramm(bool checkYear)//показать диаграмму
        {
            try
            {
                FillDataDiag(GrowthRepos.Find(child.Id));

                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

                crtsnChrtDiagramm.AxisX.Clear();

                if (checkYear)
                {
                    crtsnChrtDiagramm.AxisX.Add(new LiveCharts.Wpf.Axis()
                    {
                        Title = "Возраст, лет",
                        Labels = ageMonth
                    });

                    LineSeries line1 = new LineSeries();
                    line1.Values = weight;
                    series.Add(line1);
                    crtsnChrtDiagramm.Series = series;

                    LineSeries line2 = new LineSeries();
                    line2.Values = growth;
                    series.Add(line2);
                    crtsnChrtDiagramm.Series = series;
                }
                else
                {
                    crtsnChrtDiagramm.AxisX.Add(new LiveCharts.Wpf.Axis()
                    {
                        Title = "Возраст, мес",
                        Labels = ageMonth
                    });

                    LineSeries line1 = new LineSeries();
                    line1.Values = weight;
                    series.Add(line1);
                    crtsnChrtDiagramm.Series = series;

                    LineSeries line2 = new LineSeries();
                    line2.Values = growth;
                    series.Add(line2);
                    crtsnChrtDiagramm.Series = series;
                }
            }
            catch (Exception)
            {}
        }

        private void RdBtnMnth_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxMonth.Enabled = true;
            cmbBoxYear.Enabled = false;
            cmbBoxYear.Text = "0";
        }

        private void RdBtnYr_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxYear.Enabled = true;
            cmbBoxMonth.Enabled = false;
            cmbBoxMonth.Text = "0";
        }
    }
}