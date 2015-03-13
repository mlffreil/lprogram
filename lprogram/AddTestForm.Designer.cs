namespace lprogram
{
    partial class AddTestForm
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
            this.testName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numColl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPts = new System.Windows.Forms.TextBox();
            this.addMov = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create A New Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Name";
            // 
            // testName
            // 
            this.testName.Location = new System.Drawing.Point(96, 41);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(240, 20);
            this.testName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "# of Movements";
            // 
            // numMov
            // 
            this.numMov.Location = new System.Drawing.Point(121, 70);
            this.numMov.Name = "numMov";
            this.numMov.Size = new System.Drawing.Size(100, 20);
            this.numMov.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "# of Collective Marks";
            // 
            // numColl
            // 
            this.numColl.Location = new System.Drawing.Point(144, 100);
            this.numColl.Name = "numColl";
            this.numColl.Size = new System.Drawing.Size(100, 20);
            this.numColl.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Points";
            // 
            // totalPts
            // 
            this.totalPts.Location = new System.Drawing.Point(100, 127);
            this.totalPts.Name = "totalPts";
            this.totalPts.Size = new System.Drawing.Size(100, 20);
            this.totalPts.TabIndex = 8;
            // 
            // addMov
            // 
            this.addMov.Location = new System.Drawing.Point(34, 170);
            this.addMov.Name = "addMov";
            this.addMov.Size = new System.Drawing.Size(75, 23);
            this.addMov.TabIndex = 9;
            this.addMov.Text = "Add Movements";
            this.addMov.UseVisualStyleBackColor = true;
            this.addMov.Click += new System.EventHandler(this.addMov_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Movements";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Collectives";
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 762);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addMov);
            this.Controls.Add(this.totalPts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numColl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.testName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTestForm";
            this.Text = "AddTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numMov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numColl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPts;
        private System.Windows.Forms.Button addMov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}