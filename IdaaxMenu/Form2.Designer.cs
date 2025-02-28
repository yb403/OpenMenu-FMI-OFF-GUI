namespace idaaxopenmenu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.changebtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.cancel = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.siticoneControlBox1.BorderRadius = 5;
            this.siticoneControlBox1.BorderThickness = 2;
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Crimson;
            this.siticoneControlBox1.Location = new System.Drawing.Point(197, 3);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(20, 19);
            this.siticoneControlBox1.TabIndex = 512;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // changebtn
            // 
            this.changebtn.AutoRoundedCorners = true;
            this.changebtn.BackColor = System.Drawing.Color.Transparent;
            this.changebtn.BorderColor = System.Drawing.Color.Silver;
            this.changebtn.BorderRadius = 18;
            this.changebtn.BorderThickness = 2;
            this.changebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changebtn.Enabled = false;
            this.changebtn.FillColor = System.Drawing.Color.Green;
            this.changebtn.FillColor2 = System.Drawing.Color.Green;
            this.changebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.changebtn.ForeColor = System.Drawing.Color.White;
            this.changebtn.Location = new System.Drawing.Point(21, 70);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(172, 38);
            this.changebtn.TabIndex = 535;
            this.changebtn.Text = "Remove Password 🔓";
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // cancel
            // 
            this.cancel.AutoRoundedCorners = true;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.BorderColor = System.Drawing.Color.Silver;
            this.cancel.BorderRadius = 18;
            this.cancel.BorderThickness = 2;
            this.cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancel.FillColor = System.Drawing.Color.Gray;
            this.cancel.FillColor2 = System.Drawing.Color.Gray;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(21, 114);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(172, 38);
            this.cancel.TabIndex = 536;
            this.cancel.Text = "Cancel 🔓";
            this.cancel.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 537;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 538;
            this.label1.Text = "Entre your Backup password:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton changebtn;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}