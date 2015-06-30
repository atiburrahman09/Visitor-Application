using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorCountApp.UI;

namespace VisitorCountApp
{
    public partial class MainMenuUI : Form
    {
        public MainMenuUI()
        {
            InitializeComponent();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI visitorEntryUI = new VisitorEntryUI();
            visitorEntryUI.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryUI zoneTypeEntryUI = new ZoneTypeEntryUI();
            zoneTypeEntryUI.Show();
        }

        private void zoneSpecificVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorInformationReportUI zoneSpecificVisitorInformationReportUI = new ZoneSpecificVisitorInformationReportUI();
            zoneSpecificVisitorInformationReportUI.Show();
        }

        private void zoneSpecificVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeWiseVisitorsNumberReportUI zoneTypeWiseVisitorsNumberReportUI = new ZoneTypeWiseVisitorsNumberReportUI();
            zoneTypeWiseVisitorsNumberReportUI.Show();
        }

       


       
    }
}
