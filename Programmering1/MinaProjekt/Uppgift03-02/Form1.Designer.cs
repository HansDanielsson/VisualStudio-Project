﻿namespace Uppgift03_02
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbxCharNr = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Char Nr:";
			// 
			// tbxCharNr
			// 
			this.tbxCharNr.Location = new System.Drawing.Point(110, 23);
			this.tbxCharNr.Name = "tbxCharNr";
			this.tbxCharNr.Size = new System.Drawing.Size(100, 20);
			this.tbxCharNr.TabIndex = 1;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(110, 115);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(37, 13);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "Result";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 347);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.tbxCharNr);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Övning 3.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxCharNr;
		private System.Windows.Forms.Label lblResult;
	}
}

