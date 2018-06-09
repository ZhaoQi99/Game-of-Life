using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            generation.Interval = 100;
            BtnStop.Enabled = false;
            BtnStart.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Game(Convert.ToInt32(NumericCell.Value), Convert.ToInt32(NumericCell.Value));
            game.Rand();
            generation.Enabled = true;
            BtnStart.Enabled = false;
            show();
        }

        private void generation_Tick(object sender, EventArgs e)
        {
            game.generation();
            show();
        }
        private void show()
        {
            Bitmap map = new Bitmap(PicBoxCell.Width, PicBoxCell.Height);
            Graphics g = Graphics.FromImage(map);
            g.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black);

            int cell_size = PicBoxCell.Width / Convert.ToInt32(NumericCell.Value);
            bool[,] status = game.cellStatus();
            for (int i = 0; i < Convert.ToInt32(NumericCell.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(NumericCell.Value); j++)
                {
                    Rectangle rec = new Rectangle(i * cell_size, j * cell_size, cell_size, cell_size);
                    g.DrawRectangle(pen, rec);
                    if (status[i, j] == true)
                    {
                        g.FillRectangle(new SolidBrush(Color.Black), rec);
                    }
                }
            }
            PicBoxCell.Image = map;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            generation.Enabled = false;
        }
    }
}
