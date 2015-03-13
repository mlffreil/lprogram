using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace lprogram
{
    class Class
    {
        int classID;
        string className;
        int numRides;
        int showID;
        int testID;
        Dictionary<int, int> rideIDs;

        public Class()
        {
            classID = 0;
            numRides = 0;
            showID = 0;
            testID = 0;
        }

        public Class(int ID)
        {
            classID = ID;
            // Get class information
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable classes;
            String query = String.Format("select * from Class where ID = {0}", classID);
            classes = db.GetDataTable(query);
            if (classes != null)
            {
                numRides = int.Parse(classes.Rows[0]["NumRides"].ToString());
                className = classes.Rows[0]["Name"].ToString();
                showID = int.Parse(classes.Rows[0]["ShowID"].ToString());
                testID = int.Parse(classes.Rows[0]["TestID"].ToString());
            }
            // Get the rides
            DataTable rides;
            query = String.Format("select HorseNum from Ride where ClassID={0}", classID);
            rides = db.GetDataTable(query);
            rideIDs = new Dictionary<int, int>();
            int count = 0;
            if (rides != null)
            {
                foreach(DataRow r in rides.Rows)
                {
                    rideIDs.Add(count, int.Parse(r["HorseNum"].ToString()));
                    count++;
                }
            }
        }

        //Getters
        public int getClassID()
        {
            return classID;
        }

        public string getClassName()
        {
            return className;
        }

        public int getShowID()
        {
            return showID;
        }
        public int getNumRides()
        {
            return numRides;
        }
           
        public int getTestID()
        {
            return testID;
        }

        //setters
        public void setClassID(int id)
        {
            classID = id;
        }
        public void setNumRides(int num)
        {
            numRides = num;
        }
        public void setShowID(int id)
        {
            showID = id;
        }
        public void setTestID(int id)
        {
            testID = id;
        }
        public void setClassName(string str)
        {
            className = str;
        }
        public void setRides(Dictionary<int, int> dict)
        {
            rideIDs = dict;
        }

        public int saveClass()
        {
            //Save class if classID == 0, otherwise update
            // Check to see if there is a class with this name already - todo
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (classID == 0)
            {
                data.Add("Name", className.ToString());
                data.Add("NumRides", numRides.ToString());
                data.Add("ShowID", showID.ToString());
                data.Add("TestID", testID.ToString());
                try
                {
                    db.Insert("Class", data);
                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message);
                    return 1;
                }

                //Get the id of the class just added
                String query = string.Format("select ID from Class where Name='{0}'", className);
                classID = int.Parse(db.ExecuteScalar(query));
                Dictionary<string, string> classData;
                //Use the class id to save the rides
                foreach (KeyValuePair<int,int> item in rideIDs)
                {
                    classData = new Dictionary<string, string>();
                    classData.Add("ClassID", classID.ToString());
                    classData.Add("TestID", testID.ToString());
                    classData.Add("HorseNum", item.Value.ToString());

                    try
                    {
                        db.Insert("Ride", classData);
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
        // static function
        public static int classIDbyName(string name)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            String query = string.Format("select ID from Class where Name='{0}'", name);
            string result = db.ExecuteScalar(query);
            if (result == "")
            {
                return 0;
            }
            return int.Parse(result);
        }
    }
}
