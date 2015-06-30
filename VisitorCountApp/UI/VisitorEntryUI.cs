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
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
            GetAllZoneType();
        }

        ZoneManager zoneManager = new ZoneManager();
        VisitorManager visitorManager=new VisitorManager();
        

        public void GetAllZoneType() {
            int position=30;
            List<Zone> zoneList = zoneManager.GetAllZone();
            foreach (var zone in zoneList) {
                CheckBox aCheckBox = new CheckBox();
                aCheckBox.Text = zone.ZoneType;
                aCheckBox.AutoSize = true;
                aCheckBox.Checked = true;
                aCheckBox.Location = new Point(20, position);
                visitorGroupBox.Controls.Add(aCheckBox);
                aCheckBox.Tag = (Zone)zone;
                position += 30;
            }
        }
       

        public int CheckedZone(int visitorId)
        {
            int check = 0;
            foreach (Control box in visitorGroupBox.Controls) {
                if (box is CheckBox)
                {
                    CheckBox temp = (CheckBox)box;
                    if (temp.Checked)
                    {
                        check = 1;
                        Visitor aVisitor = new Visitor();
                        Zone selectedZone = (Zone)temp.Tag;
                        Zone aZone = new Zone();
                        aZone.Id = selectedZone.Id;
                        aVisitor.AZon = aZone;
                        visitorManager.SaveInRelation(visitorId,aVisitor.AZon.Id);
                        zoneManager.UpdateTotalVisitors(aZone.Id);
                      }
                  }
              }
            return check;
         }
        

        private void visitorEntrySaveButton_Click(object sender, EventArgs e)
        {
            Visitor aVisitor = new Visitor();
            aVisitor.Name = nameTextBox.Text;
            aVisitor.Email = emailTextBox.Text;
            aVisitor.ContactNumber = contactNumberTextBox.Text;
            int visitorId = visitorManager.SaveVisitor(aVisitor);

            if (nameTextBox.Text == "" || emailTextBox.Text == "" || contactNumberTextBox.Text == "") {
                MessageBox.Show(@"Please Fillup all Information!",@"Warning!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
           int value= CheckedZone(visitorId);
           if (value == 0) {
               MessageBox.Show("Select ZoneType!",@"Warning!",MessageBoxButtons.OK,MessageBoxIcon.Information);
               return;
           }
            MessageBox.Show("Visitor Saved Successfully!");
            nameTextBox.Clear();
            emailTextBox.Clear();
            contactNumberTextBox.Clear();
            this.Close();  
        }
  
    }
}
