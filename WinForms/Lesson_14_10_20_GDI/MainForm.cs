using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_14_10_20_GDI
{
    public partial class MainForm : Form
    {
        private Point oldPoint;
        private Color color = Color.Black;
        private int size = 3;

        //private GraphicsState graphics;
        //private Graphics gr;
        public MainForm()
        {
            InitializeComponent();

            ChangeImageColor();
            //Timer timer = new Timer();
            //timer.Interval = 1000;
            //timer.Tick += Timer_Tick;
            // timer.Start();   
            sizeToolStripComboBox.Items.AddRange(Enumerable.Range(1,10).Select(x => x as object).ToArray());
            sizeToolStripComboBox.SelectedIndex = 2;

        }

        private void ChangeImageColor()
        {
            Bitmap bitmap = new Bitmap(100, 100);

            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(color);

            colorToolStripButton.Image = bitmap;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int r = rand.Next(0, 255);
            int g = rand.Next(0, 255);
            int b = rand.Next(0, 255);

            var graphics = CreateGraphics();

            graphics.FillRectangle(new SolidBrush(Color.FromArgb(r,g,b)), 20, 20, 100, 100);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //if (gr == null)
            //{
            //    gr = CreateGraphics();
            //}
            //else
            //{
            //    e.Graphics.Restore(graphics);
            //}
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            
            //Random rand = new Random();
            //int r = rand.Next(0, 255);
            //int g = rand.Next(0, 255);
            //int b = rand.Next(0, 255);
            //int x = rand.Next(5, 200);
            //int y = rand.Next(5, 200);
            //int h = rand.Next(100, 200);
            //int w = rand.Next(100, 200);
            //if (gr == null)
            //{
            //    gr = CreateGraphics();
            //}
            //gr.FillRectangle(new SolidBrush(Color.FromArgb(r,g,b)),x,y,h,w);
            //graphics = gr.Save();
           
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //var graph = CreateGraphics();
                //graph.DrawLine(new Pen(Color.Green), oldPoint, new Point(e.X, e.Y));
                oldPoint.X = e.X;
                oldPoint.Y = e.Y;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                var graph = CreateGraphics();
               graph.DrawLine(new Pen(color,size), oldPoint, new Point(e.X, e.Y));
                
                // graph.FillRectangle(new SolidBrush(Color.Red), e.X, e.Y, 5, 5);
            }
            oldPoint.X = e.X;
            oldPoint.Y = e.Y;
        }

        private void colorToolStripButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = dialog.Color;

                ChangeImageColor();

                if (color.ToKnownColor() != 0)
                {
                    colorToolStripButton.Text = color.ToKnownColor().ToString();
                }
                else
                {
                    colorToolStripButton.Text = $"R:{color.R},G:{color.G},B:{color.B}";
                }
            }
        }

        private void sizeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = (int)sizeToolStripComboBox.SelectedIndex;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new Some();
            form.Show();
        }
    }
}
