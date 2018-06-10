namespace GameOfLife
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.NumericCell = new System.Windows.Forms.NumericUpDown();
            this.BtnStart = new System.Windows.Forms.Button();
            this.generation = new System.Windows.Forms.Timer(this.components);
            this.PicBoxCell = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RadBtnRand = new System.Windows.Forms.RadioButton();
            this.RadBtnOne = new System.Windows.Forms.RadioButton();
            this.NumicSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new CCWin.SkinControl.SkinPanel();
            this.RadBtnThree = new System.Windows.Forms.RadioButton();
            this.RadBtnTwo = new System.Windows.Forms.RadioButton();
            this.BtnColor = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumicSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumericCell
            // 
            this.NumericCell.Location = new System.Drawing.Point(483, 24);
            this.NumericCell.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NumericCell.Name = "NumericCell";
            this.NumericCell.Size = new System.Drawing.Size(120, 25);
            this.NumericCell.TabIndex = 1;
            this.NumericCell.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(16, 19);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(80, 30);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "开始";
            this.toolTip.SetToolTip(this.BtnStart, "开始游戏");
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // generation
            // 
            this.generation.Tick += new System.EventHandler(this.generation_Tick);
            // 
            // PicBoxCell
            // 
            this.PicBoxCell.Location = new System.Drawing.Point(107, 24);
            this.PicBoxCell.Name = "PicBoxCell";
            this.PicBoxCell.Size = new System.Drawing.Size(415, 415);
            this.PicBoxCell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBoxCell.TabIndex = 3;
            this.PicBoxCell.TabStop = false;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(190, 19);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(80, 30);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "停止";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(104, 19);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(80, 30);
            this.BtnPause.TabIndex = 5;
            this.BtnPause.Text = "暂停";
            this.toolTip.SetToolTip(this.BtnPause, "暂停游戏");
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(395, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "网格宽度";
            // 
            // RadBtnRand
            // 
            this.RadBtnRand.AutoSize = true;
            this.RadBtnRand.Checked = true;
            this.RadBtnRand.Location = new System.Drawing.Point(16, 65);
            this.RadBtnRand.Name = "RadBtnRand";
            this.RadBtnRand.Size = new System.Drawing.Size(88, 19);
            this.RadBtnRand.TabIndex = 9;
            this.RadBtnRand.TabStop = true;
            this.RadBtnRand.Text = "随机生成";
            this.RadBtnRand.UseVisualStyleBackColor = true;
            // 
            // RadBtnOne
            // 
            this.RadBtnOne.AutoSize = true;
            this.RadBtnOne.Location = new System.Drawing.Point(105, 65);
            this.RadBtnOne.Name = "RadBtnOne";
            this.RadBtnOne.Size = new System.Drawing.Size(118, 19);
            this.RadBtnOne.TabIndex = 10;
            this.RadBtnOne.TabStop = true;
            this.RadBtnOne.Text = "高斯帕滑翔机";
            this.RadBtnOne.UseVisualStyleBackColor = true;
            // 
            // NumicSpeed
            // 
            this.NumicSpeed.Location = new System.Drawing.Point(483, 65);
            this.NumicSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumicSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumicSpeed.Name = "NumicSpeed";
            this.NumicSpeed.Size = new System.Drawing.Size(120, 25);
            this.NumicSpeed.TabIndex = 11;
            this.toolTip.SetToolTip(this.NumicSpeed, "数值越大,速率越高");
            this.NumicSpeed.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumicSpeed.ValueChanged += new System.EventHandler(this.NumicSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(395, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "动画速率";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RadBtnThree);
            this.panel1.Controls.Add(this.RadBtnTwo);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Controls.Add(this.BtnPause);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NumericCell);
            this.panel1.Controls.Add(this.NumicSpeed);
            this.panel1.Controls.Add(this.BtnStart);
            this.panel1.Controls.Add(this.RadBtnOne);
            this.panel1.Controls.Add(this.BtnStop);
            this.panel1.Controls.Add(this.RadBtnRand);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel1.DownBack = null;
            this.panel1.Location = new System.Drawing.Point(4, 448);
            this.panel1.MouseBack = null;
            this.panel1.Name = "panel1";
            this.panel1.NormlBack = null;
            this.panel1.Size = new System.Drawing.Size(616, 100);
            this.panel1.TabIndex = 13;
            // 
            // RadBtnThree
            // 
            this.RadBtnThree.AutoSize = true;
            this.RadBtnThree.Location = new System.Drawing.Point(291, 65);
            this.RadBtnThree.Name = "RadBtnThree";
            this.RadBtnThree.Size = new System.Drawing.Size(73, 19);
            this.RadBtnThree.TabIndex = 15;
            this.RadBtnThree.TabStop = true;
            this.RadBtnThree.Text = "震荡子";
            this.RadBtnThree.UseVisualStyleBackColor = true;
            // 
            // RadBtnTwo
            // 
            this.RadBtnTwo.AutoSize = true;
            this.RadBtnTwo.Location = new System.Drawing.Point(204, 65);
            this.RadBtnTwo.Name = "RadBtnTwo";
            this.RadBtnTwo.Size = new System.Drawing.Size(73, 19);
            this.RadBtnTwo.TabIndex = 14;
            this.RadBtnTwo.TabStop = true;
            this.RadBtnTwo.Text = "一字型";
            this.RadBtnTwo.UseVisualStyleBackColor = true;
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(291, 19);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(80, 30);
            this.BtnColor.TabIndex = 13;
            this.BtnColor.Text = "选择颜色";
            this.toolTip.SetToolTip(this.BtnColor, "设置网格的填充颜色");
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.BtnStart;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(627, 558);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicBoxCell);
            this.EffectCaption = CCWin.TitleType.Title;
            this.MaximizeBox = false;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOfLife";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NumericCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumicSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NumericCell;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer generation;
        private System.Windows.Forms.PictureBox PicBoxCell;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadBtnRand;
        private System.Windows.Forms.RadioButton RadBtnOne;
        private System.Windows.Forms.NumericUpDown NumicSpeed;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinPanel panel1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RadioButton RadBtnThree;
        private System.Windows.Forms.RadioButton RadBtnTwo;
    }
}

