using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HealthGuard
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            Hide();
            //foreach (ToolStripMenuItem I in CMS.Items) I.Click += CMS_ItemClick;
        }

        private void frmStart_Activated(object sender, EventArgs e)
        {
            Hide();
        }

        public void ShowDelay()
        {
            if (this.InvokeRequired)
            {
                ThreadStart D = new ThreadStart(ShowDelay);
                Invoke(D);
                return;
            }

            Form1 F = new Form1();
            F.FormBorderStyle = FormBorderStyle.None;
            F.TopLevel = true;
            F.TopMost = true;

			F.FormClosed += Main_FormClosed;

            F.Show();
        }
		/// <summary>
		/// Отображение формы
		/// </summary>
		/// <param name="f"></param>
		public void ShowForm(Form f)
		{
			if (InvokeRequired)
			{
				Action<Form> d = new Action<Form>(ShowForm);
				Invoke(d, f);
				return;
			}
			f.TopLevel = true;
			f.TopMost = true;

			f.Show();
		}

		void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.MainOpened = false;
		}



        
        private void CMS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            ToolStripMenuItem I = e.ClickedItem as ToolStripMenuItem;
            if (I.Name == "tsbExt")
            {
                Close();
                return;
            }
        }
    }
}
