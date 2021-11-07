namespace AyuboDriveFinal
{
    partial class vehicleincome
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.vIDBox = new System.Windows.Forms.TextBox();
            this.findbtn = new System.Windows.Forms.Button();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.eDateText = new System.Windows.Forms.Label();
            this.sDateText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vehicleIdText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bckbtn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.flat_550x550_075_f_u3;
            this.groupBox4.Controls.Add(this.edateTimePicker);
            this.groupBox4.Controls.Add(this.sdateTimePicker);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.vIDBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1020, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vehicle Income";
            // 
            // edateTimePicker
            // 
            this.edateTimePicker.Location = new System.Drawing.Point(765, 45);
            this.edateTimePicker.Name = "edateTimePicker";
            this.edateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.edateTimePicker.TabIndex = 7;
            // 
            // sdateTimePicker
            // 
            this.sdateTimePicker.Location = new System.Drawing.Point(474, 40);
            this.sdateTimePicker.Name = "sdateTimePicker";
            this.sdateTimePicker.Size = new System.Drawing.Size(164, 22);
            this.sdateTimePicker.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(669, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "End Date :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(377, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Start Date :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Vehicle ID :";
            // 
            // vIDBox
            // 
            this.vIDBox.Location = new System.Drawing.Point(109, 40);
            this.vIDBox.Name = "vIDBox";
            this.vIDBox.Size = new System.Drawing.Size(218, 22);
            this.vIDBox.TabIndex = 3;
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.findbtn.Location = new System.Drawing.Point(919, 140);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(113, 43);
            this.findbtn.TabIndex = 11;
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
            this.loadTable.Location = new System.Drawing.Point(12, 189);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(928, 491);
            this.loadTable.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(573, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "To";
            // 
            // eDateText
            // 
            this.eDateText.AutoSize = true;
            this.eDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDateText.Location = new System.Drawing.Point(627, 149);
            this.eDateText.Name = "eDateText";
            this.eDateText.Size = new System.Drawing.Size(123, 20);
            this.eDateText.TabIndex = 21;
            this.eDateText.Text = "YYYY/MM/DD";
            // 
            // sDateText
            // 
            this.sDateText.AutoSize = true;
            this.sDateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDateText.Location = new System.Drawing.Point(442, 149);
            this.sDateText.Name = "sDateText";
            this.sDateText.Size = new System.Drawing.Size(123, 20);
            this.sDateText.TabIndex = 22;
            this.sDateText.Text = "YYYY/MM/DD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Searching Dates :";
            // 
            // vehicleIdText
            // 
            this.vehicleIdText.AutoSize = true;
            this.vehicleIdText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vehicleIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleIdText.Location = new System.Drawing.Point(146, 149);
            this.vehicleIdText.Name = "vehicleIdText";
            this.vehicleIdText.Size = new System.Drawing.Size(84, 20);
            this.vehicleIdText.TabIndex = 24;
            this.vehicleIdText.Text = "loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Vehicle ID :";
            // 
            // bckbtn
            // 
            this.bckbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.bckbtn.Location = new System.Drawing.Point(968, 639);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(86, 41);
            this.bckbtn.TabIndex = 26;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = false;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // vehicleincome
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
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehicleincome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vehicleincome";
            this.Load += new System.EventHandler(this.vehicleincome_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker edateTimePicker;
        private System.Windows.Forms.DateTimePicker sdateTimePicker;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox vIDBox;
        private System.Windows.Forms.Button findbtn;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label eDateText;
        private System.Windows.Forms.Label sDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vehicleIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bckbtn;
    }
}