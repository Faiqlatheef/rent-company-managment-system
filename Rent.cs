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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable

            string _rd = rdBox.Text;
            string _rb = rbddateTime.Text;
            string _rs = rsddateTime.Text;
            string _re = reddateTime.Text;
            string _VID = VIDComBox.SelectedValue.ToString();
            string _DID = DIDComBox.SelectedValue.ToString();
            string _CID = CIDComBox.SelectedValue.ToString();
           

            //validate data to insert into table
            if (_rd != "" && _rb != "" && _rs != "" && _re != "" && _VID != "" && _DID != "" && _CID != "")
            {
                A.insertData("insert into Rent (Re_Days,Re_Book_Date,Re_Start_Date,Re_End_Date,vID_FK,dID_FK,cusID_FK) values ('" + _rd + "', '" + _rb + "', '" + _rs + "', '" + _re + "', '" + _VID + "', '" + _DID + "', '" + _CID + "')");
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
            string _rd = rdBox.Text;
            string _rb = rbddateTime.Text;
            string _rs = rsddateTime.Text;
            string _re = reddateTime.Text;
            string _VID = VIDComBox.SelectedValue.ToString();
            string _DID = DIDComBox.SelectedValue.ToString();
            string _CID = CIDComBox.SelectedValue.ToString();
            string _id = idBox.Text;

            //validate data to update into table
            if (_rd != "" && _rb != "" && _rs != "" && _re != "" && _VID != "" && _DID != "" && _CID != "")
            {
                A.updateData("update Rent set  Re_Days='" + _rd + "', Re_Book_Date='" + _rb + "', Re_Start_Date='" + _rs + "', Re_End_Date='" + _re + "', vID_FK='" + _VID + "', dID_FK='" + _DID + "', cusID_FK='" + _CID + "' where Re_ID='" + _id + "' ");
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
                A.deleteData("Delete Rent where Re_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void changeDateformat()
        {
            A.convertDateTimeFormate(rbddateTime);
            A.convertDateTimeFormate(rsddateTime);
            A.convertDateTimeFormate(reddateTime);
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            loadTableFun();
            loadRentVComboBoxFun();
            loadRentDComboBoxFun();
            loadRentCComboBoxFun();
            changeDateformat();
            

        }

        // get vehicles 
        private void loadRentVComboBoxFun()
        {

            VIDComBox.DataSource = A.getData("select V_ID as [ID], V_no as [Vehicle No] , vType_FK as [VehiclesType] from Vehicles ");
            VIDComBox.DisplayMember = "ID";
            VIDComBox.ValueMember = "ID";
        }

        // get Driver 
        private void loadRentDComboBoxFun()
        {

            DIDComBox.DataSource = A.getData("select D_ID as ID, D_Name as Name, D_Address as Address, D_Tel_no as [Phone number] , D_Lic_no as [Licence number],D_Rate as Rate, D_overnight_rate as [Overnight rate] from Driver ");
            DIDComBox.DisplayMember = "ID";
            DIDComBox.ValueMember = "ID";
        }

        // get Customer 
        private void loadRentCComboBoxFun()
        {

            CIDComBox.DataSource = A.getData("select C_ID as ID, C_Name as Name, C_Address as Address, C_Tel_no as [Phone number] from Customer ");
            CIDComBox.DisplayMember = "ID";
            CIDComBox.ValueMember = "ID";
        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select Re_ID as ID, Re_Days as [Rent Days], Re_Book_Date as [Rent Book Date], Re_Start_Date as [Rent Start Date] , Re_End_Date as [Rent End Date] from Rent inner join Vehicles on Rent.vID_FK = Vehicles.V_ID inner join Driver on Rent.dID_FK = Driver.D_ID inner join Customer on Rent.cusID_FK = Customer.C_ID"  );
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getRentDataByID(idBox.Text);

                rdBox.Text = dt.Rows[0]["Re_Days"].ToString();
                rbddateTime.Text = dt.Rows[0]["Re_Book_Date"].ToString();
                rsddateTime.Text = dt.Rows[0]["Re_Start_Date"].ToString();
                reddateTime.Text = dt.Rows[0]["Re_End_Date"].ToString();
                VIDComBox.SelectedValue = dt.Rows[0]["vID_FK"].ToString();
                DIDComBox.SelectedValue = dt.Rows[0]["dID_FK"].ToString();
                CIDComBox.SelectedValue = dt.Rows[0]["cusID_FK"].ToString();

            }
        }

        // get vehicle data by id
        private DataTable getRentDataByID(string _id)
        {
            return A.getData("select *from Vehicles where V_ID = '" + _id + "' ");
        }
        private void ClearDatafun()
        {
            idBox.Text = "";
            rdBox.Text = "";
            rbddateTime.Text = "";
            rsddateTime.Text = "";
            reddateTime.Text = "";
            VIDComBox.SelectedIndex = 0;
            DIDComBox.SelectedIndex = 0;
            DIDComBox.SelectedIndex = 0;

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
