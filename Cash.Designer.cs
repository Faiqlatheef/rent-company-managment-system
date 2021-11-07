namespace AyuboDriveFinal
{
    partial class Cash
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cashdateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PIDComBox = new System.Windows.Forms.ComboBox();
            this.HIDComBox = new System.Windows.Forms.ComboBox();
            this.RIDComBox = new System.Windows.Forms.ComboBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadtable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox1.Controls.Add(this.cashdateTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PIDComBox);
            this.groupBox1.Controls.Add(this.HIDComBox);
            this.groupBox1.Controls.Add(this.RIDComBox);
            this.groupBox1.Controls.Add(this.idbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.loadtable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 587);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash";
            // 
            // cashdateTime
            // 
            this.cashdateTime.Location = new System.Drawing.Point(176, 233);
            this.cashdateTime.Name = "cashdateTime";
            this.cashdateTime.Size = new System.Drawing.Size(247, 22);
            this.cashdateTime.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date :";
            // 
            // PIDComBox
            // 
            this.PIDComBox.FormattingEnabled = true;
            this.PIDComBox.Location = new System.Drawing.Point(176, 176);
            this.PIDComBox.Name = "PIDComBox";
            this.PIDComBox.Size = new System.Drawing.Size(247, 24);
            this.PIDComBox.TabIndex = 28;
            // 
            // HIDComBox
            // 
            this.HIDComBox.FormattingEnabled = true;
            this.HIDComBox.Location = new System.Drawing.Point(176, 124);
            this.HIDComBox.Name = "HIDComBox";
            this.HIDComBox.Size = new System.Drawing.Size(247, 24);
            this.HIDComBox.TabIndex = 28;
            // 
            // RIDComBox
            // 
            this.RIDComBox.FormattingEnabled = true;
            this.RIDComBox.Location = new System.Drawing.Point(176, 82);
            this.RIDComBox.Name = "RIDComBox";
            this.RIDComBox.Size = new System.Drawing.Size(247, 24);
            this.RIDComBox.TabIndex = 28;
            // 
            // idbox
            // 
            this.idbox.Enabled = false;
            this.idbox.Location = new System.Drawing.Point(176, 43);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(247, 22);
            this.idbox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cash ID :";
            // 
            // loadtable
            // 
            this.loadtable.AllowUserToAddRows = false;
            this.loadtable.AllowUserToDeleteRows = false;
            this.loadtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadtable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadtable.Location = new System.Drawing.Point(444, 21);
            this.loadtable.Name = "loadtable";
            this.loadtable.ReadOnly = true;
            this.loadtable.RowTemplate.Height = 24;
            this.loadtable.Size = new System.Drawing.Size(592, 560);
            this.loadtable.TabIndex = 25;
            this.loadtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadtable_CellClick);
            this.loadtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadtable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hire ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rent ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Patty ID :";
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.dltbtn.Location = new System.Drawing.Point(225, 642);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(101, 38);
            this.dltbtn.TabIndex = 47;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.updbtn.Location = new System.Drawing.Point(118, 642);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(101, 38);
            this.updbtn.TabIndex = 48;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Savebtn.Location = new System.Drawing.Point(12, 642);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(101, 38);
            this.Savebtn.TabIndex = 49;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.clrbtn.Location = new System.Drawing.Point(332, 642);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(85, 37);
            this.clrbtn.TabIndex = 51;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.Savebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cash";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Cash_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView loadtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.ComboBox PIDComBox;
        private System.Windows.Forms.ComboBox HIDComBox;
        private System.Windows.Forms.ComboBox RIDComBox;
        private System.Windows.Forms.DateTimePicker cashdateTime;
        private System.Windows.Forms.Label label4;
    }
}