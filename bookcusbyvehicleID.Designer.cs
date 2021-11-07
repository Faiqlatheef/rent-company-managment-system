namespace AyuboDriveFinal
{
    partial class bookcusbyvehicleID
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vIDBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eDateText = new System.Windows.Forms.Label();
            this.sDateText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vehicleIdText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bckbtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox3.Controls.Add(this.edateTimePicker);
            this.groupBox3.Controls.Add(this.sdateTimePicker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.vIDBox);
            this.groupBox3.Location = new System.Drawing.Point(16, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 112);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Booked Customer by Vehicle";
            // 
            // edateTimePicker
            // 
            this.edateTimePicker.Location = new System.Drawing.Point(842, 39);
            this.edateTimePicker.Name = "edateTimePicker";
            this.edateTimePicker.Size = new System.Drawing.Size(163, 22);
            this.edateTimePicker.TabIndex = 7;
            // 
            // sdateTimePicker
            // 
            this.sdateTimePicker.Location = new System.Drawing.Point(534, 38);
            this.sdateTimePicker.Name = "sdateTimePicker";
            this.sdateTimePicker.Size = new System.Drawing.Size(165, 22);
            this.sdateTimePicker.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "End Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Start Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vehicle ID :";
            // 
            // vIDBox
            // 
            this.vIDBox.Location = new System.Drawing.Point(109, 40);
            this.vIDBox.Name = "vIDBox";
            this.vIDBox.Size = new System.Drawing.Size(218, 22);
            this.vIDBox.TabIndex = 3;
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.findBtn.Location = new System.Drawing.Point(908, 140);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(113, 43);
            this.findBtn.TabIndex = 11;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.Location = new System.Drawing.Point(12, 202);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(872, 478);
            this.loadTable.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "To";
            // 
            // eDateText
            // 
            this.eDateText.AutoSize = true;
            this.eDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDateText.Location = new System.Drawing.Point(641, 163);
            this.eDateText.Name = "eDateText";
            this.eDateText.Size = new System.Drawing.Size(123, 20);
            this.eDateText.TabIndex = 14;
            this.eDateText.Text = "YYYY/MM/DD";
            // 
            // sDateText
            // 
            this.sDateText.AutoSize = true;
            this.sDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDateText.Location = new System.Drawing.Point(456, 163);
            this.sDateText.Name = "sDateText";
            this.sDateText.Size = new System.Drawing.Size(123, 20);
            this.sDateText.TabIndex = 15;
            this.sDateText.Text = "YYYY/MM/DD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Searching Dates :";
            // 
            // vehicleIdText
            // 
            this.vehicleIdText.AutoSize = true;
            this.vehicleIdText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vehicleIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleIdText.Location = new System.Drawing.Point(160, 163);
            this.vehicleIdText.Name = "vehicleIdText";
            this.vehicleIdText.Size = new System.Drawing.Size(84, 20);
            this.vehicleIdText.TabIndex = 17;
            this.vehicleIdText.Text = "loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vehicle ID :";
            // 
            // bckbtn
            // 
            this.bckbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.bckbtn.Location = new System.Drawing.Point(932, 636);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(89, 44);
            this.bckbtn.TabIndex = 19;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = false;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // bookcusbyvehicleID
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
            this.Controls.Add(this.vehicleIdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookcusbyvehicleID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookcusbyvehicleID";
            this.Load += new System.EventHandler(this.bookcusbyvehicleID_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker edateTimePicker;
        private System.Windows.Forms.DateTimePicker sdateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vIDBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eDateText;
        private System.Windows.Forms.Label sDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vehicleIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bckbtn;
    }
}