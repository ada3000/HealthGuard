using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace HealthGuard
{
	public partial class frmYeys : Form
	{
		private int _swapTimeout = 500;
		public frmYeys()
		{
			InitializeComponent();
		}

		private void frmYeys_Load(object sender, EventArgs e)
		{
			Task t = new Task(WaitSwapState);
			t.Start();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			DoClick();
		}

		private void frmYeys_Click(object sender, EventArgs e)
		{
			DoClick();
		}

		private void DoClick()
		{
			Close();
			Program.YeysOpened = false;			
		}

		private void WaitSwapState()
		{
			while (Program.YeysOpened)
			{
				Thread.Sleep(_swapTimeout);
				SwapState();
			}
		}

		private void SwapState()
		{
			try
			{
				if (InvokeRequired)
				{
					Action d = new Action(SwapState);
					Invoke(d);
					return;
				}

				pbHide.Visible = !pbHide.Visible;
			}
			catch { } //Гасим исключение на ликвидированном объекте
		}
	}
}
