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
    public partial class Hire_packages : Form
    {
        public Hire_packages()
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
                A.insertData("insert into Hire_packages (HP_name) values ('" + _name + "')");
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
            string _id = idBox.Text;

            //validate data to update into table
            if (_name != "")
            {
                A.updateData("update Hire_packages set  HP_name='" + _name + "' where HP_ID='" + _id + "' ");
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
                A.deleteData("Delete Hire_packages where HP_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void Hire_packages_Load(object sender, EventArgs e)
        {
            loadTableFun();
        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select HP_ID as ID, HP_name as Name from Hire_packages");
        }
        
        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                DataTable dt = getHirePackagesByID(idBox.Text);

                nameBox.Text = dt.Rows[0]["HP_name"].ToString();

            }
        }

        // get Hire Packages by id
        private DataTable getHirePackagesByID(string _id)
        {
            return A.getData("select *from Hire_packages where HP_ID = '" + _id + "' ");
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

        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
