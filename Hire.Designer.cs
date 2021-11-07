namespace AyuboDriveFinal
{
    partial class Hire
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
            this.hedateTime = new System.Windows.Forms.DateTimePicker();
            this.hsdateTime = new System.Windows.Forms.DateTimePicker();
            this.hbdateTime = new System.Windows.Forms.DateTimePicker();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CIDComBox = new System.Windows.Forms.ComboBox();
            this.DIDComBox = new System.Windows.Forms.ComboBox();
            this.VIDComBox = new System.Windows.Forms.ComboBox();
            this.HPIDComBox = new System.Windows.Forms.ComboBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hwcfBox = new System.Windows.Forms.TextBox();
            this.hwcfhBox = new System.Windows.Forms.TextBox();
            this.maxkmBox = new System.Windows.Forms.TextBox();
            this.minkmBox = new System.Windows.Forms.TextBox();
            this.clrbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hedateTime
            // 
            this.hedateTime.Location = new System.Drawing.Point(181, 296);
            this.hedateTime.Name = "hedateTime";
            this.hedateTime.Size = new System.Drawing.Size(254, 22);
            this.hedateTime.TabIndex = 26;
            // 
            // hsdateTime
            // 
            this.hsdateTime.Location = new System.Drawing.Point(181, 259);
            this.hsdateTime.Name = "hsdateTime";
            this.hsdateTime.Size = new System.Drawing.Size(254, 22);
            this.hsdateTime.TabIndex = 26;
            // 
            // hbdateTime
            // 
            this.hbdateTime.Enabled = false;
            this.hbdateTime.Location = new System.Drawing.Point(181, 223);
            this.hbdateTime.Name = "hbdateTime";
            this.hbdateTime.Size = new System.Drawing.Size(254, 22);
            this.hbdateTime.TabIndex = 26;
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(454, 21);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(589, 581);
            this.loadTable.TabIndex = 25;
            this.loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Driver ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "HP ID :";
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.dltbtn.Location = new System.Drawing.Point(224, 642);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(101, 38);
            this.dltbtn.TabIndex = 39;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.updbtn.Location = new System.Drawing.Point(117, 642);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(101, 38);
            this.updbtn.TabIndex = 40;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Savebtn.Location = new System.Drawing.Point(11, 642);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(101, 38);
            this.Savebtn.TabIndex = 41;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hire End Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hire Book Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hire Start Date :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox1.Controls.Add(this.CIDComBox);
            this.groupBox1.Controls.Add(this.DIDComBox);
            this.groupBox1.Controls.Add(this.VIDComBox);
            this.groupBox1.Controls.Add(this.HPIDComBox);
            this.groupBox1.Controls.Add(this.idBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hedateTime);
            this.groupBox1.Controls.Add(this.hsdateTime);
            this.groupBox1.Controls.Add(this.hbdateTime);
            this.groupBox1.Controls.Add(this.loadTable);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hwcfBox);
            this.groupBox1.Controls.Add(this.hwcfhBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maxkmBox);
            this.groupBox1.Controls.Add(this.minkmBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 608);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hire";
            // 
            // CIDComBox
            // 
            this.CIDComBox.FormattingEnabled = true;
            this.CIDComBox.Location = new System.Drawing.Point(181, 410);
            this.CIDComBox.Name = "CIDComBox";
            this.CIDComBox.Size = new System.Drawing.Size(254, 24);
            this.CIDComBox.TabIndex = 29;
            // 
            // DIDComBox
            // 
            this.DIDComBox.FormattingEnabled = true;
            this.DIDComBox.Location = new System.Drawing.Point(181, 382);
            this.DIDComBox.Name = "DIDComBox";
            this.DIDComBox.Size = new System.Drawing.Size(254, 24);
            this.DIDComBox.TabIndex = 29;
            // 
            // VIDComBox
            // 
            this.VIDComBox.FormattingEnabled = true;
            this.VIDComBox.Location = new System.Drawing.Point(181, 355);
            this.VIDComBox.Name = "VIDComBox";
            this.VIDComBox.Size = new System.Drawing.Size(254, 24);
            this.VIDComBox.TabIndex = 29;
            // 
            // HPIDComBox
            // 
            this.HPIDComBox.FormattingEnabled = true;
            this.HPIDComBox.Location = new System.Drawing.Point(181, 327);
            this.HPIDComBox.Name = "HPIDComBox";
            this.HPIDComBox.Size = new System.Drawing.Size(254, 24);
            this.HPIDComBox.TabIndex = 29;
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(176, 58);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(254, 22);
            this.idBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hire ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Vehicle ID :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Hire waiting charge fee  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Hire waiting charge fee hours  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Maximum KM :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Minimum KM :";
            // 
            // hwcfBox
            // 
            this.hwcfBox.Location = new System.Drawing.Point(238, 189);
            this.hwcfBox.Name = "hwcfBox";
            this.hwcfBox.Size = new System.Drawing.Size(197, 22);
            this.hwcfBox.TabIndex = 21;
            // 
            // hwcfhBox
            // 
            this.hwcfhBox.Location = new System.Drawing.Point(238, 154);
            this.hwcfhBox.Name = "hwcfhBox";
            this.hwcfhBox.Size = new System.Drawing.Size(197, 22);
            this.hwcfhBox.TabIndex = 21;
            // 
            // maxkmBox
            // 
            this.maxkmBox.Location = new System.Drawing.Point(176, 120);
            this.maxkmBox.Name = "maxkmBox";
            this.maxkmBox.Size = new System.Drawing.Size(254, 22);
            this.maxkmBox.TabIndex = 21;
            // 
            // minkmBox
            // 
            this.minkmBox.Location = new System.Drawing.Point(176, 87);
            this.minkmBox.Name = "minkmBox";
            this.minkmBox.Size = new System.Drawing.Size(254, 22);
            this.minkmBox.TabIndex = 21;
            this.minkmBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.clrbtn.Location = new System.Drawing.Point(331, 642);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(79, 38);
            this.clrbtn.TabIndex = 42;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // Hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hire";
            this.Text = "Hire";
            this.Load += new System.EventHandler(this.Hire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker hedateTime;
        private System.Windows.Forms.DateTimePicker hsdateTime;
        private System.Windows.Forms.DateTimePicker hbdateTime;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hwcfBox;
        private System.Windows.Forms.TextBox hwcfhBox;
        private System.Windows.Forms.TextBox maxkmBox;
        private System.Windows.Forms.TextBox minkmBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.ComboBox CIDComBox;
        private System.Windows.Forms.ComboBox DIDComBox;
        private System.Windows.Forms.ComboBox VIDComBox;
        private System.Windows.Forms.ComboBox HPIDComBox;
    }
}