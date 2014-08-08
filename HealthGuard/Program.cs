using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace HealthGuard
{
	static class Program
	{
		public static bool YeysOpened = false;
		public static bool MainOpened = false;
		/// <summary>
		/// Интервал отображения глаз
		/// </summary>
		public static int YeysDelaySec = 0;
		/// <summary>
		/// ms
		/// </summary>
		public static int BigDelay = 3600000;
		/// <summary>
		/// ms
		/// </summary>
		public static int MinDelay = 300000;
		/// <summary>
		/// s
		/// </summary>
		public static int WaitDelay = 300;

		static int CurDelay = 10000;

		static Thread mthMain;
		static Thread mthYeys;

		static DateTime StartDate = DateTime.Now;
		static ManualResetEvent mEventStart = new ManualResetEvent(false);
		public static int MinDelayCountMax = 2;
		public static int MinDelayCountCur = 0;

		public static frmStart FMAIN;
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			CurDelay = BigDelay;

			LoadDayImage();

			mthMain = new Thread(Worker);
			mthMain.IsBackground = true;
			mthMain.Start();

			if (int.TryParse(System.Configuration.ConfigurationManager.AppSettings["ShowYeys"], out YeysDelaySec)
				&& YeysDelaySec > 0)
			{
				mthYeys = new Thread(YeyWorker);
				mthYeys.IsBackground = true;
				mthYeys.Start();
			}

			FMAIN = new frmStart();
			Application.Run(FMAIN);
		}
		private static void LoadDayImage()
		{
			var files = Directory.GetFiles(@".\fons").OrderBy(s=>s).ToArray();

			string img = files[DateTime.Now.DayOfYear % files.Length];
			MainBGImage = new Bitmap(img);
		}
		static void Worker()
		{
			while (true)
			{
				Thread.Sleep(CurDelay);
				mEventStart.Reset();
				try
				{
					while (Program.YeysOpened)
						Thread.Sleep(1000);

					DoEvent();
				}
				catch { }
				mEventStart.WaitOne();
			}
		}
		private static void YeyWorker()
		{
			while (true)
			{
				Thread.Sleep(YeysDelaySec * 1000);
				if (YeysOpened || MainOpened) continue;

				YeysOpened = true;

				FMAIN.ShowForm(new frmYeys());
				//Action d = new Action(ShowYesForm);
				//AsyncCallback ac = new AsyncCallback(ar => (ar.AsyncState as Action).EndInvoke(ar));
				//d.BeginInvoke(ac, d);
			}
		}
		public static void DoEvent()
		{
			MainOpened = true;

			FMAIN.ShowDelay();
		}
		/// <summary>
		/// Запуск монитора
		/// </summary>
		/// <param name="Delay">Задержка в милисекундах</param>
		public static void StartDelay(int Delay)
		{
			CurDelay = Delay;
			mEventStart.Set();
		}

		public static Image MainBGImage { get; private set; }
	}
}
