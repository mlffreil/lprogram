using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace lprogram
{
    class Final
    {
        int classID;
        int finalID;
        int rideID;
        int judgeID;
        int testID;
        int numErrors;
        int numScores;
        float finalScore;
        Dictionary<int, float> scoreIDs;

        public Final()
        {
            finalID = 0;
        }

        public Final(int ID)
        {
            finalID = ID;
            // Get the score information
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable test;
            String query = String.Format("select * from Final where ID = {0}", testID);
            test = db.GetDataTable(query);
            if (test != null)
            {
                classID = int.Parse(test.Rows[0]["ClassID"].ToString());
                rideID = int.Parse(test.Rows[0]["RideID"].ToString());
                judgeID = int.Parse(test.Rows[0]["JudgeID"].ToString());
                testID = int.Parse(test.Rows[0]["TestID"].ToString());
                numErrors = int.Parse(test.Rows[0]["numErrors"].ToString());
                finalScore = float.Parse(test.Rows[0]["FinalScore"].ToString());
            }
            //get the scores
            // Get the movements
            DataTable movements;
            query = String.Format("select Score, MovementID from Score where FinalID={0} ;", finalID);
            movements = db.GetDataTable(query);
            scoreIDs = new Dictionary<int, float>();
            int count = 0;
            if (movements != null)
            {
                foreach (DataRow r in movements.Rows)
                {
                    scoreIDs.Add(int.Parse(r["MovementID"].ToString()), float.Parse(r["Score"].ToString()));
                    count++;
                }
            }
            numScores = count;
            finalScore = computeScore();
        }
        public float computeScore()
        {
            Tests test = new Tests(testID);
            float totalPoints = 0;
            float final;
          
            foreach (KeyValuePair<int, float> item in scoreIDs)
            {
                Movements mov = new Movements(int.Parse(item.Key.ToString()));
                totalPoints += (float.Parse(item.Value.ToString()))*float.Parse(mov.getCoeff().ToString());
            }
            final = (totalPoints + numErrors) / test.getTotalPoints();

            return final;
        }

        //Getters
        public int getFinalID()
        {
            return finalID;
        }
        public int getClassID()
        {
            return classID;
        }
        public int getRideID()
        {
            return rideID;
        }
        public int getJudgeID()
        {
            return judgeID;
        }
        public int getTestID()
        {
            return testID;
        }
        public float getFinalScore()
        {
            return finalScore;
        }
        public Dictionary<int, float> getScores()
        {
            return scoreIDs;
        }

        //Setters
        public void setFinalID(int id)
        {
            finalID = id;
        }
        public void setClassID(int id)
        {
            classID = id;
        }
        public void setRideID(int id)
        {
            rideID = id;
        }
        public void setJudgeID(int id)
        {
            judgeID = id;
        }
        public void setTestID(int id)
        {
            testID = id;
        }
        public void getFinalScore(float score)
        {
            finalScore = score;
        }

        public int saveScore()
        {
            //Save score if scoreID == 0, otherwise update
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<string, string> data = new Dictionary<string, string>();
            finalScore = computeScore();
            if (testID == 0)
            {
                data.Add("ClassID", classID.ToString());
                data.Add("RideID", rideID.ToString());
                data.Add("FinalScore", finalScore.ToString());
                data.Add("TestID", testID.ToString());
                data.Add("JudgeID", judgeID.ToString());
                data.Add("NumErrors", numErrors.ToString());
                try
                {
                    db.Insert("Final", data);
                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message);
                    return 1;
                }
                // Get the id of final score just added
                String query = string.Format("select ID from Final where RideID='{0}' and JudgeID='{1}'", rideID, judgeID);
                finalID = int.Parse(db.ExecuteScalar(query));
                Dictionary<string, string> testData;
                foreach (KeyValuePair<int, float> item in scoreIDs)
                {
                    testData = new Dictionary<string, string>();
                    testData.Add("MovementID", item.Key.ToString());
                    testData.Add("Score", item.Value.ToString());
                    testData.Add("FinalID", finalID.ToString());

                    try
                    {
                        db.Insert("Score", testData);
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
    }
}
