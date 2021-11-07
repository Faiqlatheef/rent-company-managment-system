using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboDriveFinal
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _name = nameBox.Text;
            string _add = addBox.Text;
            string _tel = telnoBox.Text;
            string _lic = licBox.Text;
            string _rate = rateBox.Text;
            string _onr = onrtextBox.Text;


            //validate data to insert into table
            if (_name != "" && _add != "" && _tel != "" && _lic != "" && _rate != "" && _onr != "")
            {
                A.insertData("insert into Driver (D_Name,D_Address,D_Tel_no,D_Lic_no,D_Rate,D_overnight_rate) values ('" + _name + "', '" + _add + "', '" + _tel + "', '" + _lic + "', '" + _rate + "', '" + _onr + "')");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _name = nameBox.Text;
            string _add = addBox.Text;
            string _tel = telnoBox.Text;
            string _lic = licBox.Text;
            string _rate = rateBox.Text;
            string _onr = onrtextBox.Text;
            string _id = idBox.Text;

            //validate data to update into table
            if (_name != "" && _add != "" && _tel != "" && _lic != "" && _rate != "" && _onr != "")
            {
                A.updateData("update Driver set  D_Name='" + _name + "', D_Address='" + _add + "', D_Tel_no='" + _tel + "', D_Lic_no='" + _lic + "', D_Rate='" + _rate + "', D_overnight_rate='" + _onr + "' where D_ID='"+_id+"' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            

            //validate data to delete into table
            if (_id != "" )
            {
                A.deleteData("Delete Driver where D_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Driver_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select D_ID as ID, D_Name as Name, D_Address as Address, D_Tel_no as [Phone number] , D_Lic_no as [Licence number],D_Rate as Rate, D_overnight_rate as [Overnight rate] from Driver ");
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getDriverByID(idBox.Text);

                nameBox.Text = dt.Rows[0]["D_Name"].ToString();
                addBox.Text = dt.Rows[0]["D_Address"].ToString();
                telnoBox.Text = dt.Rows[0]["D_Tel_no"].ToString();
                licBox.Text = dt.Rows[0]["D_Lic_no"].ToString();
                rateBox.Text = dt.Rows[0]["D_Rate"].ToString();
                onrtextBox.Text = dt.Rows[0]["D_overnight_rate"].ToString();
            }
        }

        // get Driver by id
        private DataTable getDriverByID(string _id)
        {
            return A.getData("select *from Driver where D_ID = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            nameBox.Text = "";
            telnoBox.Text = "";
            addBox.Text = "";
            licBox.Text = "";
            rateBox.Text = "";
            onrtextBox.Text = "";
        }
        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }


        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
