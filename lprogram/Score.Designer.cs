namespace lprogram
{
    partial class Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.riderComboBox = new System.Windows.Forms.ComboBox();
            this.judgeComboBox = new System.Windows.Forms.ComboBox();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxErrors = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalPts = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Judge";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(71, 44);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 5;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // riderComboBox
            // 
            this.riderComboBox.FormattingEnabled = true;
            this.riderComboBox.Location = new System.Drawing.Point(71, 82);
            this.riderComboBox.Name = "riderComboBox";
            this.riderComboBox.Size = new System.Drawing.Size(121, 21);
            this.riderComboBox.TabIndex = 6;
            // 
            // judgeComboBox
            // 
            this.judgeComboBox.FormattingEnabled = true;
            this.judgeComboBox.Location = new System.Drawing.Point(71, 118);
            this.judgeComboBox.Name = "judgeComboBox";
            this.judgeComboBox.Size = new System.Drawing.Size(121, 21);
            this.judgeComboBox.TabIndex = 7;
            // 
            // scoreBtn
            // 
            this.scoreBtn.Location = new System.Drawing.Point(48, 154);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(75, 23);
            this.scoreBtn.TabIndex = 8;
            this.scoreBtn.Text = "Score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Movements";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Collectives";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Errors";
            // 
            // textBoxErrors
            // 
            this.textBoxErrors.Location = new System.Drawing.Point(242, 484);
            this.textBoxErrors.Name = "textBoxErrors";
            this.textBoxErrors.Size = new System.Drawing.Size(100, 20);
            this.textBoxErrors.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Points:";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(301, 528);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(35, 13);
            this.labelPoints.TabIndex = 15;
            this.labelPoints.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 554);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Points:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelTotalPts
            // 
            this.labelTotalPts.AutoSize = true;
            this.labelTotalPts.Location = new System.Drawing.Point(325, 554);
            this.labelTotalPts.Name = "labelTotalPts";
            this.labelTotalPts.Size = new System.Drawing.Size(41, 13);
            this.labelTotalPts.TabIndex = 17;
            this.labelTotalPts.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 583);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Percent:";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(325, 583);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(41, 13);
            this.labelPercent.TabIndex = 19;
            this.labelPercent.Text = "label11";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 762);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTotalPts);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxErrors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.judgeComboBox);
            this.Controls.Add(this.riderComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Score";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox riderComboBox;
        private System.Windows.Forms.ComboBox judgeComboBox;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxErrors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalPts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPercent;
    }
}