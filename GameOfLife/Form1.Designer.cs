namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NumericCell = new System.Windows.Forms.NumericUpDown();
            this.BtnStart = new System.Windows.Forms.Button();
            this.generation = new System.Windows.Forms.Timer(this.components);
            this.PicBoxCell = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCell)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericCell
            // 
            this.NumericCell.Location = new System.Drawing.Point(344, 479);
            this.NumericCell.Name = "NumericCell";
            this.NumericCell.Size = new System.Drawing.Size(120, 25);
            this.NumericCell.TabIndex = 1;
            this.NumericCell.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(110, 463);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "开始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // generation
            // 
            this.generation.Tick += new System.EventHandler(this.generation_Tick);
            // 
            // PicBoxCell
            // 
            this.PicBoxCell.Location = new System.Drawing.Point(110, 12);
            this.PicBoxCell.Name = "PicBoxCell";
            this.PicBoxCell.Size = new System.Drawing.Size(400, 400);
            this.PicBoxCell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCell.TabIndex = 3;
            this.PicBoxCell.TabStop = false;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(203, 463);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "停止";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 649);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.PicBoxCell);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.NumericCell);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NumericCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NumericCell;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer generation;
        private System.Windows.Forms.PictureBox PicBoxCell;
        private System.Windows.Forms.Button BtnStop;
    }
}

