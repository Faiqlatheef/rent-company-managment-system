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
    public partial class RentPayment : Form
    {
        public RentPayment()
        {
            InitializeComponent();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void Savebtn_Click(object sender, EventArgs e)
        {
            this.calculateAmountFun();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _rbc = rbcBox.Text;
            string _rp = rpdateTime.Text;
            string _rpdc = rpdcBox.Text;
            string _RID = RIDComBox.SelectedValue.ToString();;
            string _id = idBox.Text;

            //validate data to update into table
            if (_rbc != "" && _rp != "" && _rpdc != "" && _RID != "")
            {
                A.updateData("update Rent_Payment set  RP_basic_Charge='" + _rbc + "', RP_Date='" + _rp + "', RP_driver_charge='" + _rpdc + "', reID_FK='" + _RID + "' where RP_ID='" + _id + "' ");
                
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
                A.deleteData("Delete Rent_Payment where RP_ID='" + _id + "' ");
                
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void changeDateformat()
        {
            A.convertDateTimeFormate(rpdateTime);
        }

        private void RentPayment_Load(object sender, EventArgs e)
        {
            
            loadRentComboBoxFun();
            changeDateformat();
        }

        // get vehicles type 
        private void loadRentComboBoxFun()
        {
            RIDComBox.DisplayMember = "ID";
            RIDComBox.ValueMember = "ID";
            RIDComBox.DataSource = A.getData("select Re_ID as ID, Re_Days as [Rent Days], Re_Book_Date as [Rent Book Date], Re_Start_Date as [Rent Start Date] , Re_End_Date as [Rent End Date],vID_FK as [Vehicle ID], dID_FK as [Driver ID], cusID_FK as [Customer ID] from Rent");
            
        }


        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                DataTable dt = getRentPaymentDataByID(idBox.Text);
                idBox.Text = dt.Rows[0]["ID"].ToString();
                rbcBox.Text = dt.Rows[0]["RP_basic_Charge"].ToString();
                rpdateTime.Text = dt.Rows[0]["RP_Date"].ToString();
                rpdcBox.Text = dt.Rows[0]["RP_driver_charge"].ToString();
                RIDComBox.SelectedValue = dt.Rows[0]["reID_FK"].ToString();
                
            }
        }

        // get vehicle data by id
        private DataTable getRentPaymentDataByID(string _id)
        {
            return A.getData("select *from Rent_Payment where RP_ID = '" + _id + "' ");
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            rbcBox.Text = "";
            rpdateTime.Text = "";
            rpdcBox.Text = "";
            RIDComBox.SelectedIndex = 0;

        }
        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }



        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RIDComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string rentID = RIDComBox.SelectedValue.ToString();

            DataTable dt = A.getData("select Re_Days as [Days], Re_Book_Date as [Booking Date], Re_Start_Date as [Starting Date], Re_End_Date as [End Date]," +
                            "Customer.C_ID as [Customer ID], Customer.C_name as [Customer Name], Customer.C_Tel_no as [Customer Tel]," +
                            "Driver.D_ID as [Driver ID] , Driver.D_Name as [Driver Name]," +
                            "Vehicles.V_ID as [Vehicles ID], Vehicles.V_no as [Vehicles NO]," +
                            "VehiclesType.VT_name as [Vehicles Type]" +
                            " from Rent " +
                            " join Customer on Customer.C_ID = Rent.cusID_FK" +
                            " join Driver on Driver.D_ID = Rent.dID_FK" +
                            " join Vehicles on Vehicles.V_ID = Rent.vID_FK" +
                            " join VehiclesType on Vehicles.vType_FK = VehiclesType.VT_ID" +
                            " where Rent.Re_ID = '" + rentID + "' ");

            // assign data to label
            daysText.Text = dt.Rows[0]["Days"].ToString();
            bookingDateText.Text = dt.Rows[0]["Booking Date"].ToString();
            startingDatetext.Text = dt.Rows[0]["Starting Date"].ToString();
            endDateText.Text = dt.Rows[0]["End Date"].ToString();


            vehiclesIDText.Text = dt.Rows[0]["Vehicles ID"].ToString();
            vehiclesNumberText.Text = dt.Rows[0]["Vehicles NO"].ToString();
            vehiclesTypeText.Text = dt.Rows[0]["Vehicles Type"].ToString();


            driverIDText.Text = dt.Rows[0]["Driver ID"].ToString();
            driverNameText.Text = dt.Rows[0]["Driver Name"].ToString();


            cutomerIDText.Text = dt.Rows[0]["Customer ID"].ToString();
            customerNameText.Text = dt.Rows[0]["Customer Name"].ToString();
            customerTelText.Text = dt.Rows[0]["Customer Tel"].ToString();

            calculateAmountFun();

        }


        private void calculateAmountFun()
        {
            int days = Convert.ToInt32(daysText.Text);
            int daystemp = days;
            long amount = 0;

            if( days >= 30 )
            {
                // get number of months
                int numberOfMonths = days / 30;
                // add charge for number of months
                amount += numberOfMonths  * 2800;
                // reduce days from calculate month
                days -= numberOfMonths * 30;
            }

            // week calculation
            if (days >= 7)
            {
                // get number of week
                int numberOfWeeks = days / 7;
                // add charge for number of week
                amount += numberOfWeeks * 6000;
                // reduce days from calculate week
                days -= numberOfWeeks * 7;
            }

            if( days > 0 )
            {
                amount += days * 1000;
            }

            // show amount
            rbcBox.Text = amount.ToString();
            //get Driver rate from Database by ID
            DataTable dt = A.getData("select *from Driver where D_ID = '"+ driverIDText.Text +"'");

            double rate = Convert.ToDouble(dt.Rows[0]["D_Rate"].ToString());
            //Driver charge calculation
            rpdcBox.Text = Convert.ToString(daystemp * rate);


        }

        private void vwbtn_Click(object sender, EventArgs e)
        {
            rentpaymenttable fm = new rentpaymenttable();
            fm.Show();
            
        }

        private void billDisplayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable

            string _rbc = rbcBox.Text;
            string _rp = rpdateTime.Text;
            string _rpdc = rpdcBox.Text;
            string _RID = RIDComBox.SelectedValue.ToString(); ;


            //validate data to insert into table
            if (_rbc != "" && _rp != "" && _rpdc != "" && _RID != "")
            {
                A.insertData("insert into Rent_Payment (RP_basic_Charge,RP_Date,RP_driver_charge,reID_FK) values ('" + _rbc + "', '" + _rp + "' , '" + _rpdc + "' , '" + _RID + "')");
                billDisplayBox.AppendText("Rent Payment" +
                     Environment.NewLine +
                     " ------------------------------ " +
                     Environment.NewLine + " Driver Charge : " + _rpdc +
                     Environment.NewLine +
                     " -------------------------- " +
                     Environment.NewLine + " Total :" + _rbc);
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(billDisplayBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
