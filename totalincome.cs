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
    public partial class totalincome : Form
    {
        public totalincome()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void totalincome_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sdateTimePicker.Text != "" && edateTimePicker.Text != "")
            {
                sDateText.Text = sdateTimePicker.Text;
                eDateText.Text = edateTimePicker.Text;

                // check from hire payment table
                DataTable dt = A.getData("select HP_Basic_Charge from Hire_payment where HP_Date '" + sdateTimePicker.Text + "' and HP_Date '" + edateTimePicker.Text + "' ");
                if (dt.Rows.Count > 0)
                {
                    loadTable.DataSource = dt;
                }

                DataTable rDt = A.getData("select RP_basic_Charge from Rent_Payment where RP_Date '" + sdateTimePicker.Text + "' and RP_Date '" + edateTimePicker.Text + "' ");
                if (rDt.Rows.Count > 0)
                {
                    loadTable.DataSource = rDt;
                }

            }
            else
            {
                MessageBox.Show("Check the Two dates ");
            }
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
