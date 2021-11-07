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
    public partial class VehicleType : Form
    {
        public VehicleType()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {

            //get insert values from text box into variable
            string _name = nameBox.Text;


            //validate data to insert into table
            if (_name != "")
            {
                A.insertData("insert into VehiclesType (VT_name) values ('" + _name + "')");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _name = nameBox.Text;
            string _id = idBox.Text;


            //validate data to update into table
            if (_name != "")
            {
                A.updateData("update VehiclesType set  VT_name='" + _name + "' where VT_ID='" + _id + "' ");
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
            if (_id != "")
            {
                A.deleteData("Delete VehiclesType where VT_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void VehicleType_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select VT_ID as ID, VT_name as [Vehicle type Name] from VehiclesType  ");
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getVehicleTypeByID(idBox.Text);

                nameBox.Text = dt.Rows[0]["VT_name"].ToString();
                
            }
        }

        // get vehicle Type data by id
        private DataTable getVehicleTypeByID(string _id)
        {
            return A.getData("select *from VehiclesType where VT_ID = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            nameBox.Text = "";

        }
        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }

        private void loadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
