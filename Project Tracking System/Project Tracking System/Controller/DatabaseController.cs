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

       protected static SqlConnection systemConnection = new SqlConnection("server=" + System.Environment.MachineName.ToString() +
               "\\SQLEXPRESS;" + "Trusted_Connection = yes;" + "database = Project_Tracking_System;" + "connection timeout = 10;" +
               "net=dbmslpcn");
        /**
         * Returns true iff a new employee has been added to the database, else returns false
         * 
         * Precondition: currProjectID > 0 && FName.length > , FName != null, && LName.length > 0, LName !=null && 
         * position.length > , position != null
         * 
         * Postcondition: Project_Tracking_System.DB contains employee(currProjectID,FName,LName,Position
         * @return iff a new employee is added to database, else @return false
         * */
        public bool addNewEmployee(int currProjectID, string FName, string LName, string position)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);//id
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.VarChar, 25);
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.VarChar, 25);// last name
            SqlParameter LParam4 = new SqlParameter("@LParam4", SqlDbType.VarChar, 25);

            SqlCommand insertNewEmployee = new SqlCommand("INSERT INTO Employee VALUES(@LParam1,@LParam2,@LParam3,@LParam4)", systemConnection);
            LParam1.Value = currProjectID;
            LParam2.Value = FName;
            LParam3.Value = LName;
            LParam4.Value = position;

            if (doesEmployeeExist(currProjectID, LParam1) != true)
            {
                systemConnection.Open();
                insertNewEmployee.Parameters.Add(LParam1);
                insertNewEmployee.Parameters.Add(LParam2);
                insertNewEmployee.Parameters.Add(LParam3);
                insertNewEmployee.Parameters.Add(LParam4);
                systemConnection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

        /**
    * Returns true iff a new manager has been added to the database, else returns false
    * 
    * Precondition: string fName.length > 0 && fName != null && lName.length > 0 && lName != null && id > 0
    * 
    * Postcondition: Project_Tracking_System.DB contains Project_Manager(fName, lName, id)
    * @return iff a new Manager is added to database, else @return false
    * */
        public bool addNewManager(string fName, string lName, int id)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.VarChar, 20); // First Name
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.VarChar, 30); // Last Name
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.BigInt); // Id

            SqlCommand insertNewPatronCommand = new SqlCommand("INSERT INTO Project_Manager (Id, FName, LName) VALUES (@LParam3,@LParam1,@LParam2)", systemConnection);
            LParam1.Value = fName;
            LParam2.Value = lName;
            LParam3.Value = id;
            if (doesManagerExist(id, LParam3) != true)
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
        /**
        * Returns true iff a new Project has been added to the database, else returns false
        * 
        * Precondition: projectID > 0 && projectName.length > 0 && projectName != null && projectDescription.length > 0
        *   projectDescription != null
        * 
        * Postcondition: Project_Tracking_System.DB contains Project(projectID,projectName,projectDescription)
        * @return iff a new Project is added to database, else @return false
        * */
        public bool newProject(int projectID,string projectName, string projectDescription,string managerFirstName,string managerLastName)
        {
            if(projectID < 0)
            {
                throw new ArgumentException("The Project ID must be greater than or equal to zero");
            }
            

            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);//id
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.VarChar,30);//name
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.VarChar,3000);//description

            LParam1.Value = projectID;
            LParam2.Value = projectName;
            LParam3.Value = projectDescription;

            SqlCommand newProject = new SqlCommand("INSERT INTO Project VALUES(@LParam1,@LParam2,@LParam3)", systemConnection);
            if (doesManagerIdAndNameMatch(projectID,managerFirstName,managerLastName, LParam1) == true)
            {
                if (doesProjectExist(projectName,projectID,LParam2,LParam1) != true)
                {
                    systemConnection.Open();
                    newProject.Parameters.Add(LParam1);
                    newProject.Parameters.Add(LParam2);
                    newProject.Parameters.Add(LParam3);
                    newProject.ExecuteNonQuery();
                    systemConnection.Close();
                    return true;
                }
                
                else{
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool addNewHours(int effortProjID, int designHours, int codeHours, int reqAnalysisHours, int testingHours, int projManagaementHours)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);//Project ID link
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.BigInt);//design hours
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.BigInt);//code hours
            SqlParameter LParam4 = new SqlParameter("@LParam4", SqlDbType.BigInt);//requirement Analysis hours
            SqlParameter LParam5 = new SqlParameter("@LParam5", SqlDbType.BigInt);//testing  hours
            SqlParameter LParam6 = new SqlParameter("@LParam6", SqlDbType.BigInt);//project management  hours

            SqlCommand insertDesignHours = new SqlCommand("INSERT INTO Effort Values(@LParam1,@LParam2,@LParam3,@LParam4,@LParam5,@LParam6)", systemConnection);
            LParam1.Value = effortProjID;
            LParam2.Value = designHours;
            LParam3.Value = codeHours;
            LParam4.Value = reqAnalysisHours;
            LParam5.Value = testingHours;
            LParam6.Value = projManagaementHours;

            if (doesEffortExist(effortProjID, LParam1) != true)
            {
                systemConnection.Open();
                insertDesignHours.Parameters.Add(LParam1);
                insertDesignHours.Parameters.Add(LParam2);
                insertDesignHours.Parameters.Add(LParam3);
                insertDesignHours.Parameters.Add(LParam4);
                insertDesignHours.Parameters.Add(LParam5);
                insertDesignHours.Parameters.Add(LParam6);
                insertDesignHours.ExecuteNonQuery();
                systemConnection.Close();
                return true;
            }
            else
            {
                return false;
            }

            
        }


        public bool addNewRisk(int riskID, string riskDescription, string riskStatus)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt); // Risk ID
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.VarChar, 500); // Risk Description
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.VarChar, 25); // status

            SqlCommand insertNewRiskCommand = new SqlCommand("INSERT INTO Risks VALUES (@LParam1,@LParam2,@LParam3)", systemConnection);
            LParam1.Value = riskID;
            LParam2.Value = riskDescription;
            LParam3.Value = riskStatus;
            if (doesRiskExist(riskDescription,riskID, LParam3) != true)
            {
                systemConnection.Open();
                insertNewRiskCommand.Parameters.Add(LParam1);
                insertNewRiskCommand.Parameters.Add(LParam2);
                insertNewRiskCommand.Parameters.Add(LParam3);
                insertNewRiskCommand.ExecuteNonQuery();
                systemConnection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }





        /**                                          Private Methods                            **/
        private bool doesProjectExist(string projectName,int id,SqlParameter LParam, SqlParameter LParam2)
        {
            LParam = new SqlParameter("@LParam", SqlDbType.VarChar,30);
            LParam2 = new SqlParameter("@LParam2", SqlDbType.BigInt);
            LParam2.Value = id;
            LParam.Value = projectName;
            SqlDataReader myReader;
            SqlCommand findProjectCommand = new SqlCommand("SELECT * From Project WHERE projectName=@LParam", systemConnection);
            SqlCommand findProjectWithIDCommand = new SqlCommand("SELECT projectID From Project WHERE projectID = @LParam2", systemConnection);
            findProjectCommand.Parameters.Add(LParam);
            findProjectWithIDCommand.Parameters.Add(LParam2);
            String existingProject = "";
            String existingProjectID = "";
            systemConnection.Open();
            myReader = findProjectCommand.ExecuteReader();

            while (myReader.Read())
            {
                existingProject = myReader["projectName"].ToString();
            
            }
            systemConnection.Close();
            findProjectCommand.Parameters.Remove(LParam);
            systemConnection.Open();
            myReader = findProjectWithIDCommand.ExecuteReader();

            while (myReader.Read())
            {
                existingProjectID = myReader["projectID"].ToString();

            }
            systemConnection.Close();
            findProjectWithIDCommand.Parameters.Remove(LParam2);
            if (existingProject == projectName || existingProjectID == id.ToString())
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool doesEffortExist(int effortId, SqlParameter LParam)
        {
            LParam = new SqlParameter("@LParam", SqlDbType.BigInt); // Id
            LParam.Value = effortId;
            SqlDataReader myReader;
            SqlCommand findManagerCommand = new SqlCommand("SELECT effortProjID From Effort WHERE effortProjID=@LParam", systemConnection);
            findManagerCommand.Parameters.Add(LParam);
            String existingEffort = "";
            systemConnection.Open();
            myReader = findManagerCommand.ExecuteReader();

            while (myReader.Read())
            {
                existingEffort = myReader["effortProjID"].ToString();
            }
            systemConnection.Close();
            findManagerCommand.Parameters.Remove(LParam);
            if (existingEffort == effortId.ToString())
            {

                return true;
            }
            else
            {
                return false;
            }
        }


         private bool doesRiskExist(string riskDescription,int riskId, SqlParameter LParam)
        {
            LParam = new SqlParameter("@LParam", SqlDbType.BigInt); // Id
             LParam.Value = riskId;
            SqlDataReader myReader;
            SqlCommand findManagerCommand = new SqlCommand("SELECT description From Risks WHERE risksID=@LParam", systemConnection);
            findManagerCommand.Parameters.Add(LParam);
            String existingRisk = "";
            systemConnection.Open();
            myReader = findManagerCommand.ExecuteReader();
            
            while (myReader.Read())
            {
                existingRisk = myReader["description"].ToString();
                
            }
            systemConnection.Close();
           
            findManagerCommand.Parameters.Remove(LParam);
            if (existingRisk == riskDescription)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

         private bool doesManagerIdAndNameMatch(int id, string firstName, string lastName, SqlParameter LParam)
         {
             LParam = new SqlParameter("@LParam", SqlDbType.BigInt); // Id
             LParam.Value = id;
             SqlDataReader myReader;
             SqlCommand findManagerCommand = new SqlCommand("SELECT * From Project_Manager WHERE id=@LParam", systemConnection);
             findManagerCommand.Parameters.Add(LParam);
             String existingId = "";
             String existingFirstName = "";
             String existingLastName = "";

             systemConnection.Open();
             myReader = findManagerCommand.ExecuteReader();

             while (myReader.Read())
             {
                 existingId = myReader["id"].ToString();
                 existingFirstName = myReader["FName"].ToString();
                 existingLastName = myReader["LName"].ToString();

             }
             systemConnection.Close();
             findManagerCommand.Parameters.Remove(LParam);
             if (existingId == id.ToString() && existingFirstName == firstName && existingLastName == lastName)
             {

                 return true;
             }
             else
             {
                 return false;
             }
         }

        private bool doesManagerExist(int id,SqlParameter LParam)
        {
            
            LParam = new SqlParameter("@LParam", SqlDbType.BigInt); // Id
             LParam.Value = id;
            SqlDataReader myReader;
            SqlCommand findManagerCommand = new SqlCommand("SELECT * From Project_Manager WHERE id=@LParam", systemConnection);
            findManagerCommand.Parameters.Add(LParam);
            String existingId = "";
           
            systemConnection.Open();
            myReader = findManagerCommand.ExecuteReader();
            
            while (myReader.Read())
            {
                existingId = myReader["id"].ToString();

            }
            systemConnection.Close();
            findManagerCommand.Parameters.Remove(LParam);
            if (existingId == id.ToString())
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool doesEmployeeExist(int id, SqlParameter LParam)
        {
            LParam = new SqlParameter("@LParam", SqlDbType.BigInt); // Id
            LParam.Value = id;
            SqlDataReader myReader;
            SqlCommand findEmployeeCommand = new SqlCommand("SELECT currProjID From Employee WHERE currProjID=@LParam", systemConnection);
            findEmployeeCommand.Parameters.Add(LParam);
            String existingName = "";
            systemConnection.Open();
            myReader = findEmployeeCommand.ExecuteReader();

            while (myReader.Read())
            {
                existingName = myReader["currProjID"].ToString();
            }
            systemConnection.Close();
            findEmployeeCommand.Parameters.Remove(LParam);
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
