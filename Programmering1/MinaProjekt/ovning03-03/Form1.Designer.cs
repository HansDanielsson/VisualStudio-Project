﻿namespace ovning03_03
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
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblC = new System.Windows.Forms.Label();
			this.tbxA = new System.Windows.Forms.TextBox();
			this.tbxB = new System.Windows.Forms.TextBox();
			this.tbxC = new System.Windows.Forms.TextBox();
			this.lblSumma = new System.Windows.Forms.Label();
			this.lblMedel = new System.Windows.Forms.Label();
			this.btnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(32, 34);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(32, 13);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Tal A";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(32, 70);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(32, 13);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "Tal B";
			// 
			// lblC
			// 
			this.lblC.AutoSize = true;
			this.lblC.Location = new System.Drawing.Point(32, 100);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(32, 13);
			this.lblC.TabIndex = 2;
			this.lblC.Text = "Tal C";
			// 
			// tbxA
			// 
			this.tbxA.Location = new System.Drawing.Point(122, 26);
			this.tbxA.Name = "tbxA";
			this.tbxA.Size = new System.Drawing.Size(100, 20);
			this.tbxA.TabIndex = 3;
			// 
			// tbxB
			// 
			this.tbxB.Location = new System.Drawing.Point(122, 62);
			this.tbxB.Name = "tbxB";
			this.tbxB.Size = new System.Drawing.Size(100, 20);
			this.tbxB.TabIndex = 4;
			// 
			// tbxC
			// 
			this.tbxC.Location = new System.Drawing.Point(122, 92);
			this.tbxC.Name = "tbxC";
			this.tbxC.Size = new System.Drawing.Size(100, 20);
			this.tbxC.TabIndex = 5;
			// 
			// lblSumma
			// 
			this.lblSumma.AutoSize = true;
			this.lblSumma.Location = new System.Drawing.Point(102, 138);
			this.lblSumma.Name = "lblSumma";
			this.lblSumma.Size = new System.Drawing.Size(45, 13);
			this.lblSumma.TabIndex = 6;
			this.lblSumma.Text = "Summa:";
			// 
			// lblMedel
			// 
			this.lblMedel.AutoSize = true;
			this.lblMedel.Location = new System.Drawing.Point(102, 168);
			this.lblMedel.Name = "lblMedel";
			this.lblMedel.Size = new System.Drawing.Size(66, 13);
			this.lblMedel.TabIndex = 7;
			this.lblMedel.Text = "Medelvärde:";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(96, 211);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 8;
			this.btnRun.Text = "Kör";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 259);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.lblMedel);
			this.Controls.Add(this.lblSumma);
			this.Controls.Add(this.tbxC);
			this.Controls.Add(this.tbxB);
			this.Controls.Add(this.tbxA);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.TextBox tbxA;
		private System.Windows.Forms.TextBox tbxB;
		private System.Windows.Forms.TextBox tbxC;
		private System.Windows.Forms.Label lblSumma;
		private System.Windows.Forms.Label lblMedel;
		private System.Windows.Forms.Button btnRun;
	}
}

