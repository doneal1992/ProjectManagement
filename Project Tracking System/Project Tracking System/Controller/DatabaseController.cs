using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracking_System.Controller
{

    class DatabaseController
    {
        

       protected static SqlConnection systemConnection = new SqlConnection("Data Source="+Environment.MachineName+"\\SQLExpress;Initial Catalog=Project_Tracking_System;Integrated Security=True");
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

            
                systemConnection.Open();
                insertNewEmployee.Parameters.Add(LParam1);
                insertNewEmployee.Parameters.Add(LParam2);
                insertNewEmployee.Parameters.Add(LParam3);
                insertNewEmployee.Parameters.Add(LParam4);
                insertNewEmployee.ExecuteNonQuery();
                systemConnection.Close();
                return true;
            
           

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

        /**
         * Adds new requirement to database linked to projectID
         * Precondition: none
         * Postcondition: riskID ->| requirementID
         * */
        public bool addNewRequirement(int requirementID, string type, string description)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);//requirement id
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.VarChar, 20);//type
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.VarChar, 500);//description

            SqlCommand insertNewRequirement = new SqlCommand("INSERT INTO Requirements Values(@LParam1,@LParam2,@LParam3)", systemConnection);
            LParam1.Value = requirementID;
            LParam2.Value = type;
            LParam3.Value = description;
            if(doesRequirementExist(description,requirementID,LParam1) != true)
            {
                systemConnection.Open();
                insertNewRequirement.Parameters.Add(LParam1);
                insertNewRequirement.Parameters.Add(LParam2);
                insertNewRequirement.Parameters.Add(LParam3);
                insertNewRequirement.ExecuteNonQuery();
                systemConnection.Close();
                return true;
            }
            else{
                 return false;
            }
        }

        /**
         * Adds Effort Hours to project linked to projectID
         * Preconditoin: none
         * Postcondition: none
         * */
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

        /**
         * Adds new Risk to database with link to projectID
         * Precondition: none
         * Postconditon: none
         * */
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

        /**
         * Returns Project Name of project based on give projectID
         * Preconditon: none
         * Postconditoin: none
         * @Return:  Project Name of projectID
         * */
        public string getProjectNameByProjetID(int projectID)
        {
            string projectName = "";
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);
            SqlCommand getProjectName = new SqlCommand("Select projectName FROM Project WHERE projectID = @LParam1", systemConnection);
            SqlDataReader myReader;
           
            LParam1.Value = projectID;
            systemConnection.Open();
            getProjectName.Parameters.Add(LParam1);
            myReader = getProjectName.ExecuteReader();
            while (myReader.Read())
            {
                projectName = myReader["projectName"].ToString();
            }
            systemConnection.Close();
            return projectName;
        }

        /**
         * Returns string of project requirements based on the given projectID
         * Precondition: none
         * PostCondition:none
         * @Return: String of project requirements
         * */
        public string getProjectRequirementsByProjectID(int projectID)
        {
            string requirementType = "";
            string requirementDescription = "";
            string currentRequirement = "";
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);
            SqlCommand getProjctRequirements = new SqlCommand("SELECT type,description FROM Requirements WHERE requirementID = @LParam1", systemConnection);
            SqlDataReader myReader;
            LParam1.Value = projectID;
            systemConnection.Open();
            getProjctRequirements.Parameters.Add(LParam1);
            myReader = getProjctRequirements.ExecuteReader();
            while (myReader.Read())
            {
                requirementType = myReader["type"].ToString();
                requirementDescription = myReader["description"].ToString();
                requirementType = requirementType.PadRight(35 - requirementType.Length);
                currentRequirement = currentRequirement + string.Format("{0}{1}", requirementType, requirementDescription) + Environment.NewLine;
            }
            systemConnection.Close();
            getProjctRequirements.Parameters.Remove(LParam1);
            return currentRequirement;
        }

        /**Returns a string of project Risks based on the given projectID
         * Precondition: none
         * Postcondition: none
         * @Return: string of project Risks
         * */
        public string getProjectRisksByProjectID(int projectID)
        {
            string riskDescription = "";
            string riskStatus = "";
            string currentRisk = "";
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);
            SqlCommand getProjctRequirements = new SqlCommand("SELECT riskStatus,description FROM Risks WHERE risksID = @LParam1", systemConnection);
            SqlDataReader myReader;
            LParam1.Value = projectID;
            systemConnection.Open();
            getProjctRequirements.Parameters.Add(LParam1);
            myReader = getProjctRequirements.ExecuteReader();
            while (myReader.Read())
            {
                riskDescription = myReader["description"].ToString();
                riskStatus = myReader["riskStatus"].ToString();
                riskStatus = riskStatus.PadRight(35 - riskStatus.Length);
                currentRisk = currentRisk + string.Format("{0}{1}", riskStatus, riskDescription) + Environment.NewLine;
            }
            systemConnection.Close();
            getProjctRequirements.Parameters.Remove(LParam1);
            return Environment.NewLine + currentRisk;
        }


        /**
         * Returns string array of effort hours linked to projectID in database
         * Precondition: none
         * Postcondition: none
         * @Return: string array of effort hours
         * */
        public string[] getEfforHoursByProjectID(int projectID)
        {
            string[] efforHourArray = new string[5];
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);
            SqlCommand getEffortHours = new SqlCommand("SELECT * FROM Effort WHERE effortProjID = @LParam1", systemConnection);
            SqlDataReader myReader;
            LParam1.Value = projectID;
            getEffortHours.Parameters.Add(LParam1);
            systemConnection.Open();
            myReader = getEffortHours.ExecuteReader();
            while (myReader.Read())
            {
                efforHourArray[0] = myReader["designHours"].ToString();
                efforHourArray[1] = myReader["codeHours"].ToString();
                efforHourArray[2] = myReader["reqAnalysis"].ToString();
                efforHourArray[3] = myReader["testingHours"].ToString();
                efforHourArray[4] = myReader["projManagementHours"].ToString();
            }
            myReader.Close();
            getEffortHours.Parameters.Remove(LParam1);
            systemConnection.Close();
           
            return efforHourArray;
        }

        /**
         * Updates the effort hours linked to the projectID in the database
         * Precondition: none
         * PostCondition: Effort Hours linked to projectID are changed
         **/
        public void updateEfforHoursByProjectId(int projectID, int designHours, int codingHours, int reqAnalysisHours, int testingHours, int projManagementHours)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);//projectID;
            SqlParameter LParam2 = new SqlParameter("@LParam2", SqlDbType.BigInt);//designHours;
            SqlParameter LParam3 = new SqlParameter("@LParam3", SqlDbType.BigInt);//codingHours;
            SqlParameter LParam4 = new SqlParameter("@LParam4", SqlDbType.BigInt);//requirement Analysis hours;
            SqlParameter LParam5 = new SqlParameter("@LParam5", SqlDbType.BigInt);//testing hours;
            SqlParameter LParam6 = new SqlParameter("@LParam6", SqlDbType.BigInt);//project Management hours;
            SqlCommand updateEfforHours = new SqlCommand("UPDATE Effort SET designHours = @LParam2,codeHours=@LParam3,reqAnalysis=@LParam4,testingHours=@LParam5,projManagementHours=@LParam6 WHERE effortProjID = @LParam1", systemConnection);
            LParam1.Value = projectID;
            LParam2.Value = designHours;
            LParam3.Value = codingHours;
            LParam4.Value = reqAnalysisHours;
            LParam5.Value = testingHours;
            LParam6.Value = projManagementHours;

            executeUpdateEffortHours(LParam1, LParam2, LParam3, LParam4, LParam5, LParam6, updateEfforHours);



        }


        /**
         * Returns a string of all employees linked to the projectID
         * Precondition: none;
         * Postcondition: non
         * @return: A string of all employees linked to the projectID in the database
         **/
        public string getProjectEmployeesByProjectID(int projectID)
        {
       
            string projectEmployeeFName = "";
            string projectEmployeeLName = "";
            string projectEmployeePosition = "";
            string currentInfo = "";
          
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);
            SqlCommand getProjectEmployees = new SqlCommand("SELECT Fname,Lname,position FROM Employee WHERE currProjID = @LParam1", systemConnection);
            SqlDataReader myReader;
           
            LParam1.Value = projectID;
            return executeGetEmployees(ref projectEmployeeFName, ref projectEmployeeLName, ref projectEmployeePosition, ref currentInfo, LParam1, getProjectEmployees, out myReader);
        }

       

        /**
         * Moves the project with the specified id from the Project Table to the Archived_Projects Table, also removes all references to requirements,effort,risks,and employees
         * Precondition: none;
         * PostCondition: none;
         * */
        public void finalizeProjectAndRemoveComponents(int projectID)
        {
            SqlParameter LParam1 = new SqlParameter("@LParam1", SqlDbType.BigInt);//project id
            SqlCommand moveToArchiveTable = new SqlCommand("INSERT INTO Archived_Projects SELECT * FROM Project WHERE projectID = @LParam1", systemConnection);
            SqlCommand removeRequirements = new SqlCommand("DELETE FROM Requirements WHERE requirementID = @LParam1", systemConnection);
            SqlCommand removeEmployees = new SqlCommand("DELETE FROM Employee WHERE currProjID = @LParam1", systemConnection);
            SqlCommand removeEffortHours = new SqlCommand("DELETE FROM Effort WHERE effortProjID = @LParam1", systemConnection);
            SqlCommand removeRisks = new SqlCommand("DELETE FROM Risks WHERE risksID = @LParam1", systemConnection);
            SqlCommand removeProject = new SqlCommand("DELETE FROM Project WHERE projectID = @LParam1", systemConnection);
            LParam1.Value = projectID;
            executeProjectFinalize(LParam1, moveToArchiveTable, removeRequirements, removeEmployees, removeEffortHours, removeRisks, removeProject);
        }

      



        /*********************************Private Methods****************************************/
        // Reads employees from Database and returns them as a string
        private static string executeGetEmployees(ref string projectEmployeeFName, ref string projectEmployeeLName, ref string projectEmployeePosition, ref string currentInfo, SqlParameter LParam1, SqlCommand getProjectEmployees, out SqlDataReader myReader)
        {
            systemConnection.Open();
            getProjectEmployees.Parameters.Add(LParam1);
            myReader = readEmployees(ref projectEmployeeFName, ref projectEmployeeLName, ref projectEmployeePosition, ref currentInfo, getProjectEmployees);
            getProjectEmployees.Parameters.Remove(LParam1);
            systemConnection.Close();


            return Environment.NewLine + currentInfo;
        }

        //Reads employee table
        private static SqlDataReader readEmployees(ref string projectEmployeeFName, ref string projectEmployeeLName, ref string projectEmployeePosition, ref string currentInfo, SqlCommand getProjectEmployees)
        {
            SqlDataReader myReader;
            myReader = getProjectEmployees.ExecuteReader();
            while (myReader.Read())
            {

                projectEmployeeFName = myReader["Fname"].ToString();
                projectEmployeeLName = myReader["Lname"].ToString();
                projectEmployeePosition = myReader["position"].ToString();
                projectEmployeeFName = projectEmployeeFName.PadRight(40 - projectEmployeeFName.Length);
                projectEmployeeLName = projectEmployeeLName.PadRight(40 - projectEmployeeLName.Length);

                currentInfo = currentInfo + string.Format(("{0}{1}{2}"), projectEmployeeFName, projectEmployeeLName, projectEmployeePosition) + Environment.NewLine;


            }
            return myReader;
        }

        //Finalizes project by removing project,requirements,risks,employees,and effort from database. Moves projec to archive table
        private static void executeProjectFinalize(SqlParameter LParam1, SqlCommand moveToArchiveTable, SqlCommand removeRequirements, SqlCommand removeEmployees, SqlCommand removeEffortHours, SqlCommand removeRisks, SqlCommand removeProject)
        {
            moveToArchive(LParam1, moveToArchiveTable);
            removeRequirement(LParam1, removeRequirements);
            removeEmployee(LParam1, removeEmployees);
            removeEffort(LParam1, removeEffortHours);
            removeRisk(LParam1, removeRisks);
            removeRisks.Parameters.Remove(LParam1);
            removedProject(LParam1, removeProject);
        }

        private static void executeUpdateEffortHours(SqlParameter LParam1, SqlParameter LParam2, SqlParameter LParam3, SqlParameter LParam4, SqlParameter LParam5, SqlParameter LParam6, SqlCommand updateEfforHours)
        {
            updateEfforHours.Parameters.Add(LParam1);
            updateEfforHours.Parameters.Add(LParam2);
            updateEfforHours.Parameters.Add(LParam3);
            updateEfforHours.Parameters.Add(LParam4);
            updateEfforHours.Parameters.Add(LParam5);
            updateEfforHours.Parameters.Add(LParam6);
            systemConnection.Open();
            updateEfforHours.ExecuteNonQuery();
            systemConnection.Close();
            updateEfforHours.Parameters.Remove(LParam1);
            updateEfforHours.Parameters.Remove(LParam2);
            updateEfforHours.Parameters.Remove(LParam3);
            updateEfforHours.Parameters.Remove(LParam4);
            updateEfforHours.Parameters.Remove(LParam5);
            updateEfforHours.Parameters.Remove(LParam6);
        }

        private static void removeRisk(SqlParameter LParam1, SqlCommand removeRisks)
        {
            removeRisks.Parameters.Add(LParam1);
            systemConnection.Open();
            removeRisks.ExecuteNonQuery();
            systemConnection.Close();
        }

        private static void removeEffort(SqlParameter LParam1, SqlCommand removeEffortHours)
        {
            removeEffortHours.Parameters.Add(LParam1);
            systemConnection.Open();
            removeEffortHours.ExecuteNonQuery();
            systemConnection.Close();
            removeEffortHours.Parameters.Remove(LParam1);
        }

        private static void removeEmployee(SqlParameter LParam1, SqlCommand removeEmployees)
        {
            removeEmployees.Parameters.Add(LParam1);
            systemConnection.Open();
            removeEmployees.ExecuteNonQuery();
            systemConnection.Close();
            removeEmployees.Parameters.Remove(LParam1);
        }

        private static void removeRequirement(SqlParameter LParam1, SqlCommand removeRequirements)
        {
            removeRequirements.Parameters.Add(LParam1);
            systemConnection.Open();
            removeRequirements.ExecuteNonQuery();
            systemConnection.Close();
            removeRequirements.Parameters.Remove(LParam1);
        }

        private static void moveToArchive(SqlParameter LParam1, SqlCommand moveToArchiveTable)
        {
            moveToArchiveTable.Parameters.Add(LParam1);
            systemConnection.Open();
            moveToArchiveTable.ExecuteNonQuery();
            systemConnection.Close();
            moveToArchiveTable.Parameters.Remove(LParam1);
        }

        private static void removedProject(SqlParameter LParam1, SqlCommand removeProject)
        {
            removeProject.Parameters.Add(LParam1);
            systemConnection.Open();
            removeProject.ExecuteNonQuery();
            systemConnection.Close();
            removeProject.Parameters.Remove(LParam1);
        }

       
        

        private bool doesProjectExist(string projectName,int id,SqlParameter LParam, SqlParameter LParam2)
        {
            LParam = new SqlParameter("@LParam", SqlDbType.VarChar,30);
            LParam2 = new SqlParameter("@LParam2", SqlDbType.BigInt);
            LParam2.Value = id;
            LParam.Value = projectName;
            SqlDataReader myReader;
            SqlCommand findProjectCommand = new SqlCommand("SELECT projectName From Project WHERE projectName=@LParam", systemConnection);
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

        private bool doesRequirementExist(string description,int requirementID, SqlParameter LParam)
        {
            LParam = new SqlParameter("@LParam", SqlDbType.BigInt);
            LParam.Value = requirementID;
            SqlCommand findRequirementCommand = new SqlCommand("SELECT description From Requirements WHERE requirementID=@LParam", systemConnection);
            SqlDataReader myReader;
            findRequirementCommand.Parameters.Add(LParam);
            String existingRequirement = "";
            String newRequirementLowerCase = description.ToLower();
            systemConnection.Open();
            myReader = findRequirementCommand.ExecuteReader();
            while (myReader.Read())
            {
                existingRequirement = myReader["description"].ToString();
            }
            systemConnection.Close();
            findRequirementCommand.Parameters.Remove(LParam);
            if (existingRequirement == description || existingRequirement == newRequirementLowerCase)
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
            String newRiskLowerCase = riskDescription.ToLower();
            systemConnection.Open();
            myReader = findManagerCommand.ExecuteReader();
            
            while (myReader.Read())
            {
                existingRisk = myReader["description"].ToString();
                
            }
            systemConnection.Close();
           
            findManagerCommand.Parameters.Remove(LParam);
            if (existingRisk == riskDescription || existingRisk == newRiskLowerCase)
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
