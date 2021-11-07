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
    public partial class bookdcusbyrentID : Form
    {
        public bookdcusbyrentID()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void bookdcusbyrentID_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sdateTimePicker);
            A.convertDateTimeFormate(edateTimePicker);
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            if (rIDBox.Text != "")
            {

                rentIdText.Text = rIDBox.Text;
                sDateText.Text = sdateTimePicker.Text;
                eDateText.Text = edateTimePicker.Text;


                // check from hire table
                DataTable dt = A.getData("select *from Rent where Re_start_date between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and Re_end_date  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and Re_ID = '" + rIDBox.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    loadTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Enter The Rent ID ");
                }
            }
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
