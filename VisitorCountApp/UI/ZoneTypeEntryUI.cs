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
    public partial class ZoneTypeEntryUI : Form
    {
        public ZoneTypeEntryUI()
        {
            InitializeComponent();
        }

        ZoneManager zoneManager = new ZoneManager();

        private void zoneTypeSaveButton_Click(object sender, EventArgs e)
        {
            Zone aZone = new Zone();
            aZone.ZoneType = typeNameTextBox.Text;
            if (aZone.ZoneType == "") {
                MessageBox.Show("Enter Zone type!");
                return;
            }
            if(zoneManager.IsZoneExixts(aZone.ZoneType)){
                MessageBox.Show("This Zone Type Already Exists!");
                return;
            }
            MessageBox.Show(zoneManager.SaveZone(aZone));
            typeNameTextBox.Clear();
            ShowAllZoneType();
        }


        public void ShowAllZoneType()
        {
            List<Zone> zoneList = zoneManager.GetAllZone();
            zoneTypeListView.Items.Clear();
            foreach (var zone in zoneList)
            {
                ListViewItem items = new ListViewItem();
                items.SubItems.Add(zone.ZoneType);
                zoneTypeListView.Items.Add(items);
            }
        }


        private void ZoneTypeEntryUI_Load(object sender, EventArgs e)
        {
            ShowAllZoneType();
        }
    }
}
