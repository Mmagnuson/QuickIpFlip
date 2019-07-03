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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbProfiles = new System.Windows.Forms.ListBox();
            this.dgIp = new System.Windows.Forms.DataGridView();
            this.gbStaticIP = new System.Windows.Forms.GroupBox();
            this.RbStaticIP = new System.Windows.Forms.RadioButton();
            this.RbDHCP = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RbDNSDHCP = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RbDNSStatic = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNetworkCard = new System.Windows.Forms.Label();
            this.cmbNetworkcards = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDNSAdd = new System.Windows.Forms.Button();
            this.bntDNSRemove = new System.Windows.Forms.Button();
            this.btnIPRemove = new System.Windows.Forms.Button();
            this.btnIPAdd = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 509);
            this.textBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbProfiles
            // 
            this.lbProfiles.FormattingEnabled = true;
            this.lbProfiles.Location = new System.Drawing.Point(12, 63);
            this.lbProfiles.Name = "lbProfiles";
            this.lbProfiles.Size = new System.Drawing.Size(225, 173);
            this.lbProfiles.TabIndex = 5;
            this.lbProfiles.SelectedIndexChanged += new System.EventHandler(this.LbProfiles_SelectedIndexChanged);
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
            this.dgIp.Size = new System.Drawing.Size(300, 88);
            this.dgIp.TabIndex = 6;
            // 
            // gbStaticIP
            // 
            this.gbStaticIP.Controls.Add(this.btnIPAdd);
            this.gbStaticIP.Controls.Add(this.btnIPRemove);
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
            this.RbStaticIP.Click += new System.EventHandler(this.RbStaticIP_Click);
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
            this.RbDHCP.Click += new System.EventHandler(this.RbDHCP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntNew);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnApply);
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
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(14, 493);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(80, 35);
            this.bntNew.TabIndex = 21;
            this.bntNew.Text = "New";
            this.bntNew.UseVisualStyleBackColor = true;
            this.bntNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.RbDNSDHCP.Click += new System.EventHandler(this.RbDNSDHCP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntDNSRemove);
            this.groupBox3.Controls.Add(this.btnDNSAdd);
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
            this.dataGridView2.Size = new System.Drawing.Size(300, 84);
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
            this.RbDNSStatic.Click += new System.EventHandler(this.RbDNSStatic_Click);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(186, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(283, 493);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(84, 35);
            this.btnApply.TabIndex = 17;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.bntApply_Click);
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
            this.groupBox4.Location = new System.Drawing.Point(632, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 543);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Settings";
            // 
            // btnDNSAdd
            // 
            this.btnDNSAdd.Location = new System.Drawing.Point(256, 122);
            this.btnDNSAdd.Name = "btnDNSAdd";
            this.btnDNSAdd.Size = new System.Drawing.Size(62, 23);
            this.btnDNSAdd.TabIndex = 22;
            this.btnDNSAdd.Text = "Add";
            this.btnDNSAdd.UseVisualStyleBackColor = true;
            // 
            // bntDNSRemove
            // 
            this.bntDNSRemove.Location = new System.Drawing.Point(187, 122);
            this.bntDNSRemove.Name = "bntDNSRemove";
            this.bntDNSRemove.Size = new System.Drawing.Size(62, 23);
            this.bntDNSRemove.TabIndex = 23;
            this.bntDNSRemove.Text = "Remove";
            this.bntDNSRemove.UseVisualStyleBackColor = true;
            // 
            // btnIPRemove
            // 
            this.btnIPRemove.Location = new System.Drawing.Point(187, 125);
            this.btnIPRemove.Name = "btnIPRemove";
            this.btnIPRemove.Size = new System.Drawing.Size(62, 23);
            this.btnIPRemove.TabIndex = 24;
            this.btnIPRemove.Text = "Remove";
            this.btnIPRemove.UseVisualStyleBackColor = true;
            // 
            // btnIPAdd
            // 
            this.btnIPAdd.Location = new System.Drawing.Point(256, 125);
            this.btnIPAdd.Name = "btnIPAdd";
            this.btnIPAdd.Size = new System.Drawing.Size(62, 23);
            this.btnIPAdd.TabIndex = 24;
            this.btnIPAdd.Text = "Add";
            this.btnIPAdd.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 295);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "IP";
            treeNode1.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(225, 245);
            this.treeView1.TabIndex = 12;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // ip
            // 
            dataGridViewCellStyle1.Format = "###.###.###.###";
            dataGridViewCellStyle1.NullValue = null;
            this.ip.DefaultCellStyle = dataGridViewCellStyle1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 565);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbProfiles);
            this.Name = "Form1";
            this.Text = "Quick IP Flip";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbProfiles;
        private System.Windows.Forms.DataGridView dgIp;
        private System.Windows.Forms.GroupBox gbStaticIP;
        private System.Windows.Forms.RadioButton RbStaticIP;
        private System.Windows.Forms.RadioButton RbDHCP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
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
        private System.Windows.Forms.Button bntNew;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIPAdd;
        private System.Windows.Forms.Button btnIPRemove;
        private System.Windows.Forms.Button bntDNSRemove;
        private System.Windows.Forms.Button btnDNSAdd;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subnet;
    }
}

