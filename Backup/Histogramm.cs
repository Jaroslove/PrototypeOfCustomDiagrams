using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graficcc
{
    class Histogramm:AGraph
    {
        
        protected float[] values;                 //for adding values of the chart's column
        protected string[] captures;              //for adding captures of the chart's column
        protected DataGridView dataGridView;
        protected CheckBox checkBoxDVC, checkBoxD;

        public Histogramm(Panel panel, DataGridView dataGridView, CheckBox checkBoxDVC, CheckBox checkBoxD)
        {
            this.panel = panel;
            this.dataGridView = dataGridView;
            this.checkBoxDVC = checkBoxDVC;
            this.checkBoxD = checkBoxD;
            bit = new Bitmap(panel.Width, panel.Height);
            g = Graphics.FromImage(bit);
            panel.Paint+=new PaintEventHandler(panel_Paint);
            dataGridView.CellValueChanged+=new DataGridViewCellEventHandler(dataGridView_CellValueChanged);
            dataGridView.CellValidating+=new DataGridViewCellValidatingEventHandler(dataGridView_CellValidating);
            heigth = panel.Height;
            width = panel.Width;
        }

        public virtual void GetValue()
        {
            try
            {
                int countRows = dataGridView.RowCount - 1;
                
                values = new float[countRows];
                captures = new string[countRows];

                for (int i = 0; i < values.Length; i++)
                {
                    try
                    {
                        try
                        { values[i] = float.Parse((dataGridView[1, i].Value.ToString())); }
                        catch
                        { dataGridView[1, i].Value = 0; return; }
                        captures[i] = dataGridView[0, i].Value.ToString();
                    }
                    catch
                    { MessageBox.Show("В одном из столбцов нет значения\nЕсли надо удалить строку - удалите все значения в столбцах этой строки", "Подсказка"); return; }
                }
            }
            catch
            { return; }
        }

        protected int x, eX, deD;
        protected float heigthD, max;

        public override void DrawChart()
        {
            g.Clear(Color.Transparent);
            try
            {
                if (checkBoxD.Checked)
                {
                    int step = (int)(heigth * 0.05);
                    int step1 = step;

                    Pen pen = new Pen(Color.Gray, 1);
                    pen.DashStyle = DashStyle.Dot;

                    while (step1 < heigth - 40)
                    {
                        g.DrawLine(pen, new Point(0, step1), new Point(width, step1));
                        step1 += step;
                    }
                }

                if (values.LongLength == 1 && values.Max() > 0)
                {
                    RectangleF rec = new RectangleF(1, heigth - 40, width, heigth);
                    g.FillRectangle(new SolidBrush(Color.LightSkyBlue), rec);
                }
                else
                {
                    x = 1;
                    eX = (int)values.LongLength;
                    deD = 15 * (eX - 1);
                    max = values.Max();
                    for (int i = 0; i < values.Length; i++)
                    {
                        heigthD = (values[i] / max) * (heigth - 60);
                        RectangleF rec = new RectangleF(x, (heigth - heigthD) - 40, (width - deD) / eX, heigthD);
                        g.FillRectangle(new SolidBrush(Color.LightSkyBlue), rec);
                        x += (((width - deD) / eX) + (deD / (eX - 1)));
                    }
                }
            }
            catch
            { }
        }

        protected int xY; protected Font font;

        protected virtual void DrawValues()
        {
            try
            {
                font = new Font("Microsoft Sans Serif", 10);
                xY = 1;
                for (int i = 0; i < values.Length; i++)
                {
                    heigthD = (values[i] / max) * (heigth - 60); //the heigth of the column

                    PointF pointF = new PointF(xY, (heigth - heigthD) - 60);

                    g.DrawString(values[i].ToString(), font, new SolidBrush(Color.OrangeRed), pointF);

                    xY += (((width - deD) / eX) + (deD / (eX - 1)));
                }
            }
            catch
            { }
        }

        protected virtual void DrawCaptures()
        {
            try
            {
                font = new Font("Microsoft Sans Serif", 10);
                xY = 1;
                for (int i = 0; i < captures.Length; i++)
                {
                    heigthD = (values[i] / max) * (heigth - 60);

                    PointF pointF = new PointF(xY, heigth - 30);

                    g.DrawString(captures[i], font, new SolidBrush(Color.Brown), pointF);

                    xY += (((width - deD) / eX) + (deD / (eX - 1)));

                }
            }
            catch
            { }
        }

        protected void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool isEmpty; object value;

            if (dataGridView.Rows.Count > 1)
                
                for (int row = 1; row < dataGridView.Rows.Count; ++row)
                {
                    isEmpty = true;
                    for (int col = 0; col < dataGridView.Columns.Count; ++col)
                    {
                        value = dataGridView.Rows[row].Cells[col].Value;
                        if (value != null && value.ToString().Length > 0)
                        {
                            isEmpty = false;
                            break;
                        }
                    }
                    if (isEmpty)
                    {
                        if (row == dataGridView.Rows.Count - 1)
                            continue;
                        dataGridView.Rows.RemoveAt(row--);
                    }
                }
        }

        protected void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var x = dataGridView.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString();
            var y = dataGridView.Rows[e.RowIndex].Cells[1].EditedFormattedValue.ToString();

            try
            {
                if (x.Length != 0 && y.Length == 0 || (int)dataGridView.Rows[e.RowIndex].Cells[1].Value < 0)
                {
                    dataGridView.Rows[e.RowIndex].Cells[1].Value = 0;
                }
            }
            catch
            { }
        }

        public void DrawAll()
        {
            if (!checkBoxDVC.Checked && !checkBoxD.Checked)
            {
                DrawChart();
                panel.Refresh();
            }
            if (checkBoxDVC.Checked && !checkBoxD.Checked)
            {
                DrawChart();
                DrawValues();
                DrawCaptures();
                panel.Refresh();
            }
            if (!checkBoxDVC.Checked && checkBoxD.Checked)
            {
                DrawChart();
                panel.Refresh();
            }
            if (checkBoxDVC.Checked && checkBoxD.Checked)
            {
                DrawChart();
                DrawValues();
                DrawCaptures();
                panel.Refresh();
            }
        }
    }
}
