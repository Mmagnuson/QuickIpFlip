namespace QuickIp
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
            this.btnStaticTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dgIp = new System.Windows.Forms.DataGridView();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStaticIP = new System.Windows.Forms.GroupBox();
            this.RbStaticIP = new System.Windows.Forms.RadioButton();
            this.RbDHCP = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RbDNSDHCP = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RbDNSStatic = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNetworkCard = new System.Windows.Forms.Label();
            this.cmbNetworkcards = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSafe = new System.Windows.Forms.Button();
            this.bntLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgIp)).BeginInit();
            this.gbStaticIP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStaticTest
            // 
            this.btnStaticTest.Location = new System.Drawing.Point(1117, 189);
            this.btnStaticTest.Name = "btnStaticTest";
            this.btnStaticTest.Size = new System.Drawing.Size(75, 23);
            this.btnStaticTest.TabIndex = 0;
            this.btnStaticTest.Text = "Static";
            this.btnStaticTest.UseVisualStyleBackColor = true;
            this.btnStaticTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1117, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 509);
            this.textBox1.TabIndex = 2;
            // 
            // btnDHCP
            // 
            this.btnDHCP.Location = new System.Drawing.Point(1108, 219);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(75, 23);
            this.btnDHCP.TabIndex = 3;
            this.btnDHCP.Text = "DHCP";
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 472);
            this.listBox1.TabIndex = 5;
            // 
            // dgIp
            // 
            this.dgIp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ip,
            this.Subnet});
            this.dgIp.Enabled = false;
            this.dgIp.Location = new System.Drawing.Point(18, 32);
            this.dgIp.Name = "dgIp";
            this.dgIp.Size = new System.Drawing.Size(300, 105);
            this.dgIp.TabIndex = 6;
            // 
            // ip
            // 
            this.ip.HeaderText = "Address";
            this.ip.Name = "ip";
            this.ip.Width = 120;
            // 
            // Subnet
            // 
            this.Subnet.HeaderText = "Subnet";
            this.Subnet.Name = "Subnet";
            this.Subnet.Width = 120;
            // 
            // gbStaticIP
            // 
            this.gbStaticIP.Controls.Add(this.RbStaticIP);
            this.gbStaticIP.Controls.Add(this.dgIp);
            this.gbStaticIP.Location = new System.Drawing.Point(3, 27);
            this.gbStaticIP.Name = "gbStaticIP";
            this.gbStaticIP.Size = new System.Drawing.Size(341, 154);
            this.gbStaticIP.TabIndex = 7;
            this.gbStaticIP.TabStop = false;
            this.gbStaticIP.Text = "IP ";
            // 
            // RbStaticIP
            // 
            this.RbStaticIP.AutoSize = true;
            this.RbStaticIP.Location = new System.Drawing.Point(6, 0);
            this.RbStaticIP.Name = "RbStaticIP";
            this.RbStaticIP.Size = new System.Drawing.Size(220, 17);
            this.RbStaticIP.TabIndex = 8;
            this.RbStaticIP.TabStop = true;
            this.RbStaticIP.Tag = "ip";
            this.RbStaticIP.Text = "Use the following ip address or addresses";
            this.RbStaticIP.UseVisualStyleBackColor = true;
            this.RbStaticIP.CheckedChanged += new System.EventHandler(this.RbStaticIP_CheckedChanged);
            // 
            // RbDHCP
            // 
            this.RbDHCP.AutoSize = true;
            this.RbDHCP.Checked = true;
            this.RbDHCP.Location = new System.Drawing.Point(9, 3);
            this.RbDHCP.Name = "RbDHCP";
            this.RbDHCP.Size = new System.Drawing.Size(223, 18);
            this.RbDHCP.TabIndex = 8;
            this.RbDHCP.TabStop = true;
            this.RbDHCP.Tag = "ip";
            this.RbDHCP.Text = "Obtain ip address automatically (DHCP)";
            this.RbDHCP.UseCompatibleTextRendering = true;
            this.RbDHCP.UseVisualStyleBackColor = true;
            this.RbDHCP.CheckedChanged += new System.EventHandler(this.RbDHCP_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtProfileName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblNetworkCard);
            this.groupBox2.Controls.Add(this.cmbNetworkcards);
            this.groupBox2.Location = new System.Drawing.Point(252, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 543);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RbDNSDHCP);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(14, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 189);
            this.panel2.TabIndex = 20;
            // 
            // RbDNSDHCP
            // 
            this.RbDNSDHCP.AutoSize = true;
            this.RbDNSDHCP.Checked = true;
            this.RbDNSDHCP.Location = new System.Drawing.Point(9, 3);
            this.RbDNSDHCP.Name = "RbDNSDHCP";
            this.RbDNSDHCP.Size = new System.Drawing.Size(218, 17);
            this.RbDNSDHCP.TabIndex = 9;
            this.RbDNSDHCP.TabStop = true;
            this.RbDNSDHCP.Tag = "dns";
            this.RbDNSDHCP.Text = "Obtain DNS server address automatically";
            this.RbDNSDHCP.UseVisualStyleBackColor = true;
            this.RbDNSDHCP.CheckedChanged += new System.EventHandler(this.RbDNSDHCP_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.RbDNSStatic);
            this.groupBox3.Location = new System.Drawing.Point(3, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 151);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 105);
            this.dataGridView2.TabIndex = 6;
            // 
            // RbDNSStatic
            // 
            this.RbDNSStatic.AutoSize = true;
            this.RbDNSStatic.Location = new System.Drawing.Point(6, 0);
            this.RbDNSStatic.Name = "RbDNSStatic";
            this.RbDNSStatic.Size = new System.Drawing.Size(215, 17);
            this.RbDNSStatic.TabIndex = 10;
            this.RbDNSStatic.TabStop = true;
            this.RbDNSStatic.Tag = "dns";
            this.RbDNSStatic.Text = "Use the following DNS server addresses";
            this.RbDNSStatic.UseVisualStyleBackColor = true;
            this.RbDNSStatic.CheckedChanged += new System.EventHandler(this.RbDNSStatic_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbDHCP);
            this.panel1.Controls.Add(this.gbStaticIP);
            this.panel1.Location = new System.Drawing.Point(14, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 188);
            this.panel1.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(104, 24);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(251, 20);
            this.txtProfileName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Profile Name";
            // 
            // lblNetworkCard
            // 
            this.lblNetworkCard.AutoSize = true;
            this.lblNetworkCard.Location = new System.Drawing.Point(20, 67);
            this.lblNetworkCard.Name = "lblNetworkCard";
            this.lblNetworkCard.Size = new System.Drawing.Size(72, 13);
            this.lblNetworkCard.TabIndex = 13;
            this.lblNetworkCard.Text = "Network Card";
            // 
            // cmbNetworkcards
            // 
            this.cmbNetworkcards.FormattingEnabled = true;
            this.cmbNetworkcards.Location = new System.Drawing.Point(104, 61);
            this.cmbNetworkcards.Name = "cmbNetworkcards";
            this.cmbNetworkcards.Size = new System.Drawing.Size(251, 21);
            this.cmbNetworkcards.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(689, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 543);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Settings";
            // 
            // btnSafe
            // 
            this.btnSafe.Location = new System.Drawing.Point(1091, 313);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(75, 23);
            this.btnSafe.TabIndex = 12;
            this.btnSafe.Text = "Save";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bntLoad
            // 
            this.bntLoad.Location = new System.Drawing.Point(1091, 342);
            this.bntLoad.Name = "bntLoad";
            this.bntLoad.Size = new System.Drawing.Size(75, 23);
            this.bntLoad.TabIndex = 13;
            this.bntLoad.Text = "Load";
            this.bntLoad.UseVisualStyleBackColor = true;
            this.bntLoad.Click += new System.EventHandler(this.bntLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 565);
            this.Controls.Add(this.bntLoad);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDHCP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStaticTest);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgIp)).EndInit();
            this.gbStaticIP.ResumeLayout(false);
            this.gbStaticIP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaticTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dgIp;
        private System.Windows.Forms.GroupBox gbStaticIP;
        private System.Windows.Forms.RadioButton RbStaticIP;
        private System.Windows.Forms.RadioButton RbDHCP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNetworkCard;
        private System.Windows.Forms.ComboBox cmbNetworkcards;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton RbDNSStatic;
        private System.Windows.Forms.RadioButton RbDNSDHCP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subnet;
        private System.Windows.Forms.Button btnSafe;
        private System.Windows.Forms.Button bntLoad;
    }
}

