using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

            if (Form1.redGraphData.Count > 800)
            {
                label1.Text = "Error: Graph Data too large";
                label2.Text = "";
                label3.Text = "";
            }
            else
            {
                float xInt = 800 / Form1.redGraphData.Count;

                Graphics gr = e.Graphics;
                label1.Text = "Total steps: " + Form1.blueGraphData.Count.ToString();
                gr.TranslateTransform(100, 25);
                gr.DrawLine(Pens.Black, new Point(0, 0), new Point(0, 150));

                for (int i = 0; i < Form1.redGraphData.Count - 1; i++)
                {
                    if (Form1.blueGraphData[i] > 0)
                        gr.DrawLine(Pens.Blue, new Point((int)(i * xInt), 150 - (int)Form1.blueGraphData[i]), new Point((int)((i + 1) * xInt), 150 - (int)Form1.blueGraphData[i + 1]));
                    if (Form1.redGraphData[i] > 0)
                        gr.DrawLine(Pens.Red, new Point((int)(i * xInt), 150 - (int)Form1.redGraphData[i]), new Point((int)((i + 1) * xInt), 150 - (int)Form1.redGraphData[i + 1]));
                    if (Form1.greenGraphData[i] > 0)
                        gr.DrawLine(Pens.Green, new Point((int)(i * xInt), 150 - (int)Form1.greenGraphData[i]), new Point((int)((i + 1) * xInt), 150 - (int)Form1.greenGraphData[i + 1]));
                    if (Form1.yellowGraphData[i] > 0)
                        gr.DrawLine(Pens.Yellow, new Point((int)(i * xInt), 150 - (int)Form1.yellowGraphData[i]), new Point((int)((i + 1) * xInt), 150 - (int)Form1.yellowGraphData[i + 1]));
                    if (Form1.pinkGraphData[i] > 0)
                        gr.DrawLine(Pens.Pink, new Point((int)(i * xInt), 150 - (int)Form1.pinkGraphData[i]), new Point((int)((i + 1) * xInt), 150 - (int)Form1.pinkGraphData[i + 1]));
                    gr.DrawLine(Pens.Black, new Point((int)(i * xInt), 150), new Point((int)((i + 1) * xInt), 150));
                }
            }
        }
    }
}
