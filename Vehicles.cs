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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {

            //get insert values from text box into variable
            string _name = nameBox.Text;
            string _VTID = VTIDComBox.SelectedValue.ToString();

            //validate data to insert into table
            if (_name != "" && _VTID != "")
            {
                A.insertData("insert into Vehicles (V_no,vType_FK) values ('" + _name + "', '" + _VTID + "')");
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
            string _VTID = VTIDComBox.SelectedValue.ToString();
            string _id = idBox.Text;


            //validate data to update into table
            if (_name != "" && _VTID != "")
            {
                A.updateData("update Vehicles set  V_no='" + _name + "', vType_FK='" + _VTID + "' where V_ID='" + _id + "' ");
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
                A.deleteData("Delete Vehicles where V_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            loadTableFun();
            loadVehicleTypeComboBoxFun();
        }
        

        // get vehicles type 
        private void loadVehicleTypeComboBoxFun()
        {

            VTIDComBox.DataSource = A.getData("select VT_ID as ID, VT_name as [Vehicle type Name] from VehiclesType  ");
            VTIDComBox.DisplayMember = "Vehicle type Name";
            VTIDComBox.ValueMember = "ID";
        }


        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select V_ID as [ID], V_no as [Vehicle No] , VehiclesType.VT_name as [Vehicles Type Name] from Vehicles inner join VehiclesType on Vehicles.vType_FK = VehiclesType.VT_ID");
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getVehicleDataByID(idBox.Text);


                nameBox.Text = dt.Rows[0]["V_no"].ToString();
                VTIDComBox.SelectedValue = dt.Rows[0]["vType_FK"].ToString();

            }
        }


        // get vehicle data by id
        private  DataTable getVehicleDataByID( string _id )
        {
            return A.getData("select *from Vehicles where V_ID = '"+ _id +"' " );
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            nameBox.Text = "";
            VTIDComBox.SelectedIndex = 0;
 
        }
        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }


        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
