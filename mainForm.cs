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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        CommonClass A = new CommonClass();
        private void homeLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new mainfrmcntn(), panel3);
        }

        private void driverLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Driver(), panel3);
        }

        private void customerLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Customer(), panel3);
        }

        private void cashLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Cash(), panel3);
        }

        private void hireLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Hire(), panel3);
        }

        private void hirepackageLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Hire_packages(), panel3);
        }

        private void hirepaymentLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new HirePayment(), panel3);
        }

        private void pattycashLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new pattycash(), panel3);
        }

        private void ratesLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Rates(), panel3);
        }

        private void rentLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Rent(), panel3);
        }

        private void rentpaymentLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new RentPayment(), panel3);
        }

        private void vehicleLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new Vehicles(), panel3);
        }

        private void vehicletypeLabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new VehicleType(), panel3);
        }

        private void reportslabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new ReportMainForm(), panel3);
        }

        private void Xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void loginlabel_Click(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new loginform(), panel3);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            A.appsFormLoadInsidePanel(new mainfrmcntn(), panel3);
        }
    }
}
