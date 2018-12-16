namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gridSizeDial = new System.Windows.Forms.NumericUpDown();
            this.toleranceLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toleranceBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.moveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.populationsDial = new System.Windows.Forms.NumericUpDown();
            this.yellowDial = new System.Windows.Forms.NumericUpDown();
            this.pinkDial = new System.Windows.Forms.NumericUpDown();
            this.greenDial = new System.Windows.Forms.NumericUpDown();
            this.redDial = new System.Windows.Forms.NumericUpDown();
            this.blueDial = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.blueHappinessLbl = new System.Windows.Forms.Label();
            this.redHappinessLbl = new System.Windows.Forms.Label();
            this.greenHappinessLbl = new System.Windows.Forms.Label();
            this.yellowHappinessLbl = new System.Windows.Forms.Label();
            this.pinkHappinessLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningLbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.emptyLbl = new System.Windows.Forms.Label();
            this.filledLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationsDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDial)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filledLbl);
            this.panel1.Controls.Add(this.emptyLbl);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.gridSizeDial);
            this.panel1.Controls.Add(this.toleranceLbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.toleranceBar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.moveBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.populationsDial);
            this.panel1.Controls.Add(this.yellowDial);
            this.panel1.Controls.Add(this.pinkDial);
            this.panel1.Controls.Add(this.greenDial);
            this.panel1.Controls.Add(this.redDial);
            this.panel1.Controls.Add(this.blueDial);
            this.panel1.Location = new System.Drawing.Point(513, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 315);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Show Graph";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Grid Size";
            // 
            // gridSizeDial
            // 
            this.gridSizeDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gridSizeDial.Location = new System.Drawing.Point(6, 3);
            this.gridSizeDial.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gridSizeDial.Name = "gridSizeDial";
            this.gridSizeDial.Size = new System.Drawing.Size(40, 20);
            this.gridSizeDial.TabIndex = 28;
            this.gridSizeDial.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gridSizeDial.ValueChanged += new System.EventHandler(this.gridSizeDial_ValueChanged);
            // 
            // toleranceLbl
            // 
            this.toleranceLbl.AutoSize = true;
            this.toleranceLbl.Location = new System.Drawing.Point(70, 213);
            this.toleranceLbl.Name = "toleranceLbl";
            this.toleranceLbl.Size = new System.Drawing.Size(13, 13);
            this.toleranceLbl.TabIndex = 27;
            this.toleranceLbl.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tolerance:";
            // 
            // toleranceBar
            // 
            this.toleranceBar.Location = new System.Drawing.Point(6, 229);
            this.toleranceBar.Maximum = 7;
            this.toleranceBar.Name = "toleranceBar";
            this.toleranceBar.Size = new System.Drawing.Size(104, 45);
            this.toleranceBar.TabIndex = 25;
            this.toleranceBar.Value = 3;
            this.toleranceBar.Scroll += new System.EventHandler(this.toleranceBar_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(3, 285);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(48, 23);
            this.moveBtn.TabIndex = 12;
            this.moveBtn.Text = "Move";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pink Population (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yellow Population (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Green Population (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Red Population (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Blue Population (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Peoples";
            // 
            // populationsDial
            // 
            this.populationsDial.Location = new System.Drawing.Point(6, 56);
            this.populationsDial.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.populationsDial.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.populationsDial.Name = "populationsDial";
            this.populationsDial.Size = new System.Drawing.Size(40, 20);
            this.populationsDial.TabIndex = 5;
            this.populationsDial.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.populationsDial.ValueChanged += new System.EventHandler(this.populationsDial_ValueChanged);
            // 
            // yellowDial
            // 
            this.yellowDial.Enabled = false;
            this.yellowDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yellowDial.Location = new System.Drawing.Point(6, 160);
            this.yellowDial.Name = "yellowDial";
            this.yellowDial.Size = new System.Drawing.Size(40, 20);
            this.yellowDial.TabIndex = 4;
            this.yellowDial.ValueChanged += new System.EventHandler(this.dialChange);
            // 
            // pinkDial
            // 
            this.pinkDial.Enabled = false;
            this.pinkDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pinkDial.Location = new System.Drawing.Point(6, 186);
            this.pinkDial.Name = "pinkDial";
            this.pinkDial.Size = new System.Drawing.Size(40, 20);
            this.pinkDial.TabIndex = 3;
            this.pinkDial.ValueChanged += new System.EventHandler(this.dialChange);
            // 
            // greenDial
            // 
            this.greenDial.Enabled = false;
            this.greenDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.greenDial.Location = new System.Drawing.Point(6, 134);
            this.greenDial.Name = "greenDial";
            this.greenDial.Size = new System.Drawing.Size(40, 20);
            this.greenDial.TabIndex = 2;
            this.greenDial.ValueChanged += new System.EventHandler(this.dialChange);
            // 
            // redDial
            // 
            this.redDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.redDial.Location = new System.Drawing.Point(6, 108);
            this.redDial.Name = "redDial";
            this.redDial.Size = new System.Drawing.Size(40, 20);
            this.redDial.TabIndex = 1;
            this.redDial.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.redDial.ValueChanged += new System.EventHandler(this.dialChange);
            // 
            // blueDial
            // 
            this.blueDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.blueDial.Location = new System.Drawing.Point(6, 82);
            this.blueDial.Name = "blueDial";
            this.blueDial.Size = new System.Drawing.Size(40, 20);
            this.blueDial.TabIndex = 0;
            this.blueDial.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.blueDial.ValueChanged += new System.EventHandler(this.dialChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.blueHappinessLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.redHappinessLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.greenHappinessLbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.yellowHappinessLbl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pinkHappinessLbl, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(513, 348);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 160);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Happiness Levels";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Red";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Green";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Yellow";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Pink";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Blue";
            // 
            // blueHappinessLbl
            // 
            this.blueHappinessLbl.AutoSize = true;
            this.blueHappinessLbl.Location = new System.Drawing.Point(59, 32);
            this.blueHappinessLbl.Name = "blueHappinessLbl";
            this.blueHappinessLbl.Size = new System.Drawing.Size(13, 13);
            this.blueHappinessLbl.TabIndex = 33;
            this.blueHappinessLbl.Text = "b";
            // 
            // redHappinessLbl
            // 
            this.redHappinessLbl.AutoSize = true;
            this.redHappinessLbl.Location = new System.Drawing.Point(59, 56);
            this.redHappinessLbl.Name = "redHappinessLbl";
            this.redHappinessLbl.Size = new System.Drawing.Size(10, 13);
            this.redHappinessLbl.TabIndex = 34;
            this.redHappinessLbl.Text = "r";
            // 
            // greenHappinessLbl
            // 
            this.greenHappinessLbl.AutoSize = true;
            this.greenHappinessLbl.Location = new System.Drawing.Point(59, 82);
            this.greenHappinessLbl.Name = "greenHappinessLbl";
            this.greenHappinessLbl.Size = new System.Drawing.Size(13, 13);
            this.greenHappinessLbl.TabIndex = 35;
            this.greenHappinessLbl.Text = "g";
            // 
            // yellowHappinessLbl
            // 
            this.yellowHappinessLbl.AutoSize = true;
            this.yellowHappinessLbl.Location = new System.Drawing.Point(59, 108);
            this.yellowHappinessLbl.Name = "yellowHappinessLbl";
            this.yellowHappinessLbl.Size = new System.Drawing.Size(12, 13);
            this.yellowHappinessLbl.TabIndex = 36;
            this.yellowHappinessLbl.Text = "y";
            // 
            // pinkHappinessLbl
            // 
            this.pinkHappinessLbl.AutoSize = true;
            this.pinkHappinessLbl.Location = new System.Drawing.Point(59, 132);
            this.pinkHappinessLbl.Name = "pinkHappinessLbl";
            this.pinkHappinessLbl.Size = new System.Drawing.Size(13, 13);
            this.pinkHappinessLbl.TabIndex = 37;
            this.pinkHappinessLbl.Text = "p";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "&About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.warningLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.warningLbl.Location = new System.Drawing.Point(148, 230);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Padding = new System.Windows.Forms.Padding(10);
            this.warningLbl.Size = new System.Drawing.Size(224, 33);
            this.warningLbl.TabIndex = 31;
            this.warningLbl.Text = "*ERROR* Population cannot exceed 95%";
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // emptyLbl
            // 
            this.emptyLbl.AutoSize = true;
            this.emptyLbl.Location = new System.Drawing.Point(82, 32);
            this.emptyLbl.Name = "emptyLbl";
            this.emptyLbl.Size = new System.Drawing.Size(62, 13);
            this.emptyLbl.TabIndex = 31;
            this.emptyLbl.Text = "Empty: 10%";
            // 
            // filledLbl
            // 
            this.filledLbl.AutoSize = true;
            this.filledLbl.Location = new System.Drawing.Point(19, 32);
            this.filledLbl.Name = "filledLbl";
            this.filledLbl.Size = new System.Drawing.Size(57, 13);
            this.filledLbl.TabIndex = 32;
            this.filledLbl.Text = "Filled: 90%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 524);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 563);
            this.MinimumSize = new System.Drawing.Size(700, 563);
            this.Name = "Form1";
            this.Text = "Population Simulator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationsDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDial)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown populationsDial;
        private System.Windows.Forms.NumericUpDown yellowDial;
        private System.Windows.Forms.NumericUpDown pinkDial;
        private System.Windows.Forms.NumericUpDown greenDial;
        private System.Windows.Forms.NumericUpDown redDial;
        private System.Windows.Forms.NumericUpDown blueDial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label blueHappinessLbl;
        private System.Windows.Forms.Label redHappinessLbl;
        private System.Windows.Forms.Label greenHappinessLbl;
        private System.Windows.Forms.Label yellowHappinessLbl;
        private System.Windows.Forms.Label pinkHappinessLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar toleranceBar;
        private System.Windows.Forms.Label toleranceLbl;
        private System.Windows.Forms.NumericUpDown gridSizeDial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label emptyLbl;
        private System.Windows.Forms.Label filledLbl;
    }
}

