using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorCountApp.DAL.Gateway;
using VisitorCountApp.DAL.Model;

namespace VisitorCountApp.BLL
{
    class VisitorManager
    {

        VisitorGateway visitorGateway = new VisitorGateway();

        public int SaveVisitor(Visitor aVisitor)
        {
           return  visitorGateway.SaveVisitor(aVisitor) ;
        }

        public List<Visitor> GetSelectedZoneVisitor(int id)
        {
            return visitorGateway.GetSelectedZoneVisitors(id);
        }

        public void SaveInRelation(int visitorId, int zoneId)
        {
            visitorGateway.SaveInRelation(visitorId,zoneId);
        }
    }
}
