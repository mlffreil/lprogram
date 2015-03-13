using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace lprogram
{
    class Tests
    {
        int testID;
        int numMov;
        int numCol;
        int totalPoints;
        string testName;
        Dictionary<int,int> movementIDs;
        Dictionary<int,int> collectiveIDs;

        public Tests() 
        {
            testID = 0;
            numMov = 0;
            numCol = 0;
           
        }
        public Tests(int ID)
        {
            testID = ID;
            // Get the Test information
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable test;
            String query = String.Format("select * from Tests where ID = {0}", testID);
            test = db.GetDataTable(query);
            if (test != null)
            {
                numMov = int.Parse(test.Rows[0]["NumMovements"].ToString());
                numCol = int.Parse(test.Rows[0]["NumCollectives"].ToString());
                totalPoints = int.Parse(test.Rows[0]["TotalPoints"].ToString());
                testName = test.Rows[0]["Name"].ToString();
            }
            // Get the movements
            DataTable movements;
            query = String.Format("select Coeff from Movements where TestID={0} and  Collective!=1 order by MovementNo;", testID);
            movements = db.GetDataTable(query);
            movementIDs = new Dictionary<int, int>();
            int count = 0;
            if (movements != null)
            {
                foreach (DataRow r in movements.Rows)
                {
                    movementIDs.Add(count, int.Parse(r["Coeff"].ToString()));
                    count++;
                }
            }
            query = String.Format("select Coeff from Movements where TestID={0} and  Collective==1 order by MovementNo;", testID);

            movements = db.GetDataTable(query);
            collectiveIDs = new Dictionary<int, int>();
            count = 0;
            if (movements != null)
            {
                foreach (DataRow r in movements.Rows)
                {
                    collectiveIDs.Add(count, int.Parse(r["Coeff"].ToString()));
                    count++;
                }
            }
        }
        //Need getters
        public int getTestID()
        {
            return testID;
        }
        public int getNumMovements()
        {
            return numMov;
        }
        public int getNumCollectives()
        {
            return numCol;
        }
        public int getTotalPoints()
        {
            return totalPoints;
        }
        public Dictionary<int,int> getMovements()
        {
            return movementIDs;
        }
        public string getTestName()
        {
            return testName;
        }
        public Dictionary<int,int> getCollectives()
        {
            return collectiveIDs;
        }
        //Need setters
        public int setTestID(int id)
        {
            testID = id;
            return 0;
        }
        public int setNumMovements(int num)
        {
            numMov = num;
            return 0;
        }
        public int setNumCollectives(int num)
        {
            numCol = num;
            return 0;
        }
        public int setTotalPoints(int num)
        {
            totalPoints = num;
            return 0;
        }
        public int setTestName(string str)
        {
            testName = str;
            return 0;
        }
        public int setMovements(Dictionary<int,int> dict)
        {
            movementIDs = dict;
            return 0;
        }
        public int setCollectives(Dictionary<int,int> dict)
        {
            collectiveIDs = dict;
            return 0;
        }
        public int saveTest()
        {
            // Save test if testId == 0; Otherwise update
            //Check to see if there is a test with this name
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (testID == 0)
            { 
                data.Add("NumMovements", numMov.ToString());
                data.Add("NumCollectives", numCol.ToString());
                data.Add("TotalPoints", totalPoints.ToString());
                data.Add("Name", testName.ToString());
                try
                {
                    db.Insert("Tests", data);
                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message);
                    return 1;
                }
                // Get the id of test just added
                String query = string.Format("select ID from Tests where Name='{0}'", testName);
                testID = int.Parse(db.ExecuteScalar(query));
                Dictionary<string, string> testData;
                // Use test id to save movements
                foreach (KeyValuePair<int, int> item in movementIDs)
                {
                    testData = new Dictionary<string, string>();
                    testData.Add("MovementNo", item.Key.ToString());
                    testData.Add("Coeff", item.Value.ToString());
                    testData.Add("TestID", testID.ToString());

                    try
                    {
                        db.Insert("Movements", testData);
                    }
                    catch (Exception crap)
                    {
                        MessageBox.Show(crap.Message);
                        return 1;
                    }
                }
                foreach(KeyValuePair<int,int> item in collectiveIDs)
                {
                    testData = new Dictionary<string, string>();
                    testData.Add("MovementNo", item.Key.ToString());
                    testData.Add("Coeff", item.Value.ToString());
                    testData.Add("TestID", testID.ToString());
                    testData.Add("Collective", "1");
                   
                    try
                    {
                        db.Insert("Movements", testData);
                    }
                    catch (Exception crap)
                    {
                        MessageBox.Show(crap.Message);
                        return 1;
                    }

                }
            }
  
            return 0;
        }
        // Static functions
        public static int testIDbyName(string name)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            String query = string.Format("select ID from Tests where Name='{0}'", name);
            string result = db.ExecuteScalar(query);
            if (result=="")
            {
                return 0;
            }
            return int.Parse(result);
        }
        public static DataTable getTestNames()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable testNames;
            String query = "select Name from Tests;";
            testNames = db.GetDataTable(query);
            return testNames;
        }
    }
}
