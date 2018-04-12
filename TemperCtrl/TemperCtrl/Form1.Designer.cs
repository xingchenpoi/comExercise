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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(331, 517);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBitlabel);
            this.groupBox1.Controls.Add(this.StopBitlabel);
            this.groupBox1.Controls.Add(this.DataBitlabel);
            this.groupBox1.Controls.Add(this.Baudlabel);
            this.groupBox1.Controls.Add(this.Comlabel);
            this.groupBox1.Controls.Add(this.Combutton);
            this.groupBox1.Controls.Add(this.CheckBitBomboBox);
            this.groupBox1.Controls.Add(this.StopBitComboBox);
            this.groupBox1.Controls.Add(this.DataBitComboBox);
            this.groupBox1.Controls.Add(this.BaudComboBox);
            this.groupBox1.Controls.Add(this.COMComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // CheckBitlabel
            // 
            this.CheckBitlabel.AutoSize = true;
            this.CheckBitlabel.Location = new System.Drawing.Point(27, 134);
            this.CheckBitlabel.Name = "CheckBitlabel";
            this.CheckBitlabel.Size = new System.Drawing.Size(41, 12);
            this.CheckBitlabel.TabIndex = 11;
            this.CheckBitlabel.Text = "校验流";
            // 
            // StopBitlabel
            // 
            this.StopBitlabel.AutoSize = true;
            this.StopBitlabel.Location = new System.Drawing.Point(27, 107);
            this.StopBitlabel.Name = "StopBitlabel";
            this.StopBitlabel.Size = new System.Drawing.Size(41, 12);
            this.StopBitlabel.TabIndex = 10;
            this.StopBitlabel.Text = "停止位";
            // 
            // DataBitlabel
            // 
            this.DataBitlabel.AutoSize = true;
            this.DataBitlabel.Location = new System.Drawing.Point(27, 80);
            this.DataBitlabel.Name = "DataBitlabel";
            this.DataBitlabel.Size = new System.Drawing.Size(41, 12);
            this.DataBitlabel.TabIndex = 9;
            this.DataBitlabel.Text = "数据位";
            // 
            // Baudlabel
            // 
            this.Baudlabel.AutoSize = true;
            this.Baudlabel.Location = new System.Drawing.Point(27, 54);
            this.Baudlabel.Name = "Baudlabel";
            this.Baudlabel.Size = new System.Drawing.Size(41, 12);
            this.Baudlabel.TabIndex = 8;
            this.Baudlabel.Text = "波特率";
            // 
            // Comlabel
            // 
            this.Comlabel.AutoSize = true;
            this.Comlabel.Location = new System.Drawing.Point(27, 28);
            this.Comlabel.Name = "Comlabel";
            this.Comlabel.Size = new System.Drawing.Size(41, 12);
            this.Comlabel.TabIndex = 7;
            this.Comlabel.Text = "端口号";
            // 
            // Combutton
            // 
            this.Combutton.Location = new System.Drawing.Point(51, 161);
            this.Combutton.Name = "Combutton";
            this.Combutton.Size = new System.Drawing.Size(107, 23);
            this.Combutton.TabIndex = 6;
            this.Combutton.Text = "打开串口";
            this.Combutton.UseVisualStyleBackColor = true;
            this.Combutton.Click += new System.EventHandler(this.Combutton_Click);
            // 
            // CheckBitBomboBox
            // 
            this.CheckBitBomboBox.FormattingEnabled = true;
            this.CheckBitBomboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CheckBitBomboBox.Location = new System.Drawing.Point(105, 127);
            this.CheckBitBomboBox.Name = "CheckBitBomboBox";
            this.CheckBitBomboBox.Size = new System.Drawing.Size(121, 20);
            this.CheckBitBomboBox.TabIndex = 4;
            this.CheckBitBomboBox.Text = "None";
            // 
            // StopBitComboBox
            // 
            this.StopBitComboBox.FormattingEnabled = true;
            this.StopBitComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.StopBitComboBox.Location = new System.Drawing.Point(105, 100);
            this.StopBitComboBox.Name = "StopBitComboBox";
            this.StopBitComboBox.Size = new System.Drawing.Size(121, 20);
            this.StopBitComboBox.TabIndex = 3;
            this.StopBitComboBox.Text = "1";
            // 
            // DataBitComboBox
            // 
            this.DataBitComboBox.FormattingEnabled = true;
            this.DataBitComboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBitComboBox.Location = new System.Drawing.Point(105, 73);
            this.DataBitComboBox.Name = "DataBitComboBox";
            this.DataBitComboBox.Size = new System.Drawing.Size(121, 20);
            this.DataBitComboBox.TabIndex = 2;
            this.DataBitComboBox.Text = "8";
            // 
            // BaudComboBox
            // 
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
            this.BaudComboBox.Location = new System.Drawing.Point(105, 47);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.Size = new System.Drawing.Size(121, 20);
            this.BaudComboBox.TabIndex = 1;
            this.BaudComboBox.Text = "9600";
            // 
            // COMComboBox
            // 
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
            this.COMComboBox.Location = new System.Drawing.Point(105, 20);
            this.COMComboBox.Name = "COMComboBox";
            this.COMComboBox.Size = new System.Drawing.Size(121, 20);
            this.COMComboBox.TabIndex = 0;
            this.COMComboBox.Text = "COM1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "温度控制器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

