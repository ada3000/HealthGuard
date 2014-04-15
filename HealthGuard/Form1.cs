using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthGuard
{
    public partial class Form1 : Form
    {
        string mDate = "";
        string mDateResult = "";
        int mCurWait = 0;

        int mCurDelayCounter = 0;
        Image[] mRabbits = new Image[] { rcFind.rabbit1,rcFind.rabbit2};
        Random R = new Random();

        public Form1()
        {
            InitializeComponent();
            List<string> L = new List<string>();
            L.Add("YYYY");
            L.Add("MM");
            L.Add("DD");

            List<string> R = MixList<string>(L);

            for (int i = 0; i < R.Count; i++)
                mDate += R[i];
            
            string M = DateTime.Now.Month.ToString();
            if (M.Length == 1) M = "0" + M;
            string D = DateTime.Now.Day.ToString();
            if (D.Length == 1) D = "0" + D;
            mDateResult = mDate.Replace("YYYY", DateTime.Now.Year.ToString());
            mDateResult = mDateResult.Replace("MM", M);
            mDateResult = mDateResult.Replace("DD", D);

            txtDate.Text = "";
            label1.Text = mDate;

            tmrWait.Enabled = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Program.MinDelayCountCur < Program.MinDelayCountMax)
                {
                    ShowPanel();
                    pbRabbit.Visible = true;
                }
                
            }
        }
        void ShowPanel()
        {
            pbRabbit.Image = mRabbits[R.Next(mRabbits.Length)];
            pbRabbit.Left = R.Next(Width - gbMain.Width);
            pbRabbit.Top = R.Next(Height - gbMain.Height);

            pbRabbit.Visible = true;
        }
        private void txtDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDate.Text == mDateResult)
                {
                    Program.MinDelayCountCur=0;
                    Program.StartDelay(Program.BigDelay);
                    Close();
                }
                else
                {
                    txtDate.Text = "";
                }
            }
        }

        private List<E> MixList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }

        void DelaySmall()
        {
            if (mCurDelayCounter == 10)
            {
                Program.MinDelayCountCur++;
                Program.StartDelay(Program.MinDelay);
                Close();
            }
            else
            {
                mCurDelayCounter++;
                ShowPanel();
            }
        }
        private void tmrWait_Tick(object sender, EventArgs e)
        {
            if (mCurWait >= Program.WaitDelay)
            {
                tmrWait.Enabled = false;
                label1.Visible = txtDate.Visible = true;
                mCurWait = 0;
                gbMain.Visible = true;

                txtDate.Text = "";
                txtDate.Focus();
                return;
            }
            mCurWait++;
        }

        private void pbRabbit_Click(object sender, EventArgs e)
        {
            DelaySmall();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
    }
}
