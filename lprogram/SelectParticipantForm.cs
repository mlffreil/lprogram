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
    public partial class SelectParticipantForm : Form
    {
        public SelectParticipantForm()
        {
            InitializeComponent();
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable showNames;
            String query = "select Distinct Name from People where IsExaminer!=1;";
            showNames = db.GetDataTable(query);

            foreach (DataRow r in showNames.Rows)
            {
                partComboBox.Items.Add(r["Name"].ToString());
            }

        }

        private void partComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Get the selected particpant
            // Check to see if she is already a participant for this show
            // If not, create new record with this show id
            // update participants on main form
            // Todo: What if there are already 2 examiners for this show
            string partName = partComboBox.SelectedItem.ToString();
            SQLiteDatabase db = new SQLiteDatabase();
            string dt;
            string query = "select Name from People where Name = '" + partName + "' and ShowID = " + Form1.showID;
            dt = db.ExecuteScalar(query);
            if (dt.Length == 0)
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("Name", partName);
                data.Add("ShowID", Form1.showID.ToString());
                data.Add("IsExaminer", "0");
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
            foreach (KeyValuePair<int, Label> partLabel in Form1.participants)
                if (partLabel.Value.Text.Length == 0)
                {
                    partLabel.Value.Text = partName.Trim();
                    break;
                }

            this.DialogResult = DialogResult.OK;
        }
    }
}
