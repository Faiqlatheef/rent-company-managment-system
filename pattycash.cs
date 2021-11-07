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
    public partial class pattycash : Form
    {
        public pattycash()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable

            string _vwash = vwashBox.Text;
            string _vservice = vserviceBox.Text;
            string _petdeipay = petdeipayBox.Text;
            string _pattydate = pattydateTime.Text;


            //validate data to insert into table
            if (_vwash != "" && _vservice != "" && _petdeipay != "" && _pattydate != "")
            {
                A.insertData("insert into pattycash (Vehicle_wash,Vehicle_service,petrol_deisel_pay,pattydate) values ('" + _vwash + "', '" + _vservice + "', '" + _petdeipay + "', '" + _pattydate + "')");
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
            string _vwash = vwashBox.Text;
            string _vservice = vserviceBox.Text;
            string _petdeipay = petdeipayBox.Text;
            string _id = idBox.Text;
            string _pattydate = pattydateTime.Text;

            //validate data to update into table
            if (_vwash != "" && _vservice != "" && _petdeipay != "" && _pattydate != "")
            {
                A.updateData("update pattycash set  Vehicle_wash='" + _vwash + "', Vehicle_service='" + _vservice + "', petrol_deisel_pay='" + _petdeipay + "' , pattydate= '" + _pattydate + "' where patty_ID='" + _id + "' ");
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
                A.deleteData("Delete pattycash where patty_ID='" + _id + "' ");
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
            A.convertDateTimeFormate(pattydateTime);
        }

        private void pattycash_Load(object sender, EventArgs e)
        {
            loadTableFun();
            changeDateformat();
        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select patty_ID as ID, Vehicle_wash as [Vehicle wash], Vehicle_service as [Vehicle service], petrol_deisel_pay as [Petrol Deisel pay], Patty_date as Date from pattycash  ");
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getpattycashByID(idBox.Text);

                vwashBox.Text = dt.Rows[0]["Vehicle_wash"].ToString();
                vserviceBox.Text = dt.Rows[0]["Vehicle_service"].ToString();
                petdeipayBox.Text = dt.Rows[0]["petrol_deisel_pay"].ToString();
                pattydateTime.Text = dt.Rows[0]["Date"].ToString();

            }
        }

        // get pattycash data by id
        private DataTable getpattycashByID(string _id)
        {
            return A.getData("select *from pattycash where patty_ID = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            vwashBox.Text = "";
            vserviceBox.Text = "";
            petdeipayBox.Text = "";
            pattydateTime.Text = "";

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
