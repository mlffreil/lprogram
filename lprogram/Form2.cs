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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void form2BtnOK_Click(object sender, EventArgs e)
        {
            //ToDo: Check to make sure everything is filled out and save to database
            string progName = form2ProgName.Text;
            string progDate = form2Calendar.SelectionRange.ToString();
            string progLoc = form2ProgLoc.Text;

            if (progName.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a Name for the Program");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (progLoc.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a Location for the Program", "Error");
                this.DialogResult = DialogResult.None;
                return;
            }
            MessageBox.Show(progDate, "Error");
            // ToDo: Check to see if the date is after current date
            if (progDate.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a Date for the Program", "Error");
                this.DialogResult = DialogResult.None;
                return;
            }

            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<string, string>();
            data.Add("Name", progName.Trim());
            data.Add("ProgDate", progDate);
            data.Add("Location", progLoc.Trim());
            try
            {
                db.Insert("Show", data);
                Form1.nameLabel.Text = progName;
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
                this.DialogResult = DialogResult.None;
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void form2BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
