using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorCountApp.DAL.Gateway;
using VisitorCountApp.DAL.Model;

namespace VisitorCountApp.BLL
{
    class ZoneManager
    {
        ZoneGateway zoneGateway = new ZoneGateway();

        public string SaveZone(Zone aZone)
        {
            int value = zoneGateway.SaveZonetype(aZone);

            if (value > 0)
            {
                return "Zone Type Saved Successfully!";
            }
            else
            {
                return "Sorry! Save failed!";
            }
        }

        public List<Zone> GetAllZone()
        {
            return zoneGateway.GetZoneList();
        }

        public string GetTotalVisitors()
        {
            return zoneGateway.totalVisitors.ToString();
        }

        public void UpdateTotalVisitors(int id)
        {
            zoneGateway.UpdateTotalVisitors(id);
        }

        public decimal GetSelectedZoneTotalVisitors(int id)
        {
        
            return zoneGateway.GetTotalVisitors(id);
        }

        public bool IsZoneExixts(string name)
        {
            return zoneGateway.IsZoneTypeExists(name);
        }

        public List<int> visitorIdList(int zoneId)
        {
            return zoneGateway.GetVisitorId(zoneId);
        } 

    }
}
