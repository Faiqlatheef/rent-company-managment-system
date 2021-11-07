namespace AyuboDriveFinal
{
    partial class AvailableVehicles
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vIDBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingTypeText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleIdText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sDateText = new System.Windows.Forms.Label();
            this.eDateText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bckbtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox2.Controls.Add(this.eDateTimePicker);
            this.groupBox2.Controls.Add(this.sDateTimePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.vIDBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Vehicles";
            // 
            // eDateTimePicker
            // 
            this.eDateTimePicker.Location = new System.Drawing.Point(774, 41);
            this.eDateTimePicker.Name = "eDateTimePicker";
            this.eDateTimePicker.Size = new System.Drawing.Size(154, 22);
            this.eDateTimePicker.TabIndex = 7;
            // 
            // sDateTimePicker
            // 
            this.sDateTimePicker.Location = new System.Drawing.Point(450, 39);
            this.sDateTimePicker.Name = "sDateTimePicker";
            this.sDateTimePicker.Size = new System.Drawing.Size(171, 22);
            this.sDateTimePicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vehicle ID :";
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
            this.findBtn.Location = new System.Drawing.Point(916, 135);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(120, 47);
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
            this.loadTable.Location = new System.Drawing.Point(9, 221);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(938, 459);
            this.loadTable.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Booking Type :";
            // 
            // bookingTypeText
            // 
            this.bookingTypeText.AutoSize = true;
            this.bookingTypeText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookingTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingTypeText.Location = new System.Drawing.Point(152, 198);
            this.bookingTypeText.Name = "bookingTypeText";
            this.bookingTypeText.Size = new System.Drawing.Size(84, 20);
            this.bookingTypeText.TabIndex = 12;
            this.bookingTypeText.Text = "loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vehicle ID :";
            // 
            // vehicleIdText
            // 
            this.vehicleIdText.AutoSize = true;
            this.vehicleIdText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vehicleIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleIdText.Location = new System.Drawing.Point(372, 198);
            this.vehicleIdText.Name = "vehicleIdText";
            this.vehicleIdText.Size = new System.Drawing.Size(84, 20);
            this.vehicleIdText.TabIndex = 12;
            this.vehicleIdText.Text = "loading...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Searching Dates :";
            // 
            // sDateText
            // 
            this.sDateText.AutoSize = true;
            this.sDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDateText.Location = new System.Drawing.Point(653, 198);
            this.sDateText.Name = "sDateText";
            this.sDateText.Size = new System.Drawing.Size(123, 20);
            this.sDateText.TabIndex = 12;
            this.sDateText.Text = "YYYY/MM/DD";
            // 
            // eDateText
            // 
            this.eDateText.AutoSize = true;
            this.eDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDateText.Location = new System.Drawing.Point(838, 198);
            this.eDateText.Name = "eDateText";
            this.eDateText.Size = new System.Drawing.Size(123, 20);
            this.eDateText.TabIndex = 12;
            this.eDateText.Text = "YYYY/MM/DD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(784, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "To";
            // 
            // bckbtn
            // 
            this.bckbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.bckbtn.Location = new System.Drawing.Point(953, 639);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(86, 41);
            this.bckbtn.TabIndex = 13;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = false;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // AvailableVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eDateText);
            this.Controls.Add(this.sDateText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicleIdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookingTypeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvailableVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvailableVehicles";
            this.Load += new System.EventHandler(this.AvailableVehicles_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker eDateTimePicker;
        private System.Windows.Forms.DateTimePicker sDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vIDBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookingTypeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vehicleIdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sDateText;
        private System.Windows.Forms.Label eDateText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bckbtn;
    }
}