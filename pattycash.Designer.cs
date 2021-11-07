namespace AyuboDriveFinal
{
    partial class pattycash
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
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.petdeipayBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vserviceBox = new System.Windows.Forms.TextBox();
            this.vwashBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pattydateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(413, 21);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(605, 569);
            this.loadTable.TabIndex = 25;
            this.loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vehicle wash :";
            // 
            // petdeipayBox
            // 
            this.petdeipayBox.Location = new System.Drawing.Point(176, 171);
            this.petdeipayBox.Name = "petdeipayBox";
            this.petdeipayBox.Size = new System.Drawing.Size(231, 22);
            this.petdeipayBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Petrol Deisel pay :";
            // 
            // vserviceBox
            // 
            this.vserviceBox.Location = new System.Drawing.Point(176, 124);
            this.vserviceBox.Name = "vserviceBox";
            this.vserviceBox.Size = new System.Drawing.Size(231, 22);
            this.vserviceBox.TabIndex = 23;
            // 
            // vwashBox
            // 
            this.vwashBox.Location = new System.Drawing.Point(176, 77);
            this.vwashBox.Name = "vwashBox";
            this.vwashBox.Size = new System.Drawing.Size(231, 22);
            this.vwashBox.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox2.Controls.Add(this.pattydateTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.idBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.loadTable);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.petdeipayBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.vserviceBox);
            this.groupBox2.Controls.Add(this.vwashBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 596);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patty cash";
            // 
            // pattydateTime
            // 
            this.pattydateTime.Location = new System.Drawing.Point(176, 219);
            this.pattydateTime.Name = "pattydateTime";
            this.pattydateTime.Size = new System.Drawing.Size(231, 22);
            this.pattydateTime.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date :";
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(176, 43);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(231, 22);
            this.idBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Patty cash ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vehicle service :";
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.dltbtn.Location = new System.Drawing.Point(225, 642);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(101, 38);
            this.dltbtn.TabIndex = 53;
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
            this.updbtn.TabIndex = 54;
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
            this.Savebtn.TabIndex = 55;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.clrbtn.Location = new System.Drawing.Point(333, 642);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(86, 38);
            this.clrbtn.TabIndex = 57;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // pattycash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.Savebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pattycash";
            this.Text = "pattycash";
            this.Load += new System.EventHandler(this.pattycash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox petdeipayBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vserviceBox;
        private System.Windows.Forms.TextBox vwashBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.DateTimePicker pattydateTime;
        private System.Windows.Forms.Label label2;
    }
}