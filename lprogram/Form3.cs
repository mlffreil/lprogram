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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable showNames;
            String query = "select Name from Show;";
            showNames = db.GetDataTable(query);

            foreach (DataRow r in showNames.Rows)
            {
                showList.Items.Add(r["Name"].ToString());
            }

        }

        private void showList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string progName = showList.SelectedItem.ToString();
            SQLiteDatabase db = new SQLiteDatabase();
            String query = String.Format("select ID from Show where Name = '{0}';", progName);
            Form1.showID = int.Parse(db.ExecuteScalar(query));
            this.DialogResult = DialogResult.OK;
        }
    }
}
