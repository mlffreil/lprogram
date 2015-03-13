namespace lprogram
{
    partial class AddClassForm
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
            this.classNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numRidesTxt = new System.Windows.Forms.TextBox();
            this.addRides = new System.Windows.Forms.Button();
            this.testNameCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name:";
            // 
            // classNameTxt
            // 
            this.classNameTxt.Location = new System.Drawing.Point(105, 24);
            this.classNameTxt.Name = "classNameTxt";
            this.classNameTxt.Size = new System.Drawing.Size(195, 20);
            this.classNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Test Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Rides";
            // 
            // numRidesTxt
            // 
            this.numRidesTxt.Location = new System.Drawing.Point(126, 102);
            this.numRidesTxt.Name = "numRidesTxt";
            this.numRidesTxt.Size = new System.Drawing.Size(100, 20);
            this.numRidesTxt.TabIndex = 5;
            // 
            // addRides
            // 
            this.addRides.Location = new System.Drawing.Point(44, 152);
            this.addRides.Name = "addRides";
            this.addRides.Size = new System.Drawing.Size(75, 23);
            this.addRides.TabIndex = 8;
            this.addRides.Text = "Add Rides";
            this.addRides.UseVisualStyleBackColor = true;
            this.addRides.Click += new System.EventHandler(this.addRides_Click);
            // 
            // testNameCombo
            // 
            this.testNameCombo.FormattingEnabled = true;
            this.testNameCombo.Location = new System.Drawing.Point(105, 61);
            this.testNameCombo.Name = "testNameCombo";
            this.testNameCombo.Size = new System.Drawing.Size(121, 21);
            this.testNameCombo.TabIndex = 10;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 762);
            this.Controls.Add(this.testNameCombo);
            this.Controls.Add(this.addRides);
            this.Controls.Add(this.numRidesTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numRidesTxt;
        private System.Windows.Forms.Button addRides;
        private System.Windows.Forms.ComboBox testNameCombo;
    }
}