using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace GueuleLoup
{
    public partial class FormMain : Form
    {
        Bitmap v_dessin;
        Graphics v_graph;
        Point v_point1, v_point2;
        Pen PenBlack = new Pen(Color.Black, 1);
        Font FontArial = new Font("Arial", 16);
        SolidBrush BrushBlack = new SolidBrush(Color.Black);
        bool v_calculed = false;

        double v_diametre, v_epaisseur, v_longueur_interception, v_angle, v_long1, v_long2, v_angle_sous_souris, v_longueur_sous_souris, v_angle1, v_angle2;

        public FormMain()
        {
            InitializeComponent();
            v_dessin = new Bitmap(pBox.Size.Width, pBox.Size.Height);
            v_graph = Graphics.FromImage(v_dessin);
            v_graph.FillRectangle(Brushes.White, 0, 0, pBox.Size.Width, pBox.Size.Height);
            pBox.Image = v_dessin;
            m_dessiner();

        }

        private void e_bImprimer_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) { }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(v_dessin, 0, 0, pBox.Size.Width * 78 / 100, pBox.Size.Height * 78 / 100);
        }

        void m_dessiner()
        {
            try
            {
                v_angle = 90 - float.Parse(tBAngle.Text);
                v_diametre = double.Parse(tBDiametre.Text);
                v_epaisseur = double.Parse(tBEpaisseur.Text);
                v_diametre -= 2 * v_epaisseur;
                v_longueur_interception = v_diametre * (float)Math.Sqrt(1 + (Math.Tan(RAD(v_angle)) * Math.Tan(RAD(v_angle))));
                v_long1 = v_diametre / 2 * Math.Cos(RAD(v_angle));
                v_long2 = v_longueur_interception - v_long1;
                v_angle1 = Math.Atan(v_diametre / v_long1 / 2);
                v_angle2 = Math.Atan(v_diametre / v_long2 / 2);
                v_point1 = new Point(0, (pBox.Size.Height / 2) + 20);
                v_graph.FillRectangle(Brushes.White, 0, 0, pBox.Size.Width, pBox.Size.Height);
                v_graph.DrawRectangle(PenBlack, 0, 0, pBox.Size.Width - 1, pBox.Size.Height - 1);
                for (float i = 0; i < 180; i++)
                {
                    v_point2.X = (int)(pBox.Size.Width * i / 360.0);
                    if (i < 90) //5.12 = 125.6mm de circonference pour 640 pixel
                    {
                        v_point2.Y = (int)(m_calcul(i, v_diametre / 2 * 5.12) * Math.Tan(v_angle1)) + (pBox.Size.Height / 2) - 100;//((Math.Abs(Math.Cos(Math.PI * i / 180.0))) * v_long1 * pBox.Size.Width / 360.0) + (pBox.Size.Height / 2);
                    }
                    else
                    {
                        v_point2.Y = (int)(m_calcul(i, v_diametre / 2 * 5.12) * Math.Tan(v_angle2)) + (pBox.Size.Height / 2) - 100; //((Math.Abs(Math.Cos(Math.PI * i / 180.0))) * v_long2 * pBox.Size.Width / 360.0) + (pBox.Size.Height / 2);
                    }

                    v_graph.DrawLine(PenBlack, v_point1, v_point2);
                    v_point1 = v_point2;
                }
                for (float i = 180; i < 360; i++)
                {
                    v_point2.X = (int)(pBox.Size.Width * i / 360.0);
                    if (i < 270)
                    {
                        v_point2.Y = (int)(m_calcul(i, v_diametre / 2 * 5.12) * Math.Tan(v_angle2)) + (pBox.Size.Height / 2) - 100; //(int)m_calcul(i, v_long2 * 5.12) + (pBox.Size.Height / 2) - 100; //((Math.Abs(Math.Cos(Math.PI * i / 180.0))) * v_long2 * pBox.Size.Width / 360.0) + (pBox.Size.Height / 2);
                    }
                    else
                    {
                        v_point2.Y = (int)(m_calcul(i, v_diametre / 2 * 5.12) * Math.Tan(v_angle1)) + (pBox.Size.Height / 2) - 100;//(int)m_calcul(i, v_long1 * 5.12) + (pBox.Size.Height / 2) - 100; //((Math.Abs(Math.Cos(Math.PI * i / 180.0))) * v_long1 * pBox.Size.Width / 360.0) + (pBox.Size.Height / 2);
                    }
                    v_graph.DrawLine(PenBlack, v_point1, v_point2);
                    v_point1 = v_point2;
                }
                v_graph.DrawString("Angle : " + (90 - v_angle).ToString() + "°", FontArial, BrushBlack, 260, 250);
                pBox.Image = v_dessin;
                v_calculed = true;
            }
            catch { }
        }

        private void e_pBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (v_calculed)
            {
                v_angle_sous_souris = (double)e.X / (double)pBox.Size.Width * 360.0;
                if (v_angle_sous_souris < 90)
                {
                    v_longueur_sous_souris = m_calcul(v_angle_sous_souris, v_diametre / 2) * Math.Tan(v_angle1);// m_calcul(v_angle_sous_souris, v_long1);// * pBox.Size.Width / 360.0) + (pBox.Size.Height / 2); (Math.Abs(Math.Cos(Math.PI * v_angle_sous_souris / 180.0))) * v_long1;
                }
                else
                    if (v_angle_sous_souris < 180)
                {
                    v_longueur_sous_souris = m_calcul(v_angle_sous_souris, v_diametre / 2) * Math.Tan(v_angle2);// m_calcul(v_angle_sous_souris, v_long2); //(Math.Abs(Math.Cos(Math.PI * v_angle_sous_souris / 180.0))) * v_long2;
                }
                else
                    if (v_angle_sous_souris < 270)
                {
                    v_longueur_sous_souris = m_calcul(v_angle_sous_souris, v_diametre / 2) * Math.Tan(v_angle2);// m_calcul(v_angle_sous_souris, v_long2); //(Math.Abs(Math.Cos(Math.PI * v_angle_sous_souris / 180.0))) * v_long2;
                }
                else
                {
                    v_longueur_sous_souris = m_calcul(v_angle_sous_souris, v_diametre / 2) * Math.Tan(v_angle1);// m_calcul(v_angle_sous_souris, v_long1); //(Math.Abs(Math.Cos(Math.PI * v_angle_sous_souris / 180.0))) * v_long1; ;
                }
                tBLongueur.Text = ((v_diametre / 2) - v_longueur_sous_souris).ToString();
                tBIndex.Text = ((int)v_angle_sous_souris).ToString();
            }
        }

        double m_calcul(double pAngle, double pLongueur)
        {
            return Math.Abs(Math.Cos(RAD(pAngle))) * pLongueur;
        }

        double RAD(double pAngle)
        {
            return (Math.PI * pAngle / 180.0);
        }

        private void e_tBValeur_TextChanged(object sender, EventArgs e)
        {
            m_dessiner();
        }
    }
}