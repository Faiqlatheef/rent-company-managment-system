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
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _RID = RIDComBox.SelectedValue.ToString();
            string _HID = HIDComBox.SelectedValue.ToString();
            string _PID = PIDComBox.SelectedValue.ToString();
            string _CashID = idbox.Text;
            string _cashdate = cashdateTime.Text;

            //validate data to update into table
            if (_RID != "" && _HID != "" && _PID != "" && _cashdate != "")
            {
                A.updateData("update Cash set  rent_id_FK='" + _RID + "', hire_id_FK='" + _HID + "', petty_id_FK='" + _PID + "', Cash_date='" + _cashdate + "' where Cash_ID='" + _CashID + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _RID = RIDComBox.SelectedValue.ToString();
            string _HID = HIDComBox.SelectedValue.ToString();
            string _PID = PIDComBox.SelectedValue.ToString();
            string _cashdate = cashdateTime.Text;


            //validate data to insert into table
            if (_RID != "" && _HID != "" && _PID != "" && _cashdate != "")
            {
                A.insertData("insert into Cash (rent_id_FK,hire_id_FK,petty_id_FK,Cash_date) values ('" + _RID + "', '" + _HID + "', '" + _PID + "', '" + _cashdate + "')");
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
            A.convertDateTimeFormate(cashdateTime);
        }
        private void Cash_Load(object sender, EventArgs e)
        {
            loadTableFun();
            loadRentComboBoxFun();
            loadPattycashComboBoxFun();
            loadHireComboBoxFun();
            changeDateformat();
        }

        // get Rent 
        private void loadRentComboBoxFun()
        {

            RIDComBox.DataSource = A.getData("select Re_ID as ID, Re_Days as [Rent Days], Re_Book_Date as [Rent Book Date], Re_Start_Date as [Rent Start Date] , Re_End_Date as [Rent End Date],vID_FK as [Vehicle ID], dID_FK as [Driver ID], cusID_FK as [Customer ID] from Rent ");
            RIDComBox.DisplayMember = "Rent ID";
            RIDComBox.ValueMember = "ID";
        }

        // get Patty cash 
        private void loadPattycashComboBoxFun()
        {

            PIDComBox.DataSource = A.getData("select patty_ID as ID, Vehicle_wash as [Vehicle wash], Vehicle_service as [Vehicle service], petrol_deisel_pay as [Petrol Deisel pay] from pattycash  ");
            PIDComBox.DisplayMember = "Patty ID";
            PIDComBox.ValueMember = "ID";
        }

        // get Rent 
        private void loadHireComboBoxFun()
        {

            HIDComBox.DataSource = A.getData("select H_ID as ID, minKm as [minimum KM], maxKm as [maximum KM], h_waiting_charge_free_hours as [Hire waiting charge fee hours] , h_waiting_charge_fee as [Hire waiting charge fee],H_date_time as [Hire date time], H_start_date_time as [Hire start date time], H_end_date_time as[Hire end date time],hpID_FK as [ Hire packages ID],vID_FK as [Vehicle ID],dID_fk as[Driver ID],cusID_FK as[Customer ID] from Hire  ");
            HIDComBox.DisplayMember = "Hire ID";
            HIDComBox.ValueMember = "ID";
        }

        // this function for load table
        private void loadTableFun()
        {
            loadtable.DataSource = A.getData("select Cash_ID as ID, rent_id_FK as [Rent ID], hire_id_FK as [Hire ID], petty_id_FK as [Patty ID],Cash_date as Date from Cash  ");
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _CashID = idbox.Text;

            //validate data to delete into table
            if (_CashID != "")
            {
                A.deleteData("Delete Cash where Cash_ID='" + _CashID + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void loadtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idbox.Text = loadtable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getCashDataByID(idbox.Text);

                RIDComBox.SelectedValue = dt.Rows[0]["rent_id_FK"].ToString();
                HIDComBox.SelectedValue = dt.Rows[0]["hire_id_FK"].ToString();
                PIDComBox.SelectedValue = dt.Rows[0]["petty_id_FK"].ToString();
                cashdateTime.Text = dt.Rows[0]["Date"].ToString();

            }
        }

        // get vehicle data by id
        private DataTable getCashDataByID(string _id)
        {
            return A.getData("select *from Cash where Cash_ID = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idbox.Text = "";
            RIDComBox.SelectedIndex = 0;
            HIDComBox.SelectedIndex = 0;
            PIDComBox.SelectedIndex = 0;
            cashdateTime.Text = "";
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
