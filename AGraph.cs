using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Graficcc
{
    abstract class AGraph:IGraph
    {
        protected Rectangle rec;
        protected Bitmap bit;
        protected Graphics g;
        protected Panel panel;

        protected int heigth, width; //the dimension of the panel

        //abstract public void GetValue(object sender);
        abstract public void DrawChart();
        public void SaveChart()
        {
            if (bit != null)
            {
                panel.BackColor = Color.Transparent;
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "png files (*.PNG)|*.PNG";
                if (save.ShowDialog() == DialogResult.OK && save.FileName.Length > 0)
                {
                    bit.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Диаграмма сохранена", "Подсказка");
                }
            }
        }
        protected void panel_Paint(object sender, PaintEventArgs e)
        {
            if (bit != null)
                e.Graphics.DrawImage(bit, new Point(0, 0));
        }
    }
}
