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
using System.Data;

namespace AyuboDriveFinal
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select C_ID as ID, C_Name as Name, C_Address as Address, C_Tel_no as [Phone number] from Customer");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            nameBox.Text = "";
            telnoBox.Text = "";
            addBox.Text = "";
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _name = nameBox.Text;
            string _add = addBox.Text;
            string _telno = telnoBox.Text;

            //validate data to insert into table
            if (_name != "" && _add != "" && _telno != "")
            {
                A.insertData("insert into Customer (C_name, C_Address,C_Tel_no) values ('" + _name + "', '" + _add + "' , '" + _telno + "')");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void Updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _name = nameBox.Text;
            string _add = addBox.Text;
            string _telno = telnoBox.Text;
            string _id = idBox.Text;

            //validate data to update into table
            if (_name != "" && _add != "" && _telno != "")
            {
                A.updateData("update Customer set  C_name='" + _name + "', C_Address='" + _add + "', C_Tel_no='" + _telno + "' where C_ID='"+_id+"' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void Dltbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;

            //validate data to delete into table
            if (_id != "" )
            {
                A.deleteData("Delete Customer where C_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getCustomerByID(idBox.Text);

                nameBox.Text = dt.Rows[0]["C_name"].ToString();
                addBox.Text = dt.Rows[0]["C_Address"].ToString();
                telnoBox.Text = dt.Rows[0]["C_Tel_no"].ToString();
            }
        }

        // get Customer data by id
        private DataTable getCustomerByID(string _id)
        {
            return A.getData("select *from Customer where C_ID = '" + _id + "' ");
        }

        private void loadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            string _srch = srchBox.Text;

            loadTable.DataSource = A.getData("select * from Customer where C_ID='" + _srch + "'  ");
        }

    }
}
