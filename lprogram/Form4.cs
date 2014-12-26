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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string partName = addPartTextBox.Text;
            if (partName.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a Name");
                this.DialogResult = DialogResult.None;
                return;
            }
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("Name", partName.Trim());
            data.Add("ShowID", Form1.showID.ToString());
            try
            {
                db.Insert("People", data);
                
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
