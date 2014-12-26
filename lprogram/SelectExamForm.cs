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
    public partial class SelectExamForm : Form
    {
        public SelectExamForm()
        {
            InitializeComponent();
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable showNames;
            String query = "select Distinct Name from People where IsExaminer=1;";
            showNames = db.GetDataTable(query);

            foreach (DataRow r in showNames.Rows)
            {
                examComboBox.Items.Add(r["Name"].ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            //Get the selected examiner
            // Check to see if she is already an examiner for this show
            // If not, create new record with this show id
            // update Examiners on main form
            // Todo: What if there are already 2 examiners for this show
            string examName = examComboBox.SelectedItem.ToString();
            SQLiteDatabase db = new SQLiteDatabase();
            string dt;
            string query = "select Name from People where Name = '" + examName + "' and ShowID = " + Form1.showID;
            dt = db.ExecuteScalar(query);
            if (dt.Length == 0)
            {
                Dictionary<string,string> data = new Dictionary<string,string>();
                data.Add("Name", examName);
                data.Add("ShowID", Form1.showID.ToString());
                data.Add("IsExaminer", "1");
                try
                {
                    db.Insert("People", data);
                    // find an empty examiner
  
  
                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message);
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }
            foreach (KeyValuePair<int, Label> examLabel in Form1.examiners)
                if (examLabel.Value.Text.Length == 0)
                {
                    examLabel.Value.Text = examName.Trim();
                    break;
                }
            this.DialogResult = DialogResult.OK;
        }
    }
}
