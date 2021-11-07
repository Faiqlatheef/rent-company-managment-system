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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-59OJTCM;Initial Catalog=Ayubo_Drive;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select *from A_login where A_ID = '" + idBox.Text + "' and A_password='" + passBox.Text + "'", con);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                new mainForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void ClearDatafun()
        {
            idBox.Text = "";
            passBox.Text = "";

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            ClearDatafun();
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
        }

    }
}
