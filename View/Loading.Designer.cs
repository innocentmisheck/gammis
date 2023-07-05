namespace gammis
{
    partial class Loading
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.bunifuColorTransitionLoading = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
            this.BunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.BunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuColorTransitionLoading
            // 
            this.bunifuColorTransitionLoading.AutoTransition = true;
            this.bunifuColorTransitionLoading.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(97)))), ((int)(((byte)(252))))),
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(97)))), ((int)(((byte)(252)))))};
            this.bunifuColorTransitionLoading.EndColor = System.Drawing.Color.White;
            this.bunifuColorTransitionLoading.Interval = 5;
            this.bunifuColorTransitionLoading.ProgessValue = 0;
            this.bunifuColorTransitionLoading.StartColor = System.Drawing.Color.White;
            this.bunifuColorTransitionLoading.TransitionControl = this;
            // 
            // BunifuLoader1
            // 
            this.BunifuLoader1.AllowStylePresets = true;
            this.BunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.BunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Flat;
            this.BunifuLoader1.Color = System.Drawing.Color.DodgerBlue;
            this.BunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.BunifuLoader1.Customization = "";
            this.BunifuLoader1.DashWidth = 0.5F;
            this.BunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BunifuLoader1.Image = null;
            this.BunifuLoader1.Location = new System.Drawing.Point(636, 546);
            this.BunifuLoader1.Name = "BunifuLoader1";
            this.BunifuLoader1.NoRounding = false;
            this.BunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Dashed;
            this.BunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Dashed;
            this.BunifuLoader1.ShowText = false;
            this.BunifuLoader1.Size = new System.Drawing.Size(100, 100);
            this.BunifuLoader1.Speed = 10;
            this.BunifuLoader1.TabIndex = 1;
            this.BunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.BunifuLoader1.Thickness = 10;
            this.BunifuLoader1.Transparent = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BunifuPictureBox2
            // 
            this.BunifuPictureBox2.AllowFocused = false;
            this.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BunifuPictureBox2.AutoSizeHeight = false;
            this.BunifuPictureBox2.BorderRadius = 45;
            this.BunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("BunifuPictureBox2.Image")));
            this.BunifuPictureBox2.IsCircle = true;
            this.BunifuPictureBox2.Location = new System.Drawing.Point(17, 659);
            this.BunifuPictureBox2.Name = "BunifuPictureBox2";
            this.BunifuPictureBox2.Size = new System.Drawing.Size(90, 90);
            this.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuPictureBox2.TabIndex = 2;
            this.BunifuPictureBox2.TabStop = false;
            this.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MessageTopMargin = 0;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // BunifuPictureBox1
            // 
            this.BunifuPictureBox1.AllowFocused = false;
            this.BunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BunifuPictureBox1.AutoSizeHeight = false;
            this.BunifuPictureBox1.BorderRadius = 100;
            this.BunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("BunifuPictureBox1.Image")));
            this.BunifuPictureBox1.IsCircle = false;
            this.BunifuPictureBox1.Location = new System.Drawing.Point(312, 24);
            this.BunifuPictureBox1.Name = "BunifuPictureBox1";
            this.BunifuPictureBox1.Size = new System.Drawing.Size(741, 496);
            this.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuPictureBox1.TabIndex = 0;
            this.BunifuPictureBox1.TabStop = false;
            this.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(174)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.BunifuPictureBox2);
            this.Controls.Add(this.BunifuLoader1);
            this.Controls.Add(this.BunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gammis | Loading";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BunifuPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuColorTransition bunifuColorTransitionLoading;
        private Bunifu.UI.WinForms.BunifuLoader BunifuLoader1;
        private Bunifu.UI.WinForms.BunifuPictureBox BunifuPictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuPictureBox BunifuPictureBox1;
    }
}

