namespace MotorControl
{
    partial class MainControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControlPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxCOM = new System.Windows.Forms.ToolStripComboBox();
            this.btn_connect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxMotorFunction = new System.Windows.Forms.GroupBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_rstAlarm = new System.Windows.Forms.Button();
            this.btn_Emergency = new System.Windows.Forms.Button();
            this.gbxContinue = new System.Windows.Forms.GroupBox();
            this.nudContinueHz = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_RVS = new System.Windows.Forms.Button();
            this.btn_FWD = new System.Windows.Forms.Button();
            this.gbxPoint = new System.Windows.Forms.GroupBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dudMod = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDec = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAcc = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudHz = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudStep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbxHomep = new System.Windows.Forms.PictureBox();
            this.tbx_nowPosition = new System.Windows.Forms.TextBox();
            this.pbxMove = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pbxReady = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pbxAlarm = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pbxWarning = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxMotorFunction.SuspendLayout();
            this.gbxContinue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContinueHz)).BeginInit();
            this.gbxPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).BeginInit();
            this.gbxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHomep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbxCOM,
            this.btn_connect,
            this.toolStripSeparator1,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1560, 31);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 26);
            this.toolStripLabel1.Text = "連接埠";
            // 
            // cbxCOM
            // 
            this.cbxCOM.Name = "cbxCOM";
            this.cbxCOM.Size = new System.Drawing.Size(136, 31);
            // 
            // btn_connect
            // 
            this.btn_connect.AutoSize = false;
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_connect.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(80, 24);
            this.btn_connect.Text = "連接";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 24);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbxMotorFunction);
            this.groupBox2.Controls.Add(this.gbxContinue);
            this.groupBox2.Controls.Add(this.gbxPoint);
            this.groupBox2.Controls.Add(this.gbxStatus);
            this.groupBox2.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(243, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1252, 327);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "馬達控制介面";
            // 
            // gbxMotorFunction
            // 
            this.gbxMotorFunction.Controls.Add(this.btn_home);
            this.gbxMotorFunction.Controls.Add(this.btn_rstAlarm);
            this.gbxMotorFunction.Controls.Add(this.btn_Emergency);
            this.gbxMotorFunction.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxMotorFunction.Location = new System.Drawing.Point(16, 24);
            this.gbxMotorFunction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxMotorFunction.Name = "gbxMotorFunction";
            this.gbxMotorFunction.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxMotorFunction.Size = new System.Drawing.Size(164, 310);
            this.gbxMotorFunction.TabIndex = 19;
            this.gbxMotorFunction.TabStop = false;
            this.gbxMotorFunction.Text = "馬達功能";
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_home.Location = new System.Drawing.Point(21, 50);
            this.btn_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 44);
            this.btn_home.TabIndex = 2;
            this.btn_home.Tag = "0";
            this.btn_home.Text = "原點復歸";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_rstAlarm
            // 
            this.btn_rstAlarm.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_rstAlarm.Location = new System.Drawing.Point(21, 128);
            this.btn_rstAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rstAlarm.Name = "btn_rstAlarm";
            this.btn_rstAlarm.Size = new System.Drawing.Size(122, 44);
            this.btn_rstAlarm.TabIndex = 2;
            this.btn_rstAlarm.Tag = "1";
            this.btn_rstAlarm.Text = "重置警報";
            this.btn_rstAlarm.UseVisualStyleBackColor = true;
            this.btn_rstAlarm.Click += new System.EventHandler(this.btn_RVS_Click);
            // 
            // btn_Emergency
            // 
            this.btn_Emergency.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Emergency.Location = new System.Drawing.Point(21, 214);
            this.btn_Emergency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Emergency.Name = "btn_Emergency";
            this.btn_Emergency.Size = new System.Drawing.Size(122, 44);
            this.btn_Emergency.TabIndex = 2;
            this.btn_Emergency.Tag = "2";
            this.btn_Emergency.Text = "緊急停止";
            this.btn_Emergency.UseVisualStyleBackColor = true;
            // 
            // gbxContinue
            // 
            this.gbxContinue.Controls.Add(this.nudContinueHz);
            this.gbxContinue.Controls.Add(this.label3);
            this.gbxContinue.Controls.Add(this.label2);
            this.gbxContinue.Controls.Add(this.btn_Stop);
            this.gbxContinue.Controls.Add(this.btn_RVS);
            this.gbxContinue.Controls.Add(this.btn_FWD);
            this.gbxContinue.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxContinue.Location = new System.Drawing.Point(201, 32);
            this.gbxContinue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxContinue.Name = "gbxContinue";
            this.gbxContinue.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxContinue.Size = new System.Drawing.Size(758, 104);
            this.gbxContinue.TabIndex = 7;
            this.gbxContinue.TabStop = false;
            this.gbxContinue.Text = "連續運轉";
            // 
            // nudContinueHz
            // 
            this.nudContinueHz.Location = new System.Drawing.Point(118, 44);
            this.nudContinueHz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudContinueHz.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudContinueHz.Name = "nudContinueHz";
            this.nudContinueHz.Size = new System.Drawing.Size(106, 32);
            this.nudContinueHz.TabIndex = 11;
            this.nudContinueHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "運轉速度";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.Location = new System.Drawing.Point(514, 26);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(100, 66);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Tag = "1";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_RVS_Click);
            // 
            // btn_RVS
            // 
            this.btn_RVS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_RVS.Image = ((System.Drawing.Image)(resources.GetObject("btn_RVS.Image")));
            this.btn_RVS.Location = new System.Drawing.Point(412, 26);
            this.btn_RVS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RVS.Name = "btn_RVS";
            this.btn_RVS.Size = new System.Drawing.Size(62, 66);
            this.btn_RVS.TabIndex = 6;
            this.btn_RVS.Tag = "0";
            this.btn_RVS.UseVisualStyleBackColor = false;
            this.btn_RVS.Click += new System.EventHandler(this.btn_RVS_Click);
            // 
            // btn_FWD
            // 
            this.btn_FWD.Image = ((System.Drawing.Image)(resources.GetObject("btn_FWD.Image")));
            this.btn_FWD.Location = new System.Drawing.Point(664, 26);
            this.btn_FWD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FWD.Name = "btn_FWD";
            this.btn_FWD.Size = new System.Drawing.Size(62, 66);
            this.btn_FWD.TabIndex = 5;
            this.btn_FWD.Tag = "2";
            this.btn_FWD.UseVisualStyleBackColor = true;
            this.btn_FWD.Click += new System.EventHandler(this.btn_RVS_Click);
            // 
            // gbxPoint
            // 
            this.gbxPoint.Controls.Add(this.btn_move);
            this.gbxPoint.Controls.Add(this.label12);
            this.gbxPoint.Controls.Add(this.dudMod);
            this.gbxPoint.Controls.Add(this.label5);
            this.gbxPoint.Controls.Add(this.nudDec);
            this.gbxPoint.Controls.Add(this.label6);
            this.gbxPoint.Controls.Add(this.nudAcc);
            this.gbxPoint.Controls.Add(this.label8);
            this.gbxPoint.Controls.Add(this.nudHz);
            this.gbxPoint.Controls.Add(this.label10);
            this.gbxPoint.Controls.Add(this.nudStep);
            this.gbxPoint.Controls.Add(this.label4);
            this.gbxPoint.Controls.Add(this.label11);
            this.gbxPoint.Controls.Add(this.label7);
            this.gbxPoint.Controls.Add(this.label9);
            this.gbxPoint.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxPoint.Location = new System.Drawing.Point(201, 154);
            this.gbxPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPoint.Name = "gbxPoint";
            this.gbxPoint.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPoint.Size = new System.Drawing.Size(758, 178);
            this.gbxPoint.TabIndex = 12;
            this.gbxPoint.TabStop = false;
            this.gbxPoint.Text = "定位運轉";
            // 
            // btn_move
            // 
            this.btn_move.Image = ((System.Drawing.Image)(resources.GetObject("btn_move.Image")));
            this.btn_move.Location = new System.Drawing.Point(645, 76);
            this.btn_move.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(62, 66);
            this.btn_move.TabIndex = 13;
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(16, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "運轉方式";
            // 
            // dudMod
            // 
            this.dudMod.Items.Add("INC (增量式)");
            this.dudMod.Items.Add("ABS (絕對式)");
            this.dudMod.Location = new System.Drawing.Point(122, 28);
            this.dudMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dudMod.Name = "dudMod";
            this.dudMod.Size = new System.Drawing.Size(242, 32);
            this.dudMod.TabIndex = 11;
            this.dudMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(16, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "位置";
            // 
            // nudDec
            // 
            this.nudDec.Location = new System.Drawing.Point(416, 118);
            this.nudDec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudDec.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDec.Name = "nudDec";
            this.nudDec.Size = new System.Drawing.Size(106, 32);
            this.nudDec.TabIndex = 10;
            this.nudDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "運轉速度";
            // 
            // nudAcc
            // 
            this.nudAcc.Location = new System.Drawing.Point(416, 74);
            this.nudAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAcc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAcc.Name = "nudAcc";
            this.nudAcc.Size = new System.Drawing.Size(106, 32);
            this.nudAcc.TabIndex = 10;
            this.nudAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(320, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "加速度";
            // 
            // nudHz
            // 
            this.nudHz.Location = new System.Drawing.Point(122, 118);
            this.nudHz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHz.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudHz.Name = "nudHz";
            this.nudHz.Size = new System.Drawing.Size(106, 32);
            this.nudHz.TabIndex = 10;
            this.nudHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(320, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "減速度";
            // 
            // nudStep
            // 
            this.nudStep.Location = new System.Drawing.Point(122, 72);
            this.nudStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudStep.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nudStep.Name = "nudStep";
            this.nudStep.Size = new System.Drawing.Size(106, 32);
            this.nudStep.TabIndex = 10;
            this.nudStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "step";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(536, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "ms/kHz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "ms/kHz";
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.label19);
            this.gbxStatus.Controls.Add(this.label13);
            this.gbxStatus.Controls.Add(this.pbxHomep);
            this.gbxStatus.Controls.Add(this.tbx_nowPosition);
            this.gbxStatus.Controls.Add(this.pbxMove);
            this.gbxStatus.Controls.Add(this.label14);
            this.gbxStatus.Controls.Add(this.pbxReady);
            this.gbxStatus.Controls.Add(this.label15);
            this.gbxStatus.Controls.Add(this.pbxAlarm);
            this.gbxStatus.Controls.Add(this.label16);
            this.gbxStatus.Controls.Add(this.pbxWarning);
            this.gbxStatus.Controls.Add(this.label17);
            this.gbxStatus.Controls.Add(this.label18);
            this.gbxStatus.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxStatus.Location = new System.Drawing.Point(976, 24);
            this.gbxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxStatus.Size = new System.Drawing.Size(284, 310);
            this.gbxStatus.TabIndex = 18;
            this.gbxStatus.TabStop = false;
            this.gbxStatus.Text = "馬達狀態";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(231, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 24);
            this.label19.TabIndex = 14;
            this.label19.Text = "step";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("DFKai-SB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(18, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "現在位置";
            // 
            // pbxHomep
            // 
            this.pbxHomep.BackColor = System.Drawing.Color.White;
            this.pbxHomep.Location = new System.Drawing.Point(164, 238);
            this.pbxHomep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxHomep.Name = "pbxHomep";
            this.pbxHomep.Size = new System.Drawing.Size(28, 30);
            this.pbxHomep.TabIndex = 17;
            this.pbxHomep.TabStop = false;
            // 
            // tbx_nowPosition
            // 
            this.tbx_nowPosition.Location = new System.Drawing.Point(128, 32);
            this.tbx_nowPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_nowPosition.Name = "tbx_nowPosition";
            this.tbx_nowPosition.Size = new System.Drawing.Size(90, 32);
            this.tbx_nowPosition.TabIndex = 3;
            // 
            // pbxMove
            // 
            this.pbxMove.BackColor = System.Drawing.Color.White;
            this.pbxMove.Location = new System.Drawing.Point(164, 80);
            this.pbxMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxMove.Name = "pbxMove";
            this.pbxMove.Size = new System.Drawing.Size(28, 30);
            this.pbxMove.TabIndex = 16;
            this.pbxMove.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 24);
            this.label14.TabIndex = 9;
            this.label14.Text = "Move";
            // 
            // pbxReady
            // 
            this.pbxReady.BackColor = System.Drawing.Color.White;
            this.pbxReady.Location = new System.Drawing.Point(164, 120);
            this.pbxReady.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxReady.Name = "pbxReady";
            this.pbxReady.Size = new System.Drawing.Size(28, 30);
            this.pbxReady.TabIndex = 15;
            this.pbxReady.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Ready";
            // 
            // pbxAlarm
            // 
            this.pbxAlarm.BackColor = System.Drawing.Color.White;
            this.pbxAlarm.Location = new System.Drawing.Point(164, 160);
            this.pbxAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxAlarm.Name = "pbxAlarm";
            this.pbxAlarm.Size = new System.Drawing.Size(28, 30);
            this.pbxAlarm.TabIndex = 14;
            this.pbxAlarm.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 24);
            this.label16.TabIndex = 9;
            this.label16.Text = "Alarm";
            // 
            // pbxWarning
            // 
            this.pbxWarning.BackColor = System.Drawing.Color.White;
            this.pbxWarning.Location = new System.Drawing.Point(164, 198);
            this.pbxWarning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxWarning.Name = "pbxWarning";
            this.pbxWarning.Size = new System.Drawing.Size(28, 30);
            this.pbxWarning.TabIndex = 13;
            this.pbxWarning.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 206);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 24);
            this.label17.TabIndex = 9;
            this.label17.Text = "Warning";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 246);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 24);
            this.label18.TabIndex = 9;
            this.label18.Text = "Home-p";
            // 
            // MainControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 524);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainControlPanel";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbxMotorFunction.ResumeLayout(false);
            this.gbxContinue.ResumeLayout(false);
            this.gbxContinue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContinueHz)).EndInit();
            this.gbxPoint.ResumeLayout(false);
            this.gbxPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).EndInit();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHomep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxCOM;
        private System.Windows.Forms.ToolStripButton btn_connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxMotorFunction;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_rstAlarm;
        private System.Windows.Forms.Button btn_Emergency;
        private System.Windows.Forms.GroupBox gbxContinue;
        private System.Windows.Forms.NumericUpDown nudContinueHz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_RVS;
        private System.Windows.Forms.Button btn_FWD;
        private System.Windows.Forms.GroupBox gbxPoint;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DomainUpDown dudMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudHz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbxHomep;
        private System.Windows.Forms.TextBox tbx_nowPosition;
        private System.Windows.Forms.PictureBox pbxMove;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbxReady;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbxAlarm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbxWarning;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

