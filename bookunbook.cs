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
    public partial class bookunbook : Form
    {
        public bookunbook()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void findbtn_Click(object sender, EventArgs e)
        {
            if (dIDBox.Text != "")
            {

                driverIdText.Text = dIDBox.Text;
                sDateText.Text = sdateTimePicker.Text;
                eDateText.Text = edateTimePicker.Text;



                // check from hire table
                DataTable dt = A.getData("select *from Hire where H_start_date_time between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and H_end_date_time  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and dID_FK = '" + dIDBox.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    
                    loadTable.DataSource = dt;
                }
                else
                {
                    DataTable rDt = A.getData("select *from Rent where Re_Start_Date  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and Re_End_Date  between '" + sdateTimePicker.Text + "' and '" + edateTimePicker.Text + "' and dID_FK = '" + dIDBox.Text + "'");
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
                MessageBox.Show("Enter The Driver ID ");
            }
        }

        private void bookunbook_Load(object sender, EventArgs e)
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
