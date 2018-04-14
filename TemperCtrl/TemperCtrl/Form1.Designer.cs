namespace TemperCtrl
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
            this.CheckBitlabel = new System.Windows.Forms.Label();
            this.StopBitlabel = new System.Windows.Forms.Label();
            this.DataBitlabel = new System.Windows.Forms.Label();
            this.Baudlabel = new System.Windows.Forms.Label();
            this.Comlabel = new System.Windows.Forms.Label();
            this.Combutton = new System.Windows.Forms.Button();
            this.CheckBitBomboBox = new System.Windows.Forms.ComboBox();
            this.StopBitComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitComboBox = new System.Windows.Forms.ComboBox();
            this.BaudComboBox = new System.Windows.Forms.ComboBox();
            this.COMComboBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ParaGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ParaButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PIDCycleiTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OverTermperTimeTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ITextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OverTemperTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TemperSettB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ParaGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckBitlabel
            // 
            this.CheckBitlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBitlabel.AutoSize = true;
            this.CheckBitlabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBitlabel.Location = new System.Drawing.Point(741, 2);
            this.CheckBitlabel.Name = "CheckBitlabel";
            this.CheckBitlabel.Size = new System.Drawing.Size(84, 26);
            this.CheckBitlabel.TabIndex = 11;
            this.CheckBitlabel.Text = "校验流";
            this.CheckBitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopBitlabel
            // 
            this.StopBitlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBitlabel.AutoSize = true;
            this.StopBitlabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StopBitlabel.Location = new System.Drawing.Point(557, 2);
            this.StopBitlabel.Name = "StopBitlabel";
            this.StopBitlabel.Size = new System.Drawing.Size(84, 26);
            this.StopBitlabel.TabIndex = 10;
            this.StopBitlabel.Text = "停止位";
            this.StopBitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBitlabel
            // 
            this.DataBitlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBitlabel.AutoSize = true;
            this.DataBitlabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataBitlabel.Location = new System.Drawing.Point(373, 2);
            this.DataBitlabel.Name = "DataBitlabel";
            this.DataBitlabel.Size = new System.Drawing.Size(84, 26);
            this.DataBitlabel.TabIndex = 9;
            this.DataBitlabel.Text = "数据位";
            this.DataBitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Baudlabel
            // 
            this.Baudlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Baudlabel.AutoSize = true;
            this.Baudlabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Baudlabel.Location = new System.Drawing.Point(189, 2);
            this.Baudlabel.Name = "Baudlabel";
            this.Baudlabel.Size = new System.Drawing.Size(84, 26);
            this.Baudlabel.TabIndex = 8;
            this.Baudlabel.Text = "波特率";
            this.Baudlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comlabel
            // 
            this.Comlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Comlabel.AutoSize = true;
            this.Comlabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Comlabel.Location = new System.Drawing.Point(5, 2);
            this.Comlabel.Name = "Comlabel";
            this.Comlabel.Size = new System.Drawing.Size(84, 26);
            this.Comlabel.TabIndex = 7;
            this.Comlabel.Text = "端口号";
            this.Comlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Combutton
            // 
            this.Combutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combutton.Location = new System.Drawing.Point(925, 5);
            this.Combutton.Name = "Combutton";
            this.Combutton.Size = new System.Drawing.Size(85, 20);
            this.Combutton.TabIndex = 6;
            this.Combutton.Text = "打开串口";
            this.Combutton.UseVisualStyleBackColor = true;
            this.Combutton.Click += new System.EventHandler(this.Combutton_Click);
            // 
            // CheckBitBomboBox
            // 
            this.CheckBitBomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBitBomboBox.FormattingEnabled = true;
            this.CheckBitBomboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CheckBitBomboBox.Location = new System.Drawing.Point(833, 5);
            this.CheckBitBomboBox.Name = "CheckBitBomboBox";
            this.CheckBitBomboBox.Size = new System.Drawing.Size(84, 20);
            this.CheckBitBomboBox.TabIndex = 4;
            this.CheckBitBomboBox.Text = "None";
            // 
            // StopBitComboBox
            // 
            this.StopBitComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBitComboBox.FormattingEnabled = true;
            this.StopBitComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.StopBitComboBox.Location = new System.Drawing.Point(649, 5);
            this.StopBitComboBox.Name = "StopBitComboBox";
            this.StopBitComboBox.Size = new System.Drawing.Size(84, 20);
            this.StopBitComboBox.TabIndex = 3;
            this.StopBitComboBox.Text = "1";
            // 
            // DataBitComboBox
            // 
            this.DataBitComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBitComboBox.FormattingEnabled = true;
            this.DataBitComboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBitComboBox.Location = new System.Drawing.Point(465, 5);
            this.DataBitComboBox.Name = "DataBitComboBox";
            this.DataBitComboBox.Size = new System.Drawing.Size(84, 20);
            this.DataBitComboBox.TabIndex = 2;
            this.DataBitComboBox.Text = "8";
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaudComboBox.FormattingEnabled = true;
            this.BaudComboBox.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BaudComboBox.Location = new System.Drawing.Point(281, 5);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.Size = new System.Drawing.Size(84, 20);
            this.BaudComboBox.TabIndex = 1;
            this.BaudComboBox.Text = "9600";
            // 
            // COMComboBox
            // 
            this.COMComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMComboBox.FormattingEnabled = true;
            this.COMComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30",
            "COM31",
            "COM32",
            "COM33",
            "COM34",
            "COM35",
            "COM36",
            "COM37",
            "COM38",
            "COM39",
            "COM40"});
            this.COMComboBox.Location = new System.Drawing.Point(97, 5);
            this.COMComboBox.Name = "COMComboBox";
            this.COMComboBox.Size = new System.Drawing.Size(84, 20);
            this.COMComboBox.TabIndex = 0;
            this.COMComboBox.Text = "COM1";
            // 
            // ParaGroupBox
            // 
            this.ParaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParaGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.ParaGroupBox.Location = new System.Drawing.Point(12, 69);
            this.ParaGroupBox.Name = "ParaGroupBox";
            this.ParaGroupBox.Size = new System.Drawing.Size(1012, 398);
            this.ParaGroupBox.TabIndex = 3;
            this.ParaGroupBox.TabStop = false;
            this.ParaGroupBox.Text = "参数设置";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.ParaButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.DTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.PIDCycleiTB, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.PTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.OverTermperTimeTB, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.ITextBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.CheckTextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.OverTemperTB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TemperSettB, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(996, 216);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ParaButton
            // 
            this.ParaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParaButton.Location = new System.Drawing.Point(749, 5);
            this.ParaButton.Name = "ParaButton";
            this.ParaButton.Size = new System.Drawing.Size(242, 34);
            this.ParaButton.TabIndex = 43;
            this.ParaButton.Text = "设置";
            this.ParaButton.UseVisualStyleBackColor = true;
            this.ParaButton.Click += new System.EventHandler(this.ParaButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 44);
            this.label7.TabIndex = 48;
            this.label7.Text = "D参数";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTextBox
            // 
            this.DTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTextBox.Location = new System.Drawing.Point(253, 173);
            this.DTextBox.Name = "DTextBox";
            this.DTextBox.Size = new System.Drawing.Size(240, 21);
            this.DTextBox.TabIndex = 49;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "32路";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "温控器类型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 44);
            this.label9.TabIndex = 39;
            this.label9.Text = "PID计算周期";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PIDCycleiTB
            // 
            this.PIDCycleiTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PIDCycleiTB.Location = new System.Drawing.Point(749, 173);
            this.PIDCycleiTB.Name = "PIDCycleiTB";
            this.PIDCycleiTB.Size = new System.Drawing.Size(242, 21);
            this.PIDCycleiTB.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 40);
            this.label5.TabIndex = 44;
            this.label5.Text = "P参数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PTextBox
            // 
            this.PTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTextBox.Location = new System.Drawing.Point(253, 131);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(240, 21);
            this.PTextBox.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 40);
            this.label4.TabIndex = 37;
            this.label4.Text = "超温报警时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverTermperTimeTB
            // 
            this.OverTermperTimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverTermperTimeTB.Location = new System.Drawing.Point(253, 89);
            this.OverTermperTimeTB.Name = "OverTermperTimeTB";
            this.OverTermperTimeTB.Size = new System.Drawing.Size(240, 21);
            this.OverTermperTimeTB.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 40);
            this.label6.TabIndex = 46;
            this.label6.Text = "l参数";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ITextBox
            // 
            this.ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITextBox.Location = new System.Drawing.Point(749, 131);
            this.ITextBox.Name = "ITextBox";
            this.ITextBox.Size = new System.Drawing.Size(242, 21);
            this.ITextBox.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 40);
            this.label10.TabIndex = 41;
            this.label10.Text = "开始检测异常时间";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckTextBox
            // 
            this.CheckTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckTextBox.Location = new System.Drawing.Point(749, 89);
            this.CheckTextBox.Name = "CheckTextBox";
            this.CheckTextBox.Size = new System.Drawing.Size(242, 21);
            this.CheckTextBox.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 40);
            this.label3.TabIndex = 35;
            this.label3.Text = "温度报警值";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverTemperTB
            // 
            this.OverTemperTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverTemperTB.Location = new System.Drawing.Point(253, 47);
            this.OverTemperTB.Name = "OverTemperTB";
            this.OverTemperTB.Size = new System.Drawing.Size(240, 21);
            this.OverTemperTB.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 40);
            this.label2.TabIndex = 33;
            this.label2.Text = "温度设定值";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperSettB
            // 
            this.TemperSettB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemperSettB.Location = new System.Drawing.Point(749, 47);
            this.TemperSettB.Name = "TemperSettB";
            this.TemperSettB.Size = new System.Drawing.Size(242, 21);
            this.TemperSettB.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Controls.Add(this.CheckBitlabel, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.Comlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckBitBomboBox, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.Combutton, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopBitlabel, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopBitComboBox, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.COMComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataBitlabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataBitComboBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.BaudComboBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Baudlabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 30);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ParaGroupBox);
            this.Name = "Form1";
            this.Text = "温度控制器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ParaGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Combutton;
        private System.Windows.Forms.ComboBox CheckBitBomboBox;
        private System.Windows.Forms.ComboBox StopBitComboBox;
        private System.Windows.Forms.ComboBox DataBitComboBox;
        private System.Windows.Forms.ComboBox BaudComboBox;
        private System.Windows.Forms.ComboBox COMComboBox;
        private System.Windows.Forms.Label Comlabel;
        private System.Windows.Forms.Label CheckBitlabel;
        private System.Windows.Forms.Label StopBitlabel;
        private System.Windows.Forms.Label DataBitlabel;
        private System.Windows.Forms.Label Baudlabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox ParaGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ParaButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PIDCycleiTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OverTermperTimeTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ITextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CheckTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OverTemperTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TemperSettB;
    }
}

