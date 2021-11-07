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
    public partial class HirePayment : Form
    {
        // for calculation function
        double _Days = 0;
        double _overNight = 0;

        public HirePayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            string _hpbc = hpbcBox.Text;
            string _hpwc = hpwcBox.Text;
            string _pfekm = pfekmBox.Text;
            string _pfons = pfonsBox.Text;
            string _hpdate = hpdateTime.Text;
            string _HID = HIDComBox.SelectedValue.ToString();
            string _id = idBox.Text;

            //validate data to update into table
            if (_hpbc != "" && _hpwc != "" && _pfekm != "" && _pfons != "" && _hpdate != "" && _HID != "")
            {
                A.updateData("update Hire_payment set  HP_Basic_Charge='" + _hpbc + "', HP_Waiting_Charge='" + _hpwc + "', Pay_for_ExtraKm='" + _pfekm + "', Pay_for_overnight_stay='" + _pfons + "', HP_Date='" + _hpdate + "' , hID_fk='" + _HID + "' where HP_ID='" + _id + "' ");
               
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
                A.deleteData("Delete Hire_payment where HP_ID='" + _id + "' ");
                
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void changeDateformat()
        {
            A.convertDateTimeFormate(hpdateTime);
        }

        private void HirePayment_Load(object sender, EventArgs e)
        {
           
            loadHTypeComboBoxFun();
            changeDateformat();
        }

        // get vehicles type 
        private void loadHTypeComboBoxFun()
        {
            HIDComBox.DisplayMember = "ID";
            HIDComBox.ValueMember = "ID";
            HIDComBox.DataSource = A.getData("select H_ID as ID, minKm as [minimum KM], maxKm as [maximum KM], h_waiting_charge_free_hours as [Hire waiting charge fee hours] , h_waiting_charge_fee as [Hire waiting charge fee],H_date_time as [Hire date time], H_start_date_time as [Hire start date time], H_end_date_time as[Hire end date time],hpID_FK as [ Hire packages ID],vID_FK as [Vehicle ID],dID_fk as[Driver ID],cusID_FK as[Customer ID] from Hire  ");
            
        }

        

        private void loadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                DataTable dt = getHirePaymentDataByID(idBox.Text);
                idBox.Text = dt.Rows[0]["ID"].ToString();
                
                hpbcBox.Text = dt.Rows[0]["HP_Basic_Charge"].ToString();
                hpwcBox.Text = dt.Rows[0]["HP_Waiting_Charge"].ToString();
                pfekmBox.Text = dt.Rows[0]["Pay_for_ExtraKm"].ToString();
                pfonsBox.Text = dt.Rows[0]["Pay_for_overnight_stay"].ToString();
                hpdateTime.Text = dt.Rows[0]["HP_Date"].ToString();
                HIDComBox.SelectedValue = dt.Rows[0]["hID_fk"].ToString();
                
            }
        }

        // get Hire payment data by id
        private DataTable getHirePaymentDataByID(string _id)
        {
            return A.getData("select *from Hire_payment where HP_ID = '" + _id + "' ");
        }
        private void ClearDatafun()
        {
            idBox.Text = "";
            hpbcBox.Text = "";
            hpwcBox.Text = "";
            pfekmBox.Text = "";
            pfonsBox.Text = "";
            hpdateTime.Text = "";
            HIDComBox.SelectedIndex = 0 ;
            
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

        private void HIDComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hireID = HIDComBox.SelectedValue.ToString();

            DataTable dt = A.getData("select minKm as [minimum KM], maxKm as [maximum KM], h_waiting_charge_free_hours as [Hire waiting charge fee hours], h_waiting_charge_fee as [Hire waiting charge fee], CAST( H_date_time as date ) as [Hire date time], CAST( H_start_date_time as date ) as [Hire start date time], CAST( H_end_date_time as date )  as [Hire end date time],DATEDIFF(day , H_end_date_time, H_start_date_time ) as [Days]," +
                            "Customer.C_ID as [Customer ID], Customer.C_name as [Customer Name], Customer.C_Tel_no as [Customer Tel]," +
                            "Driver.D_ID as [Driver ID] , Driver.D_Name as [Driver Name], Driver.D_overnight_rate as [Over Night]," +
                            "Vehicles.V_ID as [Vehicles ID], Vehicles.V_no as [Vehicles NO]," +
                            "VehiclesType.VT_name as [Vehicles Type]," +
                            "Hire_packages.HP_ID as [Hire Package ID]" +
                            " from Hire " +
                            " join Customer on Customer.C_ID = Hire.cusID_FK" +
                            " join Driver on Driver.D_ID = Hire.dID_FK" +
                            " join Vehicles on Vehicles.V_ID = Hire.vID_FK" +
                            " join VehiclesType on Vehicles.vType_FK = VehiclesType.VT_ID" +
                            " join Hire_packages on Hire_packages.HP_ID = Hire.hpID_FK " + 
                            " where Hire.H_ID = '" + hireID + "' ");

            // assign data to label
            minKMtext.Text = dt.Rows[0]["minimum KM"].ToString();
            maxKMtext.Text = dt.Rows[0]["maximum KM"].ToString();
            hwchtext.Text = dt.Rows[0]["Hire waiting charge fee hours"].ToString();
            hwcftext.Text = dt.Rows[0]["Hire waiting charge fee"].ToString();
            hiredateText.Text = dt.Rows[0]["Hire date time"].ToString();
            hirestartingText.Text = dt.Rows[0]["Hire start date time"].ToString();
            hireendText.Text = dt.Rows[0]["Hire end date time"].ToString();


            vehiclesIDText.Text = dt.Rows[0]["Vehicles ID"].ToString();
            vehiclesNumberText.Text = dt.Rows[0]["Vehicles NO"].ToString();
            vehiclesTypeText.Text = dt.Rows[0]["Vehicles Type"].ToString();


            driverIDText.Text = dt.Rows[0]["Driver ID"].ToString();
            driverNameText.Text = dt.Rows[0]["Driver Name"].ToString();


            cutomerIDText.Text = dt.Rows[0]["Customer ID"].ToString();
            customerNameText.Text = dt.Rows[0]["Customer Name"].ToString();
            customerTelText.Text = dt.Rows[0]["Customer Tel"].ToString();

            hirepackageText.Text = dt.Rows[0]["Hire Package ID"].ToString();

            this._Days = Convert.ToDouble(dt.Rows[0]["Days"].ToString());
            this._overNight = Convert.ToDouble(dt.Rows[0]["Over Night"].ToString());


        }

        private void calculateAmountFun()
        {
            double hours = (Convert.ToDouble(_Days)+1) * 24;

            int extrahour = Convert.ToInt32(pfekmBox.Text);
            //int overnight = Convert.ToInt32(pfonsBox.Text);
            double daystemp = hours;
            double amount = 0;

            if (this._Days > 2)
            {
                // get number of extra hours
                double numberOfhours = this._Days;

                // add charge for number of hours
                amount += numberOfhours * 250 + extrahour + this._overNight;
                // reduce days from calculate hours
                hours -= numberOfhours * 24;
            }

            // week calculation
            if (this._Days < 2)
            {
                // get number of week
                double numberOfhours = this._Days;
                // add charge for number of week
                amount += numberOfhours * 250;
                // reduce days from calculate week
                hours -= numberOfhours * 24;
            }



            // show amount
            hpbcBox.Text = amount.ToString();
            //get rate from Database by ID
            DataTable dt = A.getData("select h_waiting_charge_fee from Hire where  H_ID = '" + HIDComBox.SelectedValue + "'");
            DataTable ons = A.getData("select *from Driver where D_ID = '" + driverIDText.Text + "'");

            double rate = Convert.ToDouble(dt.Rows[0]["h_waiting_charge_fee"].ToString());
            double onrate = Convert.ToDouble(ons.Rows[0]["D_overnight_rate"].ToString());
            double xtrapay = Convert.ToDouble(extrahour);

            // extra fee
            hpwcBox.Text = rate.ToString();
            pfonsBox.Text = onrate.ToString();

            //Driver charge calculation
            hpbcBox.Text = Convert.ToString((daystemp * rate) + onrate + xtrapay);


        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable

            string _hpbc = hpbcBox.Text;
            string _hpwc = hpwcBox.Text;
            string _pfekm = pfekmBox.Text;
            string _pfons = pfonsBox.Text;
            string _hpdate = hpdateTime.Text;
            string _HID = HIDComBox.SelectedValue.ToString();

            //validate data to insert into table
            if (_hpbc != "" && _hpwc != "" && _pfekm != "" && _pfons != "" && _hpdate != "" && _HID != "")
            {
                A.insertData("insert into Hire_payment (HP_Basic_Charge,HP_Waiting_Charge,Pay_for_ExtraKm,Pay_for_overnight_stay,HP_Date,hID_fk) values ('" + _hpbc + "', '" + _hpwc + "', '" + _pfekm + "', '" + _pfons + "', '" + _hpdate + "', '" + _HID + "' )");

                billDisplayBox.AppendText("Hire Payment" +
                    Environment.NewLine +
                    " ------------------------------ " + 
                    Environment.NewLine + " Extra KM : " + _pfekm +
                    Environment.NewLine + " Waiting Charge : " + _hpwc +
                    Environment.NewLine + " Over night Stay  : " + _pfons + 
                    Environment.NewLine + 
                    " -------------------------- "+ 
                    Environment.NewLine+" Total :" + _hpbc);

                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void vwbtn_Click(object sender, EventArgs e)
        {
            hirepaymenttable fm = new hirepaymenttable();
            fm.Show();
            
        }

        private void minKMtext_Click(object sender, EventArgs e)
        {

        }

        private void prntbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(billDisplayBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 100));
        }
        
    }
}
