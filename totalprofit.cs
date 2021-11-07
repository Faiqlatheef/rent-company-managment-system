﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDriveFinal
{
    public partial class totalprofit : Form
    {
        public totalprofit()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void totalprofit_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            if (sdateTimePicker.Text != "" && edateTimePicker.Text != "")
            {
                sDateText.Text = sdateTimePicker.Text;
                eDateText.Text = edateTimePicker.Text;


                // check from hire table
                DataTable dt = A.getData("select *from Cash where Cash_date '" + sdateTimePicker.Text + "' and Cash_date '" + edateTimePicker.Text + "' ");
                if (dt.Rows.Count > 0)
                {
                    loadTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Check the Two dates ");
                }
            }
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
