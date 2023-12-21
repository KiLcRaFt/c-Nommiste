namespace Tooded
{
    partial class Registration
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
            this.lblReg = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtboxLog = new System.Windows.Forms.TextBox();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Noto Mono", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblReg.Location = new System.Drawing.Point(12, 9);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(475, 57);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "Registreesimine";
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbllog.Location = new System.Drawing.Point(111, 114);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(75, 24);
            this.lbllog.TabIndex = 1;
            this.lbllog.Text = "Login";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPass.Location = new System.Drawing.Point(93, 156);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(114, 24);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // txtboxLog
            // 
            this.txtboxLog.Location = new System.Drawing.Point(215, 114);
            this.txtboxLog.Name = "txtboxLog";
            this.txtboxLog.Size = new System.Drawing.Size(137, 20);
            this.txtboxLog.TabIndex = 3;
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(215, 156);
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(137, 20);
            this.txtboxPass.TabIndex = 4;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(215, 199);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(137, 20);
            this.txtboxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Noto Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblEmail.Location = new System.Drawing.Point(132, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 24);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Gmail";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnSubmit.Location = new System.Drawing.Point(215, 256);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 29);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Salvesta";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 309);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.txtboxLog);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.lblReg);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtboxLog;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSubmit;
    }
}