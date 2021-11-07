using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AyuboDriveFinal
{
    public partial class AvailableVehicles : Form
    {
        public AvailableVehicles()
        {
            InitializeComponent();
        }

        CommonClass A = new CommonClass();

        private void findBtn_Click(object sender, EventArgs e)
        {

            if(vIDBox.Text !="")
            {

                vehicleIdText.Text = vIDBox.Text;
                sDateText.Text = sDateTimePicker.Text;
                eDateText.Text = eDateTimePicker.Text;



                // check from hire table
                DataTable dt = A.getData("select *from Hire where H_start_date_time between '"+sDateTimePicker.Text+"' and '"+eDateTimePicker.Text+"' and H_end_date_time  between '"+sDateTimePicker.Text+"' and '"+eDateTimePicker.Text+"' and vID_FK = '"+vIDBox.Text+"'");
                if( dt.Rows.Count > 0 )
                {
                    bookingTypeText.Text = "Hire";
                    loadTable.DataSource = dt;
                }
                else
                {
                    DataTable rDt = A.getData("select *from Rent where Re_Start_Date  between '"+sDateTimePicker.Text+"' and '"+eDateTimePicker.Text+"' and Re_End_Date  between '"+sDateTimePicker.Text+"' and '"+eDateTimePicker.Text+"' and vID_FK = '"+vIDBox.Text+"'");
                    if( rDt.Rows.Count > 0 )
                    {
                        bookingTypeText.Text = "Rent";
                        loadTable.DataSource = rDt;
                    }
                    else
                    {
                        loadTable.DataSource = null;
                        MessageBox.Show("this selected Vehicle is available from "+ sDateTimePicker.Text +" to "+ eDateTimePicker.Text );
                    }
                }

                
                
            }
            else
            {
                MessageBox.Show("Enter The Vehicle ID ");
            }
            
        }


        private void AvailableVehicles_Load(object sender, EventArgs e)
        {
            A.convertDateTimeFormate(sDateTimePicker);
            A.convertDateTimeFormate(eDateTimePicker);

            
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
