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
    public partial class Hire : Form
    {
        public Hire()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            
            string _minkm = minkmBox.Text;
            string _maxkm = maxkmBox.Text;
            string _hwcfh = hwcfhBox.Text;
            string _hwcf = hwcfBox.Text;
            string _hbdate = hbdateTime.Text;
            string _hsdate = hsdateTime.Text;
            string _hedate = hedateTime.Text;
            string _HPID = HPIDComBox.SelectedValue.ToString();
            string _VID = VIDComBox.SelectedValue.ToString();
            string _DID = DIDComBox.SelectedValue.ToString();
            string _CID = CIDComBox.SelectedValue.ToString();


            //validate data to insert into table
            if (_minkm != "" && _maxkm != "" && _hwcfh != "" && _hwcf != "" && _hbdate != "" && _hsdate != "" && _hedate != "" && _HPID != "" && _VID != "" && _DID != "" && _CID != "")
            {
                A.insertData("insert into Hire (minKm,maxKm,h_waiting_charge_free_hours,h_waiting_charge_fee,H_date_time,H_start_date_time,H_end_date_time,hpID_FK,vID_FK,dID_fk,cusID_FK) values ('" + _minkm + "', '" + _maxkm + "', '" + _hwcfh + "', '" + _hwcf + "', '" + _hbdate + "', '" + _hsdate + "', '" + _hedate + "', '" + _HPID + "', '" + _VID + "', '" + _DID + "', '" + _CID + "'  )");
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
            string _minkm = minkmBox.Text;
            string _maxkm = maxkmBox.Text;
            string _hwcfh = hwcfhBox.Text;
            string _hwcf = hwcfBox.Text;
            string _hbdate = hbdateTime.Text;
            string _hsdate = hsdateTime.Text;
            string _hedate = hedateTime.Text;
            string _HPID = HPIDComBox.SelectedValue.ToString();
            string _VID = VIDComBox.SelectedValue.ToString();
            string _DID = DIDComBox.SelectedValue.ToString();
            string _CID = CIDComBox.SelectedValue.ToString();
            string _id = idBox.Text;

            //validate data to update into table
            if (_minkm != "" && _maxkm != "" && _hwcfh != "" && _hwcf != "" && _hbdate != "" && _hsdate != "" && _hedate != "")
            {
                A.updateData("update Hire set  minKm='" + _minkm + "', maxKm='" + _maxkm + "', h_waiting_charge_free_hours='" + _hwcfh + "', h_waiting_charge_fee='" + _hwcf + "', H_date_time='" + _hbdate + "', H_start_date_time='" + _hsdate + "', H_end_date_time='" + _hedate + "', hpID_FK='" + _HPID + "', vID_FK='" + _VID + "', dID_fk='" + _DID + "', cusID_FK='" + _CID + "' where H_ID='" + _id + "'  ");
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
                A.deleteData("Delete Hire where H_ID='" + _id + "' ");
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
            A.convertDateTimeFormate(hbdateTime);
            A.convertDateTimeFormate(hsdateTime);
            A.convertDateTimeFormate(hedateTime);
        }
        
        private void Hire_Load(object sender, EventArgs e)
        {
            loadTableFun();
            loadHPComboBoxFun();
            loadVComboBoxFun();
            loadDComboBoxFun();
            loadCComboBoxFun();
            changeDateformat();
        }

        // get Hire package
        private void loadHPComboBoxFun()
        {

            HPIDComBox.DataSource = A.getData("select HP_ID as ID, HP_name as Name from Hire_packages ");
            HPIDComBox.DisplayMember = "Hire payment ID";
            HPIDComBox.ValueMember = "ID";
        }

        // get vehicles
        private void loadVComboBoxFun()
        {

            VIDComBox.DataSource = A.getData("select V_ID as [ID], V_no as [Vehicle No] , vType_FK as [VehiclesType] from Vehicles ");
            VIDComBox.DisplayMember = "Vehicle ID";
            VIDComBox.ValueMember = "ID";
        }

        // get Driver
        private void loadDComboBoxFun()
        {

            DIDComBox.DataSource = A.getData("select D_ID as ID, D_Name as Name, D_Address as Address, D_Tel_no as [Phone number] , D_Lic_no as [Licence number],D_Rate as Rate, D_overnight_rate as [Overnight rate] from Driver ");
            DIDComBox.DisplayMember = "DriverID";
            DIDComBox.ValueMember = "ID";
        }

        // get Customer
        private void loadCComboBoxFun()
        {

            CIDComBox.DataSource = A.getData("select C_ID as ID, C_Name as Name, C_Address as Address, C_Tel_no as [Phone number] from Customer ");
            CIDComBox.DisplayMember = "Customer ID";
            CIDComBox.ValueMember = "ID";
        }

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select H_ID as ID, minKm as [minimum KM], maxKm as [maximum KM], h_waiting_charge_free_hours as [Hire waiting charge fee hours] , h_waiting_charge_fee as [Hire waiting charge fee],H_date_time as [Hire date time], H_start_date_time as [Hire start date time], H_end_date_time as[Hire end date time] from Hire inner join Hire_packages on Hire.hpID_FK = Hire_packages.HP_ID inner join Vehicles on Hire.vID_FK = Vehicles.V_ID inner join Driver on Hire.dID_fk = Driver.D_ID inner join Customer on Hire.cusID_FK = Customer.C_ID  ");
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getHireDataByID(idBox.Text);

                minkmBox.Text = dt.Rows[0]["minKm"].ToString();
                maxkmBox.Text = dt.Rows[0]["maxKm"].ToString();
                hwcfhBox.Text = dt.Rows[0]["h_waiting_charge_free_hours"].ToString();
                hwcfBox.Text = dt.Rows[0]["h_waiting_charge_fee"].ToString();
                hbdateTime.Text = dt.Rows[0]["H_date_time"].ToString();
                hsdateTime.Text = dt.Rows[0]["H_start_date_time"].ToString();
                hedateTime.Text = dt.Rows[0]["H_end_date_time"].ToString();
                HPIDComBox.SelectedValue = dt.Rows[0]["hpID_FK"].ToString();
                VIDComBox.SelectedValue = dt.Rows[0]["vID_FK"].ToString();
                DIDComBox.SelectedValue = dt.Rows[0]["dID_fk"].ToString();
                CIDComBox.SelectedValue = dt.Rows[0]["cusID_FK"].ToString();
            }
        }
        // get Hire by id
        private DataTable getHireDataByID(string _id)
        {
            return A.getData("select *from Hire where H_ID = '" + _id + "' ");
        }
        private void ClearDatafun()
        {
            idBox.Text = "";
            minkmBox.Text = "";
            maxkmBox.Text = "";
            hwcfhBox.Text = "";
            hwcfBox.Text = "";
            hbdateTime.Text = "";
            hsdateTime.Text = "";
            hedateTime.Text = "";
            HPIDComBox.SelectedIndex = 0;
            VIDComBox.SelectedIndex = 0;
            DIDComBox.SelectedIndex = 0;
            CIDComBox.SelectedIndex = 0;
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
