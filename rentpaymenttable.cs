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
    public partial class rentpaymenttable : Form
    {
        public rentpaymenttable()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void rentpaymenttable_Load(object sender, EventArgs e)
        {
            loadTable.DataSource = A.getData("select RP_ID as ID, RP_basic_Charge as [Rent payment basic charge], RP_Date as [Rent payment date], RP_driver_charge as [Driver charge] from Rent_Payment inner join Rent on Rent_Payment.reID_FK = Rent.Re_ID");
        
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
