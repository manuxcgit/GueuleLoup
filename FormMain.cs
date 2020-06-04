using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GueuleLoup
{
    public partial class FormMain : Form
    {
        Bitmap v_dessin;
        Graphics v_graph;
        Point v_point1, v_point2;
        Pen PenBlack = new Pen(Color.Black, 1);
        public FormMain()
        {
            InitializeComponent();
            v_dessin = new Bitmap(pBox.Size.Width, pBox.Size.Height);
            v_graph = Graphics.FromImage(v_dessin);
            v_graph.FillRectangle(Brushes.White, 0, 0, pBox.Size.Width, pBox.Size.Height);
            pBox.Image = v_dessin;
        }

        private void e_pBox_MouseClick(object sender, MouseEventArgs e)
        {
            tBLongueur.Text = ((1 - Math.Abs( Math.Cos(Math.PI * (double)e.X / (double)pBox.Size.Width * 2.0)) * 20) + 19) .ToString();
            tBIndex.Text = ((int)((double)e.X / (double)pBox.Size.Width * 360.0) ).ToString();
        }

        private void e_tBAngle_TextChanged(object sender, EventArgs e)
        {
            v_point1 = new Point(0, (pBox.Size.Height / 2) + 20);
            v_graph.FillRectangle(Brushes.White, 0, 0, pBox.Size.Width, pBox.Size.Height);
            for (float i = 0; i < 360; i++)
            {
                v_point2.X = (int)(pBox.Size.Width * i / 360.0);
                v_point2.Y = (int)((1 - Math.Abs( Math.Cos(Math.PI * i / 180.0))) * -20 * pBox.Size.Width / 360.0) + (pBox.Size.Height / 2);
                v_graph.DrawLine(PenBlack, v_point1, v_point2);
                v_point1 = v_point2;
            }
            pBox.Image = v_dessin;
        }
    }
}
