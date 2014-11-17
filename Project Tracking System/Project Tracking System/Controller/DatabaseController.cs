using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Tracking_System.Controller
{

    class DatabaseController
    {

        SqlConnection systemConnection = new SqlConnection("server=" + System.Environment.MachineName.ToString() +
               "\\SQLEXPRESS;" + "Trusted_Connection = yes;" + "database = Project_Tracking_System;" + "connection timeout = 10;" +
               "net=dbmslpcn");

        public bool addNewManager(string fName, string lName, int id)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.VarChar, 20); // First Name
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.VarChar, 30); // Last Name
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.BigInt); // Id

            SqlCommand insertNewPatronCommand = new SqlCommand("INSERT INTO Project_Manager (Id, FName, LName) VALUES (@LParam3,@LParam1,@LParam2)", systemConnection);
            LParam1.Value = fName;
            LParam2.Value = lName;
            LParam3.Value = id;
            if (doesManagerExist(fName, lName, id, LParam3) != true)
            {
                systemConnection.Open();
                insertNewPatronCommand.Parameters.Add(LParam1);
                insertNewPatronCommand.Parameters.Add(LParam2);
                insertNewPatronCommand.Parameters.Add(LParam3);
                insertNewPatronCommand.ExecuteNonQuery();
                systemConnection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool doesManagerExist(string fName, string lName, int id, SqlParameter LParam)
        {
            LParam = new SqlParameter("@LParam", SqlDbType.BigInt); // Id
             LParam.Value = id;
            SqlDataReader myReader;
            SqlCommand findManagerCommand = new SqlCommand("SELECT id From Project_Manager WHERE id=@LParam", systemConnection);
            findManagerCommand.Parameters.Add(LParam);
            String existingName = "";
            systemConnection.Open();
            myReader = findManagerCommand.ExecuteReader();
            
            while (myReader.Read())
            {
                existingName = myReader["id"].ToString();
            }
            systemConnection.Close();
            findManagerCommand.Parameters.Remove(LParam);
            if (existingName == id.ToString())
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
