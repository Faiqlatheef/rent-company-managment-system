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
    public partial class topdriver : Form
    {
        public topdriver()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void topdriver_Load(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeComboBox.Text == "Hire")
            {
                IdText.Text = typeComboBox.Text;

                DataTable dt = A.getData("select top 10 dID_fk as [Driver ID],Count(*) as NumberOfHire, Driver.D_Name as [Driver Name], Driver.D_Tel_no as [Telephone Number], Driver.D_Rate as Rate from Hire join Driver on Hire.dID_fk=Driver.D_ID group by dID_fk,D_Name,D_Tel_no,D_Rate order by NumberOfHire Desc");
                loadTable.DataSource = dt;
            }
            else
            {
                IdText.Text = typeComboBox.Text;
                DataTable dt = A.getData("select top 10 dID_fk as [Driver ID],Count(*) as NumberOfHire, Driver.D_Name as [Driver Name], Driver.D_Tel_no as [Telephone Number], Driver.D_Rate as Rate from Rent join Driver on Rent.dID_fk=Driver.D_ID group by dID_fk,D_Name,D_Tel_no,D_Rate order by NumberOfHire Desc");
                loadTable.DataSource = dt;
            }
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
