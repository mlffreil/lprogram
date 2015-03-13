using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace lprogram
{
    public class LProgram
    {
        int showID;
        Dictionary<int, int> examinerIDs;
        Dictionary<int,int> participantIDs;
        Dictionary<int, int> classIDs;

        public LProgram()
        {
            examinerIDs = new Dictionary<int,int>();
            participantIDs = new Dictionary<int,int>();
            classIDs = new Dictionary<int,int>();
            showID = 0;
        }

        public LProgram(int ID)
        {
            showID = ID;
            // Get all the examiners for this program from the database
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable examNames;
            String query = String.Format("select Distinct ID from People where IsExaminer=1 and ShowID={0};", showID);
            examNames = db.GetDataTable(query);
            examinerIDs = new Dictionary<int,int>();
            int count = 0;
            if (examNames != null)
            {
                foreach (DataRow r in examNames.Rows)
                {
                    examinerIDs.Add(count, int.Parse(r["ID"].ToString()));
                    count++;
                }
            }

            // Get all the participants for this program from the database
            DataTable partNames;
            query = String.Format("select Distinct ID from People where IsExaminer!=1 and ShowID={0};", showID);
            partNames = db.GetDataTable(query);
            participantIDs = new Dictionary<int,int>();
            count = 0;
            if (partNames != null)
            {
                foreach (DataRow r in partNames.Rows)
                {
                    participantIDs.Add(count, int.Parse(r["ID"].ToString()));
                    count++;
                }
            }
            // Get all the classes for this show from the database
        }

        public string getProgramName()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            string showName;
            String query = String.Format("select Name from Show where ID={0};", showID);
            showName = db.ExecuteScalar(query);
            return showName;
        }

        public string getExaminer(int num)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            string examName;
            if (examinerIDs == null || examinerIDs.Count == 0 || examinerIDs.Count < num)
                return "";
            int examId = examinerIDs[num-1];
            String query = String.Format("select Name from People where ID={0} and ShowID={1};", examId, showID);
            examName = db.ExecuteScalar(query);
            return examName;
        }
        public string getParticipant(int num)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            string examName;
            if (participantIDs == null || participantIDs.Count == 0 || participantIDs.Count < num)
                return "";
            int partId = participantIDs[num-1];
            String query = String.Format("select Name from People where ID={0} and ShowID={1};", partId, showID);
            examName = db.ExecuteScalar(query);
            return examName;
        }
        public int getShowID()
        {
            return showID;
        }
    }   
}
