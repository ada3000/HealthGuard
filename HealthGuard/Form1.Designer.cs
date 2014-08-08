namespace HealthGuard
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.gbMain = new System.Windows.Forms.Panel();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrWait = new System.Windows.Forms.Timer(this.components);
			this.pbRabbit = new System.Windows.Forms.PictureBox();
			this.gbMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbRabbit)).BeginInit();
			this.SuspendLayout();
			// 
			// gbMain
			// 
			this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.gbMain.Controls.Add(this.txtDate);
			this.gbMain.Controls.Add(this.label1);
			this.gbMain.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbMain.Location = new System.Drawing.Point(321, 22);
			this.gbMain.Name = "gbMain";
			this.gbMain.Size = new System.Drawing.Size(200, 109);
			this.gbMain.TabIndex = 0;
			this.gbMain.Visible = false;
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(19, 49);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(167, 39);
			this.txtDate.TabIndex = 1;
			this.txtDate.Text = "20011285";
			this.txtDate.Visible = false;
			this.txtDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "YYYYMMDD";
			this.label1.Visible = false;
			// 
			// tmrWait
			// 
			this.tmrWait.Interval = 1000;
			this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
			// 
			// pbRabbit
			// 
			this.pbRabbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pbRabbit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbRabbit.Location = new System.Drawing.Point(245, 250);
			this.pbRabbit.Name = "pbRabbit";
			this.pbRabbit.Size = new System.Drawing.Size(64, 64);
			this.pbRabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbRabbit.TabIndex = 1;
			this.pbRabbit.TabStop = false;
			this.pbRabbit.Visible = false;
			this.pbRabbit.Click += new System.EventHandler(this.pbRabbit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(533, 439);
			this.Controls.Add(this.pbRabbit);
			this.Controls.Add(this.gbMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Opacity = 0.9D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.gbMain.ResumeLayout(false);
			this.gbMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbRabbit)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Timer tmrWait;
        private System.Windows.Forms.PictureBox pbRabbit;

    }
}

