namespace Tooded
{
    partial class Login
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
            this.txtbLog = new System.Windows.Forms.TextBox();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OpenSymbol", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbLog
            // 
            this.txtbLog.Location = new System.Drawing.Point(92, 157);
            this.txtbLog.Name = "txtbLog";
            this.txtbLog.Size = new System.Drawing.Size(198, 21);
            this.txtbLog.TabIndex = 1;
            this.txtbLog.Text = "Login";
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(92, 193);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(198, 21);
            this.txtbPass.TabIndex = 2;
            this.txtbPass.Text = "Password";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(228, 237);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(62, 21);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Enter";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 313);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtbPass);
            this.Controls.Add(this.txtbLog);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "Login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbLog;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.Button btnLog;
    }
}