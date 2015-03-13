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
    public partial class AddTestForm : Form
    {
        int MovBox = 1;
        int ColBox = 1;
        Dictionary<int, TextBox> movementBoxes;
        Dictionary<int, TextBox> collectiveBoxes;
        Dictionary<int, Label> labels;

        public AddTestForm()
        {
            InitializeComponent();
        }
         
        private void addMov_Click(object sender, EventArgs e)
        {
            // Validate that all fields have been filled out

            // Add Boxes
            AddMovementBoxes(Convert.ToInt16( numMov.Text));
            AddCollectiveBoxes(Convert.ToInt16(numColl.Text));
            // Add Save button
            AddSaveButton();
        }

        public System.Windows.Forms.TextBox AddMovementBoxes(int numBoxes)
        {
            int left = 50;
            int topOffset = 1;
            movementBoxes = new Dictionary<int, TextBox>();
            labels = new Dictionary<int, Label>();
            for (int i = 1; i <= numBoxes; i++ )
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
                txt.Text = "1";
                txt.Width = 25;
                MovBox += 1;
                topOffset += 1;
                if (MovBox == 20)
                {
                    left = left + 100;
                    topOffset = 1;
                }
  
            }
            return null;
        }
        public System.Windows.Forms.TextBox AddCollectiveBoxes(int numBoxes)
        {
            int left = 300;
            int topOffset = 1;
            collectiveBoxes = new Dictionary<int, TextBox>();
            for (int i = 1; i <= numBoxes; i++)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                this.Controls.Add(lbl);
                labels.Add(i+MovBox, lbl);
                lbl.Text = this.ColBox.ToString();
                lbl.Left = left;
                lbl.Top = 200 + topOffset * 25;
                lbl.Width = 20;
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                collectiveBoxes.Add(i, txt);
                this.Controls.Add(txt);
                txt.Top =200 + ColBox * 25;
                txt.Left = left+25 ;
                txt.Text = "1";
                txt.Width = 25;
                ColBox += 1;
                topOffset += 1;
             }
            return null;
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
            btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Top = 700;
            btn.Left = 150;
            btn.Text = "Cancel";
            btn.Name = "BtnCancel";
            btn.Click += new System.EventHandler(btnCancel_Click);
            return btn;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // See if there is a test with this name already in database. If so, error
            if (Tests.testIDbyName(testName.Text) > 0)
            {
                MessageBox.Show("A test with this name already exists, please choose another");
                this.DialogResult = DialogResult.None;
                return;
            }
            // Create a test in database
            Tests newTest = new Tests();
            newTest.setNumMovements(int.Parse(numMov.Text));
            newTest.setNumCollectives(int.Parse(numColl.Text));
            newTest.setTotalPoints(int.Parse(totalPts.Text));
            newTest.setTestName(testName.Text);
            Dictionary<int, int> testData = new Dictionary<int, int>();
            foreach (KeyValuePair<int,TextBox> item in movementBoxes)
            {
                testData.Add(item.Key, int.Parse(item.Value.Text));
            }
            newTest.setMovements(testData);
            Dictionary<int, int> collData = new Dictionary<int, int>();
            foreach (KeyValuePair<int, TextBox> item in collectiveBoxes)
            {
                collData.Add(item.Key, int.Parse(item.Value.Text));
            }
            newTest.setCollectives(collData);
            newTest.saveTest();
            clearForm();
            this.DialogResult = DialogResult.OK;
        }
        private void clearForm()
        {
            removeBoxes();
            numColl.Text = "";
            numMov.Text = "";
            testName.Text = "";
            totalPts.Text = "";
            MovBox = 1;
            ColBox = 1;
        }
        private void removeBoxes()
        {
            foreach (KeyValuePair<int, TextBox> item in movementBoxes)
            {
                this.Controls.Remove(item.Value);
                item.Value.Dispose();
            }
            foreach (KeyValuePair<int, TextBox> item in collectiveBoxes)
            {
                this.Controls.Remove(item.Value);
                item.Value.Dispose();
            }
            foreach (KeyValuePair<int,Label> item in labels)
            {
                this.Controls.Remove(item.Value);
                item.Value.Dispose();
            }
        }
    }
}
