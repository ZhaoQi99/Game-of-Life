using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Media;
using System.Reflection;
using System.IO;

namespace GameOfLife
{
    public partial class FormMain : CCSkinMain
    {
        Game game;
        Color BrushColor = Color.Black;
        public FormMain()
        {
            InitializeComponent();
            generation.Interval = 110 - Convert.ToInt32(NumicSpeed.Value) * 10;
            BtnStop.Enabled = false;
            BtnStart.Enabled = true;
            BtnPause.Enabled = false;
            int SH = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            this.Width = (int)(SH * 0.9 + 0.5); // 设置窗体宽度
            this.Height = (int)(SH * 0.9 + 0.5); // 设置窗体高度
            PicBoxCell.Width = (int)(this.Width * 0.8);
            PicBoxCell.Height = (int)(this.Width * 0.8);
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = this.Bottom - panel1.Height - 5;

        }

        //开始按钮的Click事件
        private void BtnStart_Click(object sender, EventArgs e)
        {
            PicBoxCell.Width = (int)(this.Width * 0.8);
            PicBoxCell.Height = (int)(this.Width * 0.8);
            if (game == null)
            {
                game = new Game(Convert.ToInt32(NumericCell.Value), Convert.ToInt32(NumericCell.Value));
                if (RadBtnRand.Checked == true)
                    game.Rand();
                if (RadBtnOne.Checked == true)
                {
                    if(Convert.ToInt32(NumericCell.Value)<40)
                        game = new Game(40,40);
                    game.StyleOne();

                }
                if(RadBtnTwo.Checked==true)
                {
                    if (Convert.ToInt32(NumericCell.Value) < 40)
                        game = new Game(40, 40);
                    game.StyleTwo();
                }
                if(RadBtnThree.Checked==true)
                {
                    if (Convert.ToInt32(NumericCell.Value) < 40)
                        game = new Game(40, 40);
                    game.StyleThree();
                }
            }
            BtnPause.Enabled = true;
            generation.Enabled = true;
            BtnStop.Enabled = true;
            BtnStart.Enabled = false;
            show();
            NumericCell.Enabled = false;
        }

        //产生下一代
        private void generation_Tick(object sender, EventArgs e)
        {
            game.generation();
            show();
        }
        //更新PictureBox
        private void show()
        {
            int cell_size = PicBoxCell.Width / Convert.ToInt32(NumericCell.Value);
            Bitmap map = new Bitmap(cell_size * Convert.ToInt32(NumericCell.Value), cell_size * Convert.ToInt32(NumericCell.Value));
            Graphics g = Graphics.FromImage(map);
            g.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black);

            bool[,] status = game.cellStatus();
            for (int i = 0; i < Convert.ToInt32(NumericCell.Value) - 1; i++)
            {
                for (int j = 0; j < Convert.ToInt32(NumericCell.Value) - 1; j++)
                {
                    Rectangle rec = new Rectangle(j * cell_size, i * cell_size, cell_size, cell_size);
                    g.DrawRectangle(pen, rec);
                    if (status[i, j] == true)
                    {
                        g.FillRectangle(new SolidBrush(BrushColor), rec);
                    }
                }
            }
            PicBoxCell.Width = map.Width;
            PicBoxCell.Height = map.Height;
            PicBoxCell.Image = map;
        }

        //关闭线程
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //停止按钮的Click事件
        private void BtnStop_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = true;
            BtnPause.Enabled = false;
            BtnStop.Enabled = false;
            generation.Enabled = false;
            NumericCell.Enabled = true;
            game = null;
        }

        //暂停按钮的Click事件
        private void BtnPause_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = true;
            BtnPause.Enabled = false;
            generation.Enabled = false;
        }

        //产生下一代的速率
        private void NumicSpeed_ValueChanged(object sender, EventArgs e)
        {
            generation.Interval = 110 - Convert.ToInt32(NumicSpeed.Value) * 10;
        }

        //选择网格颜色的事件
        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BrushColor= colorDialog.Color;
            }
        }
    }
}
