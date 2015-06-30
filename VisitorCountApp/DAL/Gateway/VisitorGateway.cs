using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using VisitorCountApp.DAL.Model;

namespace VisitorCountApp.DAL.Gateway
{
    class VisitorGateway
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connectionDb"].ConnectionString;

        public int SaveVisitor(Visitor aVisitor)
        {
            int visitorId=0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO VisitorTBL VALUES('" + aVisitor.Name + "','"+aVisitor.Email+"','"+aVisitor.ContactNumber+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            query = "SELECT * FROM VisitorTBL";
            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                 visitorId =int.Parse( reader["Id"].ToString());
            }
            reader.Close();
            connection.Close();
            return visitorId;

        }

        //public  int GetVisitorId()

        public List<Visitor> GetSelectedZoneVisitors(int id)
        {
            List<Visitor> visitorList = new List<Visitor>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM VisitorTBL WHERE Id='"+id+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                Visitor aVisitor = new Visitor();
                aVisitor.Name = reader["Name"].ToString();
                aVisitor.Email = reader["Email"].ToString();
                aVisitor.ContactNumber = reader["ContactNumber"].ToString();
                visitorList.Add(aVisitor);
            }
            reader.Close();
            connection.Close();
            return visitorList;
        }

        public void SaveInRelation(int visitorId,int zoneId )
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO RelationTBL VALUES('" + visitorId + "','" + zoneId + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            
        }
    }
}
