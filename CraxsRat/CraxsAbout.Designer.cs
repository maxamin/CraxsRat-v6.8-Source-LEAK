﻿namespace Craxs_Rat
{
	// Token: 0x0200003C RID: 60
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CraxsAbout : global::System.Windows.Forms.Form
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x00024FFC File Offset: 0x000231FC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					((global::System.IDisposable)this.components).Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00025040 File Offset: 0x00023240
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Craxs_Rat.CraxsAbout));
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.PictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.PictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.PictureBox5 = new global::System.Windows.Forms.PictureBox();
			this.PictureBox6 = new global::System.Windows.Forms.PictureBox();
			this.subtext = new global::DrakeUI.Framework.DrakeUITextBox();
			this.bdytext = new global::DrakeUI.Framework.DrakeUITextBox();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.TabPage3 = new global::System.Windows.Forms.TabPage();
			this.logupdate = new global::System.Windows.Forms.TextBox();
			this.updatbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.checkupdatbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.TabPage4 = new global::System.Windows.Forms.TabPage();
			this.LogBrowser = new global::System.Windows.Forms.WebBrowser();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.reqbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			global::System.Windows.Forms.Button button = new global::System.Windows.Forms.Button();
			button.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			button.BackColor = global::System.Drawing.Color.Transparent;
			button.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			button.Cursor = global::System.Windows.Forms.Cursors.Hand;
			button.FlatAppearance.BorderSize = 0;
			button.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			button.Font = new global::System.Drawing.Font("Segoe UI", 22f, global::System.Drawing.FontStyle.Bold);
			button.ForeColor = global::System.Drawing.Color.Red;
			button.Location = new global::System.Drawing.Point(950, 2);
			button.Margin = new global::System.Windows.Forms.Padding(2);
			button.Name = "closeButton";
			button.Size = new global::System.Drawing.Size(50, 55);
			button.TabIndex = 35;
			button.Text = "×";
			button.UseVisualStyleBackColor = false;
			button.Click += delegate(object sender, global::System.EventArgs e)
			{
				this.Close();
			};
			global::System.Windows.Forms.Button button2 = new global::System.Windows.Forms.Button();
			global::System.Windows.Forms.Button button3 = new global::System.Windows.Forms.Button();
			global::System.Windows.Forms.Button button4 = new global::System.Windows.Forms.Button();
			button2.Text = "About";
			button2.ForeColor = global::System.Drawing.Color.White;
			button2.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button2.FlatAppearance.BorderSize = 1;
			button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new global::System.Drawing.Font(button2.Font, global::System.Drawing.FontStyle.Regular);
			button2.Size = new global::System.Drawing.Size(160, 50);
			button2.Location = new global::System.Drawing.Point(10, 10);
			button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			button3.Text = "History";
			button3.ForeColor = global::System.Drawing.Color.White;
			button3.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			button3.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button3.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button3.FlatAppearance.BorderSize = 1;
			button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			button3.Font = new global::System.Drawing.Font(button3.Font, global::System.Drawing.FontStyle.Regular);
			button3.Size = new global::System.Drawing.Size(160, 50);
			button3.Location = new global::System.Drawing.Point(160, 10);
			button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			button4.Text = "Report";
			button4.ForeColor = global::System.Drawing.Color.White;
			button4.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			button4.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button4.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 3, 10);
			button4.FlatAppearance.BorderSize = 1;
			button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			button4.Font = new global::System.Drawing.Font(button4.Font, global::System.Drawing.FontStyle.Regular);
			button4.Size = new global::System.Drawing.Size(160, 50);
			button4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			button4.Location = new global::System.Drawing.Point(310, 10);
			button2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			button3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			button4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			button2.Font = new global::System.Drawing.Font(button2.Font.FontFamily, 12f);
			button3.Font = new global::System.Drawing.Font(button3.Font.FontFamily, 12f);
			button4.Font = new global::System.Drawing.Font(button4.Font.FontFamily, 12f);
			this.Panel1.Controls.Add(button2);
			this.Panel1.Controls.Add(button3);
			this.Panel1.Controls.Add(button4);
			global::System.Windows.Forms.Panel panelAbout = new global::System.Windows.Forms.Panel();
			panelAbout.Name = "panelAbout";
			panelAbout.BackColor = global::System.Drawing.Color.Transparent;
			panelAbout.Dock = global::System.Windows.Forms.DockStyle.Fill;
			panelAbout.Size = new global::System.Drawing.Size(1000, 600);
			panelAbout.Location = new global::System.Drawing.Point(0, 0);
			panelAbout.Visible = true;
			panelAbout.Controls.Add(this.PictureBox2);
			panelAbout.Controls.Add(this.Label2);
			panelAbout.Controls.Add(this.checkupdatbtn);
			panelAbout.Controls.Add(this.Panel2);
			global::System.Windows.Forms.Panel panelHistory = new global::System.Windows.Forms.Panel();
			panelHistory.Name = "panelHistory";
			panelHistory.BackColor = global::System.Drawing.Color.Transparent;
			panelHistory.Size = new global::System.Drawing.Size(1000, 600);
			panelHistory.Location = new global::System.Drawing.Point(0, 0);
			panelHistory.Dock = global::System.Windows.Forms.DockStyle.Fill;
			panelHistory.Visible = false;
			panelHistory.Controls.Add(this.LogBrowser);
			global::System.Windows.Forms.Panel panelReport = new global::System.Windows.Forms.Panel();
			panelReport.Name = "panelReport";
			panelReport.BackColor = global::System.Drawing.Color.Transparent;
			panelReport.Size = new global::System.Drawing.Size(1000, 600);
			panelReport.Location = new global::System.Drawing.Point(0, 0);
			panelReport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			panelReport.Visible = false;
			panelReport.Controls.Add(this.reqbtn);
			panelReport.Controls.Add(this.Label7);
			panelReport.Controls.Add(this.bdytext);
			panelReport.Controls.Add(this.Label6);
			panelReport.Controls.Add(this.subtext);
			panelReport.Controls.Add(this.Label5);
			button2.Click += delegate(object sender, global::System.EventArgs e)
			{
				panelAbout.Visible = true;
				panelHistory.Visible = false;
				panelReport.Visible = false;
			};
			button3.Click += delegate(object sender, global::System.EventArgs e)
			{
				panelAbout.Visible = false;
				panelHistory.Visible = true;
				panelReport.Visible = false;
			};
			button4.Click += delegate(object sender, global::System.EventArgs e)
			{
				panelAbout.Visible = false;
				panelHistory.Visible = false;
				panelReport.Visible = true;
			};
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox6).BeginInit();
			this.TabPage1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			panelAbout.SuspendLayout();
			panelHistory.SuspendLayout();
			panelReport.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.TabPage2.SuspendLayout();
			base.SuspendLayout();
			this.PictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.PictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBoxGift2.Image");
			this.PictureBox2.Location = new global::System.Drawing.Point(445, 50);
			this.PictureBox2.Margin = new global::System.Windows.Forms.Padding(4);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new global::System.Drawing.Size(269, 230);
			this.PictureBox2.TabIndex = 9;
			this.PictureBox2.TabStop = false;
			this.PictureBox2.Dock = global::System.Windows.Forms.DockStyle.None;
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Black;
			this.Label3.Font = new global::System.Drawing.Font("Candara", 60f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Label3.Location = new global::System.Drawing.Point(396, 105);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(456, 122);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Craxs Rat";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Bold);
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Label1.Location = new global::System.Drawing.Point(543, 241);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(288, 24);
			this.Label1.TabIndex = 19;
			this.Label1.Text = "Advanced Android Remote Tool";
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.None;
			this.Label2.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Label2.Location = new global::System.Drawing.Point(330, 300);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(500, 30);
			this.Label2.TabIndex = 20;
			this.Label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			global::System.Windows.Forms.Label label = new global::System.Windows.Forms.Label();
			label.Text = "Site";
			label.ForeColor = global::System.Drawing.Color.Red;
			label.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			label.Size = new global::System.Drawing.Size(200, 20);
			label.Location = new global::System.Drawing.Point(35, 200);
			label.Dock = global::System.Windows.Forms.DockStyle.None;
			global::System.Windows.Forms.Label label2 = new global::System.Windows.Forms.Label();
			label2.Text = "FaceBook";
			label2.ForeColor = global::System.Drawing.Color.Red;
			label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			label2.Size = new global::System.Drawing.Size(200, 20);
			label2.Location = new global::System.Drawing.Point(250, 200);
			label2.Dock = global::System.Windows.Forms.DockStyle.None;
			global::System.Windows.Forms.Label label3 = new global::System.Windows.Forms.Label();
			label3.Text = "Twitter";
			label3.ForeColor = global::System.Drawing.Color.Red;
			label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			label3.Size = new global::System.Drawing.Size(200, 20);
			label3.Location = new global::System.Drawing.Point(540, 200);
			label3.Dock = global::System.Windows.Forms.DockStyle.None;
			global::System.Windows.Forms.Label label4 = new global::System.Windows.Forms.Label();
			label4.Text = "Telegram";
			label4.ForeColor = global::System.Drawing.Color.Red;
			label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			label4.Size = new global::System.Drawing.Size(200, 20);
			label4.Location = new global::System.Drawing.Point(760, 200);
			label4.Dock = global::System.Windows.Forms.DockStyle.None;
			global::System.Windows.Forms.Label label5 = new global::System.Windows.Forms.Label();
			label5.Text = "Support";
			label5.ForeColor = global::System.Drawing.Color.Red;
			label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			label5.Size = new global::System.Drawing.Size(200, 20);
			label5.Location = new global::System.Drawing.Point(910, 200);
			label5.Dock = global::System.Windows.Forms.DockStyle.None;
			this.PictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(80, 100);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(100, 100);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 22;
			this.PictureBox1.TabStop = false;
			this.PictureBox3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox5.Image");
			this.PictureBox3.Location = new global::System.Drawing.Point(300, 100);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new global::System.Drawing.Size(100, 100);
			this.PictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox3.TabIndex = 23;
			this.PictureBox3.TabStop = false;
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.PictureBox4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox6.Image");
			this.PictureBox4.Location = new global::System.Drawing.Point(520, 100);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new global::System.Drawing.Size(100, 100);
			this.PictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox4.TabIndex = 24;
			this.PictureBox4.TabStop = false;
			this.PictureBox5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox3.Image");
			this.PictureBox5.Location = new global::System.Drawing.Point(740, 100);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new global::System.Drawing.Size(100, 100);
			this.PictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox5.TabIndex = 25;
			this.PictureBox5.TabStop = false;
			this.PictureBox6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("supportimage.jpg");
			this.PictureBox6.Location = new global::System.Drawing.Point(960, 100);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new global::System.Drawing.Size(100, 100);
			this.PictureBox6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox6.TabIndex = 26;
			this.PictureBox6.TabStop = false;
			this.subtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.subtext.FillColor = global::System.Drawing.Color.Black;
			this.subtext.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.subtext.ForeColor = global::System.Drawing.Color.White;
			this.subtext.Location = new global::System.Drawing.Point(170, 79);
			this.subtext.Margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.subtext.Maximum = 2147483647.0;
			this.subtext.MaxLength = 15;
			this.subtext.Minimum = -2147483648.0;
			this.subtext.Name = "subtext";
			this.subtext.Padding = new global::System.Windows.Forms.Padding(7, 6, 7, 6);
			this.subtext.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.subtext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.subtext.Size = new global::System.Drawing.Size(421, 30);
			this.subtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.subtext.TabIndex = 41;
			this.subtext.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.DrakeUIToolTip1.SetToolTip(this.subtext, "Max 15 letter");
			this.bdytext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.bdytext.FillColor = global::System.Drawing.Color.Black;
			this.bdytext.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.bdytext.ForeColor = global::System.Drawing.Color.White;
			this.bdytext.Location = new global::System.Drawing.Point(170, 142);
			this.bdytext.Margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.bdytext.Maximum = 2147483647.0;
			this.bdytext.MaxLength = 150;
			this.bdytext.Minimum = -2147483648.0;
			this.bdytext.Multiline = true;
			this.bdytext.Name = "bdytext";
			this.bdytext.Padding = new global::System.Windows.Forms.Padding(7, 6, 7, 6);
			this.bdytext.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.bdytext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.bdytext.Size = new global::System.Drawing.Size(670, 325);
			this.bdytext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.bdytext.TabIndex = 42;
			this.bdytext.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
			this.DrakeUIToolTip1.SetToolTip(this.bdytext, "Max 150 letter");
			this.TabPage1.BackColor = global::System.Drawing.Color.Black;
			this.TabPage1.Location = new global::System.Drawing.Point(201, 0);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new global::System.Drawing.Size(959, 634);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "About";
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Size = new global::System.Drawing.Size(1000, 70);
			this.Panel1.Name = "Panel1";
			this.Panel1.TabIndex = 27;
			this.Panel1.Controls.Add(button);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Controls.Add(this.PictureBox5);
			this.Panel2.Controls.Add(this.PictureBox6);
			this.Panel2.Controls.Add(this.PictureBox3);
			this.Panel2.Controls.Add(this.PictureBox4);
			this.Panel2.Controls.Add(label);
			this.Panel2.Controls.Add(label2);
			this.Panel2.Controls.Add(label3);
			this.Panel2.Controls.Add(label4);
			this.Panel2.Controls.Add(label5);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Size = new global::System.Drawing.Size(1100, 300);
			this.Panel2.Name = "Panel2";
			this.Panel2.TabIndex = 27;
			this.TabPage3.BackColor = global::System.Drawing.Color.Black;
			this.TabPage3.Controls.Add(this.logupdate);
			this.TabPage3.Controls.Add(this.updatbtn);
			this.TabPage3.Location = new global::System.Drawing.Point(201, 0);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new global::System.Drawing.Size(935, 618);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Update";
			this.logupdate.BackColor = global::System.Drawing.Color.Black;
			this.logupdate.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.logupdate.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.logupdate.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.logupdate.Location = new global::System.Drawing.Point(0, 110);
			this.logupdate.Multiline = true;
			this.logupdate.Name = "logupdate";
			this.logupdate.ReadOnly = true;
			this.logupdate.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.logupdate.Size = new global::System.Drawing.Size(935, 508);
			this.logupdate.TabIndex = 47;
			this.logupdate.WordWrap = false;
			this.updatbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.updatbtn.Enabled = false;
			this.updatbtn.FillColor = global::System.Drawing.Color.Black;
			this.updatbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.updatbtn.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.updatbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.updatbtn.Location = new global::System.Drawing.Point(229, 22);
			this.updatbtn.Name = "updatbtn";
			this.updatbtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.updatbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.updatbtn.Size = new global::System.Drawing.Size(171, 45);
			this.updatbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.updatbtn.TabIndex = 46;
			this.updatbtn.Text = "Start Update";
			this.checkupdatbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkupdatbtn.FillColor = global::System.Drawing.Color.Black;
			this.checkupdatbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.checkupdatbtn.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.checkupdatbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.checkupdatbtn.Location = new global::System.Drawing.Point(900, 300);
			this.checkupdatbtn.Name = "checkupdatbtn";
			this.checkupdatbtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.checkupdatbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.checkupdatbtn.Size = new global::System.Drawing.Size(171, 45);
			this.checkupdatbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.checkupdatbtn.Symbol = 61473;
			this.checkupdatbtn.TabIndex = 45;
			this.checkupdatbtn.Text = "Check update";
			this.TabPage4.BackColor = global::System.Drawing.Color.Black;
			this.TabPage4.Location = new global::System.Drawing.Point(201, 0);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Size = new global::System.Drawing.Size(935, 618);
			this.TabPage4.TabIndex = 3;
			this.TabPage4.Text = "Change Log";
			this.LogBrowser.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LogBrowser.Location = new global::System.Drawing.Point(0, 0);
			this.LogBrowser.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.LogBrowser.Name = "LogBrowser";
			this.LogBrowser.Size = new global::System.Drawing.Size(935, 618);
			this.LogBrowser.TabIndex = 0;
			this.TabPage2.BackColor = global::System.Drawing.Color.Black;
			this.TabPage2.Location = new global::System.Drawing.Point(201, 0);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new global::System.Drawing.Size(935, 618);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Report";
			this.reqbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.reqbtn.FillColor = global::System.Drawing.Color.Black;
			this.reqbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.reqbtn.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.reqbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.reqbtn.Location = new global::System.Drawing.Point(714, 476);
			this.reqbtn.Name = "reqbtn";
			this.reqbtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.reqbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.reqbtn.Size = new global::System.Drawing.Size(126, 45);
			this.reqbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.reqbtn.Symbol = 61913;
			this.reqbtn.TabIndex = 44;
			this.reqbtn.Text = "Send";
			this.Label7.AutoSize = true;
			this.Label7.BackColor = global::System.Drawing.Color.Transparent;
			this.Label7.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Bold);
			this.Label7.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Label7.Location = new global::System.Drawing.Point(261, 9);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(396, 24);
			this.Label7.TabIndex = 43;
			this.Label7.Text = "Please Send only feedback and report bugs";
			this.Label6.AutoSize = true;
			this.Label6.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Label6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Label6.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Label6.Location = new global::System.Drawing.Point(42, 142);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(111, 24);
			this.Label6.TabIndex = 42;
			this.Label6.Tag = "1";
			this.Label6.Text = "Description";
			this.Label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Label5.AutoSize = true;
			this.Label5.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.Label5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Label5.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Label5.Location = new global::System.Drawing.Point(42, 77);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(77, 24);
			this.Label5.TabIndex = 40;
			this.Label5.Tag = "1";
			this.Label5.Text = "Subject";
			this.Label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1160, 634);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(panelAbout);
			base.Controls.Add(panelHistory);
			base.Controls.Add(panelReport);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "CraxsAbout";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CraxsAbout";
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox6).EndInit();
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			panelAbout.ResumeLayout(false);
			panelHistory.ResumeLayout(false);
			panelReport.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.TabPage4.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001E9 RID: 489
		private global::System.ComponentModel.Container components;
	}
}
