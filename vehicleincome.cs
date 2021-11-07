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
    public partial class vehicleincome : Form
    {
        public vehicleincome()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void findbtn_Click(object sender, EventArgs e)
        {
            if (vIDBox.Text != "")
            {

                vehicleIdText.Text = vIDBox.Text;
                sDateText.Text = sdateTimePicker.Text;
                eDateText.Text = edateTimePicker.Text;


                // check from hire payment table
                DataTable dt = A.getData("select HP_Basic_Charge from Hire_payment join Hire on Hire_payment.hID_fk= Hire.cusID_FK where H_start_date_time between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and H_end_date_time  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and vID_FK = '" + vIDBox.Text + "'");
                if (dt.Rows.Count > 0)
                {

                    loadTable.DataSource = dt;
                }
                else
                {
                    DataTable rDt = A.getData("select RP_basic_Charge from Rent_payment join Rent on Rent_payment.reID_FK= Rent.cusID_FK where Re_Start_Date  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and Re_End_Date  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and vID_FK = '" + vIDBox.Text + "'");
                    if (rDt.Rows.Count > 0)
                    {

                        loadTable.DataSource = rDt;
                    }
                    else
                    {
                        loadTable.DataSource = null;
                        MessageBox.Show("this selected Vehicle is available from " + sdateTimePicker.Text + " to " + edateTimePicker.Text);
                    }
                }

            }
            else
            {
                MessageBox.Show("Enter The Vehicle ID ");
            }
        
        }

        private void vehicleincome_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
