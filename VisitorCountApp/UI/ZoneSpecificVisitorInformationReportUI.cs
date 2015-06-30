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
    public partial class ZoneSpecificVisitorInformationReportUI : Form
    {
        public ZoneSpecificVisitorInformationReportUI()
        {
            InitializeComponent();
            LoadAllZone();
        }

        ZoneManager zoneManager = new ZoneManager();

        public void LoadAllZone() {
            selectZoneComboBox.DataSource = zoneManager.GetAllZone();
            selectZoneComboBox.DisplayMember = "ZoneType";
            selectZoneComboBox.ValueMember = "Id";
        }
       

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowSelectedZoneVisitors();
        }


        VisitorManager visitorManager = new VisitorManager();

        public void ShowSelectedZoneVisitors()
        {
            zoneSpecificVisitorInformationListView.Items.Clear();
            Zone aZone = (Zone)selectZoneComboBox.SelectedItem;
            int id = aZone.Id;
            List<int> visitorIdList = zoneManager.visitorIdList(id);
            foreach (int visitorId in visitorIdList)
            {
                List<Visitor> totalVisitorList = visitorManager.GetSelectedZoneVisitor(visitorId);

                foreach (Visitor visitor in totalVisitorList)
                {
                    ListViewItem items = new ListViewItem();
                    items.SubItems.Add(visitor.Name);
                    items.SubItems.Add(visitor.Email);
                    items.SubItems.Add(visitor.ContactNumber);
                    zoneSpecificVisitorInformationListView.Items.Add(items);
                }
                totalZoneSpecificTextBox.Text = zoneManager.GetSelectedZoneTotalVisitors(aZone.Id).ToString();
            }

        }
    }
}
