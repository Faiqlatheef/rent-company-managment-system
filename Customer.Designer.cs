namespace AyuboDriveFinal
{
    partial class Customer
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
            this.telnoBox = new System.Windows.Forms.TextBox();
            this.addBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srchbtn = new System.Windows.Forms.Button();
            this.srchBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Updbtn = new System.Windows.Forms.Button();
            this.Dltbtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // telnoBox
            // 
            this.telnoBox.Location = new System.Drawing.Point(169, 207);
            this.telnoBox.Name = "telnoBox";
            this.telnoBox.Size = new System.Drawing.Size(263, 22);
            this.telnoBox.TabIndex = 23;
            // 
            // addBox
            // 
            this.addBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBox.Location = new System.Drawing.Point(169, 142);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(263, 38);
            this.addBox.TabIndex = 22;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(169, 90);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(263, 22);
            this.nameBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Customer Tel no :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customer Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer Name :";
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(455, 54);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(572, 556);
            this.loadTable.TabIndex = 25;
            this.loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellClick);
            this.loadTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox1.Controls.Add(this.srchbtn);
            this.groupBox1.Controls.Add(this.srchBox);
            this.groupBox1.Controls.Add(this.idBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loadTable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.telnoBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 616);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.srchbtn.Location = new System.Drawing.Point(592, 18);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(75, 26);
            this.srchbtn.TabIndex = 29;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // srchBox
            // 
            this.srchBox.Location = new System.Drawing.Point(455, 22);
            this.srchBox.Name = "srchBox";
            this.srchBox.Size = new System.Drawing.Size(131, 22);
            this.srchBox.TabIndex = 28;
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(169, 49);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(263, 22);
            this.idBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer ID :";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Savebtn.Location = new System.Drawing.Point(12, 643);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(87, 37);
            this.Savebtn.TabIndex = 28;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Updbtn
            // 
            this.Updbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Updbtn.Location = new System.Drawing.Point(105, 643);
            this.Updbtn.Name = "Updbtn";
            this.Updbtn.Size = new System.Drawing.Size(87, 37);
            this.Updbtn.TabIndex = 28;
            this.Updbtn.Text = "Update";
            this.Updbtn.UseVisualStyleBackColor = false;
            this.Updbtn.Click += new System.EventHandler(this.Updbtn_Click);
            // 
            // Dltbtn
            // 
            this.Dltbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Dltbtn.Location = new System.Drawing.Point(198, 643);
            this.Dltbtn.Name = "Dltbtn";
            this.Dltbtn.Size = new System.Drawing.Size(87, 37);
            this.Dltbtn.TabIndex = 28;
            this.Dltbtn.Text = "Delete";
            this.Dltbtn.UseVisualStyleBackColor = false;
            this.Dltbtn.Click += new System.EventHandler(this.Dltbtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.clrbtn.Location = new System.Drawing.Point(300, 644);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(90, 36);
            this.clrbtn.TabIndex = 29;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.Dltbtn);
            this.Controls.Add(this.Updbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox telnoBox;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Updbtn;
        private System.Windows.Forms.Button Dltbtn;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox srchBox;
    }
}

