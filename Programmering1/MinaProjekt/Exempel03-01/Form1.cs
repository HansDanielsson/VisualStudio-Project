﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel03_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int tal = int.Parse(tbxTal.Text);

			int kvadrat = tal * tal;
			string text = kvadrat.ToString();
			tbxTal.Text = text;
			lblKvadrat.Text = text;
		}
	}
}