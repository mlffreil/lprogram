using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lprogram
{
    public partial class Score : Form
    {
        int classID;
        Final currentFinal;
        Dictionary<int, TextBox> movementBoxes;
        Dictionary<int, TextBox> collectiveBoxes;
        Dictionary<int, Label> labels;
        int MovBox = 1;
        int ColBox = 1;

        public Score()
        {
            InitializeComponent();
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable classList;
            String query = string.Format("select * from Class where ShowID = {0}", Form1.show.getShowID());
            classList = db.GetDataTable(query);

            foreach (DataRow r in classList.Rows)
            {
                classComboBox.Items.Add(r["Name"].ToString());
            }
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the class id and use it to find the list of rides
            SQLiteDatabase db = new SQLiteDatabase();
            string className = classComboBox.SelectedItem.ToString();
           
            string query = "select ID from Class where Name = '" + className + "' and ShowID = " + Form1.showID;
            classID = int.Parse(db.ExecuteScalar(query));
            DataTable rideList;
            if (classID != 0)
            {
                query = string.Format("select * from Ride where ClassID = {0}", classID);
                rideList = db.GetDataTable(query);
                foreach (DataRow r in rideList.Rows)
                {
                    riderComboBox.Items.Add(r["HorseNum"].ToString());
                }
            }

            // use the show id to find the list of judges
            query = string.Format("select * from People where ShowID = {0}", Form1.showID);
            DataTable judgeList = db.GetDataTable(query);
            foreach (DataRow r in judgeList.Rows)
            {
                judgeComboBox.Items.Add(r["Name"].ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void scoreBtn_Click(object sender, EventArgs e)
        {
            //Make sure all fields have a selection and store the result
            currentFinal = new Final();
            SQLiteDatabase db = new SQLiteDatabase();
             string query = "select ID from Class where Name = '" + classComboBox.Text + "' and ShowID = " + Form1.showID;
            currentFinal.setClassID(int.Parse(db.ExecuteScalar(query)));

            query = "select ID from Ride where ClassID = '" + currentFinal.getClassID() + "' and HorseNum = " + riderComboBox.Text;
            currentFinal.setRideID(int.Parse(db.ExecuteScalar(query)));

            query = "select TestID from Ride where ClassID = '" + currentFinal.getClassID() + "' and HorseNum = " + riderComboBox.Text;
            currentFinal.setTestID(int.Parse(db.ExecuteScalar(query)));

            query = "select ID from People where ShowID = '" + Form1.showID + "' and Name = '" + judgeComboBox.Text + "'";
            currentFinal.setJudgeID(int.Parse(db.ExecuteScalar(query)));


            //Add score boxes
            AddScoreBoxes();
            AddSaveButton();

            query = "select TotalPoints from Tests where ID = " + test.getTestID();
            labelTotalPts.Text = db.ExecuteScalar(query);

        }
        public System.Windows.Forms.Button AddSaveButton()
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Top = 700;
            btn.Left = 50;
            btn.Text = "Save";
            btn.Name = "BtnOK";
            btn.Click += new System.EventHandler(btnOK_Click);
            
            return btn;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        public void AddScoreBoxes()
        {
            //Figure out how many movement boxes are needed and add them to the form
            Tests test = new Tests(currentFinal.getTestID());
            int numMovements = test.getNumMovements();
            int left = 50;
            int topOffset = 1;
            movementBoxes = new Dictionary<int, TextBox>();
            labels = new Dictionary<int, Label>();
            for (int i = 1; i <= numMovements; i++)
            {
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                movementBoxes.Add(i, txt);
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                this.Controls.Add(lbl);
                labels.Add(i, lbl);
                lbl.Text = this.MovBox.ToString();
                lbl.Left = left;
                lbl.Top = 200 + topOffset * 25;
                lbl.Width = 20;
                this.Controls.Add(txt);
                txt.Top = 200 + topOffset * 25;
                txt.Left = left + 25;
                txt.Width = 25;
                txt.KeyDown += new System.Windows.Forms.KeyEventHandler(keyEvent);
                MovBox += 1;
                topOffset += 1;
                if (MovBox == 20)
                {
                    left = left + 100;
                    topOffset = 1;
                }

            }



            //Figure out how many collective boxes are needed and add them to the form
            int numCollectives = test.getNumCollectives();
            left = 300;
            topOffset = 1;
            collectiveBoxes = new Dictionary<int, TextBox>();
            for (int i = 1; i <= numCollectives; i++)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                this.Controls.Add(lbl);
                labels.Add(i + MovBox, lbl);
                lbl.Text = this.ColBox.ToString();
                lbl.Left = left;
                lbl.Top = 200 + topOffset * 25;
                lbl.Width = 20;
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                collectiveBoxes.Add(i, txt);
                this.Controls.Add(txt);
                txt.Top = 200 + ColBox * 25;
                txt.Left = left + 25;
                txt.Width = 25;
                txt.KeyDown += new System.Windows.Forms.KeyEventHandler(keyEvent);
                ColBox += 1;
                topOffset += 1;
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void keyEvent(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
            {
                // add value of box to the running total and compute current percentage.

                Control ctl;
                ctl = (Control)sender;
                this.SelectNextControl(ActiveControl, true, true, true, true);

            }
        }
    }
}
