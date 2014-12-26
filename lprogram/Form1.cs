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
    public partial class Form1 : Form
    {
        Form2 newForm = new Form2();
        Form3 openForm = new Form3();
        Form4 newPart = new Form4();
        Form5 newExam = new Form5();
        SelectExamForm selectExam = new SelectExamForm();
        public static Label nameLabel = new Label();
        public static Dictionary<int, Label> examiners = new Dictionary<int, Label>();
        


        public static int showID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void part3_Click(object sender, EventArgs e)
        {

        }

        private void part7_Click(object sender, EventArgs e)
        {

        }

        private void showName_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //ToDo: check to see if anything needs to be saved?
            Application.Exit();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            newForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameLabel = showName;
            examiners.Add(1, examiner1);
            examiners.Add(2, examiner2);
            
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openForm.ShowDialog();
        }

        private void mnuAddParticipant_Click(object sender, EventArgs e)
        {
            newPart.ShowDialog();
        }

        private void mnuAddExaminer_Click(object sender, EventArgs e)
        {
            newExam.ShowDialog();
        }

        private void selectParticipantToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuSelectExaminer_Click(object sender, EventArgs e)
        {
            selectExam.ShowDialog();
        }
    }
}
