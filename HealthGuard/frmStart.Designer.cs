namespace HealthGuard
{
    partial class frmStart
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
			this.NI = new System.Windows.Forms.NotifyIcon(this.components);
			this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsbSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbTest = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbExt = new System.Windows.Forms.ToolStripMenuItem();

			this.CMS.SuspendLayout();
			this.SuspendLayout();
			// 
			// NI
			// 
			this.NI.ContextMenuStrip = this.CMS;
			this.NI.Icon = ((System.Drawing.Icon)(resources.GetObject("NI.Icon")));
			this.NI.Visible = true;
			// 
			// CMS
			// 
			this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.tsbSettings,
				this.tsbTest,
				this.tsbExt});
			this.CMS.Name = "CMS";
			this.CMS.Size = new System.Drawing.Size(117, 48);
			this.CMS.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_Opening);
			this.CMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMS_ItemClicked);
			// 
			// tsbSettings
			// 
			this.tsbSettings.Name = "tsbSettings";
			this.tsbSettings.Size = new System.Drawing.Size(116, 22);
			this.tsbSettings.Text = "Settings";
			// 
			// tsbExt
			// 
			this.tsbExt.Name = "tsbExt";
			this.tsbExt.Size = new System.Drawing.Size(116, 22);
			this.tsbExt.Text = "Exit";

			// 
			// tsbTest 
			// 
			this.tsbTest.Name = "tsbTest";
			this.tsbTest.Size = new System.Drawing.Size(116, 22);
			this.tsbTest.Text = "Test";
			// 
			// frmStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1, 1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmStart";
			this.ShowInTaskbar = false;
			this.Text = "frmStart";
			this.Activated += new System.EventHandler(this.frmStart_Activated);
			this.Load += new System.EventHandler(this.frmStart_Load);
			this.CMS.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NI;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem tsbSettings;
        private System.Windows.Forms.ToolStripMenuItem tsbExt;
		private System.Windows.Forms.ToolStripMenuItem tsbTest;
    }
}