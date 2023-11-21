using System.Windows.Forms;

namespace Tooded
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Kat_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lisa_Kat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 225);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(647, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // Kat_Box
            // 
            this.Kat_Box.FormattingEnabled = true;
            this.Kat_Box.Location = new System.Drawing.Point(538, 174);
            this.Kat_Box.Name = "Kat_Box";
            this.Kat_Box.Size = new System.Drawing.Size(121, 21);
            this.Kat_Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(443, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategooriad:";
            // 
            // Lisa_Kat
            // 
            this.Lisa_Kat.AccessibleName = "Lisa_Kat";
            this.Lisa_Kat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lisa_Kat.Location = new System.Drawing.Point(625, 201);
            this.Lisa_Kat.Name = "Lisa_Kat";
            this.Lisa_Kat.Size = new System.Drawing.Size(34, 21);
            this.Lisa_Kat.TabIndex = 3;
            this.Lisa_Kat.Tag = "Lisa_Kat";
            this.Lisa_Kat.Text = "Lisa";
            this.Lisa_Kat.UseVisualStyleBackColor = true;
            this.Lisa_Kat.Click += new System.EventHandler(this.Lisa_Kat_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(671, 387);
            this.Controls.Add(this.Lisa_Kat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kat_Box);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox Kat_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lisa_Kat;
    }
}

