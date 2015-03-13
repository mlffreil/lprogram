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
    public partial class AddClassForm : Form
    {
        int RideBox = 1;
        Dictionary<int, TextBox> rideBoxes;
        Dictionary<int, Label> labels;

        public AddClassForm()
        {
            InitializeComponent();
            DataTable testNames = Tests.getTestNames();
            foreach (DataRow r in testNames.Rows)
            {
                testNameCombo.Items.Add(r["Name"].ToString());
            }
        }

        private void addRides_Click(object sender, EventArgs e)
        {
            //Add ride boxes
            string numRides = numRidesTxt.Text;
            if (numRides != "")
            {
                AddRideBoxes(Convert.ToInt16(numRides));
                AddSaveButton();
            }
            else
            {
                MessageBox.Show("Please enter the number of rides in this class");
            }

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

        public void AddRideBoxes(int numBoxes)
        {
            int left = 50;
            int topOffset = 1;
            rideBoxes = new Dictionary<int, TextBox>();
            labels = new Dictionary<int, Label>();
            for (int i = 1; i <= numBoxes; i++)
            {
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                rideBoxes.Add(i, txt);
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                this.Controls.Add(lbl);
                labels.Add(i, lbl);
                lbl.Text = this.RideBox.ToString();
                lbl.Left = left;
                lbl.Top = 200 + topOffset * 25;
                lbl.Width = 20;
                this.Controls.Add(txt);
                txt.Top = 200 + topOffset * 25;
                txt.Left = left + 25;
                txt.Text = "";
                txt.Width = 50;
              
                txt.KeyDown += new System.Windows.Forms.KeyEventHandler(keyEvent);
; RideBox += 1;
                topOffset += 1;
                if (RideBox == 20)
                {
                    left = left + 100;
                    topOffset = 1;
                }

            }
        }
        private void keyEvent(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
            {
                
                Control ctl;
                ctl = (Control)sender;
                this.SelectNextControl(ActiveControl, true, true, true, true);
                
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Create a class
            Class newClass = new Class();
            newClass.setNumRides(int.Parse(numRidesTxt.Text));
            newClass.setClassName(classNameTxt.Text);
            newClass.setShowID(Form1.showID);
            newClass.setTestID(Tests.testIDbyName(testNameCombo.Text));
            Dictionary<int, int> rideData = new Dictionary<int, int>();
            foreach (KeyValuePair<int, TextBox> item in rideBoxes)
            {
                rideData.Add(item.Key, int.Parse(item.Value.Text));
            }
            newClass.setRides(rideData);
            newClass.saveClass();
            clearForm();
            this.DialogResult = DialogResult.OK;

        }
        private void clearForm()
        {
            foreach (KeyValuePair<int, TextBox> item in rideBoxes)
            {
                this.Controls.Remove(item.Value);
                item.Value.Dispose();
            }
            foreach (KeyValuePair<int, Label> item in labels)
            {
                this.Controls.Remove(item.Value);
                item.Value.Dispose();
            }
            classNameTxt.Text = "";
            numRidesTxt.Text = "";
            RideBox = 1;
        }
    }
}
