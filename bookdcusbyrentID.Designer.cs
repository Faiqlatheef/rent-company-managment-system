namespace AyuboDriveFinal
{
    partial class bookdcusbyrentID
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
            this.findbtn = new System.Windows.Forms.Button();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rIDBox = new System.Windows.Forms.TextBox();
            this.edateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eDateText = new System.Windows.Forms.Label();
            this.sDateText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rentIdText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bckbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.findbtn.Location = new System.Drawing.Point(916, 115);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(113, 43);
            this.findbtn.TabIndex = 14;
            this.findbtn.Text = "Find";
            this.findbtn.UseVisualStyleBackColor = false;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.Location = new System.Drawing.Point(10, 184);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(927, 496);
            this.loadTable.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.rIDBox);
            this.groupBox3.Controls.Add(this.edateTimePicker);
            this.groupBox3.Controls.Add(this.sdateTimePicker);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1032, 98);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Booked Customer by Rent";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Rent ID :";
            // 
            // rIDBox
            // 
            this.rIDBox.Location = new System.Drawing.Point(114, 35);
            this.rIDBox.Name = "rIDBox";
            this.rIDBox.Size = new System.Drawing.Size(218, 22);
            this.rIDBox.TabIndex = 11;
            // 
            // edateTimePicker
            // 
            this.edateTimePicker.Location = new System.Drawing.Point(831, 38);
            this.edateTimePicker.Name = "edateTimePicker";
            this.edateTimePicker.Size = new System.Drawing.Size(161, 22);
            this.edateTimePicker.TabIndex = 7;
            // 
            // sdateTimePicker
            // 
            this.sdateTimePicker.Location = new System.Drawing.Point(539, 37);
            this.sdateTimePicker.Name = "sdateTimePicker";
            this.sdateTimePicker.Size = new System.Drawing.Size(162, 22);
            this.sdateTimePicker.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(737, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "End Date :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(442, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Start Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "To";
            // 
            // eDateText
            // 
            this.eDateText.AutoSize = true;
            this.eDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDateText.Location = new System.Drawing.Point(640, 138);
            this.eDateText.Name = "eDateText";
            this.eDateText.Size = new System.Drawing.Size(123, 20);
            this.eDateText.TabIndex = 20;
            this.eDateText.Text = "YYYY/MM/DD";
            // 
            // sDateText
            // 
            this.sDateText.AutoSize = true;
            this.sDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDateText.Location = new System.Drawing.Point(455, 138);
            this.sDateText.Name = "sDateText";
            this.sDateText.Size = new System.Drawing.Size(123, 20);
            this.sDateText.TabIndex = 21;
            this.sDateText.Text = "YYYY/MM/DD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Searching Dates :";
            // 
            // rentIdText
            // 
            this.rentIdText.AutoSize = true;
            this.rentIdText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rentIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentIdText.Location = new System.Drawing.Point(159, 138);
            this.rentIdText.Name = "rentIdText";
            this.rentIdText.Size = new System.Drawing.Size(84, 20);
            this.rentIdText.TabIndex = 23;
            this.rentIdText.Text = "loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Rent ID :";
            // 
            // bckbtn
            // 
            this.bckbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.bckbtn.Location = new System.Drawing.Point(943, 639);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(86, 41);
            this.bckbtn.TabIndex = 25;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = false;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // bookdcusbyrentID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eDateText);
            this.Controls.Add(this.sDateText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rentIdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookdcusbyrentID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookdcusbyrentID";
            this.Load += new System.EventHandler(this.bookdcusbyrentID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findbtn;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rIDBox;
        private System.Windows.Forms.DateTimePicker edateTimePicker;
        private System.Windows.Forms.DateTimePicker sdateTimePicker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eDateText;
        private System.Windows.Forms.Label sDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rentIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bckbtn;
    }
}