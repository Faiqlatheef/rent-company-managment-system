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
    public partial class bookdcusbyhireID : Form
    {
        public bookdcusbyhireID()
        {
            InitializeComponent();
        }

        CommonClass A = new CommonClass();
        private void findbtn_Click(object sender, EventArgs e)
        {
            if (hIDBox.Text != "")
            {

                hireIdText.Text = hIDBox.Text;
                sDateText.Text = sdateTimePicker.Text;
                eDateText.Text = edateTimePicker.Text;


                // check from hire table
                DataTable dt = A.getData("select *from Hire where H_start_date_time between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and H_end_date_time  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and Re_ID = '" + hIDBox.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    loadTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Enter The Hire ID ");
                }
            }
        }

        private void bookdcusbyhireID_Load(object sender, EventArgs e)
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
