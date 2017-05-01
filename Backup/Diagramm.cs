using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graficcc
{
    class Diagramm : Histogramm
    {
        public Diagramm(Panel panel, DataGridView dataGridView, CheckBox checkBoxDVC, CheckBox checkBoxD) : 
            base(panel, dataGridView, checkBoxDVC, checkBoxD) { }

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

                    x = 1;
                    eX = (int)values.LongLength;
                    deD = 15 * (eX - 1);
                    max = values.Max();
                    Point[] points = new Point[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        heigthD = (values[i] / max) * (heigth - 60);
                        points[i] = new Point(x, (int)((heigth - heigthD) - 40));
                        x += (((width - deD) / eX) + (deD / (eX - 1)));
                    }

                    g.DrawCurve(new Pen(Color.Black,2),points);
            }
            catch
            { }
        }
    }
}
