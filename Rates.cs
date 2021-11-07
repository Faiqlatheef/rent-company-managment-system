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
    public partial class Rates : Form
    {
        public Rates()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable

            string _pd = pdBox.Text;
            string _pw = pwBox.Text;
            string _pm = pmBox.Text;
            string _VTID = VTIDComBox.SelectedValue.ToString();


            //validate data to insert into table
            if (_pd != "" && _pw != "" && _pm != "" && _VTID != "")
            {
                A.insertData("insert into Rates (Perday,Perweek,Permonth,vType_FK) values ('" + _pd + "', '" + _pw + "', '" + _pm + "', '" + _VTID + "')");
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
            string _pd = pdBox.Text;
            string _pw = pwBox.Text;
            string _pm = pmBox.Text;
            string _VTID = VTIDComBox.SelectedValue.ToString();
            string _id = idBox.Text;

            //validate data to update into table
            if (_pd != "" && _pw != "" && _pm != "" && _VTID != "")
            {
                A.updateData("update Rates set  Perday='" + _pd + "', Perweek='" + _pw + "', Permonth='" + _pm + "', vType_FK='" + _VTID + "' where Ra_ID='" + _id + "' ");
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
                A.deleteData("Delete Rates where Ra_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void Rates_Load(object sender, EventArgs e)
        {
            loadTableFun();
            loadVTComboBoxFun();
        }

        // get Vehicle Type
        private void loadVTComboBoxFun()
        {

            VTIDComBox.DataSource = A.getData("select VT_ID as ID, VT_name as [Vehicle type Name] from VehiclesType  ");
            VTIDComBox.DisplayMember = "Vehicles Type ID";
            VTIDComBox.ValueMember = "ID";
        }

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select Ra_ID as ID, Perday as PerDay, Perweek as PerWeek, Permonth as [PerMonth] from Rates inner join Hire_packages on Rates.vType_FK = Hire_packages.HP_ID  ");
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getRatesByID(idBox.Text);

                pdBox.Text = dt.Rows[0]["Perday"].ToString();
                pwBox.Text = dt.Rows[0]["Perweek"].ToString();
                pmBox.Text = dt.Rows[0]["Permonth"].ToString();
                VTIDComBox.SelectedValue = dt.Rows[0]["vType_FK"].ToString();

            }
        }

        // get vehicle data by id
        private DataTable getRatesByID(string _id)
        {
            return A.getData("select *from Rates where Ra_ID = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            pdBox.Text = "";
            pwBox.Text = "";
            pmBox.Text = "";
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
    }
}
