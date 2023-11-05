namespace zadatak12
{
    partial class Form1
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
            this.mCal1 = new System.Windows.Forms.MonthCalendar();
            this.but1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mCal1
            // 
            this.mCal1.Location = new System.Drawing.Point(267, 18);
            this.mCal1.Name = "mCal1";
            this.mCal1.TabIndex = 0;
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(327, 214);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 1;
            this.but1.Text = "KLIKNI";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.mCal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCal1;
        private System.Windows.Forms.Button but1;
    }
}

