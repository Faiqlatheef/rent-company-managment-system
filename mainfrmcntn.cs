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
    public partial class mainfrmcntn : Form
    {
        public mainfrmcntn()
        {
            InitializeComponent();
        }
        CommonClass A = new CommonClass();
        private void mainfrmcntn_Load(object sender, EventArgs e)
        {
            // assign to label
            DataTable hdt = A.getData("select count (*) from Hire");
            thlabel.Text = hdt.Rows[0][0].ToString();

            DataTable rdt = A.getData("select count (*) from Rent");
            trlabel.Text = rdt.Rows[0][0].ToString();

            DataTable ddt = A.getData("select count (*) from Driver");
            tdlabel.Text = ddt.Rows[0][0].ToString();

            DataTable vdt = A.getData("select count (*) from Vehicles");
            tvlabel.Text = vdt.Rows[0][0].ToString();

            //transparent value
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            thlabel.BackColor = System.Drawing.Color.Transparent;
            trlabel.BackColor = System.Drawing.Color.Transparent;
            tdlabel.BackColor = System.Drawing.Color.Transparent;
            tvlabel.BackColor = System.Drawing.Color.Transparent;

            timer1.Start();
        }

        private void timeLabel_Tick(object sender, EventArgs e)
        {
            
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            datelabel.Text = DateTime.Now.ToString("MM dd yyyy");
        }
    }
}
