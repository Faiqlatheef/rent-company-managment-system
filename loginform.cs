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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void updbtn_Click(object sender, EventArgs e)
        {
            if(passBox.Text == conpassBox.Text)
            {
                //get insert values from text box into variable
                string _UID = idBox.Text;
                string _pID = passBox.Text;
                string _cpID = conpassBox.Text;

                //validate data to insert into table
                if (_UID != "" && _pID != "" && _cpID != "" )
                {
                    A.updateData("update A_login set  A_password='" + _pID + "' where A_ID='" + _UID + "' ");
                    loadTableFun();
                    this.ClearDatafun();
                }
                else
                {
                    MessageBox.Show(A.message_emptyBox());
                }
            }
            else
            {
                MessageBox.Show("Miss Match Passowrd....");
            }
        }

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select A_ID as ID from A_login  ");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            passBox.Text = "";
            conpassBox.Text = "";
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            ClearDatafun();
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getCashDataByID(idBox.Text);
                passBox.Text = dt.Rows[0]["A_password"].ToString();
                conpassBox.Text = dt.Rows[0]["A_password"].ToString();

            }
        }

        // get vehicle data by id
        private DataTable getCashDataByID(string _id)
        {
            return A.getData("select *from A_login  where A_ID = '" + _id + "' ");
        }
    }
}
