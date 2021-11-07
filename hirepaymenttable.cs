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
    public partial class hirepaymenttable : Form
    {
        public hirepaymenttable()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void loadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
        }

        private void hirepaymenttable_Load(object sender, EventArgs e)
        {
            loadTable.DataSource = A.getData("select HP_ID as ID, HP_Basic_Charge as [Basic Charge], HP_Waiting_Charge as [Waiting Charge], Pay_for_ExtraKm as [Pay for extra KM] , Pay_for_overnight_stay as [Pay for overnight stay],HP_Date as [Hire payment date], hID_fk as [Hire ID] from Hire_payment  ");
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
