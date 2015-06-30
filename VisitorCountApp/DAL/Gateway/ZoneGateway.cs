using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using VisitorCountApp.DAL.Model;
using System.Data.SqlClient;

namespace VisitorCountApp.DAL.Gateway
{
    class ZoneGateway
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connectionDb"].ConnectionString;

        public int SaveZonetype(Zone aZone)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO ZoneTBL VALUES('"+aZone.ZoneType+"','0')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        
        public decimal GetTotalVisitors(int id)
        {
            totalVisitors = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM ZoneTBL WHERE Id='"+id+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                totalVisitors= decimal.Parse(reader["Total"].ToString());
            }
            connection.Close();
            reader.Close();
            return totalVisitors;
        }

        public void UpdateTotalVisitors(int id)
        {
            decimal total = GetTotalVisitors(id);
            total = total + 1;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE ZoneTBL SET Total='"+total+"' WHERE Id='"+id+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           
        }

        public decimal totalVisitors;

        public List<Zone> GetZoneList()
        {
            totalVisitors = 0;
            List<Zone> zoneList = new List<Zone>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM ZoneTBL ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Zone aZone = new Zone();
                aZone.Id = int.Parse(reader["Id"].ToString());
                aZone.ZoneType = reader["ZoneType"].ToString();
                aZone.Total = decimal.Parse(reader["Total"].ToString());
                totalVisitors += aZone.Total;
                zoneList.Add(aZone);
            }
            reader.Close();
            connection.Close();
            return zoneList;
        }

        public List<int> GetVisitorId(int zoneId)
        {
            List<int> visitorIdList=new List<int>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM RelationTBL WHERE ZoneId='"+zoneId+"' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                visitorIdList.Add(int.Parse(reader["VisitorId"].ToString()));
            }
            reader.Close();
            connection.Close();
            return visitorIdList;

        }
        public bool IsZoneTypeExists(string zoneType) {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM ZoneTBL WHERE ZoneType='"+zoneType+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
            return false;

        }
    }
}
