using openmenuAuto.Properties;
using idaaxopenmenu.Properties;

namespace openmenuAuto
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002FA4 File Offset: 0x000011A4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002FDC File Offset: 0x000011DC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.readhello = new System.ComponentModel.BackgroundWorker();
            this.readhello_1 = new System.ComponentModel.BackgroundWorker();
            this.fmioff = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.productlb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneProgressBar1 = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.statuslb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.udidlb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.ioslb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.seriallb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.modellb = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.button = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.picDevice = new System.Windows.Forms.PictureBox();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel9 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel10 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.gbUsed = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.gbTotal = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fmioff
            // 
            this.fmioff.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fmioff_DoWork);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderColor = System.Drawing.Color.White;
            this.siticoneControlBox1.BorderRadius = 3;
            this.siticoneControlBox1.BorderThickness = 2;
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.MintCream;
            this.siticoneControlBox1.Location = new System.Drawing.Point(625, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(20, 19);
            this.siticoneControlBox1.TabIndex = 511;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click_1);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.BorderColor = System.Drawing.Color.White;
            this.siticoneControlBox2.BorderRadius = 5;
            this.siticoneControlBox2.BorderThickness = 2;
            this.siticoneControlBox2.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(599, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(20, 19);
            this.siticoneControlBox2.TabIndex = 512;
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel7.IsSelectionEnabled = false;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(247, 97);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(56, 19);
            this.siticoneHtmlLabel7.TabIndex = 544;
            this.siticoneHtmlLabel7.Text = "MODEL : ";
            // 
            // productlb
            // 
            this.productlb.BackColor = System.Drawing.Color.Transparent;
            this.productlb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlb.ForeColor = System.Drawing.Color.White;
            this.productlb.IsSelectionEnabled = false;
            this.productlb.Location = new System.Drawing.Point(341, 194);
            this.productlb.Name = "productlb";
            this.productlb.Size = new System.Drawing.Size(60, 19);
            this.productlb.TabIndex = 543;
            this.productlb.Text = "No Device";
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel6.IsSelectionEnabled = false;
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(248, 194);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(67, 18);
            this.siticoneHtmlLabel6.TabIndex = 542;
            this.siticoneHtmlLabel6.Text = "PRODUCT : ";
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneProgressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneProgressBar1.BorderRadius = 5;
            this.siticoneProgressBar1.FillColor = System.Drawing.Color.Gray;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(189, 327);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.siticoneProgressBar1.ProgressColor2 = System.Drawing.Color.MediumSeaGreen;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(456, 12);
            this.siticoneProgressBar1.TabIndex = 541;
            this.siticoneProgressBar1.Text = "progressbar";
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // statuslb
            // 
            this.statuslb.BackColor = System.Drawing.Color.Transparent;
            this.statuslb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslb.ForeColor = System.Drawing.Color.White;
            this.statuslb.IsSelectionEnabled = false;
            this.statuslb.Location = new System.Drawing.Point(335, 345);
            this.statuslb.Name = "statuslb";
            this.statuslb.Size = new System.Drawing.Size(182, 19);
            this.statuslb.TabIndex = 539;
            this.statuslb.Text = "Please Connect Your Device First ";
            // 
            // udidlb
            // 
            this.udidlb.BackColor = System.Drawing.Color.Transparent;
            this.udidlb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udidlb.ForeColor = System.Drawing.Color.White;
            this.udidlb.IsSelectionEnabled = false;
            this.udidlb.Location = new System.Drawing.Point(341, 169);
            this.udidlb.Name = "udidlb";
            this.udidlb.Size = new System.Drawing.Size(60, 19);
            this.udidlb.TabIndex = 538;
            this.udidlb.Text = "No Device";
            this.udidlb.Click += new System.EventHandler(this.udidlb_Click_1);
            // 
            // ioslb
            // 
            this.ioslb.BackColor = System.Drawing.Color.Transparent;
            this.ioslb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ioslb.ForeColor = System.Drawing.Color.White;
            this.ioslb.IsSelectionEnabled = false;
            this.ioslb.Location = new System.Drawing.Point(341, 145);
            this.ioslb.Name = "ioslb";
            this.ioslb.Size = new System.Drawing.Size(60, 19);
            this.ioslb.TabIndex = 537;
            this.ioslb.Text = "No Device";
            // 
            // seriallb
            // 
            this.seriallb.BackColor = System.Drawing.Color.Transparent;
            this.seriallb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriallb.ForeColor = System.Drawing.Color.White;
            this.seriallb.IsSelectionEnabled = false;
            this.seriallb.Location = new System.Drawing.Point(341, 120);
            this.seriallb.Name = "seriallb";
            this.seriallb.Size = new System.Drawing.Size(60, 19);
            this.seriallb.TabIndex = 536;
            this.seriallb.Text = "No Device";
            this.seriallb.Click += new System.EventHandler(this.seriallb_Click);
            // 
            // modellb
            // 
            this.modellb.BackColor = System.Drawing.Color.Transparent;
            this.modellb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modellb.ForeColor = System.Drawing.Color.White;
            this.modellb.IsSelectionEnabled = false;
            this.modellb.Location = new System.Drawing.Point(341, 97);
            this.modellb.Name = "modellb";
            this.modellb.Size = new System.Drawing.Size(60, 19);
            this.modellb.TabIndex = 535;
            this.modellb.Text = "No Device";
            // 
            // button
            // 
            this.button.AutoRoundedCorners = true;
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BorderColor = System.Drawing.Color.Silver;
            this.button.BorderRadius = 18;
            this.button.CustomizableEdges.BottomLeft = false;
            this.button.CustomizableEdges.BottomRight = false;
            this.button.CustomizableEdges.TopLeft = false;
            this.button.CustomizableEdges.TopRight = false;
            this.button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button.Enabled = false;
            this.button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(10)))), ((int)(((byte)(110)))));
            this.button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(10)))), ((int)(((byte)(110)))));
            this.button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(189, 231);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(228, 38);
            this.button.TabIndex = 534;
            this.button.Text = "FMI-OFF 🔓";
            this.button.Click += new System.EventHandler(this.button_Click_1);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel5.IsSelectionEnabled = false;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(247, 120);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(54, 19);
            this.siticoneHtmlLabel5.TabIndex = 533;
            this.siticoneHtmlLabel5.Text = "SERIAL : ";
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel4.IsSelectionEnabled = false;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(249, 145);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(29, 19);
            this.siticoneHtmlLabel4.TabIndex = 532;
            this.siticoneHtmlLabel4.Text = "iOS : ";
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel3.IsSelectionEnabled = false;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(248, 170);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(39, 18);
            this.siticoneHtmlLabel3.TabIndex = 531;
            this.siticoneHtmlLabel3.Text = "UDID : ";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.IsSelectionEnabled = false;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(189, 4);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(281, 33);
            this.siticoneHtmlLabel1.TabIndex = 546;
            this.siticoneHtmlLabel1.Text = "Idaax Open Menu V1.0";
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // picDevice
            // 
            this.picDevice.BackColor = System.Drawing.Color.Transparent;
            this.picDevice.Location = new System.Drawing.Point(3, 13);
            this.picDevice.Name = "picDevice";
            this.picDevice.Size = new System.Drawing.Size(180, 326);
            this.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDevice.TabIndex = 530;
            this.picDevice.TabStop = false;
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.AutoRoundedCorners = true;
            this.siticoneGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.BorderColor = System.Drawing.Color.Silver;
            this.siticoneGradientButton1.BorderRadius = 18;
            this.siticoneGradientButton1.CustomizableEdges.BottomLeft = false;
            this.siticoneGradientButton1.CustomizableEdges.BottomRight = false;
            this.siticoneGradientButton1.CustomizableEdges.TopLeft = false;
            this.siticoneGradientButton1.CustomizableEdges.TopRight = false;
            this.siticoneGradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton1.Enabled = false;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(417, 231);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.Size = new System.Drawing.Size(228, 38);
            this.siticoneGradientButton1.TabIndex = 547;
            this.siticoneGradientButton1.Text = "REMOVE PASSWORD 🔓";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click_2);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(189, 275);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(456, 46);
            this.richTextBox1.TabIndex = 548;
            this.richTextBox1.Text = "Delete all apps, pictures, videos on iPhone\nOff Turn on Game Center 2-3 times the" +
    "n click start.\nif you have already backup passord please remove it.\n";
            // 
            // siticoneHtmlLabel8
            // 
            this.siticoneHtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel8.IsSelectionEnabled = false;
            this.siticoneHtmlLabel8.Location = new System.Drawing.Point(472, 97);
            this.siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            this.siticoneHtmlLabel8.Size = new System.Drawing.Size(90, 19);
            this.siticoneHtmlLabel8.TabIndex = 549;
            this.siticoneHtmlLabel8.Text = "PW Backup: 123";
            // 
            // siticoneHtmlLabel9
            // 
            this.siticoneHtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel9.IsSelectionEnabled = false;
            this.siticoneHtmlLabel9.Location = new System.Drawing.Point(472, 145);
            this.siticoneHtmlLabel9.Name = "siticoneHtmlLabel9";
            this.siticoneHtmlLabel9.Size = new System.Drawing.Size(53, 19);
            this.siticoneHtmlLabel9.TabIndex = 550;
            this.siticoneHtmlLabel9.Text = "Capacity: ";
            // 
            // siticoneHtmlLabel10
            // 
            this.siticoneHtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel10.IsSelectionEnabled = false;
            this.siticoneHtmlLabel10.Location = new System.Drawing.Point(584, 145);
            this.siticoneHtmlLabel10.Name = "siticoneHtmlLabel10";
            this.siticoneHtmlLabel10.Size = new System.Drawing.Size(7, 19);
            this.siticoneHtmlLabel10.TabIndex = 551;
            this.siticoneHtmlLabel10.Text = "/";
            this.siticoneHtmlLabel10.Click += new System.EventHandler(this.siticoneHtmlLabel10_Click);
            // 
            // gbUsed
            // 
            this.gbUsed.BackColor = System.Drawing.Color.Transparent;
            this.gbUsed.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.gbUsed.ForeColor = System.Drawing.Color.White;
            this.gbUsed.IsSelectionEnabled = false;
            this.gbUsed.Location = new System.Drawing.Point(531, 145);
            this.gbUsed.Name = "gbUsed";
            this.gbUsed.Size = new System.Drawing.Size(3, 2);
            this.gbUsed.TabIndex = 552;
            this.gbUsed.Text = null;
            this.gbUsed.Click += new System.EventHandler(this.siticoneHtmlLabel11_Click);
            // 
            // gbTotal
            // 
            this.gbTotal.BackColor = System.Drawing.Color.Transparent;
            this.gbTotal.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.gbTotal.ForeColor = System.Drawing.Color.White;
            this.gbTotal.IsSelectionEnabled = false;
            this.gbTotal.Location = new System.Drawing.Point(601, 145);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(3, 2);
            this.gbTotal.TabIndex = 553;
            this.gbTotal.Text = null;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(346, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 13);
            this.linkLabel1.TabIndex = 554;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check FMI";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.IsSelectionEnabled = false;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(472, 193);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(83, 19);
            this.siticoneHtmlLabel2.TabIndex = 556;
            this.siticoneHtmlLabel2.Text = "Time Elapsing:";
            this.siticoneHtmlLabel2.Click += new System.EventHandler(this.siticoneHtmlLabel2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.IsSelectionEnabled = false;
            this.label1.Location = new System.Drawing.Point(559, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 557;
            this.label1.Text = "00:00:00";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(12, 345);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(114, 20);
            this.linkLabel2.TabIndex = 558;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "idaaxtools.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(598, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 559;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbUsed);
            this.Controls.Add(this.siticoneHtmlLabel10);
            this.Controls.Add(this.siticoneHtmlLabel9);
            this.Controls.Add(this.siticoneHtmlLabel8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.siticoneHtmlLabel7);
            this.Controls.Add(this.productlb);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.siticoneProgressBar1);
            this.Controls.Add(this.statuslb);
            this.Controls.Add(this.udidlb);
            this.Controls.Add(this.ioslb);
            this.Controls.Add(this.seriallb);
            this.Controls.Add(this.modellb);
            this.Controls.Add(this.button);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.picDevice);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Idaax OpenMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000D RID: 13
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.BackgroundWorker readhello;
        private global::System.ComponentModel.BackgroundWorker readhello_1;
        // Token: 0x0400000F RID: 15
        private global::System.ComponentModel.BackgroundWorker fmioff;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000011 RID: 17
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000012 RID: 18
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000013 RID: 19
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;

		// Token: 0x04000014 RID: 20
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel productlb;

		// Token: 0x04000015 RID: 21
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;

		// Token: 0x04000016 RID: 22
		private global::Siticone.Desktop.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;

		// Token: 0x04000018 RID: 24
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel statuslb;

		// Token: 0x04000019 RID: 25
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel udidlb;

		// Token: 0x0400001A RID: 26
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel ioslb;

		// Token: 0x0400001B RID: 27
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel seriallb;

		// Token: 0x0400001C RID: 28
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel modellb;

		// Token: 0x0400001D RID: 29
		private global::Siticone.Desktop.UI.WinForms.SiticoneGradientButton button;

		// Token: 0x0400001E RID: 30
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;

		// Token: 0x0400001F RID: 31
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;

		// Token: 0x04000020 RID: 32
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;

		// Token: 0x04000022 RID: 34
		private global::Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.PictureBox picDevice;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel9;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel10;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel gbUsed;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel gbTotal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
