namespace GreetingServiceConsoleClient
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
            this.cmbTimeOfDay = new System.Windows.Forms.ComboBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnGenerateGreeting = new System.Windows.Forms.Button();
            this.lblTimeOfDay = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTimeOfDay
            // 
            this.cmbTimeOfDay.FormattingEnabled = true;
            this.cmbTimeOfDay.Location = new System.Drawing.Point(33, 66);
            this.cmbTimeOfDay.Name = "cmbTimeOfDay";
            this.cmbTimeOfDay.Size = new System.Drawing.Size(121, 24);
            this.cmbTimeOfDay.TabIndex = 0;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(33, 181);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 24);
            this.cmbLanguage.TabIndex = 1;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(260, 181);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(142, 16);
            this.lblGreeting.TabIndex = 2;
            this.lblGreeting.Text = "Greeting appears here";
            // 
            // btnGenerateGreeting
            // 
            this.btnGenerateGreeting.Location = new System.Drawing.Point(33, 275);
            this.btnGenerateGreeting.Name = "btnGenerateGreeting";
            this.btnGenerateGreeting.Size = new System.Drawing.Size(129, 44);
            this.btnGenerateGreeting.TabIndex = 3;
            this.btnGenerateGreeting.Text = "Generate Greeting";
            this.btnGenerateGreeting.UseVisualStyleBackColor = true;
            this.btnGenerateGreeting.Click += new System.EventHandler(this.btnGenerateGreeting_Click);
            // 
            // lblTimeOfDay
            // 
            this.lblTimeOfDay.AutoSize = true;
            this.lblTimeOfDay.Location = new System.Drawing.Point(30, 27);
            this.lblTimeOfDay.Name = "lblTimeOfDay";
            this.lblTimeOfDay.Size = new System.Drawing.Size(80, 16);
            this.lblTimeOfDay.TabIndex = 4;
            this.lblTimeOfDay.Text = "Time of Day";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(30, 129);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(68, 16);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 386);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblTimeOfDay);
            this.Controls.Add(this.btnGenerateGreeting);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.cmbTimeOfDay);
            this.Name = "Form1";
            this.Text = "Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTimeOfDay;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnGenerateGreeting;
        private System.Windows.Forms.Label lblTimeOfDay;
        private System.Windows.Forms.Label lblLanguage;
    }
}

