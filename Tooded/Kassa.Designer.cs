﻿namespace Tooded
{
    partial class Kassa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOtsi = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnKustuta = new System.Windows.Forms.Button();
            this.btnSalv = new System.Windows.Forms.Button();
            this.btnOtsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtOtsi
            // 
            this.txtOtsi.Location = new System.Drawing.Point(340, 243);
            this.txtOtsi.Name = "txtOtsi";
            this.txtOtsi.Size = new System.Drawing.Size(87, 20);
            this.txtOtsi.TabIndex = 1;
            this.txtOtsi.TextChanged += new System.EventHandler(this.txtOtsi_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(169, 251);
            this.listBox.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(187, 214);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "Lisa";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnKustuta
            // 
            this.btnKustuta.Location = new System.Drawing.Point(187, 240);
            this.btnKustuta.Name = "btnKustuta";
            this.btnKustuta.Size = new System.Drawing.Size(75, 23);
            this.btnKustuta.TabIndex = 4;
            this.btnKustuta.Text = "Kustuta";
            this.btnKustuta.UseVisualStyleBackColor = true;
            this.btnKustuta.Click += new System.EventHandler(this.btnKustuta_Click);
            // 
            // btnSalv
            // 
            this.btnSalv.Location = new System.Drawing.Point(187, 12);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(75, 23);
            this.btnSalv.TabIndex = 5;
            this.btnSalv.Text = "Salvesta";
            this.btnSalv.UseVisualStyleBackColor = true;
            this.btnSalv.Click += new System.EventHandler(this.btnSalv_Click);
            // 
            // btnOtsi
            // 
            this.btnOtsi.Location = new System.Drawing.Point(434, 243);
            this.btnOtsi.Name = "btnOtsi";
            this.btnOtsi.Size = new System.Drawing.Size(36, 20);
            this.btnOtsi.TabIndex = 6;
            this.btnOtsi.Text = "Otsi";
            this.btnOtsi.UseVisualStyleBackColor = true;
            this.btnOtsi.Click += new System.EventHandler(this.btnOtsi_Click);
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 440);
            this.Controls.Add(this.btnOtsi);
            this.Controls.Add(this.btnSalv);
            this.Controls.Add(this.btnKustuta);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txtOtsi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kassa";
            this.Text = "Kassa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOtsi;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnKustuta;
        private System.Windows.Forms.Button btnSalv;
        private System.Windows.Forms.Button btnOtsi;
    }
}