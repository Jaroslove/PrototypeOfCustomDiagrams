using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Graficcc
{
    class Pie:AGraph
    {
        float total, i1, i2, i3, i4, i5, deg1, deg2, deg3, deg4, deg5;

        public Pie(int x, int y, int width, int height, Panel pannel)
        {
            panel = pannel;
            rec = new Rectangle(x - 148, y - 56, width - 10, height - 10);
            bit = new Bitmap(width, height);
            g = Graphics.FromImage(bit);
            panel.Paint += new PaintEventHandler(panel_Paint);
        }

        public void GetValue(object sender)
        {
            TextBox curTextBox = (TextBox)sender;
            try
            {
                switch (curTextBox.Name)
                {
                    case "textBoxP1":
                        i1 = float.Parse(curTextBox.Text); break;
                    case "textBoxP2":
                        i2 = float.Parse(curTextBox.Text); break;
                    case "textBoxP3":
                        i3 = float.Parse(curTextBox.Text); break;
                    case "textBoxP4":
                        i4 = float.Parse(curTextBox.Text); break;
                    default:
                        i5 = float.Parse(curTextBox.Text); break;
                }
            }
            catch
            { curTextBox.Clear(); }
        }

        public override void DrawChart()
        {
            Brush b1 = new SolidBrush(Color.Black);
            Brush b2 = new SolidBrush(Color.Red);
            Brush b3 = new SolidBrush(Color.Blue);
            Brush b4 = new SolidBrush(Color.Yellow);
            Brush b5 = new SolidBrush(Color.Green);

            total = i1 + i2 + i3 + i4 + i5;

            deg1 = (i1 / total) * 360;

            deg2 = (i2 / total) * 360;

            deg3 = (i3 / total) * 360;

            deg4 = (i4 / total) * 360;

            deg5 = (i5 / total) * 360;


            if (bit != null)
            {
                if (deg1 != 0)
                    g.FillPie(b1, rec, 0, deg1);
                if (deg2 != 0)
                    g.FillPie(b2, rec, deg1, deg2);
                if (deg3 != 0)
                    g.FillPie(b3, rec, deg1 + deg2, deg3);
                if (deg4 != 0)
                    g.FillPie(b4, rec, deg1 + deg2 + deg3, deg4);
                if (deg5 != 0)
                    g.FillPie(b5, rec, deg1 + deg2 + deg3 + deg4, deg5);

                panel.Refresh();
            }
        }
    }
}
