using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorCountApp.BLL;
using VisitorCountApp.DAL.Model;

namespace VisitorCountApp.UI
{
    public partial class ZoneTypeWiseVisitorsNumberReportUI : Form
    {
        public ZoneTypeWiseVisitorsNumberReportUI()
        {
            InitializeComponent();
        }

        ZoneManager zoneManager = new ZoneManager();

        public void GetAllZoneWithTotal()
        {
            List<Zone> zoneList = zoneManager.GetAllZone();
            zoneTypeWiseVisitorNumberListView.Items.Clear();
            foreach (var zone in zoneList) {
                ListViewItem items=new ListViewItem();
                items.SubItems.Add(zone.ZoneType);
                items.SubItems.Add(zone.Total.ToString());
                zoneTypeWiseVisitorNumberListView.Items.Add(items);
            }
        }


        private void ZoneTypeWiseVisitorsNumberReportUI_Load(object sender, EventArgs e)
        {
            GetAllZoneWithTotal();
            totalVisitorTextBox.Text = zoneManager.GetTotalVisitors();
        }
    }
}
