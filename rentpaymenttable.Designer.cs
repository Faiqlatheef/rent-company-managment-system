namespace AyuboDriveFinal
{
    partial class rentpaymenttable
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
            this.bckbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            this.SuspendLayout();
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(21, 24);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(1012, 591);
            this.loadTable.TabIndex = 26;
            // 
            // bckbtn
            // 
            this.bckbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.bckbtn.Location = new System.Drawing.Point(955, 635);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(99, 45);
            this.bckbtn.TabIndex = 28;
            this.bckbtn.Text = "Back";
            this.bckbtn.UseVisualStyleBackColor = false;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // rentpaymenttable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDriveFinal.Properties.Resources._8181;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.loadTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rentpaymenttable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rentpaymenttable";
            this.Load += new System.EventHandler(this.rentpaymenttable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Button bckbtn;
    }
}