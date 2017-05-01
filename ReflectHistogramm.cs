using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graficcc
{
    class ReflectHistogramm : Histogramm
    {
        public ReflectHistogramm(Panel panel, DataGridView dataGridView, CheckBox checkBoxDVC, CheckBox checkBoxD) :
            base(panel, dataGridView, checkBoxDVC, checkBoxD) { }

        public override void DrawChart()
        {
            g.Clear(Color.Transparent);
            try
            {
                if (checkBoxD.Checked)
                {
                    int step = (int)(heigth * 0.05);
                    int step1 = heigth;                    
                    Pen pen = new Pen(Color.Gray, 1);
                    pen.DashStyle = DashStyle.Dot;

                    while (step1 > heigth - (heigth-40))
                    {
                        g.DrawLine(pen, new Point(0, step1), new Point(width, step1));
                        step1 -= step; 
                    }
                }

                if (values.LongLength == 1 && values.Max() > 0)
                {
                    RectangleF rec = new RectangleF(1, 0, width, heigth);
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
                        RectangleF rec = new RectangleF(x, 40, (width - deD) / eX, heigthD);
                        g.FillRectangle(new SolidBrush(Color.LightSkyBlue), rec);
                        x += (((width - deD) / eX) + (deD / (eX - 1)));

                    }
                }
            }
            catch
            { }
        }

        protected override void DrawValues()
        {
            try
            {
                Font font = new Font("Microsoft Sans Serif", 10);
                xY = 1;
                for (int i = 0; i < values.Length; i++)
                {
                    heigthD = (values[i] / max) * (heigth - 60);

                    PointF pointF = new PointF(xY, heigthD + 40);

                    g.DrawString(values[i].ToString(), font, new SolidBrush(Color.OrangeRed), pointF);

                    xY += (((width - deD) / eX) + (deD / (eX - 1)));
                }
            }
            catch { }
        }

        protected override void DrawCaptures()
        {
            try
            {
                Font font = new Font("Microsoft Sans Serif", 10);
                xY = 1;
                for (int i = 0; i < captures.Length; i++)
                {
                    heigthD = (values[i] / max) * (heigth - 60);

                    PointF pointF = new PointF(xY, 15);

                    g.DrawString(captures[i], font, new SolidBrush(Color.Brown), pointF);

                    xY += (((width - deD) / eX) + (deD / (eX - 1)));
                }
            }
            catch { }
        }
    }
}
