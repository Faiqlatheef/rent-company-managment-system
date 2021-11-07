namespace AyuboDriveFinal
{
    partial class mainfrmcntn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thlabel = new System.Windows.Forms.Label();
            this.trlabel = new System.Windows.Forms.Label();
            this.tdlabel = new System.Windows.Forms.Label();
            this.tvlabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Hire  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Rent :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Drivers :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Vehicles :";
            // 
            // thlabel
            // 
            this.thlabel.AutoSize = true;
            this.thlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thlabel.Location = new System.Drawing.Point(630, 217);
            this.thlabel.Name = "thlabel";
            this.thlabel.Size = new System.Drawing.Size(52, 55);
            this.thlabel.TabIndex = 1;
            this.thlabel.Text = "0";
            // 
            // trlabel
            // 
            this.trlabel.AutoSize = true;
            this.trlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trlabel.Location = new System.Drawing.Point(630, 310);
            this.trlabel.Name = "trlabel";
            this.trlabel.Size = new System.Drawing.Size(52, 55);
            this.trlabel.TabIndex = 1;
            this.trlabel.Text = "0";
            // 
            // tdlabel
            // 
            this.tdlabel.AutoSize = true;
            this.tdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdlabel.Location = new System.Drawing.Point(630, 418);
            this.tdlabel.Name = "tdlabel";
            this.tdlabel.Size = new System.Drawing.Size(52, 55);
            this.tdlabel.TabIndex = 1;
            this.tdlabel.Text = "0";
            // 
            // tvlabel
            // 
            this.tvlabel.AutoSize = true;
            this.tvlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvlabel.Location = new System.Drawing.Point(630, 520);
            this.tvlabel.Name = "tvlabel";
            this.tvlabel.Size = new System.Drawing.Size(52, 55);
            this.tvlabel.TabIndex = 1;
            this.tvlabel.Text = "0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(919, 632);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(135, 32);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(13, 632);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(183, 32);
            this.datelabel.TabIndex = 3;
            this.datelabel.Text = "DD:MM:YYY";
            // 
            // mainfrmcntn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._1518409943_2618_23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.tvlabel);
            this.Controls.Add(this.tdlabel);
            this.Controls.Add(this.trlabel);
            this.Controls.Add(this.thlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainfrmcntn";
            this.Text = "mainfrmcntn";
            this.Load += new System.EventHandler(this.mainfrmcntn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label thlabel;
        private System.Windows.Forms.Label trlabel;
        private System.Windows.Forms.Label tdlabel;
        private System.Windows.Forms.Label tvlabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelabel;
    }
}