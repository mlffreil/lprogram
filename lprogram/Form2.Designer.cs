namespace lprogram
{
    partial class Form2
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
            this.form2ProgName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.form2ProgLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.form2Calendar = new System.Windows.Forms.MonthCalendar();
            this.form2BtnOK = new System.Windows.Forms.Button();
            this.form2BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Name: ";
            // 
            // form2ProgName
            // 
            this.form2ProgName.Location = new System.Drawing.Point(120, 33);
            this.form2ProgName.Name = "form2ProgName";
            this.form2ProgName.Size = new System.Drawing.Size(100, 20);
            this.form2ProgName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location: ";
            // 
            // form2ProgLoc
            // 
            this.form2ProgLoc.Location = new System.Drawing.Point(120, 68);
            this.form2ProgLoc.Name = "form2ProgLoc";
            this.form2ProgLoc.Size = new System.Drawing.Size(317, 20);
            this.form2ProgLoc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date: ";
            // 
            // form2Calendar
            // 
            this.form2Calendar.Location = new System.Drawing.Point(58, 108);
            this.form2Calendar.Name = "form2Calendar";
            this.form2Calendar.TabIndex = 5;
            // 
            // form2BtnOK
            // 
            this.form2BtnOK.Location = new System.Drawing.Point(48, 282);
            this.form2BtnOK.Name = "form2BtnOK";
            this.form2BtnOK.Size = new System.Drawing.Size(75, 23);
            this.form2BtnOK.TabIndex = 6;
            this.form2BtnOK.Text = "Save";
            this.form2BtnOK.UseVisualStyleBackColor = true;
            this.form2BtnOK.Click += new System.EventHandler(this.form2BtnOK_Click);
            // 
            // form2BtnCancel
            // 
            this.form2BtnCancel.Location = new System.Drawing.Point(180, 282);
            this.form2BtnCancel.Name = "form2BtnCancel";
            this.form2BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.form2BtnCancel.TabIndex = 7;
            this.form2BtnCancel.Text = "Cancel";
            this.form2BtnCancel.UseVisualStyleBackColor = true;
            this.form2BtnCancel.Click += new System.EventHandler(this.form2BtnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 318);
            this.Controls.Add(this.form2BtnCancel);
            this.Controls.Add(this.form2BtnOK);
            this.Controls.Add(this.form2Calendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.form2ProgLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.form2ProgName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox form2ProgName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox form2ProgLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar form2Calendar;
        private System.Windows.Forms.Button form2BtnOK;
        private System.Windows.Forms.Button form2BtnCancel;
    }
}