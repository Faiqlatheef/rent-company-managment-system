namespace AyuboDriveFinal
{
    partial class vehiclecoast
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
            this.pIDBox = new System.Windows.Forms.TextBox();
            this.findbtn = new System.Windows.Forms.Button();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eDateText = new System.Windows.Forms.Label();
            this.sDateText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pattyIdText = new System.Windows.Forms.Label();
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
            this.groupBox4.Controls.Add(this.pIDBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1005, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vehicle Coast";
            // 
            // edateTimePicker
            // 
            this.edateTimePicker.Location = new System.Drawing.Point(735, 38);
            this.edateTimePicker.Name = "edateTimePicker";
            this.edateTimePicker.Size = new System.Drawing.Size(158, 22);
            this.edateTimePicker.TabIndex = 7;
            // 
            // sdateTimePicker
            // 
            this.sdateTimePicker.Location = new System.Drawing.Point(430, 39);
            this.sdateTimePicker.Name = "sdateTimePicker";
            this.sdateTimePicker.Size = new System.Drawing.Size(171, 22);
            this.sdateTimePicker.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(654, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "End Date :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(335, 43);
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
            this.label18.Size = new System.Drawing.Size(65, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Patty ID :";
            // 
            // pIDBox
            // 
            this.pIDBox.Location = new System.Drawing.Point(109, 40);
            this.pIDBox.Name = "pIDBox";
            this.pIDBox.Size = new System.Drawing.Size(168, 22);
            this.pIDBox.TabIndex = 3;
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.findbtn.Location = new System.Drawing.Point(904, 141);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(113, 43);
            this.findbtn.TabIndex = 13;
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
            this.loadTable.Location = new System.Drawing.Point(12, 204);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(932, 476);
            this.loadTable.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 151);
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
            this.eDateText.Location = new System.Drawing.Point(630, 151);
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
            this.sDateText.Location = new System.Drawing.Point(445, 151);
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
            this.label3.Location = new System.Drawing.Point(278, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Searching Dates :";
            // 
            // pattyIdText
            // 
            this.pattyIdText.AutoSize = true;
            this.pattyIdText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pattyIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pattyIdText.Location = new System.Drawing.Point(149, 151);
            this.pattyIdText.Name = "pattyIdText";
            this.pattyIdText.Size = new System.Drawing.Size(84, 20);
            this.pattyIdText.TabIndex = 23;
            this.pattyIdText.Text = "loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Patty ID :";
            // 
            // bckbtn
            // 
            this.bckbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.bckbtn.Location = new System.Drawing.Point(968, 639);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(86, 41);
            this.bckbtn.TabIndex = 25;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = false;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // vehiclecoast
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
            this.Controls.Add(this.pattyIdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehiclecoast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vehiclecoast";
            this.Load += new System.EventHandler(this.vehiclecoast_Load);
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
        private System.Windows.Forms.TextBox pIDBox;
        private System.Windows.Forms.Button findbtn;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eDateText;
        private System.Windows.Forms.Label sDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pattyIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bckbtn;
    }
}