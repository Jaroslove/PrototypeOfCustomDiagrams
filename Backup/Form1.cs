using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graficcc
{
    public partial class MainForm : Form
    {
        
        Pie PieChart;
        Histogramm HistoChart;
        ReflectHistogramm RefHistog;
        Diagramm Diagramm;
        
        public MainForm()
        {
            InitializeComponent();
            PieChart = new Pie(panelPD.Location.X, panelPD.Location.Y, panelPD.Width, panelPD.Height, panelPD);
            HistoChart = new Histogramm(panelHistogramm, dataGridViewHistogramm, checkBoxHistogram, checkBoxDashH);
            RefHistog = new ReflectHistogramm(panelRefHis, dataGridViewHistogramm, checkBoxHistogram, checkBoxDashH);
            Diagramm = new Diagramm(panelDiagramm, dataGridViewHistogramm, checkBoxHistogram, checkBoxDashH);
        }

        void GetNumber(object sender, EventArgs e)
        {
            PieChart.GetValue(sender);
            PieChart.DrawChart();
        }

        private void сохранитьКруговуюДиаграммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PieChart.SaveChart();
        }

        private void dataGridViewHistogramm_CellValidated(object sender, DataGridViewCellEventArgs e)
        { 
            HistoChart.GetValue();
            HistoChart.DrawAll();
            
            RefHistog.GetValue();
            RefHistog.DrawAll();

            Diagramm.GetValue();
            Diagramm.DrawAll();
        }

        private void checkBoxHistogram_CheckedChanged(object sender, EventArgs e)
        {
            HistoChart.DrawAll();
            RefHistog.DrawAll();
            Diagramm.DrawAll();
        }

        private void сохранитьГистограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoChart.SaveChart();
        }

        private void checkBoxDashH_CheckedChanged(object sender, EventArgs e)
        {
            HistoChart.DrawAll();
            RefHistog.DrawAll();
            Diagramm.DrawAll();
        }

        private void сохранитьЗеркальнуюГистограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefHistog.SaveChart();
        }

        private void сохранитьДиаграммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diagramm.SaveChart();
        }

    }
}
