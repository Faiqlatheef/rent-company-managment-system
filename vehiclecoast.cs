using System;
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
    public partial class vehiclecoast : Form
    {
        public vehiclecoast()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void vehiclecoast_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            if (pIDBox.Text != "")
            {

                pattyIdText.Text = pattyIdText.Text;
                sDateText.Text = sdateTimePicker.Text;
                eDateText.Text = edateTimePicker.Text;


                // check from hire table
                DataTable dt = A.getData("select Vehicle_wash,Vehicle_service from pattycash where Patty_date '" + sdateTimePicker.Text + "' and Patty_date '" + edateTimePicker.Text + "' and patty_ID = '" + pIDBox.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    loadTable.DataSource = dt;
                }

                else
                {
                    MessageBox.Show("Enter The Patty cash ID ");
                }
            }
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
