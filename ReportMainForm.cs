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
    public partial class ReportMainForm : Form
    {
        public ReportMainForm()
        {
            InitializeComponent();
        }

        private void avPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bcfvPanel_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void bcfhPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bcfrPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void borubPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pfcPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tdPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tiPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tcPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tpPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ifvPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pfvPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ReportMainForm_Load(object sender, EventArgs e)
        {

        }

        private void avPanel_Click(object sender, EventArgs e)
        {
            new AvailableVehicles().Show();
            
        }

        private void bcfvPanel_Click(object sender, EventArgs e)
        {
            new bookcusbyvehicleID().Show();
            
        }

        private void bcfhPanel_Click(object sender, EventArgs e)
        {
            new bookdcusbyhireID().Show();
            
        }

        private void bcfrPanel_Click(object sender, EventArgs e)
        {
            new bookdcusbyrentID().Show();
            
        }

        private void borubPanel_Click(object sender, EventArgs e)
        {
            new bookunbook().Show();
            
        }

        private void pfcPanel_Click(object sender, EventArgs e)
        {
            new customerprofit().Show();
            
        }

        private void tdPanel_Click(object sender, EventArgs e)
        {
            new topdriver().Show();
            
        }

        private void tiPanel_Click(object sender, EventArgs e)
        {
            new totalincome().Show();
            
        }

        private void tcPanel_Click(object sender, EventArgs e)
        {
            new totalcoast().Show();
            
        }

        private void tpPanel_Click(object sender, EventArgs e)
        {
            new totalprofit().Show();
            
        }

        private void ifvPanel_Click(object sender, EventArgs e)
        {
            new vehicleincome().Show();
            
        }

        private void pfvPanel_Click(object sender, EventArgs e)
        {
            new vehiclecoast().Show();
            
        }
    }
}
