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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string examName = examTextBox.Text;
            if (examName.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a Name");
                this.DialogResult = DialogResult.None;
                return;
            }
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("Name", examName.Trim());
            data.Add("ShowID", Form1.showID.ToString());
            data.Add("IsExaminer", "1");
            try
            {
                db.Insert("People", data);
                // find an empty examiner
                foreach (KeyValuePair<int, Label> examLabel in Form1.examiners)
                    if (examLabel.Value.Text.Length == 0)
                    {
                        examLabel.Value.Text = examName.Trim();
                        break;
                    }
                

            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
                this.DialogResult = DialogResult.None;
                return;
            }
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
