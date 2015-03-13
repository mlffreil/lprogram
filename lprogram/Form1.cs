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
        Score newScore;
        SelectExamForm selectExam = new SelectExamForm();
        SelectParticipantForm selectPart = new SelectParticipantForm();
        AddTestForm newAddTest = new AddTestForm();
        AddClassForm newAddClass = new AddClassForm();
        public static LProgram show;
        public static Label nameLabel = new Label();
        public static Dictionary<int, Label> examiners = new Dictionary<int, Label>();
        public static Dictionary<int, Label> participants = new Dictionary<int, Label>();
        

        
        public static int showID = 0;

        public Form1()
        {
            InitializeComponent();
            show = new LProgram();
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
            participants.Add(1, part1);
            participants.Add(2, part2);
            participants.Add(3, part3);
            participants.Add(4, part4);
            participants.Add(5, part5);
            participants.Add(6, part6);
            participants.Add(7, part7);
            participants.Add(8, part8);
            participants.Add(9, part9);
            participants.Add(10, part10);
            participants.Add(11, part11);
            participants.Add(12, part12);
            participants.Add(13, part13);
            participants.Add(14, part14);
            participants.Add(15, part15);
            
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openForm.ShowDialog();
            show = new LProgram(showID);
            Form1.nameLabel.Text = show.getProgramName();
            examiner1.Text = show.getExaminer(1);
            examiner2.Text = show.getExaminer(2);
            part1.Text = show.getParticipant(1);
            part2.Text = show.getParticipant(2);
            part3.Text = show.getParticipant(3);
            part4.Text = show.getParticipant(4);
            part5.Text = show.getParticipant(5);
            part6.Text = show.getParticipant(6);
            part7.Text = show.getParticipant(7);
            part8.Text = show.getParticipant(8);
            part9.Text = show.getParticipant(9);
            part10.Text = show.getParticipant(10);
            part11.Text = show.getParticipant(11);
            part12.Text = show.getParticipant(12);
            part13.Text = show.getParticipant(13);
            part14.Text = show.getParticipant(14);
            part15.Text = show.getParticipant(15);
        }

        private void mnuAddParticipant_Click(object sender, EventArgs e)
        {
            newPart.ShowDialog();
        }

        private void mnuAddExaminer_Click(object sender, EventArgs e)
        {
            newExam.ShowDialog();
            selectExam.Refresh();
        }

        private void selectParticipantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectPart.ShowDialog();
        }

        private void mnuSelectExaminer_Click(object sender, EventArgs e)
        {
            selectExam.ShowDialog();
        }

        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAddTest.ShowDialog();
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAddClass.ShowDialog();
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newScore = new Score();
            newScore.ShowDialog();
        }
    }
}
