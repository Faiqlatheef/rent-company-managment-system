namespace AyuboDriveFinal
{
    partial class mainForm
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
            this.Xlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginlabel = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.reportslabel = new System.Windows.Forms.Label();
            this.vehicletypeLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.ratesLabel = new System.Windows.Forms.Label();
            this.hirepaymentLabel = new System.Windows.Forms.Label();
            this.hirepackageLabel = new System.Windows.Forms.Label();
            this.hireLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.rentLabel = new System.Windows.Forms.Label();
            this.rentpaymentLabel = new System.Windows.Forms.Label();
            this.pattycashLabel = new System.Windows.Forms.Label();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xlabel.ForeColor = System.Drawing.Color.Red;
            this.Xlabel.Location = new System.Drawing.Point(1226, 9);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(27, 25);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "X";
            this.Xlabel.Click += new System.EventHandler(this.Xlabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Xlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 43);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.IMG_20190708_200836;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.loginlabel);
            this.panel2.Controls.Add(this.logoutbtn);
            this.panel2.Controls.Add(this.reportslabel);
            this.panel2.Controls.Add(this.vehicletypeLabel);
            this.panel2.Controls.Add(this.cashLabel);
            this.panel2.Controls.Add(this.customerLabel);
            this.panel2.Controls.Add(this.ratesLabel);
            this.panel2.Controls.Add(this.hirepaymentLabel);
            this.panel2.Controls.Add(this.hirepackageLabel);
            this.panel2.Controls.Add(this.hireLabel);
            this.panel2.Controls.Add(this.driverLabel);
            this.panel2.Controls.Add(this.rentLabel);
            this.panel2.Controls.Add(this.rentpaymentLabel);
            this.panel2.Controls.Add(this.pattycashLabel);
            this.panel2.Controls.Add(this.vehicleLabel);
            this.panel2.Controls.Add(this.homeLabel);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 692);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Location = new System.Drawing.Point(30, 580);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(67, 17);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "> LOGIN ";
            this.loginlabel.Click += new System.EventHandler(this.loginlabel_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.Red;
            this.logoutbtn.Location = new System.Drawing.Point(15, 615);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(169, 65);
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // reportslabel
            // 
            this.reportslabel.AutoSize = true;
            this.reportslabel.BackColor = System.Drawing.Color.White;
            this.reportslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportslabel.Location = new System.Drawing.Point(30, 542);
            this.reportslabel.Name = "reportslabel";
            this.reportslabel.Size = new System.Drawing.Size(87, 17);
            this.reportslabel.TabIndex = 0;
            this.reportslabel.Text = "> REPORTS";
            this.reportslabel.Click += new System.EventHandler(this.reportslabel_Click);
            // 
            // vehicletypeLabel
            // 
            this.vehicletypeLabel.AutoSize = true;
            this.vehicletypeLabel.BackColor = System.Drawing.Color.White;
            this.vehicletypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vehicletypeLabel.Location = new System.Drawing.Point(30, 506);
            this.vehicletypeLabel.Name = "vehicletypeLabel";
            this.vehicletypeLabel.Size = new System.Drawing.Size(117, 17);
            this.vehicletypeLabel.TabIndex = 0;
            this.vehicletypeLabel.Text = "> VEHICLE TYPE";
            this.vehicletypeLabel.Click += new System.EventHandler(this.vehicletypeLabel_Click);
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.BackColor = System.Drawing.Color.White;
            this.cashLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashLabel.Location = new System.Drawing.Point(30, 157);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(57, 17);
            this.cashLabel.TabIndex = 0;
            this.cashLabel.Text = "> CASH";
            this.cashLabel.Click += new System.EventHandler(this.cashLabel_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.BackColor = System.Drawing.Color.White;
            this.customerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerLabel.Location = new System.Drawing.Point(30, 122);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(98, 17);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "> CUSTOMER";
            this.customerLabel.Click += new System.EventHandler(this.customerLabel_Click);
            // 
            // ratesLabel
            // 
            this.ratesLabel.AutoSize = true;
            this.ratesLabel.BackColor = System.Drawing.Color.White;
            this.ratesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ratesLabel.Location = new System.Drawing.Point(30, 351);
            this.ratesLabel.Name = "ratesLabel";
            this.ratesLabel.Size = new System.Drawing.Size(66, 17);
            this.ratesLabel.TabIndex = 0;
            this.ratesLabel.Text = "> RATES";
            this.ratesLabel.Click += new System.EventHandler(this.ratesLabel_Click);
            // 
            // hirepaymentLabel
            // 
            this.hirepaymentLabel.AutoSize = true;
            this.hirepaymentLabel.BackColor = System.Drawing.Color.White;
            this.hirepaymentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hirepaymentLabel.Location = new System.Drawing.Point(30, 268);
            this.hirepaymentLabel.Name = "hirepaymentLabel";
            this.hirepaymentLabel.Size = new System.Drawing.Size(122, 17);
            this.hirepaymentLabel.TabIndex = 0;
            this.hirepaymentLabel.Text = "> HIRE PAYMENT";
            this.hirepaymentLabel.Click += new System.EventHandler(this.hirepaymentLabel_Click);
            // 
            // hirepackageLabel
            // 
            this.hirepackageLabel.AutoSize = true;
            this.hirepackageLabel.BackColor = System.Drawing.Color.White;
            this.hirepackageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hirepackageLabel.Location = new System.Drawing.Point(30, 232);
            this.hirepackageLabel.Name = "hirepackageLabel";
            this.hirepackageLabel.Size = new System.Drawing.Size(130, 17);
            this.hirepackageLabel.TabIndex = 0;
            this.hirepackageLabel.Text = "> HIRE PACKAGES";
            this.hirepackageLabel.Click += new System.EventHandler(this.hirepackageLabel_Click);
            // 
            // hireLabel
            // 
            this.hireLabel.AutoSize = true;
            this.hireLabel.BackColor = System.Drawing.Color.White;
            this.hireLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hireLabel.Location = new System.Drawing.Point(30, 191);
            this.hireLabel.Name = "hireLabel";
            this.hireLabel.Size = new System.Drawing.Size(52, 17);
            this.hireLabel.TabIndex = 0;
            this.hireLabel.Text = "> HIRE";
            this.hireLabel.Click += new System.EventHandler(this.hireLabel_Click);
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.BackColor = System.Drawing.Color.White;
            this.driverLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.driverLabel.Location = new System.Drawing.Point(30, 84);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(71, 17);
            this.driverLabel.TabIndex = 0;
            this.driverLabel.Text = "> DRIVER";
            this.driverLabel.Click += new System.EventHandler(this.driverLabel_Click);
            // 
            // rentLabel
            // 
            this.rentLabel.AutoSize = true;
            this.rentLabel.BackColor = System.Drawing.Color.White;
            this.rentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentLabel.Location = new System.Drawing.Point(30, 389);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(62, 17);
            this.rentLabel.TabIndex = 0;
            this.rentLabel.Text = "> RENT ";
            this.rentLabel.Click += new System.EventHandler(this.rentLabel_Click);
            // 
            // rentpaymentLabel
            // 
            this.rentpaymentLabel.AutoSize = true;
            this.rentpaymentLabel.BackColor = System.Drawing.Color.White;
            this.rentpaymentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentpaymentLabel.Location = new System.Drawing.Point(30, 429);
            this.rentpaymentLabel.Name = "rentpaymentLabel";
            this.rentpaymentLabel.Size = new System.Drawing.Size(128, 17);
            this.rentpaymentLabel.TabIndex = 0;
            this.rentpaymentLabel.Text = "> RENT PAYMENT";
            this.rentpaymentLabel.Click += new System.EventHandler(this.rentpaymentLabel_Click);
            // 
            // pattycashLabel
            // 
            this.pattycashLabel.AutoSize = true;
            this.pattycashLabel.BackColor = System.Drawing.Color.White;
            this.pattycashLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pattycashLabel.Location = new System.Drawing.Point(30, 310);
            this.pattycashLabel.Name = "pattycashLabel";
            this.pattycashLabel.Size = new System.Drawing.Size(106, 17);
            this.pattycashLabel.TabIndex = 0;
            this.pattycashLabel.Text = "> PATTY CASH";
            this.pattycashLabel.Click += new System.EventHandler(this.pattycashLabel_Click);
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.BackColor = System.Drawing.Color.White;
            this.vehicleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vehicleLabel.Location = new System.Drawing.Point(30, 467);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(77, 17);
            this.vehicleLabel.TabIndex = 0;
            this.vehicleLabel.Text = "> VEHICLE";
            this.vehicleLabel.Click += new System.EventHandler(this.vehicleLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.BackColor = System.Drawing.Color.White;
            this.homeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeLabel.Location = new System.Drawing.Point(30, 52);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(61, 17);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "> HOME";
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(199, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 692);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AyuboDriveFinal.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 735);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label vehicletypeLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label hireLabel;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label ratesLabel;
        private System.Windows.Forms.Label hirepaymentLabel;
        private System.Windows.Forms.Label hirepackageLabel;
        private System.Windows.Forms.Label rentpaymentLabel;
        private System.Windows.Forms.Label pattycashLabel;
        private System.Windows.Forms.Label rentLabel;
        private System.Windows.Forms.Label reportslabel;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}